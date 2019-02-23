using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Struct_Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Select Day...";
            foreach (var item in Enum.GetValues(typeof(Days)))
            {
                comboBox1.Items.Add(item);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
            try
            {
                stu.Midterm = Convert.ToDouble(txtMidterm.Text);
                stu.Final = Convert.ToDouble(txtFinal.Text);

                MessageBox.Show("Lecture Status: " + stu.status.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           MessageBox.Show("Day Name : " + comboBox1.SelectedItem.ToString());
        }
    }
}
