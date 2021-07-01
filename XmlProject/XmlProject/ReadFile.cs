using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlProject
{
        class ReadFromFile
        {
            public static string[] ReadFile()
            {
                string[] lines = System.IO.File.ReadAllLines(@"./../../../TeamMembers.txt");
                return lines;
            }
        }
}

