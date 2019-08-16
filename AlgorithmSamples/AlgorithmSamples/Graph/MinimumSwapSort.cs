using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSamples.Graph
{
    static public class MinimumSwapSort
    {
        public static int MinimumSwap(int[] arr)
        {
            // 1- create dictionary 
            // 2- sort dictionary
            // 3- find the graph cycle 
            //arr = new int[] {2,3,4,1,5 };
            arr = new int[] { 4, 3 ,1, 2 };
            
            var len = arr.Length;
            var dic = new Dictionary<int, int>();
            var visited = new bool[len];
            for (int i = 0; i < len; i++)
            {
                dic.Add(i, arr[i]);
                visited[i] = false;
            }
            dic.OrderBy(x => x.Value);
            var cycle = 0;            
            for (int j = 0; j < len; j++)
            {
                if (visited[j] || dic[j] == j )
                    continue;
                var val = j;
                var w_count = 0;
                while(val<len && !visited[val])
                {
                    visited[val] = true;
                    val = dic[val];
                    w_count++;
                }
                cycle += w_count - 1;
            }

            return cycle;
            
        }
    }
}
