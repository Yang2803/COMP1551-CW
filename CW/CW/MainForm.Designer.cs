namespace CW
{
    partial class MainForm
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
            btnCreate = new Button();
            btnPlay = new Button();
            comboBoxQuestionSets = new ComboBox();
            btnPlaySelectedSet = new Button();
            btnDeleteSet = new Button();
            label1 = new Label();
            btnEditSet = new Button();
            chkShuffle = new CheckBox();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(255, 192, 128);
            btnCreate.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            btnCreate.Location = new Point(205, 519);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(175, 84);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create New";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.FromArgb(128, 255, 255);
            btnPlay.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlay.Location = new Point(445, 519);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(165, 84);
            btnPlay.TabIndex = 1;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += btnPlay_Click;
            // 
            // comboBoxQuestionSets
            // 
            comboBoxQuestionSets.BackColor = Color.Black;
            comboBoxQuestionSets.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxQuestionSets.ForeColor = Color.White;
            comboBoxQuestionSets.FormattingEnabled = true;
            comboBoxQuestionSets.Location = new Point(325, 189);
            comboBoxQuestionSets.Name = "comboBoxQuestionSets";
            comboBoxQuestionSets.Size = new Size(182, 33);
            comboBoxQuestionSets.TabIndex = 2;
            comboBoxQuestionSets.SelectedIndexChanged += comboBoxQuestionSets_SelectedIndexChanged;
            // 
            // btnPlaySelectedSet
            // 
            btnPlaySelectedSet.BackColor = Color.FromArgb(192, 255, 192);
            btnPlaySelectedSet.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlaySelectedSet.Location = new Point(205, 337);
            btnPlaySelectedSet.Name = "btnPlaySelectedSet";
            btnPlaySelectedSet.Size = new Size(187, 41);
            btnPlaySelectedSet.TabIndex = 3;
            btnPlaySelectedSet.Text = "Play Selected Set";
            btnPlaySelectedSet.UseVisualStyleBackColor = false;
            btnPlaySelectedSet.Click += btnPlaySelectedSet_Click;
            // 
            // btnDeleteSet
            // 
            btnDeleteSet.BackColor = Color.FromArgb(255, 128, 128);
            btnDeleteSet.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteSet.Location = new Point(303, 423);
            btnDeleteSet.Name = "btnDeleteSet";
            btnDeleteSet.Size = new Size(193, 44);
            btnDeleteSet.TabIndex = 4;
            btnDeleteSet.Text = "Delete Selected Set";
            btnDeleteSet.UseVisualStyleBackColor = false;
            btnDeleteSet.Click += btnDeleteSet_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(341, 128);
            label1.Name = "label1";
            label1.Size = new Size(155, 30);
            label1.TabIndex = 5;
            label1.Text = "Question Sets";
            // 
            // btnEditSet
            // 
            btnEditSet.BackColor = Color.FromArgb(255, 192, 255);
            btnEditSet.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditSet.Location = new Point(429, 337);
            btnEditSet.Name = "btnEditSet";
            btnEditSet.Size = new Size(192, 41);
            btnEditSet.TabIndex = 6;
            btnEditSet.Text = "Edit Selected Set";
            btnEditSet.UseVisualStyleBackColor = false;
            btnEditSet.Click += btnEditSet_Click;
            // 
            // chkShuffle
            // 
            chkShuffle.AutoSize = true;
            chkShuffle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            chkShuffle.ForeColor = SystemColors.ButtonHighlight;
            chkShuffle.Location = new Point(318, 267);
            chkShuffle.Name = "chkShuffle";
            chkShuffle.Size = new Size(206, 32);
            chkShuffle.TabIndex = 7;
            chkShuffle.Text = "Shuffle Questions";
            chkShuffle.UseVisualStyleBackColor = true;
            chkShuffle.CheckedChanged += chkShuffle_CheckedChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.istockphoto_1154425711_612x612;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 749);
            Controls.Add(chkShuffle);
            Controls.Add(btnEditSet);
            Controls.Add(label1);
            Controls.Add(btnDeleteSet);
            Controls.Add(btnPlaySelectedSet);
            Controls.Add(comboBoxQuestionSets);
            Controls.Add(btnPlay);
            Controls.Add(btnCreate);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate;
        private Button btnPlay;
        private ComboBox comboBoxQuestionSets;
        private Button btnPlaySelectedSet;
        private Button btnDeleteSet;
        private Label label1;
        private Button btnEditSet;
        private CheckBox chkShuffle;
    }
}