using System;
using System.Collections.Generic;

namespace Datastructures.Trees
{
    public class SegmentTree<T> where T : IComparable
    {
        private readonly Node _root;

        public SegmentTree(IReadOnlyList<T> list)
        {
            _root = list.Count > 0 ? Build(list, 0, list.Count - 1) : throw new ArgumentException();
        }

        public T MinQuery(int startIndex, int endIndex)
        {
            if (startIndex > endIndex || endIndex > _root.EndIndex)
            {
                throw new ArgumentException();
            }

            var (min, _) = MinQuery(_root, startIndex, endIndex);

            return min;
        }

        private (T value, bool infinity) MinQuery(Node node, int startIndex, int endIndex)
        {
            if (node.StartIndex >= startIndex && node.EndIndex <= endIndex)
            {
                return (node.Value, false);
            }

            if (startIndex > node.EndIndex || endIndex < node.StartIndex)
            {
                return (node.Value, true);
            }

            var leftMin = MinQuery(node.Left, startIndex, endIndex);
            var rightMin = MinQuery(node.Right, startIndex, endIndex);
            if (leftMin.infinity)
            {
                return rightMin;
            }

            if (rightMin.infinity)
            {
                return leftMin;
            }

            return (Min(leftMin.value, rightMin.value), false);
        }


        private Node Build(IReadOnlyList<T> s, int startIndex, int endIndex)
        {
            if (startIndex > endIndex)
            {
                return null;
            }

            var node = new Node
            {
                StartIndex = startIndex,
                EndIndex = endIndex
            };

            if (startIndex == endIndex)
            {
                node.Value = s[startIndex];
            }
            else
            {
                var midpoint = startIndex + (endIndex - startIndex) / 2;
                node.Left = Build(s, startIndex, midpoint);
                node.Right = Build(s, midpoint + 1, endIndex);
                if (node.Right == null)
                {
                    node.Value = node.Left.Value;
                }
                else
                {
                    node.Value = Min(node.Left.Value, node.Right.Value);
                }
            }

            return node;
        }

        private T Min(T a, T b) => a.CompareTo(b) < 0 ? a : b;

        private class Node
        {
            public Node Left { get; set; }
            public Node Right { get; set; }
            public T Value { get; set; }
            public int StartIndex { get; set; }
            public int EndIndex { get; set; }

            public override string ToString()
            {
                return $"[{StartIndex} - {EndIndex}]: {Value}";
            }
        }
    }
}