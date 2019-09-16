using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/generate-parentheses/
    //Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses. 
    class GenerateParenthesesWithNPairs
    {
        public IList<string> GenerateParenthesis(int n)
        {
            var result = new List<string>();
            DFS(n, n, new List<char>(), result);
            return result;
        }

        private void DFS(int leftCount, int rightCount, IList<char> oneResult, IList<string> result)
        {
            if (leftCount == 0 && rightCount == 0)
            {
                result.Add(new string(oneResult.ToArray()));
            }
            else
            {
                if (leftCount > 0)
                {
                    oneResult.Add('(');
                    DFS(leftCount - 1, rightCount, oneResult, result);
                    oneResult.RemoveAt(oneResult.Count - 1);
                }

                if (rightCount > 0 && leftCount < rightCount)
                {
                    oneResult.Add(')');
                    DFS(leftCount, rightCount - 1, oneResult, result);
                    oneResult.RemoveAt(oneResult.Count - 1);
                }
            }
        }
    }
}
