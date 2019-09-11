using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/longest-substring-without-repeating-characters/
    //Given a string, find the length of the longest substring without repeating characters.
    //O(n)
    public class SubStringWithoutRepeatedChars
    {
        public int LengthOfLongestSubstring(string s)
        {

            if (String.IsNullOrEmpty(s))
                return 0;
            int maxLength = 1;
            int currLength = 1;
            int prevIndex;

            int[] visited = new int[256];

            for (int i = 0; i < visited.Length; i++)
                visited[i] = -1;


            //Visited Stors last index at which that character is present. 
            visited[s[0]] = 0;

            for (int i = 1; i < s.Length; i++)
            {
                prevIndex = visited[s[i]];

                //if char is not visited till now OR
                //It is not part of longest substring till now
                if (prevIndex == -1 || i - currLength > prevIndex)
                {
                    currLength = currLength + 1;
                }
                else
                {
                    // if char is present in current longest substring
                    if (currLength > maxLength)
                        maxLength = currLength;

                    //Reset current length
                    currLength = i - prevIndex;

                }
                visited[s[i]] = i;
            }

            if (currLength > maxLength)
                maxLength = currLength;

            return maxLength;
        }
    }
}
