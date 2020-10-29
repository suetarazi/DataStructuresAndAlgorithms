using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Calculate2dArrayDistance
{
    public class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordinate(int x, int y)
            {
                X = x;
                Y = y;
            }

        public List<Coordinate> getNeighbors()
        {
            List<Coordinate> neighbors = new List<Coordinate>();
            
            neighbors.Add(new Coordinate(X + 1, Y));
            neighbors.Add(new Coordinate(X - 1, Y));
            neighbors.Add(new Coordinate(X, Y + 1));
            neighbors.Add(new Coordinate(X, Y - 1));

            return neighbors;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int calculateDistance(string input)
        {
            int distance = 0;
            Coordinate start = null;  
            Queue queue = new Queue();

            //split input string into array
            string[] stringArray = input.Split(";");  //[{O__} {_XT} {___}] 
            //stringArray[0][2];

            // Start at the start - to find start, need to search stringArray for 'O' and return its indices. 
            for(int i=0; i<stringArray.Length; i++)
            {
                for(int j=0; j<stringArray[i].Length; j++)
                {
                    if(stringArray[i][j]=='O')
                    {
                        //start has been found and it's coordinates have been set as such from the constructor above: X to i and Y to j 
                        start = new Coordinate(i, j);
                        
                    }
                }
            }

            // Create a set of nodes S that are reachable from start: populate List neighbors
            List<Coordinate> list = new List<Coordinate>();
           //Dictionary<>
            
                foreach(Coordinate c in start.getNeighbors())
                {
                    //list.Add(c);
                }
            // Create a set of nodes S' thar are reachable from S and have not yet been in any set
            // Repeat until you reach end
            // Return number of sets (+/-1?)

            return distance;
        }
    }
}
