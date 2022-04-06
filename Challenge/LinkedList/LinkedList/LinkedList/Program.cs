using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> liste = new LinkedList<int>();            
            
            //liste.Append(15);
            liste.AddFirst(20);
            liste.AddFirst(1);
            liste.AddBefore(20, 50);
            liste.AddAfter(20, 60);
            liste.AddAfter(60, 600);
            liste.AddBefore(20,5);
            liste.Search(60);
            liste.Search(63);
            liste.ToSstring();
            Console.WriteLine("The KthFromEnd function output is :");
            liste.kthFromEnd(3);


        }
    }
}
