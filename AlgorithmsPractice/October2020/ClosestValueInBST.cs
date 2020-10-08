using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPractice.October2020
{
    public class ClosestValueInBST
    {
        // Time Complexity - Average = O(log(N)) random tree; Worst Case = O(N) for one branch tree
        // recursive is Space Complexity O(log(N)) for average and O(N) for one branch because it opens frames on the stack for each check
        // iterative is Space Complexity O(1) becauseit doesn't stack frames on the stack like the recursive solution would 
        public int? FindClosestRecursive(NodeBST root, int target)
        {
            return FindClosestValueInBstHelper(root, target, 0);
        }
        public int? FindClosestValueInBstHelper(NodeBST root, int target, int closest)
        {
            if (root == null)
            {
                return closest;
            }
            if (Math.Abs(target - closest) > Math.Abs(target - root.Value))
            {
                closest = root.Value;
            }
            if (target < root.Value)
            {
                return FindClosestValueInBstHelper(root.Left, target, closest);
            }
            else if (target > root.Value)
            {
                return FindClosestValueInBstHelper(root.Right, target, closest);
            }
            else
            {
                return closest;
            }
        }
    }
}
