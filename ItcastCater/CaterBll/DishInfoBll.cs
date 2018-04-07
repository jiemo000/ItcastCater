using CaterDal;
using CaterModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaterBll
{
    public partial class DishInfoBll
    {
        DishInfoDal didal = new DishInfoDal();

        public List<DishInfo> GetList(Dictionary<string,string> dic)
        {
            return didal.Getlist(dic);
        }

        public bool Delete(DishInfo di)
        {
            return didal.Delete(di) > 0;
        }

        public bool Insert(DishInfo di)
        {
            return didal.Insert(di) > 0;
        }
    }
}
