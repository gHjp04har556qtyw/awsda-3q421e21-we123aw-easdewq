using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question1
    {
        
        public static int Answer(int[] portfolios)
        {
            int result = 0, i=0, n = portfolios.Length, a, j, x;
            for (; i < n; i++)
            {
                a = portfolios[i];
                for (j = i, x = 0; j < n; j++)
                {
                    x = a ^ portfolios[j];
                    result = x > result ? x : result;
                }
            }
            return result;
        }
    }
}
