using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/letter-combinations-of-a-phone-number/
    //Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent.
    public class LetterCombinationsOfPhoneNumber
    {
        public IList<string> LetterCombinations(string digits)
        {
            if (digits == "") return new List<string>();

            var numberAndLetters = InitNumberAndLetters();

            var result = new List<string>();
            DFS(digits, 0, numberAndLetters, new char[digits.Length], result);

            return result;
        }

        private void DFS(string digits, int curIndex, Dictionary<char, string> numberAndLetters, char[] oneResult, IList<string> result)
        {
            if (curIndex == digits.Length)
            {
                result.Add(new String(oneResult));
            }
            else
            {
                var letters = numberAndLetters[digits[curIndex]];

                for (int i = 0; i < letters.Length; i++)
                {
                    oneResult[curIndex] = letters[i];
                    DFS(digits, curIndex + 1, numberAndLetters, oneResult, result);
                }
            }
        }

        private Dictionary<char, string> InitNumberAndLetters()
        {
            var numberAndLetters = new Dictionary<char, string>
            {
                { '2', "abc" },
                { '3', "def" },
                { '4', "ghi" },
                { '5', "jkl" },
                { '6', "mno" },
                { '7', "pqrs" },
                { '8', "tuv" },
                { '9', "wxyz" }
            };
            return numberAndLetters;
        }


    }
}
