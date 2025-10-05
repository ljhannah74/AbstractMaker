using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace AbstractMaker.Main
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
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.cddCustomerAccounts = new System.Windows.Forms.CheckedListBox();
            this.cddBusinessProducts = new System.Windows.Forms.CheckedListBox();
            this.btnJumpToAbstractBuildForOrder = new System.Windows.Forms.Button();
            this.tbOrderNumber = new System.Windows.Forms.TextBox();
            this.PageView = new System.Windows.Forms.TabControl();
            this.pgOrders = new System.Windows.Forms.TabPage();
            this.btnCreateNewOrder = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefreshOrderList = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.cddOrderStatuses = new System.Windows.Forms.CheckedListBox();
            this.MasterTemplate = new System.Windows.Forms.DataGridView();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.PageView.SuspendLayout();
            this.pgOrders.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(7, 110);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(137, 22);
            this.Label3.TabIndex = 22;
            this.Label3.Text = "Customer Accounts";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(7, 31);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(128, 22);
            this.Label2.TabIndex = 21;
            this.Label2.Text = "Business Products";
            // 
            // cddCustomerAccounts
            // 
            this.cddCustomerAccounts.Location = new System.Drawing.Point(8, 136);
            this.cddCustomerAccounts.Margin = new System.Windows.Forms.Padding(4);
            this.cddCustomerAccounts.Name = "cddCustomerAccounts";
            this.cddCustomerAccounts.Size = new System.Drawing.Size(352, 38);
            this.cddCustomerAccounts.TabIndex = 20;
            // 
            // cddBusinessProducts
            // 
            this.cddBusinessProducts.AllowDrop = true;
            this.cddBusinessProducts.Location = new System.Drawing.Point(7, 55);
            this.cddBusinessProducts.Margin = new System.Windows.Forms.Padding(4);
            this.cddBusinessProducts.Name = "cddBusinessProducts";
            this.cddBusinessProducts.Size = new System.Drawing.Size(352, 38);
            this.cddBusinessProducts.TabIndex = 19;
            // 
            // btnJumpToAbstractBuildForOrder
            // 
            this.btnJumpToAbstractBuildForOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJumpToAbstractBuildForOrder.Location = new System.Drawing.Point(264, 87);
            this.btnJumpToAbstractBuildForOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnJumpToAbstractBuildForOrder.Name = "btnJumpToAbstractBuildForOrder";
            this.btnJumpToAbstractBuildForOrder.Size = new System.Drawing.Size(196, 30);
            this.btnJumpToAbstractBuildForOrder.TabIndex = 24;
            this.btnJumpToAbstractBuildForOrder.Text = "Build Abstract for Order...";
            // 
            // tbOrderNumber
            // 
            this.tbOrderNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOrderNumber.Location = new System.Drawing.Point(227, 38);
            this.tbOrderNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbOrderNumber.Name = "tbOrderNumber";
            this.tbOrderNumber.Size = new System.Drawing.Size(232, 22);
            this.tbOrderNumber.TabIndex = 25;
            // 
            // PageView
            // 
            this.PageView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PageView.Controls.Add(this.pgOrders);
            this.PageView.Location = new System.Drawing.Point(0, 32);
            this.PageView.Margin = new System.Windows.Forms.Padding(4);
            this.PageView.Name = "PageView";
            this.PageView.SelectedIndex = 0;
            this.PageView.Size = new System.Drawing.Size(1667, 683);
            this.PageView.TabIndex = 28;
            // 
            // pgOrders
            // 
            this.pgOrders.Controls.Add(this.btnCreateNewOrder);
            this.pgOrders.Controls.Add(this.GroupBox2);
            this.pgOrders.Controls.Add(this.GroupBox1);
            this.pgOrders.Controls.Add(this.MasterTemplate);
            this.pgOrders.Location = new System.Drawing.Point(4, 25);
            this.pgOrders.Margin = new System.Windows.Forms.Padding(4);
            this.pgOrders.Name = "pgOrders";
            this.pgOrders.Size = new System.Drawing.Size(1659, 654);
            this.pgOrders.TabIndex = 0;
            this.pgOrders.Text = "Orders";
            // 
            // btnCreateNewOrder
            // 
            this.btnCreateNewOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateNewOrder.Location = new System.Drawing.Point(1540, 538);
            this.btnCreateNewOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateNewOrder.Name = "btnCreateNewOrder";
            this.btnCreateNewOrder.Size = new System.Drawing.Size(196, 30);
            this.btnCreateNewOrder.TabIndex = 25;
            this.btnCreateNewOrder.Text = "Create New Order";
            this.btnCreateNewOrder.Click += new System.EventHandler(this.btnCreateNewOrder_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.GroupBox2.Controls.Add(this.Label1);
            this.GroupBox2.Controls.Add(this.tbOrderNumber);
            this.GroupBox2.Controls.Add(this.btnJumpToAbstractBuildForOrder);
            this.GroupBox2.Location = new System.Drawing.Point(4, 390);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Size = new System.Drawing.Size(367, 123);
            this.GroupBox2.TabIndex = 29;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Jump To Order";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(7, 39);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(105, 22);
            this.Label1.TabIndex = 26;
            this.Label1.Text = "Order Number";
            // 
            // GroupBox1
            // 
            this.GroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.GroupBox1.Controls.Add(this.btnRefreshOrderList);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.cddOrderStatuses);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.cddBusinessProducts);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.cddCustomerAccounts);
            this.GroupBox1.Location = new System.Drawing.Point(3, 4);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(367, 373);
            this.GroupBox1.TabIndex = 28;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Filters";
            // 
            // btnRefreshOrderList
            // 
            this.btnRefreshOrderList.Location = new System.Drawing.Point(213, 337);
            this.btnRefreshOrderList.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefreshOrderList.Name = "btnRefreshOrderList";
            this.btnRefreshOrderList.Size = new System.Drawing.Size(147, 30);
            this.btnRefreshOrderList.TabIndex = 29;
            this.btnRefreshOrderList.Text = "Refresh";
            this.btnRefreshOrderList.Click += new System.EventHandler(this.btnRefreshOrderList_Click);
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(8, 190);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(107, 22);
            this.Label4.TabIndex = 24;
            this.Label4.Text = "Order Statuses";
            // 
            // cddOrderStatuses
            // 
            this.cddOrderStatuses.Location = new System.Drawing.Point(6, 216);
            this.cddOrderStatuses.Margin = new System.Windows.Forms.Padding(4);
            this.cddOrderStatuses.MaximumSize = new System.Drawing.Size(352, 48);
            this.cddOrderStatuses.Name = "cddOrderStatuses";
            this.cddOrderStatuses.Size = new System.Drawing.Size(352, 38);
            this.cddOrderStatuses.TabIndex = 23;
            // 
            // MasterTemplate
            // 
            this.MasterTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MasterTemplate.ColumnHeadersHeight = 29;
            this.MasterTemplate.Location = new System.Drawing.Point(383, 0);
            this.MasterTemplate.Margin = new System.Windows.Forms.Padding(4);
            this.MasterTemplate.Name = "MasterTemplate";
            this.MasterTemplate.ReadOnly = true;
            this.MasterTemplate.RowHeadersWidth = 51;
            this.MasterTemplate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MasterTemplate.Size = new System.Drawing.Size(2264, 567);
            this.MasterTemplate.TabIndex = 30;
            this.MasterTemplate.DoubleClick += new System.EventHandler(this.MasterTemplate_DoubleClick);
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(124, 13);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(79, 22);
            this.dtpStart.TabIndex = 32;
            this.dtpStart.TabStop = false;
            this.dtpStart.Value = new System.DateTime(2021, 3, 9, 8, 30, 43, 182);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(45, 247);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(79, 22);
            this.dtpEnd.TabIndex = 33;
            this.dtpEnd.TabStop = false;
            this.dtpEnd.Value = new System.DateTime(2021, 3, 9, 8, 30, 43, 182);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1667, 720);
            this.Controls.Add(this.PageView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = ",";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PageView.ResumeLayout(false);
            this.pgOrders.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MasterTemplate)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private Label Label3;
		private Label Label2;
		private CheckedListBox cddCustomerAccounts;
		private CheckedListBox cddBusinessProducts;
		private Button btnJumpToAbstractBuildForOrder;
		private TextBox tbOrderNumber;
		private TabControl PageView;
		private TabPage pgOrders;
		private GroupBox GroupBox2;
		private Label Label1;
		private GroupBox GroupBox1;
		private Button btnRefreshOrderList;
		private Label Label4;
		private CheckedListBox cddOrderStatuses;
		private DateTimePicker dtpEnd;
		private DateTimePicker dtpStart;
		private DataGridView MasterTemplate;
		private Button btnCreateNewOrder;
	}
}