using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.DataStructure.ArrayPractice
{
	public static class SelectionSort
	{
		public static void Run()
		{
			int[] input = new int[] { 1112, 1111, 2, 3, 445, 6, 6, 120, 1250, 125 };
			Compare(input);

		}

		public static void Compare(int[] data)
		{

			int currentValue, i, j;
			int len = data.Length;


			for (int t = 0; t < data.Length; t++) {
				Console.WriteLine(data[t]);
			}
			Console.ReadKey();
		}
	}
}
