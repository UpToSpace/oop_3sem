using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = false;
            byte b = 1;
            sbyte c = -3;
            char d = 'a';
            decimal e = 10;
            double f = 2.11;
            float g = 3.294f;
            int h;
            uint integ = 2;
            long l = -3990;
            ulong m = 29;
            short n = -6;
            ushort o = 44;

            Console.WriteLine("Enter int ");
            h = Convert.ToInt32(Console.ReadLine());
            Console.Write($"bool {a},\nbyte {b},\nsbyte {c},\nchar {d},\ndecimal {e},\ndouble {f},\nfloat {g},\nint {h},\nuint {integ},\nlong {l},\nulong {m},\nshort {n},\nushort {o} \n");

            // преобразования

            h = b;
            f = g;
            l = n;
            m = o;
            e = m;

            Console.WriteLine("неявное преобразование: int to byte {0}, double to float {1}, long to short {2}, ulong to ushort {3}, decimal to ulong {4}", h, f, l, m, e);
            g = (int)g;
            a = bool.Parse("true");
            e = decimal.Parse("333");
            h = Convert.ToInt32(g);
            f = Convert.ToDouble(m);
            Console.WriteLine($"явное преобразование: {g}, {a}, {e}, {h}, {f}");

            // упаковка распаковка
            Object box = h;
            int unbox = (int)box;

            // неявно типизированная
            var v = 'c';

            // nullable
            Nullable<int> t = null;

            Console.WriteLine($"box {box}, unbox {unbox}, var {v}, nullable {t}");

            //literals.comparison
            string town = "Minsk";
            string city = "Minsk";
            if (String.Compare(town, city) == 0)
            {
                Console.WriteLine("имена одинаковы");
            }
            else
            {
                Console.WriteLine("имена различны");
            }
            // Сцепление, копирование, выделение подстроки...
            string phrase = " is good";
            string concat = city + phrase; // Сцепление
            Console.WriteLine(concat);
            string cities = "Minsk,Grodno,Brest,Lida,Gomel";
            string copy = concat; // Копирование
            string[] citylist = cities.Split(',');
            foreach (string s in citylist)
            {
                Console.Write(s + ", ");
            }
            // Вставка подстроки в заданную позицию
            string first = "wea";
            string second = "leather";
            Console.WriteLine("\n" + first + second.Substring(3));
            string st = "lea";
            Console.WriteLine(second.Replace(st, "")); // Удаление подстроки   

            string Empty = "";
            string Null = null;

            if (String.IsNullOrWhiteSpace(Empty) || String.IsNullOrEmpty(Null))
            {
                Console.WriteLine("\nОбе строки равны null или пустые!");
            }
            else
            {
                Console.WriteLine("\nОдна из строк не null или не пустая!");
            }
            StringBuilder Quote = new StringBuilder("туда пойти");
            Quote.Insert(5, "и ");
            Quote.Remove(7, 5);
            Quote.Append("обратно.");
            Console.WriteLine("\n" + Quote + "\n");

            //матрица
            int[,] A = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(A[i, j] + "\t");
                }
                Console.Write("\n\n");
            }

            // одномерный массив
            try
            {
                foreach (string s in citylist)
                {
                    Console.Write(s + ", ");
                }
                Console.WriteLine("\n length of the list is " + citylist.Length + "\n Enter a number of element to change");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num > citylist.Length - 1)
                {
                    throw new Exception("a number is big");
                }
                Console.WriteLine("Enter new value");
                citylist[num] = Console.ReadLine();
                if (String.IsNullOrEmpty(citylist[num]))
                {
                    throw new Exception("new value is empty");
                }
                foreach (string s in citylist)
                {
                    Console.Write(s + ", ");
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // ступенчатый массив
            float[][] Arr = new float[3][];
            Arr[0] = new float[2];
            Arr[1] = new float[3];
            Arr[2] = new float[4];
            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = 0; j < Arr[i].Length; j++)
                {
                    Console.Write(Arr[i].Length + "\t");
                }
                Console.WriteLine();
            }

            // неявно типизированные 
            var varInt = new int[] { 1, 2, 3 };
            var varStr = "hey";

            // corteges
            (int, string, char, string, ulong) Cortege = (2021, "Year", 'Y', "Month", 9);
            Console.WriteLine(Cortege.Item1 + ", " + Cortege.Item2 + ", " + Cortege.Item3 + ", " + Cortege.Item4 + ", " + Cortege.Item5);
            Console.WriteLine(Cortege.Item1 + " " + Cortege.Item2);
            // распаковка и сравнение
            (var ad, var bd) = (133, 8.8f);
            Console.WriteLine(ad + ", " + bd);
            (int, string) Year1 = (2020, "Year");
            (int, string) Year2 = (2020, "Year");
            if (Year1 == Year2)
            {
                Console.WriteLine("corteges are equal");
            }
            else
            {
                Console.WriteLine("corteges are not equal");
            }

            //local functions
            Tuple<int, int, int, char> local (int[] Arrr, string Str)
            {
                return Tuple.Create(Arrr.Max(), Arrr.Min(), Arrr.Sum(), Str[0]);
            }
            int[] tupleArr = { 1, 2, 3, 4, 5 };
            Tuple<int, int, int, char> T = local(tupleArr, "hello");
            Console.WriteLine(T);

            // переполнение
            void over1 ()
            {
                int integer = int.MaxValue;
                try
                {
                    checked
                    {
                        integer++;
                    }
                }
                catch (OverflowException)
                {

                    Console.WriteLine("Overflow!");
                }
            }
            void over2 ()
            {
                int integer = int.MaxValue;
                try
                {
                    unchecked
                    {
                        integer++;
                    }
                }
                catch (OverflowException)
                {

                    Console.WriteLine("Overflow!");
                }
            }
            over1();
            over2();
        }
    }
}
