namespace GeniyIdiotWinFormsApp
{
    partial class ResultsForm
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
            this.resultsDataGridView = new System.Windows.Forms.DataGridView();
            this.userNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countRightAnswerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosisColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // resultsDataGridView
            // 
            this.resultsDataGridView.AllowUserToAddRows = false;
            this.resultsDataGridView.AllowUserToDeleteRows = false;
            this.resultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameColumn,
            this.countRightAnswerColumn,
            this.diagnosisColumn});
            this.resultsDataGridView.Location = new System.Drawing.Point(3, 12);
            this.resultsDataGridView.Name = "resultsDataGridView";
            this.resultsDataGridView.ReadOnly = true;
            this.resultsDataGridView.Size = new System.Drawing.Size(395, 229);
            this.resultsDataGridView.TabIndex = 0;
            // 
            // userNameColumn
            // 
            this.userNameColumn.HeaderText = "Имя";
            this.userNameColumn.Name = "userNameColumn";
            this.userNameColumn.ReadOnly = true;
            // 
            // countRightAnswerColumn
            // 
            this.countRightAnswerColumn.HeaderText = "Кол-во правильных ответов";
            this.countRightAnswerColumn.Name = "countRightAnswerColumn";
            this.countRightAnswerColumn.ReadOnly = true;
            this.countRightAnswerColumn.Width = 150;
            // 
            // diagnosisColumn
            // 
            this.diagnosisColumn.HeaderText = "Диагноз";
            this.diagnosisColumn.Name = "diagnosisColumn";
            this.diagnosisColumn.ReadOnly = true;
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 243);
            this.Controls.Add(this.resultsDataGridView);
            this.Name = "ResultsForm";
            this.Text = "Результаты предыдущих тестирований";
            this.Load += new System.EventHandler(this.ResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView resultsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countRightAnswerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosisColumn;
    }
}