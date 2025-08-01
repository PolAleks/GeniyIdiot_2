﻿using GeniyIdiot.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeniyIdiotWinFormsApp
{
    public partial class FrmQuiz : Form
    {
        private QuizManager _quizManager;
        public FrmQuiz(string name)
        {
            InitializeComponent();
            _quizManager = new QuizManager(new User(name));

            _quizManager.OnNextQuestion += _quizManager_OnNextQuestion;
            _quizManager.OnTimeUpdate += _quizManager_OnTimeUpdate;
            _quizManager.OnQuizComplite += _quizManager_OnQuizComplite;
            
        }
        private void FrmQuiz_Load(object sender, EventArgs e)
        {
            _quizManager.Start();
        }

        private void _quizManager_OnQuizComplite(User user)
        {
            buttonNexQuestion.Invoke((Action)(() => buttonNexQuestion.Enabled = false)); 
            MessageBox.Show($"{user.Name} твой диагноз - {user.Diagnosis}",
                                "Результат тестирования",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
        }

        private void _quizManager_OnTimeUpdate(int leftTime)
        {
            labelTimer.Invoke((Action)(() => labelTimer.Text = $"Осталось {leftTime} секунд."));
        }

        private void _quizManager_OnNextQuestion(Question question)
        {
            labelQuestionNumber.Invoke((Action)(() => labelQuestionNumber.Text = $"Вопрос № {question.Number}"));
            labelQuestionText.Invoke((Action)(() => labelQuestionText.Text = question.Text));

            textBoxAnswer.Text = string.Empty;
            textBoxAnswer.Focus();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resultsFrm = new ResultsForm();
            resultsFrm.ShowDialog();
        }

        private void questionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var questionsFrm = new FrmViewQuestions();
            questionsFrm.ShowDialog();
        }

        private void buttonNexQuestion_Click(object sender, EventArgs e)
        {
            var isValidAnswer = InputValidator.TryParseNumber(textBoxAnswer.Text, out int answer, out string message);
            if (isValidAnswer)
            {
                _quizManager.Submit(answer);
            }
            else
            {
                MessageBox.Show(message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAnswer.Text = string.Empty;
                textBoxAnswer.Focus();
            }
        }

        private void textBoxAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) 
                buttonNexQuestion_Click(sender, e);
        }
    }
}
