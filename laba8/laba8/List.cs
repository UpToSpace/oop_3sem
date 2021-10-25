using System;
namespace laba8
{
    class List<T> : IGeneric<T> where T : class
    {
        public class Date
        {
            public void PrintDate()
            {
                Console.WriteLine("Create date: " + DateTime.Now);
            }
        }
        Node<T> tail;
        Node<T> head;
        int length;
        public List()
        {
            tail = null;
            head = null;
            length = 0;
        }
        public Node<T> Head
        {
            get => head;
        }
        public void AddNode(T info)
        {
            Node<T> node = new Node<T>();
            node.Info = info;
            if (head == null)
            {
                head = node;
            }
            else
            {
                tail.Next = node;
            }
            tail = node;
            length++;
        }
        public void DeleteNode(T info)
        {
            Node<T> curr = head;
            Node<T> prev = null;
            bool deleted = false;
            while (curr != null)
            {
                if (curr.Info.Equals(info))
                {
                    if (prev != null)
                    {
                        prev.Next = curr.Next;
                        if (curr.Next == null)
                            tail = prev;
                    }
                    else
                    {
                        head = head.Next;

                        if (head == null)
                            tail = null;
                    }
                    length--;
                    deleted = true;
                }
                prev = curr;
                curr = curr.Next;
            }
            if (!deleted)
            {
                throw new Exception("An element was not found");
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("length is " + length);
            Node<T> node = head;
            Console.WriteLine("--------------------------");
            while (node != null)
            {
                Console.WriteLine(node.Info);
                node = node.Next;
            }
            Console.WriteLine("--------------------------");
        }
    }
}
