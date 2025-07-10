using GeniyIdiot.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GeniyIdiotWinFormsApp
{
    public partial class MainForm : Form
    {
        private List<Question> _questions;
        private int _countQuestions;
        private User _user;
        private Question _currentQuestion;
        private int _numberCurrentQuestion = 1;
        public MainForm()
        {
            InitializeComponent();

            _questions = QuestionsStorage.GetAll();
            _countQuestions = _questions.Count;
            _user = new User("Инкогнито");

            GetNextQuestion();
        }


        private void nextButton_Click(object sender, EventArgs e)
        {
            var userAnswer = Convert.ToInt32(answerTextBox.Text);
            if (_currentQuestion.IsAnswerCorrect(userAnswer))
                _user.AddCorrectAnswer();

            GetNextQuestion();
        }
        private void GetNextQuestion()
        {
            Random random = new Random();
            var index = random.Next(_questions.Count);

            _currentQuestion = _questions[index];
            _questions.Remove(_currentQuestion);

            numberQuestionLabel.Text = $"Вопрос № {_numberCurrentQuestion++}";
            textQuestionLabel.Text = _currentQuestion.Text;

            if(_questions.Count == 0)
            {
                nextButton.Enabled = false;
                _user.AddDiagnosis(_countQuestions);
                MessageBox.Show($"{_user.Name} твой диагноз - {_user.Diagnosis}",
                                "Результат тестирования",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }
    }
}
