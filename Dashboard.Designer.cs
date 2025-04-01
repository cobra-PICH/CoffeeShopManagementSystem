using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CoffeeShop_Management
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmbTimeRange = new System.Windows.Forms.ComboBox();
            this.lblTimeRange = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTodaySummary = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTodaySales = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTodayOrders = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPopularItem = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTodayTitle = new System.Windows.Forms.Label();
            this.pnlWeekSummary = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblWeekSales = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblWeekOrders = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblWeekTitle = new System.Windows.Forms.Label();
            this.pnlMonthSummary = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblMonthSales = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblMonthOrders = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMonthTitle = new System.Windows.Forms.Label();
            this.pnlSalesChart = new System.Windows.Forms.Panel();
            this.chartSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlProductChart = new System.Windows.Forms.Panel();
            this.chartProducts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlRecentOrders = new System.Windows.Forms.Panel();
            this.lstRecentOrders = new System.Windows.Forms.ListView();
            this.colOrderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colItems = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblRecentOrders = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlTodaySummary.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlWeekSummary.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlMonthSummary.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pnlSalesChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).BeginInit();
            this.pnlProductChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProducts)).BeginInit();
            this.pnlRecentOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlHeader.Controls.Add(this.btnPrint);
            this.pnlHeader.Controls.Add(this.btnRefresh);
            this.pnlHeader.Controls.Add(this.cmbTimeRange);
            this.pnlHeader.Controls.Add(this.lblTimeRange);
            this.pnlHeader.Controls.Add(this.lblDate);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(984, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(222)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(882, 15);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(90, 30);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print Report";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(786, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 30);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cmbTimeRange
            // 
            this.cmbTimeRange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTimeRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimeRange.FormattingEnabled = true;
            this.cmbTimeRange.Items.AddRange(new object[] {
            "Today",
            "Yesterday",
            "Last 7 Days",
            "This Month",
            "Last Month",
            "This Year"});
            this.cmbTimeRange.Location = new System.Drawing.Point(659, 20);
            this.cmbTimeRange.Name = "cmbTimeRange";
            this.cmbTimeRange.Size = new System.Drawing.Size(121, 21);
            this.cmbTimeRange.TabIndex = 3;
            this.cmbTimeRange.SelectedIndexChanged += new System.EventHandler(this.cmbTimeRange_SelectedIndexChanged);
            // 
            // lblTimeRange
            // 
            this.lblTimeRange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeRange.AutoSize = true;
            this.lblTimeRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeRange.ForeColor = System.Drawing.Color.White;
            this.lblTimeRange.Location = new System.Drawing.Point(578, 21);
            this.lblTimeRange.Name = "lblTimeRange";
            this.lblTimeRange.Size = new System.Drawing.Size(75, 15);
            this.lblTimeRange.TabIndex = 2;
            this.lblTimeRange.Text = "Time Range";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(15, 35);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 15);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(129, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dashboard";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMain.Controls.Add(this.tableLayoutPanel1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 60);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(10);
            this.pnlMain.Size = new System.Drawing.Size(984, 501);
            this.pnlMain.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.pnlTodaySummary, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlWeekSummary, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlMonthSummary, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlSalesChart, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlProductChart, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlRecentOrders, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(964, 481);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlTodaySummary
            // 
            this.pnlTodaySummary.BackColor = System.Drawing.Color.White;
            this.pnlTodaySummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTodaySummary.Controls.Add(this.tableLayoutPanel2);
            this.pnlTodaySummary.Controls.Add(this.lblTodayTitle);
            this.pnlTodaySummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTodaySummary.Location = new System.Drawing.Point(3, 3);
            this.pnlTodaySummary.Name = "pnlTodaySummary";
            this.pnlTodaySummary.Size = new System.Drawing.Size(315, 144);
            this.pnlTodaySummary.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(313, 112);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTodaySales);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(98, 106);
            this.panel1.TabIndex = 0;
            // 
            // lblTodaySales
            // 
            this.lblTodaySales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTodaySales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodaySales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.lblTodaySales.Location = new System.Drawing.Point(0, 25);
            this.lblTodaySales.Name = "lblTodaySales";
            this.lblTodaySales.Size = new System.Drawing.Size(98, 81);
            this.lblTodaySales.TabIndex = 1;
            this.lblTodaySales.Text = "$0.00";
            this.lblTodaySales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTodayOrders);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(107, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(98, 106);
            this.panel2.TabIndex = 1;
            // 
            // lblTodayOrders
            // 
            this.lblTodayOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTodayOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(222)))));
            this.lblTodayOrders.Location = new System.Drawing.Point(0, 25);
            this.lblTodayOrders.Name = "lblTodayOrders";
            this.lblTodayOrders.Size = new System.Drawing.Size(98, 81);
            this.lblTodayOrders.TabIndex = 1;
            this.lblTodayOrders.Text = "0";
            this.lblTodayOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Orders";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblPopularItem);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(211, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(99, 106);
            this.panel3.TabIndex = 2;
            // 
            // lblPopularItem
            // 
            this.lblPopularItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPopularItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopularItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(173)))), ((int)(((byte)(78)))));
            this.lblPopularItem.Location = new System.Drawing.Point(0, 25);
            this.lblPopularItem.Name = "lblPopularItem";
            this.lblPopularItem.Size = new System.Drawing.Size(99, 81);
            this.lblPopularItem.TabIndex = 1;
            this.lblPopularItem.Text = "None";
            this.lblPopularItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Popular Item";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTodayTitle
            // 
            this.lblTodayTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblTodayTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTodayTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayTitle.ForeColor = System.Drawing.Color.White;
            this.lblTodayTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTodayTitle.Name = "lblTodayTitle";
            this.lblTodayTitle.Size = new System.Drawing.Size(313, 30);
            this.lblTodayTitle.TabIndex = 0;
            this.lblTodayTitle.Text = "Today\'s Summary";
            this.lblTodayTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlWeekSummary
            // 
            this.pnlWeekSummary.BackColor = System.Drawing.Color.White;
            this.pnlWeekSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWeekSummary.Controls.Add(this.tableLayoutPanel3);
            this.pnlWeekSummary.Controls.Add(this.lblWeekTitle);
            this.pnlWeekSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWeekSummary.Location = new System.Drawing.Point(324, 3);
            this.pnlWeekSummary.Name = "pnlWeekSummary";
            this.pnlWeekSummary.Size = new System.Drawing.Size(315, 144);
            this.pnlWeekSummary.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(313, 112);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblWeekSales);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 106);
            this.panel4.TabIndex = 0;
            // 
            // lblWeekSales
            // 
            this.lblWeekSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWeekSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeekSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.lblWeekSales.Location = new System.Drawing.Point(0, 25);
            this.lblWeekSales.Name = "lblWeekSales";
            this.lblWeekSales.Size = new System.Drawing.Size(150, 81);
            this.lblWeekSales.TabIndex = 1;
            this.lblWeekSales.Text = "$0.00";
            this.lblWeekSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sales";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblWeekOrders);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(159, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(151, 106);
            this.panel5.TabIndex = 1;
            // 
            // lblWeekOrders
            // 
            this.lblWeekOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWeekOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeekOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(222)))));
            this.lblWeekOrders.Location = new System.Drawing.Point(0, 25);
            this.lblWeekOrders.Name = "lblWeekOrders";
            this.lblWeekOrders.Size = new System.Drawing.Size(151, 81);
            this.lblWeekOrders.TabIndex = 1;
            this.lblWeekOrders.Text = "0";
            this.lblWeekOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Orders";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWeekTitle
            // 
            this.lblWeekTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblWeekTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWeekTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeekTitle.ForeColor = System.Drawing.Color.White;
            this.lblWeekTitle.Location = new System.Drawing.Point(0, 0);
            this.lblWeekTitle.Name = "lblWeekTitle";
            this.lblWeekTitle.Size = new System.Drawing.Size(313, 30);
            this.lblWeekTitle.TabIndex = 0;
            this.lblWeekTitle.Text = "This Week\'s Summary";
            this.lblWeekTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMonthSummary
            // 
            this.pnlMonthSummary.BackColor = System.Drawing.Color.White;
            this.pnlMonthSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMonthSummary.Controls.Add(this.tableLayoutPanel4);
            this.pnlMonthSummary.Controls.Add(this.lblMonthTitle);
            this.pnlMonthSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMonthSummary.Location = new System.Drawing.Point(645, 3);
            this.pnlMonthSummary.Name = "pnlMonthSummary";
            this.pnlMonthSummary.Size = new System.Drawing.Size(316, 144);
            this.pnlMonthSummary.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel7, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(314, 112);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblMonthSales);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(151, 106);
            this.panel6.TabIndex = 0;
            // 
            // lblMonthSales
            // 
            this.lblMonthSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMonthSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.lblMonthSales.Location = new System.Drawing.Point(0, 25);
            this.lblMonthSales.Name = "lblMonthSales";
            this.lblMonthSales.Size = new System.Drawing.Size(151, 81);
            this.lblMonthSales.TabIndex = 1;
            this.lblMonthSales.Text = "$0.00";
            this.lblMonthSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sales";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblMonthOrders);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(160, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(151, 106);
            this.panel7.TabIndex = 1;
            // 
            // lblMonthOrders
            // 
            this.lblMonthOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMonthOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(222)))));
            this.lblMonthOrders.Location = new System.Drawing.Point(0, 25);
            this.lblMonthOrders.Name = "lblMonthOrders";
            this.lblMonthOrders.Size = new System.Drawing.Size(151, 81);
            this.lblMonthOrders.TabIndex = 1;
            this.lblMonthOrders.Text = "0";
            this.lblMonthOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Orders";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonthTitle
            // 
            this.lblMonthTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblMonthTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMonthTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthTitle.ForeColor = System.Drawing.Color.White;
            this.lblMonthTitle.Location = new System.Drawing.Point(0, 0);
            this.lblMonthTitle.Name = "lblMonthTitle";
            this.lblMonthTitle.Size = new System.Drawing.Size(314, 30);
            this.lblMonthTitle.TabIndex = 0;
            this.lblMonthTitle.Text = "This Month\'s Summary";
            this.lblMonthTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSalesChart
            // 
            this.pnlSalesChart.BackColor = System.Drawing.Color.White;
            this.pnlSalesChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSalesChart.Controls.Add(this.chartSales);
            this.pnlSalesChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSalesChart.Location = new System.Drawing.Point(3, 153);
            this.pnlSalesChart.Name = "pnlSalesChart";
            this.pnlSalesChart.Size = new System.Drawing.Size(315, 325);
            this.pnlSalesChart.TabIndex = 3;
            // 
            // chartSales
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSales.ChartAreas.Add(chartArea1);
            this.chartSales.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartSales.Legends.Add(legend1);
            this.chartSales.Location = new System.Drawing.Point(0, 0);
            this.chartSales.Name = "chartSales";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartSales.Series.Add(series1);
            this.chartSales.Size = new System.Drawing.Size(313, 323);
            this.chartSales.TabIndex = 0;
            this.chartSales.Text = "chart1";
            // 
            // pnlProductChart
            // 
            this.pnlProductChart.BackColor = System.Drawing.Color.White;
            this.pnlProductChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProductChart.Controls.Add(this.chartProducts);
            this.pnlProductChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProductChart.Location = new System.Drawing.Point(324, 153);
            this.pnlProductChart.Name = "pnlProductChart";
            this.pnlProductChart.Size = new System.Drawing.Size(315, 325);
            this.pnlProductChart.TabIndex = 4;
            // 
            // chartProducts
            // 
            chartArea2.Name = "ChartArea1";
            this.chartProducts.ChartAreas.Add(chartArea2);
            this.chartProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartProducts.Legends.Add(legend2);
            this.chartProducts.Location = new System.Drawing.Point(0, 0);
            this.chartProducts.Name = "chartProducts";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartProducts.Series.Add(series2);
            this.chartProducts.Size = new System.Drawing.Size(313, 323);
            this.chartProducts.TabIndex = 0;
            this.chartProducts.Text = "chart2";
            // 
            // pnlRecentOrders
            // 
            this.pnlRecentOrders.BackColor = System.Drawing.Color.White;
            this.pnlRecentOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRecentOrders.Controls.Add(this.lstRecentOrders);
            this.pnlRecentOrders.Controls.Add(this.lblRecentOrders);
            this.pnlRecentOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRecentOrders.Location = new System.Drawing.Point(645, 153);
            this.pnlRecentOrders.Name = "pnlRecentOrders";
            this.pnlRecentOrders.Size = new System.Drawing.Size(316, 325);
            this.pnlRecentOrders.TabIndex = 5;
            // 
            // lstRecentOrders
            // 
            this.lstRecentOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colOrderId,
            this.colTime,
            this.colItems,
            this.colTotal,
            this.colStatus});
            this.lstRecentOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstRecentOrders.FullRowSelect = true;
            this.lstRecentOrders.HideSelection = false;
            this.lstRecentOrders.Location = new System.Drawing.Point(0, 30);
            this.lstRecentOrders.Name = "lstRecentOrders";
            this.lstRecentOrders.Size = new System.Drawing.Size(314, 293);
            this.lstRecentOrders.TabIndex = 1;
            this.lstRecentOrders.UseCompatibleStateImageBehavior = false;
            this.lstRecentOrders.View = System.Windows.Forms.View.Details;
            // 
            // colOrderId
            // 
            this.colOrderId.Text = "ID";
            this.colOrderId.Width = 40;
            // 
            // colTime
            // 
            this.colTime.Text = "Time";
            this.colTime.Width = 70;
            // 
            // colItems
            // 
            this.colItems.Text = "Items";
            this.colItems.Width = 100;
            // 
            // colTotal
            // 
            this.colTotal.Text = "Total";
            this.colTotal.Width = 50;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            this.colStatus.Width = 70;
            // 
            // lblRecentOrders
            // 
            this.lblRecentOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblRecentOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRecentOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentOrders.ForeColor = System.Drawing.Color.White;
            this.lblRecentOrders.Location = new System.Drawing.Point(0, 0);
            this.lblRecentOrders.Name = "lblRecentOrders";
            this.lblRecentOrders.Size = new System.Drawing.Size(314, 30);
            this.lblRecentOrders.TabIndex = 0;
            this.lblRecentOrders.Text = "Recent Orders";
            this.lblRecentOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlTodaySummary.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlWeekSummary.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.pnlMonthSummary.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.pnlSalesChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).EndInit();
            this.pnlProductChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartProducts)).EndInit();
            this.pnlRecentOrders.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTimeRange;
        private System.Windows.Forms.ComboBox cmbTimeRange;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlTodaySummary;
        private System.Windows.Forms.Label lblTodayTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTodaySales;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTodayOrders;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPopularItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlWeekSummary;
        private System.Windows.Forms.Label lblWeekTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblWeekSales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblWeekOrders;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlMonthSummary;
        private System.Windows.Forms.Label lblMonthTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblMonthSales;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblMonthOrders;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlSalesChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSales;
        private System.Windows.Forms.Panel pnlProductChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProducts;
        private System.Windows.Forms.Panel pnlRecentOrders;
        private System.Windows.Forms.Label lblRecentOrders;
        private System.Windows.Forms.ListView lstRecentOrders;
        private System.Windows.Forms.ColumnHeader colOrderId;
        private System.Windows.Forms.ColumnHeader colTime;
        private System.Windows.Forms.ColumnHeader colItems;
        private System.Windows.Forms.ColumnHeader colTotal;
        private System.Windows.Forms.ColumnHeader colStatus;
    }
}