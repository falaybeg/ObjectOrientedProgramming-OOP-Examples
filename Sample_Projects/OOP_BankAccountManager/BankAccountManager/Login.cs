using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManager
{
    class Login
    {
        private string password;
        public string Password { get; set; }

        public void SignIn()
        {
            Console.Write("Enter your Password: ");
            Password = Console.ReadLine();
            if (Password == "123")
            {
                Console.WriteLine("Welcome to Admin Screen");
            }
            else
            {
                Console.WriteLine("Welcome to Customer Screen");
            }
            System.Threading.Thread.Sleep(300);
            Console.Clear();
            

        }


    }
}
