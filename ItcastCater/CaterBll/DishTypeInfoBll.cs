using CaterDal;
using CaterModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaterBll
{
    public partial class DishTypeInfoBll
    {
        DishTypeInfoDal dtidal = new DishTypeInfoDal();

        public List<DishTypeInfo> GetList()
        {
            return dtidal.GetList();
        }

        public bool Insert(DishTypeInfo dti)
        {
            return dtidal.Insert(dti) > 0;
        }

        public bool Delete(DishTypeInfo dti)
        {
            return dtidal.Delete(dti) > 0;
        }
    }
}
