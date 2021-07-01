using System.Xml;

namespace XmlProject
{
    public class XMLWriter
    {
        private XmlDocument xmldoc;
        private XmlElement root;

        public XMLWriter(){

            this.xmldoc = new XmlDocument();

            XmlElement xmlRoot = xmldoc.CreateElement("xml");
            xmlRoot.SetAttribute("version", "1.0");
            this.xmldoc.AppendChild(xmlRoot);

            XmlElement membersElement = xmldoc.CreateElement("Members");
            xmlRoot.AppendChild(membersElement);

            this.root = membersElement;
        }

        public XMLWriter CreateMember(string name){
            XmlElement element = xmldoc.CreateElement("Member");
            XmlElement nameElement = xmldoc.CreateElement("Name");

            XmlText textNode = xmldoc.CreateTextNode(name);

            nameElement.AppendChild(textNode);

            element.AppendChild(nameElement);
            root.AppendChild(element);

            return this;
        }

        public XMLWriter Save(string path){
        
            xmldoc.Save(path);

            return this;
        }
    }
}