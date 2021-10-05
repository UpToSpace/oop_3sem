using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Product carrot = new Product("carrot", 3);
            Product cucumber = new Product("cucumber", 2222, 2, 30092021, 17);
            Product cucumber1 = new Product("cucumber", 2222, 2, 30092021, 17);
            Product apple = new Product();
            Console.WriteLine("-------------------------------------------------\n");
            Product.PrintClassInfo();
            Console.WriteLine("-------------------------------------------------\n");
            Console.WriteLine(cucumber.ToString());
            Console.WriteLine("-------------------------------------------------\n");
            Console.WriteLine(cucumber.Equals(cucumber1));
            Console.WriteLine("-------------------------------------------------\n");
            Console.WriteLine(cucumber.GetHashCode());
            Console.WriteLine("-------------------------------------------------\n");
            int price = 18, newPrice;
            cucumber.ChangePrice(ref price, out newPrice);

            Console.WriteLine("################### Array of Objects ########################\n");
                Product[] product = new Product[6];
                product[0] = new Product("milk chocolate spartak", 800002, 20, 20122021, 4);
                product[1] = new Product("milk chocolate alpen gold", 800222, 21, 25122021, 10);
                product[2] = new Product("dark chocolate kommunarka", 803333, 22, 16102021, 3);
                product[3] = new Product("white chocolate roschen", 800322, 19, 18102021, 7);
                product[4] = new Product("sweets", 805555, 15, 16112021, 30);
                product[5] = new Product("ice cream", 808888, 24, 28092021, 20);

                Console.WriteLine("milk chocolates:");
                foreach (Product item in product)
                {
                    if (item.Name.Contains("milk chocolate"))
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
                Console.WriteLine("-------------------------------------------------\n");
                Console.WriteLine("\nchocolates with price <= 20:");
                foreach (Product item in product)
                {
                    if (item.Name.Contains("chocolate") && item.Price <= 20)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
