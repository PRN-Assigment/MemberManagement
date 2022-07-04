using BusinessObject;
using DataAccess;
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
    //Nguyen Thanh Ha
    public partial class frmMemberList : Form
    {
        BindingSource source;
        MemberRepository repository = new MemberRepository();
        Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        public frmMemberList()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void frmMemberList_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMemberList(repository.GetMemberList().ToList());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMemberDetail frmMember = new frmMemberDetail
            {
                flag = false          
            };
            frmMember.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            repository = new MemberRepository();
            
             try
            {
                MemberObject target = GetMemberObject();
                repository.Delete(target.MemberID);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LoadMemberList(repository.GetMemberList().ToList());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            repository = new MemberRepository();
            
            try
            {
                if (txtMemberName.Text.Trim().Equals("")) throw new Exception("Name cannot be empty!");
                if (txtEmail.Text.Trim().Equals("")) throw new Exception("Email cannot be empty!");
                if (!emailRegex.IsMatch(txtEmail.Text.Trim())) throw new Exception("Email must match the Regular Expression: example@examle.example");
                if (txtCity.Text.Trim().Equals("")) throw new Exception("City cannot be empty!");
                if (txtCountry.Text.Trim().Equals("")) throw new Exception("Country cannot be empty!");

                MemberObject member = GetMemberObject();
                repository.Update(member);

                LoadMemberList(repository.GetMemberList().ToList());
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        

        private void LoadMemberList(List<MemberObject> list)
        {
            try
            {
                
                source = new BindingSource();
                source.DataSource = list;

                txtMemberName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();
                txtMemberID.DataBindings.Clear();

                txtMemberName.DataBindings.Add("Text", source, "MemberName");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");
                txtMemberID.DataBindings.Add("Text", source, "MemberID");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;


                if(list.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                } else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ClearText()
        {
            txtMemberName.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtCity.Text = String.Empty;
            txtCountry.Text = String.Empty;
        }

        private MemberObject GetMemberObject()
        {
            MemberObject result = new MemberObject();
            try
            {
                result = new MemberObject
                {
                    MemberID = int.Parse(txtMemberID.Text),
                    MemberName = txtMemberName.Text,
                    Email = txtEmail.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text
                };

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            List<MemberObject> list = new List<MemberObject>();
            list = repository.GetMemberList().ToList();
            list.Sort();
            LoadMemberList(list);
        }

        private void btnSearchByCity_Click(object sender, EventArgs e)
        {
            string search = txtSearchCity.Text;
            repository = new MemberRepository();
            List<MemberObject> members = new List<MemberObject>();
            members = repository.SearchByCity(search);
            if (members.Count == 0)
            {
                MessageBox.Show("No Result Found");
                return;
            }
            else
            {
                LoadMemberList(members);
            }
        }

        private void btnSearchByCountry_Click(object sender, EventArgs e)
        {
            string search = txtSearchCountry.Text;
            repository = new MemberRepository();
            List<MemberObject> members = new List<MemberObject>();
            members = repository.SearchByCountry(search);
            if (members.Count == 0)
            {
                MessageBox.Show("No Result Found");
                return;
            }
            else
            {
                LoadMemberList(members);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            repository = new MemberRepository();
            List<MemberObject> members = new List<MemberObject>();
            members = repository.SearchByName(search);
            if (members.Count == 0)
            {
                MessageBox.Show("No Result Found");
                return;
            }
            else
            {
                LoadMemberList(members);
            }
        }
    }
}
