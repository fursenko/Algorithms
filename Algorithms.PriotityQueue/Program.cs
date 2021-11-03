using System;

namespace Algorithms.PriotityQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 10;
            var random = new Random();
            var pq = new PriotityQueue<int>(n);
            for (int i = 0; i < n; i++)
                pq.Insert(random.Next(1, n));

            while (pq.Size > 0)
            {
                Console.Write($" {pq.DelMax()}");
            }
        }
    }
}
