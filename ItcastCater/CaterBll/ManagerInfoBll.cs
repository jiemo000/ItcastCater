using CaterDal;
using CaterModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaterBll
{
    public partial class ManagerInfoBll
    {
        /// <summary>
        /// 实例化 DAL数据层
        /// </summary>
        ManagerInfoDal MIDal = new ManagerInfoDal();

        /// <summary>
        /// BLL层,获取数据集合
        /// </summary>
        /// <returns></returns>
        public List<ManagerInfo> GetList()
        { 
            return MIDal.GetList();
        }

        /// <summary>
        /// BLL层,插入数据
        /// </summary>
        /// <param name="mi"></param>
        /// <returns></returns>
        public bool Insert(ManagerInfo mi)
        {
            return MIDal.Insert(mi) > 0;
        }

        /// <summary>
        /// BLL层,修改,更新数据
        /// </summary>
        /// <param name="mi"></param>
        /// <returns></returns>
        public bool Update(ManagerInfo mi)
        {
            return MIDal.Update(mi) > 0;
        }

        /// <summary>
        /// BLL层,删除一行数据,
        /// </summary>
        /// <param name="mi"></param>
        /// <returns></returns>
        public bool Delete(ManagerInfo mi)
        {
            return MIDal.Delete(mi) > 0;
        }

        public int GetRowInfo(string name,string pwd)
        {
            if(MIDal.GetRowInfo(name) == null)
            {
                return 0;//账号不正确
            }
            else
            {
                if(MIDal.GetRowInfo(name).ToString() == pwd)
                {
                    return 1;//账号密码正确,允许登录
                }
                else
                {
                    return 2;//密码错误
                }
            }
        }

    }
}
