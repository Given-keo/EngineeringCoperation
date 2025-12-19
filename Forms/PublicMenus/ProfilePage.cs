using EngineeringCoperation.Data;
using EngineeringCoperation.Models;
using EngineeringCoperation.Services;

namespace EngineeringCoperation.Forms.PublicMenus
{
    public partial class ProfilePage : UserControl
    {
        Member? loggedMember;
        public ProfilePage(Member? member)
        {
            loggedMember = member;
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void ProfilePage_Load(object sender, EventArgs e)
        {
            labelMemberId.Text = loggedMember.MemberId;
            labelJoinDate.Text = loggedMember.JoinDate.ToString("f");
            textAddress.Text = loggedMember.Address;
            textCardId.Text = loggedMember.IdCard;
            textEmail.Text = loggedMember.Email;
            textFullname.Text = loggedMember.FullName;
            textPhone.Text = loggedMember.Phone;
            textPhoneAlt.Text = loggedMember.PhoneAlt;

            LoadAccessList();
        }

        private void LoadAccessList()
        {
            AppDbContext db = new AppDbContext();
            AccessService accessService = new AccessService(db);
            Access? access = accessService.findByMember(loggedMember.Id);
            if (access != null)
            {
                string[] accessList = access.AccessList.Split(",");
                for (int i = 0; i < accessList.Length; i++)
                {
                    if (accessList[i].Trim() == "Grant All")
                        listBoxAccess.SetItemChecked(0, true);
                    if (accessList[i].Trim() == "Loan")
                        listBoxAccess.SetItemChecked(1, true);
                    if (accessList[i].Trim() == "Saving")
                        listBoxAccess.SetItemChecked(2, true);
                    if (accessList[i].Trim() == "Transfer - Inhouse")
                        listBoxAccess.SetItemChecked(3, true);
                    if (accessList[i].Trim() == "Transfer - Accross")
                        listBoxAccess.SetItemChecked(4, true);
                    if (accessList[i].Trim() == "Exchange")
                        listBoxAccess.SetItemChecked(5, true);
                }
            }
        }
    }
}
