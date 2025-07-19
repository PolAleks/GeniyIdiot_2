namespace GeniyIdiotWinFormsApp
{
    partial class QuestionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.questionsDataGridView = new System.Windows.Forms.DataGridView();
            this.textQuestionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerQuestionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.questionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // questionsDataGridView
            // 
            this.questionsDataGridView.AllowUserToAddRows = false;
            this.questionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.questionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.textQuestionColumn,
            this.answerQuestionColumn,
            this.deleteBtn});
            this.questionsDataGridView.Location = new System.Drawing.Point(0, -1);
            this.questionsDataGridView.Name = "questionsDataGridView";
            this.questionsDataGridView.RowHeadersVisible = false;
            this.questionsDataGridView.Size = new System.Drawing.Size(705, 246);
            this.questionsDataGridView.TabIndex = 0;
            this.questionsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.questionsDataGridView_CellContentClick);
            // 
            // textQuestionColumn
            // 
            this.textQuestionColumn.HeaderText = "Вопрос";
            this.textQuestionColumn.Name = "textQuestionColumn";
            this.textQuestionColumn.Width = 500;
            // 
            // answerQuestionColumn
            // 
            this.answerQuestionColumn.HeaderText = "Ответ";
            this.answerQuestionColumn.Name = "answerQuestionColumn";
            // 
            // deleteBtn
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.deleteBtn.DefaultCellStyle = dataGridViewCellStyle5;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteBtn.HeaderText = "Удаление";
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseColumnTextForButtonValue = true;
            // 
            // QuestionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 244);
            this.Controls.Add(this.questionsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuestionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuestionsForm";
            this.Load += new System.EventHandler(this.QuestionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView questionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn textQuestionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn answerQuestionColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteBtn;
    }
}