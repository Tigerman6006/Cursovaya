using System.Collections;
using System.Windows.Forms;

namespace Cursovaya
{
    public partial class FormMain : Form
    {
        private readonly CursCanvas _canvas;
        Prim? prim;
        IEnumerator? stepExecutor;
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
            prim = new Prim(n, _graph);
            stepExecutor = prim.StepByStep().GetEnumerator();
            _showGraph = new ShowGraph(_graph, 200, 200);
            _canvas.InsertGraph(_showGraph);
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
            }
            pictureBox1.Image = _canvas.DrawCanvas();
        }
        private void ButtonStep_Click(object sender, EventArgs e)
        {
            if(stepExecutor == null || prim == null)
            {
                return;
            }
            if (stepExecutor.MoveNext())
            {
                pictureBox1.Image = _canvas.DrawCanvas();
                Console.WriteLine($"Текущий вес: {prim.TotalMinCost}");
            }
            else
            {
                MessageBox.Show($"Остовное дерево построено! Итоговый вес: {prim.TotalMinCost}");
                _canvas.minost = prim.TotalMinCost;
                pictureBox1.Image = _canvas.DrawCanvas();
            }
        }
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (prim?.SaveMinCost(saveFileDialog.FileName)==true)
                {
                    MessageBox.Show("Сохранение прошло успешно",
                    "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Обработка нажатия "Загрузка"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                int? loaded = prim?.LoadMinCost(openFileDialog.FileName);
                if (loaded>0)
                {
                    MessageBox.Show("Загрузка прошла успешно",
                    "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _canvas.minost = (int)loaded;
                    pictureBox1.Image = _canvas.DrawCanvas();
                }
                else
                {
                    MessageBox.Show("Не загрузилось", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
