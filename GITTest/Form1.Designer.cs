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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGetDates
            // 
            this.buttonGetDates.Location = new System.Drawing.Point(18, 6);
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
            this.listBoxDates.Location = new System.Drawing.Point(18, 35);
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
            this.tabControl1.Size = new System.Drawing.Size(942, 552);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
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
            this.tabPage1.Size = new System.Drawing.Size(934, 526);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonGetFactTable
            // 
            this.buttonGetFactTable.Location = new System.Drawing.Point(195, 114);
            this.buttonGetFactTable.Name = "buttonGetFactTable";
            this.buttonGetFactTable.Size = new System.Drawing.Size(75, 66);
            this.buttonGetFactTable.TabIndex = 13;
            this.buttonGetFactTable.Text = "Populate Fact Table";
            this.buttonGetFactTable.UseVisualStyleBackColor = true;
            this.buttonGetFactTable.Click += new System.EventHandler(this.buttonGetFactTable_Click);
            // 
            // listBoxFactTableFromDbNamed
            // 
            this.listBoxFactTableFromDbNamed.FormattingEnabled = true;
            this.listBoxFactTableFromDbNamed.Location = new System.Drawing.Point(379, 409);
            this.listBoxFactTableFromDbNamed.Name = "listBoxFactTableFromDbNamed";
            this.listBoxFactTableFromDbNamed.Size = new System.Drawing.Size(502, 108);
            this.listBoxFactTableFromDbNamed.TabIndex = 12;
            // 
            // listBoxCustomersFromDbNamed
            // 
            this.listBoxCustomersFromDbNamed.FormattingEnabled = true;
            this.listBoxCustomersFromDbNamed.Location = new System.Drawing.Point(379, 295);
            this.listBoxCustomersFromDbNamed.Name = "listBoxCustomersFromDbNamed";
            this.listBoxCustomersFromDbNamed.Size = new System.Drawing.Size(502, 108);
            this.listBoxCustomersFromDbNamed.TabIndex = 11;
            // 
            // listBoxProductsFromDbNamed
            // 
            this.listBoxProductsFromDbNamed.FormattingEnabled = true;
            this.listBoxProductsFromDbNamed.Location = new System.Drawing.Point(379, 181);
            this.listBoxProductsFromDbNamed.Name = "listBoxProductsFromDbNamed";
            this.listBoxProductsFromDbNamed.Size = new System.Drawing.Size(502, 108);
            this.listBoxProductsFromDbNamed.TabIndex = 10;
            // 
            // listBoxDatesFromDbNamed
            // 
            this.listBoxDatesFromDbNamed.FormattingEnabled = true;
            this.listBoxDatesFromDbNamed.Location = new System.Drawing.Point(379, 64);
            this.listBoxDatesFromDbNamed.Name = "listBoxDatesFromDbNamed";
            this.listBoxDatesFromDbNamed.Size = new System.Drawing.Size(502, 108);
            this.listBoxDatesFromDbNamed.TabIndex = 9;
            // 
            // buttonGetFromDb
            // 
            this.buttonGetFromDb.Location = new System.Drawing.Point(379, 35);
            this.buttonGetFromDb.Name = "buttonGetFromDb";
            this.buttonGetFromDb.Size = new System.Drawing.Size(75, 23);
            this.buttonGetFromDb.TabIndex = 8;
            this.buttonGetFromDb.Text = "Get From Db";
            this.buttonGetFromDb.UseVisualStyleBackColor = true;
            this.buttonGetFromDb.Click += new System.EventHandler(this.buttonGetFromDb_Click);
            // 
            // listBoxCustomers
            // 
            this.listBoxCustomers.FormattingEnabled = true;
            this.listBoxCustomers.HorizontalScrollbar = true;
            this.listBoxCustomers.Location = new System.Drawing.Point(18, 295);
            this.listBoxCustomers.Name = "listBoxCustomers";
            this.listBoxCustomers.ScrollAlwaysVisible = true;
            this.listBoxCustomers.Size = new System.Drawing.Size(120, 95);
            this.listBoxCustomers.TabIndex = 7;
            // 
            // buttonGetCustomers
            // 
            this.buttonGetCustomers.Location = new System.Drawing.Point(18, 266);
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
            this.listBoxProducts.Location = new System.Drawing.Point(18, 165);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.ScrollAlwaysVisible = true;
            this.listBoxProducts.Size = new System.Drawing.Size(120, 95);
            this.listBoxProducts.TabIndex = 5;
            // 
            // buttonGetProducts
            // 
            this.buttonGetProducts.Location = new System.Drawing.Point(18, 136);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 576);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
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
    }
}

