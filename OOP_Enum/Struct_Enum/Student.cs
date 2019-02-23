using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Enum
{
    class Student
    {
        double midterm;
        double final;

        // Here midterm score range was controlled by implementing Encapsulation
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
                    throw new Exception("Midterm exam must be between 0 and 100 ! !!!");
            }
        }
        // Here final score range was controlled by implementing Encapsulation
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
                    throw new Exception("Final exam must be between 0 and 100 ! !!!");
            }
        }


        // We calculated and returned exam average of student
        public double Average
        {
            get
            {
                return (Midterm * 0.4) + (Final * 0.6);
            }
        }

        // Exam status was controlled by defining a property in StudentStatus type
        public StudentStatus status
        {
            get
            {
                if (this.Average >= 70)
                    return StudentStatus.Passed;
                else if (this.Average >= 50 && this.Average < 70)
                    return StudentStatus.Conditional;
                else
                    return StudentStatus.Failed;

            }
        }



    }


    // Here created Enum type for controlling student lecture status
    enum StudentStatus
    {
        Passed=1,
        Conditional,
        Failed
    }

    // Here was defined a Enum type for getting days 
    enum Days
    {
       
        Monday =1, 
        Tuesday=2,
        Wednesday=3,
        Thursday=4,
        Friday=5, 
        Saturday=6,
        Sunday=7,
       
    }

}
