using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace PI
{
    class JsonLaserJet : IConvertLaserJet
    {
        public void Convert(PrinterWindows LaserJet)
        {
            string json = JsonConvert.SerializeObject(LaserJet);

            Console.WriteLine("Hasil konversi ke json : \n");
            Console.WriteLine(json);
        }
    }
}
