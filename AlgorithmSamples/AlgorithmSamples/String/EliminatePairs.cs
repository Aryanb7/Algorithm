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
            //Remove(str);  
             Remove_2(str);
            Console.WriteLine(str);
            Console.ReadKey();

        }

        public static void Remove(string str)
        {
            int len = str.Length;
            int i = 0;
            string tempStr = string.Empty;

            for (i = 0; i < len; i++)
            {

                if (i + 1 < len && str[i] == str[i + 1] )
                {
                    Remove(tempStr + str.Substring(i + 2, len - (i+2)));
                }
                else
                {
                    tempStr += str[i];
                }

            }
            var t = 1;
        }

        public static unsafe void Remove_2(string str)
        {
            // compile with: /unsafe
            int len = str.Length;
            int i , j  = 0;
            var  t = str.ToCharArray();
            for (i = 1; i < len; i++)
            {
                while ((t[i] == t[j]) && (j >= 0))
                {
                    i++;
                    j--;
                }
                t[j++] = str[i];
            }
            t[j + 1] = '\0';
            return;

        }

        private static int IsPair(int index, string str)
        {
            if (str[index] == str[index + 1])
            {
                IsPair(index - 1, str);
            }
            return index;
        }
    }
}
