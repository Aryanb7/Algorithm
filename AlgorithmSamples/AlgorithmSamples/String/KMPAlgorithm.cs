using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSamples.String
{
    public class KMPAlgorithm
    {
        //shifting algorithm  ????????????
        //Knuth–Morris–Pratt algorithm - string Matching Algorithm
        //Given a text txt[0..n - 1] and a pattern pat[0..m - 1], write a function search(char pat[], char txt[]) that prints all occurrences of pat[] in txt[]. You may assume that n > m.

        // Examples:

        //Input:  txt[] = "THIS IS A TEST TEXT"
        //pat[] = "TEST"
        //Output: Pattern found at index 10

        //Input:  txt[] =  "AABAACAADAABAABA"
        //pat[] =  "AABA"
        //Output: Pattern found at index 0
        //        Pattern found at index 9
        //        Pattern found at index 12

        // KMP Has two part
        // 1- prefix array for KMP.
        // 2- find match in text with take advantage of prefix array
        public int[] GetPatternTable(char[] pattern)
        {
            int patternLength = pattern.Length;
            int[] pt = new int[patternLength];
            int j = 0;
            for (int i = 0; i < patternLength; i++)
            {
                if (i == 0)
                {
                    // The First Item is always zero
                    pt[0] = 0;
                }

                else if (pattern[j] == pattern[i])
                {
                    // match item is found
                    pt[i] = j + 1;
                    j++;
                }
                else if (pattern[j] != pattern[i] && j == 0)
                {
                    // there is no more match was found in the pattern
                    pt[i] = 0;
                }
                else if (pattern[j] != pattern[i] && j != 0)
                {
                    // we have to find the match in previous item
                    while (j >= 0)
                    {
                        // 1 - Get Last Index = looking for the value of last I in pattern 
                        // 2-  Get the value of I in PT(Pattern table) array                      
                        int ptLastIndexValue = pt[j - 1];
                        j = ptLastIndexValue;
                        // 3- compare 
                        if (pattern[ptLastIndexValue] == pattern[i])
                        {
                            //perviuosVal is the index of pt that contain the value 
                            pt[i] = ptLastIndexValue + 1;
                            j++;
                            break;
                        }
                        else
                        {

                            if (j == 0 || j == 1)
                            {
                                pt[i] = pt[0];
                                j = 0;
                                break;
                            }

                        }

                    }
                }
            }

            return pt;
        }

        public void Search()
        {
            //char[] pattern = "abcdabca".ToCharArray();
            //char[] pattern = "aacdabca".ToCharArray();
            //char[] pattern = "acacabacacabacacac".ToCharArray();
            char[] pattern = "abcaby".ToCharArray();
            var pt = GetPatternTable(pattern);
            var text = "abxabcabcaby";

            var txtArr = text.ToCharArray();
            int pointer = 0;
            int successPoints = pattern.Length;
            bool success = false;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Equals(pattern[pointer]))
                {
                    pointer++;
                }
                else
                {
                    if (pointer != 0)
                    {
                        int tempPointer = pointer - 1;
                        pointer = pt[tempPointer];
                        i--;
                    }
                }

                if (successPoints == pointer)
                {
                    success = true;
                }
            }

            if (success)
            {
                System.Console.WriteLine("TRUE");
            }
            else
            {
                System.Console.WriteLine("FALSE");
            }
            System.Console.Read();
        }

        //public void Search()
        //{
        //    //char[] pattern = "abcdabca".ToCharArray();
        //    //char[] pattern = "aacdabca".ToCharArray();
        //    //char[] pattern = "acacabacacabacacac".ToCharArray();
        //    char[] pattern = "abcabhy".ToCharArray();
        //    var pt = GetPatternTable(pattern);

        //    var text = "abxabcabcaby";
        //    var txtArr = text.ToCharArray();
        //    var j = 0;
        //    for (int i = 0; i < txtArr.Length; i++)
        //    {
        //        if (pt.Length == j)
        //        {
        //            Console.WriteLine("matched");
        //            break;
        //        }
        //        if (txtArr[i] == pattern[j])
        //            j++;

        //        else if (txtArr[i] != pattern[j])
        //        {

        //            while (j >= 0)
        //            {
        //                // 1 - Get Last Index = looking for the value of last I in pattern 
        //                // 2-  Get the value of I in PT(Pattern table) array                      
        //                int ptLastIndexValue = pt[j - 1];

        //                // 3- compare 
        //                if (pattern[ptLastIndexValue] == txtArr[i])
        //                {

        //                    //perviuosVal is the index of pt that contain the value 
        //                    j++;
        //                    break;
        //                }
        //                else
        //                {
        //                    j = ptLastIndexValue;
        //                    if (j == 0 || j == 1)
        //                    {
        //                        j = 0;
        //                        break;
        //                    }


        //                }

        //            }
        //        }
        //    }




        //    var t = 0;
        //}
    }
}
