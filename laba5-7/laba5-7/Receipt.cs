using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5_7
{
    sealed class Receipt : Document, IOrganization
    {
        public string Organization
        {
            get;
            set;
        }
        public Receipt(int date, int numberOfGoods, string organization): base(date, numberOfGoods)
        {
            Organization = organization;
        }
        public bool SignADoc()
        {
            return Signed = true;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Переопределенный метод showinfo\nОрганизация: " + Organization);
        }
        public override string ToString()
        {
            return $"Класс Receipt";
        }
    }
}
