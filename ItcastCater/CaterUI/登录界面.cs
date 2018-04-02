
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
        /// 登录时错误验证的次数限制
        /// </summary>
        int pwdnum = 0;

        /// <summary>
        /// 退出,关闭整个应用程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_退出_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 登录验证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_登录_Click(object sender, EventArgs e)
        { 
            if (pwdnum < 2)
            {
                if (textBox_用户名.Text != "" && textBox_密码.Text != "")
                {
                    #region 查询并验证
                    ManagerInfoBll MIBll = new ManagerInfoBll();
                    int num = MIBll.GetRowInfo(textBox_用户名.Text, textBox_密码.Text);
                    switch (num)
                    {
                        case 0:
                            MessageBox.Show("账号不正确,请确认账号后再重新输入");
                            break;
                        case 1:
                            //这里设置登录窗口隐藏,打开新的窗体
                            Form 主界面 = new Form();
                            主界面.Show();
                            this.Hide();
                            break;
                        case 2:
                            MessageBox.Show("密码错误");
                            label_密码错误提示.Text = string.Format("密码错误,还剩余{0}次",(2-pwdnum));
                            pwdnum = pwdnum + 1;
                            break;
                    };
                    #endregion
                }
                else
                {
                    MessageBox.Show("用户名和密码不能为空");
                }
            }
            else
            {
                MessageBox.Show("错误次数太多,程序关闭");
                Application.Exit();
            }
            
        }
    }
}
