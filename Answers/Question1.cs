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
            for (int i = 0, n = portfolios.Length; i < n - 1; i++)
            {
                for (var j = i + 1; j < n; j++)
                {
                    result = (portfolios[i] ^ portfolios[j]) > result ? (portfolios[i] ^ portfolios[j]) : result;
                }
            }
            return result;
        }
    }
}
