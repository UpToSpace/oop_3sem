using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    [Serializable]
    public class Waybill : Document
    {
        public double Fine
        {
            get;
            set;
        }
        public Waybill(int date, int numberOfGoods, double fine ): base(date, numberOfGoods)
        {
            Fine = fine;
        }
        public Waybill() : base(10102020, 100)
        {
            Fine = 0.3;
        }
        public bool SignADoc()
        {
            return Signed = true;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Переопределенный метод showinfo\nНалог: " + Fine);
        }
        public override string ToString()
        {
            return $"Класс Waybill";
        }
    }
}
