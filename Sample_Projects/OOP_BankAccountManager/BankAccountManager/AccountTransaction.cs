using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManager
{
    class AccountTransaction : AccountInformation
    {

        #region Create Account Method
        private void create_account()  // Create New Account 
        {
            Console.WriteLine("-----Enter the Account Information-----");
            Console.Write("Account No: ");
            AccountNo = int.Parse(Console.ReadLine());
            Console.Write("Account Name: ");
            AccountName = Console.ReadLine();
            Console.Write("Account Type [Commercial/Personal - (C/P)]: ");
            accountType = char.Parse(Console.ReadLine());
            Console.Write("Currency Type: ");
            currencyType = Console.ReadLine();
            Console.Write("Deposit: ");
            Deposit = int.Parse(Console.ReadLine());
        }
        #endregion

        public void CreateAccount()  //We called private create_account() method
        {
            create_account();
        }

       
        protected void show_account()  //We show customer account informations 
        {
            Console.WriteLine("-------Account Information-------");
            Console.WriteLine("Account No: {0}", AccountNo);
            Console.WriteLine("Account Holder Name: {0}", AccountName);
            Console.WriteLine("Account Type: {0}", accountType);
            Console.WriteLine("Account Balance: {0}", Deposit);
            Console.WriteLine("Currency Type: {0}", currencyType);
            Console.WriteLine("Opened Date Time: {0}", OpenedDate.ToString("dd-MM-yyyy HH:mm"));
            Console.WriteLine("---------------------------------");
        } 
        public void ShowAccount()
        {
            show_account();
        }

       
        internal void modify_account(int acNo)// We can Modify Customer account informations 
        {
            if (acNo == AccountNo)
            {
                Console.WriteLine("\n-------*Modify Account*------");
                Console.WriteLine("Account No : {0}", AccountNo);
                Console.Write("Modify Account Holder Name : ");
                AccountName = Console.ReadLine();
                Console.Write("Modify Type Of Account[Commercial/Personal (C/P)]: ");
                accountType = char.Parse(Console.ReadLine());
                Console.Write("Modify Currency Type: ");
                currencyType = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Wrong Account Number !!! Please enter again....\n");
            }
        } 

        
        public void Money_Deposit() // Deposite Money to your Account
        {
            decimal amount;
            Console.Write("Enter the Deposit Amount: ");
            amount = decimal.Parse(Console.ReadLine());
            Deposit = Deposit + amount;
        }  

        
        public void Money_Withdraw() // Withdraw Money from your account
        {
            decimal amount;
            Console.Write("Enter the Withdraw Amount: ");
            amount = decimal.Parse(Console.ReadLine());
            Deposit = Deposit - amount;
        }  

        
        public void Account_Report()
        {
            Console.WriteLine("\n----------Balance Information----------");
            Console.WriteLine("Account No: {0}", AccountNo);
            Console.WriteLine("Currency Type: {0}", currencyType);
            Console.WriteLine("Balance: {0}", Deposit);
        }  //Show your Account Balance information

    }
}
