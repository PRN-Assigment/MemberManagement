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
            if (Email == null || Password == null)
            {
                return false;
            }
            else
            {
                return MemberDBContext.Instance.Login(Email, Password);
            }
        }


        //Nguyen Tan Trung
        public MemberObject GetByEmail(string email)
        {
            MemberObject mem = new MemberObject();
            mem = MemberDBContext.Instance.GetMemberByEmail(email);
            return mem;
        }
        //Nguyen Tan Trung
        public List<MemberObject> SearchByName(string name)
        {
            List<MemberObject> result = new List<MemberObject>();
            result = MemberDBContext.Instance.GetMemberByName(name);
            return result;
        }
        //Nguyen Tan Trung
        public List<MemberObject> SearchByCity(string city)
        {
            List<MemberObject> result = new List<MemberObject>();
            result = MemberDBContext.Instance.GetMemberByCity(city);
            return result;
        }
        //Nguyen Tan Trung
        public List<MemberObject> SearchByCountry(string country)
        {
            List<MemberObject> result = new List<MemberObject>();
            result = MemberDBContext.Instance.GetMemberByCountry(country);
            return result;
        }
    }
}
