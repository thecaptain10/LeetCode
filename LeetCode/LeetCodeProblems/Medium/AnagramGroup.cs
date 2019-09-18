using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    class AnagramGroup
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> res = new List<IList<string>>();

            Dictionary<string, List<string>> stringAndGroupDict = new Dictionary<string, List<string>>();

            foreach(string s in strs)
            {
                string convertedString = ConvertString(s);

                if (!stringAndGroupDict.ContainsKey(convertedString))
                    stringAndGroupDict.Add(convertedString, new List<string>() { s });
                else
                    stringAndGroupDict[convertedString].Add(s);
            }
            
            foreach(string key in stringAndGroupDict.Keys)
            {
                res.Add(stringAndGroupDict[key]);
            }

            return res;

        }

        private string ConvertString(string s)
        {
            var charArray = s.ToCharArray();

            Array.Sort(charArray);

            return new string(charArray);

        }
    }
}
