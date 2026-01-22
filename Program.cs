using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductsApp
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product { Name = "Ноутбук", Price = 50000, Stock = 5 },
                new Product { Name = "Мышь", Price = 1500, Stock = 20 },
                new Product { Name = "Клавиатура", Price = 3000, Stock = 10 },
                new Product { Name = "Монитор", Price = 25000, Stock = 3 }
            };

            // Продукты дороже 10 000 рублей, отсортированные по цене
            var expensiveProducts = products
                .Where(p => p.Price > 10000)
                .OrderByDescending(p => p.Price)
                .ToList();

            Console.WriteLine("Дорогие товары (цена > 10 000 руб.):");
            foreach (var product in expensiveProducts)
            {
                Console.WriteLine($"{product.Name}: {product.Price:C}, на складе: {product.Stock} шт.");
            }
            Console.ReadKey();
        }
    }
}