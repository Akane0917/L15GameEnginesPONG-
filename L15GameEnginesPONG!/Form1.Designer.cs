namespace L15GameEnginesPONG_
{
    partial class Form1
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
            p1ScoreLabel = new Label();
            label1 = new Label();
            winLabel = new Label();
            SuspendLayout();
            // 
            // p1ScoreLabel
            // 
            p1ScoreLabel.ForeColor = Color.White;
            p1ScoreLabel.Location = new Point(246, 9);
            p1ScoreLabel.Name = "p1ScoreLabel";
            p1ScoreLabel.Size = new Size(35, 28);
            p1ScoreLabel.TabIndex = 0;
            p1ScoreLabel.Text = "0";
            p1ScoreLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.ForeColor = Color.White;
            label1.Location = new Point(287, 9);
            label1.Name = "label1";
            label1.Size = new Size(35, 28);
            label1.TabIndex = 1;
            label1.Text = "0";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // winLabel
            // 
            winLabel.ForeColor = Color.White;
            winLabel.Location = new Point(194, 156);
            winLabel.Name = "winLabel";
            winLabel.Size = new Size(199, 28);
            winLabel.TabIndex = 2;
            winLabel.Text = "0";
            winLabel.TextAlign = ContentAlignment.MiddleCenter;
            winLabel.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(584, 361);
            Controls.Add(winLabel);
            Controls.Add(label1);
            Controls.Add(p1ScoreLabel);
            DoubleBuffered = true;
            Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label p1ScoreLabel;
        private Label label1;
        private Label winLabel;
    }
}
