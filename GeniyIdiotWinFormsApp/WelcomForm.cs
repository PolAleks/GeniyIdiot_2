using System;
using System.Windows.Forms;

namespace GeniyIdiotWinFormsApp
{
    public partial class WelcomForm : Form
    {
        public WelcomForm()
        {
            InitializeComponent();
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            var userName = getNameTextBox.Text;
            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Вы не ввели свое имя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var mainForm = new FrmQuiz(userName);
                mainForm.Show();
                mainForm.FormClosed += (s, arg) => this.Close();
                this.Hide();
            }
        }
    }
}
