using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace laba12
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "laba12.Product";
            using (StreamWriter sw = new StreamWriter(@"text.txt", false, Encoding.Default))
            {
                sw.WriteLine(Reflector.GetAssemblyName());
                sw.WriteLine("-----------");
                sw.WriteLine(Reflector.HasPublicConstructors(name));
                sw.WriteLine("-----------");

                Reflector.PublicMethods(name, sw);
                sw.WriteLine("-----------");
                Reflector.FieldsAndProperties(name, sw);
                sw.WriteLine("-----------");
                Reflector.Interfaces(name, sw);
                sw.WriteLine("-----------");
                Reflector.MethodType(name, "newPrice", sw); 
                sw.WriteLine("-----------");
                Reflector.Invoke(name, "Print");
                sw.WriteLine(Reflector.Create(name).ToString());
                sw.WriteLine("-----------");
                sw.WriteLine("-----------");
                sw.WriteLine("-----------");
            }
            name = "System.String";
            using (StreamWriter sw = new StreamWriter(@"text.txt", true, Encoding.Default))
            {
                sw.WriteLine(Reflector.GetAssemblyName());
                sw.WriteLine("-----------");
                sw.WriteLine(Reflector.HasPublicConstructors(name));
                sw.WriteLine("-----------");

                Reflector.PublicMethods(name, sw);
                sw.WriteLine("-----------");
                Reflector.FieldsAndProperties(name, sw);
                sw.WriteLine("-----------");
                Reflector.Interfaces(name, sw);
                sw.WriteLine("-----------");
                Reflector.MethodType(name, "value", sw);
            }
        }
    }
}
