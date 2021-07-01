using System.Xml;

namespace XmlProject
{
    public class XMLWriter
    {
        private XmlDocument xmldoc;
        private XmlElement root;

        public XMLWriter(){
            this.xmldoc = new XmlDocument();
            this.root = xmldoc.CreateElement("Members");
        }

        public XMLWriter CreateMember(string name , string major){
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