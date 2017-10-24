using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSamples.Array
{
	 public static class LargestValueArray
	{
		 public static void Run() {
			Console.WriteLine(Max(new int[] { 173, 29, 391, 41 }));
			Console.ReadKey();
		 }

		 public static int Max(int[] input)
		 {
			 ////for (int i = N - 1; i >= 0; --i) {   //it is a good idea too
			 ////    if (A[i] > max)
			 ////	    max = A[i];
			 int max = 0;
			 for (int i = 0; i < input.Length; i++) {
				 if (input[i] >= input[max]) {
					 max = i;
				 }
			 }
			 return input[max];
		 }
	}
}
