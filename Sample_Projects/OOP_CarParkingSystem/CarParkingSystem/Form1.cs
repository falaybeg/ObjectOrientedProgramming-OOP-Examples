using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParkingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vehicle v = new Vehicle();
            v.Plate = txtPlateNo.Text;
            v.Type = (VehicleType)listbox_VehicleType.SelectedItem;
            v.Contact = checkBox_Contact.Checked;
            v.Subscribe = checkBox_Subscriber.Checked;

            listBox_Vehicles.Items.Add(v);
        }

        List<Vehicle> exitVehicle = new List<Vehicle>();
        private void Form1_Load(object sender, EventArgs e)
        {
            listbox_VehicleType.Items.Add(new VehicleType { Name = "Car (1)", Price = 1 });
            listbox_VehicleType.Items.Add(new VehicleType { Name = "Mini Bus (2)", Price = 2 });
            listbox_VehicleType.Items.Add(new VehicleType { Name = "Bus (3)", Price = 3 });
            listbox_VehicleType.Items.Add(new VehicleType { Name = "Truck (4)", Price = 4 });
        }

        private void listBox_Vehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Vehicles.SelectedItem == null) return;
            Vehicle selected = (Vehicle)listBox_Vehicles.SelectedItem;

            selected.ExitTime = DateTime.Now;
            lbl_plate.Text = selected.Plate;
            lbl_hour.Text = selected.Time.ToString();
            lbl_fee.Text = selected.Price.ToString();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox_Vehicles.SelectedItems == null) return;

            Vehicle selected = (Vehicle)listBox_Vehicles.SelectedItem;
            exitVehicle.Add(selected);
            listBox_Vehicles.Items.Remove(selected);

        }

        private void button_dailyreport_Click(object sender, EventArgs e)
        {
            Report form = new Report();
            decimal total = 0;

            foreach(Vehicle item in exitVehicle)
            {
                ListViewItem li = new ListViewItem();
                li.Text = item.Plate;
                li.SubItems.Add(item.Type.Name);
                li.SubItems.Add(item.Subscribe ? "Subscribe" : "UnSubscribe");
                li.SubItems.Add(item.Time.ToString());
                li.SubItems.Add(item.Price.ToString());
                form.listView1.Items.Add(li);
                total = total + item.Price;
            }
            form.lbl_totalFee.Text = total.ToString();
            form.lbl_totalVehicle.Text = exitVehicle.Count.ToString();
            form.Show();

        }

        private void listBox_Vehicles_ContextMenuStripChanged(object sender, EventArgs e)
        {

        }
    }
}
