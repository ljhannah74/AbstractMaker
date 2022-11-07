// Decompiled with JetBrains decompiler
// Type: Sternhagen.ucMortgageOrDeedType
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
  public class ucMortgageOrDeedType : UserControl
  {
    private IContainer components = (IContainer) null;
    private RadCheckBox rcbxReleaseRequirment;
    private RadLabel radLabel1;
    private RadTextBox tbLenderName;
    private RadLabel radLabel2;
    private RadLabel radLabel4;
    private RadLabel radLabel5;
    private RadLabel radLabel6;
    private RadLabel radLabel7;
    private RadTextBox rtbAmount;
    private RadDateTimePicker dtpExecutedDate;
    private RadDateTimePicker dtpFiledDate;
    private RadTextBox tbBook;
    private RadTextBox tbPage;
    private RadLabel radLabel3;
    private RadLabel radLabel8;
    private RadLabel radLabel9;
    private RadTextBox tbDocument;
    private RadTextBox tbTrustee;
    private RadTextBox tbSignedBy;
    private RadLabel radLabel10;
    private RadTextBox tbJurisdiction;
    private RadLabel radLabel11;
    private RadTextBox tbForeclosingParty;
    private RadLabel radLabel12;
    private RadTextBox tbForeclosureCaseNumber;
    private RadLabel radLabel13;
    private RadDateTimePicker dtpCaseFiledDate;
    private RadLabel radLabel14;
    private RadTextBox tbForeclosureDocumentNumber;
    private RadLabel radLabel15;
    private RadTextBox radTextBox2;
    private RadTextBox tbLastAction;
    private RadLabel radLabel16;
    private RadTextBox tbPlaintAttorney;
    private RadLabel radLabel17;
    private RadTextBox tbContactInfo;
    private RadDateTimePicker dtpSaleDate;
    private RadTextBox tbBuyerNewOwner;
    private RadLabel radLabel18;
    private RadLabel radLabel19;
    private RadLabel radLabel20;
    private RadTextBox tbMisc;
    private RadButton bAddAssignment;
    private RadPageView pvAssignment;
    private RadButton btnRemoveAssignment;
    private RadPanel radPanelHide;
    public RadSpinEditor ID;
    public RadSpinEditor PageIndex;
    private RadTextBox tbInstrument;
    private RadLabel radLabel21;
    private RadButton btnAddModification;

    public int AssignmentCount { get; set; }

    public Mortgage Mortgage_Type { get; set; }

    public Assignments Assignments { get; set; }

    public ucMortgageOrDeedType(Mortgage mortgage_Type)
    {
      this.InitializeComponent();
      this.Mortgage_Type = mortgage_Type;
      this.PageIndex.Value = (Decimal) this.Mortgage_Type.ID;
      this.ID.Value = (Decimal) this.Mortgage_Type.ID;
      this.UpdateUIToReflectModel();
      this.tbLenderName.TextChanged += new EventHandler(this.tbLenderName_TextChanged);
      this.rcbxReleaseRequirment.CheckStateChanged += new EventHandler(this.rcbxReleaseRequirment_CheckStateChanged);
      this.rtbAmount.TextChanged += new EventHandler(this.rtbAmount_TextChanged);
      this.dtpExecutedDate.ValueChanged += new EventHandler(this.dtpExecutedDate_ValueChanged);
      this.dtpFiledDate.ValueChanged += new EventHandler(this.dtpFiledDate_ValueChanged);
      this.tbBook.TextChanged += new EventHandler(this.tbBook_TextChanged);
      this.tbPage.TextChanged += new EventHandler(this.tbPage_TextChanged);
      this.tbDocument.TextChanged += new EventHandler(this.tbDocument_TextChanged);
      this.tbInstrument.TextChanged += new EventHandler(this.TbInstrument_TextChanged);
      this.tbTrustee.TextChanged += new EventHandler(this.tbTrustee_TextChanged);
      this.tbSignedBy.TextChanged += new EventHandler(this.tbSignedBy_TextChanged);
      this.tbJurisdiction.TextChanged += new EventHandler(this.tbJurisdiction_TextChanged);
      this.tbForeclosingParty.TextChanged += new EventHandler(this.tbForeclosingParty_TextChanged);
      this.tbForeclosureCaseNumber.TextChanged += new EventHandler(this.tbForeclosureCaseNumber_TextChanged);
      this.dtpCaseFiledDate.ValueChanged += new EventHandler(this.dtpCaseFiledDate_ValueChanged);
      this.tbForeclosureDocumentNumber.TextChanged += new EventHandler(this.tbForeclosureDocumentNumber_TextChanged);
      this.tbLastAction.TextChanged += new EventHandler(this.tbLastAction_TextChanged);
      this.tbPlaintAttorney.TextChanged += new EventHandler(this.tbPlaintAttorney_TextChanged);
      this.tbContactInfo.TextChanged += new EventHandler(this.tbContactInfo_TextChanged);
      this.dtpSaleDate.ValueChanged += new EventHandler(this.dtpSaleDate_ValueChanged);
      this.tbBuyerNewOwner.TextChanged += new EventHandler(this.tbBuyerNewOwner_TextChanged);
      this.tbMisc.TextChanged += new EventHandler(this.tbMisc_TextChanged);
      ((RadPageViewNavigationViewElement) this.pvAssignment.ViewElement).DisplayMode = NavigationViewDisplayModes.Expanded;
      ((RadPageViewNavigationViewElement) this.pvAssignment.ViewElement).HamburgerButton.Enabled = false;
      ((RadPageViewNavigationViewElement) this.pvAssignment.ViewElement).Expand();
    }

    private void tbLenderName_TextChanged(object sender, EventArgs e) => this.Mortgage_Type.Mortgagee = this.tbLenderName.Text;

    private void rcbxReleaseRequirment_CheckStateChanged(object sender, EventArgs e)
    {
      if (this.rcbxReleaseRequirment.Checked)
        this.Mortgage_Type.Release_Requirement = "1";
      else
        this.Mortgage_Type.Release_Requirement = "";
    }

    private void rtbAmount_TextChanged(object sender, EventArgs e)
    {
      Decimal result;
      if (Decimal.TryParse(this.rtbAmount.Text.Replace("$", ""), out result))
        this.Mortgage_Type.Mortgage_Amount = new Decimal?(result);
      else
        this.Mortgage_Type.Mortgage_Amount = new Decimal?();
    }

    private void dtpExecutedDate_ValueChanged(object sender, EventArgs e) => this.Mortgage_Type.Executed = this.dtpExecutedDate.Value > DateTime.Parse("1/1/1900") ? new DateTime?(this.dtpExecutedDate.Value) : new DateTime?();

    private void dtpFiledDate_ValueChanged(object sender, EventArgs e) => this.Mortgage_Type.Filed = this.dtpFiledDate.Value > DateTime.Parse("1/1/1900") ? new DateTime?(this.dtpFiledDate.Value) : new DateTime?();

    private void tbBook_TextChanged(object sender, EventArgs e) => this.Mortgage_Type.Book = this.tbBook.Text;

    private void tbPage_TextChanged(object sender, EventArgs e) => this.Mortgage_Type.Page = this.tbPage.Text;

    private void tbDocument_TextChanged(object sender, EventArgs e) => this.Mortgage_Type.Document = this.tbDocument.Text;

    private void TbInstrument_TextChanged(object sender, EventArgs e) => this.Mortgage_Type.Instrument = this.tbInstrument.Text;

    private void tbTrustee_TextChanged(object sender, EventArgs e) => this.Mortgage_Type.Trustee = this.tbTrustee.Text;

    private void tbSignedBy_TextChanged(object sender, EventArgs e) => this.Mortgage_Type.Signed_By = this.tbSignedBy.Text;

    private void tbJurisdiction_TextChanged(object sender, EventArgs e) => this.Mortgage_Type.Jurisdiction = this.tbJurisdiction.Text;

    private void tbForeclosingParty_TextChanged(object sender, EventArgs e) => this.Mortgage_Type.Foreclosing_Party = this.tbForeclosingParty.Text;

    private void tbForeclosureCaseNumber_TextChanged(object sender, EventArgs e) => this.Mortgage_Type.Foreclosing_Case_Number = this.tbForeclosureCaseNumber.Text;

    private void dtpCaseFiledDate_ValueChanged(object sender, EventArgs e) => this.Mortgage_Type.Case_Filed_Date = this.dtpCaseFiledDate.Value > DateTime.Parse("1/1/1900") ? new DateTime?(this.dtpCaseFiledDate.Value) : new DateTime?();

    private void tbForeclosureDocumentNumber_TextChanged(object sender, EventArgs e) => this.Mortgage_Type.Doc_Number = this.tbForeclosureDocumentNumber.Text;

    private void tbLastAction_TextChanged(object sender, EventArgs e) => this.Mortgage_Type.Last_Action = this.tbLastAction.Text;

    private void tbPlaintAttorney_TextChanged(object sender, EventArgs e) => this.Mortgage_Type.Plaintiff_Attorney = this.tbPlaintAttorney.Text;

    private void tbContactInfo_TextChanged(object sender, EventArgs e) => this.Mortgage_Type.Contact_Info = this.tbContactInfo.Text;

    private void dtpSaleDate_ValueChanged(object sender, EventArgs e) => this.Mortgage_Type.Sale_Date = this.dtpSaleDate.Value > DateTime.Parse("1/1/1900") ? new DateTime?(this.dtpSaleDate.Value) : new DateTime?();

    private void tbBuyerNewOwner_TextChanged(object sender, EventArgs e) => this.Mortgage_Type.New_Owner = this.tbBuyerNewOwner.Text;

    private void tbMisc_TextChanged(object sender, EventArgs e) => this.Mortgage_Type.Misc = this.tbMisc.Text;

    private void UpdateUIToReflectModel()
    {
      this.tbLenderName.Text = this.Mortgage_Type.Mortgagee;
      this.rtbAmount.Text = this.Mortgage_Type.Mortgage_Amount.HasValue ? this.Mortgage_Type.Mortgage_Amount.Value.ToString("C") : "";
      RadDateTimePicker dtpExecutedDate = this.dtpExecutedDate;
      DateTime? nullable = this.Mortgage_Type.Executed;
      DateTime dateTime1 = nullable ?? DateTime.Parse("1/1/1900");
      dtpExecutedDate.Value = dateTime1;
      RadDateTimePicker dtpFiledDate = this.dtpFiledDate;
      nullable = this.Mortgage_Type.Filed;
      DateTime dateTime2 = nullable ?? DateTime.Parse("1/1/1900");
      dtpFiledDate.Value = dateTime2;
      this.tbBook.Text = this.Mortgage_Type.Book;
      this.tbPage.Text = this.Mortgage_Type.Page;
      this.tbDocument.Text = this.Mortgage_Type.Document;
      this.tbInstrument.Text = this.Mortgage_Type.Instrument;
      this.tbTrustee.Text = this.Mortgage_Type.Trustee;
      this.tbSignedBy.Text = this.Mortgage_Type.Signed_By;
      this.tbJurisdiction.Text = this.Mortgage_Type.Jurisdiction;
      this.tbForeclosingParty.Text = this.Mortgage_Type.Foreclosing_Party;
      this.tbForeclosureCaseNumber.Text = this.Mortgage_Type.Foreclosing_Case_Number;
      RadDateTimePicker dtpCaseFiledDate = this.dtpCaseFiledDate;
      nullable = this.Mortgage_Type.Case_Filed_Date;
      DateTime dateTime3 = nullable ?? DateTime.Parse("1/1/1900");
      dtpCaseFiledDate.Value = dateTime3;
      this.tbForeclosureDocumentNumber.Text = this.Mortgage_Type.Doc_Number;
      this.tbLastAction.Text = this.Mortgage_Type.Last_Action;
      this.tbPlaintAttorney.Text = this.Mortgage_Type.Plaintiff_Attorney;
      this.tbContactInfo.Text = this.Mortgage_Type.Contact_Info;
      RadDateTimePicker dtpSaleDate = this.dtpSaleDate;
      nullable = this.Mortgage_Type.Sale_Date;
      DateTime dateTime4 = nullable ?? DateTime.Parse("1/1/1900");
      dtpSaleDate.Value = dateTime4;
      this.tbBuyerNewOwner.Text = this.Mortgage_Type.New_Owner;
      this.tbMisc.Text = this.Mortgage_Type.Misc;
      if (this.Mortgage_Type.Release_Requirement == "1")
        this.rcbxReleaseRequirment.Checked = true;
      if (this.Mortgage_Type.Assignments == null)
        return;
      foreach (Assignments assignment in (IEnumerable<Assignments>) this.Mortgage_Type.Assignments.OrderBy<Assignments, int?>((Func<Assignments, int?>) (c => c.ID)))
      {
        this.AssignmentCount = assignment.ID ?? this.AssignmentCount;
        this.AddAssignment(assignment);
      }
    }

    private void ucMortgageOrDeedType_Load(object sender, EventArgs e)
    {
    }

    private void bAddAssignment_Click(object sender, EventArgs e)
    {
      ++this.AssignmentCount;
      Assignments assignment = new Assignments()
      {
        ID = new int?(this.AssignmentCount),
        AssignmentType = "Assignment",
        Mortgage_Type_ID = new int?(this.Mortgage_Type.ID)
      };
      this.Mortgage_Type.Assignments.Add(assignment);
      this.AddAssignment(assignment);
    }

    private void AddAssignment(Assignments assignment)
    {
      ucMortgageOrDeedAssignment orDeedAssignment = new ucMortgageOrDeedAssignment(assignment);
      RadPageViewPage radPageViewPage = new RadPageViewPage();
      radPageViewPage.Dock = DockStyle.Fill;
      radPageViewPage.Controls.Add((Control) orDeedAssignment);
      this.pvAssignment.Pages.Add(radPageViewPage);
      this.pvAssignment.SelectedPage = radPageViewPage;
      this.ReindexAssignments();
    }

    private void btnAddModification_Click(object sender, EventArgs e)
    {
      ++this.AssignmentCount;
      Assignments assignment = new Assignments()
      {
        ID = new int?(this.AssignmentCount),
        AssignmentType = "Modification",
        Mortgage_Type_ID = new int?(this.Mortgage_Type.ID)
      };
      this.Mortgage_Type.Assignments.Add(assignment);
      this.AddAssignment(assignment);
    }

    private void btnRemoveAssignment_Click(object sender, EventArgs e)
    {
      if (this.pvAssignment.Pages.Count == 0)
        return;
      RadPageViewPage selectedPage = this.pvAssignment.SelectedPage;
      if (selectedPage.Controls[0] is ucMortgageOrDeedAssignment control)
      {
        this.Mortgage_Type.Assignments.Remove(control.Assignment);
        this.pvAssignment.Pages.Remove(selectedPage);
      }
      this.ReindexAssignments();
    }

    private void pvAssignment_PageIndexChanged(object sender, RadPageViewIndexChangedEventArgs e) => this.ReindexAssignments();

    private void ReindexAssignments()
    {
      foreach (RadPageViewPage page in this.pvAssignment.Pages)
      {
        ucMortgageOrDeedAssignment control = page.Controls[0] as ucMortgageOrDeedAssignment;
        control.PageIndex.Value = (Decimal) (this.pvAssignment.Pages.IndexOf(page) + 1);
        control.ID.Value = (Decimal) (this.pvAssignment.Pages.IndexOf(page) + 1);
        control.Assignment.ID = new int?(this.pvAssignment.Pages.IndexOf(page) + 1);
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
      this.rcbxReleaseRequirment = new RadCheckBox();
      this.radLabel1 = new RadLabel();
      this.tbLenderName = new RadTextBox();
      this.radLabel2 = new RadLabel();
      this.radLabel4 = new RadLabel();
      this.radLabel5 = new RadLabel();
      this.radLabel6 = new RadLabel();
      this.radLabel7 = new RadLabel();
      this.rtbAmount = new RadTextBox();
      this.dtpExecutedDate = new RadDateTimePicker();
      this.dtpFiledDate = new RadDateTimePicker();
      this.tbBook = new RadTextBox();
      this.tbPage = new RadTextBox();
      this.radLabel3 = new RadLabel();
      this.radLabel8 = new RadLabel();
      this.radLabel9 = new RadLabel();
      this.tbDocument = new RadTextBox();
      this.tbTrustee = new RadTextBox();
      this.tbSignedBy = new RadTextBox();
      this.radLabel10 = new RadLabel();
      this.tbJurisdiction = new RadTextBox();
      this.radLabel11 = new RadLabel();
      this.tbForeclosingParty = new RadTextBox();
      this.radLabel12 = new RadLabel();
      this.tbForeclosureCaseNumber = new RadTextBox();
      this.radLabel13 = new RadLabel();
      this.dtpCaseFiledDate = new RadDateTimePicker();
      this.radLabel14 = new RadLabel();
      this.tbForeclosureDocumentNumber = new RadTextBox();
      this.radLabel15 = new RadLabel();
      this.tbLastAction = new RadTextBox();
      this.radLabel16 = new RadLabel();
      this.radTextBox2 = new RadTextBox();
      this.tbPlaintAttorney = new RadTextBox();
      this.radLabel17 = new RadLabel();
      this.tbContactInfo = new RadTextBox();
      this.radLabel18 = new RadLabel();
      this.radLabel19 = new RadLabel();
      this.dtpSaleDate = new RadDateTimePicker();
      this.tbBuyerNewOwner = new RadTextBox();
      this.radLabel20 = new RadLabel();
      this.tbMisc = new RadTextBox();
      this.bAddAssignment = new RadButton();
      this.pvAssignment = new RadPageView();
      this.btnRemoveAssignment = new RadButton();
      this.radPanelHide = new RadPanel();
      this.ID = new RadSpinEditor();
      this.PageIndex = new RadSpinEditor();
      this.tbInstrument = new RadTextBox();
      this.radLabel21 = new RadLabel();
      this.btnAddModification = new RadButton();
      this.rcbxReleaseRequirment.BeginInit();
      this.radLabel1.BeginInit();
      this.tbLenderName.BeginInit();
      this.radLabel2.BeginInit();
      this.radLabel4.BeginInit();
      this.radLabel5.BeginInit();
      this.radLabel6.BeginInit();
      this.radLabel7.BeginInit();
      this.rtbAmount.BeginInit();
      this.dtpExecutedDate.BeginInit();
      this.dtpFiledDate.BeginInit();
      this.tbBook.BeginInit();
      this.tbPage.BeginInit();
      this.radLabel3.BeginInit();
      this.radLabel8.BeginInit();
      this.radLabel9.BeginInit();
      this.tbDocument.BeginInit();
      this.tbTrustee.BeginInit();
      this.tbSignedBy.BeginInit();
      this.radLabel10.BeginInit();
      this.tbJurisdiction.BeginInit();
      this.radLabel11.BeginInit();
      this.tbForeclosingParty.BeginInit();
      this.radLabel12.BeginInit();
      this.tbForeclosureCaseNumber.BeginInit();
      this.radLabel13.BeginInit();
      this.dtpCaseFiledDate.BeginInit();
      this.radLabel14.BeginInit();
      this.tbForeclosureDocumentNumber.BeginInit();
      this.radLabel15.BeginInit();
      this.tbLastAction.BeginInit();
      this.radLabel16.BeginInit();
      this.radLabel16.SuspendLayout();
      this.radTextBox2.BeginInit();
      this.tbPlaintAttorney.BeginInit();
      this.radLabel17.BeginInit();
      this.tbContactInfo.BeginInit();
      this.radLabel18.BeginInit();
      this.radLabel19.BeginInit();
      this.dtpSaleDate.BeginInit();
      this.tbBuyerNewOwner.BeginInit();
      this.radLabel20.BeginInit();
      this.tbMisc.BeginInit();
      this.bAddAssignment.BeginInit();
      this.pvAssignment.BeginInit();
      this.btnRemoveAssignment.BeginInit();
      this.radPanelHide.BeginInit();
      this.radPanelHide.SuspendLayout();
      this.ID.BeginInit();
      this.PageIndex.BeginInit();
      this.tbInstrument.BeginInit();
      this.radLabel21.BeginInit();
      this.btnAddModification.BeginInit();
      this.SuspendLayout();
      this.rcbxReleaseRequirment.Location = new Point(469, 188);
      this.rcbxReleaseRequirment.Name = "rcbxReleaseRequirment";
      this.rcbxReleaseRequirment.Size = new System.Drawing.Size(198, 18);
      this.rcbxReleaseRequirment.TabIndex = 0;
      this.rcbxReleaseRequirment.Text = "Add Release Requirement Sched B1";
      this.rcbxReleaseRequirment.Visible = false;
      this.radLabel1.Location = new Point(3, 9);
      this.radLabel1.Name = "radLabel1";
      this.radLabel1.Size = new System.Drawing.Size(113, 18);
      this.radLabel1.TabIndex = 1;
      this.radLabel1.Text = "Name (Lender Name)";
      this.tbLenderName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.tbLenderName.Location = new Point(122, 8);
      this.tbLenderName.Name = "tbLenderName";
      this.tbLenderName.Size = new System.Drawing.Size(663, 20);
      this.tbLenderName.TabIndex = 0;
      this.radLabel2.Location = new Point(3, 34);
      this.radLabel2.Name = "radLabel2";
      this.radLabel2.Size = new System.Drawing.Size(47, 18);
      this.radLabel2.TabIndex = 3;
      this.radLabel2.Text = "Amount";
      this.radLabel4.Location = new Point(275, 34);
      this.radLabel4.Name = "radLabel4";
      this.radLabel4.Size = new System.Drawing.Size(78, 18);
      this.radLabel4.TabIndex = 5;
      this.radLabel4.Text = "Executed Date";
      this.radLabel5.Location = new Point(511, 34);
      this.radLabel5.Name = "radLabel5";
      this.radLabel5.Size = new System.Drawing.Size(56, 18);
      this.radLabel5.TabIndex = 6;
      this.radLabel5.Text = "Filed Date";
      this.radLabel6.Location = new Point(3, 60);
      this.radLabel6.Name = "radLabel6";
      this.radLabel6.Size = new System.Drawing.Size(32, 18);
      this.radLabel6.TabIndex = 7;
      this.radLabel6.Text = "Book";
      this.radLabel7.Location = new Point(386, 60);
      this.radLabel7.Name = "radLabel7";
      this.radLabel7.Size = new System.Drawing.Size(31, 18);
      this.radLabel7.TabIndex = 8;
      this.radLabel7.Text = "Page";
      this.rtbAmount.Location = new Point(122, 34);
      this.rtbAmount.Name = "rtbAmount";
      this.rtbAmount.Size = new System.Drawing.Size(125, 20);
      this.rtbAmount.TabIndex = 1;
      this.dtpExecutedDate.Format = DateTimePickerFormat.Short;
      this.dtpExecutedDate.Location = new Point(359, 34);
      this.dtpExecutedDate.Name = "dtpExecutedDate";
      this.dtpExecutedDate.NullDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
      this.dtpExecutedDate.NullText = "not specified";
      this.dtpExecutedDate.Size = new System.Drawing.Size(125, 20);
      this.dtpExecutedDate.TabIndex = 2;
      this.dtpExecutedDate.TabStop = false;
      this.dtpExecutedDate.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
      this.dtpFiledDate.Format = DateTimePickerFormat.Short;
      this.dtpFiledDate.Location = new Point(573, 34);
      this.dtpFiledDate.Name = "dtpFiledDate";
      this.dtpFiledDate.NullDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
      this.dtpFiledDate.NullText = "not specified";
      this.dtpFiledDate.Size = new System.Drawing.Size(125, 20);
      this.dtpFiledDate.TabIndex = 3;
      this.dtpFiledDate.TabStop = false;
      this.dtpFiledDate.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
      this.tbBook.Location = new Point(122, 59);
      this.tbBook.Name = "tbBook";
      this.tbBook.Size = new System.Drawing.Size(225, 20);
      this.tbBook.TabIndex = 4;
      this.tbPage.Location = new Point(473, 59);
      this.tbPage.Name = "tbPage";
      this.tbPage.Size = new System.Drawing.Size(225, 20);
      this.tbPage.TabIndex = 5;
      this.radLabel3.Location = new Point(3, 87);
      this.radLabel3.Name = "radLabel3";
      this.radLabel3.Size = new System.Drawing.Size(92, 18);
      this.radLabel3.TabIndex = 105;
      this.radLabel3.Text = "Document/Series";
      this.radLabel8.Location = new Point(386, 112);
      this.radLabel8.Name = "radLabel8";
      this.radLabel8.Size = new System.Drawing.Size(43, 18);
      this.radLabel8.TabIndex = 106;
      this.radLabel8.Text = "Trustee";
      this.radLabel9.Location = new Point(3, 113);
      this.radLabel9.Name = "radLabel9";
      this.radLabel9.Size = new System.Drawing.Size(56, 18);
      this.radLabel9.TabIndex = 107;
      this.radLabel9.Text = "Signed By";
      this.tbDocument.Location = new Point(122, 86);
      this.tbDocument.Name = "tbDocument";
      this.tbDocument.Size = new System.Drawing.Size(225, 20);
      this.tbDocument.TabIndex = 6;
      this.tbTrustee.Location = new Point(473, 111);
      this.tbTrustee.Multiline = true;
      this.tbTrustee.Name = "tbTrustee";
      this.tbTrustee.RootElement.StretchVertically = true;
      this.tbTrustee.Size = new System.Drawing.Size(225, 50);
      this.tbTrustee.TabIndex = 9;
      this.tbSignedBy.Location = new Point(122, 112);
      this.tbSignedBy.Multiline = true;
      this.tbSignedBy.Name = "tbSignedBy";
      this.tbSignedBy.RootElement.StretchVertically = true;
      this.tbSignedBy.Size = new System.Drawing.Size(225, 50);
      this.tbSignedBy.TabIndex = 8;
      this.radLabel10.Location = new Point(3, 3);
      this.radLabel10.Name = "radLabel10";
      this.radLabel10.Size = new System.Drawing.Size(62, 18);
      this.radLabel10.TabIndex = 111;
      this.radLabel10.Text = "Jurisdiction";
      this.tbJurisdiction.Location = new Point(123, 3);
      this.tbJurisdiction.Name = "tbJurisdiction";
      this.tbJurisdiction.Size = new System.Drawing.Size(142, 20);
      this.tbJurisdiction.TabIndex = 14;
      this.radLabel11.Location = new Point(271, 3);
      this.radLabel11.Name = "radLabel11";
      this.radLabel11.Size = new System.Drawing.Size(86, 18);
      this.radLabel11.TabIndex = 113;
      this.radLabel11.Text = "Forclosing Party";
      this.tbForeclosingParty.Location = new Point(363, 3);
      this.tbForeclosingParty.Name = "tbForeclosingParty";
      this.tbForeclosingParty.Size = new System.Drawing.Size(189, 20);
      this.tbForeclosingParty.TabIndex = 15;
      this.radLabel12.Location = new Point(564, 4);
      this.radLabel12.Name = "radLabel12";
      this.radLabel12.Size = new System.Drawing.Size(97, 18);
      this.radLabel12.TabIndex = 115;
      this.radLabel12.Text = "Foreclosure Case#";
      this.tbForeclosureCaseNumber.Location = new Point(667, 3);
      this.tbForeclosureCaseNumber.Name = "tbForeclosureCaseNumber";
      this.tbForeclosureCaseNumber.Size = new System.Drawing.Size(86, 20);
      this.tbForeclosureCaseNumber.TabIndex = 16;
      this.radLabel13.Location = new Point(3, 31);
      this.radLabel13.Name = "radLabel13";
      this.radLabel13.Size = new System.Drawing.Size(83, 18);
      this.radLabel13.TabIndex = 117;
      this.radLabel13.Text = "Case Filed Date";
      this.dtpCaseFiledDate.Format = DateTimePickerFormat.Short;
      this.dtpCaseFiledDate.Location = new Point(123, 29);
      this.dtpCaseFiledDate.Name = "dtpCaseFiledDate";
      this.dtpCaseFiledDate.NullDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
      this.dtpCaseFiledDate.NullText = "not specified";
      this.dtpCaseFiledDate.Size = new System.Drawing.Size(142, 20);
      this.dtpCaseFiledDate.TabIndex = 17;
      this.dtpCaseFiledDate.TabStop = false;
      this.dtpCaseFiledDate.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
      this.radLabel14.Location = new Point(275, 31);
      this.radLabel14.Name = "radLabel14";
      this.radLabel14.Size = new System.Drawing.Size(82, 18);
      this.radLabel14.TabIndex = 119;
      this.radLabel14.Text = "Bk/Pg or Doc #";
      this.tbForeclosureDocumentNumber.Location = new Point(363, 29);
      this.tbForeclosureDocumentNumber.Name = "tbForeclosureDocumentNumber";
      this.tbForeclosureDocumentNumber.Size = new System.Drawing.Size(73, 20);
      this.tbForeclosureDocumentNumber.TabIndex = 18;
      this.radLabel15.AutoSize = false;
      this.radLabel15.Location = new Point(3, 55);
      this.radLabel15.Name = "radLabel15";
      this.radLabel15.Size = new System.Drawing.Size(89, 57);
      this.radLabel15.TabIndex = 121;
      this.radLabel15.Text = "Last Action/ Docket Entry";
      this.radLabel15.TextAlignment = ContentAlignment.TopLeft;
      this.tbLastAction.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.tbLastAction.AutoSize = false;
      this.tbLastAction.Location = new Point(119, 55);
      this.tbLastAction.Multiline = true;
      this.tbLastAction.Name = "tbLastAction";
      this.tbLastAction.Size = new System.Drawing.Size(660, 57);
      this.tbLastAction.TabIndex = 19;
      this.radLabel16.Controls.Add((Control) this.radTextBox2);
      this.radLabel16.Location = new Point(3, 119);
      this.radLabel16.Name = "radLabel16";
      this.radLabel16.Size = new System.Drawing.Size(98, 18);
      this.radLabel16.TabIndex = 123;
      this.radLabel16.Text = "Plaintiff's Attorney";
      this.radTextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.radTextBox2.AutoSize = false;
      this.radTextBox2.Location = new Point(74, 23);
      this.radTextBox2.Multiline = true;
      this.radTextBox2.Name = "radTextBox2";
      this.radTextBox2.Size = new System.Drawing.Size(604, 57);
      this.radTextBox2.TabIndex = 126;
      this.tbPlaintAttorney.Location = new Point(119, 118);
      this.tbPlaintAttorney.Name = "tbPlaintAttorney";
      this.tbPlaintAttorney.Size = new System.Drawing.Size(243, 20);
      this.tbPlaintAttorney.TabIndex = 20;
      this.radLabel17.Location = new Point(3, 145);
      this.radLabel17.Name = "radLabel17";
      this.radLabel17.Size = new System.Drawing.Size(68, 18);
      this.radLabel17.TabIndex = 125;
      this.radLabel17.Text = "Contact Info";
      this.tbContactInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.tbContactInfo.AutoSize = false;
      this.tbContactInfo.Location = new Point(119, 144);
      this.tbContactInfo.Multiline = true;
      this.tbContactInfo.Name = "tbContactInfo";
      this.tbContactInfo.Size = new System.Drawing.Size(660, 57);
      this.tbContactInfo.TabIndex = 21;
      this.radLabel18.Location = new Point(3, 208);
      this.radLabel18.Name = "radLabel18";
      this.radLabel18.Size = new System.Drawing.Size(53, 18);
      this.radLabel18.TabIndex = (int) sbyte.MaxValue;
      this.radLabel18.Text = "Sale Date";
      this.radLabel19.Location = new Point(253, 208);
      this.radLabel19.Name = "radLabel19";
      this.radLabel19.Size = new System.Drawing.Size(98, 18);
      this.radLabel19.TabIndex = 128;
      this.radLabel19.Text = "Buyer/New Owner";
      this.dtpSaleDate.Format = DateTimePickerFormat.Short;
      this.dtpSaleDate.Location = new Point(119, 207);
      this.dtpSaleDate.Name = "dtpSaleDate";
      this.dtpSaleDate.NullDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
      this.dtpSaleDate.NullText = "not specified";
      this.dtpSaleDate.Size = new System.Drawing.Size(125, 20);
      this.dtpSaleDate.TabIndex = 22;
      this.dtpSaleDate.TabStop = false;
      this.dtpSaleDate.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
      this.tbBuyerNewOwner.Location = new Point(357, 207);
      this.tbBuyerNewOwner.Name = "tbBuyerNewOwner";
      this.tbBuyerNewOwner.Size = new System.Drawing.Size(330, 20);
      this.tbBuyerNewOwner.TabIndex = 23;
      this.radLabel20.Location = new Point(3, 436);
      this.radLabel20.Name = "radLabel20";
      this.radLabel20.Size = new System.Drawing.Size(29, 18);
      this.radLabel20.TabIndex = 131;
      this.radLabel20.Text = "Misc";
      this.radLabel20.Visible = false;
      this.tbMisc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.tbMisc.AutoSize = false;
      this.tbMisc.Location = new Point(119, 435);
      this.tbMisc.Multiline = true;
      this.tbMisc.Name = "tbMisc";
      this.tbMisc.Size = new System.Drawing.Size(637, 26);
      this.tbMisc.TabIndex = 13;
      this.tbMisc.Visible = false;
      this.bAddAssignment.Location = new Point(6, 185);
      this.bAddAssignment.Name = "bAddAssignment";
      this.bAddAssignment.Size = new System.Drawing.Size(110, 24);
      this.bAddAssignment.TabIndex = 10;
      this.bAddAssignment.Text = "Add Assignment";
      this.bAddAssignment.Click += new EventHandler(this.bAddAssignment_Click);
      this.pvAssignment.AllowDrop = true;
      this.pvAssignment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.pvAssignment.Location = new Point(6, 214);
      this.pvAssignment.Name = "pvAssignment";
      this.pvAssignment.Size = new System.Drawing.Size(779, 211);
      this.pvAssignment.TabIndex = 134;
      this.pvAssignment.ViewMode = PageViewMode.NavigationView;
      this.pvAssignment.PageIndexChanged += new EventHandler<RadPageViewIndexChangedEventArgs>(this.pvAssignment_PageIndexChanged);
      ((RadPageViewNavigationViewElement) this.pvAssignment.GetChildAt(0)).ExpandedPaneWidth = 220;
      ((RadPageViewElement) this.pvAssignment.GetChildAt(0)).ItemDragMode = PageViewItemDragMode.Preview;
      this.btnRemoveAssignment.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnRemoveAssignment.Location = new Point(675, 185);
      this.btnRemoveAssignment.Name = "btnRemoveAssignment";
      this.btnRemoveAssignment.Size = new System.Drawing.Size(110, 24);
      this.btnRemoveAssignment.TabIndex = 12;
      this.btnRemoveAssignment.Text = "Remove Selected";
      this.btnRemoveAssignment.Click += new EventHandler(this.btnRemoveAssignment_Click);
      this.radPanelHide.Controls.Add((Control) this.radLabel10);
      this.radPanelHide.Controls.Add((Control) this.tbJurisdiction);
      this.radPanelHide.Controls.Add((Control) this.radLabel11);
      this.radPanelHide.Controls.Add((Control) this.tbForeclosingParty);
      this.radPanelHide.Controls.Add((Control) this.radLabel12);
      this.radPanelHide.Controls.Add((Control) this.tbForeclosureCaseNumber);
      this.radPanelHide.Controls.Add((Control) this.tbBuyerNewOwner);
      this.radPanelHide.Controls.Add((Control) this.radLabel13);
      this.radPanelHide.Controls.Add((Control) this.dtpSaleDate);
      this.radPanelHide.Controls.Add((Control) this.dtpCaseFiledDate);
      this.radPanelHide.Controls.Add((Control) this.radLabel19);
      this.radPanelHide.Controls.Add((Control) this.radLabel14);
      this.radPanelHide.Controls.Add((Control) this.radLabel18);
      this.radPanelHide.Controls.Add((Control) this.tbForeclosureDocumentNumber);
      this.radPanelHide.Controls.Add((Control) this.tbContactInfo);
      this.radPanelHide.Controls.Add((Control) this.radLabel15);
      this.radPanelHide.Controls.Add((Control) this.radLabel17);
      this.radPanelHide.Controls.Add((Control) this.tbLastAction);
      this.radPanelHide.Controls.Add((Control) this.tbPlaintAttorney);
      this.radPanelHide.Controls.Add((Control) this.radLabel16);
      this.radPanelHide.Location = new Point(6, 467);
      this.radPanelHide.Name = "radPanelHide";
      this.radPanelHide.Size = new System.Drawing.Size(782, 238);
      this.radPanelHide.TabIndex = 136;
      this.radPanelHide.Visible = false;
      this.ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.ID.Location = new Point(351, 187);
      this.ID.Name = "ID";
      this.ID.ReadOnly = true;
      this.ID.Size = new System.Drawing.Size(53, 20);
      this.ID.TabIndex = 11;
      this.ID.Visible = false;
      this.PageIndex.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.PageIndex.Location = new Point(410, 187);
      this.PageIndex.Name = "PageIndex";
      this.PageIndex.ReadOnly = true;
      this.PageIndex.Size = new System.Drawing.Size(53, 20);
      this.PageIndex.TabIndex = 12;
      this.PageIndex.Visible = false;
      this.tbInstrument.Location = new Point(473, 85);
      this.tbInstrument.Name = "tbInstrument";
      this.tbInstrument.Size = new System.Drawing.Size(225, 20);
      this.tbInstrument.TabIndex = 7;
      this.radLabel21.Location = new Point(386, 86);
      this.radLabel21.Name = "radLabel21";
      this.radLabel21.Size = new System.Drawing.Size(61, 18);
      this.radLabel21.TabIndex = 138;
      this.radLabel21.Text = "Instrument";
      this.btnAddModification.Location = new Point(122, 185);
      this.btnAddModification.Name = "btnAddModification";
      this.btnAddModification.Size = new System.Drawing.Size(110, 24);
      this.btnAddModification.TabIndex = 11;
      this.btnAddModification.Text = "Add Modification";
      this.btnAddModification.Click += new EventHandler(this.btnAddModification_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.btnAddModification);
      this.Controls.Add((Control) this.tbInstrument);
      this.Controls.Add((Control) this.radLabel21);
      this.Controls.Add((Control) this.ID);
      this.Controls.Add((Control) this.PageIndex);
      this.Controls.Add((Control) this.radPanelHide);
      this.Controls.Add((Control) this.btnRemoveAssignment);
      this.Controls.Add((Control) this.pvAssignment);
      this.Controls.Add((Control) this.bAddAssignment);
      this.Controls.Add((Control) this.tbMisc);
      this.Controls.Add((Control) this.tbSignedBy);
      this.Controls.Add((Control) this.tbTrustee);
      this.Controls.Add((Control) this.radLabel20);
      this.Controls.Add((Control) this.tbDocument);
      this.Controls.Add((Control) this.radLabel9);
      this.Controls.Add((Control) this.radLabel8);
      this.Controls.Add((Control) this.radLabel3);
      this.Controls.Add((Control) this.tbPage);
      this.Controls.Add((Control) this.tbBook);
      this.Controls.Add((Control) this.dtpFiledDate);
      this.Controls.Add((Control) this.dtpExecutedDate);
      this.Controls.Add((Control) this.rtbAmount);
      this.Controls.Add((Control) this.radLabel7);
      this.Controls.Add((Control) this.radLabel6);
      this.Controls.Add((Control) this.radLabel5);
      this.Controls.Add((Control) this.radLabel4);
      this.Controls.Add((Control) this.radLabel2);
      this.Controls.Add((Control) this.tbLenderName);
      this.Controls.Add((Control) this.radLabel1);
      this.Controls.Add((Control) this.rcbxReleaseRequirment);
      this.Name = nameof (ucMortgageOrDeedType);
      this.Size = new System.Drawing.Size(791, 719);
      this.Load += new EventHandler(this.ucMortgageOrDeedType_Load);
      this.rcbxReleaseRequirment.EndInit();
      this.radLabel1.EndInit();
      this.tbLenderName.EndInit();
      this.radLabel2.EndInit();
      this.radLabel4.EndInit();
      this.radLabel5.EndInit();
      this.radLabel6.EndInit();
      this.radLabel7.EndInit();
      this.rtbAmount.EndInit();
      this.dtpExecutedDate.EndInit();
      this.dtpFiledDate.EndInit();
      this.tbBook.EndInit();
      this.tbPage.EndInit();
      this.radLabel3.EndInit();
      this.radLabel8.EndInit();
      this.radLabel9.EndInit();
      this.tbDocument.EndInit();
      this.tbTrustee.EndInit();
      this.tbSignedBy.EndInit();
      this.radLabel10.EndInit();
      this.tbJurisdiction.EndInit();
      this.radLabel11.EndInit();
      this.tbForeclosingParty.EndInit();
      this.radLabel12.EndInit();
      this.tbForeclosureCaseNumber.EndInit();
      this.radLabel13.EndInit();
      this.dtpCaseFiledDate.EndInit();
      this.radLabel14.EndInit();
      this.tbForeclosureDocumentNumber.EndInit();
      this.radLabel15.EndInit();
      this.tbLastAction.EndInit();
      this.radLabel16.EndInit();
      this.radLabel16.ResumeLayout(false);
      this.radTextBox2.EndInit();
      this.tbPlaintAttorney.EndInit();
      this.radLabel17.EndInit();
      this.tbContactInfo.EndInit();
      this.radLabel18.EndInit();
      this.radLabel19.EndInit();
      this.dtpSaleDate.EndInit();
      this.tbBuyerNewOwner.EndInit();
      this.radLabel20.EndInit();
      this.tbMisc.EndInit();
      this.bAddAssignment.EndInit();
      this.pvAssignment.EndInit();
      this.btnRemoveAssignment.EndInit();
      this.radPanelHide.EndInit();
      this.radPanelHide.ResumeLayout(false);
      this.radPanelHide.PerformLayout();
      this.ID.EndInit();
      this.PageIndex.EndInit();
      this.tbInstrument.EndInit();
      this.radLabel21.EndInit();
      this.btnAddModification.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
