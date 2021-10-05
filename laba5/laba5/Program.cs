using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Квитанция, Накладная, Документ, Чек, Дата, Организация. */
namespace laba5
{
    class Program
    {
        static void Main(string[] args)
        {
            Cheque cheque = new Cheque(29092021);
            cheque.ShowInfo();
        }
    }
}
