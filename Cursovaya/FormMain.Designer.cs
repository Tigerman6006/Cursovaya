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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
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
            groupBox.Location = new Point(600, 0);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(200, 450);
            groupBox.TabIndex = 1;
            groupBox.TabStop = false;
            groupBox.Text = "Инструменты";
            // 
            // buttonStep
            // 
            buttonStep.Location = new Point(31, 279);
            buttonStep.Name = "buttonStep";
            buttonStep.Size = new Size(139, 42);
            buttonStep.TabIndex = 3;
            buttonStep.Text = "Шаг по Приму";
            buttonStep.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 70);
            label1.Name = "label1";
            label1.Size = new Size(136, 15);
            label1.TabIndex = 2;
            label1.Text = "Сколько узлов в графе:";
            // 
            // textGenGraphBox
            // 
            textGenGraphBox.Location = new Point(6, 100);
            textGenGraphBox.Name = "textGenGraphBox";
            textGenGraphBox.Size = new Size(188, 23);
            textGenGraphBox.TabIndex = 1;
            // 
            // buttonGenGraph
            // 
            buttonGenGraph.Location = new Point(6, 158);
            buttonGenGraph.Name = "buttonGenGraph";
            buttonGenGraph.Size = new Size(188, 23);
            buttonGenGraph.TabIndex = 0;
            buttonGenGraph.Text = "Сгенерировать граф";
            buttonGenGraph.UseVisualStyleBackColor = true;
            buttonGenGraph.Click += ButtonGenGraph_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox);
            Controls.Add(pictureBox1);
            Name = "FormMain";
            Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox;
        private Button buttonStep;
        private Label label1;
        private TextBox textGenGraphBox;
        private Button buttonGenGraph;
    }
}
