using System;
using System.Collections.Generic;

namespace UniversiteOdev2
{
    public class Bolum
    {
        int Bolumid;
        string Bolumad;
        public int bolumid { get; set; }
        public string bolumad { get; set; }
        public static Dictionary<int, Ders> DersDictionary = new Dictionary<int, Ders>();
        public static Dictionary<int, OgretimUyesi> OgretimUyesiDictionary = new Dictionary<int, OgretimUyesi>();
        public static Dictionary<int, Ders> SubeDictionary = new Dictionary<int, Ders>();
        public Bolum(int bolumİd,string bolumAd)
        {
            this.bolumad = bolumAd;
            this.bolumid = bolumİd;
        }
        public void DersEkle(int dersid,string dersad)
        {
            DersDictionary.Add(dersid, new Ders(dersid, dersad));
            Console.WriteLine(Bolum.DersDictionary[dersid].dersAd);


        }
        public void SubeEkle(int subeid,string dersad,int dersid)
        {
            SubeDictionary.Add(subeid, new Ders(dersid, dersad));
        }
        public void DersSil(int dersid)
        {
            DersDictionary.Remove(dersid); 
        }

        public void OgrElemaniEkle(int ogruyesiid,string ogruyesiad)
        {
            OgretimUyesiDictionary.Add(ogruyesiid, new OgretimUyesi(ogruyesiid, ogruyesiad));
        }
        public void OgrElemaniSil(int ogruyesiid)
        {
            OgretimUyesiDictionary.Remove(ogruyesiid);
        }
    }
}
