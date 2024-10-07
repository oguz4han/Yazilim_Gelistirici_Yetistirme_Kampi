using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Oğuzhan";
            musteri1.Soyad = "Çakmak";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Ali";
            musteri2.Soyad = "Yılmaz";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Berkan";
            musteri3.Soyad = "Tokat";


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Listeleme(musteriler);

            musteriManager.Ekleme(musteri3);

            musteriManager.Silme(musteri2);


            Console.Read();


        }
    }
}
