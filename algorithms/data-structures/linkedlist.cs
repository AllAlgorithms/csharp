using System;
using System.Collections.Generic;

/// <summary>
///     Generic linked list implementation.
/// </summary>
/// <typeparam name="T">Item type.</typeparam>
class LinkedList<T>
{
    private Node<T> _front;
    private Node<T> _end;

    /// <summary>
    ///     Initialize the linked list.
    /// </summary>
    public LinkedList()
    {
    }

    /// <summary>
    ///     Insert an item at the front of the list.
    /// </summary>
    /// <param name="item">Item to insert.</param>
    public void InsertAtFront(T item)
    {
        var node = Node<T>.Create(item);
        node.Next = _front;
        _front = node;
        if (_end == null)
            _end = _front;
    }

    /// <summary>
    ///     Insert an item at the end of the list.
    /// </summary>
    /// <param name="item">Item to insert.</param>
    public void InsertAtEnd(T item)
    {
        var node = Node<T>.Create(item);
        if (_end == null)
        {
            _front = node;
            _end = _front;
        }
        else
        {
            _end.Next = node;
            _end = node;
        }
    }

    /// <summary>
    ///     Search an item from the list.
    /// </summary>
    /// <param name="item">Item to search.</param>
    /// <returns>True if found, otherwise false.</returns>
    public bool Search(T item)
    {
        var found = false;
        var node = _front;
        while (node != null)
        {
            if (node.Data.Equals(item))
            {
                found = true;
                break;
            }
            node = node.Next;
        }
        return found;
    }

    /// <summary>
    ///     Returns the content of the list as string.
    /// </summary>
    /// <returns>Content of the list as string.</returns>
    public override string ToString()
    {
        var result = string.Empty;
        var node = _front;
        while (node != null)
        {
            result += node.Data.ToString() + " ";
            node = node.Next;
        }
        return result.Trim();
    }

    /// <summary>
    ///     Clears the list.
    /// </summary>
    public void Clear()
    {
        _front = null;
        _end = null;
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

class LinkedListTest
{
    public static void Main()
    {
        var list = new LinkedList<int>();
        list.InsertAtFront(3);
        list.InsertAtEnd(4);
        list.InsertAtEnd(5);
        list.InsertAtFront(2);
        list.InsertAtFront(1);
        Console.WriteLine("Searching for 2, found: {0}", list.Search(2));
        Console.WriteLine("Searching for 5, found: {0}", list.Search(5));
        Console.WriteLine("Searching for 10, found: {0}", list.Search(10));
        Console.WriteLine("Linked list content: {0}", list.ToString());
    }
}