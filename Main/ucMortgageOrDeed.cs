// Decompiled with JetBrains decompiler
// Type: Sternhagen.ucMortgageOrDeed
// Assembly: Sternhagen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 926CB3A7-5318-4FD7-8127-F742EC5C62A1
// Assembly location: C:\Users\lhann\OneDrive\Documents\Software\Sternhagen\Sternhagen.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using AbstractMaker.Model;

namespace AbstractMaker.Main
{
  public class ucMortgageOrDeed : UserControl
  {
    private IContainer components = (IContainer) null;
    private RadLabel radLabel1;
    private RadDropDownList ddlMortgageType;
    private RadPageView pvMortgageDeedType;
    private RadButton rbAddMortgageType;
    private RadButton btnRemoveMortgageType;

    public List<Mortgage> MORTGAGES { get; set; }

    public ucMortgageOrDeed()
    {
      this.InitializeComponent();
      this.MORTGAGES = new List<Mortgage>();
      this.ddlMortgageType.DataSource = (object) new List<string>()
      {
        "Mortgagee",
        "Deed",
        "Beneficiary"
      };
      this.UpdateUIToReflectModel();
      ((RadPageViewNavigationViewElement) this.pvMortgageDeedType.ViewElement).DisplayMode = NavigationViewDisplayModes.Expanded;
      ((RadPageViewNavigationViewElement) this.pvMortgageDeedType.ViewElement).HamburgerButton.Enabled = false;
      ((RadPageViewNavigationViewElement) this.pvMortgageDeedType.ViewElement).Expand();
    }

    private void UpdateUIToReflectModel()
    {
      foreach (Mortgage mortgage_Type in (IEnumerable<Mortgage>) this.MORTGAGES.OrderBy<Mortgage, int>((Func<Mortgage, int>) (c => c.ID)))
      {
        ucMortgageOrDeedType mortgageOrDeedType = new ucMortgageOrDeedType(mortgage_Type);
        mortgageOrDeedType.Dock = DockStyle.Fill;
        RadPageViewPage radPageViewPage = new RadPageViewPage(mortgage_Type.I_Mortgage_Type);
        radPageViewPage.Controls.Add((Control) mortgageOrDeedType);
        this.pvMortgageDeedType.Pages.Add(radPageViewPage);
      }
    }

    private void rbAddMortgageType_Click(object sender, EventArgs e)
    {
      if (this.ddlMortgageType.SelectedItem.Text == "Deed")
      {

      }
      else
      {
        Mortgage mortgage_Type = new Mortgage()
        {
          I_Mortgage_Type = this.ddlMortgageType.SelectedItem.Text
        };
        this.MORTGAGES.Add(mortgage_Type);
        ucMortgageOrDeedType mortgageOrDeedType = new ucMortgageOrDeedType(mortgage_Type);
        mortgageOrDeedType.Dock = DockStyle.Fill;
        RadPageViewPage radPageViewPage = new RadPageViewPage(this.ddlMortgageType.SelectedItem.Text);
        radPageViewPage.Controls.Add((Control) mortgageOrDeedType);
        this.pvMortgageDeedType.Pages.Add(radPageViewPage);
        this.pvMortgageDeedType.SelectedPage = radPageViewPage;
        this.ReIndexMortgageTypes();
      }
    }

    private void btnRemoveMortgageType_Click(object sender, EventArgs e)
    {
      if (this.pvMortgageDeedType.Pages.Count == 0)
        return;
      RadPageViewPage selectedPage = this.pvMortgageDeedType.SelectedPage;
      if (selectedPage.Controls[0] is ucMortgageOrDeedType control1)
      {
        this.MORTGAGES.Remove(control1.Mortgage_Type);
        this.pvMortgageDeedType.Pages.Remove(selectedPage);
      }
    }

    private void pvMortgageDeedType_PageIndexChanged(
      object sender,
      RadPageViewIndexChangedEventArgs e)
    {
      this.ReIndexMortgageTypes();
    }

    private void ReIndexMortgageTypes()
    {
      foreach (RadPageViewPage page in this.pvMortgageDeedType.Pages)
      {
        if (page.Controls[0] is ucMortgageOrDeedType control1)
        {
          control1.PageIndex.Value = (Decimal) (this.pvMortgageDeedType.Pages.IndexOf(page) + 1);
          control1.ID.Value = (Decimal) (this.pvMortgageDeedType.Pages.IndexOf(page) + 1);
          control1.Mortgage_Type.ID = this.pvMortgageDeedType.Pages.IndexOf(page) + 1;
        }
      }
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
      this.ddlMortgageType = new RadDropDownList();
      this.pvMortgageDeedType = new RadPageView();
      this.rbAddMortgageType = new RadButton();
      this.btnRemoveMortgageType = new RadButton();
      this.radLabel1.BeginInit();
      this.ddlMortgageType.BeginInit();
      this.pvMortgageDeedType.BeginInit();
      this.rbAddMortgageType.BeginInit();
      this.btnRemoveMortgageType.BeginInit();
      this.SuspendLayout();
      this.radLabel1.Location = new Point(3, 3);
      this.radLabel1.Name = "radLabel1";
      this.radLabel1.Size = new System.Drawing.Size(30, 18);
      this.radLabel1.TabIndex = 0;
      this.radLabel1.Text = "Type";
      this.ddlMortgageType.Location = new Point(39, 3);
      this.ddlMortgageType.Name = "ddlMortgageType";
      this.ddlMortgageType.Size = new System.Drawing.Size(150, 20);
      this.ddlMortgageType.TabIndex = 1;
      this.ddlMortgageType.Text = "ddlMortgageType";
      this.pvMortgageDeedType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.pvMortgageDeedType.Location = new Point(3, 30);
      this.pvMortgageDeedType.Name = "pvMortgageDeedType";
      this.pvMortgageDeedType.Size = new System.Drawing.Size(1039, 820);
      this.pvMortgageDeedType.TabIndex = 117;
      this.pvMortgageDeedType.ViewMode = PageViewMode.NavigationView;
      this.pvMortgageDeedType.PageIndexChanged += new EventHandler<RadPageViewIndexChangedEventArgs>(this.pvMortgageDeedType_PageIndexChanged);
      ((RadPageViewNavigationViewElement) this.pvMortgageDeedType.GetChildAt(0)).ExpandedPaneWidth = 220;
      ((RadPageViewElement) this.pvMortgageDeedType.GetChildAt(0)).ItemDragMode = PageViewItemDragMode.Preview;
      this.rbAddMortgageType.Location = new Point(195, 0);
      this.rbAddMortgageType.Name = "rbAddMortgageType";
      this.rbAddMortgageType.Size = new System.Drawing.Size(110, 24);
      this.rbAddMortgageType.TabIndex = 118;
      this.rbAddMortgageType.Text = "Add";
      this.rbAddMortgageType.Click += new EventHandler(this.rbAddMortgageType_Click);
      this.btnRemoveMortgageType.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnRemoveMortgageType.Location = new Point(892, 0);
      this.btnRemoveMortgageType.Name = "btnRemoveMortgageType";
      this.btnRemoveMortgageType.Size = new System.Drawing.Size(150, 24);
      this.btnRemoveMortgageType.TabIndex = 122;
      this.btnRemoveMortgageType.Text = "Remove Selected";
      this.btnRemoveMortgageType.Click += new EventHandler(this.btnRemoveMortgageType_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.btnRemoveMortgageType);
      this.Controls.Add((Control) this.rbAddMortgageType);
      this.Controls.Add((Control) this.pvMortgageDeedType);
      this.Controls.Add((Control) this.ddlMortgageType);
      this.Controls.Add((Control) this.radLabel1);
      this.Name = nameof (ucMortgageOrDeed);
      this.Size = new System.Drawing.Size(1045, 866);
      this.radLabel1.EndInit();
      this.ddlMortgageType.EndInit();
      this.pvMortgageDeedType.EndInit();
      this.rbAddMortgageType.EndInit();
      this.btnRemoveMortgageType.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
