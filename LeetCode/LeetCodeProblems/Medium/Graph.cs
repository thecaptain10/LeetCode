using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    public class Graph
    {
        int Vertices;
        List<int>[] neighbours;

        public Graph(int numOfVertices)
        {
            Vertices = numOfVertices;
            neighbours = new List<int>[Vertices];

            //Initialize list for each vertex.
            for (int i = 0; i < numOfVertices; i++)
                neighbours[i] = new List<int>();
         
        }

        public void AddEdge(int u, int v)
        {
            neighbours[u].Add(v);
        }
        

        public List<int> DFS(int v)
        {
            List<int> res = new List<int>();

            bool[] visited = new bool[Vertices];

            //This work only for connected graph and will not cover any disconnected nodes.
            DFSHelper(v, visited, res);

            //For disconnected graph, traverse for reach unvisited.
            for (int i = 0; i < Vertices; i++)
                if (!visited[i])
                    DFSHelper(i, visited, res);

            return res;
        }

        private void DFSHelper(int v, bool[] visited, List<int> res)
        {
            if (!visited[v])
            {
                visited[v] = true;
                res.Add(v);
            }

            List<int> vList = neighbours[v];

            foreach(int vertex in vList)
            {
                if (!(visited[vertex]))
                    DFSHelper(vertex, visited, res);
            }
            
        }

        public List<int> BFS(int v)
        {
            List<int> res = new List<int>();

            bool[] visited = new bool[Vertices];

            Queue<int> queue = new Queue<int>();
            
            queue.Enqueue(v);

            while(queue.Count != 0)
            {
                int s = queue.Peek();
                
                res.Add(s);
                visited[s] = true;

                queue.Dequeue();

                List<int> sList = neighbours[s];
                
                foreach(int i in sList)
                {
                    if (!visited[i])
                        queue.Enqueue(i);
                }            
            }
            
            return res;
        }
    }
}
