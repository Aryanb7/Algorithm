using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSamples.Array
{
	public class LargestDifferenceInArray
	{
		public static void Run()
		{
            //Find();
            //int[] input = new int[] { 90, 10, 5, 8, 9, 4, 3 }; //5 and 9 =4 is largest 
            int[] input = new int[] { 100, 180, 260, 310, 40, 535, 695 };//(0 3) (4 6)
            //int[] input = new int[] { 23, 13, 25, 29 ,33, 19, 34,45 ,65, 67};(1 4) (5 9)
            Console.WriteLine(solution(input));
			Console.ReadKey();
		}
		public static void Find()
		{
			int[] input = new int[] { 10, 3, 6, 8, 9, 4, 3 };
			//answer is 9 and 3
			int length = input.Length;			
			int max = 0;
			int result = 0;

			for (int i = 0; i < length; i++) {
				if (input[i] - input[i + 1] > max) {
					max = input[i];
				}
			}

			Console.WriteLine(result);
			Console.ReadKey();
		}

		public static int solution(int[] A)
		{
			int N = A.Length;
			if (N < 1) return 0;

			int max = 0;
			int result = 0;

			int buy = 0;
			int cell = 0;

			//1- find and update Max if there is in each loop
 			//2-  update result if it is larger than last result 
			// { 90, 10, 5, 8, 9, 4, 3 }
			for (int i = N - 1; i >= 0; --i) {
				if (A[i] > max)
					max = A[i];

				var tmpResult = max - A[i];
				if (tmpResult > result) {
					result = tmpResult;
					buy = A[i];
					cell = max;
				}
			}
			Console.WriteLine("buy: "+ buy);
			Console.WriteLine("cell: " +cell);
			return result;
		}

	}
}
