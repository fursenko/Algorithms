using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class ShellSorter: ISorter
    {
		public void Sort(int[] arr)
		{
			var n = arr.Length;
			var step = 1;
			while(step < n)
				step = step*3 + 1;
			
			while(step >=1)
			{
				for(int i = 0; i < n; i++)
				{
					for(int j = i; j >= step && arr[j] < arr[j - step]; j -= step)
					{
						var t = arr[j];
						arr[j] = arr[j - step];
						arr[j - step] = t;
					}
				}
				
				step /= 3;
			}
			
		}
    }
}
