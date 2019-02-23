using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorhism
{
    class Student : Human
    {
        
        public decimal Midterm { get; set; }
        public decimal Final { get; set; }


        // Here was implemented polymorphism with override keyword
        public override string ToString()
        {
            return Name + " " + Surname;
        }

        // According to day number birthday was calculated 
        public override int Age()
        {
           
            int totalDays = Convert.ToInt16((DateTime.Now - this.dateOfBirth).TotalDays);
            return totalDays;
        }



    }
}
