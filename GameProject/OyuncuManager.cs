using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OyuncuManager
    {
        public void KayitOl(Oyuncu o)
        {
            Console.WriteLine(o.Adi + " başarıyla kayıt oldu");
        }

        public void BilgiGuncelleme(Oyuncu o)
        {
            Console.WriteLine(o + " başarıyla kayıt oldu");
        }
        public void KayıtSilme()
        {
            Console.WriteLine("Kayıt silmek istediğinize emin misiniz?");
            string cevap = Console.ReadLine();
            if(cevap == "evet")
            {
                Console.WriteLine("Bilgiler istediğiniz gibi silindi");
            }
            else
            {
                Console.WriteLine("işlem yapılamadı");
            }
                
        }
    }
}
