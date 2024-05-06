namespace ExamC_
{
    partial class ExamQuestions
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
            this.ExamLabel = new System.Windows.Forms.Label();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.QuestionNameLabel = new System.Windows.Forms.Label();
            this.Answers = new System.Windows.Forms.CheckedListBox();
            this.AnswerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExamLabel
            // 
            this.ExamLabel.AutoSize = true;
            this.ExamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExamLabel.Location = new System.Drawing.Point(291, 30);
            this.ExamLabel.Name = "ExamLabel";
            this.ExamLabel.Size = new System.Drawing.Size(82, 31);
            this.ExamLabel.TabIndex = 0;
            this.ExamLabel.Text = "Exam";
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLabel.Location = new System.Drawing.Point(291, 70);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(130, 31);
            this.QuestionLabel.TabIndex = 1;
            this.QuestionLabel.Text = "Question ";
            // 
            // QuestionNameLabel
            // 
            this.QuestionNameLabel.AutoSize = true;
            this.QuestionNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionNameLabel.Location = new System.Drawing.Point(291, 101);
            this.QuestionNameLabel.Name = "QuestionNameLabel";
            this.QuestionNameLabel.Size = new System.Drawing.Size(130, 31);
            this.QuestionNameLabel.TabIndex = 2;
            this.QuestionNameLabel.Text = "Question ";
            // 
            // Answers
            // 
            this.Answers.FormattingEnabled = true;
            this.Answers.Location = new System.Drawing.Point(12, 190);
            this.Answers.Name = "Answers";
            this.Answers.Size = new System.Drawing.Size(776, 169);
            this.Answers.TabIndex = 3;
            this.Answers.SelectedIndexChanged += new System.EventHandler(this.Answers_SelectedIndexChanged);
            // 
            // AnswerButton
            // 
            this.AnswerButton.Location = new System.Drawing.Point(328, 376);
            this.AnswerButton.Name = "AnswerButton";
            this.AnswerButton.Size = new System.Drawing.Size(121, 48);
            this.AnswerButton.TabIndex = 4;
            this.AnswerButton.Text = "Answer";
            this.AnswerButton.UseVisualStyleBackColor = true;
            this.AnswerButton.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // ExamQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 436);
            this.Controls.Add(this.AnswerButton);
            this.Controls.Add(this.Answers);
            this.Controls.Add(this.QuestionNameLabel);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.ExamLabel);
            this.Name = "ExamQuestions";
            this.Text = "ExamQuestions";
            this.Load += new System.EventHandler(this.ExamQuestions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExamLabel;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Label QuestionNameLabel;
        private System.Windows.Forms.CheckedListBox Answers;
        private System.Windows.Forms.Button AnswerButton;
    }
}