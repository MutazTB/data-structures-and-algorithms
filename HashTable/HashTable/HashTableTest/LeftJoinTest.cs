using HashTable;
using Hashtables;
using System;
using System.Collections.Generic;
using Xunit;

namespace HashTableTest
{
    public class LeftJoinTest
    {
        [Fact]
        public void BasicLeftJoinWorksTest()
        {
            // Arrange
            Hashtable h1 = new Hashtable();
            h1.set("fond", "enamoured");
            h1.set("wrath", "anger");
            h1.set("diligent", "employed");
            h1.set("outfit", "garb");
            h1.set("guide", "usher");

            Hashtable h2 = new Hashtable();
            h2.set("fond", "averse");
            h2.set("wrath", "delight");
            h2.set("diligent", "idle");
            h2.set("guide", "follow");
            h2.set("flow", "jam");

            // Act
            List<string[]> leftJoin = Program.LeftJoin(h1, h2);
            List<string[]> expected = new List<string[]>()
            {
                new string[] { "fond", "enamoured", "averse" },
                new string[] { "guide", "usher", "follow" },
                new string[] { "wrath", "anger", "delight" },
                new string[] { "outfit", "garb", "NULL" },
                new string[] { "diligent", "employed", "idle" },
            };

            // Assert
            Assert.Equal(expected, leftJoin);
        }
        [Fact]
        public void NullTablesTestTest()
        {
            // Arrange
            Hashtable h1 = new Hashtable();

            Hashtable h2 = new Hashtable();

            // Act
            List<string[]> leftJoin = Program.LeftJoin(h1, h2);

            // Assert
            Assert.Empty(leftJoin);
        }
        [Fact]
        public void OnlyOneTableHasValuesTest()
        {
            // Arrange
            Hashtable h1 = new Hashtable();
            h1.set("fond", "enamoured");
            h1.set("wrath", "anger");
            h1.set("diligent", "employed");
            h1.set("outfit", "garb");
            h1.set("guide", "usher");

            Hashtable h2 = new Hashtable();

            // Act
            List<string[]> leftJoin = Program.LeftJoin(h1, h2);
            List<string[]> expected = new List<string[]>()
            {
                new string[] { "fond", "enamoured", "NULL" },
                new string[] { "guide", "usher", "NULL" },
                new string[] { "wrath", "anger", "NULL" },
                new string[] { "outfit", "garb", "NULL" },
                new string[] { "diligent", "employed", "NULL" },
            };

            // Assert
            Assert.Equal(expected, leftJoin);
        }

    }
}
