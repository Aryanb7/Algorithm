using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.DataStructure.String
{
	public static class FirstNonRepeatedCharacter
	{
		//For example, Input : “teeter” Output: r
		public static void Run(string str) {
			var dict = new Dictionary<char, int>();
			int numb = 1;
			for (int i = 0; i < str.Length; i++) {
				if (!dict.ContainsKey(str[i]))
					dict.Add(str[i], numb);
				else
					//find base on the key
					dict[str[i]] += 1;
			}
			foreach (var item in dict) {
				if (item.Value == 1) {
					Console.WriteLine(item.Key);
					Console.ReadKey();
					return;
				}
			}			
		}
	}
}
