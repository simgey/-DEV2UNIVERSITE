using System;
using System.Collections.Generic;
namespace UniversiteOdev2
{
    public class Listele
    {
        public void Listelemeİslemleri()
        {
            int fakulteid;
            int bolumid;
            int dersid;
            Console.WriteLine("Dokuz Eylül Üniversitesi Ders/Ogrenci/Ogretimuyesi Sorgulama Ekrani");
            Console.WriteLine("İslem yapmak istediğiniz fakultenin id numarasını giriniz:");
            foreach (Fakulte u in Universite.FakulteDictionary.Values)
            {
                Console.WriteLine(u.fakulteid + "-" + u.fakultead);
            }
            fakulteid = Convert.ToInt32(Console.ReadLine());
            Fakulte f;
            Bolum bolum;

            if (Universite.FakulteDictionary.TryGetValue(fakulteid, out f))
            {
                foreach (int l in Universite.FakulteDictionary.Keys)
                {
                    if (fakulteid == l)
                    {
                        foreach (Bolum b in Fakulte.BolumDictionary.Values)
                        {
                            Console.WriteLine(b.bolumid + " -" + b.bolumad);

                        }
                        Console.WriteLine("İslem yapmak istediğiniz bölümün id numarasını giriniz:");
                        bolumid = Convert.ToInt32(Console.ReadLine());
                        if (Fakulte.BolumDictionary.TryGetValue(bolumid, out bolum))
                        {
                            foreach (int d in Bolum.DersDictionary.Keys)
                            {
                                if (bolumid == d)
                                {
                                    foreach (Ders ders in Bolum.DersDictionary.Values)
                                    {
                                        Console.WriteLine(ders.dersId + "-" + ders.dersAd);
                                    }
                                }
                                Console.WriteLine("1-Ders Listele");
                                Console.WriteLine("2-Ogrenci Listele");
                                Console.WriteLine("3-Ogretim Uyesi Listele");

                                Console.WriteLine("Secim yapmak istediğiniz islemi giriniz:");
                                int secim;
                                secim = Convert.ToInt32(Console.ReadLine());
                                switch (secim)
                                {
                                    case 1:
                                        {
                                            DersListele();
                                            break;
                                        }
                                    case 2:
                                        {
                                            OgrenciListele();
                                            break;
                                        }
                                    case 3:
                                        {
                                            OgretimUyesiListele();
                                            break;
                                        }
                                }


                            }
                        }
                        else
                        {
                            Console.WriteLine("Yanlıs id girdiniz");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Yanlıs id giridiniz:");
            }


        }
        public void DersListele()//Ders listeleyen method
        { 
             Ders B;
            int dersid;
            Console.WriteLine("İslem yapmak istediğiniz dersin id numarasını giriniz:");
            dersid = Convert.ToInt32(Console.ReadLine());
            if (Bolum.DersDictionary.TryGetValue(dersid, out B)) 
            {

                  foreach(int i in Bolum.DersDictionary.Keys)
                {
                    Console.WriteLine(B.dersId + "--" + B.dersAd);
                }
            }
            else
            {
                Console.WriteLine("Yanlıs id girdiniz");
            }

        }


       


        public void OgrenciListele()
        {
            int dersid;
            Console.WriteLine("İslem yapmak istediğiniz dersin id numarasını gririniz:");
            dersid = Convert.ToInt32(Console.ReadLine());

        }

        public void OgretimUyesiListele()
        {

        }
    } 
   }
