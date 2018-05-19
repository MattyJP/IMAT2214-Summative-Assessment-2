namespace GITTest
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
            this.buttonGetDates = new System.Windows.Forms.Button();
            this.listBoxDates = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonGetFactTable = new System.Windows.Forms.Button();
            this.listBoxFactTableFromDbNamed = new System.Windows.Forms.ListBox();
            this.listBoxCustomersFromDbNamed = new System.Windows.Forms.ListBox();
            this.listBoxProductsFromDbNamed = new System.Windows.Forms.ListBox();
            this.listBoxDatesFromDbNamed = new System.Windows.Forms.ListBox();
            this.buttonGetFromDb = new System.Windows.Forms.Button();
            this.listBoxCustomers = new System.Windows.Forms.ListBox();
            this.buttonGetCustomers = new System.Windows.Forms.Button();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.buttonGetProducts = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelTabTitle = new System.Windows.Forms.Label();
            this.labelInstruction1 = new System.Windows.Forms.Label();
            this.labelInstruction2 = new System.Windows.Forms.Label();
            this.labelInstruction3 = new System.Windows.Forms.Label();
            this.labelInstruction4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGetDates
            // 
            this.buttonGetDates.Location = new System.Drawing.Point(11, 82);
            this.buttonGetDates.Name = "buttonGetDates";
            this.buttonGetDates.Size = new System.Drawing.Size(75, 23);
            this.buttonGetDates.TabIndex = 2;
            this.buttonGetDates.Text = "Get Dates";
            this.buttonGetDates.UseVisualStyleBackColor = true;
            this.buttonGetDates.Click += new System.EventHandler(this.buttonGetDates_Click);
            // 
            // listBoxDates
            // 
            this.listBoxDates.FormattingEnabled = true;
            this.listBoxDates.HorizontalScrollbar = true;
            this.listBoxDates.Location = new System.Drawing.Point(11, 111);
            this.listBoxDates.Name = "listBoxDates";
            this.listBoxDates.ScrollAlwaysVisible = true;
            this.listBoxDates.Size = new System.Drawing.Size(120, 95);
            this.listBoxDates.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(936, 620);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelInstruction4);
            this.tabPage1.Controls.Add(this.labelInstruction3);
            this.tabPage1.Controls.Add(this.labelInstruction2);
            this.tabPage1.Controls.Add(this.labelInstruction1);
            this.tabPage1.Controls.Add(this.labelTabTitle);
            this.tabPage1.Controls.Add(this.buttonGetFactTable);
            this.tabPage1.Controls.Add(this.listBoxFactTableFromDbNamed);
            this.tabPage1.Controls.Add(this.listBoxCustomersFromDbNamed);
            this.tabPage1.Controls.Add(this.listBoxProductsFromDbNamed);
            this.tabPage1.Controls.Add(this.listBoxDatesFromDbNamed);
            this.tabPage1.Controls.Add(this.buttonGetFromDb);
            this.tabPage1.Controls.Add(this.listBoxCustomers);
            this.tabPage1.Controls.Add(this.buttonGetCustomers);
            this.tabPage1.Controls.Add(this.listBoxProducts);
            this.tabPage1.Controls.Add(this.buttonGetProducts);
            this.tabPage1.Controls.Add(this.buttonGetDates);
            this.tabPage1.Controls.Add(this.listBoxDates);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(928, 594);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonGetFactTable
            // 
            this.buttonGetFactTable.Location = new System.Drawing.Point(11, 506);
            this.buttonGetFactTable.Name = "buttonGetFactTable";
            this.buttonGetFactTable.Size = new System.Drawing.Size(335, 66);
            this.buttonGetFactTable.TabIndex = 13;
            this.buttonGetFactTable.Text = "Populate Fact Table";
            this.buttonGetFactTable.UseVisualStyleBackColor = true;
            this.buttonGetFactTable.Click += new System.EventHandler(this.buttonGetFactTable_Click);
            // 
            // listBoxFactTableFromDbNamed
            // 
            this.listBoxFactTableFromDbNamed.FormattingEnabled = true;
            this.listBoxFactTableFromDbNamed.Location = new System.Drawing.Point(415, 472);
            this.listBoxFactTableFromDbNamed.Name = "listBoxFactTableFromDbNamed";
            this.listBoxFactTableFromDbNamed.Size = new System.Drawing.Size(502, 108);
            this.listBoxFactTableFromDbNamed.TabIndex = 12;
            // 
            // listBoxCustomersFromDbNamed
            // 
            this.listBoxCustomersFromDbNamed.FormattingEnabled = true;
            this.listBoxCustomersFromDbNamed.Location = new System.Drawing.Point(415, 358);
            this.listBoxCustomersFromDbNamed.Name = "listBoxCustomersFromDbNamed";
            this.listBoxCustomersFromDbNamed.Size = new System.Drawing.Size(502, 108);
            this.listBoxCustomersFromDbNamed.TabIndex = 11;
            // 
            // listBoxProductsFromDbNamed
            // 
            this.listBoxProductsFromDbNamed.FormattingEnabled = true;
            this.listBoxProductsFromDbNamed.Location = new System.Drawing.Point(415, 244);
            this.listBoxProductsFromDbNamed.Name = "listBoxProductsFromDbNamed";
            this.listBoxProductsFromDbNamed.Size = new System.Drawing.Size(502, 108);
            this.listBoxProductsFromDbNamed.TabIndex = 10;
            // 
            // listBoxDatesFromDbNamed
            // 
            this.listBoxDatesFromDbNamed.FormattingEnabled = true;
            this.listBoxDatesFromDbNamed.Location = new System.Drawing.Point(415, 127);
            this.listBoxDatesFromDbNamed.Name = "listBoxDatesFromDbNamed";
            this.listBoxDatesFromDbNamed.Size = new System.Drawing.Size(502, 108);
            this.listBoxDatesFromDbNamed.TabIndex = 9;
            // 
            // buttonGetFromDb
            // 
            this.buttonGetFromDb.Location = new System.Drawing.Point(415, 98);
            this.buttonGetFromDb.Name = "buttonGetFromDb";
            this.buttonGetFromDb.Size = new System.Drawing.Size(119, 23);
            this.buttonGetFromDb.TabIndex = 8;
            this.buttonGetFromDb.Text = "Get From Database";
            this.buttonGetFromDb.UseVisualStyleBackColor = true;
            this.buttonGetFromDb.Click += new System.EventHandler(this.buttonGetFromDb_Click);
            // 
            // listBoxCustomers
            // 
            this.listBoxCustomers.FormattingEnabled = true;
            this.listBoxCustomers.HorizontalScrollbar = true;
            this.listBoxCustomers.Location = new System.Drawing.Point(11, 371);
            this.listBoxCustomers.Name = "listBoxCustomers";
            this.listBoxCustomers.ScrollAlwaysVisible = true;
            this.listBoxCustomers.Size = new System.Drawing.Size(328, 95);
            this.listBoxCustomers.TabIndex = 7;
            // 
            // buttonGetCustomers
            // 
            this.buttonGetCustomers.Location = new System.Drawing.Point(11, 342);
            this.buttonGetCustomers.Name = "buttonGetCustomers";
            this.buttonGetCustomers.Size = new System.Drawing.Size(97, 23);
            this.buttonGetCustomers.TabIndex = 6;
            this.buttonGetCustomers.Text = "Get Customers";
            this.buttonGetCustomers.UseVisualStyleBackColor = true;
            this.buttonGetCustomers.Click += new System.EventHandler(this.buttonGetCustomers_Click);
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.HorizontalScrollbar = true;
            this.listBoxProducts.Location = new System.Drawing.Point(11, 241);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.ScrollAlwaysVisible = true;
            this.listBoxProducts.Size = new System.Drawing.Size(328, 95);
            this.listBoxProducts.TabIndex = 5;
            // 
            // buttonGetProducts
            // 
            this.buttonGetProducts.Location = new System.Drawing.Point(11, 212);
            this.buttonGetProducts.Name = "buttonGetProducts";
            this.buttonGetProducts.Size = new System.Drawing.Size(97, 23);
            this.buttonGetProducts.TabIndex = 4;
            this.buttonGetProducts.Text = "Get Products";
            this.buttonGetProducts.UseVisualStyleBackColor = true;
            this.buttonGetProducts.Click += new System.EventHandler(this.buttonGetProducts_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(934, 526);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelTabTitle
            // 
            this.labelTabTitle.AutoSize = true;
            this.labelTabTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTabTitle.Location = new System.Drawing.Point(6, 14);
            this.labelTabTitle.Name = "labelTabTitle";
            this.labelTabTitle.Size = new System.Drawing.Size(369, 25);
            this.labelTabTitle.TabIndex = 14;
            this.labelTabTitle.Text = "Welcome to the Data Population Tab!";
            // 
            // labelInstruction1
            // 
            this.labelInstruction1.AutoSize = true;
            this.labelInstruction1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstruction1.Location = new System.Drawing.Point(8, 55);
            this.labelInstruction1.Name = "labelInstruction1";
            this.labelInstruction1.Size = new System.Drawing.Size(380, 13);
            this.labelInstruction1.TabIndex = 15;
            this.labelInstruction1.Text = "To populate the destination database from the dataset, click the buttons below!";
            // 
            // labelInstruction2
            // 
            this.labelInstruction2.AutoSize = true;
            this.labelInstruction2.Location = new System.Drawing.Point(412, 42);
            this.labelInstruction2.Name = "labelInstruction2";
            this.labelInstruction2.Size = new System.Drawing.Size(366, 13);
            this.labelInstruction2.TabIndex = 16;
            this.labelInstruction2.Text = "Click \"Get From Database\" to pull every entry from the destination database!";
            // 
            // labelInstruction3
            // 
            this.labelInstruction3.AutoSize = true;
            this.labelInstruction3.Location = new System.Drawing.Point(412, 64);
            this.labelInstruction3.Name = "labelInstruction3";
            this.labelInstruction3.Size = new System.Drawing.Size(396, 13);
            this.labelInstruction3.TabIndex = 17;
            this.labelInstruction3.Text = "They are empty until you populate them using the controls on the left of the scre" +
    "en!";
            // 
            // labelInstruction4
            // 
            this.labelInstruction4.AutoSize = true;
            this.labelInstruction4.Location = new System.Drawing.Point(11, 478);
            this.labelInstruction4.Name = "labelInstruction4";
            this.labelInstruction4.Size = new System.Drawing.Size(377, 13);
            this.labelInstruction4.TabIndex = 18;
            this.labelInstruction4.Text = "After creating the dimensions, click the button below to populate the fact table!" +
    "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 644);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonGetDates;
        private System.Windows.Forms.ListBox listBoxDates;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listBoxCustomers;
        private System.Windows.Forms.Button buttonGetCustomers;
        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.Button buttonGetProducts;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBoxFactTableFromDbNamed;
        private System.Windows.Forms.ListBox listBoxCustomersFromDbNamed;
        private System.Windows.Forms.ListBox listBoxProductsFromDbNamed;
        private System.Windows.Forms.ListBox listBoxDatesFromDbNamed;
        private System.Windows.Forms.Button buttonGetFromDb;
        private System.Windows.Forms.Button buttonGetFactTable;
        private System.Windows.Forms.Label labelTabTitle;
        private System.Windows.Forms.Label labelInstruction3;
        private System.Windows.Forms.Label labelInstruction2;
        private System.Windows.Forms.Label labelInstruction1;
        private System.Windows.Forms.Label labelInstruction4;
    }
}

