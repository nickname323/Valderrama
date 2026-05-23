using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserNamespace
{
    public class User
    {
        private string user_id;
        protected string user_password;
        
        public User(string id, string pass)
        { this.user_id = id; this.user_password = pass; }
        public bool verifyLogin(string id, string pass)
        { return this.user_id.Equals(id) && this.user_password.Equals(pass);}
        public virtual void updatePassword(String newPassword)
        { this.user_password = newPassword;}
    }
}
