
using CaterBll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaterUI
{
    public partial class 登录界面 : Form
    {
        public 登录界面()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 退出,关闭整个应用程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_退出_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_登录_Click(object sender, EventArgs e)
        {
            if(textBox_用户名.Text != "" && textBox_密码.Text != "")
            {
                #region 查询并验证
                ManagerInfoBll MIBll = new ManagerInfoBll();
                if(MIBll.GetRowInfo(textBox_用户名.Text,textBox_密码.Text))
                {
                    //密码正确
                    MessageBox.Show("密码正确");
                }
                else
                {
                    MessageBox.Show("密码不正确");
                    label_密码错误提示.Text = "密码错误,剩余3次";
                }

                #endregion
            }
            else
            {
                MessageBox.Show("用户名和密码不能为空");
            }
        }
    }
}
