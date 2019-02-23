using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface
{
    // Here ICalculate interface was inherited and Calculate() function was implemented
    class CalculateYear : ICalculate
    {
        // Here is calculated passed year according to entered from datetimepicker
        public int Calculate(DateTime date)
        {
            int totalYear = Convert.ToInt16((DateTime.Now - date).TotalDays / 365);
            return totalYear;
        }
    }
}
