using System;
using System.Collections.Generic;

namespace UniversiteOdev2
{  
    public class Bolum
    {
        Dictionary<int, string> Ogrenci = new Dictionary<int, string>();
        Dictionary<int, string> Ders = new Dictionary<int, string>();
        Dictionary<int, string> OgretimUyesi = new Dictionary<int, string>();

        public void BolumIslemleri()
        {
            int x;
            Console.WriteLine("1-Ders Ekle");
            Console.WriteLine("2-Ogrenci Ekle");
            Console.WriteLine("3-Ogretim Uyesi Ekle");
            x = Convert.ToInt16(Console.ReadLine());

            switch(x)
            {
                case 1:
                    {
                        DersEkle();
                        break;
                    }
                case 2:
                    {
                        OgrenciEkle();
                        break;
                    }
                case 3:
                    {
                        OgretimUyesiEkle();
                        break;
                    }
            }
        }
        public void DersEkle()
        {
            int DersID;
            string DersAd;
            Console.WriteLine("Eklemek İsediğiniz Dersin ID Numarasını Giriniz:");
            DersID= Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Eklemek İstediğiniz Dersin Adını Giriniz:");
            DersAd = Console.ReadLine();
            Ders.Add(DersID, DersAd);

        }
        public void OgrenciEkle()
        {
          int  OgrenciID;
          string OgrenciAdi;

        }
        public void OgretimUyesiEkle()
        {
            int OgretimUyesiID;
            string OgretimUyesiAd;
            Console.WriteLine("Eklemek İsediğiniz Ogretim Uyesinin ID Numarasını Giriniz:");
            OgretimUyesiID = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Eklemek İstediğiniz Ogretim Uyesinin Adını Giriniz:");
            OgretimUyesiAd= Console.ReadLine();
            OgretimUyesi.Add(OgretimUyesiID, OgretimUyesiAd);
        }

    }
}
