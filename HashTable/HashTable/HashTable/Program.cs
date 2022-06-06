using Hashtables;
using System;

namespace Hashtables
{
    class Program
    {
        static void Main(string[] args)
        {            

            Node n1 = new Node("Real Madrid", "14");
            Node n2 = new Node("AcMilan", "7");
            Node n3 = new Node("FC Bayern München", "6");
            Node n4 = new Node("Liverpool FC", "6");
            Node n5 = new Node("Barcelona", "5");
            

            Hashtable hashtable = new Hashtable();

            hashtable.Add(n1);
            hashtable.Add(n2);
            hashtable.Add(n3);
            hashtable.Add(n4);
            hashtable.Add(n5);           

            Console.WriteLine("Trying to find a value for Real Madrid: Expected - 14");
            Console.WriteLine(hashtable.Find("Real Madrid"));

            Console.WriteLine("Trying to find a value for AcMilan: Expected - 7");
            Console.WriteLine(hashtable.Find("AcMilan"));

            Console.WriteLine("Trying to find a value for FC Bayern München: Expected - 6");
            Console.WriteLine(hashtable.Find("FC Bayern München"));

            Console.WriteLine("Trying to see if node is in hashtable: Expected - True");
            Console.WriteLine(hashtable.Contains("Liverpool FC"));

            Console.WriteLine("Trying to see if node is in hashtable: Expected - False");
            Console.WriteLine(hashtable.Contains("Barcelona Winners"));

        }
    }
}