using CaterBll;
using CaterModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaterUI
{
    public partial class 店员界面 : Form
    {
        /* 此界面还有1个Bug,删除某行数据后,序号不能更新,中间缺少删除的行的编号
         *最次的解决方案,可以将编号边长打乱,随机安排,但是 Lable_编号.text 就需要更改*/

        private 店员界面()
        {
            InitializeComponent();
        }

        private static 店员界面 _form;

        public static 店员界面 Cteate()
        {
            if(_form == null)
            {
                _form = new 店员界面();
            }
            return _form;
        }


        /// <summary>
        /// 实例化 BLL逻辑层
        /// </summary>
        ManagerInfoBll MIBll = new ManagerInfoBll();

        /// <summary>
        /// 界面初始化,将数据单元格显示信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManagerInfo_Load(object sender, EventArgs e)
        {
            GetInfo();
        }

        /// <summary>
        /// 取消按钮,将需要添加/修改的信息清空,回复初始化状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_取消_Click(object sender, EventArgs e)
        {
            GetInfo();
            textBox_账户名.Text = "";
            textBox_密码.Text = "";
            radioButton_店员.Checked = true;
            button_添加.Text = "添加";
            label_需要修改的员工编号.Visible = false;
        }

        /// <summary>
        /// 添加/修改 按钮,用于人员信息的添加  或者 修改密码等
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_添加_Click(object sender, EventArgs e)
        {
            if (textBox_账户名.Text == "" || textBox_密码.Text == "")//用户名或密码不能为空
            {
                MessageBox.Show("用户名或密码不能为空");
            }
            else
            {
                if (button_添加.Text == "添加")
                {
                    #region 添加事件,执行过程
                    ManagerInfo mi = new ManagerInfo()
                    {
                        MNam = textBox_账户名.Text,
                        MPwd = textBox_密码.Text,
                        MType = radioButton_店员.Checked ? 1 : 0
                    };

                    if (MIBll.Insert(mi))
                    {
                        GetInfo();
                        button_取消.PerformClick();
                    }
                    else
                    {
                        button_取消.PerformClick();
                        MessageBox.Show("添加错误,请重新输入");
                    }
                    #endregion
                }
                else
                {
                    #region 修改事件,执行过程
                    ManagerInfo mi = new ManagerInfo()
                    {
                        MNam = textBox_账户名.Text,
                        MPwd = textBox_密码.Text,
                        MType = radioButton_店员.Checked ? 1 : 0,
                        MId = int.Parse(textBox_编号.Text)
                    };
                    if (MIBll.Update(mi))
                    {
                        GetInfo();
                        button_取消.PerformClick();
                    }
                    else
                    {
                        button_取消.PerformClick();
                        MessageBox.Show("修改错误,请重新输入");
                    }
                    #endregion
                }
            }
        }

        /// <summary>
        /// 删除 数据单元格 选中的行row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_删除选中的店员_Click(object sender, EventArgs e)
        {
            var rows = dataGridView_店员管理.SelectedCells;
            //MessageBox.Show(rows[0].Value.ToString());
            ManagerInfo mi = new ManagerInfo()
            {
                MId = Convert.ToInt32(rows[0].Value)
            };

            if (MIBll.Delete(mi))
            {
                GetInfo();
                button_取消.PerformClick();
            }
            else
            {
                button_取消.PerformClick();
                MessageBox.Show("删除操作错误,请先选中要删除的行");
            }
        }

        /// <summary>
        /// 数据单元格,格式化显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_店员列表_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 2)
            {
                e.Value = Convert.ToInt32(e.Value) == 1 ? "店员" : "经理";
            }
        }

        /// <summary>
        /// 数据单元格,双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_店员列表_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                #region 非第一显示行,不能点击第一显示行
                //根据单元格,获取所在的行
                DataGridViewRow row = dataGridView_店员管理.Rows[e.RowIndex];
                //用行找到,所有列的值,给文本框赋值

                textBox_编号.Text =row.Cells[0].Value.ToString();
                label_需要修改的员工编号.Visible = true;
                textBox_账户名.Text = row.Cells[1].Value.ToString();
                textBox_密码.Text = "123456789";//密码不显示,

                if (row.Cells[2].Value.ToString() == "1")
                {
                    radioButton_店员.Checked = true;
                }
                else
                {
                    radioButton_经理.Checked = true;
                }

                button_添加.Text = "修改";
                #endregion
            }
            else
            {
                return;
            }
        }

        //----------------------------------------------------------//

        /// <summary>
        /// 数据单元格,获得数据,并显示
        /// </summary>
        private void GetInfo()
        {
            //从BLL层拿数据,填充 数据列表

            dataGridView_店员管理.AutoGenerateColumns = false;

            List<ManagerInfo> list = new List<ManagerInfo>();
            list = MIBll.GetList();
            dataGridView_店员管理.DataSource = list;

            //编号不能修改,界面初始化 和 添加 后,更新内容,公司员工总数+1
            textBox_编号.Text = (list.Count + 1).ToString();
        }

        private void 店员界面_FormClosing(object sender, FormClosingEventArgs e)
        {
            _form = null;
        }
    }
}
