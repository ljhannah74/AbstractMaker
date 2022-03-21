using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using AbstractMaker.Model;

namespace AbstractMaker.Main
{
	public partial class ucChainOfTitleGrantee : UserControl
	{
		public ucChainOfTitleGrantee()
		{
			InitializeComponent();
		}

		public ucChainOfTitleGrantee(AbstractMaker.Model.Deed deed)
		{
			this.InitializeComponent();
			this.Deed = deed;
			this.rddlOwnershipType.DataSource = this.OwnershipTypes;
			this.UpdateUIToReflectModel();
			this.rtbGranteeName.TextChanged += new EventHandler(this.rtbGranteeName_TextChanged);
			this.rtbGrantorName.TextChanged += new EventHandler(this.rtbGrantorName_TextChanged);
			this.rddlOwnershipType.SelectedValueChanged += new EventHandler(this.rddlOwnershipType_SelectedValueChanged);
			this.rtbOtherDesc.TextChanged += new EventHandler(this.RtbOtherDesc_TextChanged);
			this.mebConsideration.TextChanged += new EventHandler(this.mebConsideration_TextChanged);
			this.rdtpDated.ValueChanged += new EventHandler(this.rdtpDated_ValueChanged);
			this.rdtpRecorded.ValueChanged += new EventHandler(this.rdtpRecorded_ValueChanged);
			this.rtbBook.TextChanged += new EventHandler(this.rtbBook_TextChanged);
			this.rtbPage.TextChanged += new EventHandler(this.rtbPage_TextChanged);
			this.rtbDocumentInstr.TextChanged += new EventHandler(this.rtbDocumentSeries_TextChanged);
			this.ID.ValueChanged += new EventHandler(this.ID_ValueChanged);
		}

		private void ID_ValueChanged(object sender, EventArgs e)
		{
			this.Deed.ID = (int)this.ID.Value;
		}
		private void mebConsideration_TextChanged(object sender, EventArgs e)
		{
			decimal num;
			if (!decimal.TryParse(this.mebConsideration.Text.Replace("$", ""), out num))
			{
				this.Deed.Consideration = null;
			}
			else
			{
				this.Deed.Consideration = new decimal?(num);
			}
		}

		private void rddlOwnershipType_SelectedValueChanged(object sender, EventArgs e)
		{
			this.Deed.Ownership_Type = this.rddlOwnershipType.SelectedValue.ToString();
			if (this.Deed.Ownership_Type != "Other")
			{
				this.rtbOtherDesc.Visible = false;
				this.lblOtherDesc.Visible = false;
				this.rtbOtherDesc.Text = "";
			}
			else
			{
				this.rtbOtherDesc.Visible = true;
				this.lblOtherDesc.Visible = true;
			}
		}

		private void rdtpDated_ValueChanged(object sender, EventArgs e)
		{
			DateTime? nullable;
			AbstractMaker.Model.Deed deed = this.Deed;
			if (this.rdtpDated.Value > DateTime.Parse("1/1/1900"))
			{
				nullable = new DateTime?(this.rdtpDated.Value);
			}
			else
			{
				nullable = null;
			}
			deed.Date = nullable;
		}

		private void rdtpRecorded_ValueChanged(object sender, EventArgs e)
		{
			DateTime? nullable;
			AbstractMaker.Model.Deed deed = this.Deed;
			if (this.rdtpRecorded.Value > DateTime.Parse("1/1/1900"))
			{
				nullable = new DateTime?(this.rdtpRecorded.Value);
			}
			else
			{
				nullable = null;
			}
			deed.Recorded = nullable;
		}

		private void rtbBook_TextChanged(object sender, EventArgs e)
		{
			this.Deed.Book = this.rtbBook.Text;
		}

		private void rtbDocumentSeries_TextChanged(object sender, EventArgs e)
		{
			this.Deed.Document_Series = this.rtbDocumentInstr.Text;
		}

		private void rtbGranteeName_TextChanged(object sender, EventArgs e)
		{
			string text = this.rtbGranteeName.Text;
			if (!string.IsNullOrWhiteSpace(text))
			{
				this.Deed.Grantee_Name = text;
				this.UpdateHeading(this.Deed);
			}
		}

		private void rtbGrantorName_TextChanged(object sender, EventArgs e)
		{
			this.Deed.Grantor_Name = this.rtbGrantorName.Text;
		}

		private void RtbOtherDesc_TextChanged(object sender, EventArgs e)
		{
			this.Deed.Other_Ownership_Type = this.rtbOtherDesc.Text;
		}

		private void rtbPage_TextChanged(object sender, EventArgs e)
		{
			this.Deed.Page = this.rtbPage.Text;
		}

		private void UpdateHeading(AbstractMaker.Model.Deed deed)
		{
			RadPageViewPage parent = base.Parent as RadPageViewPage;
			if (parent != null)
			{
				string granteeName = deed.Grantee_Name;
				if (this.Deed.ID > 0)
				{
					string str = deed.Grantee_Name;
					granteeName = (str.Length > 20 ? string.Concat(str.Substring(0, 20), "...") : str);
				}
				parent.Text = granteeName;
				parent.Refresh();
				RadPageView radPageView = parent.Parent as RadPageView;
				if (radPageView != null)
				{
					(radPageView.ViewElement as RadPageViewNavigationViewElement).HeaderElement.Text = granteeName;
				}
				this.Refresh();
			}
		}

		private void UpdateUIToReflectModel()
		{
			DateTime? date;
			decimal? nullable;
			DateTime value;
			DateTime dateTime;
			this.rtbGranteeName.Text = this.Deed.Grantee_Name ?? "";
			this.rtbGrantorName.Text = this.Deed.Grantor_Name ?? "";
			if (!string.IsNullOrWhiteSpace(this.Deed.Ownership_Type))
			{
				this.rddlOwnershipType.SelectedValue = this.Deed.Ownership_Type;
			}
			this.Deed.Ownership_Type = this.rddlOwnershipType.SelectedValue.ToString();
			this.rtbOtherDesc.Text = this.Deed.Other_Ownership_Type ?? "";
			RadMaskedEditBox radMaskedEditBox = this.mebConsideration;
			decimal? consideration = this.Deed.Consideration;
			if (consideration.HasValue)
			{
				consideration = this.Deed.Consideration;
				nullable = new decimal?(consideration.Value);
			}
			else
			{
				consideration = null;
				nullable = consideration;
			}
			radMaskedEditBox.Value = nullable;
			RadDateTimePicker radDateTimePicker = this.rdtpDated;
			if (this.Deed.Date.HasValue)
			{
				date = this.Deed.Date;
				value = date.Value;
			}
			else
			{
				value = DateTime.Parse("1/1/1900");
			}
			radDateTimePicker.Value = value;
			RadDateTimePicker radDateTimePicker1 = this.rdtpRecorded;
			if (this.Deed.Recorded.HasValue)
			{
				date = this.Deed.Recorded;
				dateTime = date.Value;
			}
			else
			{
				dateTime = DateTime.Parse("1/1/1900");
			}
			radDateTimePicker1.Value = dateTime;
			this.rtbBook.Text = this.Deed.Book ?? "";
			this.rtbPage.Text = this.Deed.Page ?? "";
			this.rtbDocumentInstr.Text = this.Deed.Document_Series ?? "";
			this.ID.Value = this.Deed.ID;
			this.UpdateHeading(this.Deed);
		}
	}
}
