using System;
using System.Collections.Generic;
namespace UniversiteOdev2
{
    public class Fakulte:Universite
    {
        public  string Fakultead;
        public  int Fakulteid;
        public string fakultead
        {
            get
            {
                return Fakultead;
            }
            set
            {
                Fakultead = value;
            }
        }

        public int fakulteid { get; set; }

        public Fakulte(string Fakultead,int Fakulteid)
        {
            this.Fakultead = fakultead;
            this.Fakulteid = fakulteid;
        }


        public Dictionary<int, Ders> Bolum = new Dictionary<int, Ders>();
        public void FakulteIslemleri()
        {
            int x;
            Console.WriteLine("1-Bolum Ekle");
            Console.WriteLine("2-Bolum Sil");
            x = Convert.ToInt16(Console.ReadLine());
            switch(x)
            {
                case 1:
                    {
                        BolumEkle();
                        break;
                    }
                case 2:
                    {
                        BolumSil();
                        break;
                    }
            }
        }
        public void BolumEkle()
        {  
            int BolumID;
            string BolumAd;
            string FakulteAD;
            Console.WriteLine("Bolum eklemek istediğiniz fakultryi giriniz:");
            FakulteAD = Console.ReadLine();

            Console.WriteLine("Eklemek İsediğiniz Bolumun ID Numarasını Giriniz:");
            BolumID = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Eklemek İstediğiniz Bolumun Adını Giriniz:");
            BolumAd = Console.ReadLine();


        }
        public void BolumSil()
        {
            int BolumID;
            int FakulteID;
            Console.WriteLine("Silmek İstediğiniz Bolumun Fakulte ID sini Giriniz:");
            FakulteID = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Silmek İsediğiniz Bolumun ID Numarasını Giriniz:");
            BolumID = Convert.ToInt16(Console.ReadLine());
            Bolum.Remove(BolumID);
            if(FakulteID==BolumID)
            {

             }
          
        }
    }
}
