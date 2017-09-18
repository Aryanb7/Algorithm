using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.DataStructure.String
{
	public static class ReverseStringWordByWord
	{
		//Input : Hello! How are you
		//Output: you are How Hello!

		//i)Reverse the whole string.
		//You will get “uoy era woH !olleH”
		//ii)Then reverse each word.

		public static void Run(string str)
		{
			string tempStr = string.Empty;
			string tempFinalStr = string.Empty;

			string reversStatment = Revers(str);
			for (int i = 0; i < reversStatment.Length; i++) {

				if (reversStatment[i] != Convert.ToChar(" ")) {
					tempStr += reversStatment[i];
				}
				else {
					tempFinalStr = tempFinalStr + " " + Revers(tempStr);
					tempStr = string.Empty;
				}
			}
			// " " + Revers(tempStr) this block just is to add last word
			Console.WriteLine(tempFinalStr + " " + Revers(tempStr));
			Console.ReadKey();

			//just reverse the statment
			//var reversedWords = string.Join(" ", str.Split(' ')
			//					 .Select(x => new string(x.Reverse().ToArray())));
		}

		private static string Revers(string str)
		{
			string tempStr = string.Empty;
			int lenght = str.Count();
			for (int i = lenght; i > 0; i--) {
				tempStr += str[i - 1];
			}
			return tempStr;

		}


	}
}
