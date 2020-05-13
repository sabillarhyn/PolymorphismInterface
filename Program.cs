using System;
using System.Linq.Expressions;

namespace PI
{
    class Program
    {
        public static void Main(string[] args)
        {
            PrinterWindows Epson = new PrinterWindows();
            PrinterWindows Canon = new PrinterWindows();
            PrinterWindows LaserJet = new PrinterWindows();

            Console.WriteLine("Pilih Printer : ");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet");

            Console.WriteLine("\nNomor Printer [1..3] : ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());
            switch (nomorPrinter)
            {
                case 1:
                    Epson.Show = "Epson display dimension : 10*11";
                    Epson.Print = "Epson printer printing ...";
                    IConvertEpson convertEpson;
                    convertEpson = new JsonEpson();
                    convertEpson.Convert(Epson);                    
                    convertEpson = new XmlEpson();
                    convertEpson.Convert(Epson);
                    convertEpson = new CsvEpson();
                    convertEpson.Convert(Epson);
                    break;
                case 2:
                    Canon.Show = "Canon display dimension : 9.5*12";
                    Canon.Print = "Canon printer printing ...";
                    IConvertCanon convertCanon;
                    convertCanon = new JsonCanon();
                    convertCanon.Convert(Canon);
                    convertCanon = new XmlCanon();
                    convertCanon.Convert(Canon);
                    convertCanon = new CsvCanon();
                    convertCanon.Convert(Canon);
                    break;
                case 3:
                    LaserJet.Show = "Laser Jet display dimension : 12*12";
                    LaserJet.Print = "Laser Jet printer printing ...";
                    IConvertLaserJet convertLaserJet;
                    convertLaserJet = new JsonLaserJet();
                    convertLaserJet.Convert(LaserJet);
                    convertLaserJet = new XmlLaserJet();
                    convertLaserJet.Convert(LaserJet);
                    convertLaserJet = new CsvLaserJet();
                    convertLaserJet.Convert(LaserJet);
                    break;
            }

            Console.ReadKey();
        }
    }
}
