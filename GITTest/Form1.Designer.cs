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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnGetDates = new System.Windows.Forms.Button();
            this.listBoxDates = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGetFactTable = new System.Windows.Forms.Button();
            this.buttonGetDates = new System.Windows.Forms.Button();
            this.listBoxDates = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonGetFactTable = new System.Windows.Forms.Button();
            this.listBoxFactTableFromDbNamed = new System.Windows.Forms.ListBox();
            this.listBoxCustomersFromDbNamed = new System.Windows.Forms.ListBox();
            this.listBoxProductsFromDbNamed = new System.Windows.Forms.ListBox();
            this.listBoxDatesFromDbNamed = new System.Windows.Forms.ListBox();
            this.btnGetFromDb = new System.Windows.Forms.Button();
            this.listBoxCustomers = new System.Windows.Forms.ListBox();
            this.btnGetCustomers = new System.Windows.Forms.Button();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.btnGetProducts = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelWeek = new System.Windows.Forms.Label();
            this.labelLoadData = new System.Windows.Forms.Label();
            this.comboBoxWeek = new System.Windows.Forms.ComboBox();
            this.chartPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartBar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.destinationDatabaseDataSet = new GITTest.DestinationDatabaseDataSet();
            this.destinationDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonGetFromDb = new System.Windows.Forms.Button();
            this.listBoxCustomers = new System.Windows.Forms.ListBox();
            this.buttonGetCustomers = new System.Windows.Forms.Button();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.buttonGetProducts = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationDatabaseDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetDates
            // 
            this.btnGetDates.Location = new System.Drawing.Point(18, 6);
            this.btnGetDates.Name = "btnGetDates";
            this.btnGetDates.Size = new System.Drawing.Size(75, 23);
            this.btnGetDates.TabIndex = 2;
            this.btnGetDates.Text = "GetDates";
            this.btnGetDates.UseVisualStyleBackColor = true;
            this.btnGetDates.Click += new System.EventHandler(this.GetDates_Click);
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
            this.tabPage1.Controls.Add(this.btnGetFactTable);
            this.tabPage1.Controls.Add(this.listBoxFactTableFromDbNamed);
            this.tabPage1.Controls.Add(this.listBoxCustomersFromDbNamed);
            this.tabPage1.Controls.Add(this.listBoxProductsFromDbNamed);
            this.tabPage1.Controls.Add(this.listBoxDatesFromDbNamed);
            this.tabPage1.Controls.Add(this.btnGetFromDb);
            this.tabPage1.Controls.Add(this.listBoxCustomers);
            this.tabPage1.Controls.Add(this.btnGetCustomers);
            this.tabPage1.Controls.Add(this.listBoxProducts);
            this.tabPage1.Controls.Add(this.btnGetProducts);
            this.tabPage1.Controls.Add(this.btnGetDates);
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
            // btnGetFactTable
            // 
            this.btnGetFactTable.Location = new System.Drawing.Point(195, 114);
            this.btnGetFactTable.Name = "btnGetFactTable";
            this.btnGetFactTable.Size = new System.Drawing.Size(75, 66);
            this.btnGetFactTable.TabIndex = 13;
            this.btnGetFactTable.Text = "Populate Fact Table";
            this.btnGetFactTable.UseVisualStyleBackColor = true;
            this.btnGetFactTable.Click += new System.EventHandler(this.buttonGetFactTable_Click);
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
            // btnGetFromDb
            // 
            this.btnGetFromDb.Location = new System.Drawing.Point(379, 35);
            this.btnGetFromDb.Name = "btnGetFromDb";
            this.btnGetFromDb.Size = new System.Drawing.Size(75, 23);
            this.btnGetFromDb.TabIndex = 8;
            this.btnGetFromDb.Text = "Get From Db";
            this.btnGetFromDb.UseVisualStyleBackColor = true;
            this.btnGetFromDb.Click += new System.EventHandler(this.buttonGetFromDb_Click);
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
            // btnGetCustomers
            // 
            this.btnGetCustomers.Location = new System.Drawing.Point(18, 266);
            this.btnGetCustomers.Name = "btnGetCustomers";
            this.btnGetCustomers.Size = new System.Drawing.Size(97, 23);
            this.btnGetCustomers.TabIndex = 6;
            this.btnGetCustomers.Text = "Get Customers";
            this.btnGetCustomers.UseVisualStyleBackColor = true;
            this.btnGetCustomers.Click += new System.EventHandler(this.buttonGetCustomers_Click);
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
            // btnGetProducts
            // 
            this.btnGetProducts.Location = new System.Drawing.Point(18, 136);
            this.btnGetProducts.Name = "btnGetProducts";
            this.btnGetProducts.Size = new System.Drawing.Size(97, 23);
            this.btnGetProducts.TabIndex = 4;
            this.btnGetProducts.Text = "Get Products";
            this.btnGetProducts.UseVisualStyleBackColor = true;
            this.btnGetProducts.Click += new System.EventHandler(this.buttonGetProducts_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelWeek);
            this.tabPage2.Controls.Add(this.labelLoadData);
            this.tabPage2.Controls.Add(this.comboBoxWeek);
            this.tabPage2.Controls.Add(this.chartPie);
            this.tabPage2.Controls.Add(this.chartBar);
            this.tabPage2.Controls.Add(this.buttonLoadData);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(934, 526);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelWeek
            // 
            this.labelWeek.AutoSize = true;
            this.labelWeek.Enabled = false;
            this.labelWeek.Location = new System.Drawing.Point(66, 81);
            this.labelWeek.Name = "labelWeek";
            this.labelWeek.Size = new System.Drawing.Size(115, 13);
            this.labelWeek.TabIndex = 5;
            this.labelWeek.Text = "Select a week to view:";
            // 
            // labelLoadData
            // 
            this.labelLoadData.AutoSize = true;
            this.labelLoadData.Location = new System.Drawing.Point(8, 11);
            this.labelLoadData.Name = "labelLoadData";
            this.labelLoadData.Size = new System.Drawing.Size(218, 13);
            this.labelLoadData.TabIndex = 4;
            this.labelLoadData.Text = "Click \"Load Data\" to initialise the dashboard!";
            // 
            // comboBoxWeek
            // 
            this.comboBoxWeek.Enabled = false;
            this.comboBoxWeek.FormattingEnabled = true;
            this.comboBoxWeek.Location = new System.Drawing.Point(187, 78);
            this.comboBoxWeek.Name = "comboBoxWeek";
            this.comboBoxWeek.Size = new System.Drawing.Size(39, 21);
            this.comboBoxWeek.TabIndex = 3;
            this.comboBoxWeek.SelectedIndexChanged += new System.EventHandler(this.comboBoxWeek_SelectedIndexChanged);
            // 
            // chartPie
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPie.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPie.Legends.Add(legend1);
            this.chartPie.Location = new System.Drawing.Point(322, 127);
            this.chartPie.Name = "chartPie";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartPie.Series.Add(series1);
            this.chartPie.Size = new System.Drawing.Size(300, 300);
            this.chartPie.TabIndex = 2;
            this.chartPie.Text = "chart2";
            // 
            // chartBar
            // 
            chartArea2.Name = "ChartArea1";
            this.chartBar.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chartBar.Legends.Add(legend2);
            this.chartBar.Location = new System.Drawing.Point(27, 105);
            this.chartBar.Name = "chartBar";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartBar.Series.Add(series2);
            this.chartBar.Size = new System.Drawing.Size(300, 300);
            this.chartBar.TabIndex = 1;
            this.chartBar.Text = "chart1";
            // 
            // buttonLoadData
            // 
            this.buttonLoadData.Location = new System.Drawing.Point(11, 27);
            this.buttonLoadData.Name = "buttonLoadData";
            this.buttonLoadData.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadData.TabIndex = 0;
            this.buttonLoadData.Text = "Load Data";
            this.buttonLoadData.UseVisualStyleBackColor = true;
            this.buttonLoadData.Click += new System.EventHandler(this.buttonLoadData_Click);
            // 
            // destinationDatabaseDataSet
            // 
            this.destinationDatabaseDataSet.DataSetName = "DestinationDatabaseDataSet";
            this.destinationDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // destinationDatabaseDataSetBindingSource
            // 
            this.destinationDatabaseDataSetBindingSource.DataSource = this.destinationDatabaseDataSet;
            this.destinationDatabaseDataSetBindingSource.Position = 0;
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationDatabaseDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGetDates;
        private System.Windows.Forms.Button buttonGetDates;
        private System.Windows.Forms.ListBox listBoxDates;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listBoxCustomers;
        private System.Windows.Forms.Button btnGetCustomers;
        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.Button btnGetProducts;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBoxFactTableFromDbNamed;
        private System.Windows.Forms.ListBox listBoxCustomersFromDbNamed;
        private System.Windows.Forms.ListBox listBoxProductsFromDbNamed;
        private System.Windows.Forms.ListBox listBoxDatesFromDbNamed;
        private System.Windows.Forms.Button btnGetFromDb;
        private System.Windows.Forms.Button btnGetFactTable;
        private System.Windows.Forms.Button buttonLoadData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPie;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBar;
        private System.Windows.Forms.ComboBox comboBoxWeek;
        private DestinationDatabaseDataSet destinationDatabaseDataSet;
        private System.Windows.Forms.BindingSource destinationDatabaseDataSetBindingSource;
        private System.Windows.Forms.Label labelWeek;
        private System.Windows.Forms.Label labelLoadData;
    }
}

