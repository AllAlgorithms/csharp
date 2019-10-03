/**********************************************************************
 This is a random password generator
 Made with love by: Adonis Mendoza
**********************************************************************/

using System;
using System.Linq;

class PasswordGenerator
{
    private static Random random = new Random();
    static void Main(string[] args)
    {
        Console.WriteLine("How many characters do you want the password to have?");
        int Length = Convert.ToInt32(Console.ReadLine());
        string Password = GeneratePassword(Length);
        Console.WriteLine("Your password generated is: {0}", Password);
        Console.ReadKey();
    }

    public static string GeneratePassword(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }
}