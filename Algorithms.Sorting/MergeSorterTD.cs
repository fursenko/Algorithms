using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class MergeSorterTD: MergeSorterBase, ISorter
    {
		public void Sort(int[] arr)
		{
			var n = arr.Length;
			var buffer = new int[n];
			Sort(arr, buffer, 0, n - 1);
		}
		
		private void Sort(int[] arr, int[] buffer, int l, int r)
		{
			if(r == l) return;
			var mid = l + (r - l)/2;
			Sort(arr, buffer, l, mid);
			Sort(arr, buffer, mid + 1, r);
			Merge(arr, buffer, l, mid, r);
		}
	}
}
