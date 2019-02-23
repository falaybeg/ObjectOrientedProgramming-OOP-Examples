using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPClassObject
{
    public class Employee
    {
        public string Name;
        public string Surname;
        public string IdentityNo;
        public decimal Salary;
        public DateTime RegistrationDate;

    
    
       public void Create(Employee yeni)
        {

        }
        decimal PaySalary()
        {
            return 0;
        }

        public void Delete(Employee kov, ListBox listbox)
        {
            listbox.Items.Remove(listbox.SelectedItem);
        }

    }
}
