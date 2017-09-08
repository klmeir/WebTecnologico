using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecnologico.Web.Core.Model
{
    public class Usuario
    {
        private bool isAdmin;

        public bool IsAdmin
        {
            get { return isAdmin; }
            set { isAdmin = value; }
        }
        private string username;

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        
    }
}
