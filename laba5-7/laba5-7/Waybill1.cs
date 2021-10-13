using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5_7
{
    partial class Waybill : Document, IOrganization
    {
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
