using Homework.Auth;
using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Username daxil edin");
            string userName = Console.ReadLine();

            Console.WriteLine("Password daxil edin");
            string pass = Console.ReadLine();

            Account account = new Account();
            account.Login(userName, pass);
        }
    }
}
