using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CodeAdvent
{
    public static class FileReader
    {
        public static List<string> ReadFile(string path)
        {
            List<string> list = new List<string>();

            using (StreamReader sr = new StreamReader(path))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    list.Add(line);
                }
            }

            return list;
        }
    }
}
