// Decompiled with JetBrains decompiler
// Type: Sternhagen.ucJudgmentLiensInfo
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
  public class ucJudgmentLiensInfo : UserControl
  {
    public List<string> PlaintiffTypes = new List<string>()
    {
      "Plaintiff",
      "Secured Party",
      "Creditor",
      "Lienor"
    };
    public List<string> DefendantTypes = new List<string>()
    {
      "Defendant",
      "Debtor"
    };
    private IContainer components = (IContainer) null;
    private RadTextBox rtbJudgmentType;
    private RadLabel radLabel1;
    private RadDropDownList rddlPlaintiffType;
    private RadLabel radLabel2;
    private RadLabel radLabel3;
    private RadLabel radLabel4;
    private RadLabel radLabel5;
    private RadLabel radLabel6;
    private RadLabel radLabel7;
    private RadLabel radLabel8;
    private RadDropDownList rddlDefendantType;
    private RadTextBox rtbBook;
    private RadTextBox rtbDocumentCase;
    private RadTextBox rtbPage;
    private RadTextBox rtbDefendantName;
    private RadTextBox rtbPlaintiffName;
    private RadLabel radLabel10;
    private RadLabel radLabel11;
    private RadMaskedEditBox mebAmount;
    public RadSpinEditor ID;
    private RadDateTimePicker dtpDateFiled;
    private RadLabel radLabel13;
    private RadTextBox rtbInstrumentNumber;

    public Judgment JudgmentModel { get; set; }

    public ucJudgmentLiensInfo(Judgment judgment)
    {
      this.InitializeComponent();
      this.JudgmentModel = judgment;
      this.rddlPlaintiffType.DataSource = (object) this.PlaintiffTypes;
      this.rddlDefendantType.DataSource = (object) this.DefendantTypes;
      this.UpdateUIToReflectModel();
      this.rtbJudgmentType.TextChanged += new EventHandler(this.RtbJudgmentType_TextChanged);
      this.rddlPlaintiffType.SelectedValueChanged += new EventHandler(this.RddlPlaintiffType_SelectedValueChanged);
      this.rtbPlaintiffName.TextChanged += new EventHandler(this.RtbPlaintiffName_TextChanged);
      this.rddlDefendantType.SelectedValueChanged += new EventHandler(this.RddlDefendantType_SelectedValueChanged);
      this.rtbDefendantName.TextChanged += new EventHandler(this.RtbDefendantName_TextChanged);
      this.mebAmount.ValueChanged += new EventHandler(this.MebAmount_ValueChanged);
      this.dtpDateFiled.ValueChanged += new EventHandler(this.MebDateFiled_ValueChanged);
      this.rtbDocumentCase.TextChanged += new EventHandler(this.RtbDocumentCase_TextChanged);
      this.rtbBook.TextChanged += new EventHandler(this.RtbBook_TextChanged);
      this.rtbPage.TextChanged += new EventHandler(this.RtbPage_TextChanged);
      this.ID.ValueChanged += new EventHandler(this.ID_ValueChanged);
      this.rtbInstrumentNumber.TextChanged += new EventHandler(this.RtbInstrumentNumber_TextChanged);
    }

    private void ID_ValueChanged(object sender, EventArgs e) => this.JudgmentModel.ID = (int) this.ID.Value;

    private void RtbJudgmentType_TextChanged(object sender, EventArgs e) => this.JudgmentModel.Name = this.rtbJudgmentType.Text;

    private void RddlPlaintiffType_SelectedValueChanged(object sender, EventArgs e) => this.JudgmentModel.PlaintiffType = this.rddlPlaintiffType.SelectedValue.ToString();

    private void RtbPlaintiffName_TextChanged(object sender, EventArgs e) => this.JudgmentModel.PlaintiffName = this.rtbPlaintiffName.Text;

    private void RddlDefendantType_SelectedValueChanged(object sender, EventArgs e) => this.JudgmentModel.DefendantType = this.rddlDefendantType.SelectedValue.ToString();

    private void RtbDefendantName_TextChanged(object sender, EventArgs e) => this.JudgmentModel.DefendantName = this.rtbDefendantName.Text;

    private void MebAmount_ValueChanged(object sender, EventArgs e) => this.JudgmentModel.Amount = this.mebAmount.Value == null || ((string) this.mebAmount.Value).Length <= 0 ? new Decimal?() : new Decimal?(Decimal.Parse(((string) this.mebAmount.Value).Substring(1)));

    private void MebDateFiled_ValueChanged(object sender, EventArgs e) => this.JudgmentModel.FiledDate = this.dtpDateFiled.Value > DateTime.Parse("1/1/1900") ? new DateTime?(this.dtpDateFiled.Value) : new DateTime?();

    private void RtbDocumentCase_TextChanged(object sender, EventArgs e) => this.JudgmentModel.DocumentInstrumentNumber = this.rtbDocumentCase.Text;

    private void RtbBook_TextChanged(object sender, EventArgs e) => this.JudgmentModel.Book = this.rtbBook.Text;

    private void RtbPage_TextChanged(object sender, EventArgs e) => this.JudgmentModel.Page = this.rtbPage.Text;

    private void RtbInstrumentNumber_TextChanged(object sender, EventArgs e) => this.JudgmentModel.CaseNumber = this.rtbInstrumentNumber.Text;

    private void UpdateUIToReflectModel()
    {
      this.rtbJudgmentType.Text = this.JudgmentModel.Name ?? "";
      if (!string.IsNullOrWhiteSpace(this.JudgmentModel.PlaintiffType))
        this.rddlPlaintiffType.SelectedValue = (object) this.JudgmentModel.PlaintiffType;
      this.JudgmentModel.PlaintiffType = this.rddlPlaintiffType.SelectedValue.ToString();
      this.rtbPlaintiffName.Text = this.JudgmentModel.PlaintiffName;
      if (!string.IsNullOrWhiteSpace(this.JudgmentModel.DefendantType))
        this.rddlDefendantType.SelectedValue = (object) this.JudgmentModel.DefendantType;
      this.JudgmentModel.DefendantType = this.rddlDefendantType.SelectedValue.ToString();
      this.rtbDefendantName.Text = this.JudgmentModel.DefendantName;
      RadMaskedEditBox mebAmount = this.mebAmount;
      Decimal? nullable1 = this.JudgmentModel.Amount;
      Decimal? nullable2;
      if (!nullable1.HasValue)
      {
        nullable1 = new Decimal?();
        nullable2 = nullable1;
      }
      else
      {
        nullable1 = this.JudgmentModel.Amount;
        nullable2 = new Decimal?(nullable1.Value);
      }
      // ISSUE: variable of a boxed type
      Decimal? local = nullable2;
      mebAmount.Value = (object) local;
      this.dtpDateFiled.Value = this.JudgmentModel.FiledDate.HasValue ? this.JudgmentModel.FiledDate.Value : DateTime.Parse("1/1/1900");
      this.rtbDocumentCase.Text = this.JudgmentModel.DocumentInstrumentNumber;
      this.rtbBook.Text = this.JudgmentModel.Book;
      this.rtbPage.Text = this.JudgmentModel.Page;
      this.rtbInstrumentNumber.Text = this.JudgmentModel.CaseNumber;
      this.ID.Value = (Decimal) this.JudgmentModel.ID;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.rtbJudgmentType = new RadTextBox();
      this.radLabel1 = new RadLabel();
      this.rddlPlaintiffType = new RadDropDownList();
      this.radLabel2 = new RadLabel();
      this.radLabel3 = new RadLabel();
      this.radLabel4 = new RadLabel();
      this.radLabel5 = new RadLabel();
      this.radLabel6 = new RadLabel();
      this.radLabel7 = new RadLabel();
      this.radLabel8 = new RadLabel();
      this.rddlDefendantType = new RadDropDownList();
      this.rtbBook = new RadTextBox();
      this.rtbDocumentCase = new RadTextBox();
      this.rtbPage = new RadTextBox();
      this.rtbDefendantName = new RadTextBox();
      this.rtbPlaintiffName = new RadTextBox();
      this.radLabel10 = new RadLabel();
      this.radLabel11 = new RadLabel();
      this.mebAmount = new RadMaskedEditBox();
      this.ID = new RadSpinEditor();
      this.dtpDateFiled = new RadDateTimePicker();
      this.radLabel13 = new RadLabel();
      this.rtbInstrumentNumber = new RadTextBox();
      this.rtbJudgmentType.BeginInit();
      this.radLabel1.BeginInit();
      this.rddlPlaintiffType.BeginInit();
      this.radLabel2.BeginInit();
      this.radLabel3.BeginInit();
      this.radLabel4.BeginInit();
      this.radLabel5.BeginInit();
      this.radLabel6.BeginInit();
      this.radLabel7.BeginInit();
      this.radLabel8.BeginInit();
      this.rddlDefendantType.BeginInit();
      this.rtbBook.BeginInit();
      this.rtbDocumentCase.BeginInit();
      this.rtbPage.BeginInit();
      this.rtbDefendantName.BeginInit();
      this.rtbPlaintiffName.BeginInit();
      this.radLabel10.BeginInit();
      this.radLabel11.BeginInit();
      this.mebAmount.BeginInit();
      this.ID.BeginInit();
      this.dtpDateFiled.BeginInit();
      this.radLabel13.BeginInit();
      this.rtbInstrumentNumber.BeginInit();
      this.SuspendLayout();
      this.rtbJudgmentType.Location = new Point(110, 24);
      this.rtbJudgmentType.Name = "rtbJudgmentType";
      this.rtbJudgmentType.Size = new System.Drawing.Size(321, 20);
      this.rtbJudgmentType.TabIndex = 3;
      this.radLabel1.Location = new Point(13, 25);
      this.radLabel1.Name = "radLabel1";
      this.radLabel1.Size = new System.Drawing.Size(91, 18);
      this.radLabel1.TabIndex = 1;
      this.radLabel1.Text = "Judgment Type:";
      this.rddlPlaintiffType.Location = new Point(110, 68);
      this.rddlPlaintiffType.Name = "rddlPlaintiffType";
      this.rddlPlaintiffType.Size = new System.Drawing.Size(133, 20);
      this.rddlPlaintiffType.TabIndex = 4;
      this.radLabel2.Location = new Point(13, 69);
      this.radLabel2.Name = "radLabel2";
      this.radLabel2.Size = new System.Drawing.Size(73, 18);
      this.radLabel2.TabIndex = 3;
      this.radLabel2.Text = "Plaintiff Type:";
      this.radLabel3.Location = new Point(13, 95);
      this.radLabel3.Name = "radLabel3";
      this.radLabel3.Size = new System.Drawing.Size(88, 18);
      this.radLabel3.TabIndex = 4;
      this.radLabel3.Text = "Defendant Type:";
      this.radLabel4.Location = new Point(13, 148);
      this.radLabel4.Name = "radLabel4";
      this.radLabel4.Size = new System.Drawing.Size(59, 18);
      this.radLabel4.TabIndex = 5;
      this.radLabel4.Text = "Date Filed:";
      this.radLabel5.Location = new Point(13, 122);
      this.radLabel5.Name = "radLabel5";
      this.radLabel5.Size = new System.Drawing.Size(49, 18);
      this.radLabel5.TabIndex = 6;
      this.radLabel5.Text = "Amount:";
      this.radLabel6.Location = new Point(13, 174);
      this.radLabel6.Name = "radLabel6";
      this.radLabel6.Size = new System.Drawing.Size(87, 18);
      this.radLabel6.TabIndex = 7;
      this.radLabel6.Text = "Document/Instr:";
      this.radLabel7.Location = new Point(259, 201);
      this.radLabel7.Name = "radLabel7";
      this.radLabel7.Size = new System.Drawing.Size(33, 18);
      this.radLabel7.TabIndex = 8;
      this.radLabel7.Text = "Page:";
      this.radLabel8.Location = new Point(13, 200);
      this.radLabel8.Name = "radLabel8";
      this.radLabel8.Size = new System.Drawing.Size(34, 18);
      this.radLabel8.TabIndex = 9;
      this.radLabel8.Text = "Book:";
      this.rddlDefendantType.Location = new Point(110, 94);
      this.rddlDefendantType.Name = "rddlDefendantType";
      this.rddlDefendantType.Size = new System.Drawing.Size(133, 20);
      this.rddlDefendantType.TabIndex = 6;
      this.rtbBook.Location = new Point(110, 199);
      this.rtbBook.Name = "rtbBook";
      this.rtbBook.Size = new System.Drawing.Size(133, 20);
      this.rtbBook.TabIndex = 13;
      this.rtbDocumentCase.Location = new Point(110, 173);
      this.rtbDocumentCase.Name = "rtbDocumentCase";
      this.rtbDocumentCase.Size = new System.Drawing.Size(321, 20);
      this.rtbDocumentCase.TabIndex = 12;
      this.rtbPage.Location = new Point(298, 199);
      this.rtbPage.Name = "rtbPage";
      this.rtbPage.Size = new System.Drawing.Size(133, 20);
      this.rtbPage.TabIndex = 14;
      this.rtbDefendantName.Location = new Point(372, 95);
      this.rtbDefendantName.Name = "rtbDefendantName";
      this.rtbDefendantName.Size = new System.Drawing.Size(133, 20);
      this.rtbDefendantName.TabIndex = 7;
      this.rtbPlaintiffName.Location = new Point(372, 69);
      this.rtbPlaintiffName.Name = "rtbPlaintiffName";
      this.rtbPlaintiffName.Size = new System.Drawing.Size(133, 20);
      this.rtbPlaintiffName.TabIndex = 5;
      this.radLabel10.Location = new Point(333, 70);
      this.radLabel10.Name = "radLabel10";
      this.radLabel10.Size = new System.Drawing.Size(39, 18);
      this.radLabel10.TabIndex = 20;
      this.radLabel10.Text = "Name:";
      this.radLabel11.Location = new Point(333, 96);
      this.radLabel11.Name = "radLabel11";
      this.radLabel11.Size = new System.Drawing.Size(39, 18);
      this.radLabel11.TabIndex = 21;
      this.radLabel11.Text = "Name:";
      this.mebAmount.EnableNullValueInput = true;
      this.mebAmount.Location = new Point(110, 121);
      this.mebAmount.Mask = "C";
      this.mebAmount.MaskType = MaskType.Numeric;
      this.mebAmount.Name = "mebAmount";
      this.mebAmount.Size = new System.Drawing.Size(133, 20);
      this.mebAmount.TabIndex = 8;
      this.mebAmount.TabStop = false;
      this.mebAmount.Text = "$0.00";
      this.ID.Location = new Point(599, 345);
      this.ID.Name = "ID";
      this.ID.ReadOnly = true;
      this.ID.Size = new System.Drawing.Size(53, 20);
      this.ID.TabIndex = 23;
      this.ID.Visible = false;
      this.dtpDateFiled.Format = DateTimePickerFormat.Short;
      this.dtpDateFiled.Location = new Point(110, 147);
      this.dtpDateFiled.Name = "dtpDateFiled";
      this.dtpDateFiled.NullDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
      this.dtpDateFiled.NullText = "not specified";
      this.dtpDateFiled.Size = new System.Drawing.Size(133, 20);
      this.dtpDateFiled.TabIndex = 10;
      this.dtpDateFiled.TabStop = false;
      this.dtpDateFiled.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
      this.radLabel13.Location = new Point(296, 122);
      this.radLabel13.Name = "radLabel13";
      this.radLabel13.Size = new System.Drawing.Size(76, 18);
      this.radLabel13.TabIndex = 27;
      this.radLabel13.Text = "Case Number:";
      this.rtbInstrumentNumber.Location = new Point(372, 121);
      this.rtbInstrumentNumber.Name = "rtbInstrumentNumber";
      this.rtbInstrumentNumber.Size = new System.Drawing.Size(133, 20);
      this.rtbInstrumentNumber.TabIndex = 9;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.rtbInstrumentNumber);
      this.Controls.Add((Control) this.radLabel13);
      this.Controls.Add((Control) this.dtpDateFiled);
      this.Controls.Add((Control) this.ID);
      this.Controls.Add((Control) this.mebAmount);
      this.Controls.Add((Control) this.radLabel11);
      this.Controls.Add((Control) this.radLabel10);
      this.Controls.Add((Control) this.rtbDefendantName);
      this.Controls.Add((Control) this.rtbPlaintiffName);
      this.Controls.Add((Control) this.rtbPage);
      this.Controls.Add((Control) this.rtbDocumentCase);
      this.Controls.Add((Control) this.rtbBook);
      this.Controls.Add((Control) this.rddlDefendantType);
      this.Controls.Add((Control) this.radLabel8);
      this.Controls.Add((Control) this.radLabel7);
      this.Controls.Add((Control) this.radLabel6);
      this.Controls.Add((Control) this.radLabel5);
      this.Controls.Add((Control) this.radLabel4);
      this.Controls.Add((Control) this.radLabel3);
      this.Controls.Add((Control) this.radLabel2);
      this.Controls.Add((Control) this.rddlPlaintiffType);
      this.Controls.Add((Control) this.radLabel1);
      this.Controls.Add((Control) this.rtbJudgmentType);
      this.Name = nameof (ucJudgmentLiensInfo);
      this.Size = new System.Drawing.Size(655, 370);
      this.rtbJudgmentType.EndInit();
      this.radLabel1.EndInit();
      this.rddlPlaintiffType.EndInit();
      this.radLabel2.EndInit();
      this.radLabel3.EndInit();
      this.radLabel4.EndInit();
      this.radLabel5.EndInit();
      this.radLabel6.EndInit();
      this.radLabel7.EndInit();
      this.radLabel8.EndInit();
      this.rddlDefendantType.EndInit();
      this.rtbBook.EndInit();
      this.rtbDocumentCase.EndInit();
      this.rtbPage.EndInit();
      this.rtbDefendantName.EndInit();
      this.rtbPlaintiffName.EndInit();
      this.radLabel10.EndInit();
      this.radLabel11.EndInit();
      this.mebAmount.EndInit();
      this.ID.EndInit();
      this.dtpDateFiled.EndInit();
      this.radLabel13.EndInit();
      this.rtbInstrumentNumber.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
