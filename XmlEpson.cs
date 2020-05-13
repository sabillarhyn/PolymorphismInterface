using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace PI
{
    class XmlEpson : IConvertEpson
    {
        public void Convert(PrinterWindows Epson)
        {
            using (StringWriter writer = new StringWriter())
            {
                XmlSerializer serializer = new XmlSerializer(typeof(PrinterWindows));
                serializer.Serialize(writer, Epson);

                string xml = writer.ToString();

                Console.WriteLine("Hasil konversi ke XML : \n");
                Console.WriteLine(xml);
            };
        }
    }
}
