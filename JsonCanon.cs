using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace PI
{
    class JsonCanon : IConvertCanon
    {
        public void Convert(PrinterWindows Canon)
        {
            string json = JsonConvert.SerializeObject(Canon);

            Console.WriteLine("Hasil konversi ke json : \n");
            Console.WriteLine(json);
        }
    }
}
