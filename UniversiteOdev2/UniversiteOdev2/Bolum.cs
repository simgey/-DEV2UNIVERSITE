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
            Console.WriteLine("2-Ders Sil");
            Console.WriteLine("3-Ogrenci Ekle");
            Console.WriteLine("4-Ogrenci Sil");
            Console.WriteLine("5-Ogretim Uyesi Ekle");
            Console.WriteLine("6-Ogretim Uyesi Sil");

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
                        DersSil();
                        break;
                    }
                case 3:
                    {
                        OgrenciEkle();
                        break;
                    }
                case 4:
                    {
                        OgrenciSil();
                        break;
                    }
                case 5:
                    {
                        OgretimUyesiEkle();
                        break;
                    }
                case 6:
                    {
                        OgretimUyesiSil();
                        break;
                    }
            }
        }
        public void DersEkle()
        {
            int DersID;
            string DersAd;
            string BolumAd;

            Console.WriteLine("Eklemek İstediğiniz Dersin Bölümünü Giriniz:");
            BolumAd = Console.ReadLine();
            Console.WriteLine("Eklemek İsediğiniz Dersin ID Numarasını Giriniz:");
            DersID= Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Eklemek İstediğiniz Dersin Adını Giriniz:");
            DersAd = Console.ReadLine();
            Ders.Add(DersID, DersAd);
          


        }
        public void DersSil()
        {
            int DersID;
            string bolumAd;
            Console.WriteLine("Silmek istediğiniz Dersin Hangi Bölümde Olduğunu Giriniz:");
            bolumAd=Console.ReadLine();
            Console.WriteLine("Silmek İsediğiniz Dersin ID Numarasını Giriniz:");
            DersID = Convert.ToInt16(Console.ReadLine());
            Ders.Remove(DersID);

        }
        public void OgrenciEkle()
        {
            int  OgrenciID;
            string OgrenciAdi;
            Console.WriteLine("Eklemek İsediğiniz Ogrencinin ID Numarasını Giriniz:");
            OgrenciID = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Eklemek İstediğiniz Ogrencinin Adını Giriniz:");
            OgrenciAdi = Console.ReadLine();
            Ogrenci.Add(OgrenciID, OgrenciAdi);
        }
        public void OgrenciSil()
        {
            int OgrenciID;
           
            Console.WriteLine("Silmek İsediğiniz Ogrencinin ID Numarasını Giriniz:");
            OgrenciID = Convert.ToInt16(Console.ReadLine());
            Ogrenci.Remove(OgrenciID);
        }
        public void OgretimUyesiEkle()
        {
            int OgretimUyesiID;
            string OgretimUyesiAd;
            Console.WriteLine("Eklemek İsediğiniz Ogretim Uyesinin ID Numarasını Giriniz:");
            OgretimUyesiID = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Eklemek İstediğiniz Ogretim Uyesinin Adını Giriniz:");
            OgretimUyesiAd= Console.ReadLine();
            OgretimUyesi.Add(OgretimUyesiID,OgretimUyesiAd);
        }
        public void OgretimUyesiSil()
        {
            int OgretimUyesiID;
           
            Console.WriteLine("Silmek İsediğiniz Ogretim Uyesinin ID Numarasını Giriniz:");
            OgretimUyesiID = Convert.ToInt16(Console.ReadLine());
            OgretimUyesi.Remove(OgretimUyesiID);
        }

    }
}
