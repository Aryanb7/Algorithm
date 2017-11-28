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
			//---------implementation 1       i think this is better
			int currentValue, i, j;
			int len = data.Length;
			//the key is i =1 , in the first loop we compare the array[0 ====>j = i - 1] with array[1] 
			for (i = 1; i < len; i++) {
				currentValue = data[i];
				j = i - 1;

				while (j >= 0 && data[j] > currentValue) {
					//in this step we move the larger value to next element of array or swipe the small element to the first of array(LOL)
					//Actually this swipe the small element to the first of array is more correct
					data[j + 1] = data[j];
					j--;
				}
				//TODO: to set the very FIRST possible position in array that we can fill with the current value
				data[j + 1] = currentValue;
			}

			//implementation 2
			//int i, j;
			//int N = data.Length;

			//for (j = 1; j < N; j++) {
			//	for (i = j; i > 0 &&   data[i - 1]>data[i]; i--) {
			//		Swipe(data, i, i - 1);
			//	}
			//}

			for (int t = 0; t < data.Length; t++) {
				Console.WriteLine(data[t]);
			}
			Console.ReadKey();
		}


		public static void Swipe(int[] data, int m, int n)
		{
			int buffer;
			buffer = data[m];
			data[m] = data[n];
			data[n] = buffer;
		}

	}
}
