using System;
using System.Collections.Generic;
namespace UniversiteOdev2
{  
    public class Universite
    {
       

        private static Universite nesne;

        private Universite()
        {

        }

        public static Universite Nesne()
        {
            if (nesne == null)
                nesne = new Universite();

            return nesne;
        }
        public static  Dictionary<int, Fakulte> FakulteDictionary = new Dictionary<int, Fakulte>();

        public void FakulteEkle(int FakulteID, string FakulteAd)
        {

            FakulteDictionary.Add(FakulteID, new Fakulte(FakulteID,FakulteAd));
            Console.WriteLine(FakulteDictionary[FakulteID].fakultead);
           
        }

        public void FakulteSil(int FakulteID)
        {
            FakulteDictionary.Remove(FakulteID);
            Console.WriteLine(FakulteDictionary[FakulteID].fakultead);
        }
    }

}



