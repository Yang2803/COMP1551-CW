namespace CW
{
    partial class ResultForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblScore = new Label();
            lblTime = new Label();
            btnShowAnswers = new Button();
            btnExit = new Button();
            btnRestart = new Button();
            rtbAnswers = new RichTextBox();
            SuspendLayout();
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = SystemColors.ActiveCaptionText;
            lblScore.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            lblScore.ForeColor = SystemColors.ButtonHighlight;
            lblScore.Location = new Point(440, 56);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(60, 25);
            lblScore.TabIndex = 0;
            lblScore.Text = "Score";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.BackColor = SystemColors.ActiveCaptionText;
            lblTime.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            lblTime.ForeColor = SystemColors.ButtonHighlight;
            lblTime.Location = new Point(546, 56);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(56, 25);
            lblTime.TabIndex = 1;
            lblTime.Text = "Time";
            // 
            // btnShowAnswers
            // 
            btnShowAnswers.BackColor = SystemColors.ActiveCaptionText;
            btnShowAnswers.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowAnswers.ForeColor = Color.FromArgb(255, 128, 255);
            btnShowAnswers.Location = new Point(440, 154);
            btnShowAnswers.Name = "btnShowAnswers";
            btnShowAnswers.Size = new Size(287, 42);
            btnShowAnswers.TabIndex = 2;
            btnShowAnswers.Text = "Show Answer";
            btnShowAnswers.UseVisualStyleBackColor = false;
            btnShowAnswers.Click += btnShowAnswers_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ActiveCaptionText;
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.FromArgb(255, 128, 128);
            btnExit.Location = new Point(448, 361);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(279, 39);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnRestart
            // 
            btnRestart.BackColor = SystemColors.ActiveCaptionText;
            btnRestart.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRestart.ForeColor = Color.Cyan;
            btnRestart.Location = new Point(440, 260);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(287, 38);
            btnRestart.TabIndex = 4;
            btnRestart.Text = "Restart ";
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Click += btnRestart_Click;
            // 
            // rtbAnswers
            // 
            rtbAnswers.BackColor = SystemColors.ActiveCaptionText;
            rtbAnswers.BorderStyle = BorderStyle.None;
            rtbAnswers.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtbAnswers.ForeColor = Color.White;
            rtbAnswers.Location = new Point(80, 104);
            rtbAnswers.Name = "rtbAnswers";
            rtbAnswers.ReadOnly = true;
            rtbAnswers.Size = new Size(279, 249);
            rtbAnswers.TabIndex = 5;
            rtbAnswers.Text = "";
            // 
            // ResultForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.images;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbAnswers);
            Controls.Add(btnRestart);
            Controls.Add(btnExit);
            Controls.Add(btnShowAnswers);
            Controls.Add(lblTime);
            Controls.Add(lblScore);
            Name = "ResultForm";
            Text = "ResultForm";
            Load += ResultForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblScore;
        private Label lblTime;
        private Button btnShowAnswers;
        private Button btnExit;
        private Button btnRestart;
        private RichTextBox rtbAnswers;
    }
}