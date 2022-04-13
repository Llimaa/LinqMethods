using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqMethods
{
    public class Program
    {
        private static List<Product> _products = new List<Product>();
        static void Main(string[] args)
        {
            AddProductsToList();

            // User method First
               FirstMethodExample();

            // User method FirstOrDefault
              FirstOrDefaultMethodExample();

            // User method Single
              SingleMethodExample();

            // User method Single
            SingleOrDefaultMethodExample();

            Console.ReadKey();
        }

        private static void FirstMethodExample()
        {
            _products.First(x => x.Name == "Produto1"); // Retorna dados do Produto1;

            _products.DefaultIfEmpty().First(x => x.Id == 21);  // Lança uma excessão do tipo InvalidOperationException;

            _products = null;
            _products.First(x => x.Id == 21);  // Lança uma excessão do tipo ArgumentNullException;
            ResetList();
        }

        private static void FirstOrDefaultMethodExample()
        {
            _products.FirstOrDefault(x => x.Id == 5); // Retorna dados do Produto5;

            _products.FirstOrDefault(x => x.Id == 20); // Retorna null;

            _products = null;
            _products.FirstOrDefault(x => x.Id == 21);  // Lança uma excessão do tipo ArgumentNullException;

            ResetList();
        }

        private static void SingleMethodExample()
        {
            _products.Single(x => x.Id == 2 && x.Name == "Produto2"); // Retorna dados do Produto2;

            _products.Single(x => x.Id == 21);  // Produto não existe; Lança uma excessão do tipo InvalidOperationException;

            _products.Single(); // Lança uma excessão do tipo InvalidOperationException;

            _products.Clear();
            _products.Single(); // Lança uma excessão do tipo InvalidOperationException;

            _products = null;
            _products.Single(x => x.Id == 21);  // Lança uma excessão do tipo ArgumentNullException;

            ResetList();
        }

        private static void SingleOrDefaultMethodExample()
        {
            _products.SingleOrDefault(x => x.Id == 3 && x.IsActive == true); // Retorna dados do Produto3;

            var res = _products.SingleOrDefault(x => x.Id == 21);  // Produto não existe; Retorna null;

            _products.SingleOrDefault(); // Lança uma excessão do tipo InvalidOperationException;

            _products = null;
            _products.SingleOrDefault(x => x.Id == 21);  // Lança uma excessão do tipo ArgumentNullException;

            ResetList();
        }

        private static void AddProductsToList()
        {
            _products.Add(new Product(1, "Produto1"));
            _products.Add(new Product(2, "Produto2"));
            _products.Add(new Product(3, "Produto3"));
            _products.Add(new Product(4, "Produto4"));
            _products.Add(new Product(5, "Produto5"));
            _products.Add(new Product(6, "Produto6", false));
            _products.Add(new Product(7, "Produto7", false));
            _products.Add(new Product(8, "Produto8", false));
            _products.Add(new Product(9, "Produto9", false));
            _products.Add(new Product(10, "Produto10", false));
        }

        private static void ResetList()
        {
            AddProductsToList();
        }
    }
}
