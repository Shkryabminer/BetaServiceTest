using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace TEST_IBT
{
    [Serializable]

    internal class Request
    {                   
        public string Login { get; set; }
        public string Password { get; set; }
        public Request() { }
        public Request(string login, string pass)
        {
            Login = login;
            Password = pass;
        }

    }
}