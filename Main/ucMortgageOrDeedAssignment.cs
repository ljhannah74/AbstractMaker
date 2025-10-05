// Decompiled with JetBrains decompiler
// Type: Sternhagen.ucMortgageOrDeedAssignment
// Assembly: Sternhagen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 926CB3A7-5318-4FD7-8127-F742EC5C62A1
// Assembly location: C:\Users\lhann\OneDrive\Documents\Software\Sternhagen\Sternhagen.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using AbstractMaker.Model;

namespace AbstractMaker.Main
{
  public class ucMortgageOrDeedAssignment : UserControl
  {
    private IContainer components = (IContainer) null;
    private RadLabel lblAssignee;
    private RadTextBox tbAssignee;
    private RadLabel radLabel2;
    private RadDateTimePicker dtpAssignmentFiledDate;
    private RadLabel radLabel3;
    private RadTextBox tbAssignmentDocument;
    private RadLabel radLabel4;
    private RadTextBox tbAssignmentBook;
    private RadLabel radLabel5;
    private RadTextBox tbAssignmentPage;
    public RadSpinEditor ID;
    public RadSpinEditor PageIndex;
    private RadDateTimePicker dtpAssignmentDated;
    private RadLabel lblDated;
    private RadTextBox tbAmount;
    private RadLabel lblAmount;

    public Assignments Assignment { get; set; }

    public ucMortgageOrDeedAssignment()    
    {
            this.Assignment = new Assignments();
            InitializeComponent();
            UpdateUIToReflectModel();
        }

    public ucMortgageOrDeedAssignment(Assignments assignment)
    {
      this.InitializeComponent();
      this.Assignment = assignment;
      this.UpdateUIToReflectModel();
      this.tbAssignee.TextChanged += new EventHandler(this.tbAssignee_TextChanged);
      this.dtpAssignmentDated.ValueChanged += new EventHandler(this.DtpAssignmentDated_ValueChanged);
      this.dtpAssignmentFiledDate.ValueChanged += new EventHandler(this.dtpAssignmentFiledDate_ValueChanged);
      this.tbAmount.TextChanged += new EventHandler(this.TbAmount_TextChanged);
      this.tbAssignmentDocument.TextChanged += new EventHandler(this.tbAssignmentDocument_TextChanged);
      this.tbAssignmentBook.TextChanged += new EventHandler(this.tbAssignmentBook_TextChanged);
      this.tbAssignmentPage.TextChanged += new EventHandler(this.tbAssignmentPage_TextChanged);
      if (this.Assignment.AssignmentType == "Modification")
      {
        this.lblAssignee.Visible = false;
        this.tbAssignee.Visible = false;
      }
      else
      {
        this.lblAmount.Visible = false;
        this.tbAmount.Visible = false;
        this.lblDated.Visible = false;
        this.dtpAssignmentDated.Visible = false;
      }
    }

    private void TbAmount_TextChanged(object sender, EventArgs e)
    {
      Decimal result;
      this.Assignment.Amount = !Decimal.TryParse(this.tbAmount.Text.Replace("$", ""), out result) ? new Decimal?() : new Decimal?(result);
      this.UpdateHeading(string.IsNullOrEmpty(this.tbAmount.Text) ? "No Amount" : "Modification of " + this.tbAmount.Text);
    }

    private void DtpAssignmentDated_ValueChanged(object sender, EventArgs e) => this.Assignment.Dated = this.dtpAssignmentDated.Value > DateTime.Parse("1/1/1900") ? new DateTime?(this.dtpAssignmentDated.Value) : new DateTime?();

    private void tbAssignee_TextChanged(object sender, EventArgs e)
    {
      this.Assignment.Assignee = this.tbAssignee.Text;
      this.UpdateHeading(string.IsNullOrEmpty(this.tbAssignee.Text) ? "No Assignee" : this.tbAssignee.Text);
    }

    private void dtpAssignmentFiledDate_ValueChanged(object sender, EventArgs e) => this.Assignment.Filed = this.dtpAssignmentFiledDate.Value > DateTime.Parse("1/1/1900") ? new DateTime?(this.dtpAssignmentFiledDate.Value) : new DateTime?();

    private void tbAssignmentDocument_TextChanged(object sender, EventArgs e) => this.Assignment.Document = this.tbAssignmentDocument.Text;

    private void tbAssignmentBook_TextChanged(object sender, EventArgs e) => this.Assignment.Book = this.tbAssignmentBook.Text;

    private void tbAssignmentPage_TextChanged(object sender, EventArgs e) => this.Assignment.Page = this.tbAssignmentPage.Text;

    private void ucMortgageOrDeedAssignment_ParentChanged(object sender, EventArgs e)
    {
      if (this.Assignment.AssignmentType == "Modification")
        this.UpdateHeading(string.IsNullOrEmpty(this.tbAmount.Text) ? "No Amount" : "Modification of " + this.tbAmount.Text);
      else
        this.UpdateHeading(string.IsNullOrEmpty(this.tbAssignee.Text) ? "No Assignee" : this.tbAssignee.Text);
    }

    private void UpdateUIToReflectModel()
    {
      if (!string.IsNullOrWhiteSpace(this.Assignment.Assignee))
        this.tbAssignee.Text = this.Assignment.Assignee;
      RadDateTimePicker dtpAssignmentDated = this.dtpAssignmentDated;
      DateTime? nullable;
      DateTime dateTime1;
      if (!this.Assignment.Dated.HasValue)
      {
        dateTime1 = DateTime.Parse("1/1/1900");
      }
      else
      {
        nullable = this.Assignment.Dated;
        dateTime1 = nullable.Value;
      }
      dtpAssignmentDated.Value = dateTime1;
      this.tbAmount.Text = this.Assignment.Amount.HasValue ? this.Assignment.Amount.Value.ToString("C") : "";
      nullable = this.Assignment.Filed;
      if (!string.IsNullOrWhiteSpace(nullable.ToString()))
      {
        RadDateTimePicker assignmentFiledDate = this.dtpAssignmentFiledDate;
        nullable = this.Assignment.Filed;
        DateTime dateTime2;
        if (!nullable.HasValue)
        {
          dateTime2 = DateTime.Parse("1/1/1900");
        }
        else
        {
          nullable = this.Assignment.Filed;
          dateTime2 = nullable.Value;
        }
        assignmentFiledDate.Value = dateTime2;
      }
      if (!string.IsNullOrWhiteSpace(this.Assignment.Document))
        this.tbAssignmentDocument.Text = this.Assignment.Document;
      if (!string.IsNullOrWhiteSpace(this.Assignment.Book))
        this.tbAssignmentBook.Text = this.Assignment.Book;
      if (string.IsNullOrWhiteSpace(this.Assignment.Page))
        return;
      this.tbAssignmentPage.Text = this.Assignment.Page;
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
      this.lblAssignee = new RadLabel();
      this.tbAssignee = new RadTextBox();
      this.radLabel2 = new RadLabel();
      this.dtpAssignmentFiledDate = new RadDateTimePicker();
      this.radLabel3 = new RadLabel();
      this.tbAssignmentDocument = new RadTextBox();
      this.radLabel4 = new RadLabel();
      this.tbAssignmentBook = new RadTextBox();
      this.radLabel5 = new RadLabel();
      this.tbAssignmentPage = new RadTextBox();
      this.ID = new RadSpinEditor();
      this.PageIndex = new RadSpinEditor();
      this.dtpAssignmentDated = new RadDateTimePicker();
      this.lblDated = new RadLabel();
      this.tbAmount = new RadTextBox();
      this.lblAmount = new RadLabel();
      this.lblAssignee.BeginInit();
      this.tbAssignee.BeginInit();
      this.radLabel2.BeginInit();
      this.dtpAssignmentFiledDate.BeginInit();
      this.radLabel3.BeginInit();
      this.tbAssignmentDocument.BeginInit();
      this.radLabel4.BeginInit();
      this.tbAssignmentBook.BeginInit();
      this.radLabel5.BeginInit();
      this.tbAssignmentPage.BeginInit();
      this.ID.BeginInit();
      this.PageIndex.BeginInit();
      this.dtpAssignmentDated.BeginInit();
      this.lblDated.BeginInit();
      this.tbAmount.BeginInit();
      this.lblAmount.BeginInit();
      this.SuspendLayout();
      this.lblAssignee.Location = new Point(3, 3);
      this.lblAssignee.Name = "lblAssignee";
      this.lblAssignee.Size = new System.Drawing.Size(51, 18);
      this.lblAssignee.TabIndex = 0;
      this.lblAssignee.Text = "Assignee";
      this.tbAssignee.Location = new Point(3, 27);
      this.tbAssignee.Name = "tbAssignee";
      this.tbAssignee.Size = new System.Drawing.Size(323, 20);
      this.tbAssignee.TabIndex = 2;
      this.radLabel2.Location = new Point(3, 53);
      this.radLabel2.Name = "radLabel2";
      this.radLabel2.Size = new System.Drawing.Size(30, 18);
      this.radLabel2.TabIndex = 2;
      this.radLabel2.Text = "Filed";
      this.dtpAssignmentFiledDate.Format = DateTimePickerFormat.Short;
      this.dtpAssignmentFiledDate.Location = new Point(3, 77);
      this.dtpAssignmentFiledDate.Name = "dtpAssignmentFiledDate";
      this.dtpAssignmentFiledDate.NullDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
      this.dtpAssignmentFiledDate.NullText = "not specified";
      this.dtpAssignmentFiledDate.Size = new System.Drawing.Size(125, 20);
      this.dtpAssignmentFiledDate.TabIndex = 3;
      this.dtpAssignmentFiledDate.TabStop = false;
      this.dtpAssignmentFiledDate.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
      this.radLabel3.Location = new Point(178, 103);
      this.radLabel3.Name = "radLabel3";
      this.radLabel3.Size = new System.Drawing.Size(61, 18);
      this.radLabel3.TabIndex = 104;
      this.radLabel3.Text = "Instrument";
      this.tbAssignmentDocument.Location = new Point(178, 125);
      this.tbAssignmentDocument.Name = "tbAssignmentDocument";
      this.tbAssignmentDocument.Size = new System.Drawing.Size(279, 20);
      this.tbAssignmentDocument.TabIndex = 8;
      this.radLabel4.Location = new Point(3, 103);
      this.radLabel4.Name = "radLabel4";
      this.radLabel4.Size = new System.Drawing.Size(32, 18);
      this.radLabel4.TabIndex = 106;
      this.radLabel4.Text = "Book";
      this.tbAssignmentBook.Location = new Point(3, 125);
      this.tbAssignmentBook.Name = "tbAssignmentBook";
      this.tbAssignmentBook.Size = new System.Drawing.Size(95, 20);
      this.tbAssignmentBook.TabIndex = 6;
      this.radLabel5.Location = new Point(104, 103);
      this.radLabel5.Name = "radLabel5";
      this.radLabel5.Size = new System.Drawing.Size(31, 18);
      this.radLabel5.TabIndex = 108;
      this.radLabel5.Text = "Page";
      this.tbAssignmentPage.Location = new Point(104, 125);
      this.tbAssignmentPage.Name = "tbAssignmentPage";
      this.tbAssignmentPage.Size = new System.Drawing.Size(68, 20);
      this.tbAssignmentPage.TabIndex = 7;
      this.ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.ID.Location = new Point(3, 174);
      this.ID.Name = "ID";
      this.ID.ReadOnly = true;
      this.ID.Size = new System.Drawing.Size(53, 20);
      this.ID.TabIndex = 6;
      this.ID.Visible = false;
      this.PageIndex.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.PageIndex.Location = new Point(62, 174);
      this.PageIndex.Name = "PageIndex";
      this.PageIndex.ReadOnly = true;
      this.PageIndex.Size = new System.Drawing.Size(53, 20);
      this.PageIndex.TabIndex = 7;
      this.PageIndex.Visible = false;
      this.dtpAssignmentDated.Format = DateTimePickerFormat.Short;
      this.dtpAssignmentDated.Location = new Point(296, 77);
      this.dtpAssignmentDated.Name = "dtpAssignmentDated";
      this.dtpAssignmentDated.NullDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
      this.dtpAssignmentDated.NullText = "not specified";
      this.dtpAssignmentDated.Size = new System.Drawing.Size(125, 20);
      this.dtpAssignmentDated.TabIndex = 5;
      this.dtpAssignmentDated.TabStop = false;
      this.dtpAssignmentDated.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
      this.lblDated.Location = new Point(296, 53);
      this.lblDated.Name = "lblDated";
      this.lblDated.Size = new System.Drawing.Size(36, 18);
      this.lblDated.TabIndex = 110;
      this.lblDated.Text = "Dated";
      this.tbAmount.Location = new Point(152, 77);
      this.tbAmount.Name = "tbAmount";
      this.tbAmount.Size = new System.Drawing.Size(125, 20);
      this.tbAmount.TabIndex = 4;
      this.lblAmount.Location = new Point(152, 53);
      this.lblAmount.Name = "lblAmount";
      this.lblAmount.Size = new System.Drawing.Size(47, 18);
      this.lblAmount.TabIndex = 112;
      this.lblAmount.Text = "Amount";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.tbAmount);
      this.Controls.Add((Control) this.lblAmount);
      this.Controls.Add((Control) this.dtpAssignmentDated);
      this.Controls.Add((Control) this.lblDated);
      this.Controls.Add((Control) this.ID);
      this.Controls.Add((Control) this.PageIndex);
      this.Controls.Add((Control) this.tbAssignmentPage);
      this.Controls.Add((Control) this.radLabel5);
      this.Controls.Add((Control) this.tbAssignmentBook);
      this.Controls.Add((Control) this.radLabel4);
      this.Controls.Add((Control) this.tbAssignmentDocument);
      this.Controls.Add((Control) this.radLabel3);
      this.Controls.Add((Control) this.dtpAssignmentFiledDate);
      this.Controls.Add((Control) this.radLabel2);
      this.Controls.Add((Control) this.tbAssignee);
      this.Controls.Add((Control) this.lblAssignee);
      this.Name = "ucMortgageOrDeedAssignment";
      this.Size = new System.Drawing.Size(498, 197);
      this.ParentChanged += new EventHandler(this.ucMortgageOrDeedAssignment_ParentChanged);
      this.lblAssignee.EndInit();
      this.tbAssignee.EndInit();
      this.radLabel2.EndInit();
      this.dtpAssignmentFiledDate.EndInit();
      this.radLabel3.EndInit();
      this.tbAssignmentDocument.EndInit();
      this.radLabel4.EndInit();
      this.tbAssignmentBook.EndInit();
      this.radLabel5.EndInit();
      this.tbAssignmentPage.EndInit();
      this.ID.EndInit();
      this.PageIndex.EndInit();
      this.dtpAssignmentDated.EndInit();
      this.lblDated.EndInit();
      this.tbAmount.EndInit();
      this.lblAmount.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
