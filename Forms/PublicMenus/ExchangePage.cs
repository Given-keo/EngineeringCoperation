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

namespace EngineeringCoperation.Forms.MemberMenus
{
    public partial class ExchangePage : UserControl
    {
        Member loggedMember;
        public ExchangePage(Member member)
        {
            loggedMember = member;
            InitializeComponent();
        }

        private async void ExchangePage_Load(object sender, EventArgs e)
        {
            txtAmount.Text = "0";
            AppDbContext db = new AppDbContext();
            ConfigurationService configService = new ConfigurationService(db);
            Configuration? config = await configService.GetConfig();
            txtFee.Text = config != null ? config.transferAcrossFee.ToString() : "0";
            txtRate.Text = config != null ? config.exchangeRate.ToString() : "0";
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal amount = Convert.ToDecimal(txtAmount.Text);
                decimal rate = Convert.ToDecimal(txtRate.Text);
                decimal fee = Convert.ToDecimal(txtFee.Text);
                decimal total = (amount * rate) + fee;
                txtTotal.Text = total.ToString("0.00");
            }
            catch (Exception)
            {
                txtTotal.Text = "0.00";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Exchange exchange = new Exchange
            {
                MemberId = loggedMember.Id,
                ExchangeId = Guid.NewGuid().ToString(),
                Amount = Convert.ToDecimal(txtAmount.Text),
                Rate = Convert.ToDecimal(txtRate.Text),
                Fee = Convert.ToDecimal(txtFee.Text),
                AmountExchanged = Convert.ToDecimal(txtAmount.Text) * Convert.ToDecimal(txtRate.Text),
                ExchangeDate = DateTime.Now,
                TotalAmountExchanged = Convert.ToDecimal(txtTotal.Text)
            };
            AppDbContext db = new AppDbContext();
            ExchangeService exchangeService = new ExchangeService(db);
            exchangeService.save(exchange);
            txtAmount.Text = "0";
            MessageBox.Show("Exchange submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAmount.Text = "0";
        }
    }
}
