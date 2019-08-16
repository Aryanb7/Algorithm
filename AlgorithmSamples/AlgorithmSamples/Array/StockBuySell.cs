using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSamples.Array
{
    public class StockBuySell
    {
        public static void Run()
        {
            //Find();
            // int[] input = new int[] { 90, 10, 5, 8, 9, 4, 3 }; //5 and 9 =4 is largest 
            //int[] input = new int[] { 100, 180, 260, 310, 40, 535, 695 };//(0 3) (4 6)
            //int[] input = new int[] { 23, 13, 25, 29 ,33, 19, 34,45 ,65, 67};//(1 4) (5 9)
            // int[] input = new int[] { 90, 10, 9, 4, 3 };
            int[] input = new int[] { 23, 13, 25, 29, 33, 19, 34, 45, 65, 30,35 };
            solution(input);
            Console.ReadKey();
        }

        public static void solution(int[] arr)
        {
            int len = arr.Length;
            if (len < 1) Console.WriteLine("nothing ..."); ;

            var dict = new Dictionary<int, int>();

            int max = arr[0];
            int min = arr[0];

            int buy = 0;
            int cell = 0;

            for (int i = 0; i + 1 < len; i++)
            {//23, 13, 25, 29 ,33, 19, 34,45 ,65, 67
                if (min < arr[i + 1]) // find the minimum
                {
                    var j = i;
                    while (j + 1 < len && max < arr[j+ 1] )
                    {
                        max = arr[j + 1];
                        j++;
                    }
                    i = j;
                    dict.Add(min, max);
                  
                }
                if (i + 1 < len)
                {
                    min = arr[i + 1];
                    max = 0;
                }   
                else
                    continue;
            }
            Console.WriteLine("buy: " + buy);
            Console.WriteLine("cell: " + cell);
        }
    }
}
