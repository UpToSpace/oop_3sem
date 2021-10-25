using System;

namespace laba8
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
        public Document(int date, int numberOfGoods)
        {
            this.date = new Dates(date);
            this.numberOfGoods = numberOfGoods;
        }
        public override string ToString()
        {
            return $"Дата документа: {date.Date}\nПодпись: {signed}\nКоличество товаров: {numberOfGoods}\n";
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
