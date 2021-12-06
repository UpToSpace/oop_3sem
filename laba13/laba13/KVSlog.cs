using System;
using System.IO;
using System.Text;

namespace laba13
{
    static class KVSlog
    {
        public static void WriteLog(string message)
        {
            string path = @"D:\University\3\oop\laba13\laba13\log.txt";
            using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                sw.WriteLine($"{DateTime.Now}: {message}");
            }
        }
        public static void Search(string name)
        {
            StringBuilder newFile = new StringBuilder();
            string path = @"D:\University\3\oop\laba13\laba13\log.txt", str;
            int lineNumber = 0;
            using (StreamReader sw = new StreamReader(path))
            {
                while (!sw.EndOfStream)
                {
                    str = sw.ReadLine();
                    if (str.Contains(name))
                    {
                        Console.WriteLine(str);
                    }
                    else
                    {
                        newFile.Append(str + "\n");
                    }
                    lineNumber++;
                }
            }
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine("Number of lines: {0}", lineNumber);
                sw.WriteLine(newFile);
            }
        }
    }
}
