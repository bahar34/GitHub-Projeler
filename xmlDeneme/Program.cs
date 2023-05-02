using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Timers;

namespace xmlDeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime timer;

            //XmlDocument doc = new XmlDocument();
            //XmlReader reader = XmlReader.Create(@"C:\Users\User\Documents\Visual Studio 2015\Projects\xmlDeneme\xmlDeneme\Ayarlar.xml");
            //XmlNodeList nodeList = doc.DocumentElement.SelectNodes("/timer/path");

            //foreach (XmlNode node in nodeList)
            //{
            //    timer = DateTime.Now;
            //}

            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\User\Documents\Visual Studio 2015\Projects\xmlDeneme\xmlDeneme\Ayarlar.xml");

            XmlNodeList nodes = doc.SelectNodes("//settings");

            foreach (XmlNode node in nodes)
            {
                //XmlNode timer = node.SelectSingleNode("timer");
                //if (timer!=null)
                //{
                //    Console.WriteLine(timer.InnerText);
                    
                //}

                XmlNode path = node.SelectSingleNode("path");
                if (path != null)
                {
                    Console.WriteLine(path.InnerText);
                }
            }

            Console.ReadKey();
        }
    }
}
