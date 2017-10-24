using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSamples.Array
{
    public static class JumpGame
    {

        //Given an array of non-negative integers, you are initially positioned at the first index of the array.
        //Each element in the array represents your maximum jump length at that position.
        //Determine if you are able to reach the last index.
        //For example:
        //A = [2, 3, 1, 1, 4], return true.
        //A = [3, 2, 1, 0, 4], return false.

        public static void Run()
        {
            int[] inputA = new int[] { 2, 3, 1, 1, 4 };
            int[] inputB = new int[] { 3, 2, 1, 0, 4 };
            int[] inputC = new int[] { 2, 2, 1, 2, 4 };
            int[] inputD = new int[] { 4, 2, 1, 2, 4 };
            int[] inputE = new int[] { 5, 2, 1, 2, 4 };

            var result = CanJump(inputE, 0);
            Console.WriteLine($"CanJump: {result}");
            Console.ReadKey();
        }

        /// This dummy answer - I think question is not comprehensive 
        static bool CanJump(int[] myArr, int position)
        {
            if (myArr.Length == position + 1)
                return true;

            if (position + 1 > myArr.Length)
                return false;

            int newPosition = myArr[position];

            if (newPosition == 0)
                return false;

            return CanJump(myArr, newPosition + position);

        }
    }
}
