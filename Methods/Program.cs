using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";   //değişken

            string[] meyveler = new string[] { };  //array





            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";
            urun1.StokAdedi = 8;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";      //instance - class örneği

            Urun[] urunler = new Urun[] { urun1, urun2 };    //array

            foreach (Urun urun in urunler)         //döngü
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.StokAdedi);
                Console.WriteLine("----------------------");
                //Urun -> type safety
                //urun -> dizinin elemanın takma adı
                //urunler -> dizinin adı 
            }

            //instance //method - reusability
            SepetManager sepetManager = new SepetManager();        
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
           
            //class yok
            sepetManager.Ekle2("Armut", "yeşil", 7, 10);
            sepetManager.Ekle2("Elma", "sarı", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyabakır", 24, 5);

        }
    }
}



//do not repeat yourself - DRY - clean code - best practice