using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables
{
    public class Hashtable
    {
        private class MyNodes : List<Node> { }
        private int length;
        private MyNodes[] data;

        //Hash Table Constructor
        public Hashtable(int size)
        {
            length = size;
            data = new MyNodes[size];
        }
        
        private int hash(string key)
        {
            int hash = 0;

            //Looping over length of key
            for (int i = 0; i < key.Length; i++)
            {
                //hashing formula
                hash = (hash + (int)key[i] * i) % length;
            }
            return hash;
        }
       
        public void set(string key, string value)
        {
            //Setting index value to hash function
            int index = hash(key);

            //If hash function is empty (nothing stored)
            if (data[index] == null)
            {
                //Create a new key value node
                data[index] = new MyNodes();
            }
            //Else, add Node to hash table at hash function index
            data[index].Add(new Node(key, value));
        }
        
        public string get(string key)
        {
            int index = hash(key);
            if (data[index] == null)
            {
                //No match return 0
                return "0";
            }
            //For each node in the array of nodes
            foreach (var node in data[index])
            {
                //if the node key equals the key inserted
                if (node.Key.Equals(key))
                {
                    //Return the value of that key
                    return node.Value;
                }
            }
            return "0";
        }

        /// <summary>
        /// Method to search all keys in hash table
        /// </summary>
        /// <returns></returns>
        public List<string> keys()
        {
            List<string> result = new List<string>();
            //Looping over array of Nodes
            for (int i = 0; i < data.Length; i++)
            {
                //If node not empty
                if (data[i] != null)
                {
                    //Start a second loop over the hash table
                    for (int j = 0; j < length; j++)
                    {
                        //Add keys to list. The First element in the Node Array will be null so this logic works. The second array element [1] onwards holds a list of key value pairs and it is this list that j is incrementing to pull out all the keys. 
                        //Will iterate all increments of j before moving out of the loop to the outer for loop whch traverses the Node Array
                        result.Add(data[i][j].Key);
                    }
                }
            }
            return result;
        }
        
        public bool Contains(string key)
        {
            if (get(key) == "0")
            {
                return false;
            }
            return true;
        }
    }
}