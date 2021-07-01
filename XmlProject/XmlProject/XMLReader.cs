using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlProject
{
    class XMLReader
    {
        public void ReadXml()
        {
            XmlDocument xmldoc = new XmlDocument();
            // put the path
            xmldoc.Load(@"path");
            foreach (XmlNode node in xmldoc.DocumentElement.ChildNodes)
            {
                string studentName = node.Name;
                Console.WriteLine("Student's Name:" + studentName + ": ");
                string text = node.InnerText;
                Console.WriteLine(text);
            }
        }
    }
}
