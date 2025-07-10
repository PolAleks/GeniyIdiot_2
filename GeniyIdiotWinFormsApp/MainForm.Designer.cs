namespace GeniyIdiotWinFormsApp
{
    partial class MainForm
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
            this.questionNumberLabe = new System.Windows.Forms.Label();
            this.questionTextLabel = new System.Windows.Forms.Label();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberQuestionLabel
            // 
            this.questionNumberLabe.AutoSize = true;
            this.questionNumberLabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionNumberLabe.Location = new System.Drawing.Point(76, 52);
            this.questionNumberLabe.Name = "numberQuestionLabel";
            this.questionNumberLabe.Size = new System.Drawing.Size(92, 20);
            this.questionNumberLabe.TabIndex = 0;
            this.questionNumberLabe.Text = "Вопрос №1";
            // 
            // textQuestionLabel
            // 
            this.questionTextLabel.AutoSize = true;
            this.questionTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionTextLabel.Location = new System.Drawing.Point(76, 95);
            this.questionTextLabel.Name = "textQuestionLabel";
            this.questionTextLabel.Size = new System.Drawing.Size(118, 20);
            this.questionTextLabel.TabIndex = 1;
            this.questionTextLabel.Text = "Текст вопроса";
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(80, 143);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(127, 20);
            this.answerTextBox.TabIndex = 2;
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextButton.Location = new System.Drawing.Point(80, 194);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(127, 31);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = "Далее";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.questionTextLabel);
            this.Controls.Add(this.questionNumberLabe);
            this.Name = "MainForm";
            this.Text = "Гений Идиот";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionNumberLabe;
        private System.Windows.Forms.Label questionTextLabel;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Button nextButton;
    }
}

