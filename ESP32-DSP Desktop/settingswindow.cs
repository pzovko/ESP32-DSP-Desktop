using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScottPlot;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Numerics;
using DSPLib;

namespace ESP32_DSP_Desktop
{
    public partial class settingswindow : Form
    {
        bool cbDomanStatus = true;
        DFT dft = new DFT();
        public settingswindow()
        {
            InitializeComponent();


            filterPlot.Plot.Style(Style.Gray1);
            filterPlot.Plot.Title("Time domain");
            filterPlot.Plot.SetAxisLimitsX(0, 20);
            filterPlot.Plot.XLabel("Time (s)");
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(0, 122,204), ButtonBorderStyle.Solid);
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            double fftLen = double.Parse(tbmFFTLen.Text);
            if ((Math.Log(fftLen, 2) % 1) != 0)
                MessageBox.Show("FFT len must be power of 2!", "Error");
            else
                Settings.FftSamples = (uint)fftLen;

            if (Settings.FilterCoeff.Count == 0)
                MessageBox.Show("No filter loaded", "Error");
        }

        private void btnLoadFIR_Click(object sender, EventArgs e)
        {
            openFilterCoef.ShowDialog();
        }

        private void openFilterCoef_FileOk(object sender, CancelEventArgs e)
        {
            string fileName;
            string fileData;
            string[] filterCoeff;

            Settings.SampleRate = UInt16.Parse(tbmSampleRate.Text);
            Settings.FilterCoeff.Clear();

            fileName = openFilterCoef.FileName;
            fileData = File.ReadAllText(fileName);

            filterCoeff = fileData.Split(',');

            foreach (string coeff in filterCoeff)
                 Settings.FilterCoeff.Add(Double.Parse(Regex.Replace(coeff, "[a-zA-Z]", ""), CultureInfo.InvariantCulture));

            tbmFilterLen.Text = Settings.FilterCoeff.Count.ToString();
            Settings.FilterLenght = (ushort)Settings.FilterCoeff.Count;

            RedrawPlot();

        }

        private void cbDomain_CheckedChanged(object sender, EventArgs e)
        {
            cbDomanStatus = !cbDomanStatus;
            RedrawPlot();
        }

        private void RedrawPlot()
        {
            if (cbDomanStatus)
            {
                double xMax;

                filterPlot.Plot.Clear();
                filterPlot.Plot.Title("Time domain");
                filterPlot.Plot.XLabel("Time (s)");

                xMax = (double)1 / (double)Settings.SampleRate * (double)Settings.FilterCoeff.Count;

                double[] xPoints = new double[Settings.FilterCoeff.Count];
                double t = 0;

                for (int i = 0; i < Settings.FilterCoeff.Count; i++)
                {
                    xPoints[i] = t;
                    t += (xMax / (double)Settings.FilterCoeff.Count);
                }

                var nsi = new ScottPlot.Statistics.Interpolation.PeriodicSpline(xPoints, Settings.FilterCoeff.ToArray(), resolution: 20);

                filterPlot.Plot.AddScatter(nsi.interpolatedXs, nsi.interpolatedYs, Color.FromArgb(0, 122, 204), markerSize: 3);
                
            }
            else
            {
                filterPlot.Plot.Clear();
                filterPlot.Plot.Title("Frequency domain");
                filterPlot.Plot.XLabel("Frequency (kHz)");

                dft.Initialize((uint)Settings.FilterLenght);
               // MessageBox.Show(Settings.FilterLenght.ToString());

                Complex[] cSpectrum = dft.Execute(Settings.FilterCoeff.ToArray());

                double[] lmSpectrum = DSP.ConvertComplex.ToMagnitude(cSpectrum);
                double[] freqSpan = dft.FrequencySpan(Settings.SampleRate);
                var nsi = new ScottPlot.Statistics.Interpolation.NaturalSpline(freqSpan, lmSpectrum, resolution: 20);

                filterPlot.Plot.AddScatter(nsi.interpolatedXs, nsi.interpolatedYs, Color.FromArgb(0, 122, 204), markerSize: 3);
            }

            filterPlot.Plot.AxisAuto();
            filterPlot.Render();
        }
    }
}
