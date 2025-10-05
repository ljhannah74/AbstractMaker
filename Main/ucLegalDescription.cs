// Decompiled with JetBrains decompiler
// Type: Sternhagen.ucLegalDescription
// Assembly: Sternhagen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 926CB3A7-5318-4FD7-8127-F742EC5C62A1
// Assembly location: C:\Users\lhann\OneDrive\Documents\Software\Sternhagen\Sternhagen.exe

using AbstractMaker.Model;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace AbstractMaker.Main
{
  public class ucLegalDescription : UserControl
  {
    private IContainer components = (IContainer) null;
    private RadLabel radLabel1;
    private RadTextBoxControl rtbcLegalDesc;
    private RadLabel radLabel2;
    private RadTextBox rtbTaxID;

    public Legal_Description Legal_Description { get; set; }

    public ucLegalDescription()
    {
      this.InitializeComponent();
      this.Legal_Description = new Legal_Description();
      this.UpdateUIToReflectModel();
      this.rtbcLegalDesc.TextChanged += new EventHandler(this.rtbcLegalDesc_TextChanged);
      this.rtbTaxID.TextChanged += new EventHandler(this.rtbTaxID_TextChanged);
    }

    public void SetLegalDescription(Legal_Description legal_Description)
    {
            if (legal_Description != null)
            {
                this.Legal_Description = legal_Description;
            }
            else
            {
                this.Legal_Description = new Legal_Description();
            }
            this.UpdateUIToReflectModel();
     }

        public Legal_Description GetLegalDescription() => this.Legal_Description;
        private void rtbcLegalDesc_TextChanged(object sender, EventArgs e) => this.Legal_Description.Text = this.rtbcLegalDesc.Text;

    private void rtbTaxID_TextChanged(object sender, EventArgs e) => this.Legal_Description.TaxID = this.rtbTaxID.Text;

    private void UpdateUIToReflectModel()
    {
        if(Legal_Description != null)
            {
                this.rtbcLegalDesc.Text = this.Legal_Description?.Text;
                this.rtbTaxID.Text = this.Legal_Description?.TaxID;
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
      this.rtbcLegalDesc = new RadTextBoxControl();
      this.radLabel2 = new RadLabel();
      this.rtbTaxID = new RadTextBox();
      this.radLabel1.BeginInit();
      this.rtbcLegalDesc.BeginInit();
      this.radLabel2.BeginInit();
      this.rtbTaxID.BeginInit();
      this.SuspendLayout();
      this.radLabel1.Location = new Point(3, 3);
      this.radLabel1.Name = "radLabel1";
      this.radLabel1.Size = new System.Drawing.Size(95, 18);
      this.radLabel1.TabIndex = 4;
      this.radLabel1.Text = "Legal Description:";
      this.rtbcLegalDesc.AcceptsReturn = true;
      this.rtbcLegalDesc.AcceptsTab = true;
      this.rtbcLegalDesc.AllowDrop = true;
      this.rtbcLegalDesc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.rtbcLegalDesc.AutoScroll = true;
      this.rtbcLegalDesc.Location = new Point(3, 27);
      this.rtbcLegalDesc.Multiline = true;
      this.rtbcLegalDesc.Name = "rtbcLegalDesc";
      this.rtbcLegalDesc.Size = new System.Drawing.Size(871, 425);
      this.rtbcLegalDesc.TabIndex = 5;
      this.radLabel2.Location = new Point(1, 548);
      this.radLabel2.Name = "radLabel2";
      this.radLabel2.Size = new System.Drawing.Size(37, 18);
      this.radLabel2.TabIndex = 6;
      this.radLabel2.Text = "Tax ID";
      this.rtbTaxID.Location = new Point(44, 548);
      this.rtbTaxID.Name = "rtbTaxID";
      this.rtbTaxID.Size = new System.Drawing.Size(830, 20);
      this.rtbTaxID.TabIndex = 7;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.rtbTaxID);
      this.Controls.Add((Control) this.radLabel2);
      this.Controls.Add((Control) this.rtbcLegalDesc);
      this.Controls.Add((Control) this.radLabel1);
      this.Name = "ucLegalDescription";
      this.Size = new System.Drawing.Size(877, 602);
      this.radLabel1.EndInit();
      this.rtbcLegalDesc.EndInit();
      this.radLabel2.EndInit();
      this.rtbTaxID.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
