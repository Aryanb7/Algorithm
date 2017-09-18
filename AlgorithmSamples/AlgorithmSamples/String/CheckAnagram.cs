using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.DataStructure.String
{
	public static class CheckAnagram
	{
		//Two strings are anagrams if they are written using the same exact letters, 
		//ignoring space, punctuation and capitalization. Each letter should have the same count in both strings.
		public static void Run(string first, string second)
		{
			if (first.Length == second.Length && GetSum(first) ==GetSum(second)) {
				Console.WriteLine("anagram");
			}
			Console.ReadKey();
		}

		private static int GetSum(string str)
		{
			int sum = 0;
			string tempStr = str.ToLower();
			for (int i = 0; i < str.Length; i++) {
				sum += (int)tempStr[i];
			}
			return sum;
		}
	}
}

