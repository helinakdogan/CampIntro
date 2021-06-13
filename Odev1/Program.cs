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

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Ece";
            musteri2.Soyadi = "Özkan";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Silme(musteri1);
            musteriManager.Ekle(musteri1); 
            musteriManager.Listele(musteri1, musteri2);
        }
    }
}
