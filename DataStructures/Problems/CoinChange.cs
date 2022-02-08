using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Problems
{
    internal class CoinChange
    {
        private int Apply(int[] arr, int len, int target)
        {

            int[,] dp = new int[len, target + 1];

            for (int i = 0; i < len; i++)
            {
                dp[i, 0] = 1;
            }


            for(int i = 0; i < len; i++)
            {
                for (int j = 1; j <= target; j++)
                {
                    if (i == 0)
                    {
                        dp[i, j] = (j % arr[i] == 0)? 1 : 0;
                    }
                    else
                    {
                        if (j >= arr[i])
                        {
                            dp[i, j] = dp[i - 1, j] + dp[i, j - arr[i]];
                        }
                        else
                        {
                            dp[i, j] = dp[i - 1, j];
                        }
                    }

                    
                    
                }
            }

            return dp[len-1, target];
        }

        private int Apply1(int[] S, int m, int n)
        {
            int[] table = new int[n + 1];

            // Base case (If given value is 0)
            table[0] = 1;

            // Pick all coins one by one and
            // update the table[] values after
            // the index greater than or equal
            // to the value of the picked coin
            for (int i = 0; i < m; i++)
                for (int j = S[i]; j <= n; j++)
                    table[j] += table[j - S[i]];

            return table[n];
        }

        public void Initiaize()
        {
            //int[] arr = { 2, 3, 5, 10 };
            //int w = 15;

            int[] arr = { 1, 2, 3 };
            int w = 4;

            Console.WriteLine($"Coin Change: {Apply(arr, arr.Length, w)}");
            Console.WriteLine($"Coin Change: {Apply1(arr, arr.Length, w)}");
        }
    }
}
