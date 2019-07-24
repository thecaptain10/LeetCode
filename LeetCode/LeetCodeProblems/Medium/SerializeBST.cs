using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/serialize-and-deserialize-bst/
    // Serialize and Deserialize BST
    public class Codec
    {

        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            if (root == null) return "";

            List<string> result = new List<string>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Any())
            {
                var size = queue.Count;

                for (int s = 0; s < size; s++)
                {
                    var cur = queue.Dequeue();

                    if (cur == null)
                    {
                        result.Add("n");
                    }
                    else
                    {
                        result.Add(cur.val.ToString());
                        queue.Enqueue(cur.left);
                        queue.Enqueue(cur.right);
                    }
                }
            }

            return string.Join(",", result);
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            if (data == "") return null;

            var nums = data.Split(',');
            int n = nums.Length;
            int i = 0;

            TreeNode root = new TreeNode(int.Parse(nums[0]));

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            i++;

            while (i < n)
            {
                int size = queue.Count;

                for (int s = 0; s < size; s++)
                {
                    var cur = queue.Dequeue();

                    if (nums[i] != "n")
                    {
                        cur.left = new TreeNode(int.Parse(nums[i]));
                        queue.Enqueue(cur.left);
                    }

                    i++;

                    if (nums[i] != "n")
                    {
                        cur.right = new TreeNode(int.Parse(nums[i]));
                        queue.Enqueue(cur.right);
                    }
                    i++;
                }
            }

            return root;
        }
    }

    // Your Codec object will be instantiated and called as such:
    // Codec codec = new Codec();
    // codec.deserialize(codec.serialize(root));
}
