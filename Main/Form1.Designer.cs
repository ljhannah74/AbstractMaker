﻿using System;
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
			TableViewDefinition tableViewDefinition2 = new TableViewDefinition();
			this.Label3 = new RadLabel();
			this.Label2 = new RadLabel();
			this.cddCustomerAccounts = new RadCheckedListBox();
			this.cddBusinessProducts = new RadCheckedListBox();
			this.btnJumpToAbstractBuildForOrder = new RadButton();
			this.tbOrderNumber = new RadTextBox();
			this.PageView = new RadPageView();
			this.pgOrders = new RadPageViewPage();
			this.GroupBox2 = new RadGroupBox();
			this.Label1 = new RadLabel();
			this.GroupBox1 = new RadGroupBox();
			this.btnRefreshOrderList = new RadButton();
			this.Label4 = new RadLabel();
			this.cddOrderStatuses = new RadCheckedListBox();
			this.MasterTemplate = new RadGridView();
			this.dtpStart = new RadDateTimePicker();
			this.dtpEnd = new RadDateTimePicker();
			this.btnCreateNewOrder = new Button();
			((System.ComponentModel.ISupportInitialize)(this.Label3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cddCustomerAccounts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cddBusinessProducts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnJumpToAbstractBuildForOrder)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbOrderNumber)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PageView)).BeginInit();
			this.PageView.SuspendLayout();
			this.pgOrders.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.GroupBox2)).BeginInit();
			this.GroupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Label1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GroupBox1)).BeginInit();
			this.GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnRefreshOrderList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cddOrderStatuses)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MasterTemplate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MasterTemplate.MasterTemplate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpStart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpEnd)).BeginInit();
			//((System.ComponentModel.ISupportInitialize)(this.btnCreateNewOrder)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			this.SuspendLayout();
			// 
			// Label3
			// 
			this.Label3.Location = new System.Drawing.Point(5, 75);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(103, 18);
			this.Label3.TabIndex = 22;
			this.Label3.Text = "Customer Accounts";
			// 
			// Label2
			// 
			this.Label2.Location = new System.Drawing.Point(5, 25);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(96, 18);
			this.Label2.TabIndex = 21;
			this.Label2.Text = "Business Products";
			// 
			// cddCustomerAccounts
			// 
			this.cddCustomerAccounts.Location = new System.Drawing.Point(5, 95);
			this.cddCustomerAccounts.Name = "cddCustomerAccounts";
			this.cddCustomerAccounts.Size = new System.Drawing.Size(265, 20);
			this.cddCustomerAccounts.TabIndex = 20;
			// 
			// cddBusinessProducts
			// 
			this.cddBusinessProducts.Location = new System.Drawing.Point(5, 45);
			this.cddBusinessProducts.Name = "cddBusinessProducts";
			this.cddBusinessProducts.Size = new System.Drawing.Size(265, 20);
			this.cddBusinessProducts.TabIndex = 19;
			// 
			// btnJumpToAbstractBuildForOrder
			// 
			this.btnJumpToAbstractBuildForOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnJumpToAbstractBuildForOrder.Location = new System.Drawing.Point(123, 71);
			this.btnJumpToAbstractBuildForOrder.Name = "btnJumpToAbstractBuildForOrder";
			this.btnJumpToAbstractBuildForOrder.Size = new System.Drawing.Size(147, 24);
			this.btnJumpToAbstractBuildForOrder.TabIndex = 24;
			this.btnJumpToAbstractBuildForOrder.Text = "Build Abstract for Order...";
			// 
			// tbOrderNumber
			// 
			this.tbOrderNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbOrderNumber.Location = new System.Drawing.Point(95, 31);
			this.tbOrderNumber.Name = "tbOrderNumber";
			this.tbOrderNumber.Size = new System.Drawing.Size(175, 20);
			this.tbOrderNumber.TabIndex = 25;
			// 
			// PageView
			// 
			this.PageView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.PageView.Controls.Add(this.pgOrders);
			this.PageView.Location = new System.Drawing.Point(0, 26);
			this.PageView.Name = "PageView";
			this.PageView.SelectedPage = this.pgOrders;
			this.PageView.Size = new System.Drawing.Size(1250, 555);
			this.PageView.TabIndex = 28;
			// 
			// pgOrders
			// 
			this.pgOrders.Controls.Add(this.btnCreateNewOrder);
			this.pgOrders.Controls.Add(this.GroupBox2);
			this.pgOrders.Controls.Add(this.GroupBox1);
			this.pgOrders.Controls.Add(this.MasterTemplate);
			this.pgOrders.ItemSize = new System.Drawing.SizeF(50F, 28F);
			this.pgOrders.Location = new System.Drawing.Point(10, 37);
			this.pgOrders.Name = "pgOrders";
			this.pgOrders.Size = new System.Drawing.Size(1229, 507);
			this.pgOrders.Text = "Orders";
			// 
			// GroupBox2
			// 
			this.GroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.GroupBox2.Controls.Add(this.Label1);
			this.GroupBox2.Controls.Add(this.tbOrderNumber);
			this.GroupBox2.Controls.Add(this.btnJumpToAbstractBuildForOrder);
			this.GroupBox2.HeaderText = "Jump To Order";
			this.GroupBox2.Location = new System.Drawing.Point(3, 317);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(275, 100);
			this.GroupBox2.TabIndex = 29;
			this.GroupBox2.Text = "Jump To Order";
			// 
			// Label1
			// 
			this.Label1.Location = new System.Drawing.Point(5, 32);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(79, 18);
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
			this.GroupBox1.HeaderText = "Filters";
			this.GroupBox1.Location = new System.Drawing.Point(2, 3);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(275, 303);
			this.GroupBox1.TabIndex = 28;
			this.GroupBox1.Text = "Filters";
			// 
			// btnRefreshOrderList
			// 
			this.btnRefreshOrderList.Location = new System.Drawing.Point(160, 274);
			this.btnRefreshOrderList.Name = "btnRefreshOrderList";
			this.btnRefreshOrderList.Size = new System.Drawing.Size(110, 24);
			this.btnRefreshOrderList.TabIndex = 29;
			this.btnRefreshOrderList.Text = "Refresh";
			this.btnRefreshOrderList.Click += new System.EventHandler(this.btnRefreshOrderList_Click);
			// 
			// Label4
			// 
			this.Label4.Location = new System.Drawing.Point(5, 125);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(80, 18);
			this.Label4.TabIndex = 24;
			this.Label4.Text = "Order Statuses";
			// 
			// cddOrderStatuses
			// 
			this.cddOrderStatuses.Location = new System.Drawing.Point(5, 145);
			this.cddOrderStatuses.MaximumSize = new System.Drawing.Size(265, 40);
			this.cddOrderStatuses.MultiSelect = true;
			this.cddOrderStatuses.Name = "cddOrderStatuses";
			this.cddOrderStatuses.Size = new System.Drawing.Size(265, 20);
			this.cddOrderStatuses.TabIndex = 23;
			// 
			// MasterTemplate
			// 
			this.MasterTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.MasterTemplate.Location = new System.Drawing.Point(287, 0);
			// 
			// 
			// 
			this.MasterTemplate.MasterTemplate.AllowAddNewRow = false;
			this.MasterTemplate.MasterTemplate.AllowColumnReorder = false;
			this.MasterTemplate.MasterTemplate.ViewDefinition = tableViewDefinition2;
			this.MasterTemplate.Name = "MasterTemplate";
			this.MasterTemplate.ReadOnly = true;
			this.MasterTemplate.Size = new System.Drawing.Size(669, 461);
			this.MasterTemplate.TabIndex = 30;
			this.MasterTemplate.DoubleClick += new System.EventHandler(this.MasterTemplate_DoubleClick);
			// 
			// dtpStart
			// 
			this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpStart.Location = new System.Drawing.Point(124, 13);
			this.dtpStart.Name = "dtpStart";
			this.dtpStart.Size = new System.Drawing.Size(79, 20);
			this.dtpStart.TabIndex = 32;
			this.dtpStart.TabStop = false;
			this.dtpStart.Text = "3/9/2021";
			this.dtpStart.Value = new System.DateTime(2021, 3, 9, 8, 30, 43, 182);
			// 
			// dtpEnd
			// 
			this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpEnd.Location = new System.Drawing.Point(45, 247);
			this.dtpEnd.Name = "dtpEnd";
			this.dtpEnd.Size = new System.Drawing.Size(79, 20);
			this.dtpEnd.TabIndex = 33;
			this.dtpEnd.TabStop = false;
			this.dtpEnd.Text = "3/9/2021";
			this.dtpEnd.Value = new System.DateTime(2021, 3, 9, 8, 30, 43, 182);
			// 
			// btnCreateNewOrder
			// 
			this.btnCreateNewOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCreateNewOrder.Location = new System.Drawing.Point(126, 437);
			this.btnCreateNewOrder.Name = "btnCreateNewOrder";
			this.btnCreateNewOrder.Size = new System.Drawing.Size(147, 24);
			this.btnCreateNewOrder.TabIndex = 25;
			this.btnCreateNewOrder.Text = "Create New Order";
			this.btnCreateNewOrder.Click += new System.EventHandler(this.btnCreateNewOrder_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1250, 585);
			this.Controls.Add(this.PageView);
			this.Name = "Form1";
			// 
			// 
			// 
			//this.RootElement.ApplyShapeToControl = true;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.Label3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cddCustomerAccounts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cddBusinessProducts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnJumpToAbstractBuildForOrder)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbOrderNumber)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PageView)).EndInit();
			this.PageView.ResumeLayout(false);
			this.pgOrders.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.GroupBox2)).EndInit();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Label1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GroupBox1)).EndInit();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnRefreshOrderList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cddOrderStatuses)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MasterTemplate.MasterTemplate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MasterTemplate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpStart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpEnd)).EndInit();
			//((System.ComponentModel.ISupportInitialize)(this.btnCreateNewOrder)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private RadLabel Label3;
		private RadLabel Label2;
		private RadCheckedListBox cddCustomerAccounts;
		private RadCheckedListBox cddBusinessProducts;
		private RadButton btnJumpToAbstractBuildForOrder;
		private RadTextBox tbOrderNumber;
		private RadPageView PageView;
		private RadPageViewPage pgOrders;
		private RadGroupBox GroupBox2;
		private RadLabel Label1;
		private RadGroupBox GroupBox1;
		private RadButton btnRefreshOrderList;
		private RadLabel Label4;
		private RadCheckedListBox cddOrderStatuses;
		private RadDateTimePicker dtpEnd;
		private RadDateTimePicker dtpStart;
		private RadGridView MasterTemplate;
		private Button btnCreateNewOrder;
	}
}