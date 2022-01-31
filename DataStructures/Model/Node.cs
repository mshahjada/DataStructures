using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Model
{
    public class Node
    {
        public Node() { }
        public Node(int value)
        {
            this.Key = value;
            LeftNode = null;
            RightNode = null;
        }
        public int Key { get; set; }
        public Node? LeftNode { get; set; }
        public Node? RightNode { get; set; }
    }
}
