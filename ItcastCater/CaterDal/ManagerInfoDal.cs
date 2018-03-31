using CaterModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace CaterDal
{
    public partial class ManagerInfoDal
    {
        public List<ManagerInfo> GetList()
        {
            //确定查询语句
            string sql = "SELECT * FROM ManagerInfo";
            //利用sqlitehelper拿到DataTable类型的数据集;
            DataTable dt = SqliteHelper.GetDataTable(sql);
            //将DataTable类型转换成list集合,返回
            List<ManagerInfo> list = new List<ManagerInfo>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new ManagerInfo()
                {
                    MId = Convert.ToInt32(row["Mid"]),
                    MNam = row["MNam"].ToString(),
                    MPwd = row["MPwd"].ToString(),
                    MType = Convert.ToInt32(row["MType"])

                });
            }
            return list;
        }
    }
}
