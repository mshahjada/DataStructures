using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Algorithms
{
    public static class SelectionSort
    {
        public static int[] Apply(int[] arr)
        {
            int n = arr.Length, temp;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] < arr[j])
                        continue;
                    else
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
