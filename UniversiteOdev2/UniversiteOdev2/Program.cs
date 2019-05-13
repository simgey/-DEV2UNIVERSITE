using System;

namespace UniversiteOdev2
{
    class MainClass
    {
       
      public static int  Main(string[] args)
        {
            int x=0;
            do
            {

                Console.WriteLine("1-Universite islemleri icin");
                Console.WriteLine("2-Fakulte islemleri icin");
                Console.WriteLine("3-Bolum islemleri icin");
                Console.WriteLine("4-Ders islemleri icin");
                Console.WriteLine("5-Listeleme islemleri icin");
                Console.WriteLine("6-Cikmak icin:");
                x = Convert.ToInt16(Console.ReadLine());
                switch (x)
                {
                    case 1://universite islemleri
                        {
                            int m;
                            Console.WriteLine("1-Fakulte ekle");
                            Console.WriteLine("2-Fakulte sil");
                            m = Convert.ToInt16(Console.ReadLine());
                            switch (m)
                            {
                                case 1://fakulte ekle
                                    {
                                        int Fakulteid;
                                        string Fakultead;
                                        Console.WriteLine("Eklemek istediğiniz fakultenin id numarasını giriniz:");
                                        Fakulteid = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Fakulte adını giriniz:");
                                        Fakultead = Console.ReadLine();
                                        Universite nesne = Universite.Nesne();
                                        nesne.FakulteEkle(Fakulteid, Fakultead);
                                        break;
                                    }
                                case 2://fakulte sil
                                    {
                                        int Fakulteid;
                                        Console.WriteLine("Silmek istediğiniz fakültenin id numarasını giriniz:");
                                        Fakulteid = Convert.ToInt32(Console.ReadLine());
                                        Universite nesne = Universite.Nesne();
                                        nesne.FakulteSil(Fakulteid);
                                        break;
                                    }
                            }


                            break;
                        }
                    case 2://fakulte islemleri
                        {
                            int z;
                            Console.WriteLine("1-Bolum ekle");
                            Console.WriteLine("2-Bolum sil");
                            z = Convert.ToInt32(Console.ReadLine());
                            switch (z)
                            {
                                case 1://bolum ekle
                                    {
                                        int bolumid;
                                        string bolumad;
                                        int fakulteid;
                                        string fakultead;

                                        Console.WriteLine("Eklemek istediğiniz bölümün fakulte id numarasını giriniz:");
                                        fakulteid = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Eklemek istediğiniz bölümün fakulte adını giriniz:");
                                        fakultead = Console.ReadLine();
                                        Console.WriteLine("Eklemek istediğiniz bölümün id numarasını giriniz: ");
                                        bolumid = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Eklemek  istediğiniz fakültenin adını giriniz:");
                                        bolumad = Console.ReadLine();
                                        Fakulte f = new Fakulte(fakulteid, fakultead);
                                        f.BolumEkle(bolumid, bolumad);


                                        break;
                                    }
                                case 2: //bolum sil
                                    {
                                        int fakulteid;
                                        int bolumid;
                                        string fakultead;
                                        Console.WriteLine("Silmek istediğiniz bölümün fakulte id numarasını giriniz:");
                                        fakulteid = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Silmek istediğiniz bölümün fakulte adını giriniz:");
                                        fakultead = Console.ReadLine();
                                        Console.WriteLine("Silmek istediğiniz bölümün id numarasını giriniz:");
                                        bolumid = Convert.ToInt32(Console.ReadLine());
                                        Fakulte f = new Fakulte(fakulteid, fakultead);
                                        f.BolumSil(bolumid);
                                        break;
                                    }
                            }

                            break;
                        }
                    case 3://bolum islmeleri
                        {


                            int k;
                            Console.WriteLine("1-Ders ekle");
                            Console.WriteLine("2-Ders sil");
                            Console.WriteLine("3-Ogretim uyesi ekle");
                            Console.WriteLine("4-Ogretim uyesi sil");
                            k = Convert.ToInt32(Console.ReadLine());
                            switch (k)
                            {
                                case 1://ders ekle
                                    {
                                        int bolumid;
                                        string bolumad;
                                        int dersid;
                                        string dersad;
                                        Console.WriteLine("Ders eklemek istediğiniz bolumun id numarsını giriniz:");
                                        bolumid = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Ders eklemek istediğiniz bolumun adını giriniz:");
                                        bolumad = Console.ReadLine();
                                        Console.WriteLine("Eklemek istediğiniz dersin adını giriniz:");
                                        dersad = Console.ReadLine();
                                        Console.WriteLine("Eklemek istediğiniz dersin id numarasını giriniz:");
                                        dersid = Convert.ToInt32(Console.ReadLine());
                                        Bolum b = new Bolum(bolumid, bolumad);
                                        b.DersEkle(dersid, dersad);
                                         break;
                                    }
                                case 2://ders sil
                                    {
                                        int bolumid;
                                        string bolumad;
                                        int dersid;
                                        Console.WriteLine("Ders silmek istediğiniz bolumun adını giriniz:");
                                        bolumad = Console.ReadLine();
                                        Console.WriteLine("Ders silmek istediğiniz bolumun adını giriniz:");
                                        bolumid = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Eklemek istediğiniz dersin id numarasını giriniz:");
                                        dersid = Convert.ToInt32(Console.ReadLine());
                                        Bolum b = new Bolum(bolumid, bolumad);
                                        b.DersSil(dersid);
                                        break;
                                    }
                                case 3://ogretim uyesi ekle
                                    {
                                        int bolumid;
                                        string bolumad;
                                        int ogruyesiid;
                                        string ogruyesiad;
                                        Console.WriteLine("Ogretim uyesi eklemek istediğiniz bolumun adını giriniz:");
                                        bolumad = Console.ReadLine();
                                        Console.WriteLine("Ogretim uyesi eklemek istediğiniz bolumun adını giriniz:");
                                        bolumid = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Eklemek istediğiniz ogretim uyesinin adını giriniz:");
                                        ogruyesiad = Console.ReadLine();
                                        Console.WriteLine("Eklemek istediğiniz ogretim uyesinin id numarasını giriniz:");
                                        ogruyesiid = Convert.ToInt32(Console.ReadLine());
                                        Bolum b = new Bolum(bolumid, bolumad);
                                        b.OgrElemaniEkle(ogruyesiid, ogruyesiad);
                                        break;
                                    }
                                case 4://ogretim uyesi sil
                                    {
                                        int bolumid;
                                        string bolumad;
                                        int ogruyesiid;
                                        Console.WriteLine("Ogretim uyesi silmek istediğiniz bolumun adını giriniz:");
                                        bolumad = Console.ReadLine();
                                        Console.WriteLine("Ogretim uyesi silmek istediğiniz bolumun adını giriniz:");
                                        bolumid = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Eklemek istediğiniz ogretim uyesinin id numarasını giriniz:");
                                        ogruyesiid = Convert.ToInt32(Console.ReadLine());
                                        Bolum b = new Bolum(bolumid, bolumad);
                                        b.DersSil(ogruyesiid);
                                        break;
                                    }
                            }



                            break;
                        }
                    case 4:// ders islemleri
                        {
                            break;
                        }
                    case 5://listeleme islemleri
                        {
                            Listele l = new Listele();
                            l.Listelemeİslemleri();
                         
                            break;
                        }
                }




            } while (x != 6);
            return 0;
            }
        }
    }



