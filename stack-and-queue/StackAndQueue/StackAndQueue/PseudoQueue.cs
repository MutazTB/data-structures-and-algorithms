using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class PseudoQueue<T>
    {
        public Stack<T> s1 = new Stack<T>();
        public Stack<T> s2 = new Stack<T>();      
       
        public void Enqueue(T node)
        {
            s1.Push(node);
        }

        public Node<T> Dequeue()
        {
            //transer all nodes from s1 to s2 for correct order
            while (!s1.IsEmpty())
            {
                s2.Push(s1.Pop().Value);
            }
            
            //Node that is being dequeued, "front".
            Node<T> temp = s2.Pop();

            //transfer all nodes back to s1 for correct order with enqueue
            while (!s1.IsEmpty())
            {
                s1.Push(s2.Pop().Value);
            }

            return temp;
        }
    }
}
