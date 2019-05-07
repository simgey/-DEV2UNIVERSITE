using System;
using System.Collections.Generic;
namespace UniversiteOdev2
{ 
    public  class Universite
    {
      public  static Dictionary<int, Fakulte> FakulteDictionay = new Dictionary<int, Fakulte>();//value olarak fakulte tipinde bir  nesne alıyor.
        public  void UniversiteIslemleri() //Univesiteye fakulte ekleyip Çıkartma işlemleri 
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
            int FakulteID1;
            string FakulteAd1;
            Console.WriteLine("Eklemek İstediğiniz Fakultenin ID Numarasini Giriniz:");
            FakulteID1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Eklemek İstediğiniz Fakultenin Adını Giriniz:");
            FakulteAd1 =Console.ReadLine();
            Fakulte f = new Fakulte( FakulteAd1, FakulteID1);
            FakulteDictionay.Add(FakulteID1,new Fakulte(f.fakultead=FakulteAd1 ,f.fakulteid=FakulteID1 ));
            foreach(int F in FakulteDictionay.Keys )
            {
                Console.WriteLine(F);
            }

        }
        public  void FakulteSil()
        {
            int FakulteID;  //Fakulte Id numarası üzerinden silme gerçekleştiriliyor.
            Console.WriteLine("Eklemek İstediğiniz Fakultenin ID Numarasini Giriniz:");
            FakulteID = Convert.ToInt16(Console.ReadLine());
            FakulteDictionay.Remove(FakulteID);
           
        }
    }

}
