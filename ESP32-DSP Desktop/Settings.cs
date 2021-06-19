﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESP32_DSP_Desktop
{
    class Settings
    {
        static uint baudRate;
        static UInt16 sampleRate = 5000;
        static UInt16 filterLenght;
        static List<double> filterCoeff = new List<double>();



        public static uint BaudRate { get => baudRate; set => baudRate = value; }
        public static ushort SampleRate { get => sampleRate; set => sampleRate = value; }
        public static ushort FilterLenght { get => filterLenght; set => filterLenght = value; }
        public static List<double> FilterCoeff { get => filterCoeff; set => filterCoeff = value; }
    }
}