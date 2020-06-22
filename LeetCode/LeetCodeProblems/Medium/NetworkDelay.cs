using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/network-delay-time/
    //There are N network nodes, labelled 1 to N.
    //Given times, a list of travel times as directed edges times[i] = (u, v, w), where u is the source node, v is the target node, and w is the time it takes for a signal to travel from source to target.
    //Now, we send a signal from a certain node K.How long will it take for all nodes to receive the signal? If it is impossible, return -1.
    public class NetworkDelay
    {
        public int NetworkDelayTime(int[][] times, int N, int K)
        {

            Dictionary<int, int> visited = new Dictionary<int, int>();
            Dictionary<int, List<(int, int)>> graph = new Dictionary<int, System.Collections.Generic.List<(int node, int time)>>();


            //Create Graph
            foreach (var t in times)
            {
                if (graph.ContainsKey(t[0]))
                    graph[t[0]].Add((t[1], t[2]));
                else
                    graph.Add(t[0], new List<(int node, int time)> { (t[1], t[2]) });
            }

            Queue<int> queue = new Queue<int>();

            queue.Enqueue(K);
            visited.Add(K, 0);

            //DO BFS and keep on checking network delay and update for each node.
            while (queue.Any())
            {
                int cur = queue.Dequeue();

                if (graph.ContainsKey(cur))
                {
                    foreach (var (neighbor, time) in graph[cur])
                    {
                        if (!visited.ContainsKey(neighbor) || visited[neighbor] > visited[cur] + time)
                        {
                            if (visited.ContainsKey(neighbor))
                                visited[neighbor] = visited[cur] + time;
                            else
                                visited.Add(neighbor, visited[cur] + time);

                            queue.Enqueue(neighbor);
                        }                        
                    }
                }
            }

            //Check if all  the nodes have been visited. If Yes, return max value for the node.
            if (visited.Count == N)
            {
                return visited.Max(v => v.Value);
            }
            else
            {
                return -1;
            }

        }

    }
}
