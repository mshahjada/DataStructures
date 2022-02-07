using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Problems
{
    internal class MinCostPath
    {
        private static int minCost(int[,] cost, int m, int n)
        {
            int i, j;
            int[,] tc = new int[m + 1, n + 1];

            tc[0, 0] = cost[0, 0];

            /* Initialize first column of total cost(tc) array */
            for (i = 1; i <= m; i++)
                tc[i, 0] = tc[i - 1, 0] + cost[i, 0];

            /* Initialize first row of tc array */
            for (j = 1; j <= n; j++)
                tc[0, j] = tc[0, j - 1] + cost[0, j];

            /* Construct rest of the tc array */
            for (i = 1; i <= m; i++)
                for (j = 1; j <= n; j++)
                    tc[i, j] = Math.Min(tc[i - 1, j - 1],
                                Math.Min(tc[i - 1, j],
                                tc[i, j - 1])) + cost[i, j];

            return tc[m, n];
        }

        // Driver program
        public  void TestMain()
        {
            int[,] cost = {{1, 2, 3},
                    {4, 8, 2},
                    {1, 5, 3}};

            var dt = DateTime.Now;
            Console.WriteLine(minCost(cost, 2, 2));
            Console.WriteLine(DateTime.Now - dt);

            dt = DateTime.Now;
            Console.WriteLine(OptimizedDP(cost, 2, 2));
            Console.WriteLine(DateTime.Now - dt);
        }

        private int OptimizedDP(int[,] arr, int m, int n)
        {
            for(int i=1;i<=m; i++)
            {
                arr[i, 0] = arr[i-1, 0] + arr[i,0];
            }

            for (int i = 1; i <= n; i++)
            {
                arr[0, i] = arr[0, i-1] + arr[0,i];
            }

            for(int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    arr[i, j] += Math.Min(
                        arr[i - 1, j - 1],
                        Math.Min(arr[i - 1, j], arr[i, j - 1])
                        );
                }
            }

            return arr[m, n];
        }
    }
}
