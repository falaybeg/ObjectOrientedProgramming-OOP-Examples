using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
     class Student
    {
        // Defined static StudentCount is accessible without creating instance/object from Student class
        public static int StudentCount { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string SchoolNO { get; set; }
        public string IDno { get; set; }

        public Student()
        {
            // Here we increase StudentCount values after every click
            StudentCount++;
        }

        // rollCall() method is accessible without creating instance/object from Student class
        public static void rollCall()
        {

        }
    }
}
