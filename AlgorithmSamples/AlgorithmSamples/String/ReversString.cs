using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSamples.String
{
	public static class ReversString
	{		
		public static void Run(string str)
		{
			string tempStr = string.Empty;
			int lenght = str.Count();
			for (int i = lenght; i > 0; i--) {
				tempStr += str[i - 1];
			}
			Console.WriteLine(tempStr);
			Console.ReadKey();
		}
	}
}
