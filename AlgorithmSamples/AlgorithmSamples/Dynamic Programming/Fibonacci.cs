using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSamples.Dynamic_Programming
{
    public static class Fibonacci
    {
        //F0 F1  F2 F3  F4 F5  F6   F7  F8  F9  F10 F11 F12 F13 F14 F15 F16 F17  F18   F19  F20
        //0	 1	 1	2	3	5	8	13	21	34	55	89	144	233	377	610	987	1597 2584 4181	6765

        public static void Run()
        {

            //var result = fib(7);
            //Console.WriteLine($"Fibonacci: {result}");
            //Fib_1(9);
            //RecursiveFibPrint(11);

            //MemoiezationInitialize();
            //var result = fibMemo(7);
            //Console.WriteLine($"Fibonacci: {result}");

            var result = fibTabulation(7);
            Console.WriteLine($"Fibonacci: {result}");

            Console.ReadKey();
        }

        //get the nth Fibonacci number
        static int fib(int n)
        {
            if (n <= 1)
                return n;

            //  Fibonacci is result of the sum of two last Fibonacci number
            return fib(n - 1) + fib(n - 2);
        }


        public static void Fib_1(int len)
        {
            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1}", a, b);

            for (int i = 2; i < len; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
        }

        static void RecursiveFibPrint(int n)
        {
            //  Fibonacci is result of the sum of two last Fibonacci number
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"{ fib(i)}");
            //}
            RecursiveFibPrint1(n, 0);
        }

        static void RecursiveFibPrint1(int n, int i)
        {
            //  Fibonacci is result of the sum of two last Fibonacci number
            if (i < n)
            {
                Console.WriteLine($"{ fib(i)}");
                i++;
                RecursiveFibPrint1(n, i);
            }

        }

        static int MAX = 100;
        static int NIL = -1;
        static int[] lookup = new int[MAX];

        static void MemoiezationInitialize()
        {
            // Memoization(Top Down)
            /* Function to initialize NIL values in lookup table */
            for (int i = 0; i < MAX; i++)
                lookup[i] = NIL;
        }

        static int fibMemo(int n)
        {
            if (lookup[n] == NIL)
            {
                if (n <= 1)
                    lookup[n] = n;
                else
                    lookup[n] = fibMemo(n - 1) + fibMemo(n - 2);
            }
            return lookup[n];
        }

        static int fibTabulation(int n)
        {
            //Tabulation(Bottom Up)           
            int[] f = new int[n + 1];
            f[0] = 0;
            f[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                f[i] = f[i - 1] + f[i - 2];
            }
            return f[n];
        }

    }
}