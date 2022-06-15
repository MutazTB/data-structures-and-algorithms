using HashTable;
using Hashtables;
using System;
using System.Collections.Generic;

namespace Hashtables
{
    public class Program
    {
        static void Main(string[] args)
        {

            Node n1 = new Node("Real Madrid", "14");
            Node n2 = new Node("AcMilan", "7");
            Node n3 = new Node("FC Bayern München", "6");
            Node n4 = new Node("Liverpool FC", "6");
            Node n5 = new Node("Inter", "2");


            Hashtable hashtable = new Hashtable();

            hashtable.set(n1.Key, n1.Value);
            hashtable.set(n2.Key, n2.Value);
            hashtable.set(n3.Key, n3.Value);
            hashtable.set(n4.Key, n4.Value);
            hashtable.set(n5.Key, n5.Value);

            Node n6 = new Node("Real Madrid", "1454");
            Node n7 = new Node("AcMilan", "7244");
            Node n8 = new Node("FC Bayern München", "654");
            Node n9 = new Node("Liverpool FC", "65884");
            Node n10 = new Node("Inter", "2588");
            Hashtable hashtable2 = new Hashtable();

            hashtable2.set(n6.Key, n6.Value);
            hashtable2.set(n7.Key, n7.Value);
            hashtable2.set(n8.Key, n8.Value);
            hashtable2.set(n9.Key, n9.Value);
            hashtable2.set(n10.Key, n10.Value);

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

            //Console.WriteLine("Repeated Word");

            //string sentence = "This is a sentence and is also a test";
            //HashTableRepeatedWord hashTableRepeatedWord = new HashTableRepeatedWord();
            //Console.WriteLine($"{sentence}: The first repeated word is: ");
            //Console.WriteLine(hashTableRepeatedWord.RepeatedWord(sentence));

            //Console.WriteLine( LeftJoin(hashtable, hashtable2));
            List<string[]> leftJoin = LeftJoin(hashtable, hashtable2);

            // Print contents of list of arrays to the console
            foreach (var array in leftJoin)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");

        }


        //public static List<string[]> LeftJoin(Hashtable ht1, Hashtable ht2)
        //{
        //    // Initialize list of arrays
        //    List<string[]> listOfArrays = new List<string[]>();

        //    // Traverse left hash table
        //    for (int i = 0; i < ht1.data.Length; i++)
        //    {
        //        if (ht1.data[i] != null)
        //        {
        //            foreach (var node in ht1.data[i])
        //            {
        //                Node ht1Node = new Node( "khkghkg",ht1.get(node.Key));
        //                ht1Node.Value =  ht1.get(node.Key);

        //                // Initialize new array to hold current table row's contents
        //                string[] array = new string[3];

        //                // Populate array's first two indices with key and value from left table
        //                array[0] = ht1Node.Key;
        //                array[1] = ht1Node.Value;

        //                if (ht2.Contains(ht1Node.Key))
        //                {
        //                    Node ht2Node = new Node("khkghkg", ht2.get(node.Key));
        //                    array[2] = ht2Node.Value;
        //                }
        //                else
        //                {
        //                    array[2] = "NULL";
        //                }

        //                listOfArrays.Add(array);
        //            }
        //        }
        //    }
        //    return listOfArrays;
        //}


        public static List<string[]> LeftJoin(Hashtable h1, Hashtable h2)
        {
            List<string[]> answerList = new List<string[]>();
            for (int i = 0; i < h1.Table.Length; i++)
            {
                if (h1.Table[i] != null)
                {
                    string[] answerArray = new string[] { h1.Table[i].Key, h1.Table[i].Value, "NULL" };
                    if (h2.Table[i] != null)
                    {
                        h2.Current = h2.Table[i];
                        while (h2.Current.Next != null)
                        {
                            if (h2.Current.Key == h1.Table[i].Key)
                            {
                                break;
                            }
                            h2.Current = h2.Current.Next;
                        }
                        if (h2.Current.Key == h1.Table[i].Key)
                        {
                            answerArray[2] = h2.Current.Value;
                        }
                    }
                    answerList.Add(answerArray);
                }
            }
            return answerList;
        }

    }
}