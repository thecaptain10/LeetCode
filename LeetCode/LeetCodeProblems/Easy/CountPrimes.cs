using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/count-primes/
    //Count the number of prime numbers less than a non-negative number, n.
    public class CountPrimes
    {
        public int CountPrime(int n)
        {
            if (n < 2)
            {
                return 0;
            }
            var visited = new bool[n];
            for (int i = 2; i <= (int)Math.Sqrt(n); i++)
            {
                if (visited[i])
                    continue;

                for (var j = i * i; j < n; j += i)
                {
                    visited[j] = true;
                }
            }

            int count = 0;
            for (int i = 2; i < visited.Length; i++)
            {
                //unvisited are the primes
                if (!visited[i])
                {
                    count++;
                }
            }
            return count;
        }
    }
}
