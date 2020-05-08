

using System;
using System.Data.SqlClient;
using UserLibrary;

namespace DevelopWar
{
    public static class DatabaseHelper
    {
        private static SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-ET5RGIG4\SQLEXPRESS01;Initial Catalog=DevelopWarzz;Integrated Security=True");

        public static bool DeleteUser(User user)
        {
            if(user != null)
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM [User] WHERE Username = '" + user.Username.User + "'", connection);
                    int i = command.ExecuteNonQuery();
                    connection.Close();
                    if (i != 0)
                    {
                        return true;
                    }

                }catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
          
            }
            return false;

        }

        public static void ReadUsers()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM [User]", connection);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine(reader.GetValue(i).ToString() + "\n");
                    }

                }
                connection.Close();
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }

        public static void DeleteAll()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM [User]", connection);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                Console.WriteLine("Deleting successfull");
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
         
        }
    }
}
