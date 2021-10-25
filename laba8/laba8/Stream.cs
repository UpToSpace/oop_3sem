using System;
using System.IO;
using System.Text;

namespace laba8
{
    class Streams<T> where T : class
    {
        public static void InFile(string path, ref List<T> list)
        {
            Node<T> node = list.Head;
            using (StreamWriter sw = new StreamWriter(path, false, Encoding.Default))
            {
                while (node != null)
                {
                    sw.WriteLine(node.Info);
                    node = node.Next;
                }
            }
        }
        public static void OutFile(string path, ref List<string> list)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string[] items = sr.ReadToEnd().Split('\n');
                foreach (var item in items)
                {
                    list.AddNode(item);
                }
            }
        }
    }
}
