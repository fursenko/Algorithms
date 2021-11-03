using System;

namespace Algorithms.PriotityQueue
{
    public class PriotityQueue<T> where T : IComparable
    {
        T[] _arr;
        int I = 0;
        public int Size { get { return I; } }

        public PriotityQueue(int n)
        {
            _arr = new T[n + 1];
        }

        public void Insert(T vl)
        {
            _arr[++I] = vl;
            Swim(I);
        }

        public T DelMax()
        {
            var max = _arr[1];
            Swap(1, I);
            _arr[I--] = default(T);
            Sink(1);
            return max;
        }

        void Swim(int k)
        {
            while (k > 1 && Less(k / 2, k))
            {
                Swap(k, k / 2);
                k /= 2;
            }
        }

        void Sink(int k) 
        {
            while (2*k <= I)
            {
                var j = 2 * k;
                if (j < I && Less(j, j + 1)) j++;
                if (!Less(k, j)) break;
                Swap(k, j);
                k = j;
            }
        }

        void Swap(int i, int j)
        {
            var t = _arr[i];
            _arr[i] = _arr[j];
            _arr[j] = t;
        }

        bool Less(int i, int j)
        {
            return _arr[i].CompareTo(_arr[j]) < 0;
        }
    }
}
