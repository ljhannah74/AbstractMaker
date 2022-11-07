// Decompiled with JetBrains decompiler
// Type: Sternhagen.ucJudgmentLiens
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
  public class ucJudgmentLiens : UserControl
  {
    public List<string> JudgmentTypes = new List<string>()
    {
      "Child Support Order",
      "Civil Judgment",
      "Claim of Lien",
      "Criminal Judgment",
      "Federal Tax Lien",
      "Fieri Facias (FIFA)",
      "Home Association Lien",
      "Hospital Lien",
      "Lis Pendens",
      "Mechanics-Materialmens Lien",
      "Municipal Lien",
      "Notice of Commencement",
      "Spousal Support Order",
      "State Tax Lien",
      "Tax Lien",
      "UCC Financing Statement",
      "Other"
    };
    private IContainer components = (IContainer) null;
    private RadDropDownList rddlJudgmentTypes;
    private RadLabel radLabel1;
    private RadPageView pgJudgmentType;
    private RadButton btnAddJudgment;
    private RadButton btnRemoveJudgment;

    public JUDGMENTLIENS JudgmentLiensModel { get; set; }

    public ucJudgmentLiens(JUDGMENTLIENS judgmentLiens)
    {
      this.InitializeComponent();
      this.JudgmentLiensModel = judgmentLiens;
      this.rddlJudgmentTypes.DataSource = (object) this.JudgmentTypes;
      this.UpdateUIToReflectModel();
      ((RadPageViewNavigationViewElement) this.pgJudgmentType.ViewElement).DisplayMode = NavigationViewDisplayModes.Expanded;
      ((RadPageViewNavigationViewElement) this.pgJudgmentType.ViewElement).HamburgerButton.Enabled = false;
      ((RadPageViewNavigationViewElement) this.pgJudgmentType.ViewElement).Expand();
      this.pgJudgmentType.PageIndexChanged += new EventHandler<RadPageViewIndexChangedEventArgs>(this.PgJudgmentType_PageIndexChanged);
    }

    private void PgJudgmentType_PageIndexChanged(object sender, RadPageViewIndexChangedEventArgs e) => this.ReindexJudgmentTypes();

    private void ReindexJudgmentTypes()
    {
      foreach (RadPageViewPage page in this.pgJudgmentType.Pages)
        (page.Controls[0] as ucJudgmentLiensInfo).ID.Value = (Decimal) (this.pgJudgmentType.Pages.IndexOf(page) + 1);
    }

    private void UpdateUIToReflectModel()
    {
      foreach (Judgment judgment in (IEnumerable<Judgment>) this.JudgmentLiensModel.Judgments.OrderBy<Judgment, int>((Func<Judgment, int>) (c => c.ID)))
      {
        ucJudgmentLiensInfo judgementLiensInfo = new ucJudgmentLiensInfo(judgment);
        RadPageViewPage radPageViewPage = new RadPageViewPage(judgment.Name);
        radPageViewPage.Dock = DockStyle.Fill;
        radPageViewPage.Controls.Add((Control) judgementLiensInfo);
        this.pgJudgmentType.Pages.Add(radPageViewPage);
      }
      this.ReindexJudgmentTypes();
    }

    private void btnAddJudgment_Click(object sender, EventArgs e)
    {
      Judgment judgement = new Judgment()
      {
        Name = this.rddlJudgmentTypes.Text
      };
      this.JudgmentLiensModel.Judgments.Add(judgement);
      ucJudgmentLiensInfo judgementLiensInfo = new ucJudgmentLiensInfo(judgement);
      RadPageViewPage radPageViewPage = new RadPageViewPage(judgement.Name);
      radPageViewPage.Dock = DockStyle.Fill;
      radPageViewPage.Controls.Add((Control) judgementLiensInfo);
      this.pgJudgmentType.Pages.Add(radPageViewPage);
      this.pgJudgmentType.SelectedPage = radPageViewPage;
      this.ReindexJudgmentTypes();
    }

    private void btnRemoveJudgment_Click(object sender, EventArgs e)
    {
      if (this.pgJudgmentType.Pages.Count == 0)
        return;
      RadPageViewPage selectedPage = this.pgJudgmentType.SelectedPage;
      this.JudgmentLiensModel.Judgments.Remove((selectedPage.Controls[0] as ucJudgmentLiensInfo).JudgmentModel);
      this.pgJudgmentType.Pages.Remove(selectedPage);
      this.ReindexJudgmentTypes();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.rddlJudgmentTypes = new RadDropDownList();
      this.radLabel1 = new RadLabel();
      this.pgJudgmentType = new RadPageView();
      this.btnAddJudgment = new RadButton();
      this.btnRemoveJudgment = new RadButton();
      this.rddlJudgmentTypes.BeginInit();
      this.radLabel1.BeginInit();
      this.pgJudgmentType.BeginInit();
      this.btnAddJudgment.BeginInit();
      this.btnRemoveJudgment.BeginInit();
      this.SuspendLayout();
      this.rddlJudgmentTypes.Location = new Point(100, 21);
      this.rddlJudgmentTypes.Name = "rddlJudgmentTypes";
      this.rddlJudgmentTypes.Size = new System.Drawing.Size(181, 20);
      this.rddlJudgmentTypes.TabIndex = 0;
      this.radLabel1.Location = new Point(3, 21);
      this.radLabel1.Name = "radLabel1";
      this.radLabel1.Size = new System.Drawing.Size(91, 18);
      this.radLabel1.TabIndex = 2;
      this.radLabel1.Text = "Judgment Type:";
      this.pgJudgmentType.AllowDrop = true;
      this.pgJudgmentType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.pgJudgmentType.Location = new Point(3, 48);
      this.pgJudgmentType.Name = "pgJudgmentType";
      this.pgJudgmentType.Size = new System.Drawing.Size(982, 731);
      this.pgJudgmentType.TabIndex = 3;
      this.pgJudgmentType.ViewMode = PageViewMode.NavigationView;
      ((RadPageViewNavigationViewElement) this.pgJudgmentType.GetChildAt(0)).ExpandedPaneWidth = 220;
      ((RadPageViewElement) this.pgJudgmentType.GetChildAt(0)).ItemDragMode = PageViewItemDragMode.Preview;
      this.btnAddJudgment.Location = new Point(287, 18);
      this.btnAddJudgment.Name = "btnAddJudgment";
      this.btnAddJudgment.Size = new System.Drawing.Size(110, 24);
      this.btnAddJudgment.TabIndex = 4;
      this.btnAddJudgment.Text = "Add Judgment";
      this.btnAddJudgment.Click += new EventHandler(this.btnAddJudgment_Click);
      this.btnRemoveJudgment.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnRemoveJudgment.Location = new Point(835, 18);
      this.btnRemoveJudgment.Name = "btnRemoveJudgment";
      this.btnRemoveJudgment.Size = new System.Drawing.Size(150, 24);
      this.btnRemoveJudgment.TabIndex = 5;
      this.btnRemoveJudgment.Text = "Removed Selected";
      this.btnRemoveJudgment.Click += new EventHandler(this.btnRemoveJudgment_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.btnRemoveJudgment);
      this.Controls.Add((Control) this.btnAddJudgment);
      this.Controls.Add((Control) this.pgJudgmentType);
      this.Controls.Add((Control) this.radLabel1);
      this.Controls.Add((Control) this.rddlJudgmentTypes);
      this.Name = nameof (ucJudgmentLiens);
      this.Size = new System.Drawing.Size(989, 790);
      this.rddlJudgmentTypes.EndInit();
      this.radLabel1.EndInit();
      this.pgJudgmentType.EndInit();
      this.btnAddJudgment.EndInit();
      this.btnRemoveJudgment.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
