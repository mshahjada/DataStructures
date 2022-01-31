using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Algorithms
{
    public static  class HeapSort
    {
        public static int[] Apply(int[] arr)
        {
            int i, l = arr.Length;
            for (i = l/2 - 1; i>=0; i--)
            {
                Heapify(arr, l, i);
            }

            int temp;
            for(i=l-1; i>=0; i--)
            {
                temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                Heapify(arr, i, 0);
            }

            return arr;
        }

        private static void Heapify(int[] arr, int size, int depth)
        {
            int temp;
            int l = depth * 2 + 1;
            int r = depth * 2 + 2;

            int largest = depth;

            if (size > l && arr[l] > arr[depth])
                largest = l;
            if (size > r && arr[r] > arr[largest])
                largest = r;

            if (largest != depth)
            {
                temp = arr[largest];
                arr[largest] = arr[depth];
                arr[depth] = temp;

                Console.WriteLine($"{string.Join(", ", arr)}");

                Heapify(arr, size, largest);
            }
        }
    }

    
}
