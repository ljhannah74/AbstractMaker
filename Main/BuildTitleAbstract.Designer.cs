using Telerik.WinControls;
using Telerik.WinControls.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AbstractMaker.Model;


namespace AbstractMaker.Main
{
	partial class BuildTitleAbstract
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
			this.components = new System.ComponentModel.Container();
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Text = "BuildTitleAbstract";
			this.btnSaveFormData = new RadButton();
			this.radSplitContainer = new RadSplitContainer();
			this.splitPanel1 = new SplitPanel();
			this.radPageView1 = new RadPageView();
			this.pgMortgagesAndDeeds = new RadPageViewPage();
			this.pgJudgmentLiens = new RadPageViewPage();
			this.pgChainOfTitle = new RadPageViewPage();
			this.pgTaxSheet = new RadPageViewPage();
			this.pgLegalDescription = new RadPageViewPage();
			this.splitPanel2 = new SplitPanel();
			this.radStatusStrip1 = new RadStatusStrip();
			this.radLabel1 = new RadLabel();
			this.radLabel2 = new RadLabel();
			this.radLabel5 = new RadLabel();
			this.radLabel6 = new RadLabel();
			this.tbLoanType = new RadTextBox();
			this.tbLoanAmount = new RadTextBox();
			this.tbFullAddress = new RadTextBox();
			this.tbBorrowers = new RadTextBox();
			this.rbShowFiles = new RadButton();
			((ISupportInitialize)this.btnSaveFormData).BeginInit();
			((ISupportInitialize)this.radSplitContainer).BeginInit();
			this.radSplitContainer.SuspendLayout();
			((ISupportInitialize)this.splitPanel1).BeginInit();
			this.splitPanel1.SuspendLayout();
			((ISupportInitialize)this.radPageView1).BeginInit();
			this.radPageView1.SuspendLayout();
			((ISupportInitialize)this.splitPanel2).BeginInit();
			((ISupportInitialize)this.radStatusStrip1).BeginInit();
			((ISupportInitialize)this.radLabel1).BeginInit();
			((ISupportInitialize)this.radLabel2).BeginInit();
			((ISupportInitialize)this.radLabel5).BeginInit();
			((ISupportInitialize)this.radLabel6).BeginInit();
			((ISupportInitialize)this.tbLoanType).BeginInit();
			((ISupportInitialize)this.tbLoanAmount).BeginInit();
			((ISupportInitialize)this.tbFullAddress).BeginInit();
			((ISupportInitialize)this.tbBorrowers).BeginInit();
			((ISupportInitialize)this.rbShowFiles).BeginInit();
			((ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.btnSaveFormData.Location = new Point(884, 12);
			this.btnSaveFormData.Name = "btnSaveFormData";
			this.btnSaveFormData.Size = new System.Drawing.Size(110, 24);
			this.btnSaveFormData.TabIndex = 0;
			this.btnSaveFormData.Text = "Save";
			this.btnSaveFormData.Click += new EventHandler(this.btnSaveFormData_Click);
			this.radSplitContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.radSplitContainer.Controls.Add(this.splitPanel1);
			this.radSplitContainer.Controls.Add(this.splitPanel2);
			this.radSplitContainer.Location = new Point(0, 68);
			this.radSplitContainer.Name = "radSplitContainer";
			this.radSplitContainer.RootElement.MinSize = new System.Drawing.Size(25, 25);
			this.radSplitContainer.Size = new System.Drawing.Size(1792, 873);
			this.radSplitContainer.TabIndex = 1;
			this.radSplitContainer.TabStop = false;
			this.splitPanel1.Controls.Add(this.radPageView1);
			this.splitPanel1.Location = new Point(0, 0);
			this.splitPanel1.Name = "splitPanel1";
			this.splitPanel1.RootElement.MinSize = new System.Drawing.Size(25, 25);
			this.splitPanel1.Size = new System.Drawing.Size(994, 873);
			this.splitPanel1.SizeInfo.AutoSizeScale = new SizeF(0.05593222f, 0f);
			this.splitPanel1.SizeInfo.SplitterCorrection = new System.Drawing.Size(99, 0);
			this.splitPanel1.TabIndex = 0;
			this.splitPanel1.TabStop = false;
			this.splitPanel1.Text = "splitPanel1";
			this.radPageView1.Controls.Add(this.pgChainOfTitle);
			this.radPageView1.Controls.Add(this.pgLegalDescription);
			this.radPageView1.Controls.Add(this.pgMortgagesAndDeeds);
			this.radPageView1.Controls.Add(this.pgJudgmentLiens);
			this.radPageView1.Controls.Add(this.pgTaxSheet);
			this.radPageView1.Dock = DockStyle.Fill;
			this.radPageView1.Location = new Point(0, 0);
			this.radPageView1.Name = "radPageView1";
			this.radPageView1.SelectedPage = this.pgChainOfTitle;
			this.radPageView1.Size = new System.Drawing.Size(994, 873);
			this.radPageView1.TabIndex = 0;
			this.radPageView1.SelectedPageChanged += new EventHandler(this.radPageView1_SelectedPageChanged);
			((RadPageViewStripElement)this.radPageView1.GetChildAt(0)).ItemDragMode = PageViewItemDragMode.None;
			this.pgMortgagesAndDeeds.ItemSize = new SizeF(129f, 28f);
			this.pgMortgagesAndDeeds.Location = new Point(10, 37);
			this.pgMortgagesAndDeeds.Name = "pgMortgagesAndDeeds";
			this.pgMortgagesAndDeeds.Size = new System.Drawing.Size(973, 825);
			this.pgMortgagesAndDeeds.Text = "Cur. Mortgages/Deeds";
			this.pgJudgmentLiens.ItemSize = new SizeF(123f, 28f);
			this.pgJudgmentLiens.Location = new Point(10, 37);
			this.pgJudgmentLiens.Name = "pgJudgmentLiens";
			this.pgJudgmentLiens.Size = new System.Drawing.Size(973, 825);
			this.pgJudgmentLiens.Text = "Cur. Judgments/Liens";
			this.pgChainOfTitle.ItemSize = new SizeF(82f, 28f);
			this.pgChainOfTitle.Location = new Point(10, 37);
			this.pgChainOfTitle.Name = "pgChainOfTitle";
			this.pgChainOfTitle.Size = new System.Drawing.Size(1047, 859);
			this.pgChainOfTitle.Text = "Chain of Title";
			this.pgTaxSheet.ItemSize = new SizeF(64f, 28f);
			this.pgTaxSheet.Location = new Point(10, 37);
			this.pgTaxSheet.Name = "pgTaxSheet";
			this.pgTaxSheet.Size = new System.Drawing.Size(973, 825);
			this.pgTaxSheet.Text = "Tax Sheet";
			this.pgLegalDescription.ItemSize = new SizeF(70f, 28f);
			this.pgLegalDescription.Location = new Point(10, 37);
			this.pgLegalDescription.Name = "pgLegalDescription";
			this.pgLegalDescription.Size = new System.Drawing.Size(973, 825);
			this.pgLegalDescription.Text = "Legal Desc";
			this.splitPanel2.Location = new Point(998, 0);
			this.splitPanel2.Name = "splitPanel2";
			this.splitPanel2.RootElement.MinSize = new System.Drawing.Size(25, 25);
			this.splitPanel2.Size = new System.Drawing.Size(794, 873);
			this.splitPanel2.SizeInfo.AutoSizeScale = new SizeF(-0.05593219f, 0f);
			this.splitPanel2.SizeInfo.SplitterCorrection = new System.Drawing.Size(-99, 0);
			this.splitPanel2.TabIndex = 1;
			this.splitPanel2.TabStop = false;
			this.splitPanel2.Text = "splitPanel2";
			this.radStatusStrip1.Location = new Point(0, 944);
			this.radStatusStrip1.Name = "radStatusStrip1";
			this.radStatusStrip1.Size = new System.Drawing.Size(1792, 26);
			this.radStatusStrip1.TabIndex = 2;
			this.radLabel1.Location = new Point(12, 12);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Size = new System.Drawing.Size(60, 18);
			this.radLabel1.TabIndex = 3;
			this.radLabel1.Text = "Loan Type:";
			this.radLabel2.Location = new Point(12, 36);
			this.radLabel2.Name = "radLabel2";
			this.radLabel2.Size = new System.Drawing.Size(76, 18);
			this.radLabel2.TabIndex = 4;
			this.radLabel2.Text = "Loan Amount:";
			this.radLabel5.Location = new Point(242, 36);
			this.radLabel5.Name = "radLabel5";
			this.radLabel5.Size = new System.Drawing.Size(66, 18);
			this.radLabel5.TabIndex = 8;
			this.radLabel5.Text = "Borrower(s):";
			this.radLabel6.Location = new Point(242, 12);
			this.radLabel6.Name = "radLabel6";
			this.radLabel6.Size = new System.Drawing.Size(69, 18);
			this.radLabel6.TabIndex = 7;
			this.radLabel6.Text = "Full Address:";
			this.tbLoanType.Location = new Point(102, 11);
			this.tbLoanType.Name = "tbLoanType";
			this.tbLoanType.ReadOnly = true;
			this.tbLoanType.Size = new System.Drawing.Size(125, 20);
			this.tbLoanType.TabIndex = 11;
			this.tbLoanAmount.Location = new Point(102, 35);
			this.tbLoanAmount.Name = "tbLoanAmount";
			this.tbLoanAmount.ReadOnly = true;
			this.tbLoanAmount.Size = new System.Drawing.Size(125, 20);
			this.tbLoanAmount.TabIndex = 12;
			this.tbFullAddress.Location = new Point(332, 11);
			this.tbFullAddress.Name = "tbFullAddress";
			this.tbFullAddress.ReadOnly = true;
			this.tbFullAddress.Size = new System.Drawing.Size(400, 20);
			this.tbFullAddress.TabIndex = 13;
			this.tbBorrowers.Location = new Point(332, 35);
			this.tbBorrowers.Name = "tbBorrowers";
			this.tbBorrowers.ReadOnly = true;
			this.tbBorrowers.Size = new System.Drawing.Size(400, 20);
			this.tbBorrowers.TabIndex = 14;
			this.rbShowFiles.Location = new Point(1022, 12);
			this.rbShowFiles.Name = "rbShowFiles";
			this.rbShowFiles.Size = new System.Drawing.Size(110, 24);
			this.rbShowFiles.TabIndex = 15;
			this.rbShowFiles.Text = "Show Files";
			this.rbShowFiles.Click += new EventHandler(this.rbShowFiles_Click);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(1792, 970);
			base.Controls.Add(this.rbShowFiles);
			base.Controls.Add(this.tbBorrowers);
			base.Controls.Add(this.tbFullAddress);
			base.Controls.Add(this.tbLoanAmount);
			base.Controls.Add(this.tbLoanType);
			base.Controls.Add(this.radLabel5);
			base.Controls.Add(this.radLabel6);
			base.Controls.Add(this.radLabel2);
			base.Controls.Add(this.radLabel1);
			base.Controls.Add(this.btnSaveFormData);
			base.Controls.Add(this.radStatusStrip1);
			base.Controls.Add(this.radSplitContainer);
			base.Name = "BuildTitleCommitment";
			base.RootElement.ApplyShapeToControl = true;
			this.Text = "Build Title Commitment";
			ucChainOfTitle _ucChainOfTitle = new ucChainOfTitle()
			{
				Dock = DockStyle.Fill
			};
			this.pgChainOfTitle.Controls.Add(_ucChainOfTitle);

			ucLegalDescription _ucLegalDescription = new ucLegalDescription(LEGAL_DESCRIPTION)
			{
				Dock = DockStyle.Fill
			};
			this.pgLegalDescription.Controls.Add(_ucLegalDescription);
			ucMortgageOrDeed _ucMortgageOrDeed = new ucMortgageOrDeed(mORTGAGES)
			{
				Dock = DockStyle.Fill
			};
			this.pgMortgagesAndDeeds.Controls.Add(_ucMortgageOrDeed);

			ucTaxSheet TaxSheetPnl = new ucTaxSheet(this.TaxSheet)
			{
				Dock = DockStyle.Fill
			};
			this.pgTaxSheet.Controls.Add((Control)TaxSheetPnl);

			ucJudgmentLiens _ucJudgmentLiens = new ucJudgmentLiens(this.judgmentLiens)
			{
				Dock = DockStyle.Fill
			};
			this.pgJudgmentLiens.Controls.Add(_ucJudgmentLiens);

			//base.Shown += new EventHandler(this.GetTitleCommitment_Shown);
			((ISupportInitialize)this.btnSaveFormData).EndInit();
			((ISupportInitialize)this.radSplitContainer).EndInit();
			this.radSplitContainer.ResumeLayout(false);
			((ISupportInitialize)this.splitPanel1).EndInit();
			this.splitPanel1.ResumeLayout(false);
			((ISupportInitialize)this.radPageView1).EndInit();
			this.radPageView1.ResumeLayout(false);
			((ISupportInitialize)this.splitPanel2).EndInit();
			((ISupportInitialize)this.radStatusStrip1).EndInit();
			((ISupportInitialize)this.radLabel1).EndInit();
			((ISupportInitialize)this.radLabel2).EndInit();
			((ISupportInitialize)this.radLabel5).EndInit();
			((ISupportInitialize)this.radLabel6).EndInit();
			((ISupportInitialize)this.tbLoanType).EndInit();
			((ISupportInitialize)this.tbLoanAmount).EndInit();
			((ISupportInitialize)this.tbFullAddress).EndInit();
			((ISupportInitialize)this.tbBorrowers).EndInit();
			((ISupportInitialize)this.rbShowFiles).EndInit();
			((ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		#endregion

		private RadSplitContainer radSplitContainer;

		private SplitPanel splitPanel1;

		private SplitPanel splitPanel2;

		private RadStatusStrip radStatusStrip1;

		private RadButton btnSaveFormData;

		private RadLabel radLabel1;

		private RadLabel radLabel2;

		private RadLabel radLabel5;

		private RadLabel radLabel6;

		private RadTextBox tbLoanType;

		private RadTextBox tbLoanAmount;

		private RadTextBox tbFullAddress;

		private RadTextBox tbBorrowers;

		private RadPageView radPageView1;


		private RadPageViewPage pgMortgagesAndDeeds;

		private RadPageViewPage pgJudgmentLiens;

		private RadPageViewPage pgChainOfTitle;

		private RadPageViewPage pgTaxSheet;

		private RadPageViewPage pgLegalDescription;

		private RadButton rbShowFiles;

		private Legal_Description LEGAL_DESCRIPTION = new Legal_Description()
		{
			Text = "",
			TaxID = "",
			PB_Legal_Description = true
		};

		private List<Mortgage> mORTGAGES = new List<Mortgage>();

		private TAX_SHEET TaxSheet = new TAX_SHEET();

		private JUDGMENTLIENS judgmentLiens = new JUDGMENTLIENS();
	}
}