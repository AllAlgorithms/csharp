using System;
using System.Collections.Generic;
using System.Linq;

public class JS
{
    public class JumpSearch
    {
        private readonly List<int> _items;
        public JumpSearch(List<int> items)
        {
            items.Sort();
            this._items = items;
        }

        public int Search(int itemToFind)
        {
            var listLength = _items.Count;

            var jumpStep = (int)Math.Floor(Math.Sqrt(listLength));

            var prevStep = 0;
            while (_items.ElementAt(Math.Min(jumpStep, listLength) - 1) < itemToFind)
            {
                prevStep = jumpStep;
                jumpStep += (int)Math.Floor(Math.Sqrt(listLength));
                if (prevStep >= listLength)
                    return -1;
            }

            while (_items.ElementAt(prevStep) < itemToFind)
            {
                prevStep++;
                if (prevStep == Math.Min(jumpStep, listLength))
                    return -1;
            }

            if (_items.ElementAt(prevStep) == itemToFind)
                return prevStep;

            return -1;
        }
    }

    public static void Main()
    {
        var items = new List<int>() { 12, 8, 4, 30, 6, 88 };
        JumpSearch jsearch = new JumpSearch(items);

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