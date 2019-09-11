using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/reorder-data-in-log-files/
    //Reorder data in log files.
    public class ReorderDataInLogFiles
    {
        public string[] ReorderLogFiles(string[] logs)
        {

            List<string> letterLogs = new List<string>();
            List<string> digitLogs = new List<string>();

            foreach (var log in logs)
            {

                if (Char.IsDigit(log.Substring(log.IndexOf(" ")).Replace(" ", string.Empty)[0]))
                {
                    digitLogs.Add(log);
                }
                else
                {
                    letterLogs.Add(log);
                }
            }


            var letterLogsSorted = letterLogs.OrderBy(l => l.Substring(l.IndexOf(" "))).ThenBy(l => l.Split(' ')[0]).ToList();

            letterLogsSorted.AddRange(digitLogs.ToList());

            return letterLogsSorted.ToArray();

        }
    }
}
