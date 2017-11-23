using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSamples.Search
{

    //Binary Search: Search a sorted array by repeatedly dividing the search interval in half.Begin with an interval 
    //covering the whole array.If the value of the search key is less than the item in the middle of the interval, 
    //narrow the interval to the lower half.Otherwise narrow it to the upper half.Repeatedly check until the value is 
    //found or the interval is empty.

    //O(Logn)
    public static class BinarySearch
    {
        // sorted array 
        private static int[] _arr = new int[] { 0, 2, 3, 4, 10, 40, 44 };

        public static void Run()
        {
            int max = _arr.Length;
            var d = Search(44, 0, max);
            int g = 0;
        }



        private static int Search(int number, int min, int max)
        {

            int medIndex = (min + max) / 2;

            if (_arr[medIndex] == number)
                return medIndex;

            else if (number < _arr[medIndex])//Search right side
                return Search(number, min, medIndex);

            else if (number > _arr[medIndex])//Search left side
                return Search(number, medIndex, max);

            return -1;

        }
    }




}
