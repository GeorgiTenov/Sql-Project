using System;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using UserLibrary;
using DevelopWar;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace DevelopWarzz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //First user
            Username georgi123 = new Username("Georgi123");

            Password pass = new Password("123456");

            User firstUser = new User(georgi123,pass);

            //Add first user
            UserManager.AddUser(firstUser);

            //Second user
            Username ivan = new Username("ivanov56");

            Password password = new Password("ivanovB");

            User ivanIvanov = new User(ivan,password);

            //Add second user
            UserManager.AddUser(ivanIvanov);

            List<User> users = UserManager.GetAllUsers();

            UserManager.ShowAllUsers();
            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-ET5RGIG4\SQLEXPRESS01;Initial Catalog=DevelopWarzz;Integrated Security=True");

                foreach (var userr in users)
                {
                    SqlCommand cmd = new SqlCommand("Insert into [User] values('" + userr.Username.User + "','" + userr.Password.Pass + "')", connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
         

            //bool isWorking = DatabaseHelper.DeleteUser(userTwo);

            //Console.WriteLine(isWorking);

            DatabaseHelper.ReadUsers();

            
            Console.WriteLine(users.Count);

            Console.WriteLine(UserManager.CheckIfDouble());

            bool isDeleted = UserManager.DeleteDoubles();

            Console.WriteLine(isDeleted);

            //DatabaseHelper.DeleteAll();
           
            Console.ReadKey();
        }
    }
}
