using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstaction
{
    class AccountClient : Account
    {
        private string currentCode;

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
            //in this method we can load Bank lists from Database 
            return new string[] { "A Bank", "B Bank" };
        }

    }
}
