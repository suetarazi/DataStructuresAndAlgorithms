using System;

namespace DoesTheLinkedListContainACycle
{
    public class LinkedListNode
    {
        public int Value { get; set; }

        public LinkedListNode Next { get; set; }

        //create a flag to mark each node that is visited
        public bool Flag { get; set; }
        public LinkedListNode(int value, bool flag)
        {
            Value = value;
            Flag = flag;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public bool ContainsCycle(LinkedListNode node)
        {
            if (node.Next == null)
            {
                return false;
            }

            //while(node.next != null), if flag == visited(i.e. true), return true; else go ahead and flag the node to visited and move on to the next node. If you get to the end of the linkedlist and none of the nodes have been marked visited, then return false.

            while (node != null)
            {
                if (node.Flag == true)
                {
                    return true;
                }
                else
                {
                    node.Flag = true;
                    node = node.Next;
                }
            }
            return false;
        }


        /// <summary>
        /// Provided solution in InterviewCake. BigO: O(n) for time and O(1) for space
        /// </summary>
        /// <param name="firstNode">node</param>
        /// <returns>true or false</returns>
        public static bool ContainsCycle2(LinkedListNode firstNode)
        {
            //use two runners, one fast and one slow. Both start at the beginning of the linkedlist.
            var slowRunner = firstNode;
            var fastRunner = firstNode;

            //go until we hit the end of the list
            while (fastRunner != null && fastRunner.Next != null)
            {
                slowRunner = slowRunner.Next;
                fastRunner = fastRunner.Next.Next;

            }

            //case: fastRunner is about to 'lap' slowRunner
            if (fastRunner == slowRunner)
            {
                return true;
            }

            //case: fastRunner hit the end of the list
            return false;
        }
    }
}
