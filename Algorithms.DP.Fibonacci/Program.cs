using System;

namespace Algorithms.DP.Fibonacci
{
    class Program
    {
		static void Main(string[] args)
		{
			var n = new Random().Next(100, 1000);
			var cache = new long[n + 1];
			Array.Fill(cache, -1);
			Console.WriteLine(FibonacciV1(n, cache));
			Console.WriteLine(FibonacciV2(n));
			Console.WriteLine(FibonacciV3(n));
		}

		static long FibonacciV1(int n, long[] cache)
		{
			if (n < 2) return n;

			if (cache[n - 1] < 0)
				cache[n - 1] = FibonacciV1(n - 1, cache);

			if (cache[n - 2] < 0)
				cache[n - 2] = FibonacciV1(n - 2, cache);

			return cache[n - 1] + cache[n - 2];
		}

		static long FibonacciV2(int n)
		{
			var cache = new long[n + 1];
			cache[0] = 0;
			cache[1] = 1;

			for (int i = 2; i < n + 1; i++)
				cache[i] = cache[i - 1] + cache[i - 2];

			return cache[n];
		}

		static long FibonacciV3(int n)
		{
			long a = 0;
			long b = 1;

			for (int i = 2; i < n + 1; i++)
			{
				var t = a + b;
				a = b;
				b = t;
			}

			return b;
		}
	}
}
