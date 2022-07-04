using BusinessObject;
using DataAccess.MemberRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    //Tran The Quang
    public partial class frmMemberDetail : Form
    {
        MemberRepository repository;
        public bool flag;
        public MemberObject member;
        Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        public frmMemberDetail()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void frmMemberDetail_Load(object sender, EventArgs e)
        {
            repository = new MemberRepository();
            if (flag == true)
            {
                txtMemberID.Text = member.MemberID.ToString();
                txtMemberName.Text = member.MemberName;
                txtEmail.Text = member.Email;
                txtPassword.Text = member.Password;
                txtCity.Text = member.City;
                txtCountry.Text = member.Country;
            } else
            {
                txtMemberID.Text = "Member ID is auto-generated";
                txtMemberName.Text = String.Empty;
                this.txtEmail.ReadOnly = false;
                txtEmail.Text = String.Empty;
                txtPassword.Text = String.Empty;
                txtCity.Text = String.Empty;
                txtCountry.Text = String.Empty;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                member = new MemberObject();

                if (txtMemberName.Text.Trim().Equals("")) throw new Exception("Name cannot be empty!");
                if (txtEmail.Text.Trim().Equals("")) throw new Exception("Email cannot be empty!");
                if (!emailRegex.IsMatch(txtEmail.Text.Trim())) throw new Exception("Email must match the Regular Expression: example@examle.example");
                if (txtPassword.Text.Trim().Length < 6) throw new Exception("Password must be 6 character or more");
                if (txtCity.Text.Trim().Equals("")) throw new Exception("City cannot be empty!");
                if (txtCountry.Text.Trim().Equals("")) throw new Exception("Country cannot be empty!");

                if (flag)
                {
                    member.MemberID = int.Parse(txtMemberID.Text);
                }
                else
                {
                    member.MemberID = 0;
                }

                member.MemberName = txtMemberName.Text;
                member.Email = txtEmail.Text;
                member.Password = txtPassword.Text;
                member.City = txtCity.Text;
                member.Country = txtCountry.Text;

                if (flag)
                {
                    repository.Update(member);
                    MessageBox.Show("Your Information has been updated successfully");
                    frmMemberDetail_Load(sender, e);
                }
                else
                {
                    repository.Create(member);
                    this.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
