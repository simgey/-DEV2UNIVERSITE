using System;
using System.Collections.Generic;
namespace UniversiteOdev2
{
    public class Ders:Bolum
    {
        Dictionary<int, int> Sube = new Dictionary<int,int>();
        Dictionary<int, string> OgretimElemani = new Dictionary<int, string>();
        Dictionary<int, string> Ogrenci = new Dictionary<int, string>();       
           public void Dersİslemleri()
        {
            int x;
            Console.WriteLine("1-Derse Şube Ekle");
            Console.WriteLine("2-Derse Ogretim Elemanİ Ekle:");
            Console.WriteLine("3-Dersin Ogretim Elemanini Degistir");
            Console.WriteLine("4-Derse Ogrenci Ekle");
            Console.WriteLine("5-Dersten Ogrenci Sil");
            x = Convert.ToInt16(Console.ReadLine());
           switch(x)
            {
                case 1:
                    {
                        SubeEkle();
                        break;
                    }
                case 2:
                    {
                        OgrElemaniEkle();
                        break;
                    }
                case 3:
                    {
                        OgrElemaniDegistir();
                        break;
                    }
                case 4:
                    {
                        OgrEkle();
                        break;
                    }
                case 5:
                    {
                        OgrSil();
                        break;
                    }

            }

        }
        public void SubeEkle()

        {
            int DersID;
            int SubeID;
            Console.WriteLine("Sube Eklemek İstediğiniz Dersin ID Numarasını Giriniz:");
            DersID = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Sube Kodunu Giriniz:");
            SubeID = Convert.ToInt16(Console.ReadLine());
            Sube.Add(DersID, SubeID);

            
        }
        public void OgrElemaniEkle()
        {
            int  OgrElemanıID;
            string  OgrElemanıDersAdi;
            Console.WriteLine("Ogretim Elemani Eklemek İstediğiniz Dersin Adını Giriniz:");
            OgrElemanıDersAdi = Console.ReadLine();
            Console.WriteLine("Ogretim Elemani ID Numarasini Giriniz:");
            OgrElemanıID = Convert.ToInt16(Console.ReadLine());
            OgretimElemani.Add(OgrElemanıID, OgrElemanıDersAdi);

        }
        public void OgrElemaniDegistir()
        {
            int OgrElemanıID;
            string OgrElemanıDersAdi;
            Console.WriteLine("Ogretim Elemanini Silmek İstediğiniz Dersin Adını Giriniz:");
            OgrElemanıDersAdi = Console.ReadLine();
            OgretimElemani.Remove(Convert.ToInt16( OgrElemanıDersAdi));
            Console.WriteLine("Ogretim Elemani Eklemek İstediğiniz Dersin Adını Giriniz:");
            OgrElemanıDersAdi = Console.ReadLine();
            Console.WriteLine("Ogretim Elemani ID Numarasini Giriniz:");
            OgrElemanıID = Convert.ToInt16(Console.ReadLine());
            OgretimElemani.Add(OgrElemanıID, OgrElemanıDersAdi);
        }
        public void OgrEkle()
        {
            int OgrID;
            string OgrDers;
            Console.WriteLine("Ogrenci Eklemek İstediğiniz Dersin Adını Giriniz:");
            OgrDers = Console.ReadLine();
            Console.WriteLine("Ogrenci ID Numarasını Giriniz:");
            OgrID = Convert.ToInt16(Console.ReadLine());
            Ogrenci.Add(OgrID, OgrDers);
            }

        public void OgrSil()
        {
            int OgrID;
            string OgrDers;
            Console.WriteLine("Ogrenci Silmek İstediğiniz Dersin Adını Giriniz:");
            OgrDers = Console.ReadLine();
            Console.WriteLine("Ogrenci ID Numarasını Giriniz:");
            OgrID = Convert.ToInt16(Console.ReadLine());
            bool varmi = Ogrenci.TryGetValue(0, out OgrDers);
            if(varmi)
            {
                Ogrenci.Remove(OgrID);
            }

        }
    }
}
