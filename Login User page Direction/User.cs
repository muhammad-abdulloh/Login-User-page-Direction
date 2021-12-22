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
        Female
        
    }
    internal class User : SignIn
    {
        private  string firstnamePrivate;

        public  string firstname
        {
            get { return firstnamePrivate; }
            set { firstnamePrivate = value; }
        }

        private  string lastnamePrivate;

        public  string lastname
        {
            get { return lastnamePrivate; }
            set { lastnamePrivate = value; }
        }

        private  DateTime birthDatePrivate;

        public   DateTime birthDate
        {
            get { return birthDatePrivate; }
            set { birthDatePrivate = value; }
        }

        private  string emailPrivate;

        public   string email
        {
            get { return emailPrivate; }
            set { emailPrivate = value; }
        }

        private string genderPrivate;
        private static object user;

        public string gender
        {
            get { return genderPrivate; }
            set { genderPrivate = value; }
        }



        //string firstname, string lastname, string email, string gender, DateTime birthDate

        public void Show()
        {
           
            Console.WriteLine("FirstName: {0}\nLastName: {1}\nGender: {2}\nBirthDate: {3}\nEmail: {4}", firstname, lastname, email, gender, birthDate);
        }



    }
}
