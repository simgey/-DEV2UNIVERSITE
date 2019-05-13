using System;
using System.Collections.Generic;
namespace UniversiteOdev2
{
    public  class Ogrencii
    {
        int OgrenciID;
        string OgrenciAd;
        string OgrenciSoyad;
        string OgretimDurumu;
        public int ogrenciid { get; set; }
        public string ogrenciad { get; set; }
        public string ogrencisoyad { get; set; }
        public string ogretimDurumu { get; set; }
        public Ogrencii(int Ogrenciİd,string OgrenciAd,string OgrenciSoyad,int ogretimDurumu)
        {
            this.ogrenciad = OgrenciAd;
            this.ogrenciid = Ogrenciİd;
            this.ogrencisoyad = OgrenciSoyad;
            switch (ogretimDurumu)
            {
                case 0:
                    this.ogretimDurumu = "Lisans";
                    break;
                case 1:
                    this.ogretimDurumu = "Yuksek Lisans";
                    break;
                case 2:
                    this.ogretimDurumu = "Doktora";
                    break;
            }
        }
    }
}
