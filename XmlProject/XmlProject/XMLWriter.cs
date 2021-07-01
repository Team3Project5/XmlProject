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
            XmlElement majorElement = xmldoc.CreateElement("Major");

            XmlText textNode = xmldoc.CreateTextNode(name);
            XmlText textNode2 = xmldoc.CreateTextNode(major);

            nameElement.AppendChild(textNode);
            majorElement.AppendChild(textNode2);  

            element.AppendChild(nameElement);
            element.AppendChild(majorElement);
            root.AppendChild(element);

            return this;
        }

        public XMLWriter save(string path){
        
            xmldoc.Save(path);

            return this;
        }
    }
}