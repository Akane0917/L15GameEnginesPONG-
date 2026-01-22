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
            components = new System.ComponentModel.Container();
            p1ScoreLabel = new Label();
            p2ScoreLabel = new Label();
            winLabel = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
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
            // p2ScoreLabel
            // 
            p2ScoreLabel.ForeColor = Color.White;
            p2ScoreLabel.Location = new Point(287, 9);
            p2ScoreLabel.Name = "p2ScoreLabel";
            p2ScoreLabel.Size = new Size(35, 28);
            p2ScoreLabel.TabIndex = 1;
            p2ScoreLabel.Text = "0";
            p2ScoreLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimer_Tick_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(584, 361);
            Controls.Add(winLabel);
            Controls.Add(p2ScoreLabel);
            Controls.Add(p1ScoreLabel);
            DoubleBuffered = true;
            Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Click += Form1_Click;
            Paint += Form1_Paint;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ResumeLayout(false);
        }

        #endregion

        private Label p1ScoreLabel;
        private Label p2ScoreLabel;
        private Label winLabel;
        private System.Windows.Forms.Timer gameTimer;
    }
}
