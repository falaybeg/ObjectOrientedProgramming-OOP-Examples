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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }


        List <Employee> employee = new List<Employee>();
        int count = 0;
        public void EmployeeAdd(Employee newEmployee)
        {
            // Here we add employees to the listbox from RegistrationScreen
            employee.Add(newEmployee);
            listBox1.Items.Add("["+newEmployee.IdentityNo + "] - " + newEmployee.Name + " " + newEmployee.Surname+" ("+newEmployee.Salary+" $)");
            count++;
        }

     

        // Here we remove/delete employee from listbox 
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select current Employee !");
            }
            else
            {
                Employee sil = employee[listBox1.SelectedIndex];
                employee.Remove(sil);
                listBox1.Items.Remove(listBox1.SelectedItem);
                count--;
                
            }
          

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Employees_Load(object sender, EventArgs e)
        {

        }
    }
}
