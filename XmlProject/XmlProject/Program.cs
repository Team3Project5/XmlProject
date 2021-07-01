using System;
using System.Threading;

namespace XmlProject
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             
            // write xml (directly)

            Thread writerThread = 
                new Thread(() => WriteTeamMembersXml(new string[] { "Anas", "Abdulaziz", "Samirah" }, @"../../../XmlOutput.xml"));

            writerThread.Start();

            */

            // get data from custom file then write it into xml

            Thread writerThread =
                new Thread(() => WriteTeamMembersXmlFromFile(@"../../../XmlOutput.xml"));

            writerThread.Start();
        }
        public static void WriteTeamMembersXml(string[] names, string filePath)
        {
            XMLWriter writer = new XMLWriter();

            foreach(string name in names)
            {
                writer.CreateMember(name);
            }

            writer.Save(filePath);
        }

        public static void WriteTeamMembersXmlFromFile(string filePath)
        {
            string[] names = ReadFromFile.ReadFile();

            WriteTeamMembersXml(names, filePath);
        }
    }
}
