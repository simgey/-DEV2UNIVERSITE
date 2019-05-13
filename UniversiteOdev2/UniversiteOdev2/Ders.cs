using System;
using System.Collections.Generic;
namespace UniversiteOdev2
{
    public class Ders
    {
        int DersID;
        string DersAd;
        public int dersId { get; set; }
        public string dersAd { get; set; }
        Dictionary<int, Ogrenci> DerseKayıtlıOgreni = new Dictionary<int, Ogrenci>();
        Dictionary<int, OgretimUyesi> Hoca = new Dictionary<int, OgretimUyesi>();
        public Ders(int DersID, string DersAd)
        {
            this.dersId = DersID;
            this.dersAd = DersAd;
        }

    }
}
