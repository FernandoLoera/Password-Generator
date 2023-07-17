using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Generator
{
    internal class Program
    {
        public static void Main()
        {
            int passwordLenght = 10;
            Console.WriteLine(generatePasswoord(passwordLenght));
            Console.ReadLine();
        }

        public static string generatePasswoord(int len)
        {
            Console.WriteLine("Generating password");
            Console.WriteLine("The genereted password is : ");

            String uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            String lowercase = "abcdefghijklmnopqrstuvwxyz";
            String numbers = "0123456789";
            String symbols = "!@#$%^&*_=+-/";

            /**
        * Combination of all allowed characters
        */
            String generatedPassword = uppercase + lowercase + numbers + symbols;

            Random rand = new Random();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < len; i++) {
                int index = rand.Next(generatedPassword.Length);
                sb.Append(generatedPassword[index]);
            }

           return sb.ToString();
        }
    }
}
