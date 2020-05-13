using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace PI
{
    class JsonEpson : IConvertEpson
    {
        public void Convert(PrinterWindows Epson)
        {
            string json = JsonConvert.SerializeObject(Epson);

            Console.WriteLine("Hasil konversi ke json : \n");
            Console.WriteLine(json);
        }
    }
}
