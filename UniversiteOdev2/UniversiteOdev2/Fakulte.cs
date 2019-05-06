using System;
using System.Collections.Generic;
namespace UniversiteOdev2
{
    public class Fakulte
    {
        Dictionary<int, string> Ders = new Dictionary<int, string>();
       public void BolumEkle()
        {
            int BolumID;
            string BolumAd;
            Console.WriteLine("Eklemek İsediğiniz Dersin ID Numarasını Giriniz:");
            BolumID = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Eklemek İstediğiniz Dersin Adını Giriniz:");
            BolumAd = Console.ReadLine();
            Ders.Add(BolumID, BolumAd);
        }
    }
}
