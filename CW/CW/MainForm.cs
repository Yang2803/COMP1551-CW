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
    public partial class MainForm : Form

    {
        public List<BaseQuestion> QuestionList { get; private set; } = new List<BaseQuestion>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadQuestionSetList();
        }



        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide MainForm
            var createForm = new CreateForm(QuestionList);
            createForm.FormClosed += (s, args) =>
            {
                this.Show();
                LoadQuestionSetList();
            };
            createForm.Show();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (QuestionList.Count == 0)
            {
                MessageBox.Show("Don't have any Question");
                return;
            }

            this.Hide();
            bool shuffle = chkShuffle.Checked;
            var listToPlay = new List<BaseQuestion>(QuestionList);
            if (shuffle)
            {
                listToPlay = listToPlay.OrderBy(q => Guid.NewGuid()).ToList();
                Console.WriteLine("Playing temporary question list with shuffle.");
            }
            var playForm = new PlayForm(this, listToPlay);
            playForm.Show();

        }

        private void LoadQuestionSetList()
        {
            comboBoxQuestionSets.Items.Clear();
            string folder = Path.Combine(Application.StartupPath, "SavedQuestionSets");
            Directory.CreateDirectory(folder);

            string[] files = Directory.GetFiles(folder, "*.json");
            foreach (string file in files)
            {
                string name = Path.GetFileNameWithoutExtension(file);
                comboBoxQuestionSets.Items.Add(name);
            }

            if (comboBoxQuestionSets.Items.Count == 0)
                comboBoxQuestionSets.Items.Add("(Don't have any Question Set)");
        }

        private void btnPlaySelectedSet_Click(object sender, EventArgs e)
        {
            if (comboBoxQuestionSets.SelectedItem == null) return;

            string setName = comboBoxQuestionSets.SelectedItem.ToString();
            var set = LoadQuestionSet(setName);

            if (set != null && set.Questions.Count > 0)
            {
                this.Hide();
                bool shuffle = chkShuffle.Checked;
                new PlayForm(this, set.Questions, shuffle).Show();
            }
            else
            {
                MessageBox.Show("Null Question Set or Error data.");
            }
        }

        private void btnDeleteSet_Click(object sender, EventArgs e)
        {
            if (comboBoxQuestionSets.SelectedItem == null || comboBoxQuestionSets.SelectedItem.ToString().StartsWith("("))
            {
                MessageBox.Show("Please choose Question Set to delete.");
                return;
            }

            string setName = comboBoxQuestionSets.SelectedItem.ToString();
            string folder = Path.Combine(Application.StartupPath, "SavedQuestionSets");
            string filePath = Path.Combine(folder, setName + ".json");

            var confirm = MessageBox.Show($"Are you sure to delete '{setName}'?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    File.Delete(filePath);
                    MessageBox.Show($" '{setName}' is deleted.", "Sucessfully");
                    LoadQuestionSetList(); 

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error when Delete: {ex.Message}", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnEditSet_Click(object sender, EventArgs e)
        {
            if (comboBoxQuestionSets.SelectedItem == null || comboBoxQuestionSets.SelectedItem.ToString().StartsWith("("))
            {
                MessageBox.Show("Please select a Question Set to edit.");
                return;
            }

            string setName = comboBoxQuestionSets.SelectedItem.ToString();
            string filePath = Path.Combine(Application.StartupPath, "SavedQuestionSets", setName + ".json");

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Could not find the selected Question Set.");
                return;
            }

            string json = File.ReadAllText(filePath);
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            var set = JsonConvert.DeserializeObject<QuestionSet>(json, settings);

            if (set == null || set.Questions.Count == 0)
            {
                MessageBox.Show("Invalid or empty Question Set.");
                return;
            }

            this.Hide();
            var editForm = new CreateForm(set.Questions);
            editForm.FormClosed += (s, args) =>
            {
                settings.Formatting = Formatting.Indented;

                string updatedJson = JsonConvert.SerializeObject(new QuestionSet
                {
                    SetName = setName,
                    Questions = set.Questions
                }, settings);

                File.WriteAllText(filePath, updatedJson);
                MessageBox.Show($"'{setName}' has been updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Show();
                LoadQuestionSetList();
                comboBoxQuestionSets.SelectedItem = setName;
            };
            editForm.Show();

        }

        private QuestionSet LoadQuestionSet(string setName)
        {
            string folder = Path.Combine(Application.StartupPath, "SavedQuestionSets");
            string filePath = Path.Combine(folder, setName + ".json");

            if (!File.Exists(filePath)) return null;

            string json = File.ReadAllText(filePath);
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            return JsonConvert.DeserializeObject<QuestionSet>(json, settings);
        }

        private void comboBoxQuestionSets_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkShuffle_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}