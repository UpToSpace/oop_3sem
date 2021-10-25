using System;

namespace laba8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<string> list1 = new List<string>();
                list1.AddNode("a");
                list1.AddNode("b");
                list1.AddNode("c");

                list1.ShowInfo();
                list1.DeleteNode("a");
                list1.ShowInfo();

                List<string> list2 = new List<string>();
                Streams<string>.OutFile(@"D:\University\3\oop\laba8\laba8\out.txt", ref list2);
                list2.ShowInfo();

                List<Cheque> list3 = new List<Cheque>();
                list3.AddNode(new Cheque(20102021, 100, 400));
                list3.AddNode(new Cheque(21102021, 200, 300));
                list3.AddNode(new Cheque(22102021, 300, 200));
                list3.AddNode(new Cheque(23102021, 400, 100));

                list3.ShowInfo();

                Streams<Cheque>.InFile(@"D:\University\3\oop\laba8\laba8\in.txt", ref list3);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("This code will be 100%");
            }
        }
    }
}
