namespace MathGame
{
    partial class Form2
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
            Title = new Label();
            RadioSetAdd = new RadioButton();
            RadioSetSubstract = new RadioButton();
            RadioSetMultiply = new RadioButton();
            RadioSetDivide = new RadioButton();
            RadioSetRandom = new RadioButton();
            label1 = new Label();
            ButtonStartNewGame = new Button();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = SystemColors.ActiveCaptionText;
            Title.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Title.ForeColor = Color.Navy;
            Title.Location = new Point(265, 22);
            Title.Name = "Title";
            Title.Size = new Size(243, 54);
            Title.TabIndex = 0;
            Title.Text = "Math Game";
            // 
            // RadioSetAdd
            // 
            RadioSetAdd.AutoSize = true;
            RadioSetAdd.BackColor = SystemColors.ActiveCaptionText;
            RadioSetAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            RadioSetAdd.ForeColor = SystemColors.ActiveCaption;
            RadioSetAdd.Location = new Point(191, 211);
            RadioSetAdd.Name = "RadioSetAdd";
            RadioSetAdd.Size = new Size(47, 32);
            RadioSetAdd.TabIndex = 7;
            RadioSetAdd.TabStop = true;
            RadioSetAdd.Text = "+";
            RadioSetAdd.UseVisualStyleBackColor = false;
            // 
            // RadioSetSubstract
            // 
            RadioSetSubstract.AutoSize = true;
            RadioSetSubstract.BackColor = SystemColors.ActiveCaptionText;
            RadioSetSubstract.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RadioSetSubstract.ForeColor = SystemColors.ActiveCaption;
            RadioSetSubstract.Location = new Point(278, 211);
            RadioSetSubstract.Name = "RadioSetSubstract";
            RadioSetSubstract.Size = new Size(41, 32);
            RadioSetSubstract.TabIndex = 8;
            RadioSetSubstract.TabStop = true;
            RadioSetSubstract.Text = "-";
            RadioSetSubstract.UseVisualStyleBackColor = false;
            // 
            // RadioSetMultiply
            // 
            RadioSetMultiply.AutoSize = true;
            RadioSetMultiply.BackColor = SystemColors.ActiveCaptionText;
            RadioSetMultiply.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RadioSetMultiply.ForeColor = SystemColors.ActiveCaption;
            RadioSetMultiply.Location = new Point(367, 211);
            RadioSetMultiply.Name = "RadioSetMultiply";
            RadioSetMultiply.Size = new Size(42, 32);
            RadioSetMultiply.TabIndex = 9;
            RadioSetMultiply.TabStop = true;
            RadioSetMultiply.Text = "x";
            RadioSetMultiply.UseVisualStyleBackColor = false;
            // 
            // RadioSetDivide
            // 
            RadioSetDivide.AutoSize = true;
            RadioSetDivide.BackColor = SystemColors.ActiveCaptionText;
            RadioSetDivide.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RadioSetDivide.ForeColor = SystemColors.ActiveCaption;
            RadioSetDivide.Location = new Point(458, 211);
            RadioSetDivide.Name = "RadioSetDivide";
            RadioSetDivide.Size = new Size(47, 32);
            RadioSetDivide.TabIndex = 10;
            RadioSetDivide.TabStop = true;
            RadioSetDivide.Text = "÷";
            RadioSetDivide.UseVisualStyleBackColor = false;
            // 
            // RadioSetRandom
            // 
            RadioSetRandom.AutoSize = true;
            RadioSetRandom.BackColor = SystemColors.ActiveCaptionText;
            RadioSetRandom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RadioSetRandom.ForeColor = SystemColors.ActiveCaption;
            RadioSetRandom.Location = new Point(548, 211);
            RadioSetRandom.Name = "RadioSetRandom";
            RadioSetRandom.Size = new Size(42, 32);
            RadioSetRandom.TabIndex = 11;
            RadioSetRandom.TabStop = true;
            RadioSetRandom.Text = "?";
            RadioSetRandom.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(326, 158);
            label1.Name = "label1";
            label1.Size = new Size(119, 28);
            label1.TabIndex = 12;
            label1.Text = "Game Setup";
            // 
            // ButtonStartNewGame
            // 
            ButtonStartNewGame.BackColor = SystemColors.ActiveCaptionText;
            ButtonStartNewGame.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonStartNewGame.ForeColor = SystemColors.ActiveCaption;
            ButtonStartNewGame.Location = new Point(326, 307);
            ButtonStartNewGame.Name = "ButtonStartNewGame";
            ButtonStartNewGame.Size = new Size(161, 51);
            ButtonStartNewGame.TabIndex = 13;
            ButtonStartNewGame.Text = "Start";
            ButtonStartNewGame.UseVisualStyleBackColor = false;
            ButtonStartNewGame.Click += NewGameClickedEvent;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Mathematics_Hero_1600x900;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonStartNewGame);
            Controls.Add(label1);
            Controls.Add(RadioSetRandom);
            Controls.Add(RadioSetDivide);
            Controls.Add(RadioSetMultiply);
            Controls.Add(RadioSetSubstract);
            Controls.Add(RadioSetAdd);
            Controls.Add(Title);
            Name = "Form2";
            Text = "Math Game Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private RadioButton RadioSetAdd;
        private RadioButton RadioSetSubstract;
        private RadioButton RadioSetMultiply;
        private RadioButton RadioSetDivide;
        private RadioButton RadioSetRandom;
        private Label label1;
        private Button ButtonStartNewGame;
    }
}