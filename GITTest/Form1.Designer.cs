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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.buttonGetDates = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelLoadData = new System.Windows.Forms.Label();
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.labelChartBarRef = new System.Windows.Forms.Label();
            this.labelChartPie = new System.Windows.Forms.Label();
            this.labelChartBar = new System.Windows.Forms.Label();
            this.labelCustReference = new System.Windows.Forms.Label();
            this.chartBarRef = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelRefError = new System.Windows.Forms.Label();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.comboBoxWeek = new System.Windows.Forms.ComboBox();
            this.labelWeek = new System.Windows.Forms.Label();
            this.chartPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartBar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.destinationDatabaseDataSet = new GITTest.DestinationDatabaseDataSet();
            this.destinationDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBarRef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationDatabaseDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(938, 552);
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
            this.tabPage1.Size = new System.Drawing.Size(930, 526);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelLoadData);
            this.tabPage2.Controls.Add(this.buttonLoadData);
            this.tabPage2.Controls.Add(this.labelChartBarRef);
            this.tabPage2.Controls.Add(this.labelChartPie);
            this.tabPage2.Controls.Add(this.labelChartBar);
            this.tabPage2.Controls.Add(this.labelCustReference);
            this.tabPage2.Controls.Add(this.chartBarRef);
            this.tabPage2.Controls.Add(this.labelRefError);
            this.tabPage2.Controls.Add(this.comboBoxSearch);
            this.tabPage2.Controls.Add(this.comboBoxWeek);
            this.tabPage2.Controls.Add(this.labelWeek);
            this.tabPage2.Controls.Add(this.chartPie);
            this.tabPage2.Controls.Add(this.chartBar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(930, 526);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelLoadData
            // 
            this.labelLoadData.AutoSize = true;
            this.labelLoadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoadData.Location = new System.Drawing.Point(66, 32);
            this.labelLoadData.Name = "labelLoadData";
            this.labelLoadData.Size = new System.Drawing.Size(840, 20);
            this.labelLoadData.TabIndex = 4;
            this.labelLoadData.Text = "Click \"Load Data\" to initialise the dashboard! (Make sure you\'ve inserted all the" +
    " data into the destination database first)";
            // 
            // buttonLoadData
            // 
            this.buttonLoadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadData.Location = new System.Drawing.Point(388, 76);
            this.buttonLoadData.Name = "buttonLoadData";
            this.buttonLoadData.Size = new System.Drawing.Size(111, 49);
            this.buttonLoadData.TabIndex = 0;
            this.buttonLoadData.Text = "Load Data";
            this.buttonLoadData.UseVisualStyleBackColor = true;
            this.buttonLoadData.Click += new System.EventHandler(this.buttonLoadData_Click);
            // 
            // labelChartBarRef
            // 
            this.labelChartBarRef.AutoSize = true;
            this.labelChartBarRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChartBarRef.Location = new System.Drawing.Point(657, 57);
            this.labelChartBarRef.Name = "labelChartBarRef";
            this.labelChartBarRef.Size = new System.Drawing.Size(249, 16);
            this.labelChartBarRef.TabIndex = 14;
            this.labelChartBarRef.Text = "Total Daily Sales by Customer Segment:";
            this.labelChartBarRef.Visible = false;
            // 
            // labelChartPie
            // 
            this.labelChartPie.AutoSize = true;
            this.labelChartPie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChartPie.Location = new System.Drawing.Point(349, 57);
            this.labelChartPie.Name = "labelChartPie";
            this.labelChartPie.Size = new System.Drawing.Size(220, 16);
            this.labelChartPie.TabIndex = 13;
            this.labelChartPie.Text = "Weekly Sales by Product Category:";
            this.labelChartPie.Visible = false;
            // 
            // labelChartBar
            // 
            this.labelChartBar.AutoSize = true;
            this.labelChartBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChartBar.Location = new System.Drawing.Point(55, 57);
            this.labelChartBar.Name = "labelChartBar";
            this.labelChartBar.Size = new System.Drawing.Size(126, 16);
            this.labelChartBar.TabIndex = 12;
            this.labelChartBar.Text = "Total Sales by Day:";
            this.labelChartBar.Visible = false;
            // 
            // labelCustReference
            // 
            this.labelCustReference.AutoSize = true;
            this.labelCustReference.Enabled = false;
            this.labelCustReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustReference.Location = new System.Drawing.Point(496, 11);
            this.labelCustReference.Name = "labelCustReference";
            this.labelCustReference.Size = new System.Drawing.Size(221, 16);
            this.labelCustReference.TabIndex = 11;
            this.labelCustReference.Text = "Select a Customer Segment to view:";
            this.labelCustReference.Visible = false;
            // 
            // chartBarRef
            // 
            chartArea1.Name = "ChartArea1";
            this.chartBarRef.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartBarRef.Legends.Add(legend1);
            this.chartBarRef.Location = new System.Drawing.Point(606, 66);
            this.chartBarRef.Name = "chartBarRef";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartBarRef.Series.Add(series1);
            this.chartBarRef.Size = new System.Drawing.Size(300, 300);
            this.chartBarRef.TabIndex = 10;
            this.chartBarRef.Text = "chart1";
            // 
            // labelRefError
            // 
            this.labelRefError.AutoSize = true;
            this.labelRefError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRefError.ForeColor = System.Drawing.Color.Red;
            this.labelRefError.Location = new System.Drawing.Point(629, 369);
            this.labelRefError.Name = "labelRefError";
            this.labelRefError.Size = new System.Drawing.Size(277, 16);
            this.labelRefError.TabIndex = 9;
            this.labelRefError.Text = "No sales for this customer segment this week!";
            this.labelRefError.Visible = false;
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Location = new System.Drawing.Point(723, 8);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSearch.TabIndex = 8;
            this.comboBoxSearch.Visible = false;
            this.comboBoxSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearch_SelectedIndexChanged_1);
            // 
            // comboBoxWeek
            // 
            this.comboBoxWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxWeek.FormattingEnabled = true;
            this.comboBoxWeek.Location = new System.Drawing.Point(294, 10);
            this.comboBoxWeek.Name = "comboBoxWeek";
            this.comboBoxWeek.Size = new System.Drawing.Size(121, 24);
            this.comboBoxWeek.TabIndex = 7;
            this.comboBoxWeek.Visible = false;
            this.comboBoxWeek.SelectedIndexChanged += new System.EventHandler(this.comboBoxWeek_SelectedIndexChanged_1);
            // 
            // labelWeek
            // 
            this.labelWeek.AutoSize = true;
            this.labelWeek.Enabled = false;
            this.labelWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeek.Location = new System.Drawing.Point(149, 15);
            this.labelWeek.Name = "labelWeek";
            this.labelWeek.Size = new System.Drawing.Size(143, 16);
            this.labelWeek.TabIndex = 5;
            this.labelWeek.Text = "Select a Week to view:";
            this.labelWeek.Visible = false;
            // 
            // chartPie
            // 
            chartArea2.Name = "ChartArea1";
            this.chartPie.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartPie.Legends.Add(legend2);
            this.chartPie.Location = new System.Drawing.Point(314, 66);
            this.chartPie.Name = "chartPie";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.CustomProperties = "PieLabelStyle=Disabled";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartPie.Series.Add(series2);
            this.chartPie.Size = new System.Drawing.Size(300, 300);
            this.chartPie.TabIndex = 2;
            this.chartPie.Text = "chart2";
            // 
            // chartBar
            // 
            chartArea3.Name = "ChartArea1";
            this.chartBar.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chartBar.Legends.Add(legend3);
            this.chartBar.Location = new System.Drawing.Point(8, 66);
            this.chartBar.Name = "chartBar";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartBar.Series.Add(series3);
            this.chartBar.Size = new System.Drawing.Size(300, 300);
            this.chartBar.TabIndex = 1;
            this.chartBar.Text = "chart1";
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 576);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBarRef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationDatabaseDataSetBindingSource)).EndInit();
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
        private System.Windows.Forms.Button buttonLoadData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPie;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBar;
        private DestinationDatabaseDataSet destinationDatabaseDataSet;
        private System.Windows.Forms.BindingSource destinationDatabaseDataSetBindingSource;
        private System.Windows.Forms.Label labelWeek;
        private System.Windows.Forms.Label labelLoadData;
        private System.Windows.Forms.ComboBox comboBoxWeek;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.Label labelRefError;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBarRef;
        private System.Windows.Forms.Label labelCustReference;
        private System.Windows.Forms.Label labelChartBarRef;
        private System.Windows.Forms.Label labelChartPie;
        private System.Windows.Forms.Label labelChartBar;
    }
}

