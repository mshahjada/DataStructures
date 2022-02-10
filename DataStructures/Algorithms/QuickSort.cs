using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Algorithms
{
    public class QuickSort
    {
        private void Apply(int[] arr, int l, int r)
        {
            if (l >= r)
                return;

            int p = Partition(arr, l, r);
            Apply(arr, l, p - 1);
            Apply(arr, p + 1, r);
        }

        private int Partition(int[] arr, int l, int r)
        {
            int p = arr[r];
            int i = l - 1;

            for (int j = l; j < r; j++)
            {
                if (arr[j] < p)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i+1, r);
            return i+1;
        }

        private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }


        public void Initialize()
        {
            int[] arr= new int[]{ 10, 7, 8, 9, 1, 5 };
            Console.WriteLine($"Quick Sort: {string.Join(",", arr)}");
            Apply(arr, 0, arr.Length-1);

            Console.WriteLine($"Result: {string.Join(",", arr)}");
        }
    }
}
