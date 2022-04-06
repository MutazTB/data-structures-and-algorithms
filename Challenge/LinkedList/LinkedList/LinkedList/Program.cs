using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> liste = new LinkedList<int>();
            LinkedList<int> liste1 = new LinkedList<int>();
            LinkedList<int> liste2 = new LinkedList<int>();
            liste1.Append(10);
            liste1.Append(30);
            liste1.Append(50);
            liste2.Append(20);
            liste2.Append(40);
            liste2.Append(60);
            //liste.Append(15);
            //liste.AddFirst(20);
            //liste.AddFirst(1);
            //liste.AddBefore(20, 50);
            //liste.AddAfter(20, 60);
            //liste.AddAfter(60, 600);
            //liste.AddBefore(20,5);
            //liste.Search(60);
            //liste.Search(63);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(liste1.ToSstring());
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(liste2.ToSstring());
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            liste.MergeLists(liste1, liste2);
            Console.WriteLine(liste.ToSstring());
            Console.ForegroundColor = ConsoleColor.Black;
            //Console.WriteLine("The KthFromEnd function output is :");
            //liste.kthFromEnd(3);


        }
    }
}
