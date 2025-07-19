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
            RefreshDataGridView();
            UpdateButtonAddNewQuestion();
        }

        private void RefreshDataGridView()
        {
            _questions = QuestionsStorage.GetAll();
            dataGridViewQuestions.DataSource = null;
            dataGridViewQuestions.DataSource = _questions;

            dataGridViewQuestions.Columns["Text"].HeaderText = "Текст вопроса";
            dataGridViewQuestions.Columns["Text"].Width = 500;

            dataGridViewQuestions.Columns["Answer"].HeaderText = "Ответ";
            dataGridViewQuestions.Columns["Answer"].Width = 100;

            dataGridViewQuestions.Columns["Number"].HeaderText = "№ вопроса";
            dataGridViewQuestions.Columns["Number"].Width = 100;
            dataGridViewQuestions.Columns["Number"].Visible = false;

            dataGridViewQuestions.Columns["Id"].HeaderText = "Id";
            dataGridViewQuestions.Columns["Id"].Width = 100;
            dataGridViewQuestions.Columns["Id"].Visible = false;
        }

        private void UpdateButtonAddNewQuestion()
        {
            buttonAddNewQuestion.Enabled = textBoxTextQuestion.Text.Length > 0 && textBoxAnswerQuestion.Text.Length > 0; ;
        }

        private void buttonAddNewQuestion_Click(object sender, EventArgs e)
        {
            bool isValidAnswer = InputValidator.TryParseNumber(textBoxAnswerQuestion.Text, out int answer, out string errorMessage);
            if (isValidAnswer)
            {
                Question question = new Question(textBoxTextQuestion.Text, answer, Guid.NewGuid());
                QuestionsStorage.Add(question);
                RefreshDataGridView();

                textBoxTextQuestion.Text = string.Empty;
                textBoxAnswerQuestion.Text = string.Empty;
            }
            else
            {
                MessageBox.Show(errorMessage, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAnswerQuestion.Text = string.Empty;
                textBoxAnswerQuestion.Focus();
            }

        }

        private void dataGridViewQuestions_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int column = e.ColumnIndex;

            DataGridViewCell cell = dataGridViewQuestions[column, row];
            object value = cell.Value;

            Question question = _questions[row];

            switch (column)
            {
                case 0:
                    question.Text = (string)value;
                    break;
                case 1:
                    question.Answer = (int)value;
                    break;
            }
            QuestionsStorage.Update(question);
        }

        private void dataGridViewQuestions_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            int row = e.RowIndex;
            int column = e.ColumnIndex;

            object editedValue = dataGridViewQuestions[column, row].EditedFormattedValue;

            if (e.Exception is FormatException fx && column == 1)
            {
                MessageBox.Show($"Введите числовое значение, т.к. '{editedValue.ToString()}' не является числовым значением!",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void dataGridViewQuestions_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitInfo = dataGridViewQuestions.HitTest(e.X, e.Y);
                if (hitInfo.RowIndex >= 0 && hitInfo.ColumnIndex >= 0)
                {
                    dataGridViewQuestions.ClearSelection();
                    dataGridViewQuestions.Rows[hitInfo.RowIndex].Selected = true;
                    cancelcontexMenu = false;
                }
                else
                {
                    cancelcontexMenu = true;
                }
            }
        }

        private void contextMenuStripForGrid_Opening(object sender, CancelEventArgs e)
        {
            if (cancelcontexMenu)
                e.Cancel = true;
        }

        private void MenuItemRemoveQuestion_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridViewQuestions.SelectedRows;
            foreach (DataGridViewRow selectedRow in selectedRows)
            {
                int rowIndex = selectedRow.Index;
                if (rowIndex < 0) continue;

                Question question = _questions[rowIndex];

                DialogResult dlgConfirm = MessageBox.Show("Удалить вопрос?",
                                                          "Подтвердите",
                                                          MessageBoxButtons.YesNoCancel,
                                                          MessageBoxIcon.Question);
                if (dlgConfirm == DialogResult.Yes)
                    QuestionsStorage.Delete(question);
            }
            RefreshDataGridView();
        }

        private void MenuItemEditQuestion_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridViewQuestions.SelectedRows;

            foreach (DataGridViewRow selectedRow in selectedRows)
            {
                int rowIndex = selectedRow.Index;
                if(rowIndex < 0) continue;

                Question question = _questions[rowIndex];
                var editFrm = new FrmEditQuestion();
                editFrm.EditedQuestion = question;
                editFrm.QuestionUpdateEvent += FrmEdit_QuestionUpdatedEvent;
                editFrm.Show();
            }
        }

        private void FrmEdit_QuestionUpdatedEvent(Question question)
        {
            QuestionsStorage.Update(question);
            RefreshDataGridView();
        }

        private void textBoxTextQuestion_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonAddNewQuestion();
        }

        private void textBoxAnswerQuestion_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonAddNewQuestion();
        }
    }
}
