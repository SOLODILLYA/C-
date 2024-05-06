namespace SupplyCatalog
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
            this.ProductsList = new System.Windows.Forms.ListBox();
            this.ProductsTitle = new System.Windows.Forms.Label();
            this.ClearCategoryButton = new System.Windows.Forms.Button();
            this.AddCategoryButton = new System.Windows.Forms.Button();
            this.CategoryName = new System.Windows.Forms.TextBox();
            this.CategoryList = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EmployerPhotoBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EmpClearButton = new System.Windows.Forms.Button();
            this.EmpTransferButton = new System.Windows.Forms.Button();
            this.EmpDeleteButton = new System.Windows.Forms.Button();
            this.EmpSaveButton = new System.Windows.Forms.Button();
            this.EmpAddButton = new System.Windows.Forms.Button();
            this.ProductQuantity = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.Label();
            this.ProductPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.Emplo = new System.Windows.Forms.Label();
            this.ProductPhoto = new System.Windows.Forms.PictureBox();
            this.EditPhotoButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.EmployerPhotoBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsList
            // 
            this.ProductsList.FormattingEnabled = true;
            this.ProductsList.Location = new System.Drawing.Point(3, 140);
            this.ProductsList.Name = "ProductsList";
            this.ProductsList.ScrollAlwaysVisible = true;
            this.ProductsList.Size = new System.Drawing.Size(191, 303);
            this.ProductsList.TabIndex = 5;
            this.ProductsList.SelectedIndexChanged += new System.EventHandler(this.ProductsList_SelectedIndexChanged);
            // 
            // ProductsTitle
            // 
            this.ProductsTitle.AutoSize = true;
            this.ProductsTitle.Location = new System.Drawing.Point(6, 115);
            this.ProductsTitle.Name = "ProductsTitle";
            this.ProductsTitle.Size = new System.Drawing.Size(52, 13);
            this.ProductsTitle.TabIndex = 4;
            this.ProductsTitle.Text = "Products:";
            // 
            // ClearCategoryButton
            // 
            this.ClearCategoryButton.Location = new System.Drawing.Point(105, 75);
            this.ClearCategoryButton.Name = "ClearCategoryButton";
            this.ClearCategoryButton.Size = new System.Drawing.Size(89, 32);
            this.ClearCategoryButton.TabIndex = 3;
            this.ClearCategoryButton.Text = "Clear";
            this.ClearCategoryButton.UseVisualStyleBackColor = true;
            // 
            // AddCategoryButton
            // 
            this.AddCategoryButton.Location = new System.Drawing.Point(6, 75);
            this.AddCategoryButton.Name = "AddCategoryButton";
            this.AddCategoryButton.Size = new System.Drawing.Size(96, 32);
            this.AddCategoryButton.TabIndex = 2;
            this.AddCategoryButton.Text = "Add";
            this.AddCategoryButton.UseVisualStyleBackColor = true;
            // 
            // CategoryName
            // 
            this.CategoryName.Location = new System.Drawing.Point(6, 49);
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Size = new System.Drawing.Size(191, 20);
            this.CategoryName.TabIndex = 1;
            // 
            // CategoryList
            // 
            this.CategoryList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryList.FormattingEnabled = true;
            this.CategoryList.Location = new System.Drawing.Point(6, 22);
            this.CategoryList.Name = "CategoryList";
            this.CategoryList.Size = new System.Drawing.Size(191, 21);
            this.CategoryList.TabIndex = 0;
            this.CategoryList.SelectedIndexChanged += new System.EventHandler(this.DepsList_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProductsList);
            this.groupBox1.Controls.Add(this.ProductsTitle);
            this.groupBox1.Controls.Add(this.ClearCategoryButton);
            this.groupBox1.Controls.Add(this.AddCategoryButton);
            this.groupBox1.Controls.Add(this.CategoryName);
            this.groupBox1.Controls.Add(this.CategoryList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 450);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categories Management";
            // 
            // EmployerPhotoBox
            // 
            this.EmployerPhotoBox.Controls.Add(this.groupBox2);
            this.EmployerPhotoBox.Controls.Add(this.ProductPhoto);
            this.EmployerPhotoBox.Controls.Add(this.EditPhotoButton);
            this.EmployerPhotoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployerPhotoBox.Location = new System.Drawing.Point(200, 0);
            this.EmployerPhotoBox.Name = "EmployerPhotoBox";
            this.EmployerPhotoBox.Size = new System.Drawing.Size(600, 450);
            this.EmployerPhotoBox.TabIndex = 8;
            this.EmployerPhotoBox.TabStop = false;
            this.EmployerPhotoBox.Text = "Product Photo";
            this.EmployerPhotoBox.Enter += new System.EventHandler(this.EmployerPhotoBox_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EmpClearButton);
            this.groupBox2.Controls.Add(this.EmpTransferButton);
            this.groupBox2.Controls.Add(this.EmpDeleteButton);
            this.groupBox2.Controls.Add(this.EmpSaveButton);
            this.groupBox2.Controls.Add(this.EmpAddButton);
            this.groupBox2.Controls.Add(this.ProductQuantity);
            this.groupBox2.Controls.Add(this.Quantity);
            this.groupBox2.Controls.Add(this.ProductPrice);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ProductName);
            this.groupBox2.Controls.Add(this.Emplo);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(382, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 431);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Details";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // EmpClearButton
            // 
            this.EmpClearButton.Location = new System.Drawing.Point(60, 349);
            this.EmpClearButton.Name = "EmpClearButton";
            this.EmpClearButton.Size = new System.Drawing.Size(96, 32);
            this.EmpClearButton.TabIndex = 13;
            this.EmpClearButton.Text = "Clear";
            this.EmpClearButton.UseVisualStyleBackColor = true;
            // 
            // EmpTransferButton
            // 
            this.EmpTransferButton.Location = new System.Drawing.Point(60, 311);
            this.EmpTransferButton.Name = "EmpTransferButton";
            this.EmpTransferButton.Size = new System.Drawing.Size(96, 32);
            this.EmpTransferButton.TabIndex = 12;
            this.EmpTransferButton.Text = "Transfer";
            this.EmpTransferButton.UseVisualStyleBackColor = true;
            // 
            // EmpDeleteButton
            // 
            this.EmpDeleteButton.Location = new System.Drawing.Point(60, 273);
            this.EmpDeleteButton.Name = "EmpDeleteButton";
            this.EmpDeleteButton.Size = new System.Drawing.Size(96, 32);
            this.EmpDeleteButton.TabIndex = 11;
            this.EmpDeleteButton.Text = "Delete";
            this.EmpDeleteButton.UseVisualStyleBackColor = true;
            // 
            // EmpSaveButton
            // 
            this.EmpSaveButton.Location = new System.Drawing.Point(60, 235);
            this.EmpSaveButton.Name = "EmpSaveButton";
            this.EmpSaveButton.Size = new System.Drawing.Size(96, 32);
            this.EmpSaveButton.TabIndex = 10;
            this.EmpSaveButton.Text = "Save";
            this.EmpSaveButton.UseVisualStyleBackColor = true;
            // 
            // EmpAddButton
            // 
            this.EmpAddButton.Location = new System.Drawing.Point(60, 197);
            this.EmpAddButton.Name = "EmpAddButton";
            this.EmpAddButton.Size = new System.Drawing.Size(96, 32);
            this.EmpAddButton.TabIndex = 6;
            this.EmpAddButton.Text = "Add";
            this.EmpAddButton.UseVisualStyleBackColor = true;
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.Location = new System.Drawing.Point(11, 124);
            this.ProductQuantity.Name = "ProductQuantity";
            this.ProductQuantity.Size = new System.Drawing.Size(198, 20);
            this.ProductQuantity.TabIndex = 7;
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(10, 99);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(46, 13);
            this.Quantity.TabIndex = 6;
            this.Quantity.Text = "Quantity";
            this.Quantity.Click += new System.EventHandler(this.ProductQuantity_Click);
            // 
            // ProductPrice
            // 
            this.ProductPrice.Location = new System.Drawing.Point(11, 71);
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Size = new System.Drawing.Size(198, 20);
            this.ProductPrice.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Price";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(11, 30);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(198, 20);
            this.ProductName.TabIndex = 1;
            // 
            // Emplo
            // 
            this.Emplo.AutoSize = true;
            this.Emplo.Location = new System.Drawing.Point(10, 14);
            this.Emplo.Name = "Emplo";
            this.Emplo.Size = new System.Drawing.Size(35, 13);
            this.Emplo.TabIndex = 0;
            this.Emplo.Text = "Name";
            // 
            // ProductPhoto
            // 
            this.ProductPhoto.Image = ((System.Drawing.Image)(resources.GetObject("ProductPhoto.Image")));
            this.ProductPhoto.Location = new System.Drawing.Point(6, 19);
            this.ProductPhoto.Name = "ProductPhoto";
            this.ProductPhoto.Size = new System.Drawing.Size(370, 381);
            this.ProductPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductPhoto.TabIndex = 7;
            this.ProductPhoto.TabStop = false;
            this.ProductPhoto.Click += new System.EventHandler(this.EmpPhoto_Click);
            // 
            // EditPhotoButton
            // 
            this.EditPhotoButton.Location = new System.Drawing.Point(146, 406);
            this.EditPhotoButton.Name = "EditPhotoButton";
            this.EditPhotoButton.Size = new System.Drawing.Size(89, 32);
            this.EditPhotoButton.TabIndex = 6;
            this.EditPhotoButton.Text = "Edit";
            this.EditPhotoButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EmployerPhotoBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Supply Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.EmployerPhotoBox.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ProductsList;
        private System.Windows.Forms.Label ProductsTitle;
        private System.Windows.Forms.Button ClearCategoryButton;
        private System.Windows.Forms.Button AddCategoryButton;
        private System.Windows.Forms.TextBox CategoryName;
        private System.Windows.Forms.ComboBox CategoryList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox EmployerPhotoBox;
        private System.Windows.Forms.PictureBox ProductPhoto;
        private System.Windows.Forms.Button EditPhotoButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button EmpClearButton;
        private System.Windows.Forms.Button EmpTransferButton;
        private System.Windows.Forms.Button EmpDeleteButton;
        private System.Windows.Forms.Button EmpSaveButton;
        private System.Windows.Forms.Button EmpAddButton;
        private System.Windows.Forms.TextBox ProductQuantity;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.TextBox ProductPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.Label Emplo;
    }
}

