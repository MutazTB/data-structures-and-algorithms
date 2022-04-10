using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class Stack<T>
    {
        public Node<T> Top { get; set; }

        public Stack()
        {
            Top = null;
        }

        public T Peek()
        {            
                if (IsEmpty())
                {
                    Console.WriteLine("The stack is empty");
                    return default;
                }
                else 
                {
                    T top = Top.Value;
                    return top;
                }                                        
        }

        public Node<T> Pop()
        {
            Node<T> temp = Top;
            Top = Top.next;
            temp.next = null;
            return temp;
        }

        public void Push(T node)
        {
            Node<T> temp = new Node<T>(node);
            temp.next = Top;
            Top = temp;
        }
        public bool IsEmpty()
        {
            return (Top == null);
        }
    }
}
