using CaterModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace CaterDal
{
    public partial class DishInfoDal
    {
        public List<DishInfo> Getlist(Dictionary<string,string> dic)
        {
            string sql = "SELECT DishInfo.*,DishTypeInfo.DTitle AS DTypeTitle FROM DishInfo INNER JOIN DishTypeInfo ON DishInfo.DTypeId=DishTypeInfo.DId WHERE DishInfo.DIsDelete = 0";
            if (dic.Count > 0)
            {
                foreach (var item in dic)
                {
                    sql = sql + " AND " + item.Key + " LIKE '%" + item.Value + "%'";
                }
            }
            List<DishInfo> list = new List<DishInfo>();
            DataTable dt = SqliteHelper.GetDataTable(sql);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new DishInfo()
                {
                    DId = Convert.ToInt32(row["DId"]),
                    DTitle = row["DTitle"].ToString(),
                    DChar = row["DChar"].ToString(),
                    DPrice = Convert.ToDecimal(row["DPrice"]),
                    DIsDelete = Convert.ToBoolean(row["DIsDelete"]),
                    DTypeId = Convert.ToInt32(row["DTypeId"]),
                    DTypeTitle = row["DTypeTitle"].ToString()
                });
            }
            return list;
        }

        public int Delete(DishInfo di)
        {
            string sql = "DELETE FROM DishInfo WHERE DId =@id";
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@id",di.DId)
            };
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }

        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="mi">DishInfo</param>
        /// <returns>受影响行数</returns>
        public int Insert(DishInfo di)
        {
            //构造Insert语句
            string sql = "INSERT INTO DishInfo(DTitle,DTypeId,DPrice,DChar,DIsDelete) VALUES(@title,@typeid,@price,@char,@isdelete)";
            //构造Sql语句的参数
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@title",di.DTitle),
                new SQLiteParameter("@price",di.DPrice),
                new SQLiteParameter("@char",di.DChar),
                new SQLiteParameter("@typeid",di.DTypeId),
                new SQLiteParameter("@isdelete",di.DIsDelete)
            };
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }

    }
}
