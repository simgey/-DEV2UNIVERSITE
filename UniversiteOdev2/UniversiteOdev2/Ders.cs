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
        Dictionary<int, Ogrencii> DerseKayıtlıOgrenci = new Dictionary<int, Ogrencii>();
        Dictionary<int, OgretimUyesi> Hoca = new Dictionary<int, OgretimUyesi>();
        public Ders(int DersID, string DersAd)
        {
            this.dersId = DersID;
            this.dersAd = DersAd;
        }
        public void OgreciEkle(int Ogrenciİd, string OgrenciAd, int ogretimDurumu)
        {

            DerseKayıtlıOgrenci.Add(Ogrenciİd,new Ogrencii( Ogrenciİd, OgrenciAd, ogretimDurumu));

        }

        public void OgrenciSil(int ogrenciid)
        {
            DerseKayıtlıOgrenci.Remove(ogrenciid);        }
        public void HocaEkle(int ogretimuyesiid,string ogretimuyesiad)
        {
            Hoca.Add(ogretimuyesiid, new OgretimUyesi(ogretimuyesiid,ogretimuyesiad));
        }
        public void HocaDegistir(int ogretimuyesiid)
        {
            Hoca.Remove(ogretimuyesiid);
        }
    }
}
