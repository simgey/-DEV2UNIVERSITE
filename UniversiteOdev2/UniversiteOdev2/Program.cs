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
                            Console.WriteLine("5-Ogrenci ekle");
                            Console.WriteLine("6-Ogrenci sil");
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
                                        Console.WriteLine("Ogretim uyesi silmek istediğiniz bolumun id numarasını giriniz:");
                                        bolumid = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Eklemek istediğiniz ogretim uyesinin id numarasını giriniz:");
                                        ogruyesiid = Convert.ToInt32(Console.ReadLine());
                                        Bolum b = new Bolum(bolumid, bolumad);
                                        b.DersSil(ogruyesiid);
                                        break;
                                    }
                                case 5://ogrenci ekle
                                    {
                                        int bolumid;
                                        string bolumad;
                                        int ogrenciid;
                                         string ogrenciad;
                                        int ogrencidurum;
                                        Console.WriteLine("Ogrenci kaydetmek istediğiniz bolumun id numarasını giriniz:");
                                        bolumid = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Ogrenci kaydetmek istediğiniz bolumun adını giriniz:");
                                        bolumad = Console.ReadLine();
                                        Console.WriteLine("Kaydetmek istediğiniz ogrencinin id numarasını giriniz: ");
                                        ogrenciid = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Kaydetmek istediğiniz ogrencinin adini giriniz:");
                                        ogrenciad = Console.ReadLine();
                                        Console.WriteLine("Kaydetmek istediğiniz ogrencinin durumunu giriniz(1-Lisans 2-Yukseklisans 3-Doktora)");
                                        ogrencidurum = Convert.ToInt32(Console.ReadLine());
                                        Bolum b = new Bolum(bolumid, bolumad);
                                        b.OgrenciEkle(ogrenciid,ogrenciad,ogrencidurum);

                                        
                                        break;
                                    }
                                case 6://ogrenci sil
                                    {
                                        int bolumid;
                                        string bolumad;
                                        int ogrenciid;
                                        Console.WriteLine("Ogrenci silmek istediğiniz bolumun id numarasını giriniz:");
                                        bolumid = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Ogrenci silmek istediğiniz bolumun adını giriniz:");
                                        bolumad = Console.ReadLine();
                                        Console.WriteLine("Silmek istediğiniz ogrencinin id numarasını giriniz:");
                                        ogrenciid = Convert.ToInt32(Console.ReadLine());
                                        Bolum b = new Bolum(bolumid, bolumad);
                                        b.OgreciSil(ogrenciid);

                                        break;
                                    }
                            }



                            break;
                        }
                    case 4:// ders islemleri
                        {
                            int m;
                            Console.WriteLine("1-Derse ogrenci ekle");
                            Console.WriteLine("2-Dersten ogrenci sil");
                            Console.WriteLine("3-Derse hoca ekle ");
                            Console.WriteLine("4-Dersten hoca sil");
                            m = Convert.ToInt32(Console.ReadLine());
                            switch(m)
                            {
                                case 1://derse ogrenci ekle
                                    {
                                        int dersid;
                                        string dersad;
                                        int ogrenciid;
                                        string ogrenciad;
                                        int ogrencidurum;
                                        Console.WriteLine("Ogrenci kaydetmek istediğiniz dersin id numarasını giriniz:");
                                        dersid = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Ogrenci kaydetmek istediğiniz dersin adını giriniz:");
                                        dersad = Console.ReadLine();
                                        Console.WriteLine("Kaydetmek istediğiniz ogrencinin id numarasını giriniz: ");
                                        ogrenciid = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Kaydetmek istediğiniz ogrencinin adini giriniz:");
                                        ogrenciad = Console.ReadLine();
                                        Console.WriteLine("Kaydetmek istediğiniz ogrencinin durumunu giriniz(1-Lisans 2-Yukseklisans 3-Doktora)");
                                        ogrencidurum = Convert.ToInt32(Console.ReadLine());
                                        Ders d = new Ders(dersid, dersad);
                                        d.OgreciEkle(ogrenciid, ogrenciad, ogrencidurum);
                                        break;
                                    }
                                case 2://dersten ogrenci sil
                                    {
                                        int dersid;
                                        string dersad;
                                        int ogrenciid;
                                        Console.WriteLine("Ogrenci silmek istediğiniz dersin id numarasını giriniz:");
                                        dersid = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Ogrenci silmek istediğiniz dersin adını giriniz:");
                                        dersad = Console.ReadLine();
                                        Console.WriteLine("Silmek istediğiniz ogrencinin id numarasını giriniz:");
                                        ogrenciid = Convert.ToInt32(Console.ReadLine());
                                        Ders d = new Ders(dersid, dersad);
                                        d.OgrenciSil(ogrenciid);
                                        break;
                                    }
                                case 3://derse hoca ekle
                                    {
                                        int dersid;
                                        string dersad;
                                        int ogruyesiid;
                                        string ogruyesiad;
                                        Console.WriteLine("Ogretim uyesi eklemek istediğiniz dersin adını giriniz:");
                                        dersad = Console.ReadLine();
                                        Console.WriteLine("Ogretim uyesi eklemek istediğiniz dersin  id numarasını giriniz:");
                                        dersid = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Eklemek istediğiniz ogretim uyesinin adını giriniz:");
                                        ogruyesiad = Console.ReadLine();
                                        Console.WriteLine("Eklemek istediğiniz ogretim uyesinin id numarasını giriniz:");
                                        ogruyesiid = Convert.ToInt32(Console.ReadLine());
                                        Ders b = new Ders(dersid,dersad);
                                        b.HocaEkle(ogruyesiid, ogruyesiad);
                                        break;

                                    }
                                case 4:// hocayı değiştir
                                    {
                                        int dersid;
                                        string dersad;
                                        int ogruyesiid;
                                        string ogretimuyesiad2;
                                        int ogruyesiid2;
                                        Console.WriteLine("Ogretim uyesi değiştirmek istediğiniz dersin adını giriniz:");
                                        dersad = Console.ReadLine();
                                        Console.WriteLine("Ogretim uyesi değiştirmek istediğiniz ders id numarasını giriniz:");
                                        dersid = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Değiştirmek istediğiniz ogretim uyesinin id numarasını giriniz:");
                                        ogruyesiid = Convert.ToInt32(Console.ReadLine());
                                        Ders d = new Ders(dersid, dersad);
                                        d.HocaDegistir(ogruyesiid);
                                        Console.WriteLine("Eklemek istediğiniz ogretim uyesinin adını giriniz:");
                                        ogretimuyesiad2 = Console.ReadLine();
                                        Console.WriteLine("Eklemek istediğiniz ogretim uyesinin id numarasını giriniz:");
                                        ogruyesiid2 = Convert.ToInt32(Console.ReadLine());
                                        d.HocaEkle(ogruyesiid2, ogretimuyesiad2);

                                        break;
                                      
                                    }
                            }

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



