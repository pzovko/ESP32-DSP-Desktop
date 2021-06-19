using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Collections.Concurrent;

namespace ESP32_DSP_Desktop
{
    class ESP
    {
        static string btPort;
        static SerialPort hportHandle;
        static int baud;
        static double[] plotBuffer;
        static double[] filterBuffer;
        static ConcurrentQueue<int> buffer = new ConcurrentQueue<int>();

        static double[] dspSpectrum;
        static double[] dspFreqSpan; 


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

        public static double[] PlotBuffer { get => plotBuffer; set => plotBuffer = value; }
        public static double[] FilterBuffer { get => filterBuffer; set => filterBuffer = value; }
        public static ConcurrentQueue<int> Buffer { get => buffer; set => buffer = value; }
        public static double[] DspFreqSpan { get => dspFreqSpan; set => dspFreqSpan = value; }
        public static double[] DspSpectrum { get => dspSpectrum; set => dspSpectrum = value; }

        public static bool IsPow2(int x)
        {
            return (x != 0) && ((x & (x - 1)) == 0);
        }

        public static uint NextPow2(uint x)
        {
            uint power = 1;
            while (power < x)
                power *= 2;
            return power;
        }

        public static void UnpackData(double data)
        {

        }
    }
}
