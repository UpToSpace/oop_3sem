using System;
using System.Collections.Generic;
using System.Linq;

namespace laba9
{
    class Programmer
    {
        public delegate void ProgrammerHandler(List<string> list);
        public event ProgrammerHandler Removing;
        public event ProgrammerHandler Mutation;

        public void Remove(List<string> list)
        {
            Console.WriteLine("Enter a number of element you want to remove");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;
            list.RemoveAt(index);
            Removing?.Invoke(list);
        }
        public void Mutate(List<string> list)
        {
            Random random = new Random();
            List<string> tmp = list.OrderBy(i => random.Next()).ToList();
            list = tmp;
            Mutation?.Invoke(list);
        }
        public void ShowList(List<string> list)
        {
            Console.WriteLine("-------------");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------");
        }
    }
}
