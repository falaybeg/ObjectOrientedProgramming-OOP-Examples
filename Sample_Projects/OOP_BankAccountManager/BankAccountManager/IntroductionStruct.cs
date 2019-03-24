using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManager
{
    struct IntroductionStruct
    {
        public void Intro()
        {
            Console.WriteLine("\tWelcome to our BANK");
        }
        internal void Loading()
        {
            Console.Write("Loading");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(500);
            }
        }
    }
}
