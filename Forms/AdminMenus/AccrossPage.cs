using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EngineeringCoperation.API.Connectors;
using EngineeringCoperation.API.Models;
using EngineeringCoperation.Data;
using EngineeringCoperation.Services;
using EngineeringCoperation.Models;

namespace EngineeringCoperation.Forms.AdminMenus
{
    public partial class AccrossPage : UserControl
    {
        public AccrossPage()
        {
            InitializeComponent();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void AcrossPage_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private async void LoadData()
        {
            AppDbContext appDbContext = new AppDbContext();
            ConfigurationService configurationService = new ConfigurationService(appDbContext);
            Configuration? configuration = await configurationService.GetConfig();
            String message = "";

            ConnectorGet connectorGet = new ConnectorGet();
            CoopApiResponse? coopApiResponse = await connectorGet.GetCoopAsync();
            if (coopApiResponse != null && coopApiResponse.ResponseCode == "00")
            {
                dgvCoop.Rows.Clear();
                foreach (var coop in coopApiResponse.CoopList)
                {
                    dgvCoop.Rows.Add(coop.Code, coop.Name, coop.Address);
                }
            }
            else
            {
                message = coopApiResponse != null ? coopApiResponse.ResponseCode + " - "
                    + coopApiResponse.ResponseMessage : "Did not get data";
            }

            BalanceApiResponse? balanceApiResponse = await connectorGet.GetBalancesByCoopAsync(configuration.terminologi3);
            if (balanceApiResponse != null && balanceApiResponse.ResponseCode == "00")
            {
                dgvBalance.Rows.Clear();
                foreach (var balance in balanceApiResponse.BalanceList)
                {
                    dgvBalance.Rows.Add(balance.Member.Code, balance.Member.Name, balance.Amount);
                }
            }
            else
            {
                message = balanceApiResponse != null ? balanceApiResponse.ResponseCode + " - "
                    + balanceApiResponse.ResponseMessage : "Did not get data";
            }

            TransferApiResponse? transferApiResponse = await connectorGet.GetTransfersByCoopAsync(configuration.terminologi3);
            if (transferApiResponse != null && transferApiResponse.ResponseCode == "00")
            {
                dgvTransfer.Rows.Clear();
                foreach (var transfer in transferApiResponse.TransferList)
                {
                    dgvTransfer.Rows.Add(transfer.Code, transfer.CoopCode, transfer.CodeOrigin, transfer.CodeBenef, transfer.Amount, transfer.Remarks);
                }
            }
            else
            {
                message = transferApiResponse != null ? transferApiResponse.ResponseCode + " - "
                    + transferApiResponse.ResponseMessage : "Did not get data";
            }

            if (message != "")
            {
                MessageBox.Show("Failed to load data from API.\n Error:" + message);
            }
        }

        private void dgvCoop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
