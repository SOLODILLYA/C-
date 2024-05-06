namespace Converter
{
    partial class Form1
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
            this.tempF = new System.Windows.Forms.TextBox();
            this.tempC = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tempreture (Farenheight):";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tempreture (Celcius):";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tempF
            // 
            this.tempF.ForeColor = System.Drawing.Color.Green;
            this.tempF.Location = new System.Drawing.Point(104, 64);
            this.tempF.Name = "tempF";
            this.tempF.Size = new System.Drawing.Size(126, 20);
            this.tempF.TabIndex = 2;
            this.tempF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tempC
            // 
            this.tempC.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tempC.ForeColor = System.Drawing.Color.Red;
            this.tempC.Location = new System.Drawing.Point(573, 64);
            this.tempC.Name = "tempC";
            this.tempC.ReadOnly = true;
            this.tempC.Size = new System.Drawing.Size(126, 20);
            this.tempC.TabIndex = 3;
            this.tempC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tempC.TextChanged += new System.EventHandler(this.tempC_TextChanged);
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(277, 156);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(112, 49);
            this.calcButton.TabIndex = 4;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(395, 156);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(112, 49);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 262);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.tempC);
            this.Controls.Add(this.tempF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tempreture Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tempF;
        private System.Windows.Forms.TextBox tempC;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button clearButton;
    }
}

