using System;
using System.Collections.Generic;
namespace UniversiteOdev2
{ 
    public class Universite
    {
        Dictionary<int, string> Fakulte = new Dictionary<int, string>();
        public void UniversiteIslemleri() //Univesiteye fakulte ekleyip Çıkartma işlemleri 
        {   int x;
            Console.WriteLine("1-Universiteye Fakulte Eklemek İcin");
            Console.WriteLine("2-Universiteden Fakulte Silmek İcin");
            x = Convert.ToInt16(Console.ReadLine());
            switch(x)
            {
                case 1:
                    {
                        FakulteEkle();
                        break;
                    }
                case 2:
                    {
                        FakulteSil();
                        break;
                    }
            }
        }
        public void FakulteEkle()
        {
            int FakulteID;
            string FakulteAd;
            Console.WriteLine("Eklemek İstediğiniz Fakultenin ID Numarasini Giriniz:");
            FakulteID = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Eklemek İstediğiniz Fakultenin Adını Giriniz:");
            FakulteAd = Console.ReadLine();
            Fakulte.Add(FakulteID, FakulteAd);
        }
        public void FakulteSil()
        {
            int FakulteID;  //Fakulte Id numarası üzerinden silme gerçekleştiriliyor.
            Console.WriteLine("Eklemek İstediğiniz Fakultenin ID Numarasini Giriniz:");
            FakulteID = Convert.ToInt16(Console.ReadLine());
            Fakulte.Remove(FakulteID);
        }
    }

}
