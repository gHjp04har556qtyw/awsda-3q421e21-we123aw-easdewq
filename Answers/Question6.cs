using System;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question6
    {
        public static int Answer(int numOfServers, int targetServer, int[,] connectionTimeMatrix)
        {
            return DijkstraAlgo(numOfServers, targetServer, connectionTimeMatrix);
        }


        public static int DijkstraAlgo(int verticesCount, int target, int[,] graph)
        {
            int[] distance = new int[verticesCount];
            bool[] shortestPaths = new bool[verticesCount];
            for (int i = 0; i < verticesCount; ++i)
            {
                distance[i] = int.MaxValue;
                shortestPaths[i] = false;
            }

            distance[0] = 0;
            for (int count = 0; count < verticesCount - 1; ++count)
            {
                int u = MinD(distance, shortestPaths, verticesCount);
                shortestPaths[u] = true;
                for (int v = 0; v < verticesCount; ++v)
                    if (!shortestPaths[v] && Convert.ToBoolean(graph[u, v]) && distance[u] != int.MaxValue && distance[u] + graph[u, v] < distance[v])
                        distance[v] = distance[u] + graph[u, v];
            }

            return distance[target];
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