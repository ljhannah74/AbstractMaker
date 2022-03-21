using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Collections.Generic;
using AbstractMaker.Model;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System;

namespace AbstractMaker.Main
{
	partial class ucChainOfTitleGrantee
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
			this.radLabel2 = new RadLabel();
			this.rtbGrantorName = new RadTextBox();
			this.radLabel3 = new RadLabel();
			this.rddlOwnershipType = new RadDropDownList();
			this.radLabel4 = new RadLabel();
			this.radLabel5 = new RadLabel();
			this.radLabel6 = new RadLabel();
			this.radLabel7 = new RadLabel();
			this.radLabel10 = new RadLabel();
			this.rtbPage = new RadTextBox();
			this.rtbBook = new RadTextBox();
			this.rtbDocumentInstr = new RadTextBox();
			this.radLabel9 = new RadLabel();
			this.rdtpDated = new RadDateTimePicker();
			this.rdtpRecorded = new RadDateTimePicker();
			this.lblOtherDesc = new RadLabel();
			this.rtbOtherDesc = new RadTextBox();
			this.ID = new RadSpinEditor();
			this.mebConsideration = new RadMaskedEditBox();
			((ISupportInitialize)this.radLabel1).BeginInit();
			((ISupportInitialize)this.rtbGranteeName).BeginInit();
			((ISupportInitialize)this.radLabel2).BeginInit();
			((ISupportInitialize)this.rtbGrantorName).BeginInit();
			((ISupportInitialize)this.radLabel3).BeginInit();
			((ISupportInitialize)this.rddlOwnershipType).BeginInit();
			((ISupportInitialize)this.radLabel4).BeginInit();
			((ISupportInitialize)this.radLabel5).BeginInit();
			((ISupportInitialize)this.radLabel6).BeginInit();
			((ISupportInitialize)this.radLabel7).BeginInit();
			((ISupportInitialize)this.radLabel10).BeginInit();
			((ISupportInitialize)this.rtbPage).BeginInit();
			((ISupportInitialize)this.rtbBook).BeginInit();
			((ISupportInitialize)this.rtbDocumentInstr).BeginInit();
			((ISupportInitialize)this.radLabel9).BeginInit();
			((ISupportInitialize)this.rdtpDated).BeginInit();
			((ISupportInitialize)this.rdtpRecorded).BeginInit();
			((ISupportInitialize)this.lblOtherDesc).BeginInit();
			((ISupportInitialize)this.rtbOtherDesc).BeginInit();
			((ISupportInitialize)this.ID).BeginInit();
			((ISupportInitialize)this.mebConsideration).BeginInit();
			base.SuspendLayout();
			this.radLabel1.Location = new Point(13, 25);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Size = new System.Drawing.Size(81, 18);
			this.radLabel1.TabIndex = 0;
			this.radLabel1.Text = "Grantee Name:";
			this.rtbGranteeName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			this.rtbGranteeName.Location = new Point(114, 24);
			this.rtbGranteeName.Multiline = true;
			this.rtbGranteeName.Name = "rtbGranteeName";
			this.rtbGranteeName.RootElement.StretchVertically = true;
			this.rtbGranteeName.Size = new System.Drawing.Size(353, 50);
			this.rtbGranteeName.TabIndex = 3;
			this.rtbGranteeName.TextChanged += new EventHandler(this.rtbGranteeName_TextChanged);
			this.radLabel2.Location = new Point(13, 85);
			this.radLabel2.Name = "radLabel2";
			this.radLabel2.Size = new System.Drawing.Size(80, 18);
			this.radLabel2.TabIndex = 2;
			this.radLabel2.Text = "Grantor Name:";
			this.rtbGrantorName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			this.rtbGrantorName.Location = new Point(114, 84);
			this.rtbGrantorName.Multiline = true;
			this.rtbGrantorName.Name = "rtbGrantorName";
			this.rtbGrantorName.RootElement.StretchVertically = true;
			this.rtbGrantorName.Size = new System.Drawing.Size(353, 50);
			this.rtbGrantorName.TabIndex = 4;
			this.rtbGrantorName.TextChanged += new EventHandler(this.rtbGrantorName_TextChanged);
			this.radLabel3.Location = new Point(13, 141);
			this.radLabel3.Name = "radLabel3";
			this.radLabel3.Size = new System.Drawing.Size(89, 18);
			this.radLabel3.TabIndex = 4;
			this.radLabel3.Text = "Ownership Type:";
			this.rddlOwnershipType.Location = new Point(114, 140);
			this.rddlOwnershipType.Name = "rddlOwnershipType";
			this.rddlOwnershipType.Size = new System.Drawing.Size(113, 20);
			this.rddlOwnershipType.TabIndex = 5;
			this.rddlOwnershipType.Text = "Fee Simple";
			this.radLabel4.Location = new Point(13, 219);
			this.radLabel4.Name = "radLabel4";
			this.radLabel4.Size = new System.Drawing.Size(34, 18);
			this.radLabel4.TabIndex = 7;
			this.radLabel4.Text = "Book:";
			this.radLabel5.Location = new Point(13, 193);
			this.radLabel5.Name = "radLabel5";
			this.radLabel5.Size = new System.Drawing.Size(39, 18);
			this.radLabel5.TabIndex = 8;
			this.radLabel5.Text = "Dated:";
			this.radLabel6.Location = new Point(265, 193);
			this.radLabel6.Name = "radLabel6";
			this.radLabel6.Size = new System.Drawing.Size(56, 18);
			this.radLabel6.TabIndex = 9;
			this.radLabel6.Text = "Recorded:";
			this.radLabel7.Location = new Point(13, 245);
			this.radLabel7.Name = "radLabel7";
			this.radLabel7.Size = new System.Drawing.Size(87, 18);
			this.radLabel7.TabIndex = 10;
			this.radLabel7.Text = "Document/Instr:";
			this.radLabel10.Location = new Point(265, 219);
			this.radLabel10.Name = "radLabel10";
			this.radLabel10.Size = new System.Drawing.Size(33, 18);
			this.radLabel10.TabIndex = 13;
			this.radLabel10.Text = "Page:";
			this.rtbPage.Location = new Point(354, 218);
			this.rtbPage.Name = "rtbPage";
			this.rtbPage.Size = new System.Drawing.Size(113, 20);
			this.rtbPage.TabIndex = 11;
			this.rtbBook.Location = new Point(114, 218);
			this.rtbBook.Name = "rtbBook";
			this.rtbBook.Size = new System.Drawing.Size(113, 20);
			this.rtbBook.TabIndex = 10;
			this.rtbDocumentInstr.Location = new Point(114, 244);
			this.rtbDocumentInstr.Name = "rtbDocumentInstr";
			this.rtbDocumentInstr.Size = new System.Drawing.Size(113, 20);
			this.rtbDocumentInstr.TabIndex = 12;
			this.radLabel9.Location = new Point(265, 141);
			this.radLabel9.Name = "radLabel9";
			this.radLabel9.Size = new System.Drawing.Size(78, 18);
			this.radLabel9.TabIndex = 19;
			this.radLabel9.Text = "Consideration:";
			this.rdtpDated.Format = DateTimePickerFormat.Short;
			this.rdtpDated.Location = new Point(114, 192);
			this.rdtpDated.Name = "rdtpDated";
			this.rdtpDated.NullDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.rdtpDated.NullText = "not specified";
			this.rdtpDated.Size = new System.Drawing.Size(113, 20);
			this.rdtpDated.TabIndex = 8;
			this.rdtpDated.TabStop = false;
			this.rdtpDated.Text = "11/16/2020";
			this.rdtpDated.Value = new DateTime(2020, 11, 16, 0, 0, 0, 0);
			((RadDateTimePickerElement)this.rdtpDated.GetChildAt(0)).Text = "";
			((RadMaskedEditBoxElement)this.rdtpDated.GetChildAt(0).GetChildAt(2).GetChildAt(1)).Text = "11/16/2020";
			this.rdtpRecorded.Format = DateTimePickerFormat.Short;
			this.rdtpRecorded.Location = new Point(354, 192);
			this.rdtpRecorded.Name = "rdtpRecorded";
			this.rdtpRecorded.NullDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.rdtpRecorded.NullText = "not specified";
			this.rdtpRecorded.Size = new System.Drawing.Size(113, 20);
			this.rdtpRecorded.TabIndex = 9;
			this.rdtpRecorded.TabStop = false;
			this.rdtpRecorded.Text = "11/16/2020";
			this.rdtpRecorded.Value = new DateTime(2020, 11, 16, 0, 0, 0, 0);
			((RadDateTimePickerElement)this.rdtpRecorded.GetChildAt(0)).Text = "";
			((RadMaskedEditBoxElement)this.rdtpRecorded.GetChildAt(0).GetChildAt(2).GetChildAt(1)).Text = "11/16/2020";
			this.lblOtherDesc.Location = new Point(13, 167);
			this.lblOtherDesc.Name = "lblOtherDesc";
			this.lblOtherDesc.Size = new System.Drawing.Size(64, 18);
			this.lblOtherDesc.TabIndex = 20;
			this.lblOtherDesc.Text = "Other Desc:";
			this.lblOtherDesc.Visible = false;
			this.rtbOtherDesc.Location = new Point(114, 166);
			this.rtbOtherDesc.Name = "rtbOtherDesc";
			this.rtbOtherDesc.Size = new System.Drawing.Size(353, 20);
			this.rtbOtherDesc.TabIndex = 7;
			this.rtbOtherDesc.Visible = false;
			this.ID.Location = new Point(13, 49);
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Size = new System.Drawing.Size(53, 20);
			this.ID.TabIndex = 21;
			this.ID.Visible = false;
			this.mebConsideration.EnableNullValueInput = true;
			this.mebConsideration.Location = new Point(349, 139);
			this.mebConsideration.Mask = "C";
			this.mebConsideration.MaskType = MaskType.Numeric;
			this.mebConsideration.Name = "mebConsideration";
			this.mebConsideration.Size = new System.Drawing.Size(70, 20);
			this.mebConsideration.TabIndex = 22;
			this.mebConsideration.TabStop = false;
			this.mebConsideration.Text = "$0.00";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.mebConsideration);
			base.Controls.Add(this.ID);
			base.Controls.Add(this.rtbOtherDesc);
			base.Controls.Add(this.lblOtherDesc);
			base.Controls.Add(this.rdtpRecorded);
			base.Controls.Add(this.rdtpDated);
			base.Controls.Add(this.radLabel9);
			base.Controls.Add(this.rtbDocumentInstr);
			base.Controls.Add(this.rtbBook);
			base.Controls.Add(this.rtbPage);
			base.Controls.Add(this.radLabel10);
			base.Controls.Add(this.radLabel7);
			base.Controls.Add(this.radLabel6);
			base.Controls.Add(this.radLabel5);
			base.Controls.Add(this.radLabel4);
			base.Controls.Add(this.rddlOwnershipType);
			base.Controls.Add(this.radLabel3);
			base.Controls.Add(this.rtbGrantorName);
			base.Controls.Add(this.radLabel2);
			base.Controls.Add(this.rtbGranteeName);
			base.Controls.Add(this.radLabel1);
			base.Name = "ucChainOfTitleGrantee";
			base.Size = new System.Drawing.Size(486, 291);
			((ISupportInitialize)this.radLabel1).EndInit();
			((ISupportInitialize)this.rtbGranteeName).EndInit();
			((ISupportInitialize)this.radLabel2).EndInit();
			((ISupportInitialize)this.rtbGrantorName).EndInit();
			((ISupportInitialize)this.radLabel3).EndInit();
			((ISupportInitialize)this.rddlOwnershipType).EndInit();
			((ISupportInitialize)this.radLabel4).EndInit();
			((ISupportInitialize)this.radLabel5).EndInit();
			((ISupportInitialize)this.radLabel6).EndInit();
			((ISupportInitialize)this.radLabel7).EndInit();
			((ISupportInitialize)this.radLabel10).EndInit();
			((ISupportInitialize)this.rtbPage).EndInit();
			((ISupportInitialize)this.rtbBook).EndInit();
			((ISupportInitialize)this.rtbDocumentInstr).EndInit();
			((ISupportInitialize)this.radLabel9).EndInit();
			((ISupportInitialize)this.rdtpDated).EndInit();
			((ISupportInitialize)this.rdtpRecorded).EndInit();
			((ISupportInitialize)this.lblOtherDesc).EndInit();
			((ISupportInitialize)this.rtbOtherDesc).EndInit();
			((ISupportInitialize)this.ID).EndInit();
			((ISupportInitialize)this.mebConsideration).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		#endregion

		public const int CustomHeadingMaxSize = 20;

		public List<string> OwnershipTypes = new List<string>()
		{
			"Fee Simple",
			"Leasehold",
			"Other"
		};

		private RadLabel radLabel1;

		private RadTextBox rtbGranteeName;

		private RadLabel radLabel2;

		private RadTextBox rtbGrantorName;

		private RadLabel radLabel3;

		private RadDropDownList rddlOwnershipType;

		private RadLabel radLabel4;

		private RadLabel radLabel5;

		private RadLabel radLabel6;

		private RadLabel radLabel7;

		private RadLabel radLabel10;

		private RadTextBox rtbPage;

		private RadTextBox rtbBook;

		private RadTextBox rtbDocumentInstr;

		private RadLabel radLabel9;

		private RadDateTimePicker rdtpDated;

		private RadDateTimePicker rdtpRecorded;

		private RadLabel lblOtherDesc;

		private RadTextBox rtbOtherDesc;

		public RadSpinEditor ID;

		private RadMaskedEditBox mebConsideration;

		public AbstractMaker.Model.Deed Deed
		{
			get;
			set;
		}

		public string GranteeName
		{
			get;
			set;
		}
	}
}
