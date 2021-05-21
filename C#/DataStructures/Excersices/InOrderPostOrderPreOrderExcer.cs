using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Excersices
{
    class InOrderPostOrderPreOrderExcer
    {
        internal static void Call()
        {
            MyTree myTree = new MyTree();

            myTree.Root = new TreeNode(1);

            myTree.Root.Left = new TreeNode(2);

            myTree.Root.Right = new TreeNode(3);


            myTree.Root.Left.Left = new TreeNode(4);

            myTree.Root.Left.Right = new TreeNode(5);

            //myTree.Root.Right.Left = new TreeNode(8);

            //myTree.Root.Right.Right = new TreeNode(11);



            var reuslt = GetInOrderArray(myTree);

            for (int i = 0; i < reuslt.Length; i++)
            {
                Console.WriteLine(reuslt[i]);
            }

            //Console.WriteLine(reuslt);
        }

        public class MyTree
        {
            public TreeNode Root { get; set; }
        }

        public  class TreeNode
        {
            public TreeNode(int data)
            {
                this.Data = data;
            }
            public int Data { get; set; }
            public TreeNode Left { get; set; }
            public TreeNode Right { get; set; }

        }

        static int[] GetInOrderArray(MyTree originalTree)
        {
            List<int> list = new List<int>();

           

            AddInOrder(originalTree.Root, ref list);

            return list.ToArray();
        }

        private static void AddInOrder(TreeNode node, ref List<int> list)
        {
            if (node == null)
            {
                return;
            }
            AddInOrder(node.Left, ref list);
            list.Add(node.Data);
            AddInOrder(node.Right, ref list);
        
            
        }

        private static void AddPreOrder(TreeNode node, ref List<int> list)
        {
            if (node == null)
            {
                return;
            }
            list.Add(node.Data);
            AddPreOrder(node.Left, ref list);
            AddPreOrder(node.Right, ref list);
        }

        private static void AddPostOrder(TreeNode node, ref List<int> list)
        {
            if (node == null)
            {
                return;
            }

            AddPostOrder(node.Left, ref list);
            AddPostOrder(node.Right, ref list);
            list.Add(node.Data);
        }


    }
}
