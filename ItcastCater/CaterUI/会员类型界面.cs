using CaterBll;
using CaterModel;
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
    public partial class 会员类型界面 : Form
    {
        public 会员类型界面()
        {
            InitializeComponent();
        }

        MenberTypeInfoBll MTIBll = new MenberTypeInfoBll();

        private void 会员类型界面_Load(object sender, EventArgs e)
        {
            GetInfo();
        }

        /// <summary>
        /// 数据单元格,获得数据,并显示
        /// </summary>
        private void GetInfo()
        {
            //从BLL层拿数据,填充 数据列表

            dataGridView_会员类型管理.AutoGenerateColumns = false;

            List<MemberTypeInfo> list = new List<MemberTypeInfo>();
            list = MTIBll.GetList();
            dataGridView_会员类型管理.DataSource = list;

            //编号不能修改,界面初始化 和 添加 后,更新内容,公司员工总数+1
            textBox_编号.Text = (list.Count + 1).ToString();
        }

        private void button_添加_Click(object sender, EventArgs e)
        {
            if (textBox_标题.Text != "" && textBox_折扣.Text != "")
            {
                try
                {
                    MemberTypeInfo mti = new MemberTypeInfo()
                    {
                        MTitle = textBox_标题.Text,
                        MDiscount = decimal.Parse(textBox_折扣.Text),
                        MIsdelete = false
                    };
                    if (MTIBll.Insert(mti))
                    {
                        GetInfo();
                        button_取消.PerformClick();
                    }
                    else
                    {
                        button_取消.PerformClick();
                        MessageBox.Show("添加不成功,请重试");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("折扣必须是数字");
                }
            }
            else
            {
                MessageBox.Show("文本框不能为空");
            }
           
        }

        private void button_取消_Click(object sender, EventArgs e)
        {
            GetInfo();
            textBox_标题.Text = "";
            textBox_折扣.Text = "";
        }

        /// <summary>
        /// 重要:重要:重要:
        /// 真实删除操作,后面版本需要逻辑删除,textbox_标题,需要改成下拉列表框,指定会员类型,删除后隐藏,使用逻辑删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_删除选中的会员_Click(object sender, EventArgs e)
        {
            
            var rows = dataGridView_会员类型管理.SelectedCells;
            MemberTypeInfo mti = new MemberTypeInfo()
            {
                MId = Convert.ToInt32(rows[0].Value)
            };
            if(MTIBll.Delete(mti))
            {
                GetInfo();
            }
            else
            {
                MessageBox.Show("删除错误,请重试");
            }
        }
    }
}
