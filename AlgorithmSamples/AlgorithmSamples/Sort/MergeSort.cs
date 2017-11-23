using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSamples.Sort
{
    //complexity is O(nlogn) in worst case
    //we use recursion in this algorithm but in other type of the sort we rearranging the element and change the element position with swapping and shifting 
    public class MergeSort
    {
        /// <image url="D:\DataStructure\Test.GPEG" />
        public void Run()
        {
            int[] input = new int[] { 1112, 1111, 2, 3, 445, 6, 6, 120, 1250, 125 };
            sort(input, 0, input.Length);
           // int[] aux = new int[input.Length];
           // Sort(input, aux, 0, input.Length);
            var t = 0;
        }

        public static void sort<T>(T[] a)
       where T : IComparable<T>
        {
            sort(a, 0, a.Length);
        }

        public static void sort<T>(T[] a, int low, int high)
            where T : IComparable<T>
        {
            int length = high - low;
            if (length <= 1)
                return;

            int mid = low + length / 2;

            sort(a, low, mid);
            sort(a, mid, high);

            T[] aux = new T[length];
            int i_low = low, j_mid = mid;
            for (int k = 0; k < length; k++)
            {
                if      (i_low == mid)                      aux[k] = a[j_mid++];   // it means when the ride side is completely sort - we have to just check the left side if there is any unsorted has remained 
                else if (j_mid == high)                     aux[k] = a[i_low++]; // it means when the left side is completely sort - we have to just check the right side if there is any unsorted has remained 
                else if (a[j_mid].CompareTo(a[i_low]) < 0)  aux[k] = a[j_mid++]; //** main
                else                                        aux[k] = a[i_low++];
            }

            for (int k = 0; k < length; k++)
            {
                a[low + k] = aux[k];
            }
        }

//----------------------------------------------------------------------------------------


        //private void Sort(int[] list, int[] aux, int lo, int hi)
        //{
        //    if (lo >= hi)
        //        return;
        //    else
        //    {
        //        int mid = lo + (hi - lo) / 2;
        //        Sort(list, aux, lo, mid);
        //        Sort(list, aux, mid + 1, hi);
        //        Merge(list, aux, lo, mid, hi);
        //    }
        //}

        //private void Merge(int[] list, int[] aux, int lo, int mid, int hi)
        //{

        //    //copy
        //    for (int k = lo; k <= hi; k++)
        //        aux[k] = list[k];

        //    //merge

        //    int i = lo, j = mid + 1;
        //    for (int k = lo; k <= hi; k++)
        //    {
        //        if (i > mid) list[k] = aux[j++];
        //        else if (j > hi) list[k] = aux[i++];
        //        //else if (less(aux[j], aux[i])) list[k] = aux[j++];
        //        else if (aux[j].CompareTo(aux[i]) < 0) aux[k] = aux[j++];
        //        else list[k] = aux[i++];
        //    }


        //}


    }
}



// public static void sort<T>(T[] a)
//where T : IComparable<T>
//    {
//        sort(a, 0, a.Length);
//    }

//    public static void sort<T>(T[] a, int low, int high)
//        where T : IComparable<T>
//    {
//        int N = high - low;
//        if (N <= 1)
//            return;

//        int mid = low + N / 2;

//        sort(a, low, mid);
//        sort(a, mid, high);

//        T[] aux = new T[N];
//        int i = low, j = mid;
//        for (int k = 0; k < N; k++)
//        {
//            if (i == mid) aux[k] = a[j++];
//            else if (j == high) aux[k] = a[i++];
//            else if (a[j].CompareTo(a[i]) < 0) aux[k] = a[j++];
//            else aux[k] = a[i++];
//        }

//        for (int k = 0; k < N; k++)
//        {
//            a[low + k] = aux[k];
//        }
//    }