using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    public class SepetManager
    {

        public void Ekle(Urun urun)
        {
            Console.WriteLine(urun.Adi+" sepete eklendi.");
        }

        // override edilmiş hali
        public void Ekle()
        {
            Console.WriteLine("sepete eklendi.");
        }

    }
}
