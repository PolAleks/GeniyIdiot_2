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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelQuestionNumber
            // 
            this.labelQuestionNumber.AutoSize = true;
            this.labelQuestionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuestionNumber.Location = new System.Drawing.Point(16, 50);
            this.labelQuestionNumber.Name = "labelQuestionNumber";
            this.labelQuestionNumber.Size = new System.Drawing.Size(79, 16);
            this.labelQuestionNumber.TabIndex = 0;
            this.labelQuestionNumber.Text = "Вопрос №1";
            // 
            // labelQuestionText
            // 
            this.labelQuestionText.AutoSize = true;
            this.labelQuestionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuestionText.Location = new System.Drawing.Point(16, 79);
            this.labelQuestionText.Name = "labelQuestionText";
            this.labelQuestionText.Size = new System.Drawing.Size(103, 16);
            this.labelQuestionText.TabIndex = 1;
            this.labelQuestionText.Text = "Текст вопроса";
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(19, 114);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(143, 20);
            this.textBoxAnswer.TabIndex = 2;
            // 
            // buttonNexQuestion
            // 
            this.buttonNexQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNexQuestion.Location = new System.Drawing.Point(386, 107);
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
            this.labelTimer.Location = new System.Drawing.Point(474, 50);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(138, 16);
            this.labelTimer.TabIndex = 4;
            this.labelTimer.Text = "Осталось 10 секунд.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.resultsToolStripMenuItem,
            this.questionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(638, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.mainToolStripMenuItem.Text = "Меню";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restartToolStripMenuItem.Text = "Рестарт";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // resultsToolStripMenuItem
            // 
            this.resultsToolStripMenuItem.Name = "resultsToolStripMenuItem";
            this.resultsToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.resultsToolStripMenuItem.Text = "Результаты";
            this.resultsToolStripMenuItem.Click += new System.EventHandler(this.resultsToolStripMenuItem_Click);
            // 
            // questionsToolStripMenuItem
            // 
            this.questionsToolStripMenuItem.Name = "questionsToolStripMenuItem";
            this.questionsToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.questionsToolStripMenuItem.Text = "Вопросы";
            this.questionsToolStripMenuItem.Click += new System.EventHandler(this.questionsToolStripMenuItem_Click);
            // 
            // FrmQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 164);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.buttonNexQuestion);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.labelQuestionText);
            this.Controls.Add(this.labelQuestionNumber);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Гений - Идиот";
            this.Load += new System.EventHandler(this.FrmQuiz_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuestionNumber;
        private System.Windows.Forms.Label labelQuestionText;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Button buttonNexQuestion;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem questionsToolStripMenuItem;
    }
}