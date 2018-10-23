using System;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question6
    {
        public static int Answer(int numOfServers, int targetServer, int[,] connectionTimeMatrix)
        {

            /*
            int smallest = Int32.MaxValue;

            // loop through until smallest edge found
            for(int i=0; i<numOfServers; i++)
            {

            }*/

            // Eventually it will be the value in the first index to target server [0, 7, targetServer]
            return connectionTimeMatrix[0, targetServer];
        }

        
    }
}