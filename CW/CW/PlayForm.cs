using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace CW
{
    public partial class PlayForm : Form
    {
        private List<BaseQuestion> questions;
        private int currentIndex = 0;
        private int score = 0;
        private DateTime startTime;
        private BaseQuestion? currentQuestion;
        private bool isGameEnded = false;
        private List<string> playerAnswers = new List<string>(); 
        private MainForm mainForm;

        public PlayForm(MainForm mainForm, List<BaseQuestion> list, bool isShuffled = false)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            questions = new List<BaseQuestion>(list ?? new List<BaseQuestion>());
            if (isShuffled)
            {
                questions = questions.OrderBy(q => Guid.NewGuid()).ToList(); 
                
            }
            if (questions.Count == 0)
            {
                MessageBox.Show("Don't have any question to play", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            startTime = DateTime.Now;

            btnA.Click += Answer_Click;
            btnB.Click += Answer_Click;
            btnC.Click += Answer_Click;
            btnD.Click += Answer_Click;
            btnSubmit.Click += btnSubmit_Click;
            btnTrue.Click += Answer_TrueFalse_Click;
            btnFalse.Click += Answer_TrueFalse_Click;

            ShowNextQuestion();
        }

        private void ShowNextQuestion()
        {
            while (currentIndex < questions.Count && questions[currentIndex] == null)
            {
                currentIndex++;
            }

            if (isGameEnded || currentIndex >= questions.Count)
            {
                EndGame();
                return;
            }

            currentQuestion = questions[currentIndex];
            lblQuestion.Text = currentQuestion.Text;
            lblProgress.Text = $"Question {currentIndex + 1}/{questions.Count}";

            txtAnswer.Visible = btnSubmit.Visible = false;
            btnA.Visible = btnB.Visible = btnC.Visible = btnD.Visible = false;
            btnTrue.Visible = btnFalse.Visible = false;

            if (currentQuestion is OpenEndedQuestion openQ)
            {
                txtAnswer.Visible = btnSubmit.Visible = true;
                btnSubmit.Enabled = true;
                txtAnswer.Clear();

                string suffix = openQ.AcceptableAnswers.Any()
                    ? " (Enter your answer)"
                    : " (No valid answer — Enter your answer anyway)";

                lblQuestion.Text += suffix;
            }
            else if (currentQuestion is TrueFalseQuestion)
            {
                btnTrue.Visible = btnFalse.Visible = true;
            }
            else if (currentQuestion is MultipleChoiceQuestion mcq && mcq.Options.Count >= 4)
            {
                btnA.Visible = btnB.Visible = btnC.Visible = btnD.Visible = true;
                btnA.Text = "A: " + mcq.Options[0];
                btnB.Text = "B: " + mcq.Options[1];
                btnC.Text = "C: " + mcq.Options[2];
                btnD.Text = "D: " + mcq.Options[3];
            }
            else
            {
                MessageBox.Show("Invalid question format. Skipping...", "Warning", MessageBoxButtons.OK);
                currentIndex++;
                ShowNextQuestion();
            }
        }

            
        

        private void Answer_TrueFalse_Click(object sender, EventArgs e)
        {
            string answer = (sender == btnTrue) ? "true" : "false";
            playerAnswers.Add(answer);

            if (currentQuestion.CheckAnswer(answer))
                score++;

            currentIndex++;
            ShowNextQuestion();
        }


        private void Answer_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int selected = (btn == btnA) ? 0 : (btn == btnB) ? 1 : (btn == btnC) ? 2 : 3;
            playerAnswers.Add(selected.ToString());

            if (currentQuestion.CheckAnswer(selected.ToString()))
                score++;

            currentIndex++;
            ShowNextQuestion();
        }

        private void EndGame()
        {
            if (isGameEnded) return;
            isGameEnded = true;

            double minutes = (DateTime.Now - startTime).TotalMinutes;
            var result = new ResultForm(score, questions.Count, minutes, questions, playerAnswers)
            {
                mainForm = this.mainForm 
            };
            result.Show();
            this.Close();
        }


        private void PlayForm_Load(object sender, EventArgs e)
        {

        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (isGameEnded || currentQuestion == null) return;

            btnSubmit.Enabled = false;
            string userAnswer = BaseQuestion.Normalize(txtAnswer.Text.Trim());
            
            playerAnswers.Add(userAnswer);

            if (currentQuestion.CheckAnswer(userAnswer))
                score++;

            txtAnswer.Clear();
            currentIndex++;
            ShowNextQuestion();
        }


    }
}
