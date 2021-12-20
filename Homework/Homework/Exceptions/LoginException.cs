using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Exceptions
{
    public class LoginException : Exception 
    {
        public LoginException(string msj) : base(msj) { }
    }
}
