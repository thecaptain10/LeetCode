using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/course-schedule/
    //There are a total of numCourses courses you have to take, labeled from 0 to numCourses-1.
    //Some courses may have prerequisites, for example to take course 0 you have to first take course 1, which is expressed as a pair: [0,1]
    //Given the total number of courses and a list of prerequisite pairs, is it possible for you to finish all courses?
    public class CourseSchedule
    {
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {

            //Topological Sort 
            if (prerequisites == null || prerequisites.Length == 0)
                return true;

            Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();

            //Store all the arrows directed towards it.
            int[] inDegree = new int[numCourses];

            Queue<int> queue = new Queue<int>();
            int count = 0;

            for (int i = 0; i < numCourses; i++)
                graph.Add(i,new List<int>());


            for (int i = 0; i < prerequisites.Length; i++)
            {
                graph[prerequisites[i][0]].Add(prerequisites[i][1]);
                inDegree[prerequisites[i][1]]++;
            }

            for(int i=0;i<numCourses;i++)
            {
                //Start with nodes having no prerequisite
                if (inDegree[i] == 0)
                    queue.Enqueue(i);
            }
          

            while(queue.Any())
            {
                int cur = queue.Dequeue();

                foreach(var node in graph[cur])
                {
                    //keep on decrementing prerequisites as they were already counted. if it becomes zero enqueue again.
                    if (--inDegree[node] == 0)
                        queue.Enqueue(node);
                }

                count++;

            }

            return count == numCourses;



        }
    }
}
