using CaterModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaterDal
{
    public partial class DishTypeInfoDal
    {
        /// <summary>
        /// 获取结果集合
        /// </summary>
        /// <returns>数据集合</returns>
        public List<DishTypeInfo> GetList()
        {
            //确定查询语句
            string sql = "SELECT * FROM DishTypeInfo";
            //利用sqlitehelper拿到DataTable类型的数据集;
            DataTable dt = SqliteHelper.GetDataTable(sql);
            //将DataTable类型转换成list集合,返回
            List<DishTypeInfo> list = new List<DishTypeInfo>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new DishTypeInfo()
                {
                    DId = Convert.ToInt32(row["DId"]),
                    DTitle = row["DTitle"].ToString(),
                    DIsDelete = Convert.ToBoolean(row["DIsDelete"])
                });
            }
            return list;
        }

        public int Insert(DishTypeInfo dti)
        {
            string sql = "INSERT INTO DishTypeInfo(DTitle,DIsDelete) VALUES(@title,@isdelete)";
            //构造Sql语句的参数
            SQLiteParameter[] ps =
            {
                //new SQLiteParameter("@id",mti.MId),
                //new SQLiteParameter("@id",dti.DId),
                new SQLiteParameter("@title",dti.DTitle),
                new SQLiteParameter("@isdelete",dti.DIsDelete)
            };
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }

        public int Delete(DishTypeInfo dti)
        {
            string sql = "DELETE FROM DishTypeInfo WHERE DId =@id";
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@id",dti.DId)
            };
            return SqliteHelper.ExecuteNonQuery(sql, ps);

        }
    }
}
