using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders4_Odev5
{
    public class ProductManager<Id, Product>
    {

        Id[] _Id;
        Product[] _Product;

        public ProductManager()
        {
            _Id = new Id[0];
            _Product = new Product[0];

        }
        public void Add(Id id, Product product)
        {
            Id[] tempId = _Id;
            Product[] tempProduct = _Product;

            _Id = new Id[_Id.Length + 1];
            _Product = new Product[_Id.Length + 1];

            for (int i = 0; i < tempId.Length; i++)
            {
                _Id[i] = tempId[i];
                _Product[i] = tempProduct[i];
            }

            _Id[_Id.Length - 1] = id;
            _Product[_Product.Length - 1] = product;

            Console.WriteLine("Eklendi");

        }

        public void Select()
        {
            foreach (Product p in _Product)
            {
                Console.WriteLine(p);
            }
        }


    }
}
