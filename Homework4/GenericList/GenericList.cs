using System;

namespace GenericList
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    //泛型链表类
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public Node<T> Head
        {
            get => head;
        }
        public Node<T> Tail
        {
            get => tail;
        }
        public GenericList()
        {
            tail = head = null;
        }

        public void Add(T t)
        {
            var n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
    public void ForEach(Action<T> action)
    {
        for (var nowNode = Head; nowNode != null; nowNode = nowNode.Next)
            action(nowNode.Data);
    }
    }

}
