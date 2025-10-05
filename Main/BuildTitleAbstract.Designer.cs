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

        private RadStatusStrip radStatusStrip1;

        private RadButton btnSaveFormData;

        private RadLabel radLabel1;

        private RadLabel radLabel6;

        private RadTextBox tbOrderNo;

        private RadTextBox tbFullAddress;

        private RadPageView radPageView1;


        private RadPageViewPage pgMortgagesAndDeeds;

        private RadPageViewPage pgJudgmentLiens;

        private RadPageViewPage pgChainOfTitle;

        private RadPageViewPage pgTaxSheet;

        private RadPageViewPage pgLegalDescription;

        private Legal_Description LEGAL_DESCRIPTION = new Legal_Description()
        {
            Text = "",
            TaxID = "",
            PB_Legal_Description = true
        };

        private List<Mortgage> mORTGAGES = new List<Mortgage>();

        private TAX_SHEET TaxSheet = new TAX_SHEET();

        private JUDGMENTLIENS judgmentLiens = new JUDGMENTLIENS();
		private List<Deed> TITLE_CHAIN = new List<Deed>();
		public TitleAbstract TITLE_ABSTRACT = new TitleAbstract();
        private ucChainOfTitle _ucChainOfTitle;
        private ucLegalDescription _ucLegalDescription;
        private ucMortgageOrDeed _ucMortgageOrDeed;
        private ucTaxSheet _ucTaxSheet;

		public int TitleAbstractID;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
		{
            AbstractMaker.Model.Legal_Description legal_Description2 = new AbstractMaker.Model.Legal_Description();
            this.btnSaveFormData = new Telerik.WinControls.UI.RadButton();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.pgChainOfTitle = new Telerik.WinControls.UI.RadPageViewPage();
            this._ucChainOfTitle = new AbstractMaker.Main.ucChainOfTitle();
            this.pgLegalDescription = new Telerik.WinControls.UI.RadPageViewPage();
            this._ucLegalDescription = new AbstractMaker.Main.ucLegalDescription();
            this.pgMortgagesAndDeeds = new Telerik.WinControls.UI.RadPageViewPage();
            this.pgJudgmentLiens = new Telerik.WinControls.UI.RadPageViewPage();
            this.pgTaxSheet = new Telerik.WinControls.UI.RadPageViewPage();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.tbOrderNo = new Telerik.WinControls.UI.RadTextBox();
            this.tbFullAddress = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveFormData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.pgChainOfTitle.SuspendLayout();
            this.pgLegalDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOrderNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFullAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveFormData
            // 
            this.btnSaveFormData.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveFormData.Location = new System.Drawing.Point(1179, 15);
            this.btnSaveFormData.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveFormData.Name = "btnSaveFormData";
            // 
            // 
            // 
            this.btnSaveFormData.RootElement.ControlBounds = new System.Drawing.Rectangle(1179, 15, 137, 30);
            this.btnSaveFormData.Size = new System.Drawing.Size(183, 37);
            this.btnSaveFormData.TabIndex = 0;
            this.btnSaveFormData.Text = "Save";
            this.btnSaveFormData.Click += new System.EventHandler(this.btnSaveFormData_Click);
            // 
            // radPageView1
            // 
            this.radPageView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radPageView1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radPageView1.Controls.Add(this.pgChainOfTitle);
            this.radPageView1.Controls.Add(this.pgLegalDescription);
            this.radPageView1.Controls.Add(this.pgMortgagesAndDeeds);
            this.radPageView1.Controls.Add(this.pgJudgmentLiens);
            this.radPageView1.Controls.Add(this.pgTaxSheet);
            this.radPageView1.Location = new System.Drawing.Point(0, 68);
            this.radPageView1.Margin = new System.Windows.Forms.Padding(4);
            this.radPageView1.Name = "radPageView1";
            // 
            // 
            // 
            this.radPageView1.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 500, 375);
            this.radPageView1.SelectedPage = this.pgChainOfTitle;
            this.radPageView1.Size = new System.Drawing.Size(1604, 784);
            this.radPageView1.TabIndex = 0;
            // 
            // pgChainOfTitle
            // 
            this.pgChainOfTitle.Controls.Add(this._ucChainOfTitle);
            this.pgChainOfTitle.ItemSize = new System.Drawing.SizeF(82F, 28F);
            this.pgChainOfTitle.Location = new System.Drawing.Point(10, 37);
            this.pgChainOfTitle.Margin = new System.Windows.Forms.Padding(4);
            this.pgChainOfTitle.Name = "pgChainOfTitle";
            this.pgChainOfTitle.Size = new System.Drawing.Size(1583, 736);
            this.pgChainOfTitle.Text = "Chain of Title";
            // 
            // _ucChainOfTitle
            // 
            this._ucChainOfTitle.Location = new System.Drawing.Point(0, 0);
            this._ucChainOfTitle.Margin = new System.Windows.Forms.Padding(5);
            this._ucChainOfTitle.Name = "_ucChainOfTitle";
            this._ucChainOfTitle.Size = new System.Drawing.Size(1396, 1057);
            this._ucChainOfTitle.TabIndex = 0;
            // 
            // pgLegalDescription
            // 
            this.pgLegalDescription.Controls.Add(this._ucLegalDescription);
            this.pgLegalDescription.ItemSize = new System.Drawing.SizeF(70F, 28F);
            this.pgLegalDescription.Location = new System.Drawing.Point(15, 47);
            this.pgLegalDescription.Margin = new System.Windows.Forms.Padding(4);
            this.pgLegalDescription.Name = "pgLegalDescription";
            this.pgLegalDescription.Size = new System.Drawing.Size(1155, 903);
            this.pgLegalDescription.Text = "Legal Desc";
            // 
            // _ucLegalDescription
            // 
            legal_Description2.PB_Legal_Description = false;
            legal_Description2.TaxID = null;
            legal_Description2.Text = null;
            this._ucLegalDescription.Legal_Description = legal_Description2;
            this._ucLegalDescription.Location = new System.Drawing.Point(0, 0);
            this._ucLegalDescription.Margin = new System.Windows.Forms.Padding(5);
            this._ucLegalDescription.Name = "_ucLegalDescription";
            this._ucLegalDescription.Size = new System.Drawing.Size(1396, 1057);
            this._ucLegalDescription.TabIndex = 0;
            // 
            // pgMortgagesAndDeeds
            // 
            this.pgMortgagesAndDeeds.ItemSize = new System.Drawing.SizeF(129F, 28F);
            this.pgMortgagesAndDeeds.Location = new System.Drawing.Point(13, 46);
            this.pgMortgagesAndDeeds.Margin = new System.Windows.Forms.Padding(4);
            this.pgMortgagesAndDeeds.Name = "pgMortgagesAndDeeds";
            this.pgMortgagesAndDeeds.Size = new System.Drawing.Size(1297, 1015);
            this.pgMortgagesAndDeeds.Text = "Cur. Mortgages/Deeds";
            // 
            // pgJudgmentLiens
            // 
            this.pgJudgmentLiens.ItemSize = new System.Drawing.SizeF(123F, 28F);
            this.pgJudgmentLiens.Location = new System.Drawing.Point(13, 46);
            this.pgJudgmentLiens.Margin = new System.Windows.Forms.Padding(4);
            this.pgJudgmentLiens.Name = "pgJudgmentLiens";
            this.pgJudgmentLiens.Size = new System.Drawing.Size(1297, 1015);
            this.pgJudgmentLiens.Text = "Cur. Judgments/Liens";
            // 
            // pgTaxSheet
            // 
            this.pgTaxSheet.ItemSize = new System.Drawing.SizeF(64F, 28F);
            this.pgTaxSheet.Location = new System.Drawing.Point(13, 46);
            this.pgTaxSheet.Margin = new System.Windows.Forms.Padding(4);
            this.pgTaxSheet.Name = "pgTaxSheet";
            this.pgTaxSheet.Size = new System.Drawing.Size(1297, 1015);
            this.pgTaxSheet.Text = "Tax Sheet";
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 1023);
            this.radStatusStrip1.Margin = new System.Windows.Forms.Padding(4);
            this.radStatusStrip1.Name = "radStatusStrip1";
            // 
            // 
            // 
            this.radStatusStrip1.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 1023, 375, 30);
            this.radStatusStrip1.RootElement.StretchVertically = true;
            this.radStatusStrip1.Size = new System.Drawing.Size(1419, 32);
            this.radStatusStrip1.TabIndex = 2;
            // 
            // radLabel1
            // 
            this.radLabel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radLabel1.Location = new System.Drawing.Point(16, 15);
            this.radLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.radLabel1.Name = "radLabel1";
            // 
            // 
            // 
            this.radLabel1.RootElement.ControlBounds = new System.Drawing.Rectangle(16, 15, 125, 22);
            this.radLabel1.Size = new System.Drawing.Size(80, 22);
            this.radLabel1.TabIndex = 3;
            this.radLabel1.Text = "Order No:";
            // 
            // radLabel6
            // 
            this.radLabel6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radLabel6.Location = new System.Drawing.Point(323, 15);
            this.radLabel6.Margin = new System.Windows.Forms.Padding(4);
            this.radLabel6.Name = "radLabel6";
            // 
            // 
            // 
            this.radLabel6.RootElement.ControlBounds = new System.Drawing.Rectangle(323, 15, 125, 22);
            this.radLabel6.Size = new System.Drawing.Size(92, 22);
            this.radLabel6.TabIndex = 7;
            this.radLabel6.Text = "Full Address:";
            // 
            // tbOrderNo
            // 
            this.tbOrderNo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbOrderNo.Location = new System.Drawing.Point(136, 14);
            this.tbOrderNo.Margin = new System.Windows.Forms.Padding(4);
            this.tbOrderNo.Name = "tbLoanType";
            this.tbOrderNo.ReadOnly = true;
            // 
            // 
            // 
            this.tbOrderNo.RootElement.ControlBounds = new System.Drawing.Rectangle(136, 14, 125, 25);
            this.tbOrderNo.RootElement.StretchVertically = true;
            this.tbOrderNo.Size = new System.Drawing.Size(167, 25);
            this.tbOrderNo.TabIndex = 11;
            // 
            // tbFullAddress
            // 
            this.tbFullAddress.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbFullAddress.Location = new System.Drawing.Point(443, 14);
            this.tbFullAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbFullAddress.Name = "tbFullAddress";
            this.tbFullAddress.ReadOnly = true;
            // 
            // 
            // 
            this.tbFullAddress.RootElement.ControlBounds = new System.Drawing.Rectangle(443, 14, 125, 25);
            this.tbFullAddress.RootElement.StretchVertically = true;
            this.tbFullAddress.Size = new System.Drawing.Size(533, 25);
            this.tbFullAddress.TabIndex = 13;
            // 
            // BuildTitleAbstract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 1055);
            this.Controls.Add(this.tbFullAddress);
            this.Controls.Add(this.tbOrderNo);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.btnSaveFormData);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.radPageView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BuildTitleAbstract";
            this.Text = "Build Title Commitment";
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveFormData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.pgChainOfTitle.ResumeLayout(false);
            this.pgLegalDescription.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOrderNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFullAddress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

	}
}