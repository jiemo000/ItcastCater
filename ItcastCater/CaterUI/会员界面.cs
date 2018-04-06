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
    public partial class 会员界面 : Form
    {
        private 会员界面()
        {
            InitializeComponent();
        }

        private static 会员界面 _form;

        public static 会员界面 Cteate()
        {
            if (_form == null)
            {
                _form = new 会员界面();
            }
            return _form;
        }

        private void 会员管理_FormClosing(object sender, FormClosingEventArgs e)
        {
            _form = null;
        }

        MemberInfoBll mib = new MemberInfoBll();

        private void button_添加_类型管理_Click(object sender, EventArgs e)
        {
            会员类型界面 fm = new 会员类型界面();
            fm.Show();
            fm.Focus();
        }

        private void 会员界面_Load(object sender, EventArgs e)
        {
            GetInfo();
            GetCombox();

        }

        private void GetInfo()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            if (textBox_搜索_姓名.Text != "")
            {
                dic.Add("MName", textBox_搜索_姓名.Text);
            }

            if (textBox_搜索_手机号.Text != "")
            {
                dic.Add("MPhone", textBox_搜索_手机号.Text);
            }

            dataGridView_会员管理.AutoGenerateColumns = false;
            List<MemberInfo> list = new List<MemberInfo>();
            list = mib.GetInfo(dic);
            dataGridView_会员管理.DataSource = list;

        }

        private void textBox_搜索_姓名_TextChanged(object sender, EventArgs e)
        {
            GetInfo();
        }

        private void textBox_搜索_手机号_TextChanged(object sender, EventArgs e)
        {
            GetInfo();
        }

        private void button_搜索_显示全部_Click(object sender, EventArgs e)
        {
            textBox_搜索_手机号.Text = "";
            textBox_搜索_姓名.Text = "";
            GetInfo();
        }

        private void button_添加_取消_Click(object sender, EventArgs e)
        {
            textBox_添加_姓名.Text = "";
            textBox_添加_手机号.Text = "";
            textBox_添加_余额.Text = "";

            textBox_搜索_手机号.Text = "";
            textBox_搜索_姓名.Text = "";
            GetInfo();
        }

        private void button_添加_添加_Click(object sender, EventArgs e)
        {
            if (textBox_添加_姓名.Text != "" || textBox_添加_手机号.Text != "" || textBox_添加_余额.Text != "")
            {
                #region 添加数据
                try
                {
                    MemberInfo mi = new MemberInfo()
                    {
                        MName = textBox_添加_姓名.Text,
                        MPhone = textBox_添加_手机号.Text,
                        MMoney = decimal.Parse(textBox_添加_余额.Text),
                        MTypeId = Convert.ToInt32(comboBox_添加_类型.SelectedValue),
                        MIsdelete = false
                    };

                    if (mib.Insert(mi))
                    {
                        GetInfo();
                    }
                    else
                    {
                        MessageBox.Show("添加不成功,未知名错误");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("余额必须是数字");
                }
                #endregion
            }
            else
            {
                MessageBox.Show("不能为空,请填写内容");
            }
        }

        private void comboBox_添加_类型_DropDown(object sender, EventArgs e)
        {
            GetCombox();
        }

        private void GetCombox()
        {
            MenberTypeInfoBll mtibll = new MenberTypeInfoBll();

            List<MemberTypeInfo> list = new List<MemberTypeInfo>();

            list = mtibll.GetList();

            comboBox_添加_类型.DataSource = list;
            comboBox_添加_类型.DisplayMember = "MTitle";
            comboBox_添加_类型.ValueMember = "MId";
        }

        private void button_添加_删除选中的行数据_Click(object sender, EventArgs e)
        {
            var rows = dataGridView_会员管理.SelectedCells;
            //MessageBox.Show(rows[0].Value.ToString());
            MemberInfo mi = new MemberInfo()
            {
                MId = Convert.ToInt32(rows[0].Value)
            };

            if (mib.Delete(mi))
            {
                GetInfo();
                button_添加_取消.PerformClick();
            }
            else
            {
                button_添加_取消.PerformClick();
                MessageBox.Show("删除操作错误,请先选中要删除的行");
            }
        }
    }
}
