using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Collections.Generic;
using AbstractMaker.Model;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System;

namespace AbstractMaker.Main
{
	partial class ucChainOfTitle
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.radLabel1 = new RadLabel();
			this.rtbGranteeName = new RadTextBox();
			this.btnAddGrantee = new RadButton();
			this.pgGrantees = new RadPageView();
			this.btnRemoveGrantee = new RadButton();
			((ISupportInitialize)this.radLabel1).BeginInit();
			((ISupportInitialize)this.rtbGranteeName).BeginInit();
			((ISupportInitialize)this.btnAddGrantee).BeginInit();
			((ISupportInitialize)this.pgGrantees).BeginInit();
			((ISupportInitialize)this.btnRemoveGrantee).BeginInit();
			base.SuspendLayout();
			this.radLabel1.Location = new Point(3, 6);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Size = new System.Drawing.Size(81, 18);
			this.radLabel1.TabIndex = 4;
			this.radLabel1.Text = "Grantee Name:";
			this.rtbGranteeName.Location = new Point(90, 5);
			this.rtbGranteeName.Name = "rtbGranteeName";
			this.rtbGranteeName.Size = new System.Drawing.Size(314, 20);
			this.rtbGranteeName.TabIndex = 5;
			this.btnAddGrantee.Location = new Point(410, 3);
			this.btnAddGrantee.Name = "btnAddGrantee";
			this.btnAddGrantee.Size = new System.Drawing.Size(110, 24);
			this.btnAddGrantee.TabIndex = 6;
			this.btnAddGrantee.Text = "Add Grantee";
			this.btnAddGrantee.Click += new EventHandler(this.btnAddGrantee_Click);
			this.pgGrantees.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.pgGrantees.Location = new Point(3, 33);
			this.pgGrantees.Name = "pgGrantees";
			this.pgGrantees.Size = new System.Drawing.Size(1041, 823);
			this.pgGrantees.TabIndex = 7;
			this.pgGrantees.ViewMode = PageViewMode.NavigationView;
			((RadPageViewNavigationViewElement)this.pgGrantees.GetChildAt(0)).ExpandedPaneWidth = 220;
			((NavigationViewItemContainer)this.pgGrantees.GetChildAt(0).GetChildAt(0)).AutoSize = true;
			this.btnRemoveGrantee.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			this.btnRemoveGrantee.Location = new Point(894, 3);
			this.btnRemoveGrantee.Name = "btnRemoveGrantee";
			this.btnRemoveGrantee.Size = new System.Drawing.Size(150, 24);
			this.btnRemoveGrantee.TabIndex = 8;
			this.btnRemoveGrantee.Text = "Remove Selected";
			this.btnRemoveGrantee.Click += new EventHandler(this.btnRemoveGrantee_Click);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.btnRemoveGrantee);
			base.Controls.Add(this.pgGrantees);
			base.Controls.Add(this.btnAddGrantee);
			base.Controls.Add(this.rtbGranteeName);
			base.Controls.Add(this.radLabel1);
			base.Name = "ucChainOfTitle";
			base.Size = new System.Drawing.Size(1047, 859);
			((ISupportInitialize)this.radLabel1).EndInit();
			((ISupportInitialize)this.rtbGranteeName).EndInit();
			((ISupportInitialize)this.btnAddGrantee).EndInit();
			((ISupportInitialize)this.pgGrantees).EndInit();
			((ISupportInitialize)this.btnRemoveGrantee).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		#endregion
		public const int CustomHeadingMaxSize = 20;

		private RadLabel radLabel1;

		private RadTextBox rtbGranteeName;

		private RadButton btnAddGrantee;

		private RadPageView pgGrantees;

		private RadButton btnRemoveGrantee;

		public bool PB_Title_Chain
		{
			get;
			set;
		}

		public List<Deed> Title_Chain
		{
			get;
			set;
		}
	}
}
