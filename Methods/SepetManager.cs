using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class SepetManager    
    {
        //method -> ()
        //naming convention
        //parametre 
        //void -> bir işlem yap
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi : " + urun.Adi );
            //
            //
            //
            //
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokadedi) 
        {
            Console.WriteLine("Sepete eklendi : " + fiyat);      
        }





    }
}
