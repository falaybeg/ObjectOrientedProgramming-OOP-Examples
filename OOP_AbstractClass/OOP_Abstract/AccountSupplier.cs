using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstaction
{
    class AccountSupplier : Account
    {
        string currentCode;

        public override string CurrentCode
        {
            get
            {
                return currentCode;
            }
            set
            {
                currentCode = value;
            }
        }
        public override string[] getBankList()
        {
            return new string[] { "TEB", "Garanti", "X Bank" };
        }

    }
}
