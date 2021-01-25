using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class Oyuncu : IMusteri
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TcNo { get; set; }
        public int DogumYili { get; set; }
        
    }
}
