using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSamples.Array
{
    public class ProductOfOtherNumbers
    {
        public static void Run()
        {
           int[] input = new int[] { 1, 2, 6, 5, 9 };
            var res = solution(input);
            Console.ReadKey();
        }

        public static int[] solution(int[] arr)
        {
            var len = arr.Length;
            var rightArr = new int[len];
            var leftArr = new int[len];
            var prod = new int[len];

            rightArr[0] = 1;
            leftArr[len - 1] = 1;

            for (int i = 1; i < len; i++)
            {
                rightArr[i] = rightArr[i - 1] * arr[i];
            }

            for (int i = len - 1; i > 0; i--)
            {
                var t = leftArr[i] * arr[i];
                leftArr[i - 1] = t;
            }
         
            for (int i = 0; i < len; i++)
            {
                if (i == 0)
                    prod[i] = leftArr[i];
                else
                    prod[i] = leftArr[i] * rightArr[i - 1];
            }
            return prod;
        }
    }
}


/// <image url="C:\MyGitRepo\AlgorithmSamples\AlgorithmSamples\CommonImages\1.png" /> 