using System;
using System.Collections.Generic;
namespace UniversiteOdev2
{
    public  class Ogrencii
    {
        int OgrenciID;
        string OgrenciAd;
    
        string OgretimDurumu;
        public int ogrenciid { get; set; }
        public string ogrenciad { get; set; }
       
        public string ogretimDurumu { get; set; }
        public Ogrencii(int Ogrenciİd, string OgrenciAd, int ogretimDurumu)
        {
            this.ogrenciad = OgrenciAd;
            this.ogrenciid = Ogrenciİd;
          
            switch (ogretimDurumu)
            {
                case 1:
                    this.ogretimDurumu = "Lisans";
                    break;
                case 2:
                    this.ogretimDurumu = "Yuksek Lisans";
                    break;
                case 3:
                    this.ogretimDurumu = "Doktora";
                    break;
            }
        }
    }
}
