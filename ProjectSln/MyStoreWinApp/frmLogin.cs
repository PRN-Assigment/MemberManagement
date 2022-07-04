using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.MemberRepository;
using DataAccess;
using BusinessObject;

namespace MyStoreWinApp
{
    //Tran The Quang
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {   
            
            try
            {
               
                
                BaseDAL baseDAL = new BaseDAL();
                String email = txtEmail.Text.Trim();
                String password = txtPassword.Text.Trim();
                MemberRepository memberRepository = new MemberRepository();
                bool checkLogin = memberRepository.Login(email, password);

                if (checkLogin != false)
                {
                    frmMemberList frmMemberList = new frmMemberList();
                    MemberObject admin = MemberDBContext.Instance.GetDefaultAdmin();
                    if(email.Equals(admin.Email))
                    {
                        frmMemberList.ShowDialog();
                    } else
                    {
                        MemberObject member = memberRepository.GetByEmail(email);
                        frmMemberDetail frmMemberDetail = new frmMemberDetail { flag = true, member = member};
                        frmMemberDetail.ShowDialog();
                    }
                    this.Close();
                } else
                {
                    throw new Exception("Incorrect Email or Password");
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Error");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
