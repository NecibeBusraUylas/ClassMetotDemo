using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Musteri> musteriler = new List<Musteri>();
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Büşra";
            musteri1.Soyad = "UYLAŞ";
            musteri1.HesapId = 111111111;
            musteri1.Adres = "Şişli/İstanbul";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Engin";
            musteri2.Soyad = "DEMİROĞ";
            musteri2.HesapId = 222222222;
            musteri2.Adres = "Beyoğlu/İstanbul";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Hasan";
            musteri3.Soyad = "Korkmaz";
            musteri3.HesapId = 333333333;
            musteri3.Adres = "Kadıköy/İstanbul";


            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekleme(musteri1);
            musteriler.Add(musteri1);
            musteriManager.Ekleme(musteri2);
            musteriler.Add(musteri2);
            musteriManager.Ekleme(musteri3);
            musteriler.Add(musteri3);
            Console.WriteLine("\n");

            musteriManager.Listeleme(musteriler);
            Console.WriteLine("\n");

            int silinecekId;
            Console.WriteLine("Müşteriyi silmek için müşteri Id giriniz. ");
            silinecekId = Convert.ToInt32(Console.ReadLine());
            Musteri silinecek = musteriler.Find(i => i.Id == silinecekId);
            musteriManager.Silme(silinecek);
            musteriler.Remove(silinecek);
            Console.WriteLine("\n");

            musteriManager.Listeleme(musteriler);
            Console.WriteLine("\n");
            Console.ReadLine();


        }
    }
}
