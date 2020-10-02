using System;
using System.Collections.Generic;

/// <summary>
///     Generic stack (Last In First Out) implementation using an array.
/// </summary>
/// <typeparam name="T">Item type.</typeparam>
class Stack<T>
{
    private T[] _array;
    public int _size;
    public int _top;

    /// <summary>
    ///     Initialize the stack.
    /// </summary>
    public Stack()
    {
        _size = 10;
        _top = -1;
        _array = new T[_size];
    }

    /// <summary>
    ///     Push an item to the stack.
    /// </summary>
    /// <param name="item">Item to be pushed.</param>
    public void Push(T item)
    {
        if (_top == _size - 1)
        {
            // Array top capacity reached. resizing array
            _size = _size * 2;
            T[] newArray = new T[_size];
            Array.Copy(_array, 0, newArray, 0, _array.Length);
            _array = newArray;
        }
        _top++;
        _array[_top] = item;
    }

    /// <summary>
    ///     Pop last item from the stack. Pop removes the popped item from the stack.
    /// </summary>
    /// <returns>Popped item.</returns>
    public T Pop()
    {
        return PopOrPeek(true);
    }

    /// <summary>
    ///     Peek last item from the stack. Peek won't remove the item from the stack.
    /// </summary>
    /// <returns>Peeked item.</returns>
    public T Peek()
    {
        return PopOrPeek(false);
    }

    private T PopOrPeek(bool pop)
    {
        if (_top == -1)
            throw new InvalidOperationException("Stack is empty.");
        T item = _array[_top];

        if (pop)
        {
            _array[_top] = default(T);
            _top--;
        }
        return item;
    }

    /// <summary>
    ///     Returns the content of the stack as string.
    /// </summary>
    /// <returns>Content of the stack as string.</returns>
    public override string ToString()
    {
        var result = string.Empty;
        for (int i = 0; i<= _top; i++)
        {
            result += _array[i].ToString() + " ";
        }
        return result.Trim();
    }

    /// <summary>
    ///     Clear all items from the stack.
    /// </summary>
    public void Clear()
    {
        Array.Clear(_array, 0, _size);
        _top = -1;
    }
}

class StackTest
{
    public static void Main()
    {
        var stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        Console.WriteLine("Popped: {0}", stack.Pop());
        stack.Push(4);
        stack.Push(5);
        Console.WriteLine("Peeked: {0}", stack.Peek());
        stack.Push(6);
        stack.Push(7);
        Console.WriteLine("Peeked: {0}", stack.Peek());
        stack.Push(8);
        stack.Push(9);
        stack.Push(10);
        Console.WriteLine("Popped: {0}", stack.Pop());
        Console.WriteLine("Popped: {0}", stack.Pop());
        Console.WriteLine("Stack contents: {0}", stack.ToString());
    }
}