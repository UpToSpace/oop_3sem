using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba6
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
            Console.WriteLine("Подписана квитанция");
            return !Signed;
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
