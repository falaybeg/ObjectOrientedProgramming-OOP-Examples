using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManager
{
   public enum Option
    {
        New = 1,
        Show = 2,
        Modify = 3,
        Deposit = 4,
        WithDraw = 5,
        BalanceShow = 6,
        Exit = 7
    }

    class Program
    {
        private static object opt;

        static void Main(string[] args)
        {
            IntroductionStruct intro = new IntroductionStruct();
            AccountTransaction transaction = new AccountTransaction();
            Login signin = new Login(); 
            int opt;

            intro.Intro();
            intro.Loading();
            Console.Clear();

            do
            {
                Console.Write("\n\n\tMain Menu");
                Console.Write("\n\t1. New Account");
                Console.Write("\n\t2. Show Account");
                Console.Write("\n\t3. Modify Account");
                Console.Write("\n\t4. Deposit Money");
                Console.Write("\n\t5. Withdraw Money");
                Console.Write("\n\t6. Show Balance");
                Console.Write("\n\t7. EXIT");
                Console.Write("\n\tSelect Your Optin (1-7)...: ");
                opt = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opt)
                {
                    case (int)Option.New:
                        {
                            Console.Clear();
                            intro.Loading();
                            Console.Clear();
                            transaction.CreateAccount();
                            break;
                        }
                    case (int)Option.Show:
                        {
                            Console.Clear();
                            intro.Loading();
                            Console.Clear();
                            transaction.ShowAccount();
                            break;
                        }
                    case (int)Option.Modify:
                        {
                            int acno;
                            Console.Clear();
                            intro.Loading();
                            Console.Clear();
                            Console.Write("Please Enter the Account No : ");
                            acno = int.Parse(Console.ReadLine());
                            transaction.modify_account(acno);
                            break;
                        }
                    case (int)Option.Deposit:
                        {
                            transaction.Money_Deposit();
                            break;
                        }
                    case (int)Option.WithDraw:
                        {
                            transaction.Money_Withdraw();
                            break;
                        }
                    case (int)Option.BalanceShow:
                        {
                            transaction.Account_Report();
                            break;
                        }
                    case (int)Option.Exit:
                        { Environment.Exit(0);  break; }
                }
            } while(opt != (int)Option.Exit);
        }
    }
}
