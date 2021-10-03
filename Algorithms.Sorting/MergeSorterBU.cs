using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class MergeSorterBU : MergeSorterBase, ISorter
    {
		public void Sort(int[] arr)
		{
			var n = arr.Length;
			var buffer = new int[n];
			for (int i = 1; i < n; i = 2 * i)
			{
				for (int j = 0; j < n - i; j += 2 * i)
				{
					var pr = j + 2 * i - 1;
					var r = (n - 1) < pr ? (n - 1) : pr;
					var mid = j + i - 1;
					var l = j;
					Merge(arr, buffer, l, mid, r);
				}
			}
		}
	}
}
