using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursovaya;
public class Prim:AbstractAlgorytm, WorkAlgorytm
{
    private int[,] cost;
    private int mincost;
    private int count;
    private int[] visited;
    private int edgesCount;
    public int TotalMinCost => mincost;
    private string filePath = "mincost.txt";

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
                int val = _graph.row[i, j];
                cost[i, j] = (val == 0) ? 999 : val;
            }
        }
        visited[0] = 1;
        _graph.nodeColors[0] = Color.Red; 
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
                _graph.roadColors[(a, b)] = Color.Red;
                _graph.roadColors[(b, a)] = Color.Red;

                _graph.nodeColors[b] = Color.Red;

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
    public bool SaveMinCost(string path = null)
    {
        try
        {
            File.WriteAllText(path ?? filePath, TotalMinCost.ToString());
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при сохранении: {ex.Message}");
            return false;
        }
        return true;
    }

    // Загрузка веса из файла
    public int LoadMinCost(string path = null)
    {
        try
        {
            string targetPath = path ?? filePath;
            if (File.Exists(targetPath))
            {
                string content = File.ReadAllText(targetPath);
                return int.Parse(content);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при загрузке: {ex.Message}");
        }
        return 0;
    }
}

