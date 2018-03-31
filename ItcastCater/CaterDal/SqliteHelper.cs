using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaterDal
{
    public static class SqliteHelper
    {
        /// <summary>
        /// 从配置文本中读取连接字符串
        /// </summary>
        private static string connStr = ConfigurationManager.ConnectionStrings["itcastCater"].ConnectionString;

       
        /// <summary>
        /// 执行命令的方法：insert,update,delete
        /// </summary>
        /// <param name="sql">Sql语句</param>
        /// <param name="ps">可变参数，目的是省略了手动构造数组的过程，直接指定对象，编译器会帮助我们构造数组，并将对象加入数组中，传递过来</param>
        /// <returns>受影响的行数</returns>
        public static int ExecuteNonQuery(string sql,params SQLiteParameter[] ps)
        {
            //创建连接对象
            using (SQLiteConnection conn=new SQLiteConnection(connStr))
            {
                //创建命令对象
                SQLiteCommand cmd=new SQLiteCommand(sql,conn);
                //添加参数
                cmd.Parameters.AddRange(ps);
                //打开连接
                conn.Open();
                //执行命令，并返回受影响的行数
                return cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 查询,获取首行首列值的方法
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="ps">可变参数，目的是省略了手动构造数组的过程，直接指定对象，编译器会帮助我们构造数组，并将对象加入数组中，传递过来</param>
        /// <returns>首行首列</returns>
        public static object ExecuteScalar(string sql, params SQLiteParameter[] ps)
        {
            using (SQLiteConnection conn=new SQLiteConnection(connStr))
            {
                SQLiteCommand cmd=new SQLiteCommand(sql,conn);
                cmd.Parameters.AddRange(ps);

                conn.Open();
                //执行命令，获取查询结果中的首行首列的值，返回
                return cmd.ExecuteScalar();
            }
        }

        /// <summary>
        /// 查询,获取结果集
        /// </summary>
        /// <param name="sql">Sql语句</param>
        /// <param name="ps">可变参数，目的是省略了手动构造数组的过程，直接指定对象，编译器会帮助我们构造数组，并将对象加入数组中，传递过来</param>
        /// <returns>整个数据集合</returns>
        public static DataTable GetDataTable(string sql,params SQLiteParameter[] ps)
        {
            using (SQLiteConnection conn=new SQLiteConnection(connStr))
            {
                //构造适配器对象
                SQLiteDataAdapter adapter=new SQLiteDataAdapter(sql,conn);
                //构造数据表，用于接收查询结果
                DataTable dt=new DataTable();
                //添加参数
                adapter.SelectCommand.Parameters.AddRange(ps);
                //执行结果
                adapter.Fill(dt);
                //返回结果集
                return dt;
            }
        }
    }
}
