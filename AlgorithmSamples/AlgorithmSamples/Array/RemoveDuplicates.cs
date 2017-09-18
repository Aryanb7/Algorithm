using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSamples.Array
{
	//remove duplicates in an array
	//remove duplicates in a sorted array
	//[1] [1] [2] [3] [5] [6] [6] [7] [10] [25] [100] [123] [123]
	//[1] [2] [3] [5] [6] [7] [10] [25] [100] [123]
	public static class RemoveDuplicates
	{
		public static void Run()
		{
			int[] input = new int[] { 1, 1,2, 3, 4, 6, 6, 120, 125, 125 };

			//TODO show Duplicate
			//for (int i = 0; i < input.Length - 1; i++) {
			//	if (input[i + 1] == input[i]) {
			//		Console.WriteLine(input[i]);					
			//	}
			//}
			//Console.ReadKey();


			//TODO Remove Duplicate
			int i, j;
			j = 0;
			for (i = 1; i < input.Length; i++) {
				if (input[i] != input[j]) {
					j++;
					input[j] = input[i]; // Move it to the front
				}
			}

			// The new array size..
			int array_size = (j + 1);
			for (i = 0; i < array_size; i++) {
				Console.WriteLine(input[i]);
			}
			//Console.ReadKey();

			//linq solution
			var query = input.GroupBy(x => x)
		                      .Where(g => g.Count() > 1)
						  .Select(y => y.Key)
						  .ToList();

			//how many times the elements are repeated
			var query2 = input.GroupBy(x => x)
						  .Where(g => g.Count() > 1)
						  .Select(y => new{ Element= y.Key ,Count = y.Count() })
						  .ToList();
		}

		//TODO :contain
		//public static bool Contain(int input, int[] myArray)
		//{
		//	for (int i = 0; i < myArray.Length; i++) {
		//		if (myArray[i] == input) {
		//			return true;
		//		}
		//	}
		//	return false;
		//}
	}
}
