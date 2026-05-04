using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    internal class Program
    {
        class BinarySearchTreeNode<T> where T : IComparable<T>
        {
            public T Value { get; set; }
            public BinarySearchTreeNode<T> Left { get; set; }
            public BinarySearchTreeNode<T> Right { get; set; }
            public BinarySearchTreeNode(T value)
            {
                Value = value;
                Left = null;
                Right = null;
            }
        }

        class BinarySearchTree<T> where T : IComparable<T>
        {
            public BinarySearchTreeNode<T> Root { get; private set; }

            //define default constructor
            public BinarySearchTree()
            {
                Root = null;
            }

            public void Insert(T value)
            {
                Root = Insert(Root, value);
            }

            private BinarySearchTreeNode<T> Insert(BinarySearchTreeNode<T> node, T value)
            {
                //base case: if the node is null, create a new node with the value and return it
                if (node == null)
                {
                    return new BinarySearchTreeNode<T>(value);
                }
                else if(value.CompareTo(node.Value) < 0)//if the value is less than the node's value, insert it into the left subtree
                {
                    node.Left = Insert(node.Left, value);
                }
                else if(value.CompareTo(node.Value) > 0)//if the value is greater than the node's value, insert it into the right subtree
                {
                    node.Right = Insert(node.Right, value);
                }
                return node;
            }

            public void PrintTree()
            {
                PrintTree(Root, 0);
            }


            private void PrintTree(BinarySearchTreeNode<T> root, int space)
            {
                int COUNT = 10;  // Distance between levels
                if (root == null)
                    return;

                space += COUNT;
                PrintTree(root.Right, space);

                Console.WriteLine();
                for (int i = COUNT; i < space; i++)
                    Console.Write(" ");
                Console.WriteLine(root.Value);
                PrintTree(root.Left, space);
            }
        }
        static void Main(string[] args)
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Insert(45);
            bst.Insert(15);
            bst.Insert(79);
            bst.Insert(90);
            bst.Insert(10);
            bst.Insert(55);
            bst.Insert(12);
            bst.Insert(20);
            bst.Insert(50);

            bst.PrintTree();

        }
    }
}
