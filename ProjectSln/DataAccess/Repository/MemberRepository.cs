using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MemberRepository
{
    public class MemberRepository : IMemberRepository
    {
        //Mai Quang Khai
        public void InitAdmin()
        {
            MemberObject admin = MemberDBContext.Instance.GetDefaultAdmin();
            MemberObject flag = GetByEmail(admin.Email);
            if (flag == null)
            {
                Create(admin);
            }
            else
            {

            }
        }

        private MemberObject GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        //Mai Quang Khai
        public bool Create(MemberObject mem)
        {
            try
            {
                MemberDBContext.Instance.AddMember(mem);
                Console.WriteLine("Add Member Successfully: " + mem.ToString());
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("This email has been registered to another account!");
            }
        }
        //Mai Quang Khai
        public bool Delete(int MemberID)
        {
            try
            {
                MemberDBContext.Instance.RemoveMember(MemberID);
                Console.WriteLine("Delete Member Successfully, member ID Deleted: " + MemberID);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public MemberObject Get(int MemberID)
        {
            try
            {
                MemberObject member = MemberDBContext.Instance.GetMemberByID(MemberID);
                Console.WriteLine("Get Member Successfully: " + member.ToString());
                return member;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        //Mai Quang Khai
        public bool Update(MemberObject mem)
        {
            try
            {
                MemberDBContext.Instance.UpdateMember(mem);
                Console.WriteLine("Update Successfully");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Update Failed Error: " + ex.Message);
                return false;
            }
        }
        //Truong Thanh Trung 
        public IEnumerable<MemberObject> GetMemberList()
        {
            try
            {
                IEnumerable<MemberObject> memberObjects = MemberDBContext.Instance.GetMemberLists();
                return memberObjects;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public bool Login(string Email, string Password)
        {
            throw new NotImplementedException();
        }
    }
}
