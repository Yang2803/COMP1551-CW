using Newtonsoft.Json;
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

    public partial class CreateForm : Form
    {

        private List<BaseQuestion> questionList;
        private int selectedIndex = -1;
        public CreateForm(List<BaseQuestion> questions)
        {
            InitializeComponent();
            questionList = questions;
            RefreshList();
        }

        private void CreateForm_Load(object sender, EventArgs e)
        {
            comboCorrect.Items.Clear();
            comboCorrect.Items.Add("A");
            comboCorrect.Items.Add("B");
            comboCorrect.Items.Add("C");
            comboCorrect.Items.Add("D");
            comboCorrect.SelectedIndex = 0;

            chkTrueFalse.CheckedChanged += chkTrueFalse_CheckedChanged;


            comboTrueFalseAnswer.Items.Clear();
            comboTrueFalseAnswer.Items.Add("True");
            comboTrueFalseAnswer.Items.Add("False");
            comboTrueFalseAnswer.SelectedIndex = -1;
        }



        private void chkOpenEnded_CheckedChanged(object sender, EventArgs e)
        {
            UpdateQuestionTypeUI();
        }

        private void chkTrueFalse_CheckedChanged(object sender, EventArgs e)
        {
            UpdateQuestionTypeUI();
        }

        private void UpdateQuestionTypeUI()
        {
            bool isOpen = chkOpenEnded.Checked;
            bool isTrueFalse = chkTrueFalse.Checked;

            //Multiple choice
            bool isMultiple = !isOpen && !isTrueFalse;

            txtA.Visible = txtB.Visible = txtC.Visible = txtD.Visible = comboCorrect.Visible = isMultiple;

            //open-ended
            txtAcceptableAnswers.Visible = lblAcceptable.Visible = isOpen;

            //true false
            comboTrueFalseAnswer.Visible = lblTrueFalse.Visible = isTrueFalse;
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuestion.Text))
            {
                MessageBox.Show("Please enter your Question");
                return;
            }

            string questionText = txtQuestion.Text.Trim();

            if (chkOpenEnded.Checked)
            {
                var rawAnswers = txtAcceptableAnswers.Text.Split(';');
                var acceptedAnswers = rawAnswers
                    .Select(a => a.Trim())
                    .Where(a => !string.IsNullOrEmpty(a))
                    .ToList();

                if (acceptedAnswers.Count == 0)
                {
                    MessageBox.Show("Please enter at least one correct answer.");
                    return;
                }

                questionList.Add(new OpenEndedQuestion(questionText, acceptedAnswers));
            }
            else if (chkTrueFalse.Checked)
            {
                if (comboTrueFalseAnswer.SelectedItem == null)
                {
                    MessageBox.Show("Please choose 'True' or 'False'");
                    return;
                }

                bool answer = comboTrueFalseAnswer.SelectedItem.ToString() == "True";
                questionList.Add(new TrueFalseQuestion(questionText, answer));
            }
            else
            {
                List<string> options = new List<string>
        {
            txtA.Text.Trim(), txtB.Text.Trim(), txtC.Text.Trim(), txtD.Text.Trim()
        };

                if (options.Any(string.IsNullOrWhiteSpace))
                {
                    MessageBox.Show("Please enter all 4 options.");
                    return;
                }

                int correctIndex = comboCorrect.SelectedIndex;
                questionList.Add(new MultipleChoiceQuestion(questionText, options, correctIndex));
            }

            RefreshList();
            ClearForm();
        }


        private void lstQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstQuestions.SelectedIndex;

            if (index < 0 || index >= questionList.Count)
            {
                selectedIndex = -1;
                ClearForm();
                return;
            }

            selectedIndex = index;
            var q = questionList[index];
            txtQuestion.Text = q.Text;

            chkOpenEnded.Checked = false;
            chkTrueFalse.Checked = false;

            if (q is OpenEndedQuestion open)
            {
                chkOpenEnded.Checked = true;
                txtAcceptableAnswers.Text = string.Join(";", open.AcceptableAnswers);
            }
            else if (q is TrueFalseQuestion tf)
            {
                chkTrueFalse.Checked = true;
                comboTrueFalseAnswer.SelectedItem = tf.TrueFalseAnswer ? "True" : "False";
            }
            else if (q is MultipleChoiceQuestion mcq)
            {
                txtA.Text = mcq.Options[0];
                txtB.Text = mcq.Options[1];
                txtC.Text = mcq.Options[2];
                txtD.Text = mcq.Options[3];
                comboCorrect.SelectedIndex = mcq.CorrectOptionIndex;
            }

            UpdateQuestionTypeUI();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedIndex < 0 || selectedIndex >= questionList.Count)
            {
                MessageBox.Show("Please choose a question to edit");
                return;
            }

            string questionText = txtQuestion.Text.Trim();

            if (string.IsNullOrWhiteSpace(questionText))
            {
                MessageBox.Show("Please enter a question");
                return;
            }

            if (chkOpenEnded.Checked)
            {
                var rawAnswers = txtAcceptableAnswers.Text.Split(';');
                var acceptedAnswers = rawAnswers
                    .Select(a => a.Trim())
                    .Where(a => !string.IsNullOrEmpty(a))
                    .ToList();

                if (acceptedAnswers.Count == 0)
                {
                    MessageBox.Show("Please enter at least one correct answer.");
                    return;
                }

                questionList[selectedIndex] = new OpenEndedQuestion(questionText, acceptedAnswers);
            }
            else if (chkTrueFalse.Checked)
            {
                if (comboTrueFalseAnswer.SelectedItem == null)
                {
                    MessageBox.Show("Please choose 'True' or 'False'");
                    return;
                }

                bool answer = comboTrueFalseAnswer.SelectedItem.ToString() == "True";
                questionList[selectedIndex] = new TrueFalseQuestion(questionText, answer);
            }
            else
            {
                List<string> options = new List<string> {
            txtA.Text.Trim(), txtB.Text.Trim(), txtC.Text.Trim(), txtD.Text.Trim()
        };

                if (options.Any(string.IsNullOrWhiteSpace))
                {
                    MessageBox.Show("Please enter all 4 options.");
                    return;
                }

                int correctIndex = comboCorrect.SelectedIndex;
                questionList[selectedIndex] = new MultipleChoiceQuestion(questionText, options, correctIndex);
            }

            RefreshList();
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedIndex >= 0)
            {
                questionList.RemoveAt(selectedIndex);
                RefreshList();
                ClearForm();
            }
        }

        private void RefreshList()
        {
            lstQuestions.Items.Clear();
            foreach (var q in questionList)
                lstQuestions.Items.Add(q.Text);
        }

        private void ClearForm()
        {
            txtQuestion.Clear();
            txtA.Clear(); txtB.Clear(); txtC.Clear(); txtD.Clear();
            comboCorrect.SelectedIndex = 0;

            txtAcceptableAnswers.Clear();
            comboTrueFalseAnswer.SelectedIndex = -1;

            chkOpenEnded.Checked = false;
            chkTrueFalse.Checked = false;

            selectedIndex = -1;

            chkOpenEnded.Checked = false;
            chkTrueFalse.Checked = false;


            UpdateQuestionTypeUI();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveToJson(string setName = null)
        {
            if (questionList.Count == 0)
            {
                MessageBox.Show("Question list is empty.", "Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(setName))
            {
                setName = Microsoft.VisualBasic.Interaction.InputBox("Question Set's Name:", "Save this Question Set", "NewSet");
                if (string.IsNullOrWhiteSpace(setName)) setName = "UnnamedSet";
            }

            QuestionSet set = new QuestionSet
            {
                SetName = setName,
                Questions = questionList
            };

            string folderPath = Path.Combine(Application.StartupPath, "SavedQuestionSets");
            Directory.CreateDirectory(folderPath);
            string filePath = Path.Combine(folderPath, setName + ".json");

            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto,
                Formatting = Formatting.Indented
            };

            string json = JsonConvert.SerializeObject(set, settings);
            File.WriteAllText(filePath, json);

            MessageBox.Show($"'{setName}' has been saved.");


        }

        private void btnSaveJson_Click(object sender, EventArgs e)
        {
            SaveToJson();
        }

        private void lblCorrect_Click(object sender, EventArgs e)
        {

        }

        private void lblTrueFalse_Click(object sender, EventArgs e)
        {

        }
    }
}
