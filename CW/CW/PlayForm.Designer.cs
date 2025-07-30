namespace CW
{
    partial class PlayForm
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
            lblQuestion = new Label();
            btnA = new Button();
            btnB = new Button();
            btnC = new Button();
            btnD = new Button();
            lblProgress = new Label();
            txtAnswer = new TextBox();
            btnSubmit = new Button();
            btnTrue = new Button();
            btnFalse = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.BackColor = SystemColors.ActiveCaptionText;
            lblQuestion.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblQuestion.ForeColor = SystemColors.ButtonHighlight;
            lblQuestion.Location = new Point(342, 30);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(65, 25);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "label1";
            // 
            // btnA
            // 
            btnA.BackColor = Color.FromArgb(255, 192, 192);
            btnA.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnA.Location = new Point(205, 179);
            btnA.Name = "btnA";
            btnA.Size = new Size(375, 34);
            btnA.TabIndex = 1;
            btnA.Text = "button1";
            btnA.UseVisualStyleBackColor = false;
            // 
            // btnB
            // 
            btnB.BackColor = Color.FromArgb(255, 224, 192);
            btnB.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnB.Location = new Point(205, 219);
            btnB.Name = "btnB";
            btnB.Size = new Size(375, 34);
            btnB.TabIndex = 2;
            btnB.Text = "button2";
            btnB.UseVisualStyleBackColor = false;
            // 
            // btnC
            // 
            btnC.BackColor = Color.FromArgb(255, 255, 192);
            btnC.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnC.Location = new Point(205, 259);
            btnC.Name = "btnC";
            btnC.Size = new Size(375, 34);
            btnC.TabIndex = 3;
            btnC.Text = "button3";
            btnC.UseVisualStyleBackColor = false;
            // 
            // btnD
            // 
            btnD.BackColor = Color.FromArgb(192, 255, 192);
            btnD.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnD.Location = new Point(205, 299);
            btnD.Name = "btnD";
            btnD.Size = new Size(375, 34);
            btnD.TabIndex = 4;
            btnD.Text = "button4";
            btnD.UseVisualStyleBackColor = false;
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.BackColor = SystemColors.ActiveCaptionText;
            lblProgress.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProgress.ForeColor = SystemColors.ButtonHighlight;
            lblProgress.Location = new Point(128, 346);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(40, 25);
            lblProgress.TabIndex = 5;
            lblProgress.Text = "x/x";
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(248, 124);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(150, 31);
            txtAnswer.TabIndex = 6;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.RosyBrown;
            btnSubmit.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(433, 124);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnTrue
            // 
            btnTrue.BackColor = Color.FromArgb(128, 255, 255);
            btnTrue.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTrue.Location = new Point(248, 193);
            btnTrue.Name = "btnTrue";
            btnTrue.Size = new Size(112, 34);
            btnTrue.TabIndex = 8;
            btnTrue.Text = "True";
            btnTrue.UseVisualStyleBackColor = false;
            btnTrue.Visible = false;
            // 
            // btnFalse
            // 
            btnFalse.BackColor = Color.IndianRed;
            btnFalse.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFalse.Location = new Point(407, 193);
            btnFalse.Name = "btnFalse";
            btnFalse.Size = new Size(112, 34);
            btnFalse.TabIndex = 9;
            btnFalse.Text = "False";
            btnFalse.UseVisualStyleBackColor = false;
            btnFalse.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(144, 27);
            label1.Name = "label1";
            label1.Size = new Size(107, 28);
            label1.TabIndex = 10;
            label1.Text = "Question:";
            // 
            // PlayForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._360_F_800907698_me7E7Myku6HLPJ9Hzjn5tW3nC9sNKDNF;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnFalse);
            Controls.Add(btnTrue);
            Controls.Add(btnSubmit);
            Controls.Add(txtAnswer);
            Controls.Add(lblProgress);
            Controls.Add(btnD);
            Controls.Add(btnC);
            Controls.Add(btnB);
            Controls.Add(btnA);
            Controls.Add(lblQuestion);
            Name = "PlayForm";
            Text = "PlayForm";
            Load += PlayForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuestion;
        private Button btnA;
        private Button btnB;
        private Button btnC;
        private Button btnD;
        private Label lblProgress;
        private TextBox txtAnswer;
        private Button btnSubmit;
        private Button btnTrue;
        private Button btnFalse;
        private Label label1;
    }
}