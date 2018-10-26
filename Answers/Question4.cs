using System;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question4
    {
        public static int Answer(string[,] machineToBeFixed, int numOfConsecutiveMachines)
        {


            //TODO: Please work out the solution;
            return 0;
        }

        public static bool canFix(string[] system, int numOfConsecutiveMachines)
        {
            int n = system.Length;
            int difference = Math.Abs(n - numOfConsecutiveMachines);

            // if any of these values are X then it is impossible to fit in here!
            for (int i=difference; i < n - difference; i++)
            {
                if (system[i].Equals("X")) return false;
            }

            return true;
        }
    }
}