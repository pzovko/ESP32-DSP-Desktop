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

namespace ESP32_DSP_Desktop
{
    public partial class settingswindow : Form
    {
        public settingswindow()
        {
            InitializeComponent();
            filterPlot.Plot.Style(Style.Gray1);
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
            // MessageBox.Show(cbBaudrate.SelectedItem.ToString());
           // MessageBox.Show(tbmSampleRate.Text);
            Settings.FilterCoeff.Add(10.534534563);
            Settings.FilterCoeff.Add(10.534534563);
            Settings.FilterCoeff.Add(10.534534563);

            MessageBox.Show(Settings.FilterCoeff.Count.ToString());
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

            double xMax;

            Settings.SampleRate = 100; // UInt16.Parse(tbmSampleRate.Text);


            fileName = openFilterCoef.FileName;
            fileData = File.ReadAllText(fileName);

            filterCoeff = fileData.Split(',');

            foreach (string coeff in filterCoeff)
                 Settings.FilterCoeff.Add(Double.Parse(Regex.Replace(coeff, "[a-zA-Z]", ""), CultureInfo.InvariantCulture));

            xMax = (double)1 / (double)Settings.SampleRate * (double)Settings.FilterCoeff.Count;

            double[] xPoints = new double[Settings.FilterCoeff.Count];
            double t = 0;

            for (int i = 0; i < Settings.FilterCoeff.Count; i++)
            {
                xPoints[i] = t;
                t += (xMax / (double)Settings.FilterCoeff.Count);
            }
                
            var nsi = new ScottPlot.Statistics.Interpolation.PeriodicSpline(xPoints, Settings.FilterCoeff.ToArray(),  resolution:20);

            filterPlot.Plot.AddScatter(nsi.interpolatedXs, nsi.interpolatedYs, Color.Blue, markerSize: 3);

            filterPlot.Plot.AxisAuto();
            filterPlot.Render();

        }
    }
}
