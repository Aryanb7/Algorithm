using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.DataStructure.Array
{
	 public static class YieldClass
	{
		static List<int> myList = new List<int>();
		static void FillValue() {
			myList.Add(1);
			myList.Add(2);
			myList.Add(3);
			myList.Add(4);
			myList.Add(5);
		}

		public static void Run()
		{
			FillValue();
			foreach (var item in Filter() ) {
				Console.WriteLine(item);
			}
			Console.ReadKey();
		}

		static IEnumerable<int> Filter() 
		{
			foreach (var item in myList) {
				if (item > 3)
					yield return item;
			}
		}

	}
}
