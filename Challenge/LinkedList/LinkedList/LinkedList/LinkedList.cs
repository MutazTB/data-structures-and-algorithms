using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList<T>
    {
         Node<T> Head { get; set; }
         Node<T> Tail { get; set; }

        public LinkedList()
        {
            Head = null;
            Tail = null;
        }
        // To add before the index in the linked list
        public void AddBefore(T node, T data)
        {
            if (Head == null)
            {
                Head = new Node<T>(data);
            }
            Node<T> current = Head;
            if (Head.Data.Equals(node))
            {
                Node<T> newNode = new Node<T>(data);
                newNode.Next = current.Next;
                Head = newNode;
                newNode.Next = current;
            }
            else if (Head.next == null)
            {
                Console.WriteLine("Add Before function say node not exsist");
            }
            else
            {
                while (!current.Next.Data.Equals(node))
                {
                    if (current.Next == null)
                    {
                        Console.WriteLine("node not exsist");
                        break;
                    }
                    else
                    {
                        current = current.Next;
                        if (current.Next == null)
                        {
                            break;
                        }
                    }
                }
                if (current.Next == null)
                {
                    Console.WriteLine("Add Before function say node not exsist");
                }
                else
                {
                    Node<T> newNode = new Node<T>(data);
                    newNode.Next = current.Next;
                    current.Next = newNode;
                }
            }
        }
        // To add after the index in the linked list
        public void AddAfter(T node, T data)
        {
            if (Head == null)
            {
                Head = new Node<T>(data);
            }

            Node<T> current = Head;
            if (Head.Data.Equals(node))
            {
                Node<T> newNode = new Node<T>(data);
                newNode.Next = current.Next;
                current.Next = newNode;
            }
            else
            {
                while (!current.Data.Equals(node))
                {
                    if (current.Next == null)
                    {
                        break;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }

                if (current.Next == null)
                {
                    Console.WriteLine("Add After function say node not exsist");
                }
                else
                {
                    Node<T> newNode = new Node<T>(data);
                    newNode.Next = current.Next;
                    current.Next = newNode;
                }
            }
        }
        // To add in the last of the linked list
        public void Append(T value)
        {
            Node<T> item = new Node<T>(value);

            if (Head == null)
            {
                Head = item;
                Tail = item;
            }
            else
            {
                Tail.Next = item;
                Tail = item;
            }
        }
        // To display linked list
        public void ToSstring() 
        {
            Node<T> start = Head;
            if (start == null)
            {
                Console.WriteLine("Your llist is empty");
            }
            else
            {
                while (start != null)
                {
                    Console.Write("["+start.Data+"] -> ");
                    start = start.Next;
                }
                Console.WriteLine("null");
            }
        }
        // To add in the first of the linked list
        public void AddFirst(T value)
        {
            Node<T> item = new Node<T>(value);

            if (Head == null)
            {
                Head = item;
                Tail = item;
            }
            else
            {
                item.Next = Head;
                Head = item;
            }
        }
        // To search in the linked list for Node
        public bool Search(T value)
        {
            Node<T> current = new Node<T>(value);
            current = Head;
            while (current != null)
            {
                if (current.Data.Equals(value))
                {
                    Console.WriteLine("Found it");
                    return true;
                }
                current = current.Next;
            }
            if(current == null)
            {
                Console.WriteLine("Not found");
            }
            return false;
        }
    }
}
