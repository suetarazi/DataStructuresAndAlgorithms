using System;
using System.Collections.Generic;

namespace BreadthFirstGraphTraversal
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        // Breadth First Search - Print IDs in breadth first order
        public static void visitAll(Node start)
        {
            //make a scratch pad to keep track of which nodes have been visited:
            List<Node> scratch = new List<Node>();

            //make a queue
            Queue<Node> queue = new Queue<Node>();

            queue.Enqueue(start); //{0,0}
            scratch.Add(start);
            Console.WriteLine(start.id);

            while (queue.Count != 0)
            {
                Node n = queue.Dequeue();


                foreach (Node node in n.neighbors)
                {
                    if (!scratch.Contains(node))
                    {
                        queue.Enqueue(node); //neighbors are 1 away from {0,0}
                        scratch.Add(node);
                        Console.WriteLine(node.id);
                    }
                }


            }
        }
    }
}
