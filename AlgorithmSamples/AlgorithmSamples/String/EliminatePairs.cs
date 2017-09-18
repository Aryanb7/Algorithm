using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSamples.String
{
	//Eliminate Pairs: eg. input string RGBBGBGR –> RGGBGR–> RBGR (output)
	public static class EliminatePairs
	{
		public static void Run(string str)
		{
            //int len = str.Length;
            //int i, j = 0;
            //string tempStr = string.Empty;
            //for (i = 1; i < len; i++)
            //{
            //    while ((str[i] == str[j]) && (j >= 0))
            //    {
            //        i++;
            //        j--;
            //    }
            //    str[j++] = str[i];
            //}
            //str[j + 1] = '\0';


            //string tempStr = string.Empty;
            //int j = 1;
            //for (int i = 0; i < str.Length - 1; i++) {
            //    if (str[i] != str[i + 1]) {
            //        tempStr += str[i];
            //    }
            //    else {
            //        i = IsPair(i, str);
            //    }
            //}

            //Console.WriteLine(tempStr);
            //Console.ReadKey();

		}
		private static int IsPair(int index, string str)
		{
			if (str[index - 1] == str[index + 2]) {
				IsPair(index -1, str);
			}
			return index;
		}

	}
}
