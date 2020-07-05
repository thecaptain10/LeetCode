using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    
// Definition for a Node.
    public class GraphNode {
        public int val;
        public IList<GraphNode> neighbors;
    
        public GraphNode() {
            val = 0;
            neighbors = new List<GraphNode>();
        }

        public GraphNode(int _val) {
            val = _val;
            neighbors = new List<GraphNode>();
        }
    
        public GraphNode(int _val, List<GraphNode> _neighbors) {
            val = _val;
            neighbors = _neighbors;
        }
    }

    public class GraphClone
    {
        public GraphNode CloneGraph(GraphNode node)
        {
            if (node == null)
                return null;

            Dictionary<GraphNode, GraphNode> dict = new Dictionary<GraphNode, GraphNode>();
            HashSet<int> visited = new HashSet<int>();
            Queue<GraphNode> queue = new Queue<GraphNode>();

            queue.Enqueue(node);
            visited.Add(node.val);

            while(queue.Any())
            {
                var cur = queue.Dequeue();

                if (!dict.ContainsKey(cur))
                    dict[cur] = new GraphNode(cur.val);

                foreach(GraphNode item in cur.neighbors)
                {
                    if (!visited.Contains(item.val))
                    {
                        queue.Enqueue(item);
                        visited.Add(item.val);
                    }
                }

            }

            foreach(var key in dict.Keys)
            {
                foreach (var neighbor in key.neighbors)
                    dict[key].neighbors.Add(dict[neighbor]);
            }

            return dict[node];

        }



    }
}
