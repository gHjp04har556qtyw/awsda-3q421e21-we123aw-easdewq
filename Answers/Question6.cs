using System;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question6
    {
        public static int Answer(int numOfServers, int targetServer, int[,] connectionTimeMatrix)
        {





            // Eventually it will be the value in the first index to target server [0, 7, targetServer]
            return connectionTimeMatrix[0, targetServer];
        }

        
    }
}