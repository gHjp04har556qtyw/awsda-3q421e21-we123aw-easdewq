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
            for (byte n = (byte)portfolios.Length; n >= 0; n--)
            {
                for (byte j = (byte)(n + 1); j < portfolios.Length; j++)
                {
                    result = (portfolios[n] ^ portfolios[j]) > result ? (portfolios[n] ^ portfolios[j]) : result;
                }
            }
            return result;
        }
    }
}
