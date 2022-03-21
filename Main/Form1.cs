using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using AbstractMaker.Model;

namespace AbstractMaker.Main
{
	public partial class Form1 : RadForm
	{
		public Form1()
		{
			InitializeComponent();
		}
        private void menuCreateOrders_Click(object sender, EventArgs e)
        {
            /*CreateOrdersForm createOrdersForm = new CreateOrdersForm();

            int num = (int)createOrdersForm.ShowDialog((IWin32Window)this);*/

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshOrderTabData();
        }
        private void RefreshOrderTabData()
        {
            BusinessAPICalls bac = new BusinessAPICalls();

            this.MasterTemplate.DataSource = bac.GetAllAbstracts();
        }

        private void btnRefreshOrderList_Click(object sender, EventArgs e) => this.RefreshOrderTabData();

        private void MasterTemplate_DoubleClick(object sender, EventArgs e)
        {
          /*  TitleAbstract dataBoundItem = this.MasterTemplate.SelectedRows.First().DataBoundItem as TitleAbstract;
            new BuildAbstract()
            {
                OrderDetailID = dataBoundItem.TitleSearchID
            }.Show();*/
        }

        private void btnCreateNewOrder_Click(object sender, EventArgs e)
        {
            BuildTitleAbstract buildTitleAbstract = new BuildTitleAbstract();
            buildTitleAbstract.Show();
        }
    }
}
