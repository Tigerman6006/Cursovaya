using System;
using System.Collections;
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
    private Graph _graph;
    private int[] visited;
    private int edgesCount;
    public int TotalMinCost => mincost;

    public Prim(int n, Graph graph)
    {
        cost = new int[n, n];
        count = n;
        mincost = 0;
        _graph = graph;
        visited = new int[n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                cost[i, j] = _graph.row[i, j];
                if (cost[i, j] == 0) cost[i, j] = 999;
            }
        }
        visited[0] = 1;
        _graph.nodeColors[1] = Color.Red; 
        edgesCount = 1;


    }
    public IEnumerable StepByStep()
    {
        while (edgesCount < count)
        {
            int min = 999;
            int a = -1, b = -1;

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

            if (a != -1 && b != -1)
            {
                _graph.roadColors[(a + 1, b + 1)] = Color.Red;
                _graph.roadColors[(b + 1, a + 1)] = Color.Red;

                _graph.nodeColors[b + 1] = Color.Red;

                mincost += min;
                visited[b] = 1;
                cost[a, b] = cost[b, a] = 999;
                edgesCount++;

                yield return null;
            }
            else
            {
                break;
            }
        }
    }
}
//    public int MinOstTree()
//    {
//        int[] visited = new int[count];
//        int N = 1;
//        for (int i = 0; i < count; i++) visited[i] = 0;
//        visited[0] = 1;

//        while (N < count)
//        {
//            int min = 999;
//            int a = 0, b = 0;

//            for (int i = 0; i < count; i++)
//            {
//                if (visited[i] == 1)
//                {
//                    for (int j = 0; j < count; j++)
//                    {
//                        if (visited[j] == 0 && cost[i, j] < min)
//                        {
//                            min = cost[i, j];
//                            a = i;
//                            b = j;
//                        }
//                    }
//                }
//            }

//            if (visited[b] == 0)
//            {
//                _graph.roadColors[(a + 1, b + 1)] = Color.Red;
//                mincost += min;
//                visited[b] = 1;
//            }

//            cost[a, b] = cost[b, a] = 999;
//        }

//        return mincost;
//    }
//}

