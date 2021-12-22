using System;
using System.IO;

namespace Login_User_page_Direction
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
           
            SignIn signIn = new SignIn();
            

            signIn.login = "Buzrukov8";
            signIn.password = "246264562";

            User user = Validation.GetAutentification(signIn);

            user.Show();





        }
    }
}
