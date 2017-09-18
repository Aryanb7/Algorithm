using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.DataStructure.Array
{
	public static class SortArray
	{
		public static void Run()
		{
			int[] input = new int[] { 1, 1111, 2, 3, 445, 6, 6, 120, 1250, 125 };
			//IntArrayBubbleSort(input);
			IntArrayInsertionSort(input);
		}

		//TODO :Exchanging Array Elements
		public static void exchange(int[] data, int m, int n)
		{
			int temporary;

			temporary = data[m];
			data[m] = data[n];
			data[n] = temporary;
		}

		 //Bubble Sort
		public static void IntArrayBubbleSort(int[] data)
		{
			int i, j;
			int N = data.Length;

			for (j = N - 1; j > 0; j--) {
				for (i = 0; i < j; i++) {
					if (data[i] > data[i + 1])
						exchange(data, i, i + 1);
				}
			}

			for (int t = 0; t < data.Length; t++) {
				Console.WriteLine(data[t]);
			}

			Console.ReadKey();
		}

		// Insertion Sort
		public static void IntArrayInsertionSort(int[] data)
		{
			//int i, j;
			//int N = data.Length;

			for (int i = 1; i < data.Length; i++) {
				for (int j = i; j > 0 && data[j-1] > data[j] ; j--) {
					exchange(data, j, j-1);
				}
			}

			for (int t = 0; t < data.Length; t++) {
				Console.WriteLine(data[t]);
			}

			Console.ReadKey();
		}
	}
}
