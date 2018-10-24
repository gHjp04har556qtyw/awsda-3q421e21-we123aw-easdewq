using System;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question4
    {
        public static int Answer(string[,] machineToBeFixed, int numOfConsecutiveMachines)
        {
            // Brute force Loop through
            for(int i =0; i< machineToBeFixed.GetLength(0); i++)
            {
                bool startCounting = false;

                for(int j = 0; j < machineToBeFixed.GetLength(1); j++)
                {
                    // skip if X is found
                    if (machineToBeFixed[i, j].Equals("X") && (machineToBeFixed.GetLength(1) - j) > numOfConsecutiveMachines)
                    {
                        continue;
                    }
                    else
                    {
                        // startCounting
                        startCounting = true;
                    }
                }
            }


            //TODO: Please work out the solution;
            return 0;
        }
    }
}