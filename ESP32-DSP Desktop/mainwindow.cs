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
        FFT dspFFTfilter = new FFT();

        ScottPlot.Plottable.SignalPlot SignalPlot;
        ScottPlot.Plottable.SignalPlot FilterPlot;

        int i = 0;

        public MainWindow()
        {
            InitializeComponent();

            var random = new Random();

            Crypt.PrivateKey = (UInt32)random.Next(4);
 
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
                {
                    if(Crypt.PublicKeyESP  == 0)
                    {
                        Crypt.PublicKeyESP = UInt32.Parse(ESP.portHandle.ReadLine());
                        Crypt.SharedKey = Crypt.GenSharedKey(Crypt.PublicKeyESP, Crypt.PrivateKey);
                    }
                    else
                        ESP.Buffer.Enqueue(Int32.Parse(ESP.portHandle.ReadLine()));

                }
                    
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

                try
                {
                    Reconnect();
                    
                    dataPlot.Plot.Clear();
                    fftPlot.Plot.Clear();

                    ApplySettings();

                    
                    var legend  = dataPlot.Plot.Legend();
                     legend.FontName = "Nirmala UI";
                     legend.FontSize = 14;
                     legend.FillColor = Color.FromArgb(49, 54, 58);
                     legend.FontColor = Color.White;

                    SignalPlot = dataPlot.Plot.AddSignal(ESP.PlotBuffer, label: "Raw");

                    if(Settings.FilterEnable)
                        FilterPlot = dataPlot.Plot.AddSignal(ESP.FilterBuffer, label: "Filtered", color: Color.FromArgb(255, 255, 0)); //  Color.FromArgb(222, 30, 39)

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
            connect.Text = "Connect";
            graphPlotTimer.Enabled = false;
            ESP.SettingsSent = false;
            if(ESP.portHandle != null)
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
                while (ESP.Buffer.TryDequeue(out int temp) && !ESP.Buffer.IsEmpty)
                {
                    if(Settings.FilterEnable)
                    {
                        byte[] bytes = BitConverter.GetBytes((temp ^ Crypt.SharedKey));
                     
                        ESP.PlotBuffer[i] = (double)BitConverter.ToInt16(bytes, 2);
                        ESP.FilterBuffer[i] = (double)BitConverter.ToInt16(bytes, 0);

                    }
                    else
                        ESP.PlotBuffer[i] = (double)(temp^Crypt.SharedKey);

                    SignalPlot.MaxRenderIndex = i;
                    dataPlot.Plot.SetAxisLimitsX((SignalPlot.MaxRenderIndex - Settings.SampleRate/100), SignalPlot.MaxRenderIndex - 10);
                    if (Settings.FilterEnable)
                        FilterPlot.MaxRenderIndex = i;

                    i++;
                    if (i >= Settings.SampleRate)
                    {
                        i = 0;  
                        break;    
                    }
                }

                DoFFT();
                dataPlot.Plot.AxisAutoY();
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
            if(ESP.portHandle != null)
            {
                if (ESP.portHandle.IsOpen)
                    ESP.portHandle.Close();
            }
            
            Form settingsWindow = new settingswindow();
            settingsWindow.Show(this);
        }

        private void DoFFT()
        {
            ESP.PlotBuffer[0] = 0;
            if (Settings.FilterEnable)
                ESP.FilterBuffer[0] = 0;

            Complex[] cSpectrum = dspFFT.Execute(ESP.PlotBuffer);
            Complex[] cSpectrumFil;

            if (Settings.FilterEnable)
            {
                cSpectrumFil = dspFFT.Execute(ESP.FilterBuffer);
                ESP.DspSpectrumFil = DSP.ConvertComplex.ToMagnitude(cSpectrumFil);
               // ESP.DspSpectrumFil = DSP.Math.RemoveMean(ESP.DspSpectrumFil);
            }
                
            ESP.DspSpectrum= DSP.ConvertComplex.ToMagnitude(cSpectrum);
            ESP.DspFreqSpan = dspFFT.FrequencySpan(Settings.SampleRate);

            //ESP.DspSpectrum = DSP.Math.RemoveMean(ESP.DspSpectrum);

            fftPlot.Plot.Clear();

            fftPlot.Plot.AddSignalXY(ESP.DspFreqSpan, ESP.DspSpectrum, Color.FromArgb(0, 122, 204));//Color.FromArgb(0, 122, 204)

            if (Settings.FilterEnable)
                fftPlot.Plot.AddSignalXY(ESP.DspFreqSpan, ESP.DspSpectrumFil, Color.FromArgb(255, 255, 0));// Color.FromArgb(222, 30, 39)

            fftPlot.Plot.AxisAuto();
            fftPlot.Plot.AxisAutoY();
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
            dataPlot.Plot.SetAxisLimitsX(0, (Settings.SampleRate/100));
            
            ESP.PlotBuffer = new double[(int)Settings.SampleRate];
            ESP.FilterBuffer = new double[(int)Settings.SampleRate];

            if (ESP.IsPow2(Settings.SampleRate))
            {
                dspFFT.Initialize(Settings.SampleRate);
                dspFFTfilter.Initialize(Settings.SampleRate);
            }   
            else
            {
                uint n = ESP.NextPow2(Settings.SampleRate);
                dspFFT.Initialize(Settings.SampleRate, (n - Settings.SampleRate));
                dspFFTfilter.Initialize(Settings.SampleRate, (n - Settings.SampleRate));
            }
        }

        public void Reconnect()
        {
            if (ESP.SettingsSent)
            {
                if (ESP.portHandle != null)
                    ESP.portHandle.Close();
                ESP.portHandle = new SerialPort(ESP.BluetoothPort, Settings.BaudRate, Parity.None, 8, StopBits.One);
                ESP.portHandle.DataReceived += new SerialDataReceivedEventHandler(DataReceived);
                ESP.portHandle.Open();
            }
            else
            {
                Crypt.PublicKeyPC = Crypt.GenPublicKey(Crypt.PrivateKey);

                if (ESP.portHandle != null)
                    ESP.portHandle.Close();

                ESP.portHandle = new SerialPort(ESP.BluetoothPort, Settings.BaudRate, Parity.None, 8, StopBits.One);
                ESP.portHandle.Open();

                ESP.portHandle.WriteLine(Crypt.PublicKeyPC.ToString());
                ESP.portHandle.WriteLine(Settings.SampleRate.ToString());
                ESP.portHandle.WriteLine((Settings.FilterEnable ? 1 : 0).ToString());

                if (Settings.FilterEnable)
                {
                    ESP.portHandle.WriteLine(Settings.FilterLenght.ToString());
                    for(int i = 0; i < Settings.FilterLenght; i++)
                    {
                        ESP.portHandle.WriteLine(Settings.FilterCoeff.ElementAt(i).ToString());
                        Thread.Sleep(10);
                    }
                }


                ESP.SettingsSent = true;   
                ESP.portHandle.Close();

                connect.Text = "Reconnect";
            }
        }
    }
}