namespace MathGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            LabelScore = new Label();
            LabelNum1 = new Label();
            LabelSymbol = new Label();
            LabelNum2 = new Label();
            LabelEqual = new Label();
            AnswerBox = new TextBox();
            LabelAnswerStatus = new Label();
            CheckAnswerButton = new Button();
            LabelLevel = new Label();
            LabelQuestion = new Label();
            Timer1 = new System.Windows.Forms.Timer(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox1 = new PictureBox();
            LabelStarCount = new Label();
            ButtonPass = new Button();
            ButtonSave = new Button();
            ButtonContinue = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LabelScore
            // 
            LabelScore.AutoSize = true;
            LabelScore.BackColor = Color.MediumSpringGreen;
            LabelScore.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            LabelScore.ForeColor = Color.WhiteSmoke;
            LabelScore.Image = Properties.Resources._360_F_431448941_oo9a7gWADWwWjyYBDmdcYvuIZdss3sxh;
            LabelScore.Location = new Point(54, 19);
            LabelScore.Name = "LabelScore";
            LabelScore.Size = new Size(121, 38);
            LabelScore.TabIndex = 0;
            LabelScore.Text = "Score: 0";
            // 
            // LabelNum1
            // 
            LabelNum1.AutoSize = true;
            LabelNum1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNum1.Image = Properties.Resources._360_F_431448941_oo9a7gWADWwWjyYBDmdcYvuIZdss3sxh;
            LabelNum1.Location = new Point(119, 90);
            LabelNum1.Name = "LabelNum1";
            LabelNum1.Size = new Size(56, 46);
            LabelNum1.TabIndex = 1;
            LabelNum1.Text = "00";
            // 
            // LabelSymbol
            // 
            LabelSymbol.AutoSize = true;
            LabelSymbol.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            LabelSymbol.Image = Properties.Resources._360_F_431448941_oo9a7gWADWwWjyYBDmdcYvuIZdss3sxh;
            LabelSymbol.Location = new Point(194, 90);
            LabelSymbol.Name = "LabelSymbol";
            LabelSymbol.Size = new Size(43, 46);
            LabelSymbol.TabIndex = 2;
            LabelSymbol.Text = "+";
            // 
            // LabelNum2
            // 
            LabelNum2.AutoSize = true;
            LabelNum2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNum2.Image = Properties.Resources._360_F_431448941_oo9a7gWADWwWjyYBDmdcYvuIZdss3sxh;
            LabelNum2.Location = new Point(252, 90);
            LabelNum2.Name = "LabelNum2";
            LabelNum2.Size = new Size(56, 46);
            LabelNum2.TabIndex = 3;
            LabelNum2.Text = "00";
            // 
            // LabelEqual
            // 
            LabelEqual.AutoSize = true;
            LabelEqual.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            LabelEqual.Image = Properties.Resources._360_F_431448941_oo9a7gWADWwWjyYBDmdcYvuIZdss3sxh;
            LabelEqual.Location = new Point(328, 90);
            LabelEqual.Name = "LabelEqual";
            LabelEqual.Size = new Size(43, 46);
            LabelEqual.TabIndex = 4;
            LabelEqual.Text = "=";
            // 
            // AnswerBox
            // 
            AnswerBox.BackColor = Color.MintCream;
            AnswerBox.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            AnswerBox.Location = new Point(392, 87);
            AnswerBox.Name = "AnswerBox";
            AnswerBox.Size = new Size(90, 51);
            AnswerBox.TabIndex = 18;
            AnswerBox.TextChanged += CheckAnswer;
            // 
            // LabelAnswerStatus
            // 
            LabelAnswerStatus.AutoSize = true;
            LabelAnswerStatus.ForeColor = SystemColors.HotTrack;
            LabelAnswerStatus.Image = Properties.Resources._360_F_431448941_oo9a7gWADWwWjyYBDmdcYvuIZdss3sxh;
            LabelAnswerStatus.Location = new Point(411, 141);
            LabelAnswerStatus.Name = "LabelAnswerStatus";
            LabelAnswerStatus.Size = new Size(57, 20);
            LabelAnswerStatus.TabIndex = 28;
            LabelAnswerStatus.Text = "Correct";
            // 
            // CheckAnswerButton
            // 
            CheckAnswerButton.BackgroundImage = Properties.Resources._360_F_431448941_oo9a7gWADWwWjyYBDmdcYvuIZdss3sxh;
            CheckAnswerButton.Location = new Point(500, 90);
            CheckAnswerButton.Name = "CheckAnswerButton";
            CheckAnswerButton.Size = new Size(94, 29);
            CheckAnswerButton.TabIndex = 32;
            CheckAnswerButton.Text = "Check";
            CheckAnswerButton.UseVisualStyleBackColor = true;
            CheckAnswerButton.Click += CheckButtonClickEvent;
            // 
            // LabelLevel
            // 
            LabelLevel.AutoSize = true;
            LabelLevel.Font = new Font("Yu Gothic UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            LabelLevel.ForeColor = Color.Blue;
            LabelLevel.Image = Properties.Resources._360_F_431448941_oo9a7gWADWwWjyYBDmdcYvuIZdss3sxh;
            LabelLevel.Location = new Point(282, 9);
            LabelLevel.Name = "LabelLevel";
            LabelLevel.Size = new Size(143, 50);
            LabelLevel.TabIndex = 33;
            LabelLevel.Text = "Level: 1";
            LabelLevel.Click += LabelDifficulty_Click;
            // 
            // LabelQuestion
            // 
            LabelQuestion.AutoSize = true;
            LabelQuestion.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            LabelQuestion.Image = Properties.Resources._360_F_431448941_oo9a7gWADWwWjyYBDmdcYvuIZdss3sxh;
            LabelQuestion.Location = new Point(12, 105);
            LabelQuestion.Name = "LabelQuestion";
            LabelQuestion.Size = new Size(41, 25);
            LabelQuestion.TabIndex = 34;
            LabelQuestion.Text = "Q 1";
            // 
            // Timer1
            // 
            Timer1.Interval = 15000;
            Timer1.Tag = "";
            Timer1.Tick += Timer1Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightSeaGreen;
            pictureBox1.BackgroundImage = Properties.Resources._360_F_431448941_oo9a7gWADWwWjyYBDmdcYvuIZdss3sxh;
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(500, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // LabelStarCount
            // 
            LabelStarCount.AutoSize = true;
            LabelStarCount.Font = new Font("Segoe UI", 20.2F, FontStyle.Bold, GraphicsUnit.Point);
            LabelStarCount.ForeColor = SystemColors.ActiveCaption;
            LabelStarCount.Image = Properties.Resources._360_F_431448941_oo9a7gWADWwWjyYBDmdcYvuIZdss3sxh;
            LabelStarCount.Location = new Point(554, 12);
            LabelStarCount.Name = "LabelStarCount";
            LabelStarCount.Size = new Size(58, 46);
            LabelStarCount.TabIndex = 36;
            LabelStarCount.Text = ": 0";
            // 
            // ButtonPass
            // 
            ButtonPass.BackgroundImage = Properties.Resources._360_F_431448941_oo9a7gWADWwWjyYBDmdcYvuIZdss3sxh;
            ButtonPass.Location = new Point(500, 125);
            ButtonPass.Name = "ButtonPass";
            ButtonPass.Size = new Size(94, 29);
            ButtonPass.TabIndex = 37;
            ButtonPass.Text = "Pass";
            ButtonPass.UseVisualStyleBackColor = true;
            // 
            // ButtonSave
            // 
            ButtonSave.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSave.ForeColor = Color.Black;
            ButtonSave.Image = Properties.Resources._360_F_431448941_oo9a7gWADWwWjyYBDmdcYvuIZdss3sxh;
            ButtonSave.Location = new Point(644, 15);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(102, 53);
            ButtonSave.TabIndex = 38;
            ButtonSave.Text = "Save";
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Click += SaveButtonClicked;
            // 
            // ButtonContinue
            // 
            ButtonContinue.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonContinue.ForeColor = Color.Black;
            ButtonContinue.Image = Properties.Resources._360_F_431448941_oo9a7gWADWwWjyYBDmdcYvuIZdss3sxh;
            ButtonContinue.Location = new Point(644, 87);
            ButtonContinue.Name = "ButtonContinue";
            ButtonContinue.Size = new Size(102, 53);
            ButtonContinue.TabIndex = 39;
            ButtonContinue.Text = "Continue";
            ButtonContinue.UseVisualStyleBackColor = true;
            ButtonContinue.Click += ButtonContinueClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._360_F_431448941_oo9a7gWADWwWjyYBDmdcYvuIZdss3sxh;
            ClientSize = new Size(794, 195);
            Controls.Add(ButtonContinue);
            Controls.Add(ButtonSave);
            Controls.Add(ButtonPass);
            Controls.Add(LabelStarCount);
            Controls.Add(pictureBox1);
            Controls.Add(LabelQuestion);
            Controls.Add(LabelLevel);
            Controls.Add(CheckAnswerButton);
            Controls.Add(LabelAnswerStatus);
            Controls.Add(AnswerBox);
            Controls.Add(LabelEqual);
            Controls.Add(LabelNum2);
            Controls.Add(LabelSymbol);
            Controls.Add(LabelNum1);
            Controls.Add(LabelScore);
            Name = "Form1";
            Text = "MathGame";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelScore;
        private Label LabelNum1;
        private Label LabelSymbol;
        private Label LabelNum2;
        private Label LabelEqual;
        private TextBox AnswerBox;
        private Label LabelAnswerStatus;
        private Button CheckAnswerButton;
        private Label LabelLevel;
        private Label LabelQuestion;
        private System.Windows.Forms.Timer Timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox1;
        private Label LabelStarCount;
        private Button ButtonPass;
        private Button ButtonSave;
        private Button ButtonContinue;
    }
}