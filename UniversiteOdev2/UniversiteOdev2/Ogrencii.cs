using System;
namespace UniversiteOdev2
{
    public  class Ogrencii
    {
        int No;
        string Ad;
        string Soyad;
        string Bolum;

        public int no
        { 
            get { return No; }
            set { No = value; }

        }
        public string ad
        {
            get { return Ad; }
            set { Ad = value; }
        }
        public string soyad
        {
            get { return Soyad; }
            set { Soyad = value; }
        }
        public string bolum
        {
            get { return Bolum; }
            set { Bolum = value; }
        }
    
        public Ogrencii(int No,string Ad,string Soyad, string Bolum)
        {
            this.no = No;
            this.ad = Ad;
            this.soyad = Soyad;
            this.bolum = Bolum;
        }
    }
    public class Lisans:Ogrencii
    {
        public Lisans(int No, string Ad, string Soyad, string Bolum):base(No,Ad, Soyad, Bolum)
        {
            this.no = No;
            this.ad = Ad;
            this.soyad = Soyad;
            this.bolum = Bolum;
        }

    }
    public class YuksekLisans:Ogrencii
    {
        public YuksekLisans(int No,string Ad,string Soyad,string Bolum):base(No,Ad,Soyad,Bolum)
        {
            this.no = No;
            this.ad = Ad;
            this.soyad = Soyad;
            this.bolum = Bolum;
        }
    }
    public class Doktora:Ogrencii
    {
        public Doktora(int No, string Ad, string Soyad, string Bolum) : base(No, Ad, Soyad, Bolum)
        {
            this.no = No;
            this.ad = Ad;
            this.soyad = Soyad;
            this.bolum = Bolum;
        }

    }
}
