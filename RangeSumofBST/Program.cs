using System;
using static RangeSumofBST.Program.BST;

namespace RangeSumofBST
{
    class Program
    {
        public static int sum = 0;
        public static Node root;
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            BST bST = new BST();
            bST.Add(10);
            bST.Add(5);
            bST.Add(15);
            bST.Add(3);
            bST.Add(7);
            bST.Add(18);
            bST.RangeSumBST(root, 7, 15);
            Console.WriteLine(sum);
            Console.ReadLine();
        }
        public class BST
        {
            public class Node
            {
                public int key;
                public Node left;
                public Node right;

                public Node()
                {
                }

                public Node(int item)
                {
                    key = item;
                    left = null;
                    right = null;
                }


            }

            public BST()
            {
                root = null;
            }
            public Node Add(int item)
            {
                root = InsertItem(root, item);
                return root;
            }
            public Node InsertItem(Node root, int item)
            {
                if (root == null)
                {
                    root = new Node(item);
                    return root;
                }
                else
                {
                    if (item < root.key)
                    {
                        root.left = InsertItem(root.left, item);
                    }
                    if (item >= root.key)
                    {
                        root.right = InsertItem(root.right, item);
                    }
                }
                return root;
            }
            public int RangeSumBST(Node root, int L, int R)
            {
                if(root == null)
                {
                    return 0;
                }
                if(root.key >= L && root.key<=R)
                {
                    sum += root.key;
                    
                }
                RangeSumBST(root.left, L, R);
                RangeSumBST(root.right, L, R);
                return sum;
            }
        }
    }
}
