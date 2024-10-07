using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Ekleme(Musteri musteri)
        {
            Console.WriteLine("Musteri ID :"+musteri.Ad+" eklendi.");
        }

        public void Listeleme(Musteri[] musteri)
        {
            foreach(Musteri m in musteri)
            {
                Console.WriteLine("Musteri ID: "+m.Id);
                Console.WriteLine("Musteri AD: "+m.Ad);
                Console.WriteLine("Musteri SOYAD: "+m.Soyad);
                Console.WriteLine("------------");
            }
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Musteri ID :" + musteri.Ad + " silindi.");
        }
        

    }
}
