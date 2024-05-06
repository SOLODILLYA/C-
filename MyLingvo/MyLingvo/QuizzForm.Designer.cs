namespace MyLingvo
{
    partial class Quizz
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
            this.label2 = new System.Windows.Forms.Label();
            this.WordBox = new System.Windows.Forms.TextBox();
            this.TranslationBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.PreviousTranslationsList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Word";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quizz";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // WordBox
            // 
            this.WordBox.Location = new System.Drawing.Point(16, 66);
            this.WordBox.Name = "WordBox";
            this.WordBox.Size = new System.Drawing.Size(134, 20);
            this.WordBox.TabIndex = 2;
            // 
            // TranslationBox
            // 
            this.TranslationBox.Location = new System.Drawing.Point(187, 66);
            this.TranslationBox.Name = "TranslationBox";
            this.TranslationBox.Size = new System.Drawing.Size(134, 20);
            this.TranslationBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(202, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Your Translation";
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(58, 92);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(110, 42);
            this.CheckButton.TabIndex = 5;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(174, 92);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(110, 42);
            this.EndButton.TabIndex = 6;
            this.EndButton.Text = "End";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // PreviousTranslationsList
            // 
            this.PreviousTranslationsList.FormattingEnabled = true;
            this.PreviousTranslationsList.Location = new System.Drawing.Point(67, 140);
            this.PreviousTranslationsList.Name = "PreviousTranslationsList";
            this.PreviousTranslationsList.Size = new System.Drawing.Size(217, 199);
            this.PreviousTranslationsList.TabIndex = 7;
            // 
            // Quizz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 343);
            this.Controls.Add(this.PreviousTranslationsList);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.TranslationBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WordBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Quizz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quizz";
            this.Load += new System.EventHandler(this.Quizz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox WordBox;
        private System.Windows.Forms.TextBox TranslationBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.ListBox PreviousTranslationsList;
    }
}