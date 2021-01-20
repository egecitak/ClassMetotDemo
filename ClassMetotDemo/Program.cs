using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Ege";
            musteri1.Soyadi = "Çıtak";
            musteri1.TC = 2135548;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriAdd(musteri1);
            
            
            //Console.WriteLine("Hello World!");
        }
    }
}
