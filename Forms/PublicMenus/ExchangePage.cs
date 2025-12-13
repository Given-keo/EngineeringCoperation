using EngineeringCoperation.Data;
using EngineeringCoperation.Models;
using EngineeringCoperation.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngineeringCoperation.Forms.PublicMenus
{
    public partial class ExchangePage : UserControl
    {
        Member loggedMember;
        public ExchangePage(Member loggedMember)
        {
            InitializeComponent();
            this.loggedMember = loggedMember;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void ExchangePage_Load(object sender, EventArgs e)
        {
            TxtAmount.Text = "0";
            AppDbContext db = new AppDbContext();
            ConfigurationService configservice = new ConfigurationService(db);
            Configuration? config = await configservice.GetConfig();
            TxtFee.Text = config != null ? config.transferAcrossFee.ToString() : "0";
            TxtRate.Text = config != null ? config.exchangeRate.ToString() : "0";
        }

        private void TxtAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal amount = Convert.ToDecimal(TxtAmount);
                decimal rate = Convert.ToDecimal(TxtRate);
                decimal fee = Convert.ToDecimal(TxtFee);
                decimal total = (amount * rate) + fee;
                TxtTotal.Text = total.ToString("0.00");
            }
            catch (Exception)
            {
                TxtTotal.Text = "0.00";
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            Exchange exchange = new Exchange
            {
                MemberId = loggedMember.Id,
                ExchangeId = Guid.NewGuid().ToString(),
                Amount = Convert.ToDecimal(TxtAmount.Text),
                Rate = Convert.ToDecimal(TxtRate.Text),
                Fee = Convert.ToDecimal(TxtFee.Text),
                AmountExchanged = Convert.ToDecimal(TxtAmount.Text) * Convert.ToDecimal(TxtRate.Text),
                ExchangeDate = DateTime.Now,
                TotalAmountExchanged = Convert.ToDecimal(TxtTotal.Text)
            };

            AppDbContext db = new AppDbContext();
            ExchangeService exchangeService = new ExchangeService(db);
            exchangeService.save(exchange);

            TxtAmount.Text = "0";

            MessageBox.Show(
                "Exchange submitted successfully!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtAmount.Text = "0";
        }

        
    }
}
