namespace GeniyIdiotWinFormsApp
{
    partial class WelcomForm
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
            this.greetingLabel = new System.Windows.Forms.Label();
            this.callToActionLabel = new System.Windows.Forms.Label();
            this.getNameTextBox = new System.Windows.Forms.TextBox();
            this.startGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // greetingLabel
            // 
            this.greetingLabel.AutoSize = true;
            this.greetingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.greetingLabel.Location = new System.Drawing.Point(75, 35);
            this.greetingLabel.Name = "greetingLabel";
            this.greetingLabel.Size = new System.Drawing.Size(158, 20);
            this.greetingLabel.TabIndex = 0;
            this.greetingLabel.Text = "Добро пожаловать!";
            // 
            // callToActionLabel
            // 
            this.callToActionLabel.AutoSize = true;
            this.callToActionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.callToActionLabel.Location = new System.Drawing.Point(19, 68);
            this.callToActionLabel.Name = "callToActionLabel";
            this.callToActionLabel.Size = new System.Drawing.Size(275, 16);
            this.callToActionLabel.TabIndex = 1;
            this.callToActionLabel.Text = "Представтесь, для начала тестирования";
            // 
            // getNameTextBox
            // 
            this.getNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getNameTextBox.Location = new System.Drawing.Point(22, 107);
            this.getNameTextBox.Name = "getNameTextBox";
            this.getNameTextBox.Size = new System.Drawing.Size(272, 22);
            this.getNameTextBox.TabIndex = 2;
            this.getNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.getNameTextBox_KeyDown);
            // 
            // startGameButton
            // 
            this.startGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startGameButton.Location = new System.Drawing.Point(79, 150);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(154, 40);
            this.startGameButton.TabIndex = 3;
            this.startGameButton.Text = "Старт";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // WelcomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 220);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.getNameTextBox);
            this.Controls.Add(this.callToActionLabel);
            this.Controls.Add(this.greetingLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WelcomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра - Гений или Идиот";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label greetingLabel;
        private System.Windows.Forms.Label callToActionLabel;
        private System.Windows.Forms.TextBox getNameTextBox;
        private System.Windows.Forms.Button startGameButton;
    }
}