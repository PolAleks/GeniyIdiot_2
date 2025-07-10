using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GeniyIdiot.Common
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

        public static void Save(string file, string content, bool append = true)
        {
            file = Path.Combine(_path, file);
            using (StreamWriter sw = new StreamWriter(file, append, Encoding.Default))
            {
                sw.WriteLine(content);
            }
        }

        internal static void Delete(string file, string content)
        {
            file = Path.Combine(_path, file);
            var questions = Load(file);

            questions.Remove(content);

            Save(file, string.Join(Environment.NewLine,questions), false);
        }

        internal static bool Exists(string file)
        {
            file = Path.Combine(_path, file);
            return File.Exists(file);
        }
    }
}
