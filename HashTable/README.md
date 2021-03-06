# Hash Tables

A Hash Table is essentially an array with a set length filled with key value pairs. The way in which these key value pairs are assigned an index is by using a hashing algorithm which assigns unique indexes based on the key passed into it. The index should be unique but consistent when given the same key.


## Challenge
Implement a Hashtable with:

1. set(key, value) - Function to set the key value pair in HashTable
2. get(string key) - Function to get value of a given key
3. Contains(string key) - Method to see if a node is located inside of hashtable
4. Hash(key) - Function to hash the key of an entry

## Examples of Use
1. Hold unique values
2. Dictionary
3. Library

## Approach & Efficiency
**Average case**
Search : O(1)<br>
Insert : O(1)<br>
Delete : O(1)<br>
**Worst case**
Search : O(n)<br>
Insert : O(n)<br>
Delete : O(n)<br>
