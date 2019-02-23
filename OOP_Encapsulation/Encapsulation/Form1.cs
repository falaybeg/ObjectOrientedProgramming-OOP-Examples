using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtAdi.Focus();
        }

 

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void averageCalculate_Click(object sender, EventArgs e)
        {
            Student o = new Student();
            try
            {
                o.Name = txtAdi.Text;
                o.Midterm = Convert.ToDouble(txtVize.Text);
                o.Final = Convert.ToDouble(txtFinal.Text);
                MessageBox.Show("Sayin " + o.Name + "\n\nAverage: " + o.Average);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bonusCalculate_Click(object sender, EventArgs e)
        {
            Student o = new Student();

            try
            {
                o.Name = txtAdi.Text;
                o.BirthDay = dateTimePicker1.Value;
                o.HiredDate = dateTimePicker2.Value;
                o.BonusPrice = Convert.ToDouble(txtPrim.Text);
                MessageBox.Show("Dear " + o.Name + "\n\nAge: " + o.Age.ToString() +
                    "\nNumber of Worked days: " + o.calistigiGun.ToString() +
                    "\nCompensation: " + o.BonusPrice.ToString() + " $");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}




