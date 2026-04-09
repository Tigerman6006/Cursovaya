using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursovaya;
public class Graph
{
    public int n;
    public int[,] row;
    public Dictionary<int, Color> nodeColors;
    public Dictionary<(int from, int to), Color> roadColors;
    public Graph(int n)
    {
        this.n = n;
        row = new int[n, n];
        nodeColors = [];
        roadColors = [];
    }
    public void GenGraph()
    {
        Random rnd = new();
        for (int i = 0; i < n; i++)
        {
            nodeColors.Add(i, Color.Black);
            for(int j = 0; j < n; j++)
            {
                if (row[j, i] == 0)
                {
                    int weight = rnd.Next(0, 10);
                    row[i, j] = weight;
                    int check = row[i, j];
                    if (check != 0)
                    {
                        roadColors[(i, j)] = Color.Black;
                    }
                }
                
            }
        }
    }
}
