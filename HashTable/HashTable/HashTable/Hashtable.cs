using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables
{
    public class Hashtable
    {
        public LList[] hashtable = new LList[100];

        /// <summary>
        /// returns integer used for index
        /// </summary>
        /// <param name="key"></param>
        /// <returns>index integer</returns>
        public int GetHash(string key)
        {
            byte[] ASCIIValues = Encoding.ASCII.GetBytes(key);
            int val = 0;
            foreach (byte b in ASCIIValues)
            {
                val += b;
            }

            val = val * 499;
            val = val % hashtable.Length;
            return val;
        }

        /// <summary>
        /// Adds node into hashtable using hashed key index
        /// </summary>
        /// <param name="newNode"></param>
        public void Add(Node newNode)
        {
            int index = GetHash(newNode.Key);
            if (hashtable[index] == null)
            {
                LList newList = new LList(newNode);
                hashtable[index] = newList;
            }
            else
            {
                hashtable[index].Append(newNode);
            }
            Console.WriteLine("Successfully Added");
        }

        /// <summary>
        /// Method that uses key to return value if it exists
        /// </summary>
        /// <param name="key">the key property of the node</param>
        /// <returns>the value property of the node</returns>
        public string Find(string key)
        {
            int index = GetHash(key);
            if (hashtable[index] == null)
            {
                return null;
            }
            else
            {
                Node current = hashtable[index].Current;

                while (current != null)
                {
                    if (current.Key == key)
                    {
                        return current.Value;
                    }
                    current = current.Next;
                }
                return null;
            }
        }

        /// <summary>
        /// Method to see if a node is located inside of hashtable
        /// </summary>
        /// <param name="key">kay property of a node</param>
        /// <returns>True if node exists inside of hashtable or false if it does not</returns>
        public bool Contains(string key)
        {
            if (Find(key) == null)
            {
                return false;
            }
            return true;
        }
    }
}