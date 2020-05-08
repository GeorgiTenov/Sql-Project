using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UserLibrary;

namespace DevelopWar
{
   public static class UserManager
    {
        private static List<User> Users = new List<User>(); 

        public static void AddUser(User user)
        {
            foreach(var u in Users)
            {
                if (u.Username.User.Equals(user.Username.User))
                {
                    Console.WriteLine("User with the same username already exists!");
                    return;
                }
            }
            UserManager.Users.Add(user);
        }

        public static User GetUserAtIndex(int index)
        {
            return UserManager.Users[index];
        }

        public static List<User> GetAllUsers()
        {
            return UserManager.Users;
        }

        public static bool DeleteUser(User user)
        {
            foreach(var userr in UserManager.Users)
            {
                if (userr.Equals(user))
                {
                    UserManager.Users.Remove(userr);
                    return true;
                }

            }
            return false;
        }

        public static void ShowAllUsers()
        {
            foreach( var user in UserManager.Users)
            {
                Console.WriteLine("Username: "+user.Username.User+"\n");

                Console.WriteLine("Password: "+user.Password.Pass +"\n");
            }
        }

        public static void DeleteAllUsers()
        {
            UserManager.Users.Clear();
        }
        public static bool CheckIfDouble()
        {
            foreach(var u in Users)
            {
                foreach(var e in Users)
                {
                    if (u.Username.User.Equals(e.Username.User))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool DeleteDoubles()
        {
           for(int i = 0; i < Users.Count; i++)
            {
                for(int k = 0; k < Users.Count; k++)
                {
                    if (Users[i].Username.User.Equals(Users[k].Username.User))
                    {
                        Users.Remove(Users[k]);
                        return true;
                    }
                }
            }
            return false;
        }
       
    }
}
