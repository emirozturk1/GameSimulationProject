using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OyunİslemManager
    {
        public void OyunAl(Oyun oyun, Oyuncu musteri)
        {
            string islemler = "1. 2 AL 1 ÖDE \n" + "2. sepette 100 ₺ üstü 20 ₺ indirim çeki";
            Console.WriteLine(islemler);

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
            string islem = Console.ReadLine();

                 if (islem.Equals("1"))
                 {
                         İkiAlanaBirBedavaKampanyasi k1 = new İkiAlanaBirBedavaKampanyasi();
                         Console.WriteLine(oyun.OyunAdi+" isimli oyun "+ musteri.Adi +" adlı müşteriye " + k1.KampanyaEkle());
                 }
                  else
                  {
                        Console.WriteLine(oyun.OyunAdi + " isimli oyun " + musteri.Adi + " adlı müşteriye " + new SepetteYuzTlUstuKampanyasi().KampanyaEkle());
                  }


        }
             public void yeniKampanyaGirisi(string yeniKampanya)
             {
                  Console.WriteLine(yeniKampanya + " isimli kampanya eklendi");
             }


            public void KAmpanyaSilme(string KAmpanya)
            {
                 Console.WriteLine(KAmpanya + " isimli kampanya silindi");
            }


           public void KampanyaGuncelleme(string kampanya)
           {
                 Console.WriteLine(kampanya + " isimli kampanya güncellendi");
           }
    }
}
