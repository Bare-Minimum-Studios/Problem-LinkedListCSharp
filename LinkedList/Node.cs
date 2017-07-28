using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class Node<T>
    {
        Node<T> next, prev;
        T data;

        public Node(T data, Node<T> prev, Node<T> next)
        {

        }

        public Node(T data) : this(data, null, null)
        {

        }
    }
}
