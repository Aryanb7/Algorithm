using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.DataStructure.String
{
	public static class MoveSpacesToFrontString
	{
		//ASCII code of space is	32
		public static void Run(string str) {
			string tempStr = string.Empty;
			string space = string.Empty;
			for (int i = 0; i < str.Length; i++) {
				if ((int)str[i] != 32) {
					tempStr += str[i];
				}
				else if ((int)str[i] == 32) {
					space += " ";
				}
			}
			Console.WriteLine(space + tempStr);
			Console.ReadKey();
		}
	}
}

