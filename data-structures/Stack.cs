/* Stack (Abstract Data Type) C# - Created by: Ehsan Mohammadi
   
    The order in which elements come off a stack gives rise to its alternative name, LIFO (last in, first out).
    Stack has two principal operations:
     1- push, which adds an element to the collection.
     2- pop, which removes the most recently added element that was not yet removed.
 */

using System;

namespace Stack
{
    class Stack<T>
    {
        T[] items;
        int top = 0;

        public Stack(int size)
        {
            items = new T[size];
        }

        public void Push(T value)
        {
            lock (this)
            {
                if (top < items.Length)
                    items[top++] = value;
                else
                    throw new System.ArgumentException("Stack is full!");
            }
        }

        public T Pop()
        {
            lock (this)
            {
                if (top > 0)
                {
                    return items[top--];
                }
                else
                    throw new System.ArgumentException("Stack is empty!");
            }
        }

        public void Clear()
        {
            top = 0;
        }
    }

    class TestStack
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>(10);
            stack.Push("Ehsan");
            stack.Push("Mohammadi");
            stack.Pop();
            stack.Clear();
        }
    }
}
