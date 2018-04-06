using CaterDal;
using CaterModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaterBll
{
    public partial class MemberInfoBll
    {
        MemberInfoDal mid = new MemberInfoDal();

        public List<MemberInfo> GetInfo(Dictionary<string,string> dic)
        {
            return mid.GetInfo(dic);
        }

        public bool Insert(MemberInfo mi)
        {
            return mid.Insert(mi) > 0;
        }

        public bool Delete(MemberInfo mi)
        {
            return mid.Delete(mi) > 0;
        }
    }
}
