using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Problems
{
    public class KnapSack
    {
        static int knapSack(int W, int[] wt, int[] val, int n)
        {

            int[] dp =new int[W+1];

            for (int i = 1; i <= wt.Length; i++)
            {
                for (int j = W; j>=0; j--)
                {
                    if(wt[i-1] <= j)
                    {
                        var y = wt[i - 1];
                        var x = dp[j - y];
                      
                        dp[j] = Math.Max(dp[j],
                            val[i - 1] + x
                            );
                    }
                }
            }

            return dp[W];
            
        }

        // Driver code
        public static void Init()
        {
            int[] val = { 60, 120, 100 };
            int[] wt = { 10, 20, 30 };
            int W = 50;
            //int[] val = { 2,3,4,1 };
            //int[] wt = { 3,4,5,6};
            //int W = 8;
            int n = val.Length;
            Console.Write(knapSack(W, wt, val, n));
        }
    }
}
