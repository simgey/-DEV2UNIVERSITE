using System;

namespace UniversiteOdev2
{
    class MainClass
    {
        static int x = 0;

      public static int  Main(string[] args)
        {

            do
            {
                Console.WriteLine("Secmek İstediğiniz İslemi Giriniz");
                Console.WriteLine("1-Universite İslemleri");//Fakulte Ekleyip Cıkartma işlemleri
                Console.WriteLine("2-Fakulte İslemleri ");//Bolum Ekleyip çıkartma işlemleri
                Console.WriteLine("3-Bolum İslemleri");//ogrenci,ders,Ogretim elemanı 
                Console.WriteLine("4-Ders İslemleri");//ogretimelemanı,şube,Ogrenci
                Console.WriteLine("5-Ogretim Gorevlisi İslemleri");//Ders ekle sil
                Console.WriteLine("6-Ogrenci İslemleri");//Ders ekle sil
                Console.WriteLine("7-Fakulteye-Bolumlere Ait Dersleri Listele");
                Console.WriteLine("8-Cık");
                x = Convert.ToInt16(Console.ReadLine());

                switch (x)
                {
                    case 1:
                        {
                            Universite U = new Universite();
                            U.UniversiteIslemleri();
                            break;
                        }
                    case 2:
                        {
                            Fakulte F = new Fakulte();
                            F.FakulteIslemleri();
                            break;
                        }
                    case 3:
                        {
                            Bolum B = new Bolum();
                            B.BolumIslemleri();
                            break;
                           
                        }
                    case 4:
                        {
                            Ders D = new Ders();


                            break;
                        }
                    case 5:
                        {
                            break;
                        }
                    case 6:
                        {

                            break;
                        }
                    case 7:
                        {
                            break;
                        }
                    case 8:
                        {
                            return -1;

                        }
                }
            } while (x != 0);

            return 0;
            }
        }
    }



