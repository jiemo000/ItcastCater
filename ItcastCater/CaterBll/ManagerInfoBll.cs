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
        public List<ManagerInfo> GetList()
        {
            ManagerInfoDal MIDal = new ManagerInfoDal();
            return MIDal.GetList();
        }

    }
}
