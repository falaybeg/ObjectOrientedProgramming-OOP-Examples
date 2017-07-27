using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Ogrenci
    {
        private string adi;

        public string Adi
        {
            get { return adi; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Lutfen Isminizi Giriniz !");
                else
                    adi = value;
            }
        }

        private DateTime dogumTarihi;
        public DateTime DogumTarihi
        {
            get { return this.dogumTarihi; }
            set
            {
                if (value > DateTime.Now)
                    throw new Exception("Bugunun tarihinde buyuk atanamaz...!");
                else
                    this.dogumTarihi = value;

            }
        }
        public int Yas
        {
            get
            {
                return (int)((DateTime.Now - this.DogumTarihi).Days / 365);
            }
        }

        private DateTime iseGiris;
        public DateTime IseGiris
        {
            get { return this.iseGiris; }
            set
            {
                if (value > DateTime.Now)
                    throw new Exception("Bugunun tarihinden buyuk deger atayamazsiniz...!");
                else
                    this.iseGiris = value;

            }
        }

        public int calistigiGun
        {
            get
            {
                return (int)((DateTime.Now - this.IseGiris).TotalDays);
            }
        }

        private double prim;
        public double PrimFiyat
        {
            get
            {
                return this.prim * this.calistigiGun;
            }
            set
            {
                if (value < 10)
                {
                    throw new Exception("Prim 10 TL'den kucuk olamaz\n10 TL minimum olarak ayarlandi !");
                    value = 10;

                }
                else if (value > 50)
                {
                    throw new Exception("Tazminat 50 TL'den buyuk olamaz\n50 TL default ayarlandi !");
                    value = 50;

                }
                this.prim = value;
            }

        }



        double vize;
        double final;
        public double Vize
        {
            get
            {
                return this.vize;
            }
            set
            {
                if (value >= 0 && value <= 100)
                    this.vize = value;
                else
                    throw new Exception("Yanlis Vize araligi girdiniz !!!");
            }
        }
        public double Final
        {
            get
            {
                return this.final;
            }
            set
            {
                if (value >= 0 && value <= 100)
                    this.final = value;
                else
                    throw new Exception("Yanlis Final araligi girdiniz !!!");
            }
        }
        public double Ortalama
        {
            get
            {
                return (Vize * 0.4) + (Final * 0.6);
            }
        }

    }
}
