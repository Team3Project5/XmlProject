using System;

namespace XmlProject
{
  


    class Program
    {
        static void Main(string[] args)
        {
            string[] lines =  ReadFromFile.ReadFile();

            // use lines here.. ex:
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
