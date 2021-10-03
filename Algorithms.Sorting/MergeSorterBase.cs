using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public abstract class MergeSorterBase
    {
        protected virtual void Merge(int[] arr, int[] buffer, int l, int mid, int r)
        {
            for (int i = l; i <= r; i++)
                buffer[i] = arr[i];

            int li = l;
            int ri = mid + 1;

            for (int i = l; i <= r; i++)
            {
                if (li > mid)
                    arr[i] = buffer[ri++];
                else if (ri > r)
                    arr[i] = buffer[li++];
                else if (buffer[ri] < buffer[li])
                    arr[i] = buffer[ri++];
                else arr[i] = buffer[li++];

            }
        }
    }
}
