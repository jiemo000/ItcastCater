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
    public partial class MemberInfoDal
    {
        public List<MemberInfo> GetInfo(Dictionary<string, string> dic)
        {
            string sql = "SELECT MemberInfo.*,MemberTypeInfo.MTitle as MTypeTitle FROM MemberInfo inner join MemberTypeInfo on MemberInfo.MTypeID=MemberTypeInfo.MId WHERE MemberInfo.MIsDelete = 0";

            if (dic.Count > 0)
            {
                foreach (var item in dic)
                {
                    sql = sql + " and " + item.Key + " like '%"+ item.Value +"%'";
                }
            } 
            DataTable dt =SqliteHelper.GetDataTable(sql);

            List<MemberInfo> list = new List<MemberInfo>();
            foreach(DataRow row in dt.Rows)
            {
                list.Add(new MemberInfo()
                {
                    MId = Convert.ToInt32(row["MId"]),
                    MTypeId = Convert.ToInt32(row["MTypeId"]),
                    MName = row["MName"].ToString(),
                    MPhone = row["MPhone"].ToString(),
                    MMoney = Convert.ToDecimal(row["MMoney"]),
                    MIsdelete = Convert.ToBoolean(row["MIsdelete"]),
                    MTypeTitle = row["MTypeTitle"].ToString()
                });
            }

            return list;
        }

        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="mi">MemberInfo类型</param>
        /// <returns>受影响行数</returns>
        public int Insert(MemberInfo mi)
        {
            //构造Insert语句
            string sql = "INSERT INTO MemberInfo(MName,MPhone,MMoney,MTypeId,MIsdelete) VALUES(@name,@phone,@money,@typeid,@isdelete)";
            //构造Sql语句的参数
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@name",mi.MName),
                new SQLiteParameter("@phone",mi.MPhone),
                new SQLiteParameter("@money",mi.MMoney),
                new SQLiteParameter("@typeid",mi.MTypeId),
                new SQLiteParameter("@isdelete",mi.MIsdelete)
            };
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }

        public int Delete(MemberInfo mi)
        {
            string sql = "DELETE FROM MemberInfo WHERE MId =@id";
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@id",mi.MId)
            };
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }

    }
}
