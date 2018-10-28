using System;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question4
    {
        public static int Answer(string[,] machineToBeFixed, int numOfConsecutiveMachines)
        {
            int min = Int32.MaxValue;
            bool canFix = false;
            int systemSize = machineToBeFixed.GetLength(0);
            int pcSize = machineToBeFixed.GetLength(1);

            // don't count if we can't
            if (pcSize < numOfConsecutiveMachines) return 0;

            int diff = Math.Abs(pcSize - numOfConsecutiveMachines);

            int count = 0;
            int sum = 0;

            for (int i = 0; i < systemSize; i++)
            {
                for (int j = 0; j < pcSize; j++)
                {
                    var pc = machineToBeFixed[i, j];
                    if (pc.Length == 1) {
                        if (pc.Equals("X"))
                        {
                            count = 0;
                            sum = 0;
                        }
                    }
                    else
                    {
                        count++;
                        sum += Convert.ToInt32(pc);


                        if (count == numOfConsecutiveMachines)
                        {
                            canFix = true;
                            if (sum < min)
                            {
                                min = sum;
                            }
                            sum = 0;
                        }
                    }
                }
            }

            return canFix ? min : 0;
        }

        /*   
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
        }*/
    }
}