using System;
using System.Collections.Generic;

namespace ShortestPathLength
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int shortestPathLength(Node start, Node end)
        {
            //create a variable to count steps
            int distance = 0;

            //make a scratch pad to keep track of which nodes have been visited and their respective values
            Dictionary<Node, int> scratch = new Dictionary<Node, int>();

            //make a queue to employ breadth-first-traversal
            Queue<Node> queue = new Queue<Node>();

            // Start at the start
            queue.Enqueue(start);
            scratch.Add(start, distance);

            // Create a set of nodes S that are reachable from start
            while (queue.Count != 0)
            {
                distance += 1;
                
                Node n = queue.Dequeue();

                foreach (Node nei in n.neighbors)
                {
                    if (!scratch.ContainsKey(nei))
                    {
                        queue.Enqueue(nei);
                        scratch.Add(nei, distance);
                        
                        // check to see if End.id is in the subset of neighbors
                        if(nei.id == end.id)
                        {
                            int totalDistance = 0;
                            totalDistance = scratch[nei];             
                            return totalDistance;
                        }
                    }
                }

            }

            //return -1 if not found
            return -1;

        }

    }
}
