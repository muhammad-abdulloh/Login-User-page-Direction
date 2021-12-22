using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_User_page_Direction
{
    public enum Gender
    {
        Male,
        Female,
        Other
    }
    internal class User : SignIn
    {
        private static string firstnamePrivate;

        public static string firstname
        {
            get { return firstnamePrivate; }
            set { firstnamePrivate = value; }
        }

        private static string lastnamePrivate;

        public static string lastname
        {
            get { return lastnamePrivate; }
            set { lastnamePrivate = value; }
        }

        private static DateTime birthDatePrivate;

        public static  DateTime birthDate
        {
            get { return birthDatePrivate; }
            set { birthDatePrivate = value; }
        }

        private static string emailPrivate;

        public static  string email
        {
            get { return emailPrivate; }
            set { emailPrivate = value; }
        }

        public static void Show()
        {
            Console.WriteLine("FirstName: {0}\nLastName: {1}\nGender: {2}\nBirthDate: {3}\nEmail: {4}", firstname, lastname, Gender.Male, birthDate, email);
        }



    }
}
