namespace CW
{
    partial class CreateForm
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
            txtQuestion = new TextBox();
            txtA = new TextBox();
            txtB = new TextBox();
            txtD = new TextBox();
            txtC = new TextBox();
            comboCorrect = new ComboBox();
            btnAdd = new Button();
            lstQuestions = new ListBox();
            lblQuestion = new Label();
            lblCorrect = new Label();
            btnDelete = new Button();
            btnEdit = new Button();
            btnBack = new Button();
            chkOpenEnded = new CheckBox();
            txtAcceptableAnswers = new TextBox();
            lblAcceptable = new Label();
            chkTrueFalse = new CheckBox();
            comboTrueFalseAnswer = new ComboBox();
            lblTrueFalse = new Label();
            btnSaveJson = new Button();
            SuspendLayout();
            // 
            // txtQuestion
            // 
            txtQuestion.BackColor = Color.White;
            txtQuestion.ForeColor = SystemColors.InactiveCaptionText;
            txtQuestion.Location = new Point(232, 98);
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(339, 31);
            txtQuestion.TabIndex = 0;
            // 
            // txtA
            // 
            txtA.BackColor = SystemColors.HighlightText;
            txtA.Location = new Point(187, 261);
            txtA.Name = "txtA";
            txtA.Size = new Size(150, 31);
            txtA.TabIndex = 1;
            // 
            // txtB
            // 
            txtB.BackColor = SystemColors.HighlightText;
            txtB.Location = new Point(482, 261);
            txtB.Name = "txtB";
            txtB.Size = new Size(150, 31);
            txtB.TabIndex = 2;
            // 
            // txtD
            // 
            txtD.BackColor = SystemColors.HighlightText;
            txtD.Location = new Point(482, 337);
            txtD.Name = "txtD";
            txtD.Size = new Size(150, 31);
            txtD.TabIndex = 3;
            // 
            // txtC
            // 
            txtC.BackColor = SystemColors.HighlightText;
            txtC.Location = new Point(187, 337);
            txtC.Name = "txtC";
            txtC.Size = new Size(150, 31);
            txtC.TabIndex = 4;
            // 
            // comboCorrect
            // 
            comboCorrect.FormattingEnabled = true;
            comboCorrect.Items.AddRange(new object[] { "A", "B", "C", "D" });
            comboCorrect.Location = new Point(321, 408);
            comboCorrect.Name = "comboCorrect";
            comboCorrect.Size = new Size(182, 33);
            comboCorrect.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkMagenta;
            btnAdd.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(162, 476);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lstQuestions
            // 
            lstQuestions.FormattingEnabled = true;
            lstQuestions.ItemHeight = 25;
            lstQuestions.Location = new Point(295, 527);
            lstQuestions.Name = "lstQuestions";
            lstQuestions.Size = new Size(180, 129);
            lstQuestions.TabIndex = 7;
            lstQuestions.SelectedIndexChanged += lstQuestions_SelectedIndexChanged;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.BackColor = Color.Black;
            lblQuestion.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuestion.ForeColor = Color.White;
            lblQuestion.Location = new Point(268, 55);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(278, 30);
            lblQuestion.TabIndex = 8;
            lblQuestion.Text = "Enter your Question";
            // 
            // lblCorrect
            // 
            lblCorrect.AutoSize = true;
            lblCorrect.Font = new Font("UTM Windsor BT", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCorrect.ForeColor = SystemColors.ButtonHighlight;
            lblCorrect.Location = new Point(321, 202);
            lblCorrect.Name = "lblCorrect";
            lblCorrect.Size = new Size(178, 28);
            lblCorrect.TabIndex = 9;
            lblCorrect.Text = "Correct Answer:";
            lblCorrect.Click += lblCorrect_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(338, 476);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Goldenrod;
            btnEdit.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = SystemColors.ButtonHighlight;
            btnEdit.Location = new Point(515, 476);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.LightSeaGreen;
            btnBack.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(515, 569);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 12;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // chkOpenEnded
            // 
            chkOpenEnded.AutoSize = true;
            chkOpenEnded.BackColor = Color.Black;
            chkOpenEnded.Font = new Font("UTM Windsor BT", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkOpenEnded.ForeColor = SystemColors.ButtonHighlight;
            chkOpenEnded.Location = new Point(221, 150);
            chkOpenEnded.Name = "chkOpenEnded";
            chkOpenEnded.Size = new Size(153, 32);
            chkOpenEnded.TabIndex = 13;
            chkOpenEnded.Text = "open-ended";
            chkOpenEnded.UseVisualStyleBackColor = false;
            chkOpenEnded.CheckedChanged += chkOpenEnded_CheckedChanged;
            // 
            // txtAcceptableAnswers
            // 
            txtAcceptableAnswers.BackColor = SystemColors.HighlightText;
            txtAcceptableAnswers.Location = new Point(268, 330);
            txtAcceptableAnswers.Name = "txtAcceptableAnswers";
            txtAcceptableAnswers.Size = new Size(328, 31);
            txtAcceptableAnswers.TabIndex = 14;
            txtAcceptableAnswers.Visible = false;
            // 
            // lblAcceptable
            // 
            lblAcceptable.AutoSize = true;
            lblAcceptable.Font = new Font("UTM Windsor BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAcceptable.ForeColor = SystemColors.ButtonHighlight;
            lblAcceptable.Location = new Point(77, 334);
            lblAcceptable.Name = "lblAcceptable";
            lblAcceptable.Size = new Size(158, 25);
            lblAcceptable.TabIndex = 15;
            lblAcceptable.Text = "Correct answer:";
            lblAcceptable.Visible = false;
            // 
            // chkTrueFalse
            // 
            chkTrueFalse.AutoSize = true;
            chkTrueFalse.BackColor = Color.Black;
            chkTrueFalse.Font = new Font("UTM Windsor BT", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkTrueFalse.ForeColor = SystemColors.ButtonHighlight;
            chkTrueFalse.Location = new Point(405, 150);
            chkTrueFalse.Name = "chkTrueFalse";
            chkTrueFalse.Size = new Size(242, 32);
            chkTrueFalse.TabIndex = 16;
            chkTrueFalse.Text = "True/False Question";
            chkTrueFalse.UseVisualStyleBackColor = false;
            // 
            // comboTrueFalseAnswer
            // 
            comboTrueFalseAnswer.BackColor = SystemColors.HighlightText;
            comboTrueFalseAnswer.FormattingEnabled = true;
            comboTrueFalseAnswer.Items.AddRange(new object[] { "True", "False" });
            comboTrueFalseAnswer.Location = new Point(342, 259);
            comboTrueFalseAnswer.Name = "comboTrueFalseAnswer";
            comboTrueFalseAnswer.Size = new Size(182, 33);
            comboTrueFalseAnswer.TabIndex = 17;
            comboTrueFalseAnswer.Visible = false;
            // 
            // lblTrueFalse
            // 
            lblTrueFalse.AutoSize = true;
            lblTrueFalse.Font = new Font("UTM Windsor BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTrueFalse.ForeColor = SystemColors.ButtonHighlight;
            lblTrueFalse.Location = new Point(37, 261);
            lblTrueFalse.Name = "lblTrueFalse";
            lblTrueFalse.Size = new Size(296, 25);
            lblTrueFalse.TabIndex = 18;
            lblTrueFalse.Text = "Correct answer for True/False:";
            lblTrueFalse.Visible = false;
            lblTrueFalse.Click += lblTrueFalse_Click;
            // 
            // btnSaveJson
            // 
            btnSaveJson.BackColor = Color.FromArgb(255, 192, 128);
            btnSaveJson.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveJson.Location = new Point(304, 675);
            btnSaveJson.Name = "btnSaveJson";
            btnSaveJson.Size = new Size(159, 34);
            btnSaveJson.TabIndex = 19;
            btnSaveJson.Text = "Add to list";
            btnSaveJson.UseVisualStyleBackColor = false;
            btnSaveJson.Click += btnSaveJson_Click;
            // 
            // CreateForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.images__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 749);
            Controls.Add(btnSaveJson);
            Controls.Add(lblTrueFalse);
            Controls.Add(comboTrueFalseAnswer);
            Controls.Add(chkTrueFalse);
            Controls.Add(lblAcceptable);
            Controls.Add(txtAcceptableAnswers);
            Controls.Add(chkOpenEnded);
            Controls.Add(btnBack);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(lblCorrect);
            Controls.Add(lblQuestion);
            Controls.Add(lstQuestions);
            Controls.Add(btnAdd);
            Controls.Add(comboCorrect);
            Controls.Add(txtC);
            Controls.Add(txtD);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(txtQuestion);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "CreateForm";
            Text = "CreateForm";
            Load += CreateForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtQuestion;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtD;
        private TextBox txtC;
        private ComboBox comboCorrect;
        private Button btnAdd;
        private ListBox lstQuestions;
        private Label lblQuestion;
        private Label lblCorrect;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnBack;
        private CheckBox chkOpenEnded;
        private TextBox txtAcceptableAnswers;
        private Label lblAcceptable;
        private CheckBox chkTrueFalse;

        private ComboBox comboTrueFalseAnswer;
        private Label lblTrueFalse;
        private Button btnSaveJson;
    }
}