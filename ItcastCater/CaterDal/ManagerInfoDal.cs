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
        /// <returns>数据集合</returns>
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
                //new SQLiteParameter("@pwd",Md5Helper.EncryptString(mi.MPwd)),
                new SQLiteParameter("@pwd",mi.MPwd),
                new SQLiteParameter("@type",mi.MType)
            };
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }
        
        /// <summary>
        /// 修改,更新数据
        /// </summary>
        /// <param name="mi">ManagerInfo类型</param>
        /// <returns>受影响行数</returns>
        public int Update(ManagerInfo mi)
        {
            string sql = "UPDATE ManagerInfo SET MNam = @name,MPwd = @pwd,MType = @type WHERE MId = @id";
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@name",mi.MNam),
                new SQLiteParameter("@pwd",mi.MPwd),
                new SQLiteParameter("@type",mi.MType),
                new SQLiteParameter("@id",mi.MId)
            };

            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }

        /// <summary>
        /// 删除一行数据,
        /// </summary>
        /// <param name="mi">ManagerInfo类型</param>
        /// <returns>受影响行数</returns>
        public int Delete(ManagerInfo mi)
        {
            string sql = "DELETE FROM ManagerInfo WHERE MId =@id";
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@id",mi.MId)
            };
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }


        public string GetRowInfo(string name,out int type)
        { 
            //确定查询语
            string sql = "SELECT MPwd,MType FROM ManagerInfo WHERE MNam =@name";
            SQLiteParameter ps = new SQLiteParameter("@name", name);

            //利用sqlitehelper拿到DataTable类型的数据集;
            DataTable dt = SqliteHelper.GetDataTable(sql,ps);

            if (dt.Rows.Count > 0)//确认dt.rows是否为空,
            {
                type = Convert.ToInt32(dt.Rows[0][1]);
                return dt.Rows[0][0].ToString();
            }
            else
            {
                type = 0;
                return null;
            }
        }

    }
}
