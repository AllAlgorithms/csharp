using System;
using System.Collections.Generic;

/// <summary>
///     Generic queue (First In First Out) implementation using linked list.
/// </summary>
/// <typeparam name="T">Item type.</typeparam>
class Queue<T>
{
    private Node<T> _head;
    private Node<T> _tail;

    /// <summary>
    ///     Initialize the queue.
    /// </summary>
    public Queue()
    {
    }

    /// <summary>
    ///     Enqueue an item.
    /// </summary>
    /// <param name="item">Item to queue.</param>
    public void Enqueue(T item)
    {
        var node = Node<T>.Create(item);
        if (_head == null)
        {
            _head = node;
            _tail = node;
        }
        else
        {
            _tail.Next = node;
            _tail = node;
        }
    }

    /// <summary>
    ///     Dequeue an item.
    /// </summary>
    /// <returns>Dequeued item.</returns>
    public T Dequeue()
    {
       return DequeueOrPeek(true);
    }

    /// <summary>
    ///     Peek an item.
    /// </summary>
    /// <returns>Peeked item.</returns>
    public T Peek()
    {
        return DequeueOrPeek(false);
    }

    private T DequeueOrPeek(bool dequeue)
    {
        if (_head == null)
            throw new InvalidOperationException("Queue is empty.");
        var node = _head;

        if (dequeue)
        {
            _head = _head.Next;
            if (_head == null)
                _tail = null;
        }
        return node.Data;
    }

    /// <summary>
    ///     Returns the content of the queue as string.
    /// </summary>
    /// <returns>Content of the queue as string.</returns>
    public override string ToString()
    {
        var result = string.Empty;
        var node = _head;
        while (node != null)
        {
            result += node.Data.ToString() + " ";
            node = node.Next;
        }
        return result.Trim();
    }

    /// <summary>
    ///     Clears the queue.
    /// </summary>
    public void Clear()
    {
        _head = null;
        _tail = null;
    }
}

/// <summary>
///     Generic linked list's node.
/// </summary>
class Node<T>
{
    /// <summary>
    ///     Creates a new instance of node.
    /// </summary>
    /// <param name="data">Data instance.</param>
    private Node(T data)
    {
        Data = data;
    }

    /// <summary>
    ///     Gets the node data.
    /// </summary>
    public T Data { get; private set; }

    /// <summary>
    ///     Gets or sets the next node.
    /// </summary>
    public Node<T> Next { get; set; }

    /// <summary>
    ///     Creates a new instance of node.
    /// </summary>
    /// <param name="data">Data instance.</param>
    /// <returns>Node instance.</returns>
    public static Node<T> Create(T data)
    {
        return new Node<T>(data);
    }
}

class QueueTest
{
    public static void Main()
    {
        var queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        Console.WriteLine("Dequeued: {0}", queue.Dequeue());
        queue.Enqueue(4);
        queue.Enqueue(5);
        Console.WriteLine("Peeked: {0}", queue.Peek());
        queue.Enqueue(6);
        queue.Enqueue(7);
        Console.WriteLine("Peeked: {0}", queue.Peek());
        queue.Enqueue(8);
        queue.Enqueue(9);
        queue.Enqueue(10);
        Console.WriteLine("Dequeued: {0}", queue.Dequeue());
        Console.WriteLine("Dequeued: {0}", queue.Dequeue());
        Console.WriteLine("Queue contents: {0}", queue.ToString());
    }
}