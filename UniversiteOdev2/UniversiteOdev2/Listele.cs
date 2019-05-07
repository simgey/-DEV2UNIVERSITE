using System;
using System.Collections.Generic;
namespace UniversiteOdev2
{
    public class Listele
    { Dictionary<int, string> Ders = new Dictionary<int, string>();
            public void Listelemeİslemleri()
        {
            int x;
            Console.WriteLine("1-Fakulteye-Bolume Ait Dersleri Listele");
            Console.WriteLine("2-Derse-Subeye Kayıtlı Ogrenci Listele");
            x = Convert.ToInt16(Console.ReadLine());
            switch(x)
            {
                case 1:
                    {
                       
                        break;
                    }
                case 2:
                    {

                        break;
                    }

            }
           
        }
        /* public void DersListele()
         {
             string FakAD;
             string BolumAD;
             Universite u = new Universite();

             Bolum b = new Bolum();
             foreach (string universite in u.Fakulte.Values)
             {
                 Console.WriteLine(universite);
             }
             Console.WriteLine("Hangi Fakultedeki Dersleri Listelemek İstediğinizi Giriniz:");
             FakAD = Console.ReadLine();
             /?
             foreach (string fakulte in f.Bolum.Values)
             {

                if (FakAD == fakulte)
                 {
                     Console.WriteLine(fakulte);
                 }
             }
             Console.WriteLine("Hangi Bolumdeki Dersleri Listelemek İstersiniz:");
             BolumAD = Console.ReadLine();
             foreach (string bolum in b.Bolum.Values)
             {
                 if(BolumAD==bolum)
                 {
                     Console.WriteLine(bolum);
                 }

             }
         }
         public void OgrListele()
         {

         }*/
}    }
