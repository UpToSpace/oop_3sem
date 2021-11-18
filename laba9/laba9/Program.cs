using System;
using System.Collections.Generic;

namespace laba9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list1 = new List<string> { "one", "two", "three", "four", "five", "six", "seven" };

            Programmer programmer = new Programmer();

            programmer.ShowList(list1);

            programmer.Removing += list =>
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            };
            programmer.Removing += programmer.ShowList;
            programmer.Remove(list1);
            Console.ResetColor();

            programmer.Mutation += programmer.ShowList;
            programmer.Mutate(list1);



            Func<string, string> func;
            string str = "w,i l,D be!r ri ? Es";

            func = StringEditor.DeleteSpaces;
            str = func(str);
            Console.WriteLine(str);

            func = StringEditor.DeleteSigns;
            str = func(str);
            Console.WriteLine(str);

            func = StringEditor.FirstLetterToUpper;
            str = func(str);
            Console.WriteLine(str);

            func = StringEditor.AddExclamation;
            str = func(str);
            Console.WriteLine(str);

            func = StringEditor.AddSubstring;
            str = func(str);
            Console.WriteLine(str);
        }
    }



}
