namespace MyLingvo
{
    partial class WordsEditor
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
            this.ActionLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EnField = new System.Windows.Forms.TextBox();
            this.UaField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EnExField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UaExField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ActionButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ActionLable
            // 
            this.ActionLable.AutoSize = true;
            this.ActionLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionLable.ForeColor = System.Drawing.Color.Teal;
            this.ActionLable.Location = new System.Drawing.Point(204, 21);
            this.ActionLable.Name = "ActionLable";
            this.ActionLable.Size = new System.Drawing.Size(79, 20);
            this.ActionLable.TabIndex = 0;
            this.ActionLable.Text = "Operation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "English text: ";
            // 
            // EnField
            // 
            this.EnField.Location = new System.Drawing.Point(36, 70);
            this.EnField.Name = "EnField";
            this.EnField.Size = new System.Drawing.Size(424, 22);
            this.EnField.TabIndex = 2;
            // 
            // UaField
            // 
            this.UaField.Location = new System.Drawing.Point(36, 115);
            this.UaField.Name = "UaField";
            this.UaField.Size = new System.Drawing.Size(424, 22);
            this.UaField.TabIndex = 4;
            this.UaField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ukranian text: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // EnExField
            // 
            this.EnExField.Location = new System.Drawing.Point(36, 160);
            this.EnExField.Name = "EnExField";
            this.EnExField.Size = new System.Drawing.Size(424, 22);
            this.EnExField.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "English Example:";
            // 
            // UaExField
            // 
            this.UaExField.Location = new System.Drawing.Point(36, 205);
            this.UaExField.Name = "UaExField";
            this.UaExField.Size = new System.Drawing.Size(424, 22);
            this.UaExField.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ukranian Example: ";
            // 
            // ActionButton
            // 
            this.ActionButton.Location = new System.Drawing.Point(90, 256);
            this.ActionButton.Name = "ActionButton";
            this.ActionButton.Size = new System.Drawing.Size(135, 39);
            this.ActionButton.TabIndex = 9;
            this.ActionButton.Text = "Do";
            this.ActionButton.UseVisualStyleBackColor = true;
            this.ActionButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(256, 256);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(135, 39);
            this.ClearButton.TabIndex = 10;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // WordsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 320);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ActionButton);
            this.Controls.Add(this.UaExField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EnExField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UaField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EnField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ActionLable);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WordsEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WordsEditor";
            this.Load += new System.EventHandler(this.WordsEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ActionLable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EnField;
        private System.Windows.Forms.TextBox UaField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EnExField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UaExField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ActionButton;
        private System.Windows.Forms.Button ClearButton;
    }
}