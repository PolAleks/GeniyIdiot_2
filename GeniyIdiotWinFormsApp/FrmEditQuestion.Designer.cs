namespace GeniyIdiotWinFormsApp
{
    partial class FrmEditQuestion
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
            this.labelTextQuestion = new System.Windows.Forms.Label();
            this.textBoxTextQuestion = new System.Windows.Forms.TextBox();
            this.labelAnswerQuestion = new System.Windows.Forms.Label();
            this.textBoxAnswerQuestion = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.questionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTextQuestion
            // 
            this.labelTextQuestion.AutoSize = true;
            this.labelTextQuestion.Location = new System.Drawing.Point(13, 13);
            this.labelTextQuestion.Name = "labelTextQuestion";
            this.labelTextQuestion.Size = new System.Drawing.Size(85, 13);
            this.labelTextQuestion.TabIndex = 0;
            this.labelTextQuestion.Text = "Текст вопроса:";
            // 
            // textBoxTextQuestion
            // 
            this.textBoxTextQuestion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionBindingSource, "Text", true));
            this.textBoxTextQuestion.Location = new System.Drawing.Point(16, 38);
            this.textBoxTextQuestion.Name = "textBoxTextQuestion";
            this.textBoxTextQuestion.Size = new System.Drawing.Size(518, 20);
            this.textBoxTextQuestion.TabIndex = 1;
            // 
            // labelAnswerQuestion
            // 
            this.labelAnswerQuestion.AutoSize = true;
            this.labelAnswerQuestion.Location = new System.Drawing.Point(16, 87);
            this.labelAnswerQuestion.Name = "labelAnswerQuestion";
            this.labelAnswerQuestion.Size = new System.Drawing.Size(94, 13);
            this.labelAnswerQuestion.TabIndex = 2;
            this.labelAnswerQuestion.Text = "Ответ на вопрос:";
            // 
            // textBoxAnswerQuestion
            // 
            this.textBoxAnswerQuestion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionBindingSource, "Answer", true));
            this.textBoxAnswerQuestion.Location = new System.Drawing.Point(19, 113);
            this.textBoxAnswerQuestion.Name = "textBoxAnswerQuestion";
            this.textBoxAnswerQuestion.Size = new System.Drawing.Size(266, 20);
            this.textBoxAnswerQuestion.TabIndex = 3;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(322, 107);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(97, 31);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "Сохранить";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(438, 107);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(96, 30);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // questionBindingSource
            // 
            this.questionBindingSource.DataSource = typeof(GeniyIdiot.Common.Question);
            // 
            // FrmEditQuestion
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(548, 163);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxAnswerQuestion);
            this.Controls.Add(this.labelAnswerQuestion);
            this.Controls.Add(this.textBoxTextQuestion);
            this.Controls.Add(this.labelTextQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmEditQuestion";
            this.Text = "Редактировать вопрос";
            this.Load += new System.EventHandler(this.FrmEditQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTextQuestion;
        private System.Windows.Forms.TextBox textBoxTextQuestion;
        private System.Windows.Forms.Label labelAnswerQuestion;
        private System.Windows.Forms.TextBox textBoxAnswerQuestion;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.BindingSource questionBindingSource;
    }
}