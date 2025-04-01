using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CoffeeShop_Management
{
    public partial class Dashboard : Form
    {
        // Sample data for dashboard
        private decimal todaySales = 487.50m;
        private int todayOrders = 24;
        private string popularItem = "Cappuccino";
        private decimal weekSales = 3245.75m;
        private int weekOrders = 168;
        private decimal monthSales = 12750.25m;
        private int monthOrders = 634;

        // Sample data for charts
        private Dictionary<string, int> productSales = new Dictionary<string, int>
        {
            { "Espresso", 42 },
            { "Cappuccino", 78 },
            { "Latte", 65 },
            { "Americano", 53 },
            { "Mocha", 47 },
            { "Macchiato", 31 },
            { "Cold Brew", 38 },
            { "Flat White", 29 }
        };

        private Dictionary<string, decimal> weeklySales = new Dictionary<string, decimal>
        {
            { "Monday", 425.50m },
            { "Tuesday", 387.25m },
            { "Wednesday", 512.75m },
            { "Thursday", 478.00m },
            { "Friday", 625.50m },
            { "Saturday", 542.25m },
            { "Sunday", 274.50m }
        };

        // Sample data for recent orders
        private List<Order> recentOrders = new List<Order>();

        public class Order
        {
            public int OrderId { get; set; }
            public DateTime OrderTime { get; set; }
            public decimal Total { get; set; }
            public string Items { get; set; }
            public string Status { get; set; }
        }

        public Dashboard()
        {
            InitializeComponent();

            // Generate sample recent orders
            GenerateSampleOrders();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Set current date
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy");

            // Update summary cards
            UpdateSummaryCards();

            // Load charts
            LoadSalesChart();
            LoadProductChart();

            // Load recent orders
            LoadRecentOrders();
        }

        private void GenerateSampleOrders()
        {
            // Generate sample orders for today
            Random rnd = new Random();
            string[] statuses = new string[] { "Completed", "In Progress", "Cancelled" };
            string[] itemCombos = new string[]
            {
                "Espresso, Cappuccino",
                "Latte, Mocha",
                "Americano",
                "Cold Brew, Flat White",
                "Cappuccino, Macchiato, Espresso",
                "Mocha, Flat White"
            };

            DateTime today = DateTime.Today;

            for (int i = 1; i <= 10; i++)
            {
                Order order = new Order
                {
                    OrderId = 1000 + i,
                    OrderTime = today.AddHours(9).AddMinutes(rnd.Next(0, 540)), // Between 9 AM and 6 PM
                    Total = Math.Round((decimal)(rnd.Next(500, 3000) / 100.0), 2),
                    Items = itemCombos[rnd.Next(0, itemCombos.Length)],
                    Status = statuses[rnd.Next(0, statuses.Length)]
                };

                recentOrders.Add(order);
            }

            // Sort by order time (newest first)
            recentOrders.Sort((a, b) => b.OrderTime.CompareTo(a.OrderTime));
        }

        private void UpdateSummaryCards()
        {
            // Update today's summary
            lblTodaySales.Text = $"${todaySales:N2}";
            lblTodayOrders.Text = todayOrders.ToString();
            lblPopularItem.Text = popularItem;

            // Update this week's summary
            lblWeekSales.Text = $"${weekSales:N2}";
            lblWeekOrders.Text = weekOrders.ToString();

            // Update this month's summary
            lblMonthSales.Text = $"${monthSales:N2}";
            lblMonthOrders.Text = monthOrders.ToString();
        }

        private void LoadSalesChart()
        {
            // Clear any existing series
            chartSales.Series.Clear();

            // Add a new series
            Series series = new Series("Sales");
            series.ChartType = SeriesChartType.Column;
            series.Color = Color.FromArgb(92, 184, 92);

            // Add data points
            foreach (var day in weeklySales)
            {
                series.Points.AddXY(day.Key, (double)day.Value);
            }

            // Add the series to the chart
            chartSales.Series.Add(series);

            // Set chart title
            chartSales.Titles.Clear();
            chartSales.Titles.Add("Weekly Sales");

            // Format the chart
            chartSales.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartSales.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chartSales.ChartAreas[0].AxisY.Title = "Sales ($)";

            // Set the chart to 3D
            chartSales.ChartAreas[0].Area3DStyle.Enable3D = true;
            chartSales.ChartAreas[0].Area3DStyle.Inclination = 15;
        }

        private void LoadProductChart()
        {
            // Clear any existing series
            chartProducts.Series.Clear();

            // Add a new series
            Series series = new Series("Products");
            series.ChartType = SeriesChartType.Pie;

            // Add data points
            foreach (var product in productSales)
            {
                series.Points.AddXY(product.Key, product.Value);
            }

            // Add the series to the chart
            chartProducts.Series.Add(series);

            // Set chart title
            chartProducts.Titles.Clear();
            chartProducts.Titles.Add("Product Sales Distribution");

            // Format the chart
            chartProducts.Series[0]["PieLabelStyle"] = "Outside";
            chartProducts.Series[0]["PieLineColor"] = "Black";
            chartProducts.Series[0].IsValueShownAsLabel = true;
            chartProducts.Series[0].Label = "#PERCENT{P0}";

            // Set the chart to 3D
            chartProducts.ChartAreas[0].Area3DStyle.Enable3D = true;
        }

        private void LoadRecentOrders()
        {
            // Clear existing items
            lstRecentOrders.Items.Clear();

            // Add each order to the list view
            foreach (var order in recentOrders)
            {
                ListViewItem item = new ListViewItem(order.OrderId.ToString());
                item.SubItems.Add(order.OrderTime.ToString("h:mm tt"));
                item.SubItems.Add(order.Items);
                item.SubItems.Add($"${order.Total:N2}");
                item.SubItems.Add(order.Status);

                // Set item color based on status
                if (order.Status == "Completed")
                {
                    item.BackColor = Color.FromArgb(223, 240, 216); // Light green
                }
                else if (order.Status == "In Progress")
                {
                    item.BackColor = Color.FromArgb(252, 248, 227); // Light yellow
                }
                else if (order.Status == "Cancelled")
                {
                    item.BackColor = Color.FromArgb(242, 222, 222); // Light red
                }

                lstRecentOrders.Items.Add(item);
            }
        }

        private void cmbTimeRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            // In a real application, this would update the dashboard based on the selected time range
            // For this demo, we'll just show a message
            string selectedRange = cmbTimeRange.SelectedItem.ToString();
            MessageBox.Show($"Dashboard would update to show data for: {selectedRange}", "Time Range Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // In a real application, this would refresh the data from the database
            // For this demo, we'll just show a message and reload the current data
            MessageBox.Show("Dashboard data refreshed!", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reload the dashboard
            UpdateSummaryCards();
            LoadSalesChart();
            LoadProductChart();
            LoadRecentOrders();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // In a real application, this would print the dashboard or generate a report
            MessageBox.Show("This would print the dashboard report in a real application.", "Print Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}