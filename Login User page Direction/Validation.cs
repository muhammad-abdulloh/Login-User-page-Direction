using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Login_User_page_Direction
{
    internal static class Validation
    {
        public const string path = @"C:\Users\PC shop\Dropbox\PC\Desktop\Data.txt";

        public static User GetAutentification(SignIn signIn)
        {

            string line = Check(signIn);
            User user = new User();
            string path = Validation.path;

            string[] fields = line.Split();

            user.lastname = fields[0];
            user.firstname = fields[1];
            user.email = fields[2];

            if (fields[5].ToLower() == "erkak" || fields[5].ToLower() == "male") user.gender = Gender.Male.ToString();
            else user.gender = Gender.Male.ToString();

            user.birthDate = DateTime.Parse(fields[6]);

            return user;

        }

        private static string Check(SignIn signIn)
        {
            string result = "";

            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                string[] fields = line.Split();

                string password = fields[3];
                string login = fields[4];

                if (signIn.login == login && signIn.password == password)
                {
                    result = line;
                    break;
                }
            }

            return result;
        }

    }
}
