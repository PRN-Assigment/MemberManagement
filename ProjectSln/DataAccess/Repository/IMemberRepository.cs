using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        bool Create(MemberObject mem);
        bool Update(MemberObject mem);
        bool Delete(int MemberID);
    }
}
