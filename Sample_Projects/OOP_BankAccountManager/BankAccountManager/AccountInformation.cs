using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManager
{
    class AccountInformation
    {
        private int accountNo;
        private string accountName;
        private decimal deposit;
        private DateTime openedDate;
        protected internal char accountType;
        protected string currencyType;

        // when we create instance from Class openedDate is setted automatically DateTime.Now
        public AccountInformation()
        {
            openedDate = DateTime.Now;
        }

        public int AccountNo
        {
            get { return accountNo; }
            set { accountNo = value;}
        }
        public string AccountName
        {
            get {  return accountName; }
            set { accountName = value; }
        }
        public decimal Deposit {
            get { return deposit; }
            set {
                if (deposit >= 0)
                { deposit = value; }
                else
                { Console.WriteLine("Deposit can't be minus !"); }
                }   
        }
        public DateTime OpenedDate
        {
            get { return openedDate; }
            set { openedDate = value; }
        }

    }
}
