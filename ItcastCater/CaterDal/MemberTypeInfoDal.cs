using CaterModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaterDal
{
    public partial class MemberTypeInfoDal
    {
        /// <summary>
        /// 获取结果集合
        /// </summary>
        /// <returns>数据集合</returns>
        public List<MemberTypeInfo> GetList()
        {
            //确定查询语句
            string sql = "SELECT * FROM MemberTypeInfo";
            //利用sqlitehelper拿到DataTable类型的数据集;
            DataTable dt = SqliteHelper.GetDataTable(sql);
            //将DataTable类型转换成list集合,返回
            List<MemberTypeInfo> list = new List<MemberTypeInfo>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new MemberTypeInfo()
                {
                    MId = Convert.ToInt32(row["Mid"]),
                    MTitle = row["MTitle"].ToString(),
                    MDiscount =Convert.ToDecimal(row["MDiscount"]),
                    MIsdelete = Convert.ToBoolean(row["MIsdelete"])

                });
            }
            return list;
        }
    }
}
