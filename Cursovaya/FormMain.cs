namespace Cursovaya
{
    public partial class FormMain : Form
    {
        private readonly CursCanvas _canvas;
        public FormMain()
        {
            InitializeComponent();
            _canvas = new CursCanvas(pictureBox1.Width, pictureBox1.Height);
        }
        private Graph? _graph = null;
        private ShowGraph? _showGraph = null;
        private void ButtonGenGraph_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textGenGraphBox.Text);
            _graph = new Graph(n);
            _graph.GenGraph();
            _showGraph = new ShowGraph(_graph, 200, 200);
            _canvas.InsertGraph(_showGraph);
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
            }
            pictureBox1.Image = _canvas.DrawCanvas();
        }

    }
}
