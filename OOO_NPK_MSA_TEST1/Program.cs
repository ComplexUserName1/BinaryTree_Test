using System;
using System.Collections.Generic;

namespace OOO_NPK_MSA_TEST1
{
    interface INode
    {
        INode Left { get; }
        INode Right { get; }
        int Value { get; }
    }

    class СNode : INode
    {
        public int Value { get; set; }
        public INode Left { get; set; }
        public INode Right { get; set; }
    }

    class Tree
    {
        public СNode insert(СNode root, int v)
        {
            if (root == null)
            {
                root = new СNode();
                root.Value = v;
            }
            else if (v < root.Value)
            {
                root.Left = insert((СNode)root.Left, v);
            }
            else
            {
                root.Right = insert((СNode)root.Right, v);
            }

            return root;
        }
        public void traverse(СNode root, int level, List<List<int>> tl)
        {
            if (root == null)
            {
                return;
            }

            if (tl.Count < level)
            {
                tl.Add(new List<int> { root.Value });
            }
            else
            {
                tl[level - 1].Add(root.Value);
            }

            traverse((СNode)root.Left, level+1, tl);
            traverse((СNode)root.Right, level+1, tl);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> tl = new List<List<int>>();
            СNode root = null;
            Tree bst = new Tree();
            int SIZE = 50;
            int level = 1;
            int[] a = new int[SIZE];

            Random random = new Random();

            for (int i = 0; i < SIZE; i++)
            {
                a[i] = random.Next(1000);
            }

            for (int i = 0; i < SIZE; i++)
            {
                root = bst.insert(root, a[i]);
            }

            bst.traverse(root, level, tl);

            for(int i = tl.Count-1; i >= 0; i--)
            {
                Console.WriteLine("Level " + (i+1) + ": " + string.Join(", ", tl[i]));
            }

            Console.ReadKey();
        }
    }
}
