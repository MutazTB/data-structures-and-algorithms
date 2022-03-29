using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> liste = new LinkedList<int>();            
            
            liste.Append(15);
            liste.Append(20);
            liste.AddFirst(1);
            liste.AddBefore(1, 60);
            liste.AddAfter(1, 63);
            liste.Search(60);
            liste.Search(63);
            liste.ToSstring();


        }       
    }
}
