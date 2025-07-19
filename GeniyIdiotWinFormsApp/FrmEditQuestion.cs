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
    public partial class FrmEditQuestion : Form
    {
        public event Action<Question> QuestionUpdateEvent;
        public Question EditedQuestion { get; set; }
        public FrmEditQuestion()
        {
            InitializeComponent();
        }

        private void FrmEditQuestion_Load(object sender, EventArgs e)
        {
            questionBindingSource.Add(EditedQuestion);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Question updatedQuestion = (Question)questionBindingSource.Current;

            QuestionUpdateEvent?.Invoke(updatedQuestion);

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
