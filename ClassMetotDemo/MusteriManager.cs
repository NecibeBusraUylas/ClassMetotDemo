using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekleme(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi." + "  " + "Id: " + musteri.Id + " \t " + "Adı Soyadı: " + musteri.Ad + " " + musteri.Soyad);
        }

        public void Listeleme(List<Musteri> musteriler)
        {
            Console.WriteLine("Müşteriler Listeleniyor...");
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Id: " + musteri.Id + "\t" + "Adı Soyadı: " + musteri.Ad + " " + musteri.Soyad + " \t " + "Hesap Numarası: " + musteri.HesapId + " \t " + "Adresi: " + musteri.Adres);
            }
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi." + "  " + "Id: " + musteri.Id + " \t " + "Adı Soyadı: " + musteri.Ad + " " + musteri.Soyad);
        }
    }
}

