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
  public class 
  ucMortgageOrDeed : UserControl
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
      this.ddlMortgageType.DataSource = new List<string>()
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.ddlMortgageType = new Telerik.WinControls.UI.RadDropDownList();
            this.pvMortgageDeedType = new Telerik.WinControls.UI.RadPageView();
            this.rbAddMortgageType = new Telerik.WinControls.UI.RadButton();
            this.btnRemoveMortgageType = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlMortgageType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvMortgageDeedType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbAddMortgageType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveMortgageType)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radLabel1.Location = new System.Drawing.Point(4, 4);
            this.radLabel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radLabel1.Name = "radLabel1";
            // 
            // 
            // 
            this.radLabel1.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 125, 22);
            this.radLabel1.Size = new System.Drawing.Size(40, 22);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Type";
            // 
            // ddlMortgageType
            // 
            this.ddlMortgageType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ddlMortgageType.DropDownHeight = 141;
            this.ddlMortgageType.ItemHeight = 24;
            this.ddlMortgageType.Location = new System.Drawing.Point(52, 4);
            this.ddlMortgageType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ddlMortgageType.Name = "ddlMortgageType";
            // 
            // 
            // 
            this.ddlMortgageType.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 156, 25);
            this.ddlMortgageType.RootElement.StretchVertically = true;
            this.ddlMortgageType.Size = new System.Drawing.Size(200, 25);
            this.ddlMortgageType.TabIndex = 1;
            this.ddlMortgageType.Text = "ddlMortgageType";
            // 
            // pvMortgageDeedType
            // 
            this.pvMortgageDeedType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pvMortgageDeedType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pvMortgageDeedType.Location = new System.Drawing.Point(4, 37);
            this.pvMortgageDeedType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pvMortgageDeedType.Name = "pvMortgageDeedType";
            // 
            // 
            // 
            this.pvMortgageDeedType.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 500, 375);
            this.pvMortgageDeedType.Size = new System.Drawing.Size(1385, 1009);
            this.pvMortgageDeedType.TabIndex = 117;
            this.pvMortgageDeedType.ViewMode = Telerik.WinControls.UI.PageViewMode.NavigationView;
            this.pvMortgageDeedType.PageIndexChanged += new System.EventHandler<Telerik.WinControls.UI.RadPageViewIndexChangedEventArgs>(this.pvMortgageDeedType_PageIndexChanged);
            // 
            // rbAddMortgageType
            // 
            this.rbAddMortgageType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbAddMortgageType.Location = new System.Drawing.Point(260, 0);
            this.rbAddMortgageType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbAddMortgageType.Name = "rbAddMortgageType";
            // 
            // 
            // 
            this.rbAddMortgageType.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 137, 30);
            this.rbAddMortgageType.Size = new System.Drawing.Size(147, 30);
            this.rbAddMortgageType.TabIndex = 118;
            this.rbAddMortgageType.Text = "Add";
            this.rbAddMortgageType.Click += new System.EventHandler(this.rbAddMortgageType_Click);
            // 
            // btnRemoveMortgageType
            // 
            this.btnRemoveMortgageType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveMortgageType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemoveMortgageType.Location = new System.Drawing.Point(1189, 0);
            this.btnRemoveMortgageType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveMortgageType.Name = "btnRemoveMortgageType";
            // 
            // 
            // 
            this.btnRemoveMortgageType.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 137, 30);
            this.btnRemoveMortgageType.Size = new System.Drawing.Size(200, 30);
            this.btnRemoveMortgageType.TabIndex = 122;
            this.btnRemoveMortgageType.Text = "Remove Selected";
            this.btnRemoveMortgageType.Click += new System.EventHandler(this.btnRemoveMortgageType_Click);
            // 
            // ucMortgageOrDeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRemoveMortgageType);
            this.Controls.Add(this.rbAddMortgageType);
            this.Controls.Add(this.pvMortgageDeedType);
            this.Controls.Add(this.ddlMortgageType);
            this.Controls.Add(this.radLabel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ucMortgageOrDeed";
            this.Size = new System.Drawing.Size(1393, 1066);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlMortgageType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvMortgageDeedType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbAddMortgageType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveMortgageType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }
  }
}
