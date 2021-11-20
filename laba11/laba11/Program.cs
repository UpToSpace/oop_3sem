using System;
using System.Collections.Generic;
using System.Linq;

namespace laba11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };
            Console.WriteLine("Enter length of month");
            int n = Convert.ToInt32(Console.ReadLine());
            IEnumerable<string> lengthN = from month in months
                                          where month.Length == n
                                          select month;
            var winterSummer = months.Where((month, i) => i < 2 || i > 4 && i < 8 || i == 11);
            var alphabetOrder = months.OrderBy(month => month);
            var withU = months.Where(month => month.Contains("u") && month.Length > 3);

            Show(lengthN);
            Show(winterSummer);
            Show(alphabetOrder);
            Show(withU);

            List<Product> products = new List<Product>() {
                new Product("Tea Greenfield", 100, "Russia"),
                new Product("Tea Jambo", 200, "Belarus"),
                new Product("Tea Elephant", 50, "Belarus"),
                new Product("Tea Lisma", 70, "India"),
                new Product("Tea Java", 60, "Poland"),
                new Product("Tea Tells", 150, "Ukrain"),
                new Product("Tea Lipton", 170, "Russia"),
                new Product("Sugar", 180, "ShriLanka")
            };
            var tea = products.Where(e => e.Name.Contains("Tea"));
            var teaPrice = products.Where(e => e.Name.Contains("Tea") && e.Price < 200);
            var count = products.Where(e => e.Price > 100).Count();
            var maxPrice = products.Max(e => e.Price);
            var producer = products.OrderBy(e => e.Producer);
            var count1 = products.OrderBy(e => e.Price);

            Console.WriteLine("-----------------");
            foreach (var item in tea)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------");
            foreach (var item in teaPrice)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------");
            Console.WriteLine(count);
            Console.WriteLine("-----------------");
            Console.WriteLine(maxPrice);
            Console.WriteLine("-----------------");
            foreach (var item in producer)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------");
            foreach (var item in count1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------");

            var five = products.Where(e => e.Price != 200).Where(e => e.Producer != "Russia").OrderByDescending(e => e.Name).Select(e => e.Name += ';').Take(3);
            Show(five);

            List<Product> products1 = new List<Product>()
            {
                new Product("Coffee nescafe", 150, "Russia"),
                new Product("Coffee jacobs", 200, "Belarus"),
                new Product("Coffee Carte Noire", 50, "Belarus")
            };
            var samePrices = products.Join(
                products1,
                e => e.Price,
                c => c.Price,
                (c, e) => new { coffee = c.Name, tea = e.Name, price = c.Price });
            Console.WriteLine("-----------------");
            foreach (var item in samePrices)
            {
                Console.WriteLine($"price: ${item.price}\tcoffee: {item.coffee}\ttea: {item.tea}");
            }
        }
        public static void Show(IEnumerable<string> str)
        {
            Console.WriteLine("-----------------");
            foreach (var item in str)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------");
        }
    }
}
