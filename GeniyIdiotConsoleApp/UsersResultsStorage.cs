using System;
using System.Collections.Generic;
using System.IO;

namespace GeniyIdiotConsoleApp
{
    public class UsersResultsStorage
    {
        private static string _file = Path.Combine(Environment.CurrentDirectory, "log.txt");

        public static void Add(User user)
        {
            using (StreamWriter sw = new StreamWriter(_file, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(user.ToString());
            }
        }

        public static List<User> GetAll()
        {
            List<User> users = new List<User>();
            if (File.Exists(_file))
            {
                using (StreamReader sr = new StreamReader(_file, System.Text.Encoding.Default))
                {
                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine().Split('#');
                        (string name, int countCorrectAnswer, string diagnosis) = (line[0], Convert.ToInt32(line[1]), line[2]);
                        var user = new User(name, countCorrectAnswer, diagnosis);

                        users.Add(user);
                    }
                }
            }
            return users;
        }
    }
}
