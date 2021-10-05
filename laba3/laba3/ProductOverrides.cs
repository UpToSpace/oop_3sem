using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    partial class Product
    {
        // Equals, ToString and GetHashCode overrides
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                throw new Exception("Object is null");
            }
            Product product = obj as Product;
            return product.Name == Name && product.Price == Price;
        }
        public override int GetHashCode()
        {
            return Price + Count;
        }
        public override string ToString()
        {
            return $"id {Id}\nname {Name}\nprice {Price}\ncount {Count}\nproducer {producer}";
        }
    }
}
