using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace Cursovaya;
public class ShowGraph
{
    private Graph _graph;
    private readonly int circleSize = 25;
    private int _startPosX;
    private int _startPosY;
    private bool gen = false;
    public int[,] Nodes;
    public ShowGraph(Graph graph, int startX, int startY)
    {
        _graph = graph;
        _startPosX = startX;
        _startPosY = startY;
        Nodes = new int[_graph.n, 2];
    }
    public void Show(Graphics g)
    {
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        if (!gen)
        {
            double angleStep = 2 * Math.PI / _graph.n;
            int radius = 150;

            for (int i = 0; i < _graph.n; i++)
            {
                Nodes[i, 0] = _startPosX + (int)(radius * Math.Cos(i * angleStep));
                Nodes[i, 1] = _startPosY + (int)(radius * Math.Sin(i * angleStep));
            }
            gen = true;
        }

        for (int i = 0; i < _graph.n; i++)
        {
            for (int j = 0; j < _graph.n; j++)
            {
                if (_graph.row[i, j] > 0 && _graph.row[i, j] < 999)
                {
                    DrawRoad(g, Nodes[i, 0], Nodes[i, 1], Nodes[j, 0], Nodes[j, 1],
                             _graph.roadColors[(i, j)], _graph.row[i, j]);
                }
            }
        }

        for (int i = 0; i < _graph.n; i++)
        {
            DrawNode(g, i, Nodes[i, 0], Nodes[i, 1], _graph.nodeColors[i]);
        }

    }
    private void DrawNode(Graphics g, int num, int x, int y, Color color)
    {
        Pen pen = new Pen(color, 2);
        Brush brush = new SolidBrush(color);
        Brush bgBrush = new SolidBrush(Color.White);
        Font font = new Font("Arial", 10);

        g.FillEllipse(bgBrush, x, y, circleSize, circleSize);
        g.DrawEllipse(pen, x, y, circleSize, circleSize);


        string text = num.ToString();
        SizeF textSize = g.MeasureString(text, font);
        g.DrawString(text, font, brush, x + (circleSize - textSize.Width) / 2, y + (circleSize - textSize.Height) / 2);
    }
    private void DrawRoad(Graphics g, int x1, int y1, int x2, int y2, Color color, int weight)
    {
        int offset = circleSize / 2;
        int cx1 = x1 + offset;
        int cy1 = y1 + offset;
        int cx2 = x2 + offset;
        int cy2 = y2 + offset;
        Pen pen = new Pen(color, 1);
        Brush brush = new SolidBrush(color);
        AdjustableArrowCap arrow = new AdjustableArrowCap(5, 5);
        Font font = new Font("Arial", 9);
        pen.CustomEndCap = arrow;
        
        float dx = cx2 - cx1;
        float dy = cy2 - cy1;
        float distance = (float)Math.Sqrt(dx * dx + dy * dy);

        if (distance > 0)
        {
            float ratio = (distance - offset) / distance;
            float targetX = cx1 + dx * ratio;
            float targetY = cy1 + dy * ratio;

            g.DrawLine(pen, cx1, cy1, targetX, targetY);
        }
        string wText = weight.ToString();
        SizeF wSize = g.MeasureString(wText, font);
        int midX = (cx1 + cx2) / 2;
        int midY = (cy1 + cy2) / 2;

        g.FillRectangle(Brushes.White, midX, midY, wSize.Width, wSize.Height);
        g.DrawString(wText, font, brush, midX, midY);
    }
}
