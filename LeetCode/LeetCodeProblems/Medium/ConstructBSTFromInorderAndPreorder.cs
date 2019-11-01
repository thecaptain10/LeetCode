using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    public class ConstructBSTFromInorderAndPreorder
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            int n = preorder.Length;

            if (n == 0)
                return null;
                       
            return BuildTreeRec(preorder, 0, n - 1, inorder, 0, n - 1);
        }

        private TreeNode BuildTreeRec(int[] preorder, int preLeft, int preRight, int[] inorder, int inLeft, int inRight)
        {
            if (preLeft > preRight) return null;

            var rootValue = preorder[preLeft];
            var rootInIndex = -1;

            for (int i = inLeft; i <= inRight; i++)
            {
                if (inorder[i] == rootValue)
                {
                    rootInIndex = i;
                    break;
                }
            }

            var count = rootInIndex - inLeft;

            var root = new TreeNode(rootValue);

            root.left = BuildTreeRec(preorder, preLeft + 1, preLeft + count, inorder, inLeft, rootInIndex - 1);
            root.right = BuildTreeRec(preorder, preLeft + count + 1, preRight, inorder, rootInIndex + 1, inRight);

            return root;

        }
    }
    
}
