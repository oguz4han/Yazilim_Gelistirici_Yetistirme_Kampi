using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



// Dont repeat yourself - DRY

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Id  = 1;
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 550;
            urun2.Aciklama = "Diyarbakır karpuzu";

            // Urun[] urunler = { urun1,urun2};
            // Urun[] urunler = new Urun[] { urun1, urun2 };
            // Urun[] urunler = new Urun[2];

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach ( Urun urun in urunler )
            {
                Console.WriteLine("Urun adı: "+urun.Id);
                Console.WriteLine("Urun adı: "+urun.Adi);
                Console.WriteLine("Urun adı: "+urun.Fiyati);
                Console.WriteLine("Urun adı: "+urun.Aciklama);
                Console.WriteLine("-----------");
            }


            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            Console.WriteLine("---------------");
            // override edilmiş hali
            sepetManager.Ekle();
            Console.WriteLine("---------------");




            Console.ReadLine();
        }
    }
}
