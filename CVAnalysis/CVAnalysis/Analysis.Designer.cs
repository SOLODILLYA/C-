namespace CVAnalysis
{
    partial class Analysis
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
            this.MostWork = new System.Windows.Forms.TextBox();
            this.LeastWork = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.LeastExpensive = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MostExpensive = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Cities = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "The most experienced candidate:";
            // 
            // MostWork
            // 
            this.MostWork.Location = new System.Drawing.Point(13, 30);
            this.MostWork.Name = "MostWork";
            this.MostWork.Size = new System.Drawing.Size(165, 20);
            this.MostWork.TabIndex = 2;
            // 
            // LeastWork
            // 
            this.LeastWork.Location = new System.Drawing.Point(13, 74);
            this.LeastWork.Name = "LeastWork";
            this.LeastWork.Size = new System.Drawing.Size(165, 20);
            this.LeastWork.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "The least experienced candidate:";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(52, 341);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(79, 32);
            this.CloseButton.TabIndex = 11;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // LeastExpensive
            // 
            this.LeastExpensive.Location = new System.Drawing.Point(13, 164);
            this.LeastExpensive.Name = "LeastExpensive";
            this.LeastExpensive.Size = new System.Drawing.Size(165, 20);
            this.LeastExpensive.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "The least expensive candidate:";
            // 
            // MostExpensive
            // 
            this.MostExpensive.Location = new System.Drawing.Point(13, 120);
            this.MostExpensive.Name = "MostExpensive";
            this.MostExpensive.Size = new System.Drawing.Size(165, 20);
            this.MostExpensive.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "The most expensive candidate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Candidates from the same city:";
            // 
            // Cities
            // 
            this.Cities.FormattingEnabled = true;
            this.Cities.Location = new System.Drawing.Point(13, 210);
            this.Cities.Name = "Cities";
            this.Cities.Size = new System.Drawing.Size(165, 121);
            this.Cities.TabIndex = 18;
            // 
            // Analysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 385);
            this.Controls.Add(this.Cities);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LeastExpensive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MostExpensive);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.LeastWork);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MostWork);
            this.Controls.Add(this.label1);
            this.Name = "Analysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analysis";
            this.Load += new System.EventHandler(this.Analysis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MostWork;
        private System.Windows.Forms.TextBox LeastWork;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox LeastExpensive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MostExpensive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox Cities;
    }
}