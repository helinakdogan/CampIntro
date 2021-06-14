using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {           
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Ali";
            musteri1.Soyadi = "Yılmaz";
            musteri1.OdemeMiktari = 20;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Ece";
            musteri2.Soyadi = "Özkan";
            musteri2.OdemeMiktari = 70;


            MusteriManager musteriManager = new MusteriManager();         
            bool sistemeGirisYapmisMi = true;
            if (sistemeGirisYapmisMi == true) 
            {
                musteriManager.Ekle(musteri1);
            }
            else 
            {
                musteriManager.Silme(musteri1);
            }           
            musteriManager.Listele(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Listele(musteri1, musteri2);
        }
    }
}
