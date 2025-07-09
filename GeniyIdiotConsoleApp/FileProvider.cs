using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GeniyIdiotConsoleApp
{
    public class FileProvider
    {
        private static string _path = Environment.CurrentDirectory;
        public static List<string> Load(string file)
        {
            file = Path.Combine(_path, file);
            var content = new List<string>();

            if (File.Exists(file))
            {
                using (StreamReader sr = new StreamReader(file, Encoding.Default))
                {
                    while (!sr.EndOfStream)
                    {
                        content.Add(sr.ReadLine());
                    }
                }
            }
            return content;
        }

        public static void Save(string file, string content)
        {
            file = Path.Combine(_path, file);
            using (StreamWriter sw = new StreamWriter(file, true, Encoding.Default))
            {
                sw.WriteLine(content);
            }
        }

        internal static bool Exists(string file)
        {
            file = Path.Combine(_path, file);
            return File.Exists(file);
        }
    }
}
