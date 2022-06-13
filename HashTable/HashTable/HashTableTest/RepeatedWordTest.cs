using HashTable;
using Hashtables;
using System;
using Xunit;

namespace HashTableTest
{
    public class RepeatedWordTest
    {
        [Theory]
        [InlineData("This is a sentence and is also a test", "is")]
        [InlineData("The quick red fox jumped over the lazy brown dog", "the")]
        [InlineData("This sentence has no repeated words", "No Repeated Words.")]
        public void TestToReturnVariousWordsIfAny(string value, string expected)
        {
            HashTableRepeatedWord hashTableRepeatedWord = new HashTableRepeatedWord();
            //Assert
            Assert.Equal(expected, hashTableRepeatedWord.RepeatedWord(value));

        }
    }
}
