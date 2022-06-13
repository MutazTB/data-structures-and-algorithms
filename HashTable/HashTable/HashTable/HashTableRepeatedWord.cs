using Hashtables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class HashTableRepeatedWord
    {
        public string RepeatedWord(string sentence)
        {
            string[] words = sentence.Split(" ");
            Hashtable hashtable = new Hashtable(5);

            foreach (string word in words)
            {
                if (!hashtable.Contains(word))
                {
                    Node node = new Node(word.ToLower(), word.ToLower());
                    hashtable.set(node.Key,node.Value);
                }
                else
                {
                    return word.ToLower();
                }
            }
            return "No Repeated Words.";
        }
    }
}
