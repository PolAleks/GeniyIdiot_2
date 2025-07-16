using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace GeniyIdiot.Common
{
    public class UsersResultsStorage
    {
        private static string _file = "log.json";

        public static void Add(User user)
        {
            var users = GetAll();
            users.Add(user);    
            var content = JsonConvert.SerializeObject(users, Formatting.Indented);

            FileProvider.Save(_file, content, false);
        }

        public static List<User> GetAll()
        {
            if(!FileProvider.Exists(_file))
            {
                return new List<User>();
            }

            var content = FileProvider.Load(_file);
            List<User> users = JsonConvert.DeserializeObject<List<User>>(content);
            return users;
        }
    }
}
