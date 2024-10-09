using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders4_Odev5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();   
            product1.Id = 1;
            product1.Name = "Test1";

            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "Test2";

            ProductManager<int, string> productManager = new ProductManager<int, string>();
            productManager.Add(product1.Id,product2.Name);
            productManager.Add(product2.Id, product2.Name);

            productManager.Select();

            Console.Read();
        }
    }
}
