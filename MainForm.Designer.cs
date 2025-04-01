using System.Drawing;
using System.Windows.Forms;

namespace CoffeeShop_Management
{
    partial class MainForm
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
            this.lblShopName = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlUserCard = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.pnlOrderCard = new System.Windows.Forms.Panel();
            this.lblOrder = new System.Windows.Forms.Label();
            this.pnlDashboardCard = new System.Windows.Forms.Panel();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlUserCard.SuspendLayout();
            this.pnlOrderCard.SuspendLayout();
            this.pnlDashboardCard.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlHeader.Controls.Add(this.lblShopName);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(984, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblShopName
            // 
            this.lblShopName.AutoSize = true;
            this.lblShopName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShopName.ForeColor = System.Drawing.Color.White;
            this.lblShopName.Location = new System.Drawing.Point(12, 18);
            this.lblShopName.Name = "lblShopName";
            this.lblShopName.Size = new System.Drawing.Size(242, 25);
            this.lblShopName.TabIndex = 0;
            this.lblShopName.Text = "Brew Haven Coffee Co";
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.pnlUserCard);
            this.pnlSidebar.Controls.Add(this.pnlOrderCard);
            this.pnlSidebar.Controls.Add(this.pnlDashboardCard);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 60);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Padding = new System.Windows.Forms.Padding(10);
            this.pnlSidebar.Size = new System.Drawing.Size(200, 501);
            this.pnlSidebar.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(10, 451);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(180, 40);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlUserCard
            // 
            this.pnlUserCard.BackColor = System.Drawing.Color.White;
            this.pnlUserCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUserCard.Controls.Add(this.lblUser);
            this.pnlUserCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlUserCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserCard.Location = new System.Drawing.Point(10, 130);
            this.pnlUserCard.Margin = new System.Windows.Forms.Padding(10);
            this.pnlUserCard.Name = "pnlUserCard";
            this.pnlUserCard.Size = new System.Drawing.Size(180, 60);
            this.pnlUserCard.TabIndex = 2;
            this.pnlUserCard.Click += new System.EventHandler(this.pnlUserCard_Click);
            // 
            // lblUser
            // 
            this.lblUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(0, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(178, 58);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Add User";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // pnlOrderCard
            // 
            this.pnlOrderCard.BackColor = System.Drawing.Color.White;
            this.pnlOrderCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOrderCard.Controls.Add(this.lblOrder);
            this.pnlOrderCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlOrderCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOrderCard.Location = new System.Drawing.Point(10, 70);
            this.pnlOrderCard.Margin = new System.Windows.Forms.Padding(10);
            this.pnlOrderCard.Name = "pnlOrderCard";
            this.pnlOrderCard.Size = new System.Drawing.Size(180, 60);
            this.pnlOrderCard.TabIndex = 1;
            this.pnlOrderCard.Click += new System.EventHandler(this.pnlOrderCard_Click);
            // 
            // lblOrder
            // 
            this.lblOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(0, 0);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(178, 58);
            this.lblOrder.TabIndex = 0;
            this.lblOrder.Text = "Make Order";
            this.lblOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOrder.Click += new System.EventHandler(this.lblOrder_Click);
            // 
            // pnlDashboardCard
            // 
            this.pnlDashboardCard.BackColor = System.Drawing.Color.White;
            this.pnlDashboardCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDashboardCard.Controls.Add(this.lblDashboard);
            this.pnlDashboardCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlDashboardCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDashboardCard.Location = new System.Drawing.Point(10, 10);
            this.pnlDashboardCard.Margin = new System.Windows.Forms.Padding(10);
            this.pnlDashboardCard.Name = "pnlDashboardCard";
            this.pnlDashboardCard.Size = new System.Drawing.Size(180, 60);
            this.pnlDashboardCard.TabIndex = 0;
            this.pnlDashboardCard.Click += new System.EventHandler(this.pnlDashboardCard_Click);
            // 
            // lblDashboard
            // 
            this.lblDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.Location = new System.Drawing.Point(0, 0);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(178, 58);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "Dashboard";
            this.lblDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDashboard.Click += new System.EventHandler(this.lblDashboard_Click);
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.BackColor = System.Drawing.Color.White;
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(200, 60);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(784, 471);
            this.pnlMainContent.TabIndex = 2;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnlFooter.Controls.Add(this.lblStatus);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(200, 531);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(784, 30);
            this.pnlFooter.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(6, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(169, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Logged in as: admin | Version: 1.0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlHeader);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee Shop Management System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlUserCard.ResumeLayout(false);
            this.pnlOrderCard.ResumeLayout(false);
            this.pnlDashboardCard.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblShopName;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel pnlDashboardCard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel pnlOrderCard;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Panel pnlUserCard;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnLogout;
    }
}