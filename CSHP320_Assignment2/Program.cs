using CSHP320_Assigment2.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSHP320_Assigment2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Models.User> users = new List<Models.User>();
            BuildList(users);
            HelloPassword(users);
            NamePasswordRemoved(users);
            FirstHelloRemoved(users);
            users.ForEach(WriteUsers);
        }

        private static void WriteUsers(User user)
        {
            Console.WriteLine(user.Name + "\n");
        }

        private static void FirstHelloRemoved(List<User> users)
        {
            var removeUser = users.Select(x => x).Where(x => x.Password == "hello").FirstOrDefault();
            users.Remove(removeUser);
        }

        private static void NamePasswordRemoved(List<User> users)
        {
            users.RemoveAll(x => x.Password.ToLower() == x.Name.ToLower());
        }

        private static void HelloPassword(List<User> users)
        {
            List<User> helloItems = users.Select(x => x).Where(x => x.Password == "hello").ToList();
            helloItems.ForEach(WriteUsers);
        }

        static void BuildList(List<Models.User> users)
        {
            users.Add(new Models.User { Name = "Dave", Password = "hello" });
            users.Add(new Models.User { Name = "Steve", Password = "steve" });
            users.Add(new Models.User { Name = "Lisa", Password = "hello" });
        }

    }
}
