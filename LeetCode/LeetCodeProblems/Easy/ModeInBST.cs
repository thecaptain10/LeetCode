using LeetCodeProblems.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/find-mode-in-binary-search-tree/
    //Find Mode in Binary Search Tree
    public class ModeInBST
    {
        List<int> inorder = new List<int>();
        public int[] FindMode(TreeNode root)
        {
            List<int> res = new List<int>();
            //Do Inorder Traversal 
            Inorder(root);

            Dictionary<int, int> dict = new Dictionary<int, int>();

            //Get dictionary for each element's occurence count
            for (int i = 0; i < inorder.Count; i++)
            {
                if (dict.ContainsKey(inorder[i]))
                    dict[inorder[i]] = dict[inorder[i]] + 1;
                else
                    dict.Add(inorder[i], 1);
            }

            int max = 0;

            //Get max occurence count for element
            foreach (var kvp in dict)
            {
                if (max < kvp.Value)
                    max = kvp.Value;
            }

            //add all elements with max occurence to result list.
            foreach (var kvp in dict)
            {
                if (max == kvp.Value)
                    res.Add(kvp.Key);
            }

            return res.ToArray();
        }

        public void Inorder(TreeNode root)
        {
            if (root == null)
                return;
            Inorder(root.left);
            inorder.Add(root.val);
            Inorder(root.right);
        }
    }
}
