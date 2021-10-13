using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5_7
{
    public class NullObject : Exception
    {
        private string message;
        public NullObject()
        {
            message = "Null object";
        }
        public void PrintInfo()
        {
            Console.WriteLine("Message occured: " + message + " in method: " + TargetSite);
        }
    }
    public class WrongDate : Exception
    {
        private string message;
        public WrongDate(string message)
        {
            this.message = message;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Message occured: " + message + " in method: " + TargetSite);
        }
    }
    public class EmptyStruct : Exception
    {
        public void PrintInfo()
        {
            Console.WriteLine("Message occured: Struct fields are uninitialized" + " in method: " + TargetSite);
        }
    }
}
