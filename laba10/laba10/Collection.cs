using System;
using System.Collections.Generic;
using System.Collections;

namespace laba10
{
    class Collection<T> : IEnumerable<T>
    {
        private ArrayList items = new ArrayList();
        public void Add(T item)
        {
            items.Add(item);
        }
        public void Delete(T item)
        {
            items.Remove(item);
        }
        public void Search(T item)
        {
            if(items.Contains(item))
            {
                Console.WriteLine($"Item {item} was found");
            }
            else
            {
                Console.WriteLine($"Item {item} was not found");
            }
        }
        public void ShowCollection()
        {
            Console.WriteLine("------------------------");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------");
        }

        IEnumerator<T> GetEnumerator()
        {
            return new CollectionEnumerator<T>(items);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return ((IEnumerable<T>)items).GetEnumerator();
        }
    }
    class CollectionEnumerator<T> : IEnumerator<T>
    {
        private ArrayList items;
        private int position = -1;
        public CollectionEnumerator(ArrayList items)
        {
            this.items = items;
        }
        public T Current => (T)items[position];

        object IEnumerator.Current => Current;

        public void Dispose() // to delete data from memory
        {
        }

        public bool MoveNext()
        {
            position++;
            return position < items.Count; // returns false if weve iterated to the end
        }

        public void Reset()
        {
            position = -1; // beginning position
        }
    }
}
