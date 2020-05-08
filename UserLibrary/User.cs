
using System;

namespace UserLibrary
{
    public class User
    {
        public Username Username { get; private set; }

        public Password Password { get; private set; }

        public User(Username username,Password password)
        {
            this.Username = username;

            this.Password = password;

            if (this.Username.IsSuccessful && this.Password.IsSuccessfull)
            {
                Console.WriteLine("Successfull Registration!!!" + "\n");
            }
            else
            {
                Console.WriteLine("You have not met the requirement for registration" +"\n");
            }
        }
    }
}
