namespace MyLingvo
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddWord = new System.Windows.Forms.ToolStripMenuItem();
            this.EditWord = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteWord = new System.Windows.Forms.ToolStripMenuItem();
            this.QuizzMode = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutAuthor = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.TranslateButton = new System.Windows.Forms.Button();
            this.InputWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.WordsList = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TranslatesList = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.UaExample = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.EnExample = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(780, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddWord,
            this.EditWord,
            this.DeleteWord,
            this.QuizzMode});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "&Program";
            // 
            // AddWord
            // 
            this.AddWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddWord.Name = "AddWord";
            this.AddWord.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.AddWord.Size = new System.Drawing.Size(218, 22);
            this.AddWord.Text = "&Add Words";
            this.AddWord.Click += new System.EventHandler(this.AddWord_Click);
            // 
            // EditWord
            // 
            this.EditWord.Name = "EditWord";
            this.EditWord.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.EditWord.Size = new System.Drawing.Size(218, 22);
            this.EditWord.Text = "&Edit Words";
            this.EditWord.Click += new System.EventHandler(this.EditWord_Click);
            // 
            // DeleteWord
            // 
            this.DeleteWord.Name = "DeleteWord";
            this.DeleteWord.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.DeleteWord.Size = new System.Drawing.Size(218, 22);
            this.DeleteWord.Text = "&Delete Words";
            this.DeleteWord.Click += new System.EventHandler(this.DeleteWord_Click);
            // 
            // QuizzMode
            // 
            this.QuizzMode.Name = "QuizzMode";
            this.QuizzMode.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Q)));
            this.QuizzMode.Size = new System.Drawing.Size(218, 22);
            this.QuizzMode.Text = "&Quiz";
            this.QuizzMode.Click += new System.EventHandler(this.quizToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutAuthor});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // AboutAuthor
            // 
            this.AboutAuthor.Name = "AboutAuthor";
            this.AboutAuthor.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.AboutAuthor.Size = new System.Drawing.Size(149, 22);
            this.AboutAuthor.Text = "&Author";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClearButton);
            this.groupBox1.Controls.Add(this.TranslateButton);
            this.groupBox1.Controls.Add(this.InputWord);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(414, 65);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(81, 23);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // TranslateButton
            // 
            this.TranslateButton.Location = new System.Drawing.Point(317, 65);
            this.TranslateButton.Name = "TranslateButton";
            this.TranslateButton.Size = new System.Drawing.Size(81, 23);
            this.TranslateButton.TabIndex = 2;
            this.TranslateButton.Text = "Translate";
            this.TranslateButton.UseVisualStyleBackColor = true;
            this.TranslateButton.Click += new System.EventHandler(this.TranslateButton_Click);
            // 
            // InputWord
            // 
            this.InputWord.Location = new System.Drawing.Point(317, 37);
            this.InputWord.Name = "InputWord";
            this.InputWord.Size = new System.Drawing.Size(178, 22);
            this.InputWord.TabIndex = 1;
            this.InputWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter word in English to translate to Ukrainian:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.WordsList);
            this.groupBox2.Location = new System.Drawing.Point(12, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 216);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "English";
            // 
            // WordsList
            // 
            this.WordsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WordsList.FormattingEnabled = true;
            this.WordsList.ItemHeight = 16;
            this.WordsList.Location = new System.Drawing.Point(3, 18);
            this.WordsList.Name = "WordsList";
            this.WordsList.ScrollAlwaysVisible = true;
            this.WordsList.Size = new System.Drawing.Size(162, 195);
            this.WordsList.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TranslatesList);
            this.groupBox3.Location = new System.Drawing.Point(204, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(168, 216);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ukrainian";
            // 
            // TranslatesList
            // 
            this.TranslatesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TranslatesList.FormattingEnabled = true;
            this.TranslatesList.ItemHeight = 16;
            this.TranslatesList.Location = new System.Drawing.Point(3, 18);
            this.TranslatesList.Name = "TranslatesList";
            this.TranslatesList.ScrollAlwaysVisible = true;
            this.TranslatesList.Size = new System.Drawing.Size(162, 195);
            this.TranslatesList.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.UaExample);
            this.groupBox4.Location = new System.Drawing.Point(595, 130);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(168, 216);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ukrainian Exaple";
            // 
            // UaExample
            // 
            this.UaExample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UaExample.FormattingEnabled = true;
            this.UaExample.ItemHeight = 16;
            this.UaExample.Location = new System.Drawing.Point(3, 18);
            this.UaExample.Name = "UaExample";
            this.UaExample.ScrollAlwaysVisible = true;
            this.UaExample.Size = new System.Drawing.Size(162, 195);
            this.UaExample.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.EnExample);
            this.groupBox5.Location = new System.Drawing.Point(403, 130);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(168, 216);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "English Example";
            // 
            // EnExample
            // 
            this.EnExample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnExample.FormattingEnabled = true;
            this.EnExample.ItemHeight = 16;
            this.EnExample.Location = new System.Drawing.Point(3, 18);
            this.EnExample.Name = "EnExample";
            this.EnExample.ScrollAlwaysVisible = true;
            this.EnExample.Size = new System.Drawing.Size(162, 195);
            this.EnExample.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 358);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interactive Dictionary";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddWord;
        private System.Windows.Forms.ToolStripMenuItem EditWord;
        private System.Windows.Forms.ToolStripMenuItem DeleteWord;
        private System.Windows.Forms.ToolStripMenuItem QuizzMode;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutAuthor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputWord;
        private System.Windows.Forms.Button TranslateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox WordsList;
        private System.Windows.Forms.ListBox TranslatesList;
        private System.Windows.Forms.ListBox UaExample;
        private System.Windows.Forms.ListBox EnExample;
    }
}

