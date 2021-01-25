using System;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Oyuncu> oyuncular = new List<Oyuncu>();                //oyuncu listesinin tanımı
            string islemler = "1. müşteri oluşturma\n" +  "2. oyun işlemleri";
            Console.WriteLine(islemler);

            while (true)
            {
                String secim = Console.ReadLine();

                if (secim.Equals("1"))
                {
                    string musteriTipleri = "1. Oyuncu(Bireysel)" + "2. Mağaza(Kurumsal)";      //müşteri tipi tanımlama
                    Console.WriteLine(musteriTipleri);
                    Console.WriteLine("Lütfen Müşteri Tipini Seçiniz");
                    string secim2 = Console.ReadLine();
                    if (secim2.Equals("1"))     //müşteri seçim
                    {
                        Oyuncu o1 = new Oyuncu();       //oyuncu giriş
                        o1.Adi = "Emir";
                        o1.Soyadi = "Öztürk";
                        o1.Id = 1;
                        o1.DogumYili = 2000;
                        o1.TcNo = "12345678910";
                        o1.OyunAdedi = 1;
                        oyuncular.Add(o1);
                        Console.WriteLine(o1.Adi + " isimli oyuncu oluşturulmuştur.");
                    }
                    if (secim2.Equals("2"))     //magaza seçim 
                    {
                        Magaza o2 = new Magaza();
                        o2.MagazaAdi = "emirgames";
                        o2.Id = 1;
                        o2.OyunAdedi = 1;
                        
                        Console.WriteLine(o2.MagazaAdi + " isimli mağaza oluşturulmuştur.");
                    }
                }
                if (secim.Equals("2"))      // oyun seçim
                {
                    Oyun oyun1 = new Oyun();    
                    oyun1.OyunAdi = "GTA VI";
                    oyun1.Fiyati = 680;
                    oyun1.Boyutu = 60;
                    oyun1.Id = 5;

                    OyunİslemleriManager oyunislemler = new OyunİslemleriManager();

                    oyunislemler.OyunAl(oyun1, oyuncular[0]);
                    Console.WriteLine("-------------------------------------------");

                    oyunislemler.yeniKampanyaGirisi("Oyun içi 20 ₺ ");
                    oyunislemler.KampanyaGuncelleme("2 AL 1 ÖDE ");
                    oyunislemler.KAmpanyaSilme("2 AL 1 ÖDE");
                }
            }
        }
    }
}
