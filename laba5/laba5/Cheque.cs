using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    class Cheque : Date, IDocument
    {
        public Cheque(int date)
        {
            SetDate(date);
        }
        public void ShowInfo()
        {
            Console.WriteLine("hello im " + GetType());
        }
    }
}
