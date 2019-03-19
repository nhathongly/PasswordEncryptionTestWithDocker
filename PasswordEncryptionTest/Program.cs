using System;
using System.Globalization;
using Fanex.Data;

namespace PasswordEncryptionTest
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Select one:");
            Console.WriteLine("===================");
            Console.WriteLine("1. Encrypt password");
            Console.WriteLine("2. Decrypt password");
            Console.WriteLine("===================");
            Console.Write("Your selection: ");

            var selectedOption = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (selectedOption == 1)
            {
                Console.Write("Plain password: ");

                var plainPassword = Console.ReadLine();
                var encryptedPassword = Cryptography.EncryptPassword(plainPassword);

                Console.WriteLine($"Encrypted password: {encryptedPassword}");
            }
            else
            {
                Console.Write("Encrypted password: ");

                var encryptedPassword = Console.ReadLine();
                var plainPassword = Cryptography.DecryptPassword(encryptedPassword);

                Console.WriteLine($"Decrypted password: {plainPassword}");
            }

            Console.ReadLine();
        }
    }
}