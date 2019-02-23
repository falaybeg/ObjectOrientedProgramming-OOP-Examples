using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Static
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
            stu.Name = "Name 1";
            Student stu2 = new Student();
            stu2.Name = "Name 2";
            
            // Static defined Total Student number is showed in MessageBox
            MessageBox.Show("Student Number : "+Student.StudentCount.ToString());
        }
    }
}
