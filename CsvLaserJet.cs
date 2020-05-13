using System;
using System.Collections.Generic;
using System.Text;

namespace PI
{
    class CsvLaserJet : IConvertLaserJet
    {
        public void Convert(PrinterWindows LaserJet)
        {
            string csv = string.Format("{0},{1}", LaserJet.Show, LaserJet.Print);

            Console.WriteLine("Hasil konversi ke csv : \n");
            Console.WriteLine(csv);
        }
    }
}
