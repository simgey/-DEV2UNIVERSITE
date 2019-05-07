using System;
using System.Collections.Generic;
namespace UniversiteOdev2
{
    public class OgretimUyesi
    {
        Dictionary<int, string> OgretimElemanı = new Dictionary<int, string>();
        public void OgrElemaniİslemleri()
        {
            int x;
            Console.WriteLine("1-Ogretim Elemani Eklemek İcin ");
            Console.WriteLine("2-Ogretim Elemani Silmek İcin");
            x = Convert.ToInt16(Console.ReadLine());
            switch(x)
            {
                case 1:
                    {
                        OgrElemaniEkle();
                        break;
                    }
                case 2:
                    {
                        OgrElemaniSil();
                        break;
                    }
            }
        }
        public void OgrElemaniEkle()
        {
            int OgreElemaniID;
            string OgrElemaniAd;
            Console.WriteLine("");
        }
        public void OgrElemaniSil()
        {

        }
    }
}
