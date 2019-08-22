using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SingletonOrnek
{
    public class SingletonOrnek //Singleton Sınıfımız
    {
        private static SingletonOrnek deger = null; //daha önceden oluşmadığını anlamak için null tanımlarız


        //Constructor metodumuzu yazıyoruz
        private SingletonOrnek()
        {

        }
        //Dışarıdan ulaşacağımız metod
        public static SingletonOrnek GetDeger()
        {
            return deger ?? (deger = new SingletonOrnek());
            //Değerimiz boş ise yeni örnek oluşturur döndürür. Değil ise yeni örnek oluşturup döndürür.
        }
    }
}