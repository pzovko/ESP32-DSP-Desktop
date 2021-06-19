using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using ScottPlot;
using DSPLib;
using System.Numerics;

namespace ESP32_DSP_Desktop
{
    public partial class MainWindow : Form
    {
        FFT dspFFT = new FFT();
        ScottPlot.Plottable.SignalPlot SignalPlot;
        int i = 0;

        public MainWindow()
        {
            InitializeComponent();
 
            dataPlot.Plot.Style(Style.Gray1);
            dataPlot.Plot.XLabel("Samples per second");
            dataPlot.Plot.YLabel("Amplitude");

            fftPlot.Plot.Style(Style.Gray1);
            fftPlot.Plot.XLabel("Frequency (Hz)");
            fftPlot.Plot.YLabel("Amplitude");
            fftPlot.Plot.SetAxisLimitsY(0, 4095);

            ApplySettings();
            GetPorts();
        }

        private void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                while (ESP.portHandle.BytesToRead > 0)
                    ESP.Buffer.Enqueue(Double.Parse(ESP.portHandle.ReadLine()));
            }
            catch { }
        }

        private void refresh_Click_1(object sender, EventArgs e)
        {
            GetPorts();
        }

        private void connect_Click_1(object sender, EventArgs e)
        {
            if (avaiableDevices.SelectedIndex == -1)
            {
                MessageBox.Show("Select a port first!");
            }
            else
            {
                ESP.BluetoothPort = avaiableDevices.SelectedItem.ToString();
                ESP.baudRate = 115200;

                try
                {
                    ESP.portHandle = new SerialPort(ESP.BluetoothPort, ESP.baudRate, Parity.None, 8, StopBits.One);
                    ESP.portHandle.DataReceived += new SerialDataReceivedEventHandler(DataReceived);
                    ESP.portHandle.Open();


                    dataPlot.Plot.Clear();
                    fftPlot.Plot.Clear();

                    ApplySettings();


                   /* var legend  = dataPlot.Plot.Legend();
                    legend.FontName = "Nirmala UI";
                    legend.FontSize = 14;
                    legend.FillColor = Color.FromArgb(49, 54, 58);
                    legend.FontColor = Color.White;*/

                    SignalPlot = dataPlot.Plot.AddSignal(ESP.PlotBuffer, label: "test");

                    graphPlotTimer.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void disconnect_Click_1(object sender, EventArgs e)
        {
            ESP.portHandle.Close();
        }

        private void formsPlot1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           graphPlotTimer.Enabled = false;
            

           if(ESP.Buffer.Count > 0)
            {
               
                while (ESP.Buffer.TryDequeue(out ESP.PlotBuffer[i]) && !ESP.Buffer.IsEmpty)
                {
                    i++;

                    if (i >= Settings.SampleRate)
                    {
                        i = 0;  
                        break;    
                    }
                    SignalPlot.MaxRenderIndex = i;
                }

                DoFFT();

                dataPlot.RenderRequest();
            }
           graphPlotTimer.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form settingsWindow = new settingswindow();
            settingsWindow.Show(this);
        }

        private void DoFFT()
        {
            ESP.PlotBuffer[0] = 0;

            Complex[] cSpectrum = dspFFT.Execute(ESP.PlotBuffer);

            ESP.DspSpectrum= DSP.ConvertComplex.ToMagnitude(cSpectrum);
            ESP.DspFreqSpan = dspFFT.FrequencySpan(Settings.SampleRate);

            fftPlot.Plot.Clear();

            fftPlot.Plot.AddSignalXY(ESP.DspFreqSpan, ESP.DspSpectrum, Color.FromArgb(0, 122, 204));

            fftPlot.Plot.AxisAuto();
            fftPlot.RenderRequest();
        }

        private void GetPorts()
        {
            string[] ports = SerialPort.GetPortNames();

            avaiableDevices.Items.Clear();
            foreach (string port in ports)
                avaiableDevices.Items.Add(port);
        }

        public void ApplySettings()
        {
            dataPlot.Plot.Clear();
            fftPlot.Plot.Clear();

            dataPlot.Plot.SetAxisLimitsY(0, 4095);
            dataPlot.Plot.SetAxisLimitsX(0, Settings.SampleRate);
            
            ESP.PlotBuffer = new double[(int)Settings.SampleRate];

            if(ESP.IsPow2(Settings.SampleRate))
                dspFFT.Initialize(Settings.SampleRate);
            else
            {
                uint n = ESP.NextPow2(Settings.SampleRate);
                dspFFT.Initialize(Settings.SampleRate, (n - Settings.SampleRate));

            }
        }
    }
}