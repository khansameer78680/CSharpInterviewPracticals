﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestConsole
{
    public class BinarySearchTree
    {
        public class Node
        {
            public int Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(int value, Node left, Node right)
            {
                Value = value;
                Left = left;
                Right = right;
            }
        }

        public static bool Contains(Node root, int value)
        {
            if (root == null)
            {
                return false;
            }
            else if (root.Value == value)
            {
                return true;
            }
            else if (root.Value > value)
            {
                return Contains(root.Left, value);
            }
            else if (root.Value < value)
            {
                return Contains(root.Right, value);
            }
            return false;
        }
    }
}
