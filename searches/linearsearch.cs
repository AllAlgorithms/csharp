using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class LS
{
    public class LinearSearch
    {
        private readonly List<int> _list;
        public LinearSearch(List<int> list)
        {
            this._list = list;
        }

        public int Search(int itemToFind)
        {
            for (int i = 0; i < _list.Count(); i++)
            {
                int currentValue = _list.ElementAt(i);
                if (currentValue == itemToFind)
                {
                    return i;
                }
            }
            return -1;
        }
    }
    static void Main(string[] args)
    {
        var items = new List<int>() { 12, 8, 4, 30, 6, 88 };
        LinearSearch jsearch = new LinearSearch(items);

        var itemToFind = 4;
        int index = jsearch.Search(itemToFind);
        Console.WriteLine((index >= 0) ? $"Item {itemToFind} found at position {index}" : $"Item {itemToFind} not found");

        itemToFind = 13;
        index = jsearch.Search(itemToFind);
        Console.WriteLine((index > 0) ? $"Item {itemToFind} found at position {index}" : $"Item {itemToFind} not found");

        itemToFind = 30;
        index = jsearch.Search(itemToFind);
        Console.WriteLine((index > 0) ? $"Item {itemToFind} found at position {index}" : $"Item {itemToFind} not found");

        Console.ReadLine();
    }
}