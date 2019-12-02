using System;
using System.Collections.Generic;
using System.IO;

namespace CodeAdvent
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Environment.CurrentDirectory + "/Input/Input.txt";

            //string filePath = Path.co Directory.GetParent(workingDirectory).Parent.FullName + "@~/Input/Input.txt";

            List<string> fileContents = FileReader.ReadFile(filePath);
        }

    }
}
