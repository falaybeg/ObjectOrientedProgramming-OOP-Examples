using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface
{
    // Here ICalculate interface was inherited and Calculate() function was implemented
    class CalculateDays : ICalculate
    {
        
        // Here is calculated passed day according to entered from datetimepicker
        public int Calculate(DateTime date)
        {
            int totalDays = Convert.ToInt16((DateTime.Now - date).TotalDays);
            return totalDays;
        }
    }
}
