namespace laba8
{
    class Node<T>
    {
        T info;
        Node<T> next;
        public T Info
        {
            get => info;
            set => info = value;
        }
        public Node<T> Next
        {
            get => next;
            set => next = value;
        }
    }
}
