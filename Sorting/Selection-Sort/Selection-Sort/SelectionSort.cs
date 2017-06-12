using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Sort
{
    /// <summary>
    /// Selection sort is one of the simplest sorting algorithms. 
    /// It starts with the first element in the array (or list) 
    /// and scans through the array to find the element with the smallest key, 
    /// which it swaps with the first element.
    /// The process is then repeated with each subsequent element until 
    /// the last element is reached.
    /// The description of this algorithm suggests a recursive approach.
    /// 
    /// Complexity is O(n^2) in the best, average, and worst cases.
    /// 
    /// In-place, not stable
    /// </summary>
    public class SelectionSort
    {
        // Sort an array using a recursive selection sort.
        public void SelectionSortRecursive(int[] data)
        {
            _SelectionSortRecursive(data, 0);
        }

        // Sort a subset of the array starting at the given index.
        private void _SelectionSortRecursive(int[] data, int start)
        {
            if (start < data.Length - 1)
            {
                _Swap(data, start, _FindMinimumIndex(data, start));
                _SelectionSortRecursive(data, start + 1);
            }
        }

        // Find the position of the minimum value starting at the given index.
        private int _FindMinimumIndex(int[] data, int start)
        {
            int minPos = start;

            for (int i = start + 1; i < data.Length; ++i)
                if (data[i] < data[minPos])
                    minPos = i;
            return minPos;
        }

        // Swap two elements in an array.
        private void _Swap(int[] data, int index1, int index2)
        {
            if (index1 != index2)
            {
                int tmp = data[index1];
                data[index1] = data[index2];
                data[index2] = tmp;
            }
        }
    }
}
