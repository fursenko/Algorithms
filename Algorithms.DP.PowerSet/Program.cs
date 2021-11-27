using System;

namespace Algorithms.DP.PowerSet
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var arr = new int[] { 1, 2, 3 };
                ViaRecursion(arr, -1, "");
                Console.WriteLine("-----------------------------");
                ViaBitMask(arr);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        static void ViaBitMask(int[] arr)
        {
            var n = arr.Length;
            var vl = Math.Pow(2, n);

            for (int i = 0; i < vl; i++)
            {
                for (int j = 0; j < n; j++)
                    if ((i & (1 << j)) > 0)
                        Console.Write($"{arr[j]}");

                Console.WriteLine();
            }
        }

        static void ViaRecursion(int[] arr, int i, string result)
        {
            var n = arr.Length;
            if (i == n)
            {
                Console.WriteLine($"[{result}]");
                return;
            }

            var origin = result;
            if (0 <= i && i < n)
                result += arr[i].ToString();

            ViaRecursion(arr, i + 1, result);

            if (i >= 0)
                ViaRecursion(arr, i + 1, origin);
        }
    }
}
