using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Diziler 

            try
            {
                // diziler
                string[] isimler = new string[] { "Engin", "Kerem", "Oğuzhan", "Ali" };
                Console.WriteLine(isimler[0]);
                Console.WriteLine(isimler[1]);
                Console.WriteLine(isimler[2]);
                Console.WriteLine(isimler[3]);
                isimler[4] = "İlker";
                Console.WriteLine(isimler[4]);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata");
            }

            #endregion


            // Kısaca diziler cok terchı edılmez

            // çünkü listeler yani kleksıyonlar sonradan ekleme yapılabilir.
            #region Listeler yani Koleksiyonlar

            List<string> isimler2 = new List<string>();
            isimler2.Add("Oğuzhan");




            #endregion

        }
    }
}
