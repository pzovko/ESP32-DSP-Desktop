using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESP32_DSP_Desktop
{
    class Crypt
    {
        static UInt32 publicKeyESP = 0;
        static UInt32 publicKeyPC;
        static UInt32 privateKey;
        static UInt32 sharedKey;
        static UInt32 baseC = 4;
        static UInt32 prime = 17;


        public static uint PublicKeyESP { get => publicKeyESP; set => publicKeyESP = value; }
        public static uint PublicKeyPC { get => publicKeyPC; set => publicKeyPC = value; }
        public static uint PrivateKey { get => privateKey; set => privateKey = value; }
        public static uint SharedKey { get => sharedKey; set => sharedKey = value; }
        public static uint Base { get => baseC; set => baseC = value; }
        public static uint Prime { get => prime; set => prime = value; }

        public static UInt32 GenSharedKey(UInt32 publickey, UInt32 privatekey)
        {
            return (UInt32)(Math.Pow(publickey, privatekey) % Crypt.Prime);
        }

        public static UInt32 GenPublicKey(UInt32 privatekey)
        {
            return (UInt32)(Math.Pow(Crypt.Base, privatekey) % Crypt.Prime);
        }

    }
}
