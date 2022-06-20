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
            Node n4 = new Node("Liverpool FC", "5");
            Node n5 = new Node("Inter", "2");

            Node n6 = new Node("Real Madrid", "1454");
            Node n7 = new Node("AcMilan", "7244");
            Node n8 = new Node("FC Bayern München", "654");
            Node n9 = new Node("Liverpool FC", "65884");
            Node n10 = new Node("Inter", "2588");
            
            Node n15 = new Node("2", "2");
            Node n16 = new Node("5", "5");
            Node n17 = new Node("7", "7");
            Node n18 = new Node("1", "1");



            Hashtable hashtable = new Hashtable();

            hashtable.set(n1.Key, n1.Value);
            hashtable.set(n2.Key, n2.Value);
            hashtable.set(n3.Key, n3.Value);
            hashtable.set(n4.Key, n4.Value);
            hashtable.set(n5.Key, n5.Value);

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
            //List<string[]> leftJoin = LeftJoin(hashtable, hashtable2);

            // Print contents of list of arrays to the console
            //foreach (var array in leftJoin)
            //{
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        Console.Write($"{array[i]} ");
            //    }
            //    Console.WriteLine("");
            //}
            //Console.WriteLine("");                       
            BinaryTree tree1 = new BinaryTree(n5);
            tree1.Root.Left = n2;
            tree1.Root.Right = n3;
            tree1.Root.Left.Right = n4;

            BinaryTree tree2 = new BinaryTree(n15);
            tree2.Root.Left = n16;
            tree2.Root.Right = n17;
            tree2.Root.Right.Left = n18;

            List<string> intersections = TreeIntersection(tree1, tree2);
            Console.WriteLine("Tree Intersection");
            Console.WriteLine("The following are intersections: ");
            foreach (string value in intersections)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();

        }

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
        
        public static List<string> TreeIntersection(BinaryTree tree1, BinaryTree tree2)
        {
            List<string> result = new List<string>();
            Hashtable hashtable = new Hashtable();

            List<string> firstTree = tree1.InOrder(tree1.Root);
            List<string> secondtree = tree2.InOrder(tree2.Root);

            foreach (string value in firstTree)
            {
                Node node = new Node(value);
                hashtable.set(node.Value, null);
            }
            foreach (string value in secondtree)
            {
                if (hashtable.Contains(value))
                {
                    result.Add(value);
                }
            }
            return result;
        }

    }
}