using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort
{
    /// <summary>
    /// Insertion sort is another simple sorting algorithm.
    /// It builds a sorted array (or list) one element at a time 
    /// by comparing each new element to the already-sorted elements 
    /// and inserting the new element into the correct location,     /// similar to the way you sort a hand of playing cards.
    /// 
    /// Complexity is: best-case - O(n) which occurs when the list is already sorted.
    /// The average and worst cases are both O(n^2).
    /// </summary>
    public class InsertionSort
    {
        // Sort an array using a simple insertion sort.
        public void DoInsertionSort(int[] data)
        {
            for (int which = 1; which < data.Length; ++which)
            {
                int val = data[which];
                for (int i = 0; i < which; ++i)
                    if (data[i] > val)
                    {
                        Array.Copy(data, i, data, i + 1, which - i);
                        data[i] = val;
                        break;
                    }
            }
        }
    }
}
