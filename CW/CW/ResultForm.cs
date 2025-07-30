using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW
{
    public partial class ResultForm : Form
    {
        private int score;
        private int total;
        private double time;
        private List<BaseQuestion> questions;
        private List<string> playerAnswers;
        public MainForm mainForm;
        public ResultForm(int score, int total, double time, List<BaseQuestion> questions, List<string> playerAnswers)
        {
            InitializeComponent();
            this.score = score;
            this.total = total;
            this.time = time;
            this.questions = questions;
            this.playerAnswers = playerAnswers ?? new List<string>();
        }


        private void ResultForm_Load(object sender, EventArgs e)
        {
            lblScore.Text = $"Score: {score}/{total}";
            lblTime.Text = $"Time: {time:F2} minutes";
            rtbAnswers.Text = "";
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newPlay = new PlayForm(mainForm, questions);
            
            newPlay.Show();
            this.Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (mainForm != null)
            {
                mainForm.Show(); 
            }
            else
            {
                
                mainForm = new MainForm();
                mainForm.Show();
            }
            this.Close();
        }

        private void btnShowAnswers_Click(object sender, EventArgs e)
        {
            rtbAnswers.Text = GetAllAnswers();
        }

        private string GetAllAnswers()
        {
            StringBuilder allAnswers = new StringBuilder();

            for (int i = 0; i < questions.Count; i++)
            {
                var q = questions[i];
                string playerAnswer = i < playerAnswers.Count ? playerAnswers[i] : "Không có đáp án";

                allAnswers.AppendLine($"Question {i + 1}: {q.Text}");

                if (q is MultipleChoiceQuestion mcqForAnswer && int.TryParse(playerAnswer, out int answerIndex) &&
                answerIndex >= 0 && answerIndex < mcqForAnswer.Options.Count)
                {
                    playerAnswer = $"Option {Convert.ToChar('A' + answerIndex)}";
                }

                allAnswers.AppendLine($" - Your Answer: {playerAnswer}");

                if (q is OpenEndedQuestion open)
                {
                    allAnswers.AppendLine($" - Correct Answer: {string.Join(", ", open.AcceptableAnswers)}");
                }
                else if (q is TrueFalseQuestion tf)
                {
                    allAnswers.AppendLine($" - Correct Answer: {(tf.TrueFalseAnswer ? "True" : "False")}");
                }
                else if (q is MultipleChoiceQuestion mcq)
                {
                    for (int j = 0; j < mcq.Options.Count; j++)
                    {
                        string correctMark = (j == mcq.CorrectOptionIndex) ? " (Correct)" : "";
                        allAnswers.AppendLine($" - Option {Convert.ToChar('A' + j)}: {mcq.Options[j]}{correctMark}");
                    }
                }

                allAnswers.AppendLine();
            }

            return allAnswers.ToString();
        }
    

}
}
