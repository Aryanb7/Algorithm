using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.DataStructure.ArrayPractice
{
	//O(n2)
	//compare between 2 element and swipe the element if need, we do it till array get sort
	public static class BubbleSort
	{
		 public static void Run()
		 {
			 int[] input = new int[] { 1, 1111, 2, 3, 445, 6, 6, 120, 1250, 125 };
			 Compare(input);
		 }

		 //TODO :Exchanging Array Elements
		public static void Swipe(int[] data,int m ,int n){
			int buffer;
			buffer = data[m];
			data[m] = data[n];
			data[n] = buffer;
		}

		public static void Compare(int[] data)
		{
			int i, j;
			int len = data.Length;

			for ( i = len-1; i > 0; i--) {
				//after the first loop and sort the biggest at the end of the array
				//in the second loop we iterate loop n-1 ==> i = Len-1 , we don't need consider to the elements at the end of the array that is already sorted 
				// we are kind of two parts, sorted sections at the end section of the array and unsorted section at the first section of the array
				for (j = 0; j < i; j++) {
					if (data[j] > data[j + 1]) {
						Swipe(data,j, j + 1);
					}
				}
			}

		
			for (int t = 0; t < data.Length; t++) {
				Console.WriteLine(data[t]);
			}
			Console.ReadKey();
		}


	}
}
