using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/check-completeness-of-a-binary-tree/
    //Check Completeness of a Binary Tree
    //Solution From : https://www.geeksforgeeks.org/check-if-a-given-binary-tree-is-complete-tree-or-not/
    public class IsCompleteBinaryTree
    {
        //do a level order traversal starting from the root. In the traversal, once a node is found which is NOT a Full Node, all the following nodes must be leaf nodes.Also, one more thing needs to be checked to handle the below case: If a node has an empty left child, then the right child must be empty.
        public bool IsCompleteTree(TreeNode root)
        {

            if (root == null)
                return true;

            Queue<TreeNode> queue = new Queue<TreeNode>();

            // Create a flag variable which will be set true 
            // when a non full node is seen 
            bool flag = false;
            
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                TreeNode temp_node = queue.Dequeue();

                /* Check if left child is present*/
                if (temp_node.left != null)
                {
                    // If we have seen a non full node, 
                    // and we see a node with non-empty 
                    // left child, then the given tree is not 
                    // a complete Binary Tree 
                    if (flag == true)
                        return false;

                    // Enqueue Left Child 
                    queue.Enqueue(temp_node.left);
                }

                // If this a non-full node, set the flag as true 
                else
                    flag = true;

                /* Check if right child is present*/
                if (temp_node.right != null)
                {
                    // If we have seen a non full node, 
                    // and we see a node with non-empty 
                    // right child, then the given tree  
                    // is not a complete Binary Tree 
                    if (flag == true)
                        return false;

                    // Enqueue Right Child 
                    queue.Enqueue(temp_node.right);

                }

                // If this a non-full node, 
                // set the flag as true 
                else
                    flag = true;
            }
            return true;


        }

    }
}
