using System;
//using System.Collections.Generic;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataStructure.DataStructure.String
{
	public static class RemoveDuplicateCharacters
	{
		// crazyforcode => crazyfode
		//public static void Run(string str)
		//{
		//	var dict = new Dictionary<char, int>();
		//	string tempStr = string.Empty;
		//	for (int i = 0; i < str.Length; i++) {
		//		if (!dict.ContainsKey(str[i])) {
		//			dict.Add(str[i], i);
		//			tempStr += str[i];
		//		}
		//	}
		//	Console.WriteLine(tempStr);
		//	Console.ReadKey();

		//}

		public static void Run()
		{
			//char[] array = str.ToCharArray();
			//int[] my = new int[127];
			//foreach (var item in array) {
			//	my[(int)item] = my[(int)item] + 1;
			//}
			//Console.WriteLine();
			//Console.ReadKey();
			var h1 = new HashSet<char>();
			var h2 = new HashSet<char>();

			foreach (var ch in "nbHHkRvrXbvkn") {
				if (!h1.Add(ch)) {
					h2.Add(ch);
				}
			}

			h1.ExceptWith(h2); // remove duplicates

			var chars = new char[h1.Count];
			h1.CopyTo(chars);
			var result = new string(chars); // = "RrX"
		}


	}
}
