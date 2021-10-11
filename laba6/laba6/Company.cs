using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba6
{
    struct Company
    {
        public int age;
        public string company;
        public void PrintInfo()
        {
            Console.WriteLine($"Company name is {company}, age of the company is {age}");
        }
    }
}
