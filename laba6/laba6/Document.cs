using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba6
{
    abstract class Document
    {
        Dates date;
        bool signed = false;
        int numberOfGoods;
        public bool Signed
        {
            get => signed;
            set => signed = value;
        }
        public int Date
        {
            get => date.Date;
        }
        public Document(int date, int numberOfGoods)
        {
            this.date = new Dates(date);
            this.numberOfGoods = numberOfGoods;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Дата документа: {date.Date}\nПодпись: {signed}\nКоличество товаров: {numberOfGoods}");
        }
        public override string ToString()
        {
            return "Класс Document";
        }
        public override bool Equals(object obj)
        {
            Document doc = (Document)obj;
            if (date == doc.date && numberOfGoods == doc.numberOfGoods)
            {
                return true;
            }
                return false;
        }
        public override int GetHashCode()
        {
            return numberOfGoods;
        }
    }
}
