using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void MusteriAdd(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi.");
            Console.WriteLine("Adi: " + musteri.Adi);
            Console.WriteLine("Soyadi: " + musteri.Soyadi);
            Console.WriteLine("TC: " + musteri.TC);
        }
        public void MusteriDiscard()
        {
            Console.WriteLine("Müşteri çıkarıldı");
        }

    }
}
