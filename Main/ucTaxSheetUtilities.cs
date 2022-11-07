// Decompiled with JetBrains decompiler
// Type: Sternhagen.ucTaxSheetUtilities
// Assembly: Sternhagen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 926CB3A7-5318-4FD7-8127-F742EC5C62A1
// Assembly location: C:\Users\lhann\OneDrive\Documents\Software\Sternhagen\Sternhagen.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using AbstractMaker.Model;

namespace AbstractMaker.Main
{
  public class ucTaxSheetUtilities : UserControl
  {
    public List<string> FrequencyTypes = new List<string>()
    {
      "Quarterly",
      "Semi-Annually",
      "Annually"
    };
    private IContainer components = (IContainer) null;
    private RadTextBox rtbUtilityType;
    private RadLabel radLabel1;
    private RadMaskedEditBox mebUtilityAmount;
    private RadLabel radLabel6;
    private RadDropDownList rddlUtilityFrequency;
    private RadLabel radLabel4;
    public RadSpinEditor ID;
    public RadSpinEditor PageIndex;
    private RadLabel radLabel8;
    private RadTextBox rtbUtilityPayee;
    private RadMaskedEditBox mebUtilityPayeePhone;
    private RadLabel radLabel9;
    private RadTextBox rtbUtilityPayeeAddress1;
    private RadLabel radLabel10;
    private RadTextBox rtbUtilityPayeeAddress2;
    private RadLabel radLabel11;
    private RadTextBox rtbUtilityPayeeZip;
    private RadTextBox rtbUtilityPayeeCity;
    private RadLabel radLabel14;
    private RadLabel radLabel13;
    private RadLabel radLabel12;
    private RadDropDownList rddlUtilityPayeeState;

    public TaxSheetUtilities UtilitiestModel { get; set; }

    public ucTaxSheetUtilities(TaxSheetUtilities utilities)
    {
      this.InitializeComponent();
      PolicyType policyType = new PolicyType();
      this.UtilitiestModel = utilities;
      this.rddlUtilityFrequency.DataSource = (object) this.FrequencyTypes;
      this.rddlUtilityPayeeState.DataSource = (object) policyType.GetStates();
      this.UpdateUIToReflectModel();
      this.rddlUtilityFrequency.TextChanged += new EventHandler(this.rddlrddlUtilityFrequency_TextChanged);
      this.rddlUtilityFrequency.SelectedValueChanged += new EventHandler(this.rddlUtilityFrequency_SelectedValueChanged);
      this.mebUtilityAmount.TextChanged += new EventHandler(this.mebUtilityAmount_TextChanged);
      this.rtbUtilityType.TextChanged += new EventHandler(this.rtbUtilityType_TextChanged);
      this.rtbUtilityPayee.TextChanged += new EventHandler(this.rtbUtilityPayee_TextChanged);
      this.mebUtilityPayeePhone.TextChanged += new EventHandler(this.mebUtilityPayeePhone_TextChanged);
      this.rtbUtilityPayeeAddress1.TextChanged += new EventHandler(this.rtbUtilityPayeeAddress1_TextChanged);
      this.rtbUtilityPayeeAddress2.TextChanged += new EventHandler(this.rtbUtilityPayeeAddress2_TextChanged);
      this.rtbUtilityPayeeCity.TextChanged += new EventHandler(this.rtbUtilityPayeeCity_TextChanged);
      this.rddlUtilityPayeeState.SelectedValueChanged += new EventHandler(this.rddlState_SelectedValueChanged);
      this.rtbUtilityPayeeZip.TextChanged += new EventHandler(this.rtbUtilityPayeeZip_TextChanged);
    }

    private void rddlrddlUtilityFrequency_TextChanged(object sender, EventArgs e) => this.UtilitiestModel.UtilityFrequency = this.rddlUtilityFrequency.Text;

    private void rddlUtilityFrequency_SelectedValueChanged(object sender, EventArgs e) => this.UtilitiestModel.UtilityFrequency = this.rddlUtilityFrequency.SelectedValue.ToString();

    private void mebUtilityAmount_TextChanged(object sender, EventArgs e)
    {
      Decimal result;
      if (Decimal.TryParse(this.mebUtilityAmount.Text.Replace("$", ""), out result))
        this.UtilitiestModel.UtilityAmount = new Decimal?(result);
      else
        this.UtilitiestModel.UtilityAmount = new Decimal?();
    }

    private void rtbUtilityType_TextChanged(object sender, EventArgs e) => this.UtilitiestModel.UtilityType = this.rtbUtilityType.Text;

    private void rtbUtilityPayee_TextChanged(object sender, EventArgs e) => this.UtilitiestModel.Payee = this.rtbUtilityPayee.Text;

    private void mebUtilityPayeePhone_TextChanged(object sender, EventArgs e) => this.UtilitiestModel.PayeePhone = this.mebUtilityPayeePhone.Text;

    private void rtbUtilityPayeeAddress1_TextChanged(object sender, EventArgs e) => this.UtilitiestModel.PayeeAddress1 = this.rtbUtilityPayeeAddress1.Text;

    private void rtbUtilityPayeeAddress2_TextChanged(object sender, EventArgs e) => this.UtilitiestModel.PayeeAddress2 = this.rtbUtilityPayeeAddress2.Text;

    private void rtbUtilityPayeeCity_TextChanged(object sender, EventArgs e) => this.UtilitiestModel.PayeeCity = this.rtbUtilityPayeeCity.Text;

    private void rddlState_SelectedValueChanged(object sender, EventArgs e) => this.UtilitiestModel.PayeeState = this.rddlUtilityPayeeState.SelectedValue.ToString();

    private void rtbUtilityPayeeZip_TextChanged(object sender, EventArgs e) => this.UtilitiestModel.PayeeZip = this.rtbUtilityPayeeZip.Text;

    private void UpdateUIToReflectModel()
    {
      this.rtbUtilityType.Text = this.UtilitiestModel.UtilityType;
      this.mebUtilityAmount.Text = this.UtilitiestModel.UtilityAmount.HasValue ? this.UtilitiestModel.UtilityAmount.Value.ToString("C") : "";
      if (!string.IsNullOrWhiteSpace(this.UtilitiestModel.UtilityFrequency))
        this.rddlUtilityFrequency.SelectedText = this.UtilitiestModel.UtilityFrequency;
      this.rtbUtilityPayee.Text = this.UtilitiestModel.Payee;
      this.mebUtilityPayeePhone.Text = this.UtilitiestModel.PayeePhone;
      this.rtbUtilityPayeeAddress1.Text = this.UtilitiestModel.PayeeAddress1;
      this.rtbUtilityPayeeAddress2.Text = this.UtilitiestModel.PayeeAddress2;
      this.rtbUtilityPayeeCity.Text = this.UtilitiestModel.PayeeCity;
      if (!string.IsNullOrWhiteSpace(this.UtilitiestModel.PayeeState))
        this.rddlUtilityPayeeState.SelectedValue = (object) this.UtilitiestModel.PayeeState;
      this.UtilitiestModel.PayeeState = this.rddlUtilityPayeeState.SelectedValue.ToString();
      this.rtbUtilityPayeeZip.Text = this.UtilitiestModel.PayeeZip;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.rtbUtilityType = new RadTextBox();
      this.radLabel1 = new RadLabel();
      this.mebUtilityAmount = new RadMaskedEditBox();
      this.radLabel6 = new RadLabel();
      this.rddlUtilityFrequency = new RadDropDownList();
      this.radLabel4 = new RadLabel();
      this.ID = new RadSpinEditor();
      this.PageIndex = new RadSpinEditor();
      this.radLabel8 = new RadLabel();
      this.rtbUtilityPayee = new RadTextBox();
      this.mebUtilityPayeePhone = new RadMaskedEditBox();
      this.radLabel9 = new RadLabel();
      this.rtbUtilityPayeeAddress1 = new RadTextBox();
      this.radLabel10 = new RadLabel();
      this.rtbUtilityPayeeAddress2 = new RadTextBox();
      this.radLabel11 = new RadLabel();
      this.rtbUtilityPayeeZip = new RadTextBox();
      this.rtbUtilityPayeeCity = new RadTextBox();
      this.radLabel14 = new RadLabel();
      this.radLabel13 = new RadLabel();
      this.radLabel12 = new RadLabel();
      this.rddlUtilityPayeeState = new RadDropDownList();
      this.rtbUtilityType.BeginInit();
      this.radLabel1.BeginInit();
      this.mebUtilityAmount.BeginInit();
      this.radLabel6.BeginInit();
      this.rddlUtilityFrequency.BeginInit();
      this.radLabel4.BeginInit();
      this.ID.BeginInit();
      this.PageIndex.BeginInit();
      this.radLabel8.BeginInit();
      this.rtbUtilityPayee.BeginInit();
      this.mebUtilityPayeePhone.BeginInit();
      this.radLabel9.BeginInit();
      this.rtbUtilityPayeeAddress1.BeginInit();
      this.radLabel10.BeginInit();
      this.rtbUtilityPayeeAddress2.BeginInit();
      this.radLabel11.BeginInit();
      this.rtbUtilityPayeeZip.BeginInit();
      this.rtbUtilityPayeeCity.BeginInit();
      this.radLabel14.BeginInit();
      this.radLabel13.BeginInit();
      this.radLabel12.BeginInit();
      this.rddlUtilityPayeeState.BeginInit();
      this.SuspendLayout();
      this.rtbUtilityType.Location = new Point(80, 16);
      this.rtbUtilityType.Name = "rtbUtilityType";
      this.rtbUtilityType.Size = new System.Drawing.Size(138, 20);
      this.rtbUtilityType.TabIndex = 19;
      this.radLabel1.Location = new Point(6, 17);
      this.radLabel1.Name = "radLabel1";
      this.radLabel1.Size = new System.Drawing.Size(68, 18);
      this.radLabel1.TabIndex = 6;
      this.radLabel1.Text = "Utility Type: ";
      this.mebUtilityAmount.EnableNullValueInput = true;
      this.mebUtilityAmount.Location = new Point(329, 15);
      this.mebUtilityAmount.Mask = "C";
      this.mebUtilityAmount.MaskType = MaskType.Numeric;
      this.mebUtilityAmount.Name = "mebUtilityAmount";
      this.mebUtilityAmount.Size = new System.Drawing.Size(70, 20);
      this.mebUtilityAmount.TabIndex = 20;
      this.mebUtilityAmount.TabStop = false;
      this.mebUtilityAmount.Text = "$0.00";
      this.radLabel6.Location = new Point(242, 16);
      this.radLabel6.Name = "radLabel6";
      this.radLabel6.Size = new System.Drawing.Size(81, 18);
      this.radLabel6.TabIndex = 11;
      this.radLabel6.Text = "Utility Amount:";
      this.rddlUtilityFrequency.AutoCompleteMode = AutoCompleteMode.Append;
      this.rddlUtilityFrequency.Location = new Point(80, 42);
      this.rddlUtilityFrequency.Name = "rddlUtilityFrequency";
      this.rddlUtilityFrequency.Size = new System.Drawing.Size(138, 20);
      this.rddlUtilityFrequency.TabIndex = 21;
      this.radLabel4.Location = new Point(14, 42);
      this.radLabel4.Name = "radLabel4";
      this.radLabel4.Size = new System.Drawing.Size(60, 18);
      this.radLabel4.TabIndex = 21;
      this.radLabel4.Text = "Frequency:";
      this.ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.ID.Location = new Point(36, 218);
      this.ID.Name = "ID";
      this.ID.ReadOnly = true;
      this.ID.Size = new System.Drawing.Size(53, 20);
      this.ID.TabIndex = 23;
      this.ID.Visible = false;
      this.PageIndex.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.PageIndex.Location = new Point(95, 218);
      this.PageIndex.Name = "PageIndex";
      this.PageIndex.ReadOnly = true;
      this.PageIndex.Size = new System.Drawing.Size(53, 20);
      this.PageIndex.TabIndex = 24;
      this.PageIndex.Visible = false;
      this.radLabel8.Location = new Point(12, 80);
      this.radLabel8.Name = "radLabel8";
      this.radLabel8.Size = new System.Drawing.Size(38, 18);
      this.radLabel8.TabIndex = 9;
      this.radLabel8.Text = "Payee:";
      this.rtbUtilityPayee.Location = new Point(56, 78);
      this.rtbUtilityPayee.Name = "rtbUtilityPayee";
      this.rtbUtilityPayee.Size = new System.Drawing.Size(123, 20);
      this.rtbUtilityPayee.TabIndex = 22;
      this.mebUtilityPayeePhone.EnableNullValueInput = true;
      this.mebUtilityPayeePhone.Location = new Point(280, 78);
      this.mebUtilityPayeePhone.Mask = "###-###-####";
      this.mebUtilityPayeePhone.MaskType = MaskType.Standard;
      this.mebUtilityPayeePhone.Name = "mebUtilityPayeePhone";
      this.mebUtilityPayeePhone.PromptChar = '#';
      this.mebUtilityPayeePhone.Size = new System.Drawing.Size(100, 20);
      this.mebUtilityPayeePhone.TabIndex = 23;
      this.mebUtilityPayeePhone.TabStop = false;
      this.mebUtilityPayeePhone.Text = "###-###-####";
      this.radLabel9.Location = new Point(201, 78);
      this.radLabel9.Name = "radLabel9";
      this.radLabel9.Size = new System.Drawing.Size(73, 18);
      this.radLabel9.TabIndex = 14;
      this.radLabel9.Text = "Payee Phone:";
      this.rtbUtilityPayeeAddress1.Location = new Point(111, 111);
      this.rtbUtilityPayeeAddress1.Name = "rtbUtilityPayeeAddress1";
      this.rtbUtilityPayeeAddress1.Size = new System.Drawing.Size(269, 20);
      this.rtbUtilityPayeeAddress1.TabIndex = 24;
      this.radLabel10.Location = new Point(14, 113);
      this.radLabel10.Name = "radLabel10";
      this.radLabel10.Size = new System.Drawing.Size(91, 18);
      this.radLabel10.TabIndex = 26;
      this.radLabel10.Text = "Payee Address 1:";
      this.rtbUtilityPayeeAddress2.Location = new Point(111, 137);
      this.rtbUtilityPayeeAddress2.Name = "rtbUtilityPayeeAddress2";
      this.rtbUtilityPayeeAddress2.Size = new System.Drawing.Size(269, 20);
      this.rtbUtilityPayeeAddress2.TabIndex = 25;
      this.radLabel11.Location = new Point(14, 138);
      this.radLabel11.Name = "radLabel11";
      this.radLabel11.Size = new System.Drawing.Size(91, 18);
      this.radLabel11.TabIndex = 28;
      this.radLabel11.Text = "Payee Address 2:";
      this.rtbUtilityPayeeZip.Location = new Point(289, 186);
      this.rtbUtilityPayeeZip.Name = "rtbUtilityPayeeZip";
      this.rtbUtilityPayeeZip.Size = new System.Drawing.Size(91, 20);
      this.rtbUtilityPayeeZip.TabIndex = 32;
      this.rtbUtilityPayeeCity.Location = new Point(11, 186);
      this.rtbUtilityPayeeCity.Name = "rtbUtilityPayeeCity";
      this.rtbUtilityPayeeCity.Size = new System.Drawing.Size(192, 20);
      this.rtbUtilityPayeeCity.TabIndex = 30;
      this.radLabel14.Location = new Point(289, 163);
      this.radLabel14.Name = "radLabel14";
      this.radLabel14.Size = new System.Drawing.Size(24, 18);
      this.radLabel14.TabIndex = 32;
      this.radLabel14.Text = "Zip:";
      this.radLabel13.Location = new Point(220, 163);
      this.radLabel13.Name = "radLabel13";
      this.radLabel13.Size = new System.Drawing.Size(34, 18);
      this.radLabel13.TabIndex = 31;
      this.radLabel13.Text = "State:";
      this.radLabel12.Location = new Point(11, 163);
      this.radLabel12.Name = "radLabel12";
      this.radLabel12.Size = new System.Drawing.Size(60, 18);
      this.radLabel12.TabIndex = 30;
      this.radLabel12.Text = "Payee City:";
      this.rddlUtilityPayeeState.Location = new Point(217, 186);
      this.rddlUtilityPayeeState.Name = "rddlUtilityPayeeState";
      this.rddlUtilityPayeeState.Size = new System.Drawing.Size(57, 20);
      this.rddlUtilityPayeeState.TabIndex = 31;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.rddlUtilityPayeeState);
      this.Controls.Add((Control) this.rtbUtilityPayeeZip);
      this.Controls.Add((Control) this.rtbUtilityPayeeCity);
      this.Controls.Add((Control) this.radLabel14);
      this.Controls.Add((Control) this.radLabel13);
      this.Controls.Add((Control) this.radLabel12);
      this.Controls.Add((Control) this.rtbUtilityPayeeAddress2);
      this.Controls.Add((Control) this.radLabel11);
      this.Controls.Add((Control) this.rtbUtilityPayeeAddress1);
      this.Controls.Add((Control) this.radLabel10);
      this.Controls.Add((Control) this.mebUtilityPayeePhone);
      this.Controls.Add((Control) this.radLabel9);
      this.Controls.Add((Control) this.rtbUtilityPayee);
      this.Controls.Add((Control) this.radLabel8);
      this.Controls.Add((Control) this.ID);
      this.Controls.Add((Control) this.PageIndex);
      this.Controls.Add((Control) this.rddlUtilityFrequency);
      this.Controls.Add((Control) this.radLabel4);
      this.Controls.Add((Control) this.mebUtilityAmount);
      this.Controls.Add((Control) this.radLabel6);
      this.Controls.Add((Control) this.rtbUtilityType);
      this.Controls.Add((Control) this.radLabel1);
      this.Name = nameof (ucTaxSheetUtilities);
      this.Size = new System.Drawing.Size(419, 273);
      this.rtbUtilityType.EndInit();
      this.radLabel1.EndInit();
      this.mebUtilityAmount.EndInit();
      this.radLabel6.EndInit();
      this.rddlUtilityFrequency.EndInit();
      this.radLabel4.EndInit();
      this.ID.EndInit();
      this.PageIndex.EndInit();
      this.radLabel8.EndInit();
      this.rtbUtilityPayee.EndInit();
      this.mebUtilityPayeePhone.EndInit();
      this.radLabel9.EndInit();
      this.rtbUtilityPayeeAddress1.EndInit();
      this.radLabel10.EndInit();
      this.rtbUtilityPayeeAddress2.EndInit();
      this.radLabel11.EndInit();
      this.rtbUtilityPayeeZip.EndInit();
      this.rtbUtilityPayeeCity.EndInit();
      this.radLabel14.EndInit();
      this.radLabel13.EndInit();
      this.radLabel12.EndInit();
      this.rddlUtilityPayeeState.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
