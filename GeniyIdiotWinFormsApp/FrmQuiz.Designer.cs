namespace GeniyIdiotWinFormsApp
{
    partial class FrmQuiz
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
            this.labelQuestionNumber = new System.Windows.Forms.Label();
            this.labelQuestionText = new System.Windows.Forms.Label();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.buttonNexQuestion = new System.Windows.Forms.Button();
            this.labelTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelQuestionNumber
            // 
            this.labelQuestionNumber.AutoSize = true;
            this.labelQuestionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuestionNumber.Location = new System.Drawing.Point(16, 9);
            this.labelQuestionNumber.Name = "labelQuestionNumber";
            this.labelQuestionNumber.Size = new System.Drawing.Size(79, 16);
            this.labelQuestionNumber.TabIndex = 0;
            this.labelQuestionNumber.Text = "Вопрос №1";
            // 
            // labelQuestionText
            // 
            this.labelQuestionText.AutoSize = true;
            this.labelQuestionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuestionText.Location = new System.Drawing.Point(16, 44);
            this.labelQuestionText.Name = "labelQuestionText";
            this.labelQuestionText.Size = new System.Drawing.Size(103, 16);
            this.labelQuestionText.TabIndex = 1;
            this.labelQuestionText.Text = "Текст вопроса";
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(19, 86);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(143, 20);
            this.textBoxAnswer.TabIndex = 2;
            // 
            // buttonNexQuestion
            // 
            this.buttonNexQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNexQuestion.Location = new System.Drawing.Point(386, 79);
            this.buttonNexQuestion.Name = "buttonNexQuestion";
            this.buttonNexQuestion.Size = new System.Drawing.Size(226, 33);
            this.buttonNexQuestion.TabIndex = 3;
            this.buttonNexQuestion.Text = "&Далее";
            this.buttonNexQuestion.UseVisualStyleBackColor = true;
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimer.Location = new System.Drawing.Point(474, 9);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(138, 16);
            this.labelTimer.TabIndex = 4;
            this.labelTimer.Text = "Осталось 10 секунд.";
            // 
            // FrmQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 139);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.buttonNexQuestion);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.labelQuestionText);
            this.Controls.Add(this.labelQuestionNumber);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Гений - Идиот";
            this.Load += new System.EventHandler(this.FrmQuiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuestionNumber;
        private System.Windows.Forms.Label labelQuestionText;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Button buttonNexQuestion;
        private System.Windows.Forms.Label labelTimer;
    }
}