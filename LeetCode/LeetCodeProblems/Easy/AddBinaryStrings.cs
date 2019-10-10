using System.Collections.Generic;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/add-binary/
    //Given two binary strings, return their sum (also a binary string).The input strings are both non-empty and contains only characters 1 or 0.
    public class AddBinaryStrings
    {
        public string AddBinary(string a, string b)
        {
            var result = new List<char>();

            var carry = 0;

            var aLen = a.Length;
            var bLen = b.Length;

            var aIndex = aLen - 1;
            var bIndex = bLen - 1;

            while (aIndex >= 0 || bIndex >= 0)
            {
                var numberA = aIndex >= 0 ? a[aIndex] - '0' : 0;
                var numberB = bIndex >= 0 ? b[bIndex] - '0' : 0;

                var oneResult = numberA + numberB + carry;
                carry = oneResult / 2;

                result.Add((char)(oneResult % 2 + '0'));

                aIndex--;
                bIndex--;
            }

            if (carry != 0)
            {
                result.Add((char)(carry + '0'));
            }

            result.Reverse();

            return new string(result.ToArray());
        }
    }
}
