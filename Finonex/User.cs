using System;

namespace Finonex
{
    public class User
    {
        Random random = new Random();

        private string name = "Test";
        private string mail = "@mailnator.com";
        public string FirstName
        {
            get { return name; }
            set { name = name + value; }
        }
        public string LastName
        {
            get { return name; }
            set { name = name + value; }
        }
        public string Email
        {
            get { return name; }
            set { mail = value + mail; }
        }
        public string Password { get; set; }
        public string RealAccount { get; set; }

    }
}