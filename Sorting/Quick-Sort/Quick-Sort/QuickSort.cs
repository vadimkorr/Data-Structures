using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_Sort
{
    /// <summary>
    /// Quicksort is a divide-and-conquer algorithm that involves choosing a pivot value from a data set 
    /// and splitting the set into two subsets: a set that contains all values less than the pivot 
    /// and a set that contains all values greater than or equal to the pivot.
    /// The pivot/split process is recursively applied to each subset until there are no more subsets to split.
    /// The results are combined to form the final sorted set.
    /// 
    /// Complexity is: best case and avg: O(n log(n)) - performing log(n) operations on each of n elements 
    /// yields a combined best case complexity.
    /// Worst-case complexity of O(n^2) - pivot is poor - minimum value of data set
    /// </summary>
    public class QuickSort
    {
        // Sort an array using a simple but inefficient quicksort.
        public int[] DoQuickSort(int[] data)
        {
            if (data.Length < 2)
                return data;

            int pivotIndex = data.Length / 2;
            int pivotValue = data[pivotIndex];
            int leftCount = 0;

            // Count how many are less than the pivot
            for (int i = 0; i < data.Length; ++i)
                if (data[i] < pivotValue) ++leftCount;

            // Allocate the arrays and create the subsets
            int[] left = new int[leftCount];
            int[] right = new int[data.Length - leftCount - 1];

            int l = 0;
            int r = 0;
            for (int i = 0; i < data.Length; ++i)
            {
                if (i == pivotIndex) continue;
                int val = data[i];
                if (val < pivotValue)
                    left[l++] = val;
                else
                    right[r++] = val;
            }

            // Sort the subsets
            left = DoQuickSort(left);
            right = DoQuickSort(right);

            // Combine the sorted arrays and the pivot back into the original array
            Array.Copy(left, 0, data, 0, left.Length);
            data[left.Length] = pivotValue;
            Array.Copy(right, 0, data, left.Length + 1, right.Length);
            return data;
        }
    }
}
