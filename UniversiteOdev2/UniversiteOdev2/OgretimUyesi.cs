using System;
using System.Collections.Generic;
namespace UniversiteOdev2
{
    public class OgretimUyesi
    {
        int OgrUyesiID;
        string OgrUyesiAd;
        public int ogruyesiid { get; set; }
        public string ogrutesiad { get; set; }
        public static Dictionary<int, Bolum> OgretimUyesiDictionary = new Dictionary<int, Bolum>();
        public OgretimUyesi(int ogruyesiİd,string OgruyesiAd)
        {
            this.ogrutesiad = OgruyesiAd;
            this.ogruyesiid = ogruyesiİd;
        }
    }
}
