using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSamples.String
{
	//TODO: Replace all spaces in a string with “%20″
	public static class ReplaceAllSpaceWith
	{
		public static void run()
		{
			string str = "Hi i am a boy. i am 30 years old.";

			//1
			string result = str.Replace(" ", "20%");
			Console.WriteLine(result);

			//2
			string tempStr = string.Empty;
			for (int i = 0; i < str.Length; i++) {
				tempStr += str[i] != Convert.ToChar(" ") ? str[i].ToString() : "20%";
			}
			Console.WriteLine(tempStr);

			Console.ReadKey();
		}		
	}
}
