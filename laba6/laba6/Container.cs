using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba6
{
    class Bookkeeping : IEnumerable
    {
        private List<Document> docs;
        public Bookkeeping()
        {
            docs = new List<Document>();
        }
        public IEnumerator GetEnumerator()
        {
            return docs.GetEnumerator();
        }
        public void Add(Document doc)
        {
            docs.Add(doc);
        }
        public void Remove(Document doc)
        {
            docs.Remove(doc);
        }
        public void ShowList()
        {
            Console.WriteLine("Number of elements " + docs.Count);
            foreach (var item in docs)
            {
                item.ShowInfo();
            }
        }
    }
}
