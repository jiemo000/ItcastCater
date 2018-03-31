using CaterCommon;
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
    public partial class ManagerInfoDal
    {
        /// <summary>
        /// 获取结果集合
        /// </summary>
        /// <returns>sql语句</returns>
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

        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="mi">ManagerInfo类型</param>
        /// <returns>受影响行数</returns>
        public int Insert(ManagerInfo mi)
        {
            //构造Insert语句
            string sql = "INSERT INTO ManagerInfo(MNam,MPwd,MType) VALUES(@name,@pwd,@type)";
            //构造Sql语句的参数
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@name",mi.MNam),
                new SQLiteParameter("@pwd",Md5Helper.EncryptString(mi.MPwd)),  
                new SQLiteParameter("@type",mi.MType)
            };
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }

        
    }
}
