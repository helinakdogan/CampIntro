﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri) 
        {
            Console.WriteLine("Sisteme giriş yaptı : " + musteri.Adi + " " + musteri.Soyadi);      
        }

        public void Silme(Musteri musteri) 
        {
            Console.WriteLine("Sistemden çıkış yaptı : " + musteri.Adi + " " + musteri.Soyadi);              
        }

        public void Listele(params Musteri[] musteriler)
        {
            Console.WriteLine(          );
            Console.WriteLine("Müşteri Listesi");
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("-" + musteri.Adi + " " + musteri.Soyadi);
            }       
        }

    }



    
}
