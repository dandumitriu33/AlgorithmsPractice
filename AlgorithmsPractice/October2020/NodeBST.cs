using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPractice.October2020
{
    public class NodeBST
    {
        public NodeBST Left { get; set; }
        public NodeBST Right { get; set; }
        public int Value { get; set; }
        public NodeBST(int item)
        {
            Left = null;
            Right = null;
            Value = item;
        }
    }
}
