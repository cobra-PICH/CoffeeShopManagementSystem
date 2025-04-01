using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CoffeeShop_Management
{
    public partial class CustomizeOrder : Form
    {
        private Make_Order.CoffeeProduct _coffee;

        public int Quantity { get; private set; }
        public List<string> SelectedCustomizations { get; private set; }

        public CustomizeOrder(Make_Order.CoffeeProduct coffee)
        {
            InitializeComponent();
            _coffee = coffee;
            Quantity = 1;
            SelectedCustomizations = new List<string>();
        }

        private void CustomizeOrder_Load(object sender, EventArgs e)
        {
            // Set coffee name and price
            lblCoffeeName.Text = _coffee.Name;
            lblCoffeePrice.Text = $"${_coffee.Price:F2}";
            lblCoffeeDescription.Text = _coffee.Description;

            // Set initial quantity
            nudQuantity.Value = 1;

            // Update total
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            decimal total = _coffee.Price * nudQuantity.Value;

            // Add cost for extras
            if (chkExtraSyrup.Checked) total += 0.50m;
            if (chkExtraShot.Checked) total += 0.75m;
            if (chkWhippedCream.Checked) total += 0.50m;

            // Update total label
            lblTotal.Text = $"Total: ${total:F2}";
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void chkExtraSyrup_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void chkExtraShot_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void chkWhippedCream_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            // Set quantity
            Quantity = (int)nudQuantity.Value;

            // Collect customizations
            SelectedCustomizations.Clear();

            // Milk type
            if (rbWhole.Checked) SelectedCustomizations.Add("Whole Milk");
            else if (rbSkim.Checked) SelectedCustomizations.Add("Skim Milk");
            else if (rbAlmond.Checked) SelectedCustomizations.Add("Almond Milk");
            else if (rbOat.Checked) SelectedCustomizations.Add("Oat Milk");

            // Size
            if (rbSmall.Checked) SelectedCustomizations.Add("Small");
            else if (rbMedium.Checked) SelectedCustomizations.Add("Medium");
            else if (rbLarge.Checked) SelectedCustomizations.Add("Large");

            // Temperature
            if (rbHot.Checked) SelectedCustomizations.Add("Hot");
            else if (rbIced.Checked) SelectedCustomizations.Add("Iced");

            // Extras
            if (chkExtraSyrup.Checked) SelectedCustomizations.Add("Extra Syrup");
            if (chkExtraShot.Checked) SelectedCustomizations.Add("Extra Shot");
            if (chkWhippedCream.Checked) SelectedCustomizations.Add("Whipped Cream");

            // Set dialog result
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Set dialog result
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}