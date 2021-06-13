using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği 
            //değişkenler
            //kategoriEtiketi bir değer tutucu, alias
            //şart blokları

            int OgrenciSayisi = 3200;
            double faizOrani = 1.45;
            string kategoriEtiketi = "Kategori";
           
           

            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine("Kategori");

            double DolarDun = 7.35;
            double DolarBugun = 7.45;
            if (DolarDun>DolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (DolarDun<DolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }

            bool sistemeGirisYapmisMi = false;
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
         





           

        }
    }
}
