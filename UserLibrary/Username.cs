using System;

namespace UserLibrary
{
    public class Username
    {
        public const int MinCharacterLength = 3;

        public const int MaxCharacterLength = 10;

        public string User { get; private set; }

        public bool IsSuccessful { get; private set; }

        public Username(string username)
        {
            if(username.Length >= MinCharacterLength && username.Length <= MaxCharacterLength)
            {
                this.User = username;

                this.IsSuccessful = true;

                Console.WriteLine("Username is verified!" +"\n");
            }
            else
            {
                Console.WriteLine("Your username does not match the length if the characters" + "\n" + "The username must contain characters between 3 and 10!!!"+"\n");
            }
        }
    }
}
