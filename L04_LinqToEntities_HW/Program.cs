using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace L04_LinqToEntities_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DataContext db = new DataContext())
            {
                IEnumerable<Product> products1 = db.Products.ToList().Where(p => p.IsAvailable == false).OrderBy(p => p.Price);

                foreach (var product in products1)
                {
                    Console.WriteLine("{0}. {1} ({2:0} $) - {3}", product.Id, product.Name, product.Price, 
                        product.IsAvailable ? "Is available" : "Not available");
                }

                Console.ReadKey();
                Console.WriteLine(new string('-', 20));

                IQueryable<Product> products2 = db.Products.Where(p => p.IsAvailable == true).OrderBy(p => p.Price);
                
                foreach (var product in products2)
                {
                    Console.WriteLine("{0}. {1} ({2:0} $) - {3}", product.Id, product.Name, product.Price,
                        product.IsAvailable ? "Is available" : "Not available");
                }
            }
        }
    }
}
