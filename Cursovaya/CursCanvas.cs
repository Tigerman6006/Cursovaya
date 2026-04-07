using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursovaya;

public class CursCanvas
{
    public int? _canvasWidth;
    public int? _canvasHeight;

    public ShowGraph? _showGraph;

    public CursCanvas(int canvasWidth, int canvasHeight)
    {
        _canvasWidth = canvasWidth;
        _canvasHeight = canvasHeight;
    }
    public bool InsertGraph(ShowGraph graph)
    {
        if (!_canvasHeight.HasValue || !_canvasWidth.HasValue)
        {
            return false;
        }
        _showGraph = graph;
        return true;
    }
    public Bitmap? DrawCanvas()
    {
        if (!_canvasHeight.HasValue || !_canvasWidth.HasValue)
        {
            return null;
        }
        Bitmap bmp = new(_canvasWidth.Value, _canvasHeight.Value);
        Graphics graphics = Graphics.FromImage(bmp);
        _showGraph?.Show(graphics);
        return bmp;
    }
}

