using System;
using System.Collections.Generic;
namespace UniversiteOdev2
{
    public class Fakulte
    {
        int Fakulteid;
        string Fakutead;
        public int fakulteid { get; set; }
        public string fakultead { get; set; }
      public static  Dictionary<int, Bolum> BolumDictionary = new Dictionary<int, Bolum>();
        public Fakulte(int fakulteId,string fakulteAd)
        {
            this.fakulteid = fakulteId;
            this.fakultead = fakulteAd;
        }
       public  void BolumEkle(int bolumid,string bolumad)
        {
            BolumDictionary.Add(bolumid, new Bolum(bolumid, bolumad));
            Console.WriteLine(BolumDictionary[bolumid].bolumad);

        }
        public void BolumSil(int bolumid)
        {
            BolumDictionary.Remove(bolumid);
        }

    }
}
