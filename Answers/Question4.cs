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

            int count = 0;
            int sum = 0;

            for (int i = 0; i < systemSize; i++)
            {

                for (int j = 0; j < pcSize; j++)
                {
                    // Individual pc to be fixed
                    var pc = machineToBeFixed[i, j];

                    if (pc.Equals("X"))
                    {
                        count = 0;
                        sum = 0;
                    }
                    else
                    {
                        count++;
                        sum += Int32.Parse(pc);


                        if (count == numOfConsecutiveMachines)
                        {
                            // we can fix this system
                            canFix = true;

                            // change the difference
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