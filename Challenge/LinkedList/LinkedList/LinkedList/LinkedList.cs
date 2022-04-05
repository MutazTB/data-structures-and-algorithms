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
            Node<T> temp;
            // if list is empty
            if (Head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            // if x is the first node the new node will be inserted before the first node
            if (node.Equals(Head.Data))
            {
                temp = new Node<T>(data);
                temp.Next = Head;
                Head = temp;
                return;
            }
            Node<T> current = Head;
            while (current.Next != null)
            {
                if (current.Next.Data.Equals(node))
                    break;
                current = current.Next;
            }
            if (current.Next == null)
                Console.WriteLine(node + " not present in the list");
            else
            {
                temp = new Node<T>(data);
                temp.Next = current.Next;
                current.Next = temp;
            }
        }
        // To add after the index in the linked list
        public void AddAfter(T node, T data)
        {
            Node<T> current = Head;
            while (current != null)
            {
                if (current.Data.Equals(node))
                    break;
                current = current.Next;
            }
            if (current == null)
                Console.WriteLine(node + " not present  the list");
            else
            {
                Node<T> temp = new Node<T>(data);
                temp.Next = current.Next;
                current.Next = temp;
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

        public bool kthFromEnd(int value)
        {
            if (value < 0)
            {
                return false;
            }
            int count = 0;
            Node<T> prev, current, next;
            prev = null;
            current = Head;
            if (Head == null)
            {
                Console.WriteLine("The list is empty");
                return false;
            }
            // revers the linked list
            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            Head = prev;

            // just for print after revers 
            //while (Head != null)
            //{
            //    Console.Write("[" + Head.Data + "] -> ");
            //    Head = Head.Next;
            //}
            //Console.WriteLine("null");

            while (!Head.Data.Equals(null))
            {
                if (Head.Next == null)
                {
                    break;
                }
                else
                {
                    count++;
                    Head = Head.Next;
                }
                if (count == value)
                {
                    Console.WriteLine(Head.Data);
                    return true;
                }
            }
            if (value == count)
            {
                return true;
            }
            else
            {
                Console.WriteLine($"The list's size less than {value}");
            }
            return false;
        }
    }
}
