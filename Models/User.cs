using System;
using System.Collections.Generic;

namespace createAuser.Models
{
    public class User
    {
        public static void Main()
        {
            Dictionary<string, string> newUser = new Dictionary<string, string>();
            {
                newUser.Add("Brandon", "Reninger");
                newUser.Add("Rex", "Carrs");
            }
            foreach (var (key, value) in newUser)
                Console.WriteLine(key + value);
        }
    }
}