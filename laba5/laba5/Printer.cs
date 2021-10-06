using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    class Printer
    {
        public virtual void IAmPrinting(Document doc)
        {
            Console.WriteLine(doc.GetType().Name);
            doc.ToString();
        }
    }
}
