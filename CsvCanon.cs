using System;
using System.Collections.Generic;
using System.Text;

namespace PI
{
    class CsvCanon : IConvertCanon
    {
        public void Convert(PrinterWindows Canon)
        {
            string csv = string.Format("{0},{1}", Canon.Show, Canon.Print);

            Console.WriteLine("Hasil konversi ke csv : \n");
            Console.WriteLine(csv);
        }
    }
}
