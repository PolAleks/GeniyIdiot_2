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

namespace GeniyIdiotWinFormsApp
{
    public partial class FrmViewQuestions : Form
    {
        public FrmViewQuestions()
        {
            InitializeComponent();
        }

        List<Question> _questions = new List<Question>();
        bool cancelcontexMenu = false;

        private void FrmViewQuestions_Load(object sender, EventArgs e)
        {
            _questions = QuestionsStorage.GetAll();
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            dataGridViewQuestions.DataSource = null;
            dataGridViewQuestions.DataSource = QuestionsStorage.GetAll();

            dataGridViewQuestions.Columns["Text"].HeaderText = "Текст вопроса";
            dataGridViewQuestions.Columns["Text"].Width = 500;

            dataGridViewQuestions.Columns["Answer"].HeaderText = "Ответ";
            dataGridViewQuestions.Columns["Answer"].Width = 100;

            dataGridViewQuestions.Columns["Number"].HeaderText = "№ вопроса";
            dataGridViewQuestions.Columns["Number"].Width = 100;
            dataGridViewQuestions.Columns["Number"].Visible = false;
        }

        private void UpdateButtonAddNewQuestion()
        {
            buttonAddNewQuestion.Enabled = textBoxTextQuestion.Text.Length > 0 && textBoxAnswerQuestion.Text.Length > 0; ;
        }
    }
}
