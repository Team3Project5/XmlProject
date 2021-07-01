using System;
using System.Threading;

namespace XmlProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"../../../XmlOutput.xml";

            
            // get data from custom file then write it into xml (Default use)

            Thread writerThread =
                new Thread(() => WriteTeamMembersXmlFromFile(filePath));

            writerThread.Start();


            /*
             
            // write xml (directly)

            Thread writerThread = 
                new Thread(() => WriteTeamMembersXml(new string[] { "Anas", "Abdulaziz", "Samirah" }, filePath));

            writerThread.Start();

            */

            /*
            
            // query xml file and print out the queried member's name 

            Thread readerThread =
                new Thread(() => PrintMember("Abdulaziz Almohammadi", filePath));

            readerThread.Start();

            */
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

        public static void PrintMember(string name, string filePath)
        {
            var reader = new XMLReader();

            var memebers = reader.ReadXml(filePath);

            var member = reader.GetName(memebers, name);

            Console.WriteLine(member.InnerText);
        }
    }
}
