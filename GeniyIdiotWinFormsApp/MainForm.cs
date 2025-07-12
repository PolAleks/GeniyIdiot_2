using GeniyIdiot.Common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GeniyIdiotWinFormsApp
{
    public partial class MainForm : Form
    {
        private List<Question> _questions;
        private Question _currentQuestion;
        private int _numberCurrentQuestion = 1;
        private int _countQuestions;
        private User _user;
        public MainForm(string name)
        {
            InitializeComponent();

            _questions = QuestionsStorage.GetAll();
            _countQuestions = _questions.Count;
            _user = new User(name);

            GetNextQuestion();
        }


        private void nextButton_Click(object sender, EventArgs e)
        {
            var userAnswer = Convert.ToInt32(answerTextBox.Text);
            if (_currentQuestion.IsAnswerCorrect(userAnswer))
                _user.AddCorrectAnswer();

            if(_questions.Count == 0)
            {
                nextButton.Enabled = false;
                _user.AddDiagnosis(_countQuestions);
                UsersResultsStorage.Add(_user);
                MessageBox.Show($"{_user.Name} твой диагноз - {_user.Diagnosis}",
                                "Результат тестирования",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else 
            { 
                GetNextQuestion();
            }
        }
        private void GetNextQuestion()
        {
            Random random = new Random();
            var index = random.Next(_questions.Count);
            _currentQuestion = _questions[index];
            _questions.Remove(_currentQuestion);

            questionNumberLabe.Text = $"Вопрос № {_numberCurrentQuestion++}";
            questionTextLabel.Text = _currentQuestion.Text;

            answerTextBox.Text = string.Empty;
            answerTextBox.Focus();
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
    }
}
