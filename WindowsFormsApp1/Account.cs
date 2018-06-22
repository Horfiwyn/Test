using System;

namespace WindowsFormsApp1
{
    class Account:IComparable
    {
        protected string username;
        protected string password;
        protected string email;
        protected string country;

        public Account(string u, string p, string e, string c)
        {
            username = u;
            password = p;
            email = e;
            country = c;
        }
        
        public string GetUsername()
        {
            return username;
        }
        public string GetPassword()
        {
            return password;
        }
        public string GetEmail()
        {
            return email;
        }
        public string GetCountry()
        {
            return country;
        }

        public int CompareTo(object obj)
        {
            Account temp = (Account)obj;
            return username.CompareTo(temp.username);
        }
    }
}
