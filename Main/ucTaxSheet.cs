// Decompiled with JetBrains decompiler
// Type: Sternhagen.ucTaxSheet
// Assembly: Sternhagen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 926CB3A7-5318-4FD7-8127-F742EC5C62A1
// Assembly location: C:\Users\lhann\OneDrive\Documents\Software\Sternhagen\Sternhagen.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using AbstractMaker.Model;
using System.Collections.Generic;

namespace AbstractMaker.Main
{
  public class ucTaxSheet : UserControl
  {
    private IContainer components = (IContainer) null;
    private RadLabel radLabel1;
    private RadTextBox rtbBorrowerOwner;
    private RadPageView pgTaxSheets;
    private RadButton btnAddTaxSheet;
    private RadButton btnRemoveTaxSheet;

    public TAX_SHEET TaxSheetModel { get; set; }

    public ucTaxSheet(TAX_SHEET taxSheet)
    {
      this.InitializeComponent();
      this.TaxSheetModel = taxSheet;
      this.UpdateUIToReflectModel();
      this.rtbBorrowerOwner.TextChanged += new EventHandler(this.RtbBorrowerOwner_TextChanged);
      this.pgTaxSheets.PageIndexChanged += new EventHandler<RadPageViewIndexChangedEventArgs>(this.PgTaxSheets_PageIndexChanged);
    }

    private void RtbBorrowerOwner_TextChanged(object sender, EventArgs e) => this.TaxSheetModel.BorrowerOwner = this.rtbBorrowerOwner.Text;

    private void UpdateUIToReflectModel()
    {
      this.rtbBorrowerOwner.Text = this.TaxSheetModel.BorrowerOwner;
      foreach (TaxSheet taxSheet in this.TaxSheetModel.TaxSheets)
      {
        ucTaxSheetInfo ucTaxSheetInfo = new ucTaxSheetInfo(taxSheet);
        RadPageViewPage radPageViewPage = new RadPageViewPage();
        radPageViewPage.Dock = DockStyle.Fill;
        radPageViewPage.Controls.Add((Control) ucTaxSheetInfo);
        this.pgTaxSheets.Pages.Add(radPageViewPage);
      }
      ((RadPageViewNavigationViewElement) this.pgTaxSheets.ViewElement).Expand();
      this.ReindexTaxSheets();
    }

    private void btnAddTaxSheet_Click(object sender, EventArgs e)
    {
      TaxSheet taxSheet = new TaxSheet();
      this.TaxSheetModel.TaxSheets.Add(taxSheet);
      ucTaxSheetInfo ucTaxSheetInfo = new ucTaxSheetInfo(taxSheet);
      RadPageViewPage radPageViewPage = new RadPageViewPage();
      radPageViewPage.Dock = DockStyle.Fill;
      radPageViewPage.Controls.Add((Control) ucTaxSheetInfo);
      this.pgTaxSheets.Pages.Add(radPageViewPage);
      this.pgTaxSheets.SelectedPage = radPageViewPage;
      this.ReindexTaxSheets();
    }

    private void btnRemoveTaxSheet_Click(object sender, EventArgs e)
    {
      if (this.pgTaxSheets.Pages.Count == 0)
        return;
      RadPageViewPage selectedPage = this.pgTaxSheets.SelectedPage;
      this.TaxSheetModel.TaxSheets.Remove((selectedPage.Controls[0] as ucTaxSheetInfo).TaxSheetModel);
      this.pgTaxSheets.Pages.Remove(selectedPage);
      this.ReindexTaxSheets();
    }

    private void PgTaxSheets_PageIndexChanged(object sender, RadPageViewIndexChangedEventArgs e) => this.ReindexTaxSheets();

    private void ReindexTaxSheets()
    {
      foreach (RadPageViewPage page in this.pgTaxSheets.Pages)
        (page.Controls[0] as ucTaxSheetInfo).ID.Value = (Decimal) (this.pgTaxSheets.Pages.IndexOf(page) + 1);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.radLabel1 = new RadLabel();
      this.rtbBorrowerOwner = new RadTextBox();
      this.pgTaxSheets = new RadPageView();
      this.btnAddTaxSheet = new RadButton();
      this.btnRemoveTaxSheet = new RadButton();
      this.radLabel1.BeginInit();
      this.rtbBorrowerOwner.BeginInit();
      this.pgTaxSheets.BeginInit();
      this.btnAddTaxSheet.BeginInit();
      this.btnRemoveTaxSheet.BeginInit();
      this.SuspendLayout();
      this.radLabel1.Location = new Point(4, 4);
      this.radLabel1.Name = "radLabel1";
      this.radLabel1.Size = new System.Drawing.Size(90, 18);
      this.radLabel1.TabIndex = 5;
      this.radLabel1.Text = "Borrower Owner:";
      this.rtbBorrowerOwner.Location = new Point(101, 3);
      this.rtbBorrowerOwner.Name = "rtbBorrowerOwner";
      this.rtbBorrowerOwner.Size = new System.Drawing.Size(272, 20);
      this.rtbBorrowerOwner.TabIndex = 2;
      this.pgTaxSheets.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.pgTaxSheets.Location = new Point(4, 57);
      this.pgTaxSheets.Name = "pgTaxSheets";
      this.pgTaxSheets.Size = new System.Drawing.Size(950, 588);
      this.pgTaxSheets.TabIndex = 9;
      this.pgTaxSheets.ViewMode = PageViewMode.NavigationView;
      ((RadPageViewNavigationViewElement) this.pgTaxSheets.GetChildAt(0)).ExpandedPaneWidth = 220;
      this.pgTaxSheets.GetChildAt(0).GetChildAt(3).Enabled = false;
      this.btnAddTaxSheet.Location = new Point(4, 27);
      this.btnAddTaxSheet.Name = "btnAddTaxSheet";
      this.btnAddTaxSheet.Size = new System.Drawing.Size(110, 24);
      this.btnAddTaxSheet.TabIndex = 4;
      this.btnAddTaxSheet.Text = "Add Tax Sheet";
      this.btnAddTaxSheet.Click += new EventHandler(this.btnAddTaxSheet_Click);
      this.btnRemoveTaxSheet.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnRemoveTaxSheet.Location = new Point(828, 27);
      this.btnRemoveTaxSheet.Name = "btnRemoveTaxSheet";
      this.btnRemoveTaxSheet.Size = new System.Drawing.Size(126, 24);
      this.btnRemoveTaxSheet.TabIndex = 10;
      this.btnRemoveTaxSheet.Text = "Remove Tax Sheet";
      this.btnRemoveTaxSheet.Click += new EventHandler(this.btnRemoveTaxSheet_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.btnRemoveTaxSheet);
      this.Controls.Add((Control) this.btnAddTaxSheet);
      this.Controls.Add((Control) this.pgTaxSheets);
      this.Controls.Add((Control) this.rtbBorrowerOwner);
      this.Controls.Add((Control) this.radLabel1);
      this.Name = nameof (ucTaxSheet);
      this.Size = new System.Drawing.Size(957, 659);
      this.radLabel1.EndInit();
      this.rtbBorrowerOwner.EndInit();
      this.pgTaxSheets.EndInit();
      this.btnAddTaxSheet.EndInit();
      this.btnRemoveTaxSheet.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
