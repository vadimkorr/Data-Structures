using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_Sort_Optimized
{
    /// <summary>
    /// 
    /// </summary>
    public class QuickSortOptimized
    {
        // Sort an array using a simple but inefficient quicksort.
        public void DoQuickSortOptimized(int[] data)
        {
            if (data.Length < 2)
                return;
            DoQuickSortOptimized(data, 0, data.Length - 1);
        }

        private void DoQuickSortOptimized(int[] data, int left, int right)
        {
            int pivotValue = data[(left + right) / 2];
            int i = left;
            int j = right;
            while (i <= j)
            {
                // Find leftmost value greater than or equal to the pivot.
                while (data[i] < pivotValue) i++;
                // Find rightmost value less than or equal to the pivot.
                while (data[j] > pivotValue) j--;
                // If the values are in the wrong order, swap them.
                if (i <= j)
                {
                    _Swap(data, i, j);
                    i++;
                    j--;
                }
            }
            // Apply the algorithm to the partitions we made, if any.
            if (left < j)
                DoQuickSortOptimized(data, left, j);
            if (i < right)
                DoQuickSortOptimized(data, i, right);
        }        private void _Swap(int[] data, int i, int j)
        {
            int temp = data[i];
            data[i] = data[j];
            data[j] = temp;
        }
    }
}
