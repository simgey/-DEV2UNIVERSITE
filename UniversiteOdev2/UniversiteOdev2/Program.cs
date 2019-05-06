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
                Console.WriteLine("1-Fakulte İslemleri ");
                Console.WriteLine("2-Bolum İslemleri");
                Console.WriteLine("3-Ogretim Gorevlisi İslemleri");
                Console.WriteLine("4-Ogrenci İslemleri");
                Console.WriteLine("5-Cık");
                x = Convert.ToInt16(Console.ReadLine());

                switch (x)
                {
                    case 1:
                        {
                            Universite U = new Universite();
                            U.FakulteEkle();
                            break;
                        }
                    case 2:
                        {
                            Fakulte F = new Fakulte();
                            F.BolumEkle();
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
                            break;
                        }
                    case 5:
                        {
                            return -1;

                        }
                }
            } while (x != 0);

            return 0;
            }
        }
    }



