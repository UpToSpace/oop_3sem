using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Найти суммарную стоимость продукции 
 * по всем накладным, количество чеков. 
Вывести две документы за указанный период времени.
*/
namespace laba6
{
    class Controller
    {
        public static int WaybillSum(Bookkeeping docs)
        {
            int sum = 0;
            foreach (var item in docs)
            {
                if (item is Waybill)
                {
                    Waybill waybill = (Waybill)item;
                    sum += waybill.Sum;
                }
            }
            return sum;
        }
        public static int NumberOfCheques(Bookkeeping docs)
        {
            int sum = 0;
            foreach (var item in docs)
            {
                if (item is Cheque)
                {
                    sum++;
                }
            }
            return sum;
        }
        public static void PrintDocsPeriod(Bookkeeping docs, int begin, int end)
        {
            foreach(var item in docs)
            {
                Document document = (Document)item;
                if (document.Date >= begin && document.Date <= end)
                {
                    document.ShowInfo();
                }
            }
        }
    }
}
