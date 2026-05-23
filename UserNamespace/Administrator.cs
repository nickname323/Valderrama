using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserNamespace
{
    public class Administrator : User
    {
        private string admin_name;
        public Administrator(string name, string id, string pass) : base(id, pass)
        { this.admin_name = name; }
        public override void updatePassword(string newPassword)
        { this.user_password = newPassword; }
        public void updateAdminName(string name)
        { this.admin_name = name; }
    }
    
}
