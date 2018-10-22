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
            int result = 0;
            for (int i=0, n = portfolios.Length, a = 0; i < n; i++)
            {
                a = portfolios[i];
                for (int j = i + 1, x = 0; j < n; j++)
                {
                    x = a ^ portfolios[j];
                    result = x > result ? x : result;
                    if (result == 65335) return 65335;
                }
            }
            return result;
        }
    }
}
