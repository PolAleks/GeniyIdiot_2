using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GeniyIdiot.Common
{
    public class FileProvider
    {
        private static string _path = Environment.CurrentDirectory;

        public static string Load(string file)
        {
            file = Path.Combine(_path, file);
            
            string content = File.ReadAllText(file, Encoding.UTF8);
            return content;
        }

        
        public static void Save(string file, string content, bool append = true)
        {
            file = Path.Combine(_path, file);

            using (StreamWriter sw = new StreamWriter(file, append, Encoding.UTF8))
            {
                sw.Write(content);
            }
        }

        

        public static bool Exists(string file)
        {
            file = Path.Combine(_path, file);
            return File.Exists(file);
        }
    }
}
