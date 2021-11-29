using System;

namespace Algorithms.BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 100;
            var arr = new int[n];
            var rnd = new Random();
            for (int i = 0; i < n; i++)
                arr[i] = rnd.Next(1, n);

            Array.Sort(arr);
            var idx = rnd.Next(1, n);
            Console.WriteLine(Find(arr, arr[idx]) == idx);
            Console.WriteLine(Find(arr, int.MaxValue) == n);
            Console.WriteLine(Find(arr, int.MinValue) == 0);
        }

        static int Find(int[] arr, int target)
        {
            var l = -1;
            var r = arr.Length;
            var mid = 0;
            while (r - l > 1)
            {
                mid = l + (r - l) / 2;
                if (target <= arr[mid]) r = mid;
                else l = mid;
            }

            return r;
        }
    }
}
