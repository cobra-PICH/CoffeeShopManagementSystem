using System.Drawing;
using System.Windows.Forms;

namespace CoffeeShop_Management
{
    partial class CustomizeOrder
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblCoffeeName = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.gbTemperature = new System.Windows.Forms.GroupBox();
            this.rbIced = new System.Windows.Forms.RadioButton();
            this.rbHot = new System.Windows.Forms.RadioButton();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gbMilk = new System.Windows.Forms.GroupBox();
            this.rbOat = new System.Windows.Forms.RadioButton();
            this.rbAlmond = new System.Windows.Forms.RadioButton();
            this.rbSkim = new System.Windows.Forms.RadioButton();
            this.rbWhole = new System.Windows.Forms.RadioButton();
            this.gbExtras = new System.Windows.Forms.GroupBox();
            this.chkWhippedCream = new System.Windows.Forms.CheckBox();
            this.chkExtraShot = new System.Windows.Forms.CheckBox();
            this.chkExtraSyrup = new System.Windows.Forms.CheckBox();
            this.lblCoffeeDescription = new System.Windows.Forms.Label();
            this.lblCoffeePrice = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.gbTemperature.SuspendLayout();
            this.gbSize.SuspendLayout();
            this.gbMilk.SuspendLayout();
            this.gbExtras.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlHeader.Controls.Add(this.lblCoffeeName);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(484, 50);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblCoffeeName
            // 
            this.lblCoffeeName.AutoSize = true;
            this.lblCoffeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoffeeName.ForeColor = System.Drawing.Color.White;
            this.lblCoffeeName.Location = new System.Drawing.Point(12, 12);
            this.lblCoffeeName.Name = "lblCoffeeName";
            this.lblCoffeeName.Size = new System.Drawing.Size(146, 25);
            this.lblCoffeeName.TabIndex = 0;
            this.lblCoffeeName.Text = "Coffee Name";
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Controls.Add(this.gbTemperature);
            this.pnlContent.Controls.Add(this.gbSize);
            this.pnlContent.Controls.Add(this.gbMilk);
            this.pnlContent.Controls.Add(this.gbExtras);
            this.pnlContent.Controls.Add(this.lblCoffeeDescription);
            this.pnlContent.Controls.Add(this.lblCoffeePrice);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 50);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(20);
            this.pnlContent.Size = new System.Drawing.Size(484, 411);
            this.pnlContent.TabIndex = 1;
            // 
            // gbTemperature
            // 
            this.gbTemperature.Controls.Add(this.rbIced);
            this.gbTemperature.Controls.Add(this.rbHot);
            this.gbTemperature.Location = new System.Drawing.Point(20, 320);
            this.gbTemperature.Name = "gbTemperature";
            this.gbTemperature.Size = new System.Drawing.Size(200, 60);
            this.gbTemperature.TabIndex = 5;
            this.gbTemperature.TabStop = false;
            this.gbTemperature.Text = "Temperature";
            // 
            // rbIced
            // 
            this.rbIced.AutoSize = true;
            this.rbIced.Location = new System.Drawing.Point(100, 25);
            this.rbIced.Name = "rbIced";
            this.rbIced.Size = new System.Drawing.Size(46, 17);
            this.rbIced.TabIndex = 1;
            this.rbIced.Text = "Iced";
            this.rbIced.UseVisualStyleBackColor = true;
            // 
            // rbHot
            // 
            this.rbHot.AutoSize = true;
            this.rbHot.Checked = true;
            this.rbHot.Location = new System.Drawing.Point(20, 25);
            this.rbHot.Name = "rbHot";
            this.rbHot.Size = new System.Drawing.Size(42, 17);
            this.rbHot.TabIndex = 0;
            this.rbHot.TabStop = true;
            this.rbHot.Text = "Hot";
            this.rbHot.UseVisualStyleBackColor = true;
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Location = new System.Drawing.Point(20, 250);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(200, 60);
            this.gbSize.TabIndex = 4;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(140, 25);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(52, 17);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Checked = true;
            this.rbMedium.Location = new System.Drawing.Point(80, 25);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(62, 17);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(20, 25);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(50, 17);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            // 
            // gbMilk
            // 
            this.gbMilk.Controls.Add(this.rbOat);
            this.gbMilk.Controls.Add(this.rbAlmond);
            this.gbMilk.Controls.Add(this.rbSkim);
            this.gbMilk.Controls.Add(this.rbWhole);
            this.gbMilk.Location = new System.Drawing.Point(20, 180);
            this.gbMilk.Name = "gbMilk";
            this.gbMilk.Size = new System.Drawing.Size(444, 60);
            this.gbMilk.TabIndex = 3;
            this.gbMilk.TabStop = false;
            this.gbMilk.Text = "Milk Type";
            // 
            // rbOat
            // 
            this.rbOat.AutoSize = true;
            this.rbOat.Location = new System.Drawing.Point(260, 25);
            this.rbOat.Name = "rbOat";
            this.rbOat.Size = new System.Drawing.Size(66, 17);
            this.rbOat.TabIndex = 3;
            this.rbOat.Text = "Oat Milk";
            this.rbOat.UseVisualStyleBackColor = true;
            // 
            // rbAlmond
            // 
            this.rbAlmond.AutoSize = true;
            this.rbAlmond.Location = new System.Drawing.Point(180, 25);
            this.rbAlmond.Name = "rbAlmond";
            this.rbAlmond.Size = new System.Drawing.Size(82, 17);
            this.rbAlmond.TabIndex = 2;
            this.rbAlmond.Text = "Almond Milk";
            this.rbAlmond.UseVisualStyleBackColor = true;
            // 
            // rbSkim
            // 
            this.rbSkim.AutoSize = true;
            this.rbSkim.Location = new System.Drawing.Point(100, 25);
            this.rbSkim.Name = "rbSkim";
            this.rbSkim.Size = new System.Drawing.Size(70, 17);
            this.rbSkim.TabIndex = 1;
            this.rbSkim.Text = "Skim Milk";
            this.rbSkim.UseVisualStyleBackColor = true;
            // 
            // rbWhole
            // 
            this.rbWhole.AutoSize = true;
            this.rbWhole.Checked = true;
            this.rbWhole.Location = new System.Drawing.Point(20, 25);
            this.rbWhole.Name = "rbWhole";
            this.rbWhole.Size = new System.Drawing.Size(79, 17);
            this.rbWhole.TabIndex = 0;
            this.rbWhole.TabStop = true;
            this.rbWhole.Text = "Whole Milk";
            this.rbWhole.UseVisualStyleBackColor = true;
            // 
            // gbExtras
            // 
            this.gbExtras.Controls.Add(this.chkWhippedCream);
            this.gbExtras.Controls.Add(this.chkExtraShot);
            this.gbExtras.Controls.Add(this.chkExtraSyrup);
            this.gbExtras.Location = new System.Drawing.Point(20, 110);
            this.gbExtras.Name = "gbExtras";
            this.gbExtras.Size = new System.Drawing.Size(444, 60);
            this.gbExtras.TabIndex = 2;
            this.gbExtras.TabStop = false;
            this.gbExtras.Text = "Extras";
            // 
            // chkWhippedCream
            // 
            this.chkWhippedCream.AutoSize = true;
            this.chkWhippedCream.Location = new System.Drawing.Point(260, 25);
            this.chkWhippedCream.Name = "chkWhippedCream";
            this.chkWhippedCream.Size = new System.Drawing.Size(104, 17);
            this.chkWhippedCream.TabIndex = 2;
            this.chkWhippedCream.Text = "Whipped Cream";
            this.chkWhippedCream.UseVisualStyleBackColor = true;
            this.chkWhippedCream.CheckedChanged += new System.EventHandler(this.chkWhippedCream_CheckedChanged);
            // 
            // chkExtraShot
            // 
            this.chkExtraShot.AutoSize = true;
            this.chkExtraShot.Location = new System.Drawing.Point(140, 25);
            this.chkExtraShot.Name = "chkExtraShot";
            this.chkExtraShot.Size = new System.Drawing.Size(114, 17);
            this.chkExtraShot.TabIndex = 1;
            this.chkExtraShot.Text = "Extra Shot (+$0.75)";
            this.chkExtraShot.UseVisualStyleBackColor = true;
            this.chkExtraShot.CheckedChanged += new System.EventHandler(this.chkExtraShot_CheckedChanged);
            // 
            // chkExtraSyrup
            // 
            this.chkExtraSyrup.AutoSize = true;
            this.chkExtraSyrup.Location = new System.Drawing.Point(20, 25);
            this.chkExtraSyrup.Name = "chkExtraSyrup";
            this.chkExtraSyrup.Size = new System.Drawing.Size(114, 17);
            this.chkExtraSyrup.TabIndex = 0;
            this.chkExtraSyrup.Text = "Extra Syrup (+$0.50)";
            this.chkExtraSyrup.UseVisualStyleBackColor = true;
            this.chkExtraSyrup.CheckedChanged += new System.EventHandler(this.chkExtraSyrup_CheckedChanged);
            // 
            // lblCoffeeDescription
            // 
            this.lblCoffeeDescription.AutoSize = true;
            this.lblCoffeeDescription.Location = new System.Drawing.Point(20, 50);
            this.lblCoffeeDescription.Name = "lblCoffeeDescription";
            this.lblCoffeeDescription.Size = new System.Drawing.Size(97, 13);
            this.lblCoffeeDescription.TabIndex = 1;
            this.lblCoffeeDescription.Text = "Coffee Description";
            // 
            // lblCoffeePrice
            // 
            this.lblCoffeePrice.AutoSize = true;
            this.lblCoffeePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoffeePrice.Location = new System.Drawing.Point(20, 20);
            this.lblCoffeePrice.Name = "lblCoffeePrice";
            this.lblCoffeePrice.Size = new System.Drawing.Size(54, 20);
            this.lblCoffeePrice.TabIndex = 0;
            this.lblCoffeePrice.Text = "$0.00";
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnlFooter.Controls.Add(this.btnCancel);
            this.pnlFooter.Controls.Add(this.btnAddToCart);
            this.pnlFooter.Controls.Add(this.lblTotal);
            this.pnlFooter.Controls.Add(this.lblQuantity);
            this.pnlFooter.Controls.Add(this.nudQuantity);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 411);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(484, 50);
            this.pnlFooter.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(284, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(380, 10);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(90, 30);
            this.btnAddToCart.TabIndex = 3;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(180, 16);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(84, 16);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total: $0.00";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(20, 18);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Quantity:";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(75, 16);
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(60, 20);
            this.nudQuantity.TabIndex = 0;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.ValueChanged += new System.EventHandler(this.nudQuantity_ValueChanged);
            // 
            // CustomizeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomizeOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customize Your Order";
            this.Load += new System.EventHandler(this.CustomizeOrder_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.gbTemperature.ResumeLayout(false);
            this.gbTemperature.PerformLayout();
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbMilk.ResumeLayout(false);
            this.gbMilk.PerformLayout();
            this.gbExtras.ResumeLayout(false);
            this.gbExtras.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblCoffeeName;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblCoffeePrice;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblCoffeeDescription;
        private System.Windows.Forms.GroupBox gbExtras;
        private System.Windows.Forms.CheckBox chkWhippedCream;
        private System.Windows.Forms.CheckBox chkExtraShot;
        private System.Windows.Forms.CheckBox chkExtraSyrup;
        private System.Windows.Forms.GroupBox gbMilk;
        private System.Windows.Forms.RadioButton rbOat;
        private System.Windows.Forms.RadioButton rbAlmond;
        private System.Windows.Forms.RadioButton rbSkim;
        private System.Windows.Forms.RadioButton rbWhole;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gbTemperature;
        private System.Windows.Forms.RadioButton rbIced;
        private System.Windows.Forms.RadioButton rbHot;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnCancel;
    }
}