using System;
using System.Collections.Generic;
using System.IO;

namespace GeniyIdiot.Common
{
    public class UsersResultsStorage
    {
        private static string _file = "log.txt";

        public static void Add(User user)
        {
            FileProvider.Save(_file, user.ToString());
        }

        public static List<User> GetAll()
        {
            var lines = FileProvider.Load(_file);
            List<User> users = new List<User>();

            if(lines != null)
            {
                foreach (var line in lines)
                {
                    var item = line.Split('#');
                    (string name, int countCorrectAnswer, string diagnosis) = (item[0], Convert.ToInt32(item[1]), item[2]);
                    
                    users.Add(new User(name, countCorrectAnswer, diagnosis));
                }
            }
            return users;
        }
    }
}
