using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Employee : Person
    {
        public string recordNo { get; set; }
        public DateTime hiredDate { get; set; }
        public decimal Salary { get; set; }
        public string Degree { get; set; }
    }
}
