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

        private void button1_Click(object sender, EventArgs e)
        {

            Ogrenci o = new Ogrenci();

            try
            {
                o.Adi = txtAdi.Text;
                o.DogumTarihi = dateTimePicker1.Value;
                o.IseGiris = dateTimePicker2.Value;
                o.PrimFiyat = Convert.ToDouble(txtPrim.Text);
                MessageBox.Show("Sayin " + o.Adi + "\n\nYas: " + o.Yas.ToString() +
                    "\nCalistigi Gun Sayisi: " + o.calistigiGun.ToString() +
                    "\nTazminati: " + o.PrimFiyat.ToString() + " TL");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtAdi.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Ogrenci o = new Ogrenci();
            try
            {
                o.Adi = txtAdi.Text;
                o.Vize = Convert.ToDouble(txtVize.Text);
                o.Final = Convert.ToDouble(txtFinal.Text);
                MessageBox.Show("Sayin " + o.Adi + "\n\nNot Ortalamasi: " + o.Ortalama);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}