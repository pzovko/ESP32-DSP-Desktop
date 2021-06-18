using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace ESP32_DSP_Desktop
{
    class ESP
    {
        static string btPort;
        static SerialPort hportHandle;
        static int baud;
        static double[] dataBuffer = new double[15360];
        static int dataIndex = 0;
        static double minPlotIndex = 0;
        static double maxPlotIndex;
        static double tick = 0;
        static double sampleFrequency = 5000;
       
       
        public static string BluetoothPort
        {
            set { btPort = value; }
            get { return btPort; }
        }

        public static SerialPort portHandle
        {
            set { hportHandle = value; }
            get { return hportHandle; }
        }

        public static int baudRate
        {
            set { baud = value; }
            get { return baud; }
        }

        public static double[] DataBuffer { get => dataBuffer; set => dataBuffer = value; }
        public static int DataIndex { get => dataIndex; set => dataIndex = value; }
        public static double MinPlotIndex { get => minPlotIndex; set => minPlotIndex = value; }
        public static double MaxPlotIndex { get => maxPlotIndex; set => maxPlotIndex = value; }
        public static double Tick { get => tick; set => tick = value; }
        public static double SampleFrequency { get => sampleFrequency; set => sampleFrequency = value; }
    }
}
