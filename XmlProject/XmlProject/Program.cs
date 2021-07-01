using System;
using System.Threading;

namespace XmlProject
{
  


    class Program
    {
        static void Main(string[] args)
        {
            Thread writerThread = 
                new Thread(() => WriteTeamMembersXml(new string[] { "Anas", "Abdulaziz", "Samirah" }, @"../../../XmlOutput.xml"));

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
    }
}
