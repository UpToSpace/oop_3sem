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
            Document docCheque = new Cheque(12122021, 10, 600);
            Cheque cheque = docCheque as Cheque;
            if (cheque != null)
            {
                cheque.SignADoc();
                cheque.ShowInfo();
            }
            IOrganization orgWaybill = new Waybill(06102021, 400, 0.2);
            if (orgWaybill is Waybill)
            {
                Waybill waybill1 = (Waybill)orgWaybill;
                waybill1.ShowInfo();
            }
            Document docReceipt = new Receipt(07102021, 500, "organiz");
            if (docReceipt is Receipt receipt)
            {
                receipt.SignADoc();
                receipt.ShowInfo();
            }
            Console.WriteLine("------------------------------------");
            Waybill waybill = orgWaybill as Waybill;
            receipt = docReceipt as Receipt;
            
            Document[] docs = { cheque, waybill, receipt};
            Printer printer = new Printer();
            foreach (var item in docs)
            {
                printer.IAmPrinting(item);
            }
        }
    }
}
