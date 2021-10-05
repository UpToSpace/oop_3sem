using System;

/*
 * Создать класс Product: id, Наименование, UPC, 
Производитель, Цена, Срок хранения, Количество.
Свойства и конструкторы должны обеспечивать проверку 
корректности. Добавить метод вывода общей суммы 
продукта.
Создать массив объектов. Вывести:
a) список товаров для заданного наименования;
b) список товаров для заданного наименования, цена которых 
не превосходит заданную;
 */
namespace laba3
{
    partial class Product
    {
        // fields
        const int MAX_ID = 10; // const
        static int id;
        string name;
        int upc;
        readonly static string producer;
        int price;
        int bestBefore;
        int count;

        // constructors
        static Product()
        {
            Console.WriteLine("Static constructor");
            id = 0;
            producer = "Minsk";
        }
        public Product(string name, int upc, int price, int bestBefore, int count)
        {
            Console.WriteLine("Constructor");
            if (!string.IsNullOrEmpty(name) && id <= MAX_ID)
            {
                this.name = name;
                this.upc = upc;
                this.price = price;
                this.bestBefore = bestBefore;
                this.count = count;
                id++;
            }
            else
            {
                throw new Exception("Cannot create a product");
            }
        }
        public Product()
        {
            Console.WriteLine("Constructor");
            id++;
        }
        public Product(string name, int price, int upc = 11111, int bestBefore = 11111)
        {
            Console.WriteLine("Constructor");
            if (!string.IsNullOrEmpty(name) && id <= MAX_ID)
            {
                this.name = name;
                this.upc = upc;
                this.price = price;
                this.bestBefore = bestBefore;
                count = 10;
                id++;
            }
            else
            {
                throw new Exception("Cannot create a product");
            }
        }
        // closed constructor
        //private Product() { }       
        
        // getters and setters
        public int Id
        {
            get
            {
                return id;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!string.IsNullOrEmpty(name))
                {
                    name = value;
                }
                else
                {
                    throw new Exception("Name is null or empty");
                }
            }
        }
        public int Upc
        {
            get
            {
                return upc;
            }
            set
            {
                if (value > 0)
                {
                    upc = value;
                }
                else
                {
                    throw new Exception("Upc is incorrect");
                }
            }
        }
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value > 0)
                {
                    price = value;
                }
                else
                {
                    throw new Exception("Price is incorrect");
                }
            }
        }
        public int BestBefore
        {
            get
            {
                return bestBefore;
            }
            set
            {
                if (value > 0)
                {
                    bestBefore = value;
                }
                else
                {
                    throw new Exception("BestBefore is incorrect");
                }
            }
        }
        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                if (value > 0)
                {
                    count = value;
                }
                else
                {
                    throw new Exception("Count is incorrect");
                }
            }
        }
        //methods
        public static void PrintClassInfo()
        {
            Console.WriteLine($"Class Info:\nClassName is Product\nNumber of objects is {id}\nMaximum number is {MAX_ID}");
        }
        public string PrintSum()
        {
            return $"Whole sum of the product:\nThe whole sum of {Name} is {Count * Price}\n";
        }
        public void ChangePrice(ref int newPrice, out int price) // pass by reference
        {
            price = newPrice;
            Console.WriteLine("New price is " + price);
        }

    }
}
