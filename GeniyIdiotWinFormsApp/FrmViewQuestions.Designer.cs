namespace GeniyIdiotWinFormsApp
{
    partial class FrmViewQuestions
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStripForGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemRemoveQuestion = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditQuestion = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewQuestions = new System.Windows.Forms.DataGridView();
            this.groupBoxAddNewQuestion = new System.Windows.Forms.GroupBox();
            this.buttonAddNewQuestion = new System.Windows.Forms.Button();
            this.textBoxAnswerQuestion = new System.Windows.Forms.TextBox();
            this.textBoxTextQuestion = new System.Windows.Forms.TextBox();
            this.labelAnswerQuestion = new System.Windows.Forms.Label();
            this.labelTextQuestion = new System.Windows.Forms.Label();
            this.contextMenuStripForGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuestions)).BeginInit();
            this.groupBoxAddNewQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripForGrid
            // 
            this.contextMenuStripForGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemRemoveQuestion,
            this.MenuItemEditQuestion});
            this.contextMenuStripForGrid.Name = "contextMenuStripForGrid";
            this.contextMenuStripForGrid.Size = new System.Drawing.Size(155, 48);
            // 
            // MenuItemRemoveQuestion
            // 
            this.MenuItemRemoveQuestion.Name = "MenuItemRemoveQuestion";
            this.MenuItemRemoveQuestion.Size = new System.Drawing.Size(154, 22);
            this.MenuItemRemoveQuestion.Text = "&Удалить";
            // 
            // MenuItemEditQuestion
            // 
            this.MenuItemEditQuestion.Name = "MenuItemEditQuestion";
            this.MenuItemEditQuestion.Size = new System.Drawing.Size(154, 22);
            this.MenuItemEditQuestion.Text = "&Редактировать";
            // 
            // dataGridViewQuestions
            // 
            this.dataGridViewQuestions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGridViewQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuestions.ContextMenuStrip = this.contextMenuStripForGrid;
            this.dataGridViewQuestions.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewQuestions.Name = "dataGridViewQuestions";
            this.dataGridViewQuestions.Size = new System.Drawing.Size(643, 290);
            this.dataGridViewQuestions.TabIndex = 1;
            this.dataGridViewQuestions.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQuestions_CellEndEdit);
            this.dataGridViewQuestions.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewQuestions_DataError);
            // 
            // groupBoxAddNewQuestion
            // 
            this.groupBoxAddNewQuestion.Controls.Add(this.buttonAddNewQuestion);
            this.groupBoxAddNewQuestion.Controls.Add(this.textBoxAnswerQuestion);
            this.groupBoxAddNewQuestion.Controls.Add(this.textBoxTextQuestion);
            this.groupBoxAddNewQuestion.Controls.Add(this.labelAnswerQuestion);
            this.groupBoxAddNewQuestion.Controls.Add(this.labelTextQuestion);
            this.groupBoxAddNewQuestion.Location = new System.Drawing.Point(12, 323);
            this.groupBoxAddNewQuestion.Name = "groupBoxAddNewQuestion";
            this.groupBoxAddNewQuestion.Size = new System.Drawing.Size(643, 85);
            this.groupBoxAddNewQuestion.TabIndex = 2;
            this.groupBoxAddNewQuestion.TabStop = false;
            this.groupBoxAddNewQuestion.Text = "Добавить новый вопрос в список вопросов";
            // 
            // buttonAddNewQuestion
            // 
            this.buttonAddNewQuestion.Location = new System.Drawing.Point(373, 47);
            this.buttonAddNewQuestion.Name = "buttonAddNewQuestion";
            this.buttonAddNewQuestion.Size = new System.Drawing.Size(264, 23);
            this.buttonAddNewQuestion.TabIndex = 4;
            this.buttonAddNewQuestion.Text = "Добавить новый вопрос";
            this.buttonAddNewQuestion.UseVisualStyleBackColor = true;
            this.buttonAddNewQuestion.Click += new System.EventHandler(this.buttonAddNewQuestion_Click);
            // 
            // textBoxAnswerQuestion
            // 
            this.textBoxAnswerQuestion.Location = new System.Drawing.Point(119, 49);
            this.textBoxAnswerQuestion.Name = "textBoxAnswerQuestion";
            this.textBoxAnswerQuestion.Size = new System.Drawing.Size(234, 20);
            this.textBoxAnswerQuestion.TabIndex = 3;
            // 
            // textBoxTextQuestion
            // 
            this.textBoxTextQuestion.Location = new System.Drawing.Point(119, 21);
            this.textBoxTextQuestion.Name = "textBoxTextQuestion";
            this.textBoxTextQuestion.Size = new System.Drawing.Size(518, 20);
            this.textBoxTextQuestion.TabIndex = 2;
            // 
            // labelAnswerQuestion
            // 
            this.labelAnswerQuestion.AutoSize = true;
            this.labelAnswerQuestion.Location = new System.Drawing.Point(6, 52);
            this.labelAnswerQuestion.Name = "labelAnswerQuestion";
            this.labelAnswerQuestion.Size = new System.Drawing.Size(94, 13);
            this.labelAnswerQuestion.TabIndex = 1;
            this.labelAnswerQuestion.Text = "Ответ на вопрос:";
            // 
            // labelTextQuestion
            // 
            this.labelTextQuestion.AutoSize = true;
            this.labelTextQuestion.Location = new System.Drawing.Point(7, 24);
            this.labelTextQuestion.Name = "labelTextQuestion";
            this.labelTextQuestion.Size = new System.Drawing.Size(85, 13);
            this.labelTextQuestion.TabIndex = 0;
            this.labelTextQuestion.Text = "Текст вопроса:";
            // 
            // FrmViewQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 420);
            this.Controls.Add(this.groupBoxAddNewQuestion);
            this.Controls.Add(this.dataGridViewQuestions);
            this.Name = "FrmViewQuestions";
            this.ShowIcon = false;
            this.Text = "Работа с вопросами";
            this.Load += new System.EventHandler(this.FrmViewQuestions_Load);
            this.contextMenuStripForGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuestions)).EndInit();
            this.groupBoxAddNewQuestion.ResumeLayout(false);
            this.groupBoxAddNewQuestion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStripForGrid;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRemoveQuestion;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEditQuestion;
        private System.Windows.Forms.DataGridView dataGridViewQuestions;
        private System.Windows.Forms.GroupBox groupBoxAddNewQuestion;
        private System.Windows.Forms.Button buttonAddNewQuestion;
        private System.Windows.Forms.TextBox textBoxAnswerQuestion;
        private System.Windows.Forms.TextBox textBoxTextQuestion;
        private System.Windows.Forms.Label labelAnswerQuestion;
        private System.Windows.Forms.Label labelTextQuestion;
    }
}