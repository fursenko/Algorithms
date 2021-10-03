using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class InsertionSorter: ISorter
    {
		public void Sort(int[] arr)
		{
			var n = arr.Length;
			for(int i = 1; i < n; i++)
				for(int j = i; j > 0 && arr[j] < arr[j - 1]; j--)
				{
					var t = arr[j];
					arr[j] = arr[j - 1];
					arr[j - 1] = t;
				}
		}
    }
}
