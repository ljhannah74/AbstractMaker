// Decompiled with JetBrains decompiler
// Type: Sternhagen.ucTaxSheetInfo
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
  public class ucTaxSheetInfo : UserControl
  {
    public List<string> PaymentTypes = new List<string>()
    {
      "BORO TAXES",
      "COUNTY TAXES",
      "LOCAL TAXES",
      "REAL ESTATE TAXES",
      "SCHOOL TAXES",
      "SUMMER TAXES",
      "TOWNSHIP TAXES",
      "WINTER TAXES"
    };
    public List<string> FrequencyTypes = new List<string>()
    {
      "Quarterly",
      "Semi-Annually",
      "Annually"
    };
    private IContainer components = (IContainer) null;
    private RadLabel radLabel1;
    private RadTextBox rtbTaxID;
    private RadLabel radLabel2;
    private RadLabel radLabel3;
    private RadLabel radLabel4;
    private RadLabel radLabel5;
    private RadLabel radLabel6;
    private RadLabel radLabel7;
    private RadLabel radLabel8;
    private RadLabel radLabel9;
    private RadLabel radLabel10;
    private RadLabel radLabel11;
    private RadLabel radLabel12;
    private RadLabel radLabel13;
    private RadLabel radLabel14;
    private RadTextBox rtbTaxYear;
    private RadDropDownList rddlPaymentTypes;
    private RadTextBoxControl rtbcStatus;
    private RadTextBox rtbPayee;
    private RadTextBox rtbPayeeAddress1;
    private RadTextBox rtbPayeeAddress2;
    private RadTextBox rtbPayeeCity;
    private RadTextBox rtbPayeeZip;
    private RadMaskedEditBox mebDelinquentAmount;
    public RadSpinEditor ID;
    private RadMaskedEditBox mebPayeePhone;
    private RadDropDownList rddlFrequency;
    private RadPageView pvUtility;
    private RadButton bAddUtility;
    private RadButton btnRemoveUtility;
    private RadMaskedEditBox mebBaseAmount;
    private RadDropDownList rddlPayeeState;

    public TaxSheet TaxSheetModel { get; set; }

    public TaxSheetUtilities Utilities { get; set; }

    public int UtilityCount { get; set; }
        public ucTaxSheetInfo() { InitializeComponent(); }

    public ucTaxSheetInfo(TaxSheet taxSheet)
    {
      this.InitializeComponent();
      this.TaxSheetModel = taxSheet;
      PolicyType policyType = new PolicyType();
      this.rddlPaymentTypes.DataSource =  this.PaymentTypes;
      this.rddlFrequency.DataSource =  this.FrequencyTypes;
      this.rddlPayeeState.DataSource =  policyType.GetStates();
      this.UpdateUIToReflectModel();
      this.rtbTaxID.TextChanged += new EventHandler(this.RtbTaxID_TextChanged);
      this.rtbTaxYear.TextChanged += new EventHandler(this.RtbTaxYear_TextChanged);
      this.rddlPaymentTypes.SelectedValueChanged += new EventHandler(this.RddlPaymentTypes_SelectedValueChanged);
      this.mebBaseAmount.TextChanged += new EventHandler(this.mebBaseAmount_TextChanged);
      this.mebDelinquentAmount.ValueChanged += new EventHandler(this.MebDelinquentAmount_TextChanged);
      this.rtbcStatus.TextChanged += new EventHandler(this.RtbcStatus_TextChanged);
      this.rtbPayee.TextChanged += new EventHandler(this.RtbPayee_TextChanged);
      this.mebPayeePhone.ValueChanged += new EventHandler(this.MebPayeePhone_ValueChanged);
      this.rtbPayeeAddress1.TextChanged += new EventHandler(this.RtbPayeeAddress1_TextChanged);
      this.rtbPayeeAddress2.TextChanged += new EventHandler(this.RtbPayeeAddress2_TextChanged);
      this.rtbPayeeCity.TextChanged += new EventHandler(this.RtbPayeeCity_TextChanged);
      this.rddlPayeeState.SelectedValueChanged += new EventHandler(this.rddlPayeeState_SelectedValueChanged);
      this.rtbPayeeZip.TextChanged += new EventHandler(this.RtbPayeeZip_TextChanged);
      this.ID.ValueChanged += new EventHandler(this.ID_ValueChanged);
      this.rddlFrequency.TextChanged += new EventHandler(this.rddlFrequency_SelectedValueChanged);
      ((RadPageViewNavigationViewElement) this.pvUtility.ViewElement).DisplayMode = NavigationViewDisplayModes.Expanded;
      ((RadPageViewNavigationViewElement) this.pvUtility.ViewElement).HamburgerButton.Enabled = false;
      ((RadPageViewNavigationViewElement) this.pvUtility.ViewElement).Expand();
    }

    private void ID_ValueChanged(object sender, EventArgs e) => this.TaxSheetModel.ID = (int) this.ID.Value;

    private void RtbTaxID_TextChanged(object sender, EventArgs e) => this.TaxSheetModel.TaxID = this.rtbTaxID.Text;

    private void RtbTaxYear_TextChanged(object sender, EventArgs e) => this.TaxSheetModel.TaxYear = this.rtbTaxYear.Text;

    private void RddlPaymentTypes_SelectedValueChanged(object sender, EventArgs e)
    {
      this.TaxSheetModel.PaymentType = this.rddlPaymentTypes.SelectedValue.ToString();
      this.UpdateHeading(this.TaxSheetModel.PaymentType);
    }

    private void rddlFrequency_SelectedValueChanged(object sender, EventArgs e) => this.TaxSheetModel.Frequency = this.rddlFrequency.Text;

    private void mebBaseAmount_TextChanged(object sender, EventArgs e)
    {
      Decimal result;
      if (Decimal.TryParse(this.mebBaseAmount.Text.Replace("$", ""), out result))
        this.TaxSheetModel.BaseAmount = new Decimal?(result);
      else
        this.TaxSheetModel.BaseAmount = new Decimal?();
    }

    private void MebDelinquentAmount_TextChanged(object sender, EventArgs e)
    {
      Decimal result;
      if (Decimal.TryParse(this.mebDelinquentAmount.Text.Replace("$", ""), out result))
        this.TaxSheetModel.DelinquentAmount = new Decimal?(result);
      else
        this.TaxSheetModel.DelinquentAmount = new Decimal?();
    }

    private void RtbcStatus_TextChanged(object sender, EventArgs e) => this.TaxSheetModel.Status = this.rtbcStatus.Text;

    private void RtbPayee_TextChanged(object sender, EventArgs e) => this.TaxSheetModel.Payee = this.rtbPayee.Text;

    private void MebPayeePhone_ValueChanged(object sender, EventArgs e) => this.TaxSheetModel.PayeePhone = this.mebPayeePhone.Value as string;

    private void RtbPayeeAddress1_TextChanged(object sender, EventArgs e) => this.TaxSheetModel.PayeeAddress1 = this.rtbPayeeAddress1.Text;

    private void RtbPayeeAddress2_TextChanged(object sender, EventArgs e) => this.TaxSheetModel.PayeeAddress2 = this.rtbPayeeAddress2.Text;

    private void RtbPayeeCity_TextChanged(object sender, EventArgs e) => this.TaxSheetModel.PayeeCity = this.rtbPayeeCity.Text;

    private void rddlPayeeState_SelectedValueChanged(object sender, EventArgs e) => this.TaxSheetModel.PayeeState = this.rddlPayeeState.SelectedValue.ToString();

    private void RtbPayeeZip_TextChanged(object sender, EventArgs e) => this.TaxSheetModel.PayeeZip = this.rtbPayeeZip.Text;

    private void UpdateUIToReflectModel()
    {
      this.rtbTaxID.Text = this.TaxSheetModel.TaxID;
      this.rtbTaxYear.Text = this.TaxSheetModel.TaxYear;
      if (!string.IsNullOrWhiteSpace(this.TaxSheetModel.PaymentType))
        this.rddlPaymentTypes.SelectedValue = this.TaxSheetModel.PaymentType;
      this.TaxSheetModel.PaymentType = this.rddlPaymentTypes.SelectedValue.ToString();
      if (!string.IsNullOrWhiteSpace(this.TaxSheetModel.Frequency))
        this.rddlFrequency.SelectedText = this.TaxSheetModel.Frequency;
      this.TaxSheetModel.Frequency = this.rddlFrequency.SelectedText;
      RadMaskedEditBox mebBaseAmount = this.mebBaseAmount;
      Decimal? nullable1 = this.TaxSheetModel.BaseAmount;
      Decimal? nullable2;
      if (!nullable1.HasValue)
      {
        nullable1 = new Decimal?();
        nullable2 = nullable1;
      }
      else
      {
        nullable1 = this.TaxSheetModel.BaseAmount;
        nullable2 = new Decimal?(nullable1.Value);
      }
      // ISSUE: variable of a boxed type
      Decimal? local1 = nullable2;
      mebBaseAmount.Value = local1;
      RadMaskedEditBox delinquentAmount = this.mebDelinquentAmount;
      nullable1 = this.TaxSheetModel.DelinquentAmount;
      Decimal? nullable3;
      if (!nullable1.HasValue)
      {
        nullable1 = new Decimal?();
        nullable3 = nullable1;
      }
      else
      {
        nullable1 = this.TaxSheetModel.DelinquentAmount;
        nullable3 = new Decimal?(nullable1.Value);
      }
      // ISSUE: variable of a boxed type
      Decimal? local2 = nullable3;
      delinquentAmount.Value =  local2;
      this.rtbcStatus.Text = this.TaxSheetModel.Status;
      this.rtbPayee.Text = this.TaxSheetModel.Payee;
      if (!string.IsNullOrWhiteSpace(this.TaxSheetModel.PayeePhone))
        this.mebPayeePhone.Value =  this.TaxSheetModel.PayeePhone.Replace("(", "").Replace(")", "");
      this.rtbPayeeAddress1.Text = this.TaxSheetModel.PayeeAddress1;
      this.rtbPayeeAddress2.Text = this.TaxSheetModel.PayeeAddress2;
      this.rtbPayeeCity.Text = this.TaxSheetModel.PayeeCity;
      if (!string.IsNullOrWhiteSpace(this.TaxSheetModel.PayeeState))
        this.rddlPayeeState.SelectedValue =  this.TaxSheetModel.PayeeState;
      this.TaxSheetModel.PayeeState = this.rddlPayeeState.SelectedValue.ToString();
      this.rtbPayeeZip.Text = this.TaxSheetModel.PayeeZip;
      this.ID.Value = (Decimal) this.TaxSheetModel.ID;
      if (this.TaxSheetModel.TaxSheetUtilities == null)
        return;
      foreach (TaxSheetUtilities utilities in (IEnumerable<TaxSheetUtilities>) this.TaxSheetModel.TaxSheetUtilities.OrderBy<TaxSheetUtilities, int>((Func<TaxSheetUtilities, int>) (c => c.ID)))
      {
        this.UtilityCount = utilities.ID;
        this.AddUtilities(utilities);
      }
    }

    private void bAddUtility_Click_1(object sender, EventArgs e)
    {
      ++this.UtilityCount;
      TaxSheetUtilities utilities = new TaxSheetUtilities()
      {
        ID = this.UtilityCount,
        UtilityAmount = new Decimal?(),
        UtilityFrequency = "",
        UtilityType = ""
      };
      this.TaxSheetModel.TaxSheetUtilities.Add(utilities);
      this.AddUtilities(utilities);
    }

    private void AddUtilities(TaxSheetUtilities utilities)
    {
      ucTaxSheetUtilities taxSheetUtilities = new ucTaxSheetUtilities(utilities);
      RadPageViewPage radPageViewPage = new RadPageViewPage("Utility " + utilities.ID.ToString());
      radPageViewPage.Dock = DockStyle.Fill;
      radPageViewPage.Controls.Add((Control) taxSheetUtilities);
      this.pvUtility.Pages.Add(radPageViewPage);
      this.pvUtility.SelectedPage = radPageViewPage;
      this.ReindexUtilties();
    }

    private void btnRemoveUtility_Click_1(object sender, EventArgs e)
    {
      if (this.pvUtility.Pages.Count == 0)
        return;
      RadPageViewPage selectedPage = this.pvUtility.SelectedPage;
      if (selectedPage.Controls[0] is ucTaxSheetUtilities control)
      {
        this.TaxSheetModel.TaxSheetUtilities.Remove(control.UtilitiestModel);
        this.pvUtility.Pages.Remove(selectedPage);
      }
      this.ReindexUtilties();
    }

    private void pvAssignment_PageIndexChanged(object sender, RadPageViewIndexChangedEventArgs e) => this.ReindexUtilties();

    private void ucTaxSheetInfo_ParentChanged(object sender, EventArgs e)
    {
      if (this.rddlPaymentTypes.SelectedItem == null)
        return;
      this.UpdateHeading(this.rddlPaymentTypes.SelectedItem.DataBoundItem as string);
    }

    private void ReindexUtilties()
    {
      foreach (RadPageViewPage page in this.pvUtility.Pages)
      {
        ucTaxSheetUtilities control = page.Controls[0] as ucTaxSheetUtilities;
        control.PageIndex.Value = (Decimal) (this.pvUtility.Pages.IndexOf(page) + 1);
        control.ID.Value = (Decimal) (this.pvUtility.Pages.IndexOf(page) + 1);
        control.UtilitiestModel.ID = this.pvUtility.Pages.IndexOf(page) + 1;
      }
    }

    private void UpdateHeading(string heading)
    {
      if (!(this.Parent is RadPageViewPage parent1))
        return;
      parent1.Text = heading;
      parent1.Refresh();
      if (parent1.Parent is RadPageView parent2)
        (parent2.ViewElement as RadPageViewNavigationViewElement).HeaderElement.Text = heading;
      this.Refresh();
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
      this.rtbTaxID = new RadTextBox();
      this.radLabel2 = new RadLabel();
      this.radLabel3 = new RadLabel();
      this.radLabel4 = new RadLabel();
      this.radLabel5 = new RadLabel();
      this.radLabel6 = new RadLabel();
      this.radLabel7 = new RadLabel();
      this.radLabel8 = new RadLabel();
      this.radLabel9 = new RadLabel();
      this.radLabel10 = new RadLabel();
      this.radLabel11 = new RadLabel();
      this.radLabel12 = new RadLabel();
      this.radLabel13 = new RadLabel();
      this.radLabel14 = new RadLabel();
      this.rtbTaxYear = new RadTextBox();
      this.rddlPaymentTypes = new RadDropDownList();
      this.rtbcStatus = new RadTextBoxControl();
      this.rtbPayee = new RadTextBox();
      this.rtbPayeeAddress1 = new RadTextBox();
      this.rtbPayeeAddress2 = new RadTextBox();
      this.rtbPayeeCity = new RadTextBox();
      this.rtbPayeeZip = new RadTextBox();
      this.mebDelinquentAmount = new RadMaskedEditBox();
      this.ID = new RadSpinEditor();
      this.mebPayeePhone = new RadMaskedEditBox();
      this.rddlFrequency = new RadDropDownList();
      this.pvUtility = new RadPageView();
      this.bAddUtility = new RadButton();
      this.btnRemoveUtility = new RadButton();
      this.mebBaseAmount = new RadMaskedEditBox();
      this.rddlPayeeState = new RadDropDownList();
      this.radLabel1.BeginInit();
      this.rtbTaxID.BeginInit();
      this.radLabel2.BeginInit();
      this.radLabel3.BeginInit();
      this.radLabel4.BeginInit();
      this.radLabel5.BeginInit();
      this.radLabel6.BeginInit();
      this.radLabel7.BeginInit();
      this.radLabel8.BeginInit();
      this.radLabel9.BeginInit();
      this.radLabel10.BeginInit();
      this.radLabel11.BeginInit();
      this.radLabel12.BeginInit();
      this.radLabel13.BeginInit();
      this.radLabel14.BeginInit();
      this.rtbTaxYear.BeginInit();
      this.rddlPaymentTypes.BeginInit();
      this.rtbcStatus.BeginInit();
      this.rtbPayee.BeginInit();
      this.rtbPayeeAddress1.BeginInit();
      this.rtbPayeeAddress2.BeginInit();
      this.rtbPayeeCity.BeginInit();
      this.rtbPayeeZip.BeginInit();
      this.mebDelinquentAmount.BeginInit();
      this.ID.BeginInit();
      this.mebPayeePhone.BeginInit();
      this.rddlFrequency.BeginInit();
      this.pvUtility.BeginInit();
      this.bAddUtility.BeginInit();
      this.btnRemoveUtility.BeginInit();
      this.mebBaseAmount.BeginInit();
      this.rddlPayeeState.BeginInit();
      this.SuspendLayout();
      this.radLabel1.Location = new Point(34, 18);
      this.radLabel1.Name = "radLabel1";
      this.radLabel1.Size = new System.Drawing.Size(43, 18);
      this.radLabel1.TabIndex = 0;
      this.radLabel1.Text = "Tax ID: ";
      this.rtbTaxID.Location = new Point(84, 17);
      this.rtbTaxID.Name = "rtbTaxID";
      this.rtbTaxID.Size = new System.Drawing.Size(353, 20);
      this.rtbTaxID.TabIndex = 0;
      this.radLabel2.Location = new Point(450, 16);
      this.radLabel2.Name = "radLabel2";
      this.radLabel2.Size = new System.Drawing.Size(54, 18);
      this.radLabel2.TabIndex = 2;
      this.radLabel2.Text = "Tax Year: ";
      this.radLabel3.Location = new Point(36, 54);
      this.radLabel3.Name = "radLabel3";
      this.radLabel3.Size = new System.Drawing.Size(79, 18);
      this.radLabel3.TabIndex = 3;
      this.radLabel3.Text = "Payment Type:";
      this.radLabel4.Location = new Point(281, 54);
      this.radLabel4.Name = "radLabel4";
      this.radLabel4.Size = new System.Drawing.Size(60, 18);
      this.radLabel4.TabIndex = 4;
      this.radLabel4.Text = "Frequency:";
      this.radLabel5.Location = new Point(36, 92);
      this.radLabel5.Name = "radLabel5";
      this.radLabel5.Size = new System.Drawing.Size(75, 18);
      this.radLabel5.TabIndex = 5;
      this.radLabel5.Text = "Base Amount:";
      this.radLabel6.Location = new Point(282, 91);
      this.radLabel6.Name = "radLabel6";
      this.radLabel6.Size = new System.Drawing.Size(107, 18);
      this.radLabel6.TabIndex = 6;
      this.radLabel6.Text = "Delinquent Amount:";
      this.radLabel7.Location = new Point(36, 116);
      this.radLabel7.Name = "radLabel7";
      this.radLabel7.Size = new System.Drawing.Size(39, 18);
      this.radLabel7.TabIndex = 7;
      this.radLabel7.Text = "Status:";
      this.radLabel8.Location = new Point(40, 216);
      this.radLabel8.Name = "radLabel8";
      this.radLabel8.Size = new System.Drawing.Size(38, 18);
      this.radLabel8.TabIndex = 8;
      this.radLabel8.Text = "Payee:";
      this.radLabel9.Location = new Point(229, 216);
      this.radLabel9.Name = "radLabel9";
      this.radLabel9.Size = new System.Drawing.Size(73, 18);
      this.radLabel9.TabIndex = 9;
      this.radLabel9.Text = "Payee Phone:";
      this.radLabel10.Location = new Point(40, 243);
      this.radLabel10.Name = "radLabel10";
      this.radLabel10.Size = new System.Drawing.Size(91, 18);
      this.radLabel10.TabIndex = 10;
      this.radLabel10.Text = "Payee Address 1:";
      this.radLabel11.Location = new Point(40, 267);
      this.radLabel11.Name = "radLabel11";
      this.radLabel11.Size = new System.Drawing.Size(91, 18);
      this.radLabel11.TabIndex = 11;
      this.radLabel11.Text = "Payee Address 2:";
      this.radLabel12.Location = new Point(40, 292);
      this.radLabel12.Name = "radLabel12";
      this.radLabel12.Size = new System.Drawing.Size(60, 18);
      this.radLabel12.TabIndex = 12;
      this.radLabel12.Text = "Payee City:";
      this.radLabel13.Location = new Point(281, 292);
      this.radLabel13.Name = "radLabel13";
      this.radLabel13.Size = new System.Drawing.Size(34, 18);
      this.radLabel13.TabIndex = 13;
      this.radLabel13.Text = "State:";
      this.radLabel14.Location = new Point(347, 292);
      this.radLabel14.Name = "radLabel14";
      this.radLabel14.Size = new System.Drawing.Size(24, 18);
      this.radLabel14.TabIndex = 14;
      this.radLabel14.Text = "Zip:";
      this.rtbTaxYear.Location = new Point(510, 16);
      this.rtbTaxYear.Name = "rtbTaxYear";
      this.rtbTaxYear.Size = new System.Drawing.Size(110, 20);
      this.rtbTaxYear.TabIndex = 6;
      this.rddlPaymentTypes.Location = new Point(122, 53);
      this.rddlPaymentTypes.Name = "rddlPaymentTypes";
      this.rddlPaymentTypes.Size = new System.Drawing.Size(128, 20);
      this.rddlPaymentTypes.TabIndex = 7;
      this.rtbcStatus.AcceptsReturn = true;
      this.rtbcStatus.AllowDrop = true;
      this.rtbcStatus.Location = new Point(36, 137);
      this.rtbcStatus.Multiline = true;
      this.rtbcStatus.Name = "rtbcStatus";
      this.rtbcStatus.Size = new System.Drawing.Size(403, 48);
      this.rtbcStatus.TabIndex = 11;
      this.rtbPayee.Location = new Point(84, 216);
      this.rtbPayee.Name = "rtbPayee";
      this.rtbPayee.Size = new System.Drawing.Size(123, 20);
      this.rtbPayee.TabIndex = 12;
      this.rtbPayeeAddress1.Location = new Point(137, 241);
      this.rtbPayeeAddress1.Name = "rtbPayeeAddress1";
      this.rtbPayeeAddress1.Size = new System.Drawing.Size(306, 20);
      this.rtbPayeeAddress1.TabIndex = 14;
      this.rtbPayeeAddress2.Location = new Point(137, 266);
      this.rtbPayeeAddress2.Name = "rtbPayeeAddress2";
      this.rtbPayeeAddress2.Size = new System.Drawing.Size(306, 20);
      this.rtbPayeeAddress2.TabIndex = 15;
      this.rtbPayeeCity.Location = new Point(40, 315);
      this.rtbPayeeCity.Name = "rtbPayeeCity";
      this.rtbPayeeCity.Size = new System.Drawing.Size(236, 20);
      this.rtbPayeeCity.TabIndex = 16;
      this.rtbPayeeZip.Location = new Point(347, 315);
      this.rtbPayeeZip.Name = "rtbPayeeZip";
      this.rtbPayeeZip.Size = new System.Drawing.Size(89, 20);
      this.rtbPayeeZip.TabIndex = 18;
      this.mebDelinquentAmount.EnableNullValueInput = true;
      this.mebDelinquentAmount.Location = new Point(395, 90);
      this.mebDelinquentAmount.Mask = "C";
      this.mebDelinquentAmount.MaskType = MaskType.Numeric;
      this.mebDelinquentAmount.Name = "mebDelinquentAmount";
      this.mebDelinquentAmount.Size = new System.Drawing.Size(87, 20);
      this.mebDelinquentAmount.TabIndex = 10;
      this.mebDelinquentAmount.TabStop = false;
      this.mebDelinquentAmount.Text = "$0.00";
      this.ID.Location = new Point(464, 315);
      this.ID.Name = "ID";
      this.ID.ReadOnly = true;
      this.ID.Size = new System.Drawing.Size(53, 20);
      this.ID.TabIndex = 19;
      this.ID.Visible = false;
      this.mebPayeePhone.EnableNullValueInput = true;
      this.mebPayeePhone.Location = new Point(308, 216);
      this.mebPayeePhone.Mask = "###-###-####";
      this.mebPayeePhone.MaskType = MaskType.Standard;
      this.mebPayeePhone.Name = "mebPayeePhone";
      this.mebPayeePhone.PromptChar = '#';
      this.mebPayeePhone.Size = new System.Drawing.Size(135, 20);
      this.mebPayeePhone.TabIndex = 13;
      this.mebPayeePhone.TabStop = false;
      this.mebPayeePhone.Text = "###-###-####";
      this.rddlFrequency.AutoCompleteMode = AutoCompleteMode.Append;
      this.rddlFrequency.Location = new Point(347, 54);
      this.rddlFrequency.Name = "rddlFrequency";
      this.rddlFrequency.Size = new System.Drawing.Size(125, 20);
      this.rddlFrequency.TabIndex = 8;
      this.pvUtility.AllowDrop = true;
      this.pvUtility.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.pvUtility.Location = new Point(36, 394);
      this.pvUtility.Name = "pvUtility";
      this.pvUtility.Size = new System.Drawing.Size(584, 259);
      this.pvUtility.TabIndex = 135;
      this.pvUtility.ViewMode = PageViewMode.NavigationView;
      ((RadPageViewNavigationViewElement) this.pvUtility.GetChildAt(0)).ExpandedPaneWidth = 100;
      ((RadPageViewNavigationViewElement) this.pvUtility.GetChildAt(0)).ExpandedModeThresholdWidth = 100;
      ((RadPageViewElement) this.pvUtility.GetChildAt(0)).ItemDragMode = PageViewItemDragMode.Preview;
      this.pvUtility.GetChildAt(0).AutoSize = true;
      this.pvUtility.GetChildAt(0).GetChildAt(3).GetChildAt(2).MaxSize = new System.Drawing.Size(0, 0);
      this.bAddUtility.Location = new Point(36, 364);
      this.bAddUtility.Name = "bAddUtility";
      this.bAddUtility.Size = new System.Drawing.Size(110, 23);
      this.bAddUtility.TabIndex = 136;
      this.bAddUtility.Text = "Add Utility";
      this.bAddUtility.Click += new EventHandler(this.bAddUtility_Click_1);
      this.btnRemoveUtility.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnRemoveUtility.Location = new Point(464, 365);
      this.btnRemoveUtility.Name = "btnRemoveUtility";
      this.btnRemoveUtility.Size = new System.Drawing.Size(150, 23);
      this.btnRemoveUtility.TabIndex = 137;
      this.btnRemoveUtility.Text = "Remove Selected";
      this.btnRemoveUtility.Click += new EventHandler(this.btnRemoveUtility_Click_1);
      this.mebBaseAmount.EnableNullValueInput = true;
      this.mebBaseAmount.Location = new Point(117, 92);
      this.mebBaseAmount.Mask = "C";
      this.mebBaseAmount.MaskType = MaskType.Numeric;
      this.mebBaseAmount.Name = "mebBaseAmount";
      this.mebBaseAmount.Size = new System.Drawing.Size(102, 20);
      this.mebBaseAmount.TabIndex = 9;
      this.mebBaseAmount.TabStop = false;
      this.mebBaseAmount.Text = "$0.00";
      this.rddlPayeeState.Location = new Point(282, 315);
      this.rddlPayeeState.Name = "rddlPayeeState";
      this.rddlPayeeState.Size = new System.Drawing.Size(57, 20);
      this.rddlPayeeState.TabIndex = 17;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.rddlPayeeState);
      this.Controls.Add((Control) this.mebBaseAmount);
      this.Controls.Add((Control) this.btnRemoveUtility);
      this.Controls.Add((Control) this.bAddUtility);
      this.Controls.Add((Control) this.pvUtility);
      this.Controls.Add((Control) this.rddlFrequency);
      this.Controls.Add((Control) this.mebPayeePhone);
      this.Controls.Add((Control) this.ID);
      this.Controls.Add((Control) this.mebDelinquentAmount);
      this.Controls.Add((Control) this.rtbPayeeZip);
      this.Controls.Add((Control) this.rtbPayeeCity);
      this.Controls.Add((Control) this.rtbPayeeAddress2);
      this.Controls.Add((Control) this.rtbPayeeAddress1);
      this.Controls.Add((Control) this.rtbPayee);
      this.Controls.Add((Control) this.rtbcStatus);
      this.Controls.Add((Control) this.rddlPaymentTypes);
      this.Controls.Add((Control) this.rtbTaxYear);
      this.Controls.Add((Control) this.radLabel14);
      this.Controls.Add((Control) this.radLabel13);
      this.Controls.Add((Control) this.radLabel12);
      this.Controls.Add((Control) this.radLabel11);
      this.Controls.Add((Control) this.radLabel10);
      this.Controls.Add((Control) this.radLabel9);
      this.Controls.Add((Control) this.radLabel8);
      this.Controls.Add((Control) this.radLabel7);
      this.Controls.Add((Control) this.radLabel6);
      this.Controls.Add((Control) this.radLabel5);
      this.Controls.Add((Control) this.radLabel4);
      this.Controls.Add((Control) this.radLabel3);
      this.Controls.Add((Control) this.radLabel2);
      this.Controls.Add((Control) this.rtbTaxID);
      this.Controls.Add((Control) this.radLabel1);
      this.Name = nameof (ucTaxSheetInfo);
      this.Size = new System.Drawing.Size(636, 666);
      this.ParentChanged += new EventHandler(this.ucTaxSheetInfo_ParentChanged);
      this.radLabel1.EndInit();
      this.rtbTaxID.EndInit();
      this.radLabel2.EndInit();
      this.radLabel3.EndInit();
      this.radLabel4.EndInit();
      this.radLabel5.EndInit();
      this.radLabel6.EndInit();
      this.radLabel7.EndInit();
      this.radLabel8.EndInit();
      this.radLabel9.EndInit();
      this.radLabel10.EndInit();
      this.radLabel11.EndInit();
      this.radLabel12.EndInit();
      this.radLabel13.EndInit();
      this.radLabel14.EndInit();
      this.rtbTaxYear.EndInit();
      this.rddlPaymentTypes.EndInit();
      this.rtbcStatus.EndInit();
      this.rtbPayee.EndInit();
      this.rtbPayeeAddress1.EndInit();
      this.rtbPayeeAddress2.EndInit();
      this.rtbPayeeCity.EndInit();
      this.rtbPayeeZip.EndInit();
      this.mebDelinquentAmount.EndInit();
      this.ID.EndInit();
      this.mebPayeePhone.EndInit();
      this.rddlFrequency.EndInit();
      this.pvUtility.EndInit();
      this.bAddUtility.EndInit();
      this.btnRemoveUtility.EndInit();
      this.mebBaseAmount.EndInit();
      this.rddlPayeeState.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
