using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> liste = new LinkedList<int>();

            liste.AddLast(10);
            liste.AddLast(15);
            liste.AddLast(20);
            //liste.AddFirst(1);
            liste.Search(7);
            liste.Search(10);
            liste.ToString();

        }
    }
}
