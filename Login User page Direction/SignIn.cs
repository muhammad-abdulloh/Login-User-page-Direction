using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_User_page_Direction
{
    internal class SignIn
    {
        private string loginPrivate;

        public string login
        {
            get { return loginPrivate; }
            set { loginPrivate = value; }
        }

        private string passwordPrivate;

        public string password
        {
            get { return passwordPrivate; }
            set { passwordPrivate = value; }
        }


    }
}
