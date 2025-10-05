using AbstractMaker.Model;
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


namespace AbstractMaker.Main
{
	public partial class BuildTitleAbstract : Form
	{
		public BuildTitleAbstract()
		{
			InitializeComponent();
		//	InitializeTitleAbstract();
		}

		public BuildTitleAbstract(int titleAbstractID)
		{
			InitializeComponent();
			TitleAbstractID = titleAbstractID;
			InitializeTitleAbstract();
        }
		private void InitializeTitleAbstract()
		{
			BusinessAPICalls bac = new BusinessAPICalls();
			TITLE_ABSTRACT = bac.GetAbstractByID(TitleAbstractID);
			TITLE_CHAIN = bac.GetDeedsForAbstract(TitleAbstractID);
			LEGAL_DESCRIPTION = bac.GetAbstractLegalDescription(TitleAbstractID);
            _ucChainOfTitle.SetDeeds(TITLE_CHAIN);
			_ucLegalDescription.SetLegalDescription(LEGAL_DESCRIPTION);
            tbOrderNo.Text = TITLE_ABSTRACT.OrderNo;
			tbFullAddress.Text = TITLE_ABSTRACT.Property.FullAddress;
        }

		private void btnSaveFormData_Click(object sender, EventArgs e) 
		{
			BusinessAPICalls bac = new BusinessAPICalls();
            TITLE_CHAIN = _ucChainOfTitle.GetDeeds();
			LEGAL_DESCRIPTION = _ucLegalDescription.GetLegalDescription();
			bac.SaveTitleAbstract(TITLE_ABSTRACT);
			bac.SaveDeedsForAbstract(TITLE_ABSTRACT.TitleAbstractID, TITLE_CHAIN);
			bac.SaveAbstractLegalDescription(LEGAL_DESCRIPTION, TITLE_ABSTRACT.TitleAbstractID);
        }

		private void LoadData()
		{

		}
	}
}
