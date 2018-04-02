using CaterDal;
using CaterModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaterBll
{
    public partial class MenberTypeInfoBll
    {
        MemberTypeInfoDal MTIdal = new MemberTypeInfoDal();

        public List<MemberTypeInfo> GetList()
        {
            return MTIdal.GetList();
        }

        public bool Insert(MemberTypeInfo mti)
        {
            return MTIdal.Insert(mti) > 0;
        }

        public bool Delete(MemberTypeInfo mti)
        {
            return MTIdal.Delete(mti) > 0;
        }
    }
}
