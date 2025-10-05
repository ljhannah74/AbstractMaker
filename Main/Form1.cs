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
	public partial class Form1 : Form
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
            PopulateBusinessProducts();
            PopulateCustomerAccounts();
            RefreshOrderTabData();
        }
        private void PopulateBusinessProducts()
        {
            try
            {
                BusinessAPICalls bac = new BusinessAPICalls();
                List<ProductType> productTypes = bac.GetAllProductTypes();

                // Debug: Check if productTypes is empty
                if (productTypes == null || productTypes.Count == 0)
                {
                    MessageBox.Show("No product types found.");
                    return;
                }

                cddBusinessProducts.Items.Clear();
                foreach (var pt in productTypes)
                {
                    cddBusinessProducts.Items.Add(pt.ProductTypeName);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error loading product types: " + ex.Message);
            }
        }
        private void PopulateCustomerAccounts()
        {
            try
            {
                BusinessAPICalls bac = new BusinessAPICalls();
                List<Client> clients = bac.GetAllClients();
                // Debug: Check if clients is empty
                if (clients == null || clients.Count == 0)
                {
                    MessageBox.Show("No clients found.");
                    return;
                }
                cddCustomerAccounts.Items.Clear();
                foreach (var client in clients)
                {
                    cddCustomerAccounts.Items.Add(client.ClientName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading clients: " + ex.Message);
            }
        }
        private void RefreshOrderTabData()
        {
            BusinessAPICalls bac = new BusinessAPICalls();

            List<TitleAbstract> titleAbstracts = bac.GetAllAbstracts();
            List<TitleAbstractDTO> displayList = titleAbstracts.Select(ta => new TitleAbstractDTO
            {
                TitleAbstractID = ta.TitleAbstractID,
                OrderNo = ta.OrderNo,
                SearchDate = ta.SearchDate,
                EffectiveDate = ta.EffectiveDate,
                ClientName = ta.Client.ClientName,
                ClientRefNo = ta.ClientRefNo,
                PropertyAddress = ta.Property.Address,
                ProductTypeName = ta.ProductType.ProductTypeName,
            }).ToList();
            this.MasterTemplate.DataSource = displayList;
        }

        private void btnRefreshOrderList_Click(object sender, EventArgs e) => this.RefreshOrderTabData();

        private void MasterTemplate_DoubleClick(object sender, EventArgs e)
        {
            if (this.MasterTemplate.CurrentRow != null && this.MasterTemplate.CurrentRow.DataBoundItem is TitleAbstractDTO dataBoundItem)
            {
                BuildTitleAbstract buildtitleAbstract = new BuildTitleAbstract(dataBoundItem.TitleAbstractID);
                buildtitleAbstract.Show();
            }
        }

        private void btnCreateNewOrder_Click(object sender, EventArgs e)
        {
            BuildTitleAbstract buildTitleAbstract = new BuildTitleAbstract();
            buildTitleAbstract.Show();
        }
    }
}
