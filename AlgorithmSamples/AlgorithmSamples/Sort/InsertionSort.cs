using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSamples.Sort
{
    //it is not good sort algorithm, but it is better than bubble sort and selection sort
    public static class InsertionSort
    {
        public static void Run()
        {
            int[] input = new int[] { 1112, 1111, 2, 3, 445, 6, 6, 120, 1250, 125 };
            Compare(input);

        }

        public static void Compare(int[] data)
        {
            // First try
            //var len = data.Length;
            //for (int i = 0***; i+1 < len; i++)
            //{
            //    if (data[i] < data[i + 1])
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        var j = i;
            //        while (j > 0 *** && data[j - 1] > data[j])
            //        {
            //            Swipe(data, j, j - 1);
            //            j--;
            //        }
            //    }
            //}
            /* 1- in the first try "while (j > 0 ***" what will be happen if the first item larger than the second item
               we don't even process the first option b/c j is not larger than 0, that is why we have to start from 1 "int i = 0***"
               and not 0 => if we have such that condition "data[j - 1]" make sure that we have to start form 1

            2- when we start form 1 no need to "i+1 < len" and obviously this" if (data[i] < data[i + 1]) ...."
               */

            var len = data.Length;
            for (int i = 1; i < len; i++)
            {
                var j = i;
                while (j > 0 && data[j - 1] > data[j])
                {
                    Swipe(data, j, j - 1);
                    j--;
                }
            }
            Console.ReadKey();
        }


        public static void Swipe(int[] data, int larger, int smaller)
        {
            int buffer;
            buffer = data[larger];
            data[larger] = data[smaller];
            data[smaller] = buffer;
        }

    }
}
