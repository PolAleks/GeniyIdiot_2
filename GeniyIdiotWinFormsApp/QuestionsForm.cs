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
    public partial class QuestionsForm : Form
    {
        List<Question> _questions;
        public QuestionsForm()
        {
            InitializeComponent();
        }

        private void QuestionsForm_Load(object sender, EventArgs e)
        {
            _questions = QuestionsStorage.GetAll();
            foreach (var question in _questions)
            {
                questionsDataGridView.Rows.Add(question.Text, question.Answer);
            }
        }

        private void questionsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (questionsDataGridView.Rows.Count > 0 && _questions.Count > index)
            {
                questionsDataGridView.Rows.RemoveAt(index);
                _questions.RemoveAt(index);
                QuestionsStorage.Save(_questions);
            }
        }
    }
}
