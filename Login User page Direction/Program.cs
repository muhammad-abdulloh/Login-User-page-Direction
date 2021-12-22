using System;
using System.IO;

namespace Login_User_page_Direction
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string path = @"C:\Users\PC shop\Dropbox\PC\Desktop\Data.txt";

            string[] date = File.ReadAllLines(path);

            foreach (string dateStr in date)
            {
                if (!string.IsNullOrEmpty(dateStr))
                {
                    Console.WriteLine(dateStr);
                }
            }
        }
    }
}
