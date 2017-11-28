using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSamples.Dynamic_Connectivity
{
    public static class QuickUnion
    {
        //Lazy approach
        // we have to create tree - In the union we have to set the root of the first element to the root of the second element 
 

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

        private static int Root(int n)
        {
            int root = n;
            while (id[root] != root)
            {
                root = id[root];
            }
            return root;
        }
        public static bool Connected(int p, int q)
        {
            return Root(p) == Root(q);
        }

        public static void Union(int f, int s)
        {
            //we have to create tree - In the union we have to set the root of the first element to the root of the second element
            int rootOfFirst = Root(f);
            int rootOfSecond = Root(s);
            id[rootOfFirst] = rootOfSecond;
        }
    }
}
