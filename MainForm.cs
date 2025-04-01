using System;
using System.Windows.Forms;

namespace CoffeeShop_Management
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Set the active panel to Dashboard by default
            SetActivePanel(pnlDashboardCard);
            ShowDashboard();
        }

        private void SetActivePanel(Panel activePanel)
        {
            // Reset all panels to default color
            pnlDashboardCard.BackColor = System.Drawing.Color.White;
            pnlOrderCard.BackColor = System.Drawing.Color.White;
            pnlUserCard.BackColor = System.Drawing.Color.White;

            // Set active panel color
            activePanel.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
        }

        private void ClearMainContent()
        {
            // Clear any controls in the main content panel
            pnlMainContent.Controls.Clear();
        }

        private void ShowDashboard()
        {
            ClearMainContent();

            // Create dashboard content
            Label lblDashboardTitle = new Label
            {
                Text = "Dashboard",
                Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold),
                AutoSize = true,
                Location = new System.Drawing.Point(20, 20)
            };

            Label lblSummary = new Label
            {
                Text = "Today's Summary:",
                Font = new System.Drawing.Font("Microsoft Sans Serif", 12F),
                AutoSize = true,
                Location = new System.Drawing.Point(20, 70)
            };

            // Sample dashboard data
            TableLayoutPanel tblStats = new TableLayoutPanel
            {
                ColumnCount = 2,
                RowCount = 3,
                Width = 300,
                Height = 150,
                Location = new System.Drawing.Point(20, 100),
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
            };

            tblStats.Controls.Add(new Label { Text = "Total Orders:", Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold) }, 0, 0);
            tblStats.Controls.Add(new Label { Text = "24", Font = new System.Drawing.Font("Microsoft Sans Serif", 10F) }, 1, 0);

            tblStats.Controls.Add(new Label { Text = "Total Sales:", Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold) }, 0, 1);
            tblStats.Controls.Add(new Label { Text = "$487.50", Font = new System.Drawing.Font("Microsoft Sans Serif", 10F) }, 1, 1);

            tblStats.Controls.Add(new Label { Text = "Popular Item:", Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold) }, 0, 2);
            tblStats.Controls.Add(new Label { Text = "Cappuccino", Font = new System.Drawing.Font("Microsoft Sans Serif", 10F) }, 1, 2);

            // Add controls to main content
            pnlMainContent.Controls.Add(lblDashboardTitle);
            pnlMainContent.Controls.Add(lblSummary);
            pnlMainContent.Controls.Add(tblStats);
        }

        private void ShowOrderForm()
        {
            // Instead of creating controls dynamically, open the Make_Order form
            Make_Order orderForm = new Make_Order();
            orderForm.ShowDialog();
        }

        private void ShowUserForm()
        {
            ClearMainContent();

            // Create user form content
            Label lblUserTitle = new Label
            {
                Text = "User Management",
                Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold),
                AutoSize = true,
                Location = new System.Drawing.Point(20, 20)
            };

            // User form fields
            Label lblUsername = new Label
            {
                Text = "Username:",
                AutoSize = true,
                Location = new System.Drawing.Point(20, 70)
            };

            TextBox txtUsername = new TextBox
            {
                Location = new System.Drawing.Point(120, 70),
                Size = new System.Drawing.Size(200, 20)
            };

            Label lblPassword = new Label
            {
                Text = "Password:",
                AutoSize = true,
                Location = new System.Drawing.Point(20, 100)
            };

            TextBox txtPassword = new TextBox
            {
                Location = new System.Drawing.Point(120, 100),
                Size = new System.Drawing.Size(200, 20),
                PasswordChar = '•'
            };

            Label lblRole = new Label
            {
                Text = "Role:",
                AutoSize = true,
                Location = new System.Drawing.Point(20, 130)
            };

            ComboBox cmbRole = new ComboBox
            {
                Location = new System.Drawing.Point(120, 130),
                Size = new System.Drawing.Size(200, 20),
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            cmbRole.Items.AddRange(new string[] { "Administrator", "Cashier", "Manager" });
            cmbRole.SelectedIndex = 1; // Default to Cashier

            Button btnAddUser = new Button
            {
                Text = "Add User",
                Location = new System.Drawing.Point(120, 170),
                Size = new System.Drawing.Size(100, 30)
            };

            // User list
            Label lblUserList = new Label
            {
                Text = "Current Users:",
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold),
                AutoSize = true,
                Location = new System.Drawing.Point(20, 220)
            };

            ListView lstUsers = new ListView
            {
                Location = new System.Drawing.Point(20, 250),
                Size = new System.Drawing.Size(400, 150),
                View = View.Details,
                FullRowSelect = true
            };

            lstUsers.Columns.Add("Username", 120);
            lstUsers.Columns.Add("Role", 100);
            lstUsers.Columns.Add("Last Login", 150);

            // Add sample users
            ListViewItem item1 = new ListViewItem("admin");
            item1.SubItems.Add("Administrator");
            item1.SubItems.Add(DateTime.Now.AddDays(-1).ToString("g"));
            lstUsers.Items.Add(item1);

            ListViewItem item2 = new ListViewItem("john");
            item2.SubItems.Add("Cashier");
            item2.SubItems.Add(DateTime.Now.AddHours(-2).ToString("g"));
            lstUsers.Items.Add(item2);

            ListViewItem item3 = new ListViewItem("sarah");
            item3.SubItems.Add("Manager");
            item3.SubItems.Add(DateTime.Now.AddHours(-5).ToString("g"));
            lstUsers.Items.Add(item3);

            // Add controls to main content
            pnlMainContent.Controls.Add(lblUserTitle);
            pnlMainContent.Controls.Add(lblUsername);
            pnlMainContent.Controls.Add(txtUsername);
            pnlMainContent.Controls.Add(lblPassword);
            pnlMainContent.Controls.Add(txtPassword);
            pnlMainContent.Controls.Add(lblRole);
            pnlMainContent.Controls.Add(cmbRole);
            pnlMainContent.Controls.Add(btnAddUser);
            pnlMainContent.Controls.Add(lblUserList);
            pnlMainContent.Controls.Add(lstUsers);
        }

        private void pnlDashboardCard_Click(object sender, EventArgs e)
        {
            SetActivePanel(pnlDashboardCard);
            ShowDashboard();
        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {
            pnlDashboardCard_Click(sender, e);
        }

        private void pnlOrderCard_Click(object sender, EventArgs e)
        {
            SetActivePanel(pnlOrderCard);
            ShowOrderForm();
        }

        private void lblOrder_Click(object sender, EventArgs e)
        {
            pnlOrderCard_Click(sender, e);
        }

        private void pnlUserCard_Click(object sender, EventArgs e)
        {
            SetActivePanel(pnlUserCard);
            ShowUserForm();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            pnlUserCard_Click(sender, e);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Show login form and close this form
                Login loginForm = new Login();
                loginForm.Show();
                this.Close();
            }
        }
    }
}