using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Abstaction
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
            AccountClient client = new AccountClient();
            client.CurrentCode = "AB6494984";

            // AccountClient contains getBankList()
            // We send created client object to the TransferMoney function. But it is accepted by function. 
            // Because AccountClient was inherited Account class and AccountClient is also in Account class.
            TransferMoney(client);

            AccountSupplier supplier = new AccountSupplier();
            supplier.CurrentCode = "AB12345";
            TransferMoney(supplier);
            MessageBox.Show("Money Transfer completed successfuly !");

        }
        // We called Bank list from abstract Account class
        
        void TransferMoney(Account a)
        {
            string[] banks = a.getBankList();
        }
    }
}
