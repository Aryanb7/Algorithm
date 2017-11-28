using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSamples.Dynamic_Connectivity
{
    public class QuickFind
    {
        //eager approach
        // Union.To merge components containing p and q, change all entries
        //whose id equals id[p] to id[q](second number).
        //Union is too expensive.It takes N2 array accesses to process a sequence of
        //N union commands on N objects.

        public static void Run()
        {
            QuickFindUF(10);
            Union(3, 8);
            Union(6, 5);
            Union(9, 4);
            Union(2, 1);

            Console.WriteLine(Connected(8, 9) ?
              "8 and 9 are connected" :
              "8 and 9 are not connected");

            Console.WriteLine(Connected(6, 5) ?
                    "6 and 5 are connected" :
                    "6 and 5 are not connected");

            Console.ReadKey();
        }

        private static int[] id;

        public static void QuickFindUF(int N)
        {
            id = new int[N];
            for (int i = 0; i < N; i++)
                id[i] = i;
        }

        public static bool Connected(int p, int q)
        {
            return id[p] == id[q];
        }

        public static void Union(int p, int q)
        {
            int pid = id[p];
            int qid = id[q];
            for (int i = 0; i < id.Length; i++)
                if (id[i] == pid) id[i] = qid;
        }
    }
}
