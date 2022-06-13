﻿using HashTable;
using Hashtables;
using System;

namespace Hashtables
{
    class Program
    {
        static void Main(string[] args)
        {            

            //Node n1 = new Node("Real Madrid", "14");
            //Node n2 = new Node("AcMilan", "7");
            //Node n3 = new Node("FC Bayern München", "6");
            //Node n4 = new Node("Liverpool FC", "6");
            //Node n5 = new Node("Inter", "2");


            //Hashtable hashtable = new Hashtable(5);

            //hashtable.set(n1.Key, n1.Value);
            //hashtable.set(n2.Key, n2.Value);
            //hashtable.set(n3.Key, n3.Value);
            //hashtable.set(n4.Key, n4.Value);
            //hashtable.set(n5.Key, n5.Value);

            //Console.WriteLine("Trying to find a value for Real Madrid: Expected - 14");
            //Console.WriteLine(hashtable.get("Real Madrid"));

            //Console.WriteLine("Trying to find a value for AcMilan: Expected - 7");
            //Console.WriteLine(hashtable.get("AcMilan"));

            //Console.WriteLine("Trying to find a value for FC Bayern München: Expected - 6");
            //Console.WriteLine(hashtable.get("FC Bayern München"));

            //Console.WriteLine("Trying to see if node is in hashtable: Expected - True");
            //Console.WriteLine(hashtable.Contains("Liverpool FC"));

            //Console.WriteLine("Trying to see if node is in hashtable: Expected - False");
            //Console.WriteLine(hashtable.Contains("Barcelona"));

            Console.WriteLine("*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*");

            Console.WriteLine("Repeated Word");

            string sentence = "This is a sentence and is also a test";
            HashTableRepeatedWord hashTableRepeatedWord = new HashTableRepeatedWord();
            Console.WriteLine($"{sentence}: The first repeated word is: ");
            Console.WriteLine(hashTableRepeatedWord.RepeatedWord(sentence));

        }
    }
}