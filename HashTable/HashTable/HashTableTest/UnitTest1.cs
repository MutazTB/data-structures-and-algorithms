using Hashtables;
using System;
using Xunit;

namespace HashTableTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Test to check that node can be added to hash table
        /// </summary>
        [Fact]
        public void CanAddNodeIntoHashTable()
        {
            //Arrange
            Node n1 = new Node("Real Madrid", "14");
            Node n2 = new Node("AcMilan", "7");
            Node n3 = new Node("FC Bayern München", "6");
            Node n4 = new Node("Liverpool FC", "6");
            Node n5 = new Node("Barcelona", "5");

            Hashtable hashtable = new Hashtable(5);

            hashtable.set(n1.Key, n1.Value);
            hashtable.set(n2.Key, n2.Value);
            hashtable.set(n3.Key, n3.Value);
            hashtable.set(n4.Key, n4.Value);
            hashtable.set(n5.Key, n5.Value);

            //Assert
            Assert.Equal("14", hashtable.get("Real Madrid"));
        }

        /// <summary>
        /// Test to check that hash table contains a node
        /// </summary>
        [Fact]
        public void CanUseContainToFindNodeInHashTable()
        {
            //Arrange
            Node n1 = new Node("Real Madrid", "14");
            Node n2 = new Node("AcMilan", "7");
            Node n3 = new Node("FC Bayern München", "6");
            Node n4 = new Node("Liverpool FC", "6");
            Node n5 = new Node("Barcelona", "5");

            Hashtable hashtable = new Hashtable(5);

            hashtable.set(n1.Key, n1.Value);
            hashtable.set(n2.Key, n2.Value);
            hashtable.set(n3.Key, n3.Value);
            hashtable.set(n4.Key, n4.Value);
            hashtable.set(n5.Key, n5.Value);

            //Assert
            Assert.True(hashtable.Contains("AcMilan"));
        }

        /// <summary>
        /// Test to check that hash table can handle collisions
        /// </summary>
        [Theory]
        [InlineData("Inter", "0", "AcMilan", "7")]
        [InlineData("Barcelona", "0", "Liverbool", "5")]
        public void CanAddWithCollisionItonHashTable(string key1, string val1, string key2, string val2)
        {
            //Arrange
            Node n1 = new Node("Real Madrid", "14");
            Node n2 = new Node("FC Bayern München", "6");
            Node n3 = new Node(key1, val1);           
            Node n4 = new Node(key2, val2);

            Hashtable hashtable = new Hashtable(5);

            hashtable.set(n1.Key, n1.Value);
            hashtable.set(n2.Key, n2.Value);
            hashtable.set(n3.Key, n3.Value);
            hashtable.set(n4.Key, n4.Value);
            

            //Assert
            Assert.Equal(val2, hashtable.get(key2));
        }
    }
}
