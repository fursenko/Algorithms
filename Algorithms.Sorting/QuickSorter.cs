using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class QuickSorter : ISorter
    {
        public void Sort(int[] arr)
        {
            var n = arr.Length;
            Sort(arr, 0, n - 1);
        }

        private void Sort(int[] arr, int left, int right)
        {
            if (left >= right) return;
            var p = Partition(arr, left, right);
            Sort(arr, left, p - 1);
            Sort(arr, p + 1, right);
        }

        private int Partition(int[] arr, int left, int right)
        {
            var li = left;
            var ri = right + 1;

            var el = arr[left];

            while (true)
            {
                while (arr[++li] < el)
                    if (li == right) break;

                while (el < arr[--ri])
                    if (ri == left) break;

                if (li >= ri) break;

                var t = arr[li];
                arr[li] = arr[ri];
                arr[ri] = t;
            }

            var tt = arr[left];
            arr[left] = arr[ri];
            arr[ri] = tt;

            return ri;
        }
    }
}
