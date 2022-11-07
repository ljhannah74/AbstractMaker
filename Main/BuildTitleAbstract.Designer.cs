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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuildTitleAbstract));
			this.btnSaveFormData = new Telerik.WinControls.UI.RadButton();
			this.radSplitContainer = new Telerik.WinControls.UI.RadSplitContainer();
			this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
			this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
			this.pgChainOfTitle = new Telerik.WinControls.UI.RadPageViewPage();
			this._ucChainOfTitle = new AbstractMaker.Main.ucChainOfTitle();
			this.pgLegalDescription = new Telerik.WinControls.UI.RadPageViewPage();
			this.pgMortgagesAndDeeds = new Telerik.WinControls.UI.RadPageViewPage();
			this.pgJudgmentLiens = new Telerik.WinControls.UI.RadPageViewPage();
			this.pgTaxSheet = new Telerik.WinControls.UI.RadPageViewPage();
			this.splitPanel2 = new Telerik.WinControls.UI.SplitPanel();
			this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
			this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
			this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
			this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
			this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
			this.tbLoanType = new Telerik.WinControls.UI.RadTextBox();
			this.tbLoanAmount = new Telerik.WinControls.UI.RadTextBox();
			this.tbFullAddress = new Telerik.WinControls.UI.RadTextBox();
			this.tbBorrowers = new Telerik.WinControls.UI.RadTextBox();
			this.rbShowFiles = new Telerik.WinControls.UI.RadButton();
			((System.ComponentModel.ISupportInitialize)(this.btnSaveFormData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radSplitContainer)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
			this.pgChainOfTitle.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbLoanType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbLoanAmount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbFullAddress)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbBorrowers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rbShowFiles)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSaveFormData
			// 
			this.btnSaveFormData.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnSaveFormData.Location = new System.Drawing.Point(884, 12);
			this.btnSaveFormData.Name = "btnSaveFormData";
			// 
			// 
			// 
			this.btnSaveFormData.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 110, 24);
			this.btnSaveFormData.TabIndex = 0;
			this.btnSaveFormData.Text = "Save";
			this.btnSaveFormData.Click += new System.EventHandler(this.btnSaveFormData_Click);
			// 
			// radSplitContainer
			// 
			this.radSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.radSplitContainer.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.radSplitContainer.Controls.Add(this.splitPanel1);
			this.radSplitContainer.Controls.Add(this.splitPanel2);
			this.radSplitContainer.Location = new System.Drawing.Point(0, 68);
			this.radSplitContainer.Name = "radSplitContainer";
			// 
			// 
			// 
			this.radSplitContainer.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 200, 200);
			this.radSplitContainer.RootElement.MinSize = new System.Drawing.Size(25, 25);
			this.radSplitContainer.Size = new System.Drawing.Size(1604, 784);
			this.radSplitContainer.TabIndex = 1;
			this.radSplitContainer.TabStop = false;
			// 
			// splitPanel1
			// 
			this.splitPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.splitPanel1.Controls.Add(this.radPageView1);
			this.splitPanel1.Location = new System.Drawing.Point(0, 0);
			this.splitPanel1.Name = "splitPanel1";
			// 
			// 
			// 
			this.splitPanel1.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 200, 200);
			this.splitPanel1.RootElement.MinSize = new System.Drawing.Size(25, 25);
			this.splitPanel1.Size = new System.Drawing.Size(889, 784);
			this.splitPanel1.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0.05593222F, 0F);
			this.splitPanel1.SizeInfo.SplitterCorrection = new System.Drawing.Size(99, 0);
			this.splitPanel1.TabIndex = 0;
			this.splitPanel1.TabStop = false;
			this.splitPanel1.Text = "splitPanel1";
			// 
			// radPageView1
			// 
			this.radPageView1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.radPageView1.Controls.Add(this.pgChainOfTitle);
			this.radPageView1.Controls.Add(this.pgLegalDescription);
			this.radPageView1.Controls.Add(this.pgMortgagesAndDeeds);
			this.radPageView1.Controls.Add(this.pgJudgmentLiens);
			this.radPageView1.Controls.Add(this.pgTaxSheet);
			this.radPageView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.radPageView1.Location = new System.Drawing.Point(0, 0);
			this.radPageView1.Name = "radPageView1";
			// 
			// 
			// 
			this.radPageView1.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 400, 300);
			this.radPageView1.SelectedPage = this.pgChainOfTitle;
			this.radPageView1.Size = new System.Drawing.Size(889, 784);
			this.radPageView1.TabIndex = 0;
			this.radPageView1.SelectedPageChanged += new System.EventHandler(this.radPageView1_SelectedPageChanged);
			// 
			// pgChainOfTitle
			// 
			this.pgChainOfTitle.Controls.Add(this._ucChainOfTitle);
			this.pgChainOfTitle.ItemSize = new System.Drawing.SizeF(82F, 28F);
			this.pgChainOfTitle.Location = new System.Drawing.Point(10, 37);
			this.pgChainOfTitle.Name = "pgChainOfTitle";
			this.pgChainOfTitle.Size = new System.Drawing.Size(868, 736);
			this.pgChainOfTitle.Text = "Chain of Title";
			// 
			// _ucChainOfTitle
			// 
			this._ucChainOfTitle.Location = new System.Drawing.Point(0, 0);
			this._ucChainOfTitle.Name = "_ucChainOfTitle";
			this._ucChainOfTitle.PB_Title_Chain = false;
			this._ucChainOfTitle.Size = new System.Drawing.Size(1047, 859);
			this._ucChainOfTitle.TabIndex = 0;
			// 
			// pgLegalDescription
			// 
			this.pgLegalDescription.ItemSize = new System.Drawing.SizeF(70F, 28F);
			this.pgLegalDescription.Location = new System.Drawing.Point(10, 37);
			this.pgLegalDescription.Name = "pgLegalDescription";
			this.pgLegalDescription.Size = new System.Drawing.Size(973, 825);
			this.pgLegalDescription.Text = "Legal Desc";
			// 
			// pgMortgagesAndDeeds
			// 
			this.pgMortgagesAndDeeds.ItemSize = new System.Drawing.SizeF(129F, 28F);
			this.pgMortgagesAndDeeds.Location = new System.Drawing.Point(10, 37);
			this.pgMortgagesAndDeeds.Name = "pgMortgagesAndDeeds";
			this.pgMortgagesAndDeeds.Size = new System.Drawing.Size(973, 825);
			this.pgMortgagesAndDeeds.Text = "Cur. Mortgages/Deeds";
			// 
			// pgJudgmentLiens
			// 
			this.pgJudgmentLiens.ItemSize = new System.Drawing.SizeF(123F, 28F);
			this.pgJudgmentLiens.Location = new System.Drawing.Point(10, 37);
			this.pgJudgmentLiens.Name = "pgJudgmentLiens";
			this.pgJudgmentLiens.Size = new System.Drawing.Size(973, 825);
			this.pgJudgmentLiens.Text = "Cur. Judgments/Liens";
			// 
			// pgTaxSheet
			// 
			this.pgTaxSheet.ItemSize = new System.Drawing.SizeF(64F, 28F);
			this.pgTaxSheet.Location = new System.Drawing.Point(10, 37);
			this.pgTaxSheet.Name = "pgTaxSheet";
			this.pgTaxSheet.Size = new System.Drawing.Size(973, 825);
			this.pgTaxSheet.Text = "Tax Sheet";
			// 
			// splitPanel2
			// 
			this.splitPanel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.splitPanel2.Location = new System.Drawing.Point(893, 0);
			this.splitPanel2.Name = "splitPanel2";
			// 
			// 
			// 
			this.splitPanel2.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 200, 200);
			this.splitPanel2.RootElement.MinSize = new System.Drawing.Size(25, 25);
			this.splitPanel2.Size = new System.Drawing.Size(711, 784);
			this.splitPanel2.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(-0.05593219F, 0F);
			this.splitPanel2.SizeInfo.SplitterCorrection = new System.Drawing.Size(-99, 0);
			this.splitPanel2.TabIndex = 1;
			this.splitPanel2.TabStop = false;
			this.splitPanel2.Text = "splitPanel2";
			// 
			// radStatusStrip1
			// 
			this.radStatusStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.radStatusStrip1.Location = new System.Drawing.Point(0, 855);
			this.radStatusStrip1.Name = "radStatusStrip1";
			// 
			// 
			// 
			this.radStatusStrip1.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 300, 24);
			this.radStatusStrip1.RootElement.StretchVertically = true;
			this.radStatusStrip1.Size = new System.Drawing.Size(1604, 26);
			this.radStatusStrip1.TabIndex = 2;
			// 
			// radLabel1
			// 
			this.radLabel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.radLabel1.Location = new System.Drawing.Point(12, 12);
			this.radLabel1.Name = "radLabel1";
			// 
			// 
			// 
			this.radLabel1.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 100, 18);
			this.radLabel1.Size = new System.Drawing.Size(60, 18);
			this.radLabel1.TabIndex = 3;
			this.radLabel1.Text = "Loan Type:";
			// 
			// radLabel2
			// 
			this.radLabel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.radLabel2.Location = new System.Drawing.Point(12, 36);
			this.radLabel2.Name = "radLabel2";
			// 
			// 
			// 
			this.radLabel2.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 100, 18);
			this.radLabel2.Size = new System.Drawing.Size(76, 18);
			this.radLabel2.TabIndex = 4;
			this.radLabel2.Text = "Loan Amount:";
			// 
			// radLabel5
			// 
			this.radLabel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.radLabel5.Location = new System.Drawing.Point(242, 36);
			this.radLabel5.Name = "radLabel5";
			// 
			// 
			// 
			this.radLabel5.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 100, 18);
			this.radLabel5.Size = new System.Drawing.Size(66, 18);
			this.radLabel5.TabIndex = 8;
			this.radLabel5.Text = "Borrower(s):";
			// 
			// radLabel6
			// 
			this.radLabel6.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.radLabel6.Location = new System.Drawing.Point(242, 12);
			this.radLabel6.Name = "radLabel6";
			// 
			// 
			// 
			this.radLabel6.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 100, 18);
			this.radLabel6.Size = new System.Drawing.Size(69, 18);
			this.radLabel6.TabIndex = 7;
			this.radLabel6.Text = "Full Address:";
			// 
			// tbLoanType
			// 
			this.tbLoanType.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tbLoanType.Location = new System.Drawing.Point(102, 11);
			this.tbLoanType.Name = "tbLoanType";
			this.tbLoanType.ReadOnly = true;
			// 
			// 
			// 
			this.tbLoanType.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 100, 20);
			this.tbLoanType.RootElement.StretchVertically = true;
			this.tbLoanType.Size = new System.Drawing.Size(125, 20);
			this.tbLoanType.TabIndex = 11;
			// 
			// tbLoanAmount
			// 
			this.tbLoanAmount.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tbLoanAmount.Location = new System.Drawing.Point(102, 35);
			this.tbLoanAmount.Name = "tbLoanAmount";
			this.tbLoanAmount.ReadOnly = true;
			// 
			// 
			// 
			this.tbLoanAmount.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 100, 20);
			this.tbLoanAmount.RootElement.StretchVertically = true;
			this.tbLoanAmount.Size = new System.Drawing.Size(125, 20);
			this.tbLoanAmount.TabIndex = 12;
			// 
			// tbFullAddress
			// 
			this.tbFullAddress.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tbFullAddress.Location = new System.Drawing.Point(332, 11);
			this.tbFullAddress.Name = "tbFullAddress";
			this.tbFullAddress.ReadOnly = true;
			// 
			// 
			// 
			this.tbFullAddress.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 100, 20);
			this.tbFullAddress.RootElement.StretchVertically = true;
			this.tbFullAddress.Size = new System.Drawing.Size(400, 20);
			this.tbFullAddress.TabIndex = 13;
			// 
			// tbBorrowers
			// 
			this.tbBorrowers.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tbBorrowers.Location = new System.Drawing.Point(332, 35);
			this.tbBorrowers.Name = "tbBorrowers";
			this.tbBorrowers.ReadOnly = true;
			// 
			// 
			// 
			this.tbBorrowers.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 100, 20);
			this.tbBorrowers.RootElement.StretchVertically = true;
			this.tbBorrowers.Size = new System.Drawing.Size(400, 20);
			this.tbBorrowers.TabIndex = 14;
			// 
			// rbShowFiles
			// 
			this.rbShowFiles.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.rbShowFiles.Location = new System.Drawing.Point(1022, 12);
			this.rbShowFiles.Name = "rbShowFiles";
			// 
			// 
			// 
			this.rbShowFiles.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 110, 24);
			this.rbShowFiles.TabIndex = 15;
			this.rbShowFiles.Text = "Show Files";
			this.rbShowFiles.Click += new System.EventHandler(this.rbShowFiles_Click);
			// 
			// BuildTitleAbstract
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1604, 881);
			this.Controls.Add(this.rbShowFiles);
			this.Controls.Add(this.tbBorrowers);
			this.Controls.Add(this.tbFullAddress);
			this.Controls.Add(this.tbLoanAmount);
			this.Controls.Add(this.tbLoanType);
			this.Controls.Add(this.radLabel5);
			this.Controls.Add(this.radLabel6);
			this.Controls.Add(this.radLabel2);
			this.Controls.Add(this.radLabel1);
			this.Controls.Add(this.btnSaveFormData);
			this.Controls.Add(this.radStatusStrip1);
			this.Controls.Add(this.radSplitContainer);
			this.Name = "BuildTitleAbstract";
			this.Text = "Build Title Commitment";
			this.Load += new System.EventHandler(this.BuildTitleAbstract_Load);
			((System.ComponentModel.ISupportInitialize)(this.btnSaveFormData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radSplitContainer)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
			this.pgChainOfTitle.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbLoanType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbLoanAmount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbFullAddress)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbBorrowers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rbShowFiles)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

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
		private ucChainOfTitle _ucChainOfTitle;
	}
}