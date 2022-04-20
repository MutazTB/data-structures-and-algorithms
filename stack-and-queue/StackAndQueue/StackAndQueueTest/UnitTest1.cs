using System;
using Xunit;
using StackAndQueue;
using System.Collections.Generic;

namespace StackAndQueueTest
{
    public class UnitTest1
    {
        [Fact]
        public void StackPush()
        {
            StackAndQueue.Stack<int> stack = new StackAndQueue.Stack<int>();
            stack.Push(1);
            Assert.Equal(1, stack.Top.Value);
        }
        [Fact]
        public void StackPushMultiple()
        {
            StackAndQueue.Stack<int> stack = new StackAndQueue.Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            Assert.Equal(4, stack.Top.Value);
        }
        [Fact]
        public void StackPop()
        {
            StackAndQueue.Stack<int> stack = new StackAndQueue.Stack<int>();
            stack.Push(1);

            Assert.Equal(1, stack.Pop().Value);
        }
        [Fact]
        public void StackEmpty()
        {
            StackAndQueue.Stack<int> stack = new StackAndQueue.Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Pop();
            stack.Pop();
            stack.Pop();
            Assert.True(stack.IsEmpty());
        }
        [Fact]
        public void StackPeek()
        {
            StackAndQueue.Stack<int> stack = new StackAndQueue.Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Pop();

            Assert.Equal(1, stack.Peek());
        }
        [Fact]
        public void StackInstantiat()
        {
            StackAndQueue.Stack<int> stack = new StackAndQueue.Stack<int>();

            Assert.True(stack.IsEmpty());
        }
        //Queue tests
        [Fact]
        public void QueueEnQueue()
        {
            StackAndQueue.Queue<int> queue = new StackAndQueue.Queue<int>();
            queue.Enqueue(3);
            queue.Enqueue(10);

            Assert.Equal(3, queue.Peek());
        }

        [Fact]
        public void QueueEnqueueMultiple()
        {
            StackAndQueue.Queue<int> queue = new StackAndQueue.Queue<int>();
            queue.Enqueue(3);
            queue.Enqueue(10);
            queue.Enqueue(11);
            queue.Enqueue(20);
            queue.Dequeue();
            Assert.Equal(10, queue.Peek());
        }
        [Fact]
        public void QueueDequeue()
        {
            StackAndQueue.Queue<int> queue = new StackAndQueue.Queue<int>();
            queue.Enqueue(3);
            queue.Enqueue(10);
            queue.Enqueue(11);
            queue.Enqueue(20);
            //queue.Dequeue();
            Assert.Equal(3, queue.Dequeue().Value);
        }

        [Fact]
        public void QueuePeek()
        {
            StackAndQueue.Queue<int> queue = new StackAndQueue.Queue<int>();
            queue.Enqueue(50);
            Assert.Equal(50, queue.Peek());
        }
        [Fact]
        public void QueueDequeueMultiple()
        {
            StackAndQueue.Queue<int> queue = new StackAndQueue.Queue<int>();
            queue.Enqueue(3);
            queue.Enqueue(10);
            queue.Enqueue(11);
            queue.Enqueue(20);
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            Assert.True(queue.IsEmpty());
        }
        [Fact]
        public void QueueInstantiat()
        {
            StackAndQueue.Queue<int> queue = new StackAndQueue.Queue<int>();
            Assert.True(queue.IsEmpty());
        }

        [Fact]
        public void PseudoQueueTest()
        {
            PseudoQueue<int> pseudoQueue = new PseudoQueue<int>();

            pseudoQueue.Enqueue(20);
            pseudoQueue.Enqueue(15);
            pseudoQueue.Enqueue(10);
            pseudoQueue.Enqueue(5);
            Assert.Equal(20, pseudoQueue.Dequeue().Value);

        }

        [Fact]
        public void AnimalShelterTestEnqueue()
        {
            AnimalShelter<string> animalShelter = new AnimalShelter<string>();
            animalShelter.Enqueue("cat");
            animalShelter.Enqueue("DOG");
            animalShelter.Enqueue("Dog");

            string pref = animalShelter.Peek("cat");

            Assert.Equal("cat", pref);
        }

        [Fact]
        public void AnimalShelterTestDequeue()
        {
            AnimalShelter<string> animalShelter = new AnimalShelter<string>();
            animalShelter.Enqueue("cat");
            animalShelter.Enqueue("DOG");
            animalShelter.Enqueue("Dog");
            string pref = animalShelter.Dequeue("dog").Value;

            Assert.Equal("DOG", pref);
        }

        [Theory]
        [InlineData("()[[Extra Characters]]", true)]
        [InlineData("(){}[[]]", true)]
        [InlineData("{}{Code}[Fellows](())", true)]
        [InlineData("[({}]", false)]
        [InlineData("(](", false)]
        public void TestToCheckBalancedBrackets(string input, bool expected)
        {
            //Assert
            Brackets<string> brackets = new Brackets<string>();
            Assert.Equal(expected, brackets.MultiBracketValidation(input));
        }

    }
}
