using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorhism
{
    class Human
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public DateTime dateOfBirth;
       
        // We calculated human age according to year in int type 
        public virtual int Age()
        {
            int age = Convert.ToInt16((DateTime.Now - this.dateOfBirth).TotalDays / 365);
            return age; 
        }

    }
}
