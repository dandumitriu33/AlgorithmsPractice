﻿using System;
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

        // Time Complexity - Average = O(log(N)) random tree; Worst Case = O(N) for one branch tree
        // recursive is Space Complexity O(log(N)) for average and O(N) for one branch because it opens frames on the stack for each check
        // iterative is Space Complexity O(1) because it doesn't stack frames on the stack like the recursive solution
        public int FindClosestRecursive(int target)
        {
            return FindClosestValueInBstHelper(root, target, 0);
        }
        private int FindClosestValueInBstHelper(NodeBST rootNode, int target, int closest)
        {
            if (rootNode == null)
            {
                return closest;
            }
            if (Math.Abs(target - closest) > Math.Abs(target - rootNode.Value))
            {
                closest = rootNode.Value;
            }
            if (target < rootNode.Value)
            {
                return FindClosestValueInBstHelper(rootNode.Left, target, closest);
            }
            else if (target > rootNode.Value)
            {
                return FindClosestValueInBstHelper(rootNode.Right, target, closest);
            }
            else
            {
                return closest;
            }
        }

        // iterative implementation
        public int FindClosestIterative(int target)
        {
            return FindClosestValueInBstHelperIterative(root, target, 0);
        }

        private int FindClosestValueInBstHelperIterative(NodeBST root, int target, int closest)
        {
            NodeBST currentNode = root;
            while (currentNode != null)
            {
                if (Math.Abs(target - closest) > Math.Abs(target - currentNode.Value))
                {
                    closest = currentNode.Value;
                }
                if (target < currentNode.Value)
                {
                    currentNode = currentNode.Left;
                }
                else if (target > currentNode.Value)
                {
                    currentNode = currentNode.Right;
                }
                else
                {
                    break;
                }
            }
            return closest;
        }
    }
}
