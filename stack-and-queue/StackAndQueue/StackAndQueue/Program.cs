using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {            
            Stack<int> stack = new Stack<int>();
            Node<int> node1 = new Node<int>(55);
            Node<int> node2 = new Node<int>(4);
            //stack.Push(node1);
            //stack.Push(node2);
            //stack.Push(node1);
            //stack.Push(node2);
            Queue<int> queue = new Queue<int>();
            //queue.Enqueue(node1);
            //queue.Dequeue();
            //queue.Dequeue();
            //queue.Enqueue(node2.Value);
            //Console.WriteLine(queue.Peek());
            //Console.WriteLine(queue.IsEmpty());
            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.IsEmpty());

            PseudoQueue<int> pseudoQueue = new PseudoQueue<int>();

            pseudoQueue.Enqueue(20);
            pseudoQueue.Enqueue(15);
            pseudoQueue.Enqueue(10);
            pseudoQueue.Enqueue(5);
                                    
            Console.WriteLine(pseudoQueue.Dequeue().Value);
        }
    }
}
