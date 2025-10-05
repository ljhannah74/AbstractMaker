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
	public partial class ucChainOfTitle : UserControl
	{
		public ucChainOfTitle(List<Deed> title_Chain, bool pbTitleChain)
		{
			this.InitializeComponent();
			this.Title_Chain = title_Chain;
			this.PB_Title_Chain = pbTitleChain;
			this.UpdateUIToReflectModel();
			((RadPageViewNavigationViewElement)this.pgGrantees.ViewElement).DisplayMode = NavigationViewDisplayModes.Expanded;
			((RadPageViewNavigationViewElement)this.pgGrantees.ViewElement).HamburgerButton.Enabled = false;
			((RadPageViewNavigationViewElement)this.pgGrantees.ViewElement).Expand();
			this.pgGrantees.PageIndexChanged += new EventHandler<RadPageViewIndexChangedEventArgs>(this.PgGrantees_PageIndexChanged);
		}

		private void btnAddGrantee_Click(object sender, EventArgs e)
		{
			Deed deed = new Deed()
			{
				Grantee_Name = this.rtbGranteeName.Text
			};
			this.Title_Chain.Add(deed);
			ucChainOfTitleGrantee _ucChainOfTitleGrantee = new ucChainOfTitleGrantee(deed);
			RadPageViewPage radPageViewPage = new RadPageViewPage(this.rtbGranteeName.Text)
			{
				Dock = DockStyle.Fill
			};
			radPageViewPage.Controls.Add(_ucChainOfTitleGrantee);
			this.pgGrantees.Pages.Add(radPageViewPage);
			this.pgGrantees.SelectedPage = radPageViewPage;
			this.rtbGranteeName.Text = "";
			this.ReindexGrantees();
		}

		private void btnRemoveGrantee_Click(object sender, EventArgs e)
		{
			if (this.pgGrantees.Pages.Count != 0)
			{
				RadPageViewPage selectedPage = this.pgGrantees.SelectedPage;
				ucChainOfTitleGrantee item = selectedPage.Controls[0] as ucChainOfTitleGrantee;
				this.Title_Chain.Remove(item.Deed);
				this.pgGrantees.Pages.Remove(selectedPage);
				this.ReindexGrantees();
			}
		}
		public ucChainOfTitle()
		{
			InitializeComponent();
			this.Title_Chain = new List<Deed>();
		}


		private void PgGrantees_PageIndexChanged(object sender, RadPageViewIndexChangedEventArgs e)
		{
			this.ReindexGrantees();
		}

		private void ReindexGrantees()
		{
			foreach (RadPageViewPage page in this.pgGrantees.Pages)
			{
				(page.Controls[0] as ucChainOfTitleGrantee).ID.Value = this.pgGrantees.Pages.IndexOf(page) + 1;
			}
		}

		private void UpdateUIToReflectModel()
		{
			foreach (Deed titleChain in this.Title_Chain)
			{
				string granteeName = titleChain.Grantee_Name;
				granteeName = (granteeName.Length > 20 ? string.Concat(granteeName.Substring(0, 20), "...") : granteeName);
				ucChainOfTitleGrantee _ucChainOfTitleGrantee = new ucChainOfTitleGrantee(titleChain);
				RadPageViewPage radPageViewPage = new RadPageViewPage(granteeName)
				{
					Dock = DockStyle.Fill
				};
				radPageViewPage.Controls.Add(_ucChainOfTitleGrantee);
				this.pgGrantees.Pages.Add(radPageViewPage);
			}
			this.ReindexGrantees();
		}

		public void SetDeeds(List<Deed> deeds)
		{
			this.Title_Chain = deeds;
			UpdateUIToReflectModel();
        }

		public List<Deed> GetDeeds()
		{
			return this.Title_Chain;
		}
    }
}
