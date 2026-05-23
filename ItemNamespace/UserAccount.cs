using System;

namespace UserAccountNamespace
{
    public class UserAccount
    {
        private string full_name;
        protected string user_name;
        protected string user_password;

        public UserAccount(string name, string uName, string password)
        {
            full_name = name;
            user_name = uName;
            user_password = password;
        }

        public virtual bool validateLogin(string uName, string password)
        {
            return user_name == uName &&
                   user_password == password;
        }

        public string getFullName()
        {
            return full_name;
        }
    }
}