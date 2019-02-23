using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstaction
{
    // Here was defined abstract class and we cannot create instance/object from this class
    public abstract class Account
    {
        public abstract string CurrentCode { get; set; }
        public string Title { get; set; }

        public abstract string[] getBankList();

        public decimal getKDV()
        {
            return 0.18m;
        }
    }

}
