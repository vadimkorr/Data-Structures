using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Sort
{
    /// <summary>
    /// Merge sort is another divide-and-conquer algorithm that works 
    /// by splitting a data set into two or more subsets,     /// sorting the subsets, and then merging them together into the nal sorted set.
    /// 
    /// Complexity is 
    /// </summary>
    public class MergeSort
    {
        // Sort an array using a simple but inefficient merge sort.
        public int[] DoMergeSort(int[] data)
        {
            if (data.Length < 2)
                return data;

            // Split the array into two subarrays of approx equal size.
            int mid = data.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[data.Length - mid];
            Array.Copy(data, 0, left, 0, left.Length);
            Array.Copy(data, mid, right, 0, right.Length);

            // Sort each subarray, then merge the result.
            DoMergeSort(left);
            DoMergeSort(right);
            return _Merge(data, left, right);
        }

        // Merge two smaller arrays into a larger array.
        private int[] _Merge(int[] dest, int[] left, int[] right)
        {
            int dind = 0;
            int lind = 0;
            int rind = 0;

            // Merge arrays while there are elements in both
            while (lind < left.Length && rind < right.Length)
            {
                if (left[lind] <= right[rind])
                    dest[dind++] = left[lind++];
                else
                    dest[dind++] = right[rind++];
            }

            // Copy rest of whichever array remains
            while (lind < left.Length)
                dest[dind++] = left[lind++];
            while (rind < right.Length)
                dest[dind++] = right[rind++];
            return dest;
        }
    }
}
