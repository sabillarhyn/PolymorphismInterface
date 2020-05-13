using System;
using System.Collections.Generic;
using System.Text;

namespace PI
{
    class CsvEpson : IConvertEpson
    {
        public void Convert(PrinterWindows Epson)
        {
            string csv = string.Format("{0},{1}", Epson.Show, Epson.Print);

            Console.WriteLine("Hasil konversi ke csv : \n");
            Console.WriteLine(csv);
        }
    }
}
