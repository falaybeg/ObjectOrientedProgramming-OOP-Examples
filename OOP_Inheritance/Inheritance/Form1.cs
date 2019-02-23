using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Size = new Size(395, 405);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Insan sinifindan miras alan Ogrenci sinifindan nesne olusturduk
            Student o = new Student(); 

            // Ogrenciye ait bilgileri tanimladik
            o.Name = "A";
            o.Surname = "AAA";
            o.IdentityNo = "BBB";
            o.SchoolNo = "b134242423";
            o.Final = 60;
            o.Midterm = 50;

            MessageBox.Show("Student Informations\n\nName: " + o.Name + "\nSurname: " + o.Surname + "\nIdentity No: " + o.IdentityNo +
                "\n------------------------\nSchool No: " + o.SchoolNo + "\nMidterm Score: " + o.Midterm + "\nFinal Score: " + o.Final);


          
        }

        private void txtOgretmen_Click(object sender, EventArgs e)
        {
            Teacher ogr = new Teacher();
            ogr.Name = "AAA";
            ogr.Surname = "BBB";
            ogr.IdentityNo = "2478923394823";
            ogr.recordNo = "3535342";
            ogr.Field = "Math";
            ogr.WeeklyScheduleHour = 10;
            ogr.Salary = 1000;

            MessageBox.Show("Teacher Information\n\nName:  " + ogr.Name + "\nSurname:  " + ogr.Surname + "\nIdentity No:  " + ogr.IdentityNo +
                "\n-------------------------\nRecord No:  " + ogr.recordNo +"\nField :  "+ogr.Field+"\nWeekly Schedule Hour:  "+ogr.WeeklyScheduleHour+"\nSalary: "+ogr.Salary + " $");
        }

        private void txtMudur_Click(object sender, EventArgs e)
        {
            Headmaster mud = new Headmaster();
            mud.Name = "AAA";
            mud.Surname = "BBB";
            mud.IdentityNo = "642323423564";

            mud.RoomNo = "2/321";
            mud.recordNo = "543543";
            mud.Field = "Biology";
            mud.Salary = 1500;

            MessageBox.Show("Headmaster Information\n\nName:  " + mud.Name + "\nSurname:  " + mud.Surname + "\nIdentity No:  " + mud.IdentityNo +
                 "\n-------------------------\nRoom no:  " + mud.RoomNo + "\nRecord No:  " + mud.recordNo + "\nField: " + mud.Field + "\nSalary:  " + mud.Salary+" $");
        }

        private void txtMemur_Click(object sender, EventArgs e)
        {
            // Here we can add more person information which we want to show. 
            MessageBox.Show("Please enter new person information !");
        }
    }
}
