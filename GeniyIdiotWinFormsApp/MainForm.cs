using GeniyIdiot.Common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GeniyIdiotWinFormsApp
{
    public partial class MainForm : Form
    {
        private TestManager _testManager;

        public MainForm(string name)
        {
            InitializeComponent();

            _testManager = new TestManager(new User(name));

            _testManager.OnNextQuestion += q =>
            {
                questionNumberLabe.Text = $"Вопрос № {q.Number}";
                questionTextLabel.Text = q.Text;

                answerTextBox.Text = string.Empty;
                answerTextBox.Focus();
            };

            _testManager.OnCompliteTest += u =>
            {
                nextButton.Enabled = false;
                MessageBox.Show($"{u.Name} твой диагноз - {u.Diagnosis}",
                                "Результат тестирования",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            };

            _testManager.Start();
        }


        private void nextButton_Click(object sender, EventArgs e)
        {
            bool isValidAnswer = InputValidator.TryParseNumber(answerTextBox.Text, out int answer, out string errorMessage);
            if (isValidAnswer)
            {
                _testManager.SubmitAnswer(answer);
            }
            else
            {
                MessageBox.Show(errorMessage, "Ошибка ввода", MessageBoxButtons.OK);
                answerTextBox.Text = string.Empty;
                answerTextBox.Focus();
            }
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void showResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resultsForm = new ResultsForm();
            resultsForm.ShowDialog();
        }

        private void showQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var questionsForm = new QuestionsForm();
            var questionsForm = new FrmViewQuestions();
            questionsForm.ShowDialog();
        }
    }
}
