using System;

namespace laba4
{
    class Program
    {
        static void Main(string[] args)
        {
            List list1 = new List();
            list1.AddNode("a");
            list1.AddNode("b");
            list1.AddNode("c");
            list1.AddNode("d");
            list1.AddNode("e");

            List list2 = new List();
            list2.AddNode("a");
            list2.AddNode("b");
            list2.AddNode("c");
            list2.AddNode("d");
            list2.AddNode("e");

            list1.ShowInfo();
            list2.ShowInfo();

            Console.Write("list1 equals to list2: ");
            Console.WriteLine(list1 == list2);

            Node node = new Node();
            node.Info = "f";
            list1 = node + list1;
            list1.ShowInfo();

            Console.Write("list1 not equals to list2: ");
            Console.WriteLine(list1 != list2);

            list1--;
            list1.ShowInfo();
            list1 *= list2;
            list1.ShowInfo();

            List list3 = new List();
            list3.AddNode("Jjj");
            list3.AddNode("kkK");
            list3.AddNode("Ppp");
            list3.AddNode("Jjj");
            list3.AddNode("oooO");

            list3.ShowInfo();
            Console.WriteLine("Count of words starting with capital letter is " + list3.CountFirstCapitalLetters());
            Console.WriteLine("Has repeating elements list3 " + list3.CheckRepeatings());
            Console.WriteLine("Has repeating elements list2 " + list2.CheckRepeatings());
            Console.WriteLine("Count of elements in list3 is " + StaticOperations.Count(list3));
            Console.WriteLine("List1 in string: " + StaticOperations.ListString(list1));
            Console.WriteLine("Longest info in list3 is " + StaticOperations.LongestInfo(list3));

            string str = "heY ITS a GoOd daY!";
            Console.WriteLine(str + " formats to: " + StaticOperations.FormatText(str));
        }
    }
}
