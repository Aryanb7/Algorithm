using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSamples.Sort
{
    public class QuickSort
    {
        // https://www.techiedelight.com/quicksort/
        public static void Run()
        {
            //Find();
            // int[] input = new int[] { 90, 10, 5, 8, 9, 4, 3 }; //5 and 9 =4 is largest 
            //int[] input = new int[] { 100, 180, 260, 310, 40, 535, 695 };//(0 3) (4 6)
            //int[] input = new int[] { 23, 13, 25, 29 ,33, 19, 34,45 ,65, 67};//(1 4) (5 9)
            // int[] input = new int[] { 90, 10, 9, 4, 3 };
            int[] input = new int[] { 23, 13, 25, 29, 33, 19, 34, 45, 65, 30, 35 };

            if (input.Length < 1) Console.WriteLine("nothing ..."); ;
            var pivot = input[input.Length - 1];
          //  solution(input);
            Console.ReadKey();
        }

        //public static List<int> solution(int[] arr)
        //{
        //    var len = arr.Length;
        //    if (len > 2)
        //    {
        //        var pivot = arr[len - 1];
        //        for (int i = 0; i < len; i++)
        //        solution(arr);
        //    }
        //    else if (len ==2)
        //    {
        //        sortedArr.Add(arr[0] > arr[1] ? arr[1] : arr[0]);
        //        sortedArr.Add(arr[0] > arr[1] ? arr[0] : arr[1]);
        //        return sortedArr; 
        //    }
        //    else if (len == 1)
        //    {
        //        sortedArr.Add(arr[0]);
        //        return sortedArr;
        //    }

        //    return new List<int>();
        //}
    }
}
