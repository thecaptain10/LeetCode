using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/delete-node-in-a-bst/
    //Given a root node reference of a BST and a key, delete the node with the given key in the BST. Return the root node reference (possibly updated) of the BST.
    public class DeleteNodeInBST
    {
        public TreeNode DeleteNode(TreeNode root, int key)
        {
            if (root == null)
                return root;

            // search the node which we want to delete 

            if (root.val < key)
                root.right = DeleteNode(root.right, key);
            else if (root.val > key)
                root.left = DeleteNode(root.left, key);
            else
            {

                // case 1: Leaf node			
                if (root.left == null && root.right == null)
                    return null;

                // case 2 : Only Right Child			
                else if (root.left == null) return root.right;

                // case 2: Only Left Child
                else if (root.right == null) return root.left;

                // case 3 : Having Both Children
                // copy the min val from right subtree to the node

                root.val = getMinValNode(root.right);

                // this case is now reduced to the case 1 or case 2
                root.right = DeleteNode(root.right, root.val);
            }
            return root;
        }

        public int getMinValNode(TreeNode root)
        {
            int min = root.val;
            while (root != null)
            {
                min = root.val;
                root = root.left;
            }
            return min;
        }
    }
}
