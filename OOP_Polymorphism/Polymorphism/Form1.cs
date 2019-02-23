using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorhism
{
    public partial class Polymorphism : Form
    {
        public Polymorphism()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Student stu = new Student();

            stu.Name = txtAd.Text;
            stu.Surname = txtSoyad.Text;
            stu.Midterm = numericUPvize.Value;
            stu.Final = numericUPfinal.Value;

            listBox1.Items.Add(stu);

            // toString() method in Student class was overrided and It will return only Name and Surname
            MessageBox.Show(stu.ToString());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if in listbox doesn't selected any item don't run the below codes.
            if (listBox1.SelectedIndex == -1) return;

            Student secilen = (Student)listBox1.SelectedItem;
            txtAd.Text = secilen.Name;
            txtSoyad.Text = secilen.Surname;
            numericUPvize.Value = secilen.Midterm;
            numericUPfinal.Value = secilen.Final;

            
        }

     

        private void HumaAge_Click(object sender, EventArgs e)
        {
            Human human = new Human();

            human.dateOfBirth = dateTimePicker.Value;
            if (human.dateOfBirth > DateTime.Now)
            {
                MessageBox.Show("Entered date cannot be bigger than now datetime !");
            }
            else
            {
                MessageBox.Show("Human\n\nAge :  " + human.Age().ToString());
            }
        }

        private void StudentAge_Click(object sender, EventArgs e)
        {
            Student student = new Student();

            student.dateOfBirth = dateTimePicker.Value;

            if (student.dateOfBirth > DateTime.Now)
            {
                MessageBox.Show("Entered date cannot be bigger than now datetime !");
            }
            else
            {
                MessageBox.Show("Student\n\nMy Total Lived Days :  " + student.Age().ToString());
            }
        }

        private void Polymorphism_Load(object sender, EventArgs e)
        {

        }
    }
}
