using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML
{
    class Program
    {
        static void Main(string[] args)
        {
            Write();

            Read();


        }

        private static void Write()
        {
            XmlTextWriter writer = new XmlTextWriter("1.xml", Encoding.UTF8);
            writer.WriteStartDocument();
            writer.WriteStartElement("Product");
            writer.WriteAttributeString("id", "444");
            writer.WriteElementString("Name", "Bamba");
            writer.WriteElementString("Price", "33");
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }

        private static void Read()
        {
            XmlTextReader reader = new XmlTextReader("1.xml");
            while (reader.Read())
            {
                if (reader.NodeType==XmlNodeType.Element)
                {
                    Console.WriteLine(reader.Name);
                }
                if (reader.HasAttributes)
                {
                    for (int i = 0; i < reader.AttributeCount; i++)
                    {
                        reader.MoveToAttribute(i);
                        Console.WriteLine(reader.Name+":"+reader.Value);
                    }
                }
                else if (reader.NodeType==XmlNodeType.Text)
                {
                    Console.WriteLine("\t\t" + reader.Value); 
                }
            }

        }
        


    }
}
