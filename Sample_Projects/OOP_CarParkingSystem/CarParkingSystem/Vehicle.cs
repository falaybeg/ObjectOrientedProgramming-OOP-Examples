using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkingSystem
{
    class Vehicle
    {
       public Vehicle()
        {
            EntranceTime = DateTime.Now;
        }

        public string Plate { get; set; }
        public VehicleType Type { get; set; }
        public bool Contact { get; set; }
        public bool Subscribe { get; set; }

        public DateTime EntranceTime { get; set; }
        public DateTime ExitTime { get; set; }

        public int Time
        {
            get
            {
                TimeSpan difference = (ExitTime - EntranceTime);
                if (difference - TimeSpan.FromHours((int)difference.TotalHours)> TimeSpan.Zero) 
                {
                   difference = difference.Add(TimeSpan.FromHours(1));
                }
                return (int)difference.TotalHours;
            }
        }
        public decimal Price
        {
            get
            {
                decimal sum = Type.Price * (Time - 1) + Type.Price*2;
                if(Subscribe == true)
                {
                    sum = sum *  0.80m;
                }
                return sum;
            }
        }


        public override string ToString()
        {
            string member = Subscribe ? "Subscribe" : "Not Subscribe";
            string contact = Contact ? "Contact" : "No Contact";
            return string.Format("{0} - {1} - {2} - {3}",Plate,Type.Name,member,contact);
        }
    }
}
