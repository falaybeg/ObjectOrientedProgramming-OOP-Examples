using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Student
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Please enter your Name !");
                else
                    name = value;
            }
        }

        private DateTime birthday;
        public DateTime BirthDay
        {
            get { return this.birthday; }
            set
            {
                if (value > DateTime.Now)
                    throw new Exception("Birth Date cannot bigger than today...!");
                else
                    this.birthday = value;

            }
        }
        public int Age
        {
            get
            {
                return (int)((DateTime.Now - this.BirthDay).Days / 365);
            }
        }

        private DateTime hiredDate;
        public DateTime HiredDate
        {
            get { return this.hiredDate; }
            set
            {
                if (value > DateTime.Now)
                    throw new Exception("Hired Date cannot bigger than today...!");
                else
                    this.hiredDate = value;

            }
        }

        public int calistigiGun
        {
            get
            {
                return (int)((DateTime.Now - this.HiredDate).TotalDays);
            }
        }

        private double bonus;
        public double BonusPrice
        {
            get
            {
                return this.bonus * this.calistigiGun;
            }
            set
            {
                if (value < 10)
                {
                    value = 10;
                    throw new Exception("Bonus cannot be lower than 10 $\n10 $ is set to minimum !");
                }
                else if (value > 50)
                {
                    this.bonus = 50;
                    throw new Exception("Compensation  cannot be higher than 50 $\n50 $ is set to default !");
                }
                this.bonus = value;
            }

        }



        double midterm;
        double final;
        public double Midterm
        {
            get
            {
                return this.midterm;
            }
            set
            {
                if (value >= 0 && value <= 100)
                    this.midterm = value;
                else
                    throw new Exception("Wrong Midterm exam range. It should be 0-100 !!!");
            }
        }
        public double Final
        {
            get
            {
                return this.final;
            }
            set
            {
                if (value >= 0 && value <= 100)
                    this.final = value;
                else
                    throw new Exception("Wrong Final exam range. It should be 0-100 !!!");
            }
        }
        public double Average
        {
            get
            {
                return (Midterm * 0.4) + (Final * 0.6);
            }
        }

    }
}
