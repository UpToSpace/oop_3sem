using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba6
{
    class Program
    {
        static void Main(string[] args)
        {
            Cheque cheque = new Cheque(12122021, 10, 600);
            Waybill waybill1 = new Waybill(06102021, 400, 0.2, 300);
            Waybill waybill2 = new Waybill(11102021, 10, 0.4, 500);
            Receipt receipt = new Receipt(07102021, 500, "organiz");
            Cheque cheque1 = new Cheque(22102021, 22, 300);
            Cheque cheque2 = new Cheque(22102021, 22, 300);
            Bookkeeping docs = new Bookkeeping() {cheque, cheque2, waybill1, waybill2, receipt};
            docs.Add(cheque1);
            docs.ShowList();
            Console.WriteLine("########################################################");
            Console.WriteLine("Sum of waybills: " + Controller.WaybillSum(docs));
            Console.WriteLine("Number of cheques: "+ Controller.NumberOfCheques(docs));
            Console.WriteLine("########################################################");
            Console.WriteLine("Documents in period: 05.10.2021 to 08.10.2021");
            Controller.PrintDocsPeriod(docs, 5102021, 8102021);
            Console.WriteLine("########################################################");
            Company company;
            company.company = "evroopt";
            company.age = 10;
            company.PrintInfo();
        }
    }
}
