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
            this.questionsDataGridView = new System.Windows.Forms.DataGridView();
            this.textQuestionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerQuestionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.questionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // questionsDataGridView
            // 
            this.questionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.questionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.textQuestionColumn,
            this.answerQuestionColumn});
            this.questionsDataGridView.Location = new System.Drawing.Point(0, -1);
            this.questionsDataGridView.Name = "questionsDataGridView";
            this.questionsDataGridView.Size = new System.Drawing.Size(694, 243);
            this.questionsDataGridView.TabIndex = 0;
            // 
            // textQuestionColumn
            // 
            this.textQuestionColumn.HeaderText = "Вопрос";
            this.textQuestionColumn.Name = "textQuestionColumn";
            this.textQuestionColumn.Width = 550;
            // 
            // answerQuestionColumn
            // 
            this.answerQuestionColumn.HeaderText = "Ответ";
            this.answerQuestionColumn.Name = "answerQuestionColumn";
            // 
            // QuestionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 299);
            this.Controls.Add(this.questionsDataGridView);
            this.Name = "QuestionsForm";
            this.Text = "QuestionsForm";
            this.Load += new System.EventHandler(this.QuestionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView questionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn textQuestionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn answerQuestionColumn;
    }
}