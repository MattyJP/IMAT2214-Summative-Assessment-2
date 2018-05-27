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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SloganLabel = new System.Windows.Forms.Label();
            this.CopyrightsLabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBarRef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxDates
            // 
            this.listBoxDates.FormattingEnabled = true;
            this.listBoxDates.HorizontalScrollbar = true;
            this.listBoxDates.Location = new System.Drawing.Point(22, 50);
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
            this.tabPage1.Controls.Add(this.CopyrightsLabel);
            this.tabPage1.Controls.Add(this.SloganLabel);
            this.tabPage1.Controls.Add(this.pictureBox2);
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
            this.tabPage1.Controls.Add(this.pictureBox1);
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
            this.buttonGetFactTable.Location = new System.Drawing.Point(148, 50);
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
            this.listBoxFactTableFromDbNamed.Location = new System.Drawing.Point(304, 395);
            this.listBoxFactTableFromDbNamed.Name = "listBoxFactTableFromDbNamed";
            this.listBoxFactTableFromDbNamed.Size = new System.Drawing.Size(502, 108);
            this.listBoxFactTableFromDbNamed.TabIndex = 12;
            // 
            // listBoxCustomersFromDbNamed
            // 
            this.listBoxCustomersFromDbNamed.FormattingEnabled = true;
            this.listBoxCustomersFromDbNamed.Location = new System.Drawing.Point(304, 281);
            this.listBoxCustomersFromDbNamed.Name = "listBoxCustomersFromDbNamed";
            this.listBoxCustomersFromDbNamed.Size = new System.Drawing.Size(502, 108);
            this.listBoxCustomersFromDbNamed.TabIndex = 11;
            // 
            // listBoxProductsFromDbNamed
            // 
            this.listBoxProductsFromDbNamed.FormattingEnabled = true;
            this.listBoxProductsFromDbNamed.Location = new System.Drawing.Point(304, 167);
            this.listBoxProductsFromDbNamed.Name = "listBoxProductsFromDbNamed";
            this.listBoxProductsFromDbNamed.Size = new System.Drawing.Size(502, 108);
            this.listBoxProductsFromDbNamed.TabIndex = 10;
            // 
            // listBoxDatesFromDbNamed
            // 
            this.listBoxDatesFromDbNamed.FormattingEnabled = true;
            this.listBoxDatesFromDbNamed.Location = new System.Drawing.Point(304, 50);
            this.listBoxDatesFromDbNamed.Name = "listBoxDatesFromDbNamed";
            this.listBoxDatesFromDbNamed.Size = new System.Drawing.Size(502, 108);
            this.listBoxDatesFromDbNamed.TabIndex = 9;
            // 
            // buttonGetFromDb
            // 
            this.buttonGetFromDb.Location = new System.Drawing.Point(304, 21);
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
            this.listBoxCustomers.Location = new System.Drawing.Point(22, 310);
            this.listBoxCustomers.Name = "listBoxCustomers";
            this.listBoxCustomers.ScrollAlwaysVisible = true;
            this.listBoxCustomers.Size = new System.Drawing.Size(120, 95);
            this.listBoxCustomers.TabIndex = 7;
            // 
            // buttonGetCustomers
            // 
            this.buttonGetCustomers.Location = new System.Drawing.Point(22, 281);
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
            this.listBoxProducts.Location = new System.Drawing.Point(22, 180);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.ScrollAlwaysVisible = true;
            this.listBoxProducts.Size = new System.Drawing.Size(120, 95);
            this.listBoxProducts.TabIndex = 5;
            // 
            // buttonGetProducts
            // 
            this.buttonGetProducts.Location = new System.Drawing.Point(22, 151);
            this.buttonGetProducts.Name = "buttonGetProducts";
            this.buttonGetProducts.Size = new System.Drawing.Size(97, 23);
            this.buttonGetProducts.TabIndex = 4;
            this.buttonGetProducts.Text = "Get Products";
            this.buttonGetProducts.UseVisualStyleBackColor = true;
            this.buttonGetProducts.Click += new System.EventHandler(this.buttonGetProducts_Click);
            // 
            // buttonGetDates
            // 
            this.buttonGetDates.Location = new System.Drawing.Point(22, 21);
            this.buttonGetDates.Name = "buttonGetDates";
            this.buttonGetDates.Size = new System.Drawing.Size(75, 23);
            this.buttonGetDates.TabIndex = 2;
            this.buttonGetDates.Text = "Get Dates";
            this.buttonGetDates.UseVisualStyleBackColor = true;
            this.buttonGetDates.Click += new System.EventHandler(this.buttonGetDates_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.pictureBox4);
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
            this.tabPage2.Controls.Add(this.pictureBox3);
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
            this.labelLoadData.Location = new System.Drawing.Point(70, 119);
            this.labelLoadData.Name = "labelLoadData";
            this.labelLoadData.Size = new System.Drawing.Size(840, 20);
            this.labelLoadData.TabIndex = 4;
            this.labelLoadData.Text = "Click \"Load Data\" to initialise the dashboard! (Make sure you\'ve inserted all the" +
    " data into the destination database first)";
            // 
            // buttonLoadData
            // 
            this.buttonLoadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadData.Location = new System.Drawing.Point(392, 163);
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
            this.labelChartBarRef.Location = new System.Drawing.Point(661, 144);
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
            this.labelChartPie.Location = new System.Drawing.Point(353, 144);
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
            this.labelChartBar.Location = new System.Drawing.Point(59, 144);
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
            this.labelCustReference.Location = new System.Drawing.Point(500, 98);
            this.labelCustReference.Name = "labelCustReference";
            this.labelCustReference.Size = new System.Drawing.Size(221, 16);
            this.labelCustReference.TabIndex = 11;
            this.labelCustReference.Text = "Select a Customer Segment to view:";
            this.labelCustReference.Visible = false;
            // 
            // chartBarRef
            // 
            chartArea13.Name = "ChartArea1";
            this.chartBarRef.ChartAreas.Add(chartArea13);
            legend13.Enabled = false;
            legend13.Name = "Legend1";
            this.chartBarRef.Legends.Add(legend13);
            this.chartBarRef.Location = new System.Drawing.Point(610, 153);
            this.chartBarRef.Name = "chartBarRef";
            series13.ChartArea = "ChartArea1";
            series13.Legend = "Legend1";
            series13.Name = "Series1";
            series13.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartBarRef.Series.Add(series13);
            this.chartBarRef.Size = new System.Drawing.Size(300, 300);
            this.chartBarRef.TabIndex = 10;
            this.chartBarRef.Text = "chart1";
            // 
            // labelRefError
            // 
            this.labelRefError.AutoSize = true;
            this.labelRefError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRefError.ForeColor = System.Drawing.Color.Red;
            this.labelRefError.Location = new System.Drawing.Point(633, 456);
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
            this.comboBoxSearch.Location = new System.Drawing.Point(727, 95);
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
            this.comboBoxWeek.Location = new System.Drawing.Point(298, 97);
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
            this.labelWeek.Location = new System.Drawing.Point(153, 102);
            this.labelWeek.Name = "labelWeek";
            this.labelWeek.Size = new System.Drawing.Size(143, 16);
            this.labelWeek.TabIndex = 5;
            this.labelWeek.Text = "Select a Week to view:";
            this.labelWeek.Visible = false;
            // 
            // chartPie
            // 
            chartArea14.Name = "ChartArea1";
            this.chartPie.ChartAreas.Add(chartArea14);
            legend14.Name = "Legend1";
            this.chartPie.Legends.Add(legend14);
            this.chartPie.Location = new System.Drawing.Point(318, 153);
            this.chartPie.Name = "chartPie";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series14.CustomProperties = "PieLabelStyle=Disabled";
            series14.Legend = "Legend1";
            series14.Name = "Series1";
            this.chartPie.Series.Add(series14);
            this.chartPie.Size = new System.Drawing.Size(300, 300);
            this.chartPie.TabIndex = 2;
            this.chartPie.Text = "chart2";
            // 
            // chartBar
            // 
            chartArea15.Name = "ChartArea1";
            this.chartBar.ChartAreas.Add(chartArea15);
            legend15.Enabled = false;
            legend15.Name = "Legend1";
            this.chartBar.Legends.Add(legend15);
            this.chartBar.Location = new System.Drawing.Point(12, 153);
            this.chartBar.Name = "chartBar";
            series15.ChartArea = "ChartArea1";
            series15.Legend = "Legend1";
            series15.Name = "Series1";
            series15.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartBar.Series.Add(series15);
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
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GITTest.Properties.Resources.GC_LOGO_v2;
            this.pictureBox2.Location = new System.Drawing.Point(863, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 60);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GITTest.Properties.Resources.tabPage1_border;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(858, 539);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // SloganLabel
            // 
            this.SloganLabel.AutoSize = true;
            this.SloganLabel.Location = new System.Drawing.Point(856, 63);
            this.SloganLabel.Name = "SloganLabel";
            this.SloganLabel.Size = new System.Drawing.Size(74, 26);
            this.SloganLabel.TabIndex = 16;
            this.SloganLabel.Text = "Make Generic\r\nMore generic\r\n";
            this.SloganLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CopyrightsLabel
            // 
            this.CopyrightsLabel.AutoSize = true;
            this.CopyrightsLabel.Location = new System.Drawing.Point(726, 510);
            this.CopyrightsLabel.Name = "CopyrightsLabel";
            this.CopyrightsLabel.Size = new System.Drawing.Size(204, 13);
            this.CopyrightsLabel.TabIndex = 17;
            this.CopyrightsLabel.Text = "© 2018 GeneriCorp. All Rights Reserved. ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GITTest.Properties.Resources.tabPage1_border;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(858, 539);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GITTest.Properties.Resources.GC_LOGO_v2;
            this.pictureBox4.Location = new System.Drawing.Point(863, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(67, 60);
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(856, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "Make Generic\r\nMore generic\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(726, 510);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "© 2018 GeneriCorp. All Rights Reserved. ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBarRef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label CopyrightsLabel;
        private System.Windows.Forms.Label SloganLabel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

