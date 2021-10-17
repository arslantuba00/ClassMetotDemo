using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = "Eb012";
            musteri1.Name = "Zeliha";
            musteri1.Surname = "Tanbaşı";
            musteri1.CreditRating = "İyi";

            Musteri musteri2 = new Musteri();
            musteri2.Id = "Ec138";
            musteri2.Name = "Sabahat";
            musteri2.Surname = "Sarıoba";
            musteri2.CreditRating = "Çok İyi";

            Musteri musteri3 = new Musteri();
            musteri3.Id = "A2001";
            musteri3.Name = "Salih";
            musteri3.Surname = "Özman";
            musteri3.CreditRating = "Orta Riskli";

            Musteri musteri4 = new Musteri();
            musteri4.Id = "Tn234";
            musteri4.Name = "Kadir";
            musteri4.Surname = "Edin";
            musteri4.CreditRating = "Az Riskli";

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);

            musteriManager.Guncelle();

            musteriManager.Cikar(musteri3);

            musteriManager.Guncelle();

            Console.ReadLine();

        }
    }
}
