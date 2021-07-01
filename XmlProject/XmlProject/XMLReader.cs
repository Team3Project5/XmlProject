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
        public XmlNode ReadXml(string filePath)
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(filePath);

            return xmldoc.DocumentElement.ChildNodes[0];
        }
        public XmlNode GetName(XmlNode allNodes, string name)
        {
            foreach(XmlNode node in allNodes)
            {
                if(node.ChildNodes[0].InnerText == name)
                {
                    return node;
                }
            }
            return null;
        }
    }
}
