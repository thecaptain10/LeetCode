using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    public class MinimumHeightTrees
    {
        public IList<int> FindMinHeightTrees(int n, int[][] edges)
        {
            IList<int> res = new List<int>();

            List<int>[] graph = new List<int>[n];

            for (int i = 0; i < n; i++)
                graph[i] = new List<int>();

            foreach (var edge in edges)
                graph[edge[0]].Add(edge[1]);



            bool[] visited = new bool[n];
            bool[] isLeaf = new bool[n];


            Queue<int> queue = new Queue<int>();
            queue.Enqueue(0);

            while (queue.Any())
            {
                int cur = queue.Dequeue();

                visited[cur] = true;

                bool parentOfLeafNodes = true;
                for(int i = 0; i < graph[cur].Count; i++)
                {
                    if (!visited[graph[cur][i]])
                        queue.Enqueue(graph[cur][i]);

                    if(graph[graph[cur][i]].Count != 0)
                    {
                        parentOfLeafNodes = false;
                        
                    }

                }
                isLeaf[cur] = parentOfLeafNodes;                
            }

            for(int i=0;i<n;i++)
            {
                if (isLeaf[i])
                    res.Add(i);
            }




            return res;

        }
    }
}
