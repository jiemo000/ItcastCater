using CaterDal;
using CaterModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaterBll
{
    public partial class ManagerInfoBll
    {
        ManagerInfoDal MIDal = new ManagerInfoDal();

        public List<ManagerInfo> GetList()
        {
            
            return MIDal.GetList();
        }

        public bool Insert(ManagerInfo mi)
        {
            return MIDal.Insert(mi) > 0;
        }

    }
}
