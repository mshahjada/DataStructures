using DataStructures.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Algorithms
{
    internal static class BinarySearchTree
    {
        public static Node InsertNode(Node root, int value)
        {
            if (root == null)
                return new Node(value);


            if (root.Key > value)
                root.LeftNode = InsertNode(root.LeftNode, value);
            else
                root.RightNode = InsertNode(root.RightNode, value);

            return root;


        }

        public static Node DeleteNode(Node root, int value)
        {
            if (root == null)
                return root;


            if (root.Key > value)
                root.LeftNode = DeleteNode(root.LeftNode, value);
            else if (root.Key < value)
                root.RightNode = DeleteNode(root.RightNode, value);

            else
            {
                if(root.LeftNode is null)
                    return root.RightNode;
                else if(root.RightNode is null)
                    return root.LeftNode;

                root.Key = GetSuccessorNode(root.RightNode);

                root.RightNode = DeleteNode(root.RightNode, root.Key);
            }
                

            return root;


        }

        private static int GetSuccessorNode(Node node)
        {
            int value = node.Key;

            while(node.LeftNode is not null)
            {
                node = node.LeftNode;
                value = node.Key;
            }
            return value;

        }

        public static void PreOrderTraverser(Node root)
        {
            if (root == null)
                return;
            Console.Write($"{root.Key}");
            PreOrderTraverser(root.LeftNode);
            PreOrderTraverser(root.RightNode);
        }

        public static Node GetTree()
        {
            return new Node() {
                Key = 8,
                LeftNode = new Node() 
                {
                    Key = 3,
                    LeftNode = new Node(1),
                    RightNode = new Node()
                    {
                        Key = 6,
                        LeftNode = new Node(4),
                        RightNode = new Node(7),
                    }
                },
                RightNode = new Node()
                {
                    Key = 10,
                    RightNode = new Node()
                    {
                        Key = 14,
                        LeftNode = new Node(13)
                    }
                }
            };
        }
    }

   
}
