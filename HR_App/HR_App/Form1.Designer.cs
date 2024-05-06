namespace HR_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EmpsList = new System.Windows.Forms.ListBox();
            this.EmployersList = new System.Windows.Forms.Label();
            this.ClearDepButton = new System.Windows.Forms.Button();
            this.AddDepButton = new System.Windows.Forms.Button();
            this.DepName = new System.Windows.Forms.TextBox();
            this.DepsList = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EmpClearButton = new System.Windows.Forms.Button();
            this.EmpTransferButton = new System.Windows.Forms.Button();
            this.EmpDeleteButton = new System.Windows.Forms.Button();
            this.EmpSaveButton = new System.Windows.Forms.Button();
            this.EmpAddButton = new System.Windows.Forms.Button();
            this.EmpPosition = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmpPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmpMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmpBirth = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.EmpName = new System.Windows.Forms.TextBox();
            this.Emplo = new System.Windows.Forms.Label();
            this.EmployerPhotoBox = new System.Windows.Forms.GroupBox();
            this.EmpPhoto = new System.Windows.Forms.PictureBox();
            this.EditPhotoButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.EmployerPhotoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EmpsList);
            this.groupBox1.Controls.Add(this.EmployersList);
            this.groupBox1.Controls.Add(this.ClearDepButton);
            this.groupBox1.Controls.Add(this.AddDepButton);
            this.groupBox1.Controls.Add(this.DepName);
            this.groupBox1.Controls.Add(this.DepsList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Departments Management";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // EmpsList
            // 
            this.EmpsList.FormattingEnabled = true;
            this.EmpsList.Location = new System.Drawing.Point(3, 140);
            this.EmpsList.Name = "EmpsList";
            this.EmpsList.ScrollAlwaysVisible = true;
            this.EmpsList.Size = new System.Drawing.Size(191, 303);
            this.EmpsList.TabIndex = 5;
            this.EmpsList.SelectedIndexChanged += new System.EventHandler(this.EmpsList_SelectedIndexChanged);
            // 
            // EmployersList
            // 
            this.EmployersList.AutoSize = true;
            this.EmployersList.Location = new System.Drawing.Point(6, 115);
            this.EmployersList.Name = "EmployersList";
            this.EmployersList.Size = new System.Drawing.Size(58, 13);
            this.EmployersList.TabIndex = 4;
            this.EmployersList.Text = "Employers:";
            this.EmployersList.Click += new System.EventHandler(this.label1_Click);
            // 
            // ClearDepButton
            // 
            this.ClearDepButton.Location = new System.Drawing.Point(105, 69);
            this.ClearDepButton.Name = "ClearDepButton";
            this.ClearDepButton.Size = new System.Drawing.Size(89, 32);
            this.ClearDepButton.TabIndex = 3;
            this.ClearDepButton.Text = "Clear";
            this.ClearDepButton.UseVisualStyleBackColor = true;
            this.ClearDepButton.Click += new System.EventHandler(this.ClearDepButton_Click);
            // 
            // AddDepButton
            // 
            this.AddDepButton.Location = new System.Drawing.Point(3, 69);
            this.AddDepButton.Name = "AddDepButton";
            this.AddDepButton.Size = new System.Drawing.Size(96, 32);
            this.AddDepButton.TabIndex = 2;
            this.AddDepButton.Text = "Add";
            this.AddDepButton.UseVisualStyleBackColor = true;
            this.AddDepButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // DepName
            // 
            this.DepName.Location = new System.Drawing.Point(3, 43);
            this.DepName.Name = "DepName";
            this.DepName.Size = new System.Drawing.Size(191, 20);
            this.DepName.TabIndex = 1;
            // 
            // DepsList
            // 
            this.DepsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepsList.FormattingEnabled = true;
            this.DepsList.Location = new System.Drawing.Point(3, 16);
            this.DepsList.Name = "DepsList";
            this.DepsList.Size = new System.Drawing.Size(191, 21);
            this.DepsList.TabIndex = 0;
            this.DepsList.SelectedIndexChanged += new System.EventHandler(this.DepsList_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EmpClearButton);
            this.groupBox2.Controls.Add(this.EmpTransferButton);
            this.groupBox2.Controls.Add(this.EmpDeleteButton);
            this.groupBox2.Controls.Add(this.EmpSaveButton);
            this.groupBox2.Controls.Add(this.EmpAddButton);
            this.groupBox2.Controls.Add(this.EmpPosition);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.EmpPhone);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.EmpMail);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.EmpBirth);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.EmpName);
            this.groupBox2.Controls.Add(this.Emplo);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(525, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 450);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personal Details";
            // 
            // EmpClearButton
            // 
            this.EmpClearButton.Location = new System.Drawing.Point(43, 405);
            this.EmpClearButton.Name = "EmpClearButton";
            this.EmpClearButton.Size = new System.Drawing.Size(96, 32);
            this.EmpClearButton.TabIndex = 13;
            this.EmpClearButton.Text = "Clear";
            this.EmpClearButton.UseVisualStyleBackColor = true;
            this.EmpClearButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // EmpTransferButton
            // 
            this.EmpTransferButton.Location = new System.Drawing.Point(43, 367);
            this.EmpTransferButton.Name = "EmpTransferButton";
            this.EmpTransferButton.Size = new System.Drawing.Size(96, 32);
            this.EmpTransferButton.TabIndex = 12;
            this.EmpTransferButton.Text = "Transfer";
            this.EmpTransferButton.UseVisualStyleBackColor = true;
            // 
            // EmpDeleteButton
            // 
            this.EmpDeleteButton.Location = new System.Drawing.Point(43, 329);
            this.EmpDeleteButton.Name = "EmpDeleteButton";
            this.EmpDeleteButton.Size = new System.Drawing.Size(96, 32);
            this.EmpDeleteButton.TabIndex = 11;
            this.EmpDeleteButton.Text = "Delete";
            this.EmpDeleteButton.UseVisualStyleBackColor = true;
            // 
            // EmpSaveButton
            // 
            this.EmpSaveButton.Location = new System.Drawing.Point(43, 291);
            this.EmpSaveButton.Name = "EmpSaveButton";
            this.EmpSaveButton.Size = new System.Drawing.Size(96, 32);
            this.EmpSaveButton.TabIndex = 10;
            this.EmpSaveButton.Text = "Save";
            this.EmpSaveButton.UseVisualStyleBackColor = true;
            this.EmpSaveButton.Click += new System.EventHandler(this.EmpSaveButton_Click);
            // 
            // EmpAddButton
            // 
            this.EmpAddButton.Location = new System.Drawing.Point(43, 253);
            this.EmpAddButton.Name = "EmpAddButton";
            this.EmpAddButton.Size = new System.Drawing.Size(96, 32);
            this.EmpAddButton.TabIndex = 6;
            this.EmpAddButton.Text = "Add";
            this.EmpAddButton.UseVisualStyleBackColor = true;
            // 
            // EmpPosition
            // 
            this.EmpPosition.Location = new System.Drawing.Point(8, 227);
            this.EmpPosition.Name = "EmpPosition";
            this.EmpPosition.Size = new System.Drawing.Size(176, 20);
            this.EmpPosition.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Position";
            // 
            // EmpPhone
            // 
            this.EmpPhone.Location = new System.Drawing.Point(9, 178);
            this.EmpPhone.Name = "EmpPhone";
            this.EmpPhone.Size = new System.Drawing.Size(176, 20);
            this.EmpPhone.TabIndex = 7;
            this.EmpPhone.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // EmpMail
            // 
            this.EmpMail.Location = new System.Drawing.Point(8, 130);
            this.EmpMail.Name = "EmpMail";
            this.EmpMail.Size = new System.Drawing.Size(176, 20);
            this.EmpMail.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            // 
            // EmpBirth
            // 
            this.EmpBirth.Location = new System.Drawing.Point(9, 85);
            this.EmpBirth.Name = "EmpBirth";
            this.EmpBirth.Size = new System.Drawing.Size(175, 20);
            this.EmpBirth.TabIndex = 3;
            this.EmpBirth.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date Of Birth";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // EmpName
            // 
            this.EmpName.Location = new System.Drawing.Point(8, 45);
            this.EmpName.Name = "EmpName";
            this.EmpName.Size = new System.Drawing.Size(176, 20);
            this.EmpName.TabIndex = 1;
            // 
            // Emplo
            // 
            this.Emplo.AutoSize = true;
            this.Emplo.Location = new System.Drawing.Point(6, 24);
            this.Emplo.Name = "Emplo";
            this.Emplo.Size = new System.Drawing.Size(35, 13);
            this.Emplo.TabIndex = 0;
            this.Emplo.Text = "Name";
            // 
            // EmployerPhotoBox
            // 
            this.EmployerPhotoBox.Controls.Add(this.EmpPhoto);
            this.EmployerPhotoBox.Controls.Add(this.EditPhotoButton);
            this.EmployerPhotoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployerPhotoBox.Location = new System.Drawing.Point(200, 0);
            this.EmployerPhotoBox.Name = "EmployerPhotoBox";
            this.EmployerPhotoBox.Size = new System.Drawing.Size(325, 450);
            this.EmployerPhotoBox.TabIndex = 7;
            this.EmployerPhotoBox.TabStop = false;
            this.EmployerPhotoBox.Text = "Employer Photo";
            // 
            // EmpPhoto
            // 
            this.EmpPhoto.Image = ((System.Drawing.Image)(resources.GetObject("EmpPhoto.Image")));
            this.EmpPhoto.Location = new System.Drawing.Point(6, 19);
            this.EmpPhoto.Name = "EmpPhoto";
            this.EmpPhoto.Size = new System.Drawing.Size(313, 381);
            this.EmpPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EmpPhoto.TabIndex = 7;
            this.EmpPhoto.TabStop = false;
            this.EmpPhoto.Click += new System.EventHandler(this.EmpPhoto_Click);
            // 
            // EditPhotoButton
            // 
            this.EditPhotoButton.Location = new System.Drawing.Point(108, 406);
            this.EditPhotoButton.Name = "EditPhotoButton";
            this.EditPhotoButton.Size = new System.Drawing.Size(89, 32);
            this.EditPhotoButton.TabIndex = 6;
            this.EditPhotoButton.Text = "Edit";
            this.EditPhotoButton.UseVisualStyleBackColor = true;
            this.EditPhotoButton.Click += new System.EventHandler(this.EditPhotoButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.EmployerPhotoBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HR Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.EmployerPhotoBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmpPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox DepName;
        private System.Windows.Forms.ComboBox DepsList;
        private System.Windows.Forms.Button AddDepButton;
        private System.Windows.Forms.Button ClearDepButton;
        private System.Windows.Forms.Label EmployersList;
        private System.Windows.Forms.ListBox EmpsList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox EmployerPhotoBox;
        private System.Windows.Forms.Button EditPhotoButton;
        private System.Windows.Forms.PictureBox EmpPhoto;
        private System.Windows.Forms.Label Emplo;
        private System.Windows.Forms.TextBox EmpName;
        private System.Windows.Forms.DateTimePicker EmpBirth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmpMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmpPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmpPosition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EmpDeleteButton;
        private System.Windows.Forms.Button EmpSaveButton;
        private System.Windows.Forms.Button EmpAddButton;
        private System.Windows.Forms.Button EmpTransferButton;
        private System.Windows.Forms.Button EmpClearButton;
    }
}

