using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPClassObject
{
    public partial class RegistrationScreen : Form
    {
        public RegistrationScreen()
        {
            InitializeComponent();
        }

        Employees formEmployee = new Employees();
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            // Here we register a new employee to be added to the listbox
            Employee employee = new Employee();
            employee.Name = textBox1.Text;
            employee.Surname = textBox2.Text;
            employee.IdentityNo = textBox3.Text;
            employee.Salary = numericUpDown1.Value;


            formEmployee.EmployeeAdd(employee);

            textBox1.Text = textBox2.Text = textBox3.Text = "";
            numericUpDown1.Value = 0;
            textBox1.Focus();
            sayac++;
        }

        void PersonEl(Employee yenikisi)
        {
             
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formEmployee.Show();
        }

        private void ad_Click(object sender, EventArgs e)
        {

        }
    }
    

}
