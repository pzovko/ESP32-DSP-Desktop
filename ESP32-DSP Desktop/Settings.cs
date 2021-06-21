using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESP32_DSP_Desktop
{
    class Settings
    {
        static int baudRate = 115200;
        static UInt16 sampleRate = 50000;
        static UInt16 filterLenght = 0;
        static List<double> filterCoeff = new List<double>();

        static bool filterEnable = false;

        public static int BaudRate { get => baudRate; set => baudRate = value; }
        public static ushort SampleRate { get => sampleRate; set => sampleRate = value; }
        public static ushort FilterLenght { get => filterLenght; set => filterLenght = value; }
        public static List<double> FilterCoeff { get => filterCoeff; set => filterCoeff = value; }
        public static bool FilterEnable { get => filterEnable; set => filterEnable = value; }
    }
}
