using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTree
{
    class node
    {
        private int input;
        public node RightNode;
        public node LeftNode;

        public node(int value)
        {
            input = value;
            RightNode = null;
            LeftNode = null;
        }
        public bool IsItALeaf(ref node node)
        {
            return (node.LeftNode == null && node.RightNode == null);
        }
        public void insertData(ref node node, int Data)
        {

            if (node == null)
            {
                node = new node(Data);
            }
            else if (node.input < Data)
            {
                insertData(ref node.LeftNode, Data);
            }
            else if (node.input > Data)
            {
                insertData(ref node.RightNode, Data);
            }
        }
        public bool Search(node node, int s)
        {
            if (node == null)
            {
                return false;
                }
            if (node.input == s)
            {
                return true;
            }

            else if (node.input < s)
            {
                return Search(node.RightNode, s);
            }
            else if (node.input > s)
            {
                return Search(node.LeftNode, s);
            }
            return false;
        }
        public void display(node n)
        {
            if (n == null)
                return;
            display(n.LeftNode);
            Console.WriteLine(" " + n.input);
            display(n.RightNode);
        }


    }
}
     