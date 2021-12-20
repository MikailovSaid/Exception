using Homework.Constans;
using Homework.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Auth
{
    public class Account
    {
        public void Login(string userName, string password)
        {
            try
            {
                if (userName != "Mikailov")
                {
                    throw new LoginException(Messages.LoginMessage);
                }
                else if (password.Length < 6)
                {
                    throw new LoginException(Messages.PasswordMessage);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Login was success");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
