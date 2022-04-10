using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class Queue<T>
    {
        public Node<T> front { get; set; }
        public Node<T> rear { get; set; }

        public Queue()
        {
           // Node node = new Node(value);
            front = null;
            rear = null;
        }

        public void Enqueue(T node)
        {
            // Node node = new Node(value);
            //Handle case where queue has been instantiated with null
            Node<T> temp = new Node<T>(node);            

            if (front == null)
                front = temp;
            else
                rear.next = temp;
            rear = temp;
        }

        public Node<T> Dequeue()
        {
            try
            {
                Node<T> node;
                node = front;
                front = front.next;
                return node;
            }
            catch
            {
                return null;
            }
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty");
                return default;
            }
            else
                return front.Value;
        }

        public bool IsEmpty()
        {
            return (front == null);
        }
    }
}
