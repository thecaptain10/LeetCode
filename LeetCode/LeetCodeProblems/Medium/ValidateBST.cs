using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    public class ValidateBST
    {
        public bool IsValidBST(TreeNode root)
        {
            return Validate(root, double.NegativeInfinity, double.PositiveInfinity);
        }
        private bool Validate(TreeNode root, double minValue, double maxValue)
        {
            if (root == null)
            {
                return true;
            }
            if (root.val >= maxValue || root.val <= minValue)
            {
                return false;
            }
            bool isLeftTreeValid = Validate(root.left, minValue, root.val);
            bool isRightTreeValid = Validate(root.right, root.val, maxValue);
            return isLeftTreeValid && isRightTreeValid;
        }
    }
}
