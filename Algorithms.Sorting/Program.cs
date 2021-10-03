using System;

namespace Algorithms.Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(new MergeSorterTD(), "Merge sort, top down");
            Test(new MergeSorterBU(), "Merge sort, bottom up");
			Test(new ShellSorter(), "Shell sort");
			Test(new InsertionSorter(), "Insertion Sort");
        }

        static void Test(ISorter sorter, string name)
        {
            Console.WriteLine(name);
            var arr = Create(10);
            Print(arr);
            sorter.Sort(arr);
            Print(arr);
            Console.WriteLine(IsSorted(arr));
            Console.WriteLine("\n");
        }

        static int[] Create(int n)
        {
            var random = new Random();
            var arr = new int[n];

            for (int i = 0; i < n; i++)
                arr[i] = random.Next(1, 100);

            return arr;
        }

        static void Print(int[] arr)
        {
            var n = arr.Length;
            for (int i = 0; i < n; i++)
                Console.Write($" {arr[i]}");

            Console.WriteLine();
        }

        static bool IsSorted(int[] arr)
        {
            var n = arr.Length;
            for (int i = 1; i < n; i++)
                if (arr[i] < arr[i - 1]) return false;

            return true;
        }
    }
}
