using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba6
{
    partial class Waybill : Document, IOrganization
    {
        public int Sum
        {
            get;
            set;
        }
        public double Fine
        {
            get;
            set;
        }
        public Waybill(int date, int numberOfGoods, double fine, int sum ): base(date, numberOfGoods)
        {
            Fine = fine;
            Sum = sum;
        }
        public bool SignADoc()
        {
            Console.WriteLine("Подписана накладная");
            return !Signed;
        }
    }
}
