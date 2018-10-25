using System;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question6
    {
        public static int Answer(int numOfServers, int targetServer, int[,] connectionTimeMatrix)
        {
            // if the target server is only 1 in direction or itself
            if(connectionTimeMatrix[0, targetServer] == 1) return 1;
            if (connectionTimeMatrix[0, targetServer] == 0) return 0;

            // otherwise check the other nodes

            return DijkstraAlgo(numOfServers, targetServer, connectionTimeMatrix);
        }


        public static int DijkstraAlgo(int numOfServers, int targetServer, int[,] graph)
        {
            int[] distance = new int[numOfServers];
            bool[] shortestPaths = new bool[numOfServers];
            for (int i = 0; i < numOfServers; ++i)
            {
                distance[i] = int.MaxValue;
                shortestPaths[i] = false;
            }

            distance[0] = 0;
            for (int count = 0; count < numOfServers - 1; ++count)
            {
                int u = MinD(distance, shortestPaths, numOfServers);
                shortestPaths[u] = true;
                for (int v = 0; v < numOfServers; ++v)
                    if (!shortestPaths[v] && Convert.ToBoolean(graph[u, v]) && distance[u] != int.MaxValue && distance[u] + graph[u, v] < distance[v])
                        distance[v] = distance[u] + graph[u, v];
            }

            return distance[targetServer];
        }

        private static int MinD(int[] distance, bool[] shortestPaths, int n)
        {
            int min = int.MaxValue;
            int minIndex = 0;
            for (int v = 0; v < n; ++v)
            {
                if (shortestPaths[v] == false && distance[v] <= min)
                {
                    min = distance[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }
    }
}