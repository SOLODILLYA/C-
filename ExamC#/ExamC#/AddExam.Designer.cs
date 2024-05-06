namespace ExamC_
{
    partial class AddExam
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
            this.label1 = new System.Windows.Forms.Label();
            this.QuestionBox = new System.Windows.Forms.TextBox();
            this.CorrectBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IncorrectBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IncorrectBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IncorrectBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ExamNameBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Next Question";
            // 
            // QuestionBox
            // 
            this.QuestionBox.Location = new System.Drawing.Point(12, 129);
            this.QuestionBox.Name = "QuestionBox";
            this.QuestionBox.Size = new System.Drawing.Size(776, 20);
            this.QuestionBox.TabIndex = 1;
            this.QuestionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CorrectBox
            // 
            this.CorrectBox.Location = new System.Drawing.Point(12, 202);
            this.CorrectBox.Name = "CorrectBox";
            this.CorrectBox.Size = new System.Drawing.Size(776, 20);
            this.CorrectBox.TabIndex = 3;
            this.CorrectBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(325, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Correct Answer";
            // 
            // IncorrectBox2
            // 
            this.IncorrectBox2.Location = new System.Drawing.Point(12, 347);
            this.IncorrectBox2.Name = "IncorrectBox2";
            this.IncorrectBox2.Size = new System.Drawing.Size(776, 20);
            this.IncorrectBox2.TabIndex = 7;
            this.IncorrectBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Second Incorrect Answer";
            // 
            // IncorrectBox1
            // 
            this.IncorrectBox1.Location = new System.Drawing.Point(12, 274);
            this.IncorrectBox1.Name = "IncorrectBox1";
            this.IncorrectBox1.Size = new System.Drawing.Size(776, 20);
            this.IncorrectBox1.TabIndex = 5;
            this.IncorrectBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(304, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "First Incorrect Answer";
            // 
            // IncorrectBox3
            // 
            this.IncorrectBox3.Location = new System.Drawing.Point(12, 421);
            this.IncorrectBox3.Name = "IncorrectBox3";
            this.IncorrectBox3.Size = new System.Drawing.Size(776, 20);
            this.IncorrectBox3.TabIndex = 9;
            this.IncorrectBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(296, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Third Incorrect Answer";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(296, 447);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(106, 48);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(418, 447);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(106, 48);
            this.SubmitButton.TabIndex = 11;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ExamNameBox
            // 
            this.ExamNameBox.Location = new System.Drawing.Point(12, 49);
            this.ExamNameBox.Name = "ExamNameBox";
            this.ExamNameBox.Size = new System.Drawing.Size(776, 20);
            this.ExamNameBox.TabIndex = 13;
            this.ExamNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(336, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Exam Name";
            // 
            // AddExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.ExamNameBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.IncorrectBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IncorrectBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IncorrectBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CorrectBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QuestionBox);
            this.Controls.Add(this.label1);
            this.Name = "AddExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Exam";
            this.Load += new System.EventHandler(this.AddExam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox QuestionBox;
        private System.Windows.Forms.TextBox CorrectBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IncorrectBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IncorrectBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IncorrectBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox ExamNameBox;
        private System.Windows.Forms.Label label6;
    }
}