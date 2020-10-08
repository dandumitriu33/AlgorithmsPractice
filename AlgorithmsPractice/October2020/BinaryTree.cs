using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPractice.October2020
{
    public class BinaryTree
    {
        public NodeBT Root { get; set; }

        // recursive insertion from list beginning with order i
        public NodeBT InsertLevelOrder(int[] arr, NodeBT root, int i)
        {
            // base case for recursion
            if (i < arr.Length)
            {
                NodeBT tempNode = new NodeBT(arr[i]);
                root = tempNode;
                // insert left child
                root.Left = InsertLevelOrder(arr, root.Left, 2 * i + 1);
                // insert right child
                root.Right = InsertLevelOrder(arr, root.Right, 2 * i + 2);
            }
            return root;
        }

        public void PrintInOrder(NodeBT rootNode)
        {
            if (rootNode != null)
            {
                PrintInOrder(rootNode.Left);
                Console.WriteLine(rootNode.Value);
                PrintInOrder(rootNode.Right);
            }
        }

        // Time Complexity = O(N) - worst case one branch tree
        // Space Complexity = O(N) - every recursion opens a stack frame
        public List<int> BranchSums(NodeBT rootNode)
        {
            List<int> sums = new List<int>();
            sums = calculateBranchSums(rootNode, 0, sums);
            return sums;
        }

        private List<int> calculateBranchSums(NodeBT node, int runningSum, List<int> sums)
        {
            if (node == null)
            {
                return sums;
            }
            int newRunningSum = runningSum + node.Value;
            if (node.Left == null && node.Right == null)
            {
                sums.Add(newRunningSum);
                return sums;
            }
            calculateBranchSums(node.Left, newRunningSum, sums);
            calculateBranchSums(node.Right, newRunningSum, sums);
            return sums;
        }
    }
}
