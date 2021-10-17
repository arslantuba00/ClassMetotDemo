using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public MusteriManager()
        {
        }

        public void Ekle(Musteri gelenMusteri)
        {
            Console.WriteLine(gelenMusteri.Name +" " + gelenMusteri.Surname + " isimli müşterimiz listeye eklenmiştir.");
        }

        public void Cikar(Musteri gelenMusteri)
        {
            Console.WriteLine(gelenMusteri.Name + " " + gelenMusteri.Surname + " isimli müşterimiz listeden çıkarılmıştır.");
        }

        public void Guncelle()
        {
            Console.WriteLine("Liste güncellemesi başarıyla gerçekleşti.");
        }
    }
}
