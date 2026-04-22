namespace Cursovaya
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            groupBox = new GroupBox();
            buttonStep = new Button();
            label1 = new Label();
            textGenGraphBox = new TextBox();
            buttonGenGraph = new Button();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            menuStrip1 = new MenuStrip();
            resultToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 28);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(914, 572);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(buttonStep);
            groupBox.Controls.Add(label1);
            groupBox.Controls.Add(textGenGraphBox);
            groupBox.Controls.Add(buttonGenGraph);
            groupBox.Dock = DockStyle.Right;
            groupBox.Location = new Point(685, 28);
            groupBox.Margin = new Padding(3, 4, 3, 4);
            groupBox.Name = "groupBox";
            groupBox.Padding = new Padding(3, 4, 3, 4);
            groupBox.Size = new Size(229, 572);
            groupBox.TabIndex = 1;
            groupBox.TabStop = false;
            groupBox.Text = "Инструменты";
            // 
            // buttonStep
            // 
            buttonStep.Location = new Point(35, 372);
            buttonStep.Margin = new Padding(3, 4, 3, 4);
            buttonStep.Name = "buttonStep";
            buttonStep.Size = new Size(159, 56);
            buttonStep.TabIndex = 3;
            buttonStep.Text = "Шаг по Приму";
            buttonStep.UseVisualStyleBackColor = true;
            buttonStep.Click += ButtonStep_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 93);
            label1.Name = "label1";
            label1.Size = new Size(169, 20);
            label1.TabIndex = 2;
            label1.Text = "Сколько узлов в графе:";
            // 
            // textGenGraphBox
            // 
            textGenGraphBox.Location = new Point(7, 133);
            textGenGraphBox.Margin = new Padding(3, 4, 3, 4);
            textGenGraphBox.Name = "textGenGraphBox";
            textGenGraphBox.Size = new Size(214, 27);
            textGenGraphBox.TabIndex = 1;
            // 
            // buttonGenGraph
            // 
            buttonGenGraph.Location = new Point(7, 211);
            buttonGenGraph.Margin = new Padding(3, 4, 3, 4);
            buttonGenGraph.Name = "buttonGenGraph";
            buttonGenGraph.Size = new Size(215, 31);
            buttonGenGraph.TabIndex = 0;
            buttonGenGraph.Text = "Сгенерировать граф";
            buttonGenGraph.UseVisualStyleBackColor = true;
            buttonGenGraph.Click += ButtonGenGraph_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { resultToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(914, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // resultToolStripMenuItem
            // 
            resultToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, loadToolStripMenuItem });
            resultToolStripMenuItem.Name = "resultToolStripMenuItem";
            resultToolStripMenuItem.Size = new Size(89, 24);
            resultToolStripMenuItem.Text = "Результат";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(224, 26);
            saveToolStripMenuItem.Text = "Сохранить";
            saveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(224, 26);
            loadToolStripMenuItem.Text = "Загрузить";
            loadToolStripMenuItem.Click += LoadToolStripMenuItem_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(groupBox);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox;
        private Button buttonStep;
        private Label label1;
        private TextBox textGenGraphBox;
        private Button buttonGenGraph;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem resultToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
    }
}
