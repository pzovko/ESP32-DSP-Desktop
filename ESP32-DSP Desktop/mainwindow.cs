using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using ScottPlot;

namespace ESP32_DSP_Desktop
{
    public partial class MainWindow : Form
    {
        ScottPlot.Plottable.SignalPlot SignalPlot;
        //ScottPlot.Plottable.SignalPlot FFTPlot;

        public MainWindow()
        {
            InitializeComponent();

            dataPlot.Plot.Style(Style.Gray1);
            fftPlot.Plot.Style(Style.Gray1);
        }

        private void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                int bytesToRead = ESP.portHandle.BytesToRead;
                byte[] readBuffer = new byte[bytesToRead];

                while(ESP.portHandle.BytesToRead >0)
                {
                   ESP.DataBuffer[ESP.DataIndex] = Double.Parse(ESP.portHandle.ReadLine());
                   ESP.DataIndex++;
                   ESP.Tick++;
                   if (ESP.DataIndex == 15000)
                      ESP.DataIndex = 0;
                }
            }
            catch { }
        }

        private void refresh_Click_1(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
                avaiableDevices.Items.Add(port);
            
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

                    ESP.MaxPlotIndex = (double)15000/ESP.SampleFrequency;
                  //  SignalPlot.MaxRenderIndex = 1;
                    dataPlot.Plot.SetAxisLimitsY(0, 4095);
                    dataPlot.Plot.SetAxisLimitsX(ESP.MinPlotIndex, ESP.MaxPlotIndex); //buffer size / samplerate

                    SignalPlot = dataPlot.Plot.AddSignal(ESP.DataBuffer,5000);
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
           // ScottPlot.Plottable.SignalPlot
        }

        private void formsPlot1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            graphPlotTimer.Enabled = false;
           
            if(ESP.DataIndex >  1)
                SignalPlot.MaxRenderIndex = ESP.DataIndex - 1;

            if((ESP.Tick/ESP.SampleFrequency) > (ESP.MaxPlotIndex - (ESP.SampleFrequency / (double)15000)))
            {
                ESP.MinPlotIndex = ESP.MinPlotIndex + ESP.SampleFrequency / (double)15000; //SignalPlot.MaxRenderIndex/5000 - 100;
                ESP.MaxPlotIndex += (ESP.SampleFrequency / (double)15000);

                dataPlot.Plot.SetAxisLimitsX(ESP.MinPlotIndex, ESP.MaxPlotIndex);
            }

            dataPlot.Render();
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
            settingsWindow.Show();
        }
    }
}