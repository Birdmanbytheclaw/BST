using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTree
{
    public class TreeOfBinary
    {
        private node root;
        private int count;

        public TreeOfBinary()
        {
            root = null;
            count = 0;
        }
        public bool IsItEmpty()
        {
            return root == null;
        }
        public void insertData(int d)
        {
            if (IsItEmpty())
            {
                root = new node(d);
            }
            else 
            {
                root.insertData(ref root, d);
            }
            count++;
        }
        public bool Search(int s)
        {
            return root.Search(root, s);
        }
        public bool IsItALeaf()
        {
            if (!IsItEmpty())
                return root.IsItALeaf(ref root);

            return true;
        }
        public bool display()
        {
            if (!IsItEmpty())
                root.display(root);
        }
        public int count()
        {
            return count;
        }
    }
}
