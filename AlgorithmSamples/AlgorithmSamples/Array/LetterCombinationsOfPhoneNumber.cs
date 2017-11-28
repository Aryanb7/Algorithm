using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSamples.Array
{
    public static class LetterCombinationsOfPhoneNumber
    {

        static string[] _map = new string[] { "", "", "abc", "def", "ghi", "jkl",
                                              "mno", "pqrs", "tuv", "wxyz" };
        public static void Run()
        {
            Calculate("234", 0, 0, "");
            Console.ReadKey();
        }

        //public static void Calculate(string numbers, int currentDigitIndex)
        //{
        //    char[] str = GetCurrentString(numbers, currentDigitIndex).ToCharArray();
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        char[] str2 = GetCurrentString(numbers, currentDigitIndex + 1).ToCharArray();
        //        for (int j = 0; j < str2.Length; j++)
        //        {
        //            Console.WriteLine(str[i].ToString() + str2[j].ToString());
        //        }
        //    }

        //}

        public static void Calculate(string numbers, int currentDigitIndex, int loopIndex, string lastUpdateChar)
        {
            char[] str = GetCurrentString(numbers, currentDigitIndex).ToCharArray();

            for (int i = loopIndex; i < str.Length; i++)
            {
                int newIndex = currentDigitIndex + 1;
                string newChar = string.IsNullOrEmpty(lastUpdateChar) ? str[i].ToString() : lastUpdateChar + str[i].ToString();

                if (newIndex < numbers.Length)
                    Calculate(numbers, newIndex, loopIndex, newChar);

                if (newChar.Length == numbers.Length)
                    Console.WriteLine(newChar);

            }
            
        }


        public static string GetCurrentString(string numbers, int currentDigitIndex)
        {
            string digit = numbers[currentDigitIndex].ToString();
            var currentChar = _map[Convert.ToInt32(digit)];
            return currentChar;
        }

    }

}

