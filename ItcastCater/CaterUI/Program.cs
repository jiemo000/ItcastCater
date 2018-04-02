using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaterUI
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new 登录界面()); //程序运行时,显示界面
            //Application.Run(new 主界面());
            //Application.Run(店员界面.Cteate());
            Application.Run(new 会员类型界面());
        }
    }
}
