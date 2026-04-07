using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursovaya;
class Prim
{
    private int[,] cost;
    private int mincost;
    private int count;

    public Prim(int n, int[,] row)
    {
        cost = new int[n, n];
        count = n;
        mincost = 0;
        

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                cost[i, j] = row[i, j];
                if (cost[i, j] == 0) cost[i, j] = 999;
            }
        }

        
    }
    public int MinOstTree()
    {
        int[] visited = new int[count];
        int N = 1;
        for (int i = 0; i < count; i++) visited[i] = 0;
        visited[0] = 1;

        while (N < count)
        {
            int min = 999;
            int a = 0, b = 0;

            for (int i = 0; i < count; i++)
            {
                if (visited[i] == 1)
                {
                    for (int j = 0; j < count; j++)
                    {
                        if (visited[j] == 0 && cost[i, j] < min)
                        {
                            min = cost[i, j];
                            a = i;
                            b = j;
                        }
                    }
                }
            }

            if (visited[b] == 0)
            {
                //Console.WriteLine($"Ребро {N++}: ({a + 1} -> {b + 1}) вес = {min}");
                mincost += min;
                visited[b] = 1;
            }

            cost[a, b] = cost[b, a] = 999;
        }

        return mincost;
    }
}

