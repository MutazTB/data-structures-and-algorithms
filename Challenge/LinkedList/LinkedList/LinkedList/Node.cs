using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Node<T>
    {
        public T data;
        public Node<T> next;

        public T Data 
        {
            get; set;
        }

        public Node<T>  Next 
        
        {
            get; set;
        }

        public Node(T value)
        {
            Data = value;
            Next = null;
        }
    }
}
