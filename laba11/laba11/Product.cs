using System;

namespace laba11
{
    partial class Product
    {
        // fields
        const int MAX_ID = 10; // const
        static int id;
        string name;
        int upc;
        string producer;
        int price;
        int bestBefore;
        int count;

        // constructors
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
        public Product(string name, int price, string producer, int upc = 11111, int bestBefore = 11111)
        {
            if (!string.IsNullOrEmpty(name) && id <= MAX_ID)
            {
                this.name = name;
                this.producer = producer;
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

        // getters and setters
        public string Producer
        {
            get
            {
                return producer;
            }
            set
            {
                producer = value;
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
        public override string ToString()
        {
            return $"name: {Name}, price {Price}, producer {Producer}";
        }
    }
}

