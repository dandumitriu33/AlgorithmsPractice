using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPractice.October2020
{
    public class BinarySearchTree
    {
        public NodeBST root { get; set; }

        public BinarySearchTree()
        {
            root = null;
        }

        // method that calls the recursive method InsertRec
        public void Insert(int item)
        {
            root = InsertRec(root, item);
        }

        // recursive method to insert new items in the BST
        private NodeBST InsertRec(NodeBST root, int item)
        {
            // if the tree is empty, return a new node
            if (root == null)
            {
                root = new NodeBST(item);
                return root;
            }

            // otherwise, recur down the tree
            if (item < root.Value)
            {
                root.Left = InsertRec(root.Left, item);
            }
            else if (item > root.Value)
            {
                root.Right = InsertRec(root.Right, item);
            }

            // return the unchanged node pointer
            return root;
        }

        // method that calls the InorderRec
        public void InOrder()
        {
            InOrderRec(root);
        }

        private void InOrderRec(NodeBST root)
        {
            if (root != null)
            {
                InOrderRec(root.Left);
                Console.WriteLine(root.Value);
                InOrderRec(root.Right);
            }
        }

        // search
        public NodeBST Search(NodeBST rootNode, int item)
        {
            if (rootNode == null || rootNode.Value == item)
            {
                return rootNode;
            }
            if (root.Value > item)
            {
                return Search(root.Left, item);
            }
            return Search(root.Right, item);
        }
    }
}
