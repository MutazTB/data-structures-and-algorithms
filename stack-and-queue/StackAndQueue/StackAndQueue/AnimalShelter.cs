using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackAndQueue;

namespace StackAndQueue
{
    public class AnimalShelter<T>
    {
        Queue<T> dogQueue = new Queue<T>();
        Queue<T> catQueue = new Queue<T>();

        public void Enqueue(T node)
        {
            Node<T> temp = new Node<T>(node);
            if (node.ToString().ToLower().Equals("dog"))
            {
                dogQueue.Enqueue(temp.Value);
            }
            else if (node.ToString().ToLower().Equals("cat"))
            {
                catQueue.Enqueue(temp.Value);
            }
            else
            {
                throw new Exception("Sorry, only cats and dogs at this shelter");
            }

        }

        public Node<T> Dequeue(T pref)
        {
            try
            {

                if (pref.ToString().ToLower().Equals("dog"))
                {
                    Node<T> temp = dogQueue.Dequeue();
                    return temp;

                }
                else if (pref.ToString().ToLower().Equals("cat"))
                {
                    Node<T> temp = catQueue.Dequeue();
                    return temp;
                }
            }
            catch
            {
                throw new Exception("Sorry, only cats and dogs at this shelter");
            }
            return null;
        }

        public T Peek(T pref)
        {
            if (pref.ToString().ToLower().Equals("dog"))
            {
                if (dogQueue.IsEmpty())
                {
                    Console.WriteLine("The Dog queue is empty");
                    return default;
                }
                return dogQueue.front.Value;
            }
            else if (pref.ToString().ToLower().Equals("cat"))
            {
                if (catQueue.IsEmpty())
                {
                    Console.WriteLine("The Cat queue is empty");
                    return default;
                }
                return catQueue.front.Value;
            }
            else
                throw new Exception("Sorry, only cats and dogs at this shelter");

        }
    }
}
