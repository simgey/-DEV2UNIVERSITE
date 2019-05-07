using System;
using System.Collections.Generic;
namespace UniversiteOdev2
{
    public class Fakulte:Universite
    {
        Dictionary<int, string> Bolum= new Dictionary<int, string>();
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
            Console.WriteLine("Eklemek İsediğiniz Dersin ID Numarasını Giriniz:");
            BolumID = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Eklemek İstediğiniz Dersin Adını Giriniz:");
            BolumAd = Console.ReadLine();
            Bolum.Add(BolumID, BolumAd);
        }
        public void BolumSil()
        {
            int BolumID;
            Console.WriteLine("Silmek İsediğiniz Dersin ID Numarasını Giriniz:");
            BolumID = Convert.ToInt16(Console.ReadLine());
            Bolum.Remove(BolumID);
        }
    }
}
