namespace EstimateCalcCSharp
{
    partial class AddCircles
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
            this.Caption = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RadiusField = new System.Windows.Forms.TextBox();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Caption
            // 
            this.Caption.AutoSize = true;
            this.Caption.Location = new System.Drawing.Point(174, 41);
            this.Caption.Name = "Caption";
            this.Caption.Size = new System.Drawing.Size(70, 13);
            this.Caption.TabIndex = 0;
            this.Caption.Text = "Circle No _/_";
            this.Caption.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Radius :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // RadiusField
            // 
            this.RadiusField.Location = new System.Drawing.Point(207, 103);
            this.RadiusField.Name = "RadiusField";
            this.RadiusField.Size = new System.Drawing.Size(100, 20);
            this.RadiusField.TabIndex = 2;
            this.RadiusField.Text = "0";
            this.RadiusField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ContinueButton
            // 
            this.ContinueButton.Location = new System.Drawing.Point(125, 146);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(88, 40);
            this.ContinueButton.TabIndex = 3;
            this.ContinueButton.Text = "Continue";
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(219, 146);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(88, 40);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AddCircles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 211);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ContinueButton);
            this.Controls.Add(this.RadiusField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Caption);
            this.Name = "AddCircles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddCircles";
            this.Load += new System.EventHandler(this.AddCircles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Caption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RadiusField;
        private System.Windows.Forms.Button ContinueButton;
        private System.Windows.Forms.Button ClearButton;
    }
}