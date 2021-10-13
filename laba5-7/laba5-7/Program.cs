using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace laba5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Laba5Test();
            Laba6Test();
            Laba7Test();
        }
        public static void Laba5Test()
        {
            Console.WriteLine("\n //////////////////// Laba 5 //////////////////////");
            Document docCheque = new Cheque(12122021, 10, 600);
            Cheque cheque = docCheque as Cheque;
            if (cheque != null)
            {
                cheque.SignADoc();
                cheque.ShowInfo();
            }
            IOrganization orgWaybill = new Waybill(06102021, 400, 0.2, 100);
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

            Document[] docs = { cheque, waybill, receipt };
            Printer printer = new Printer();
            foreach (var item in docs)
            {
                printer.IAmPrinting(item);
            }
        }
        public static void Laba6Test()
        {
            Console.WriteLine("\n //////////////////// Laba 6 //////////////////////");
            Cheque cheque = new Cheque(12122021, 10, 600);
            Waybill waybill1 = new Waybill(06102021, 400, 0.2, 300);
            Waybill waybill2 = new Waybill(11102021, 10, 0.4, 500);
            Receipt receipt = new Receipt(07102021, 500, "organiz");
            Cheque cheque1 = new Cheque(22102021, 22, 300);
            Cheque cheque2 = new Cheque(22102021, 22, 300);
            Bookkeeping docs = new Bookkeeping() { cheque, cheque2, waybill1, waybill2, receipt };
            docs.Add(cheque1);
            docs.ShowList();
            Console.WriteLine("########################################################");
            Console.WriteLine("Sum of waybills: " + Controller.WaybillSum(docs));
            Console.WriteLine("Number of cheques: " + Controller.NumberOfCheques(docs));
            Console.WriteLine("########################################################");
            Console.WriteLine("Documents in period: 05.10.2021 to 08.10.2021");
            Controller.PrintDocsPeriod(docs, 5102021, 8102021);
            Console.WriteLine("########################################################");
            Company company;
            company.company = "evroopt";
            company.age = 10;
            company.PrintInfo();
        }
        public static void Laba7Test()
        {
            Console.WriteLine("\n //////////////////// Laba 7 //////////////////////");
            try
            {
                object obj = "some string";
                Cheque cheque = obj as Cheque;
                if (cheque == null)
                {
                    throw new NullObject();
                }


            }
            catch(NullObject e)
            {
                e.PrintInfo();
            }

            try
            {
                Cheque cheque = new Cheque(34122021, 10, 600);
                if (cheque.Date > 32000000)
                {
                    throw new WrongDate("The date is out of range");
                }    
            }
            catch(WrongDate e)
            {
                e.PrintInfo();
            }

            try
            {
                Company company = new Company();
                if (company.age == 0 || string.IsNullOrEmpty(company.company))
                {
                    throw new EmptyStruct();
                }
            }
            catch(EmptyStruct e)
            {
                e.PrintInfo();
            }
            finally
            {
                Console.WriteLine("This code will be running definitely");
            }

            try
            {
                int x = 10, y = 0;
                x = x / y;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                int[] arr = new int[2];
                arr[5] = 10;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //int p = 10;
            //int n = -10;
            //Debug.Assert(n > 0, "n is negative");
            //Debug.Assert(p > 0, "p is negative");
        }
    }
}
