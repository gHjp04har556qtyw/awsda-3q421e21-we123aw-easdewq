using System;
using C_Sharp_Challenge_Skeleton.Beans;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question3
    {
        public static int Answer(int numOfNodes, Edge[] edgeLists)
        {
            return maxExchangesTraded(numOfNodes, edgeLists) - nonTradedWithRelation(numOfNodes, edgeLists);
        }

        private static int nonTradedWithRelation(int numOfNodes, Edge[] edgeLists)
        {
            return 0;
        }

        private static int maxExchangesTraded(int numOfNodes, Edge[] edgeLists)
        {
            return 0;
        }
    }
}