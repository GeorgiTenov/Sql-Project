

using System;
using System.Linq.Expressions;

namespace UserLibrary
{
    public class Password
    {
        public const int MinLengthPasswordCharacters = 5;

        public const int MaxLengthPasswordCharacters = 12;

        public string Pass { get; private set; }

        public bool IsSuccessfull { get; private set; }

        public Password(string password)
        {
            if(password.Length >= MinLengthPasswordCharacters && password.Length <= MaxLengthPasswordCharacters)
            {
                this.Pass = password;

                this.IsSuccessfull = true;

                Console.WriteLine("Password is verified!" + "\n");
            }
            else
            {
                Console.WriteLine("Your password does not match the length if the characters"+"\n" + "The Password must contain characters between 5 and 12!!!" + "\n");
            }
            
        }

    }
}
