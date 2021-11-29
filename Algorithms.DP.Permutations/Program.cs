using System;

namespace Algorithms.DP.Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "ABCD";
            Permutate(str, 0);
        }

        static void Permutate(string str, int p)
        {
            var n = str.Length;
            if (p == n - 1)
            {
                Console.WriteLine(str);
                return;
            }

            Permutate(str, p + 1);
            var arr = str.ToCharArray();
            for (int i = p + 1; i < n; i++)
            {
                var t = arr[i];
                arr[i] = arr[p];
                arr[p] = t;

                Permutate(string.Join("", arr), p + 1);

                t = arr[i];
                arr[i] = arr[p];
                arr[p] = t;
            }
        }
    }
}
