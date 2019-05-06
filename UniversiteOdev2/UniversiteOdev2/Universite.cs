using System;
using System.Collections.Generic;
namespace UniversiteOdev2
{ 
    public class Universite
    {
        Dictionary<int, string> Fakulte = new Dictionary<int, string>();
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
    }
}
