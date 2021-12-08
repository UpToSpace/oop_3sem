using System.Collections.Generic;
using System.IO;
using System.Linq;
using laba5;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;
using System.Xml.Linq;
using System.Xml.XPath;

namespace laba14
{
    class Program
    {
        static void Main(string[] args)
        {
            Waybill bill = new Waybill(12122112, 300, 0.5);
            List<Waybill> list = new List<Waybill>() { new Waybill(12122021, 10, 0.4), new Waybill(13122021, 20, 0.2), new Waybill(23122021, 30, 0.3) };

            BinaryFormatter formatter = new BinaryFormatter();
            SoapFormatter formatter1 = new SoapFormatter();
            DataContractJsonSerializer formatter2 = new DataContractJsonSerializer(typeof(List<Waybill>));
            XmlSerializer formatter3 = new XmlSerializer(typeof(List<Waybill>));

            using (FileStream fs = new FileStream("waybill.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, list);
            }
            using (FileStream fs = new FileStream("waybill.dat", FileMode.OpenOrCreate))
            {
                foreach (Waybill waybill in formatter.Deserialize(fs) as List<Waybill>)
                {
                    waybill.ShowInfo();
                }
            }

            using (FileStream fs = new FileStream("waybill.soap", FileMode.OpenOrCreate))
            {
                formatter1.Serialize(fs, bill);
            }
            using (FileStream fs = new FileStream("waybill.soap", FileMode.OpenOrCreate))
            {
                Waybill newWaybill = formatter1.Deserialize(fs) as Waybill;
                newWaybill.ShowInfo();
            }

            using (FileStream fs = new FileStream("waybill.json", FileMode.OpenOrCreate))
            {
                formatter2.WriteObject(fs, list);
            }
            using (FileStream fs = new FileStream("waybill.json", FileMode.OpenOrCreate))
            {
                foreach (Waybill waybill in formatter2.ReadObject(fs) as List<Waybill>)
                {
                    waybill.ShowInfo();
                }
            }

            using (FileStream fs = new FileStream("waybill.xml", FileMode.OpenOrCreate))
            {
                formatter3.Serialize(fs, list);
            }
            using (FileStream fs = new FileStream("waybill.xml", FileMode.OpenOrCreate))
            {
                foreach (Waybill waybill in formatter3.Deserialize(fs) as List<Waybill>)
                {
                    waybill.ShowInfo();
                }
            }


            XPathDocument doc = new XPathDocument("waybill.xml");
            XPathNavigator nav = doc.CreateNavigator();
            
            foreach (XPathItem item in nav.Select("//Waybill/Signed"))
            {
                System.Console.WriteLine(item.Value);
            }
            System.Console.WriteLine("-------------");
            foreach (XPathItem item in nav.Select("//Waybill[Fine = \"0.3\"]/Signed"))
            {
                System.Console.WriteLine(item);
            }

            XDocument Xdoc = new XDocument();
            XElement root = new XElement("Animals");
            XElement animal = new XElement("animal");
            XElement name = new XElement("name");
            XElement age = new XElement("age");

            name.Value = "dog";
            age.Value = "10";
            animal.Add(name);
            animal.Add(age);
            root.Add(animal);

            animal = new XElement("animal");
            name = new XElement("name");
            age = new XElement("age");
            name.Value = "cat";
            age.Value = "2";
            animal.Add(name);
            animal.Add(age);
            root.Add(animal);

            Xdoc.Add(root);
            Xdoc.Save(@"animals.xml");

            System.Console.WriteLine("-------------");

            foreach (var item in root.Elements("animal"))
            {
                if (item.Element("name").Value == "dog")
                {
                    System.Console.WriteLine(item.Element("name").Value);
                }
            }
        }
    }
}
