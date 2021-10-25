using System;

namespace laba8
{
    class Cheque : Document
    {
        public int Sum
        {
            get;
            set;
        }
        public Cheque(int date, int numberOfGoods, int sum) : base(date, numberOfGoods)
        {
            Sum = sum;
        }
        public bool SignADoc()
        {
            return Signed = true;
        }
        public override string ToString()
        {
            return base.ToString() + $"Sum of cheque is {Sum}\n";
        }
    }
}
