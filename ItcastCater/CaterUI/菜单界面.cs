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
    public partial class 菜单界面 : Form
    {
        private 菜单界面()
        {
            InitializeComponent();
        }

        private static 菜单界面 _form;

        public static 菜单界面 Cteate()
        {
            if (_form == null)
            {
                _form = new 菜单界面();
            }
            return _form;
        }
        private void 菜单界面_FormClosing(object sender, FormClosingEventArgs e)
        {
            _form = null;
        }



        DishInfoBll dibll = new DishInfoBll();

        private void button_添加_分类管理_Click(object sender, EventArgs e)
        {
            菜单类型界面 fm = new 菜单类型界面();
            fm.ShowDialog();
        }

        private void 菜单界面_Load(object sender, EventArgs e)
        {
            GetInfo();

            GetCombox();
        }

        private void GetInfo()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            if (textBox_搜索_姓名.Text != "")
            {
                dic.Add("DishInfo.DTitle", textBox_搜索_姓名.Text);
            }
            dataGridView_菜单管理.AutoGenerateColumns = false;
            dataGridView_菜单管理.DataSource = dibll.GetList(dic);
        }

        private void textBox_搜索_姓名_TextChanged(object sender, EventArgs e)
        {
            GetInfo();
        }

        private void button_搜索_显示全部_Click(object sender, EventArgs e)
        {
            textBox_搜索_姓名.Text = "";
            GetInfo();
        }

        private void comboBox_搜索_分类_DropDown(object sender, EventArgs e)
        {
            GetCombox();
        }

        

        private void GetCombox()
        {
            DishTypeInfoBll dtibll = new DishTypeInfoBll();
            List<DishTypeInfo> list = new List<DishTypeInfo>();

            list = dtibll.GetList();

            comboBox_搜索_分类.DataSource = list;
            comboBox_搜索_分类.DisplayMember = "DTitle";
            comboBox_搜索_分类.ValueMember = "DId";

            comboBox_添加_分类.DataSource = list;
            comboBox_添加_分类.DisplayMember = "DTitle";
            comboBox_添加_分类.ValueMember = "DId";
        }

        private void button_添加_取消_Click(object sender, EventArgs e)
        {
            textBox_添加_名称.Text = "";
            textBox_添加_价格.Text = "";
            textBox_添加_拼音.Text = "";
            GetInfo();
        }

        private void button_添加_添加_Click(object sender, EventArgs e)
        {
            if(textBox_添加_名称.Text != "" || textBox_添加_价格.Text != "" ||textBox_添加_拼音.Text != "")
            {
                #region 添加数据
                try
                {
                    DishInfo di = new DishInfo()
                    {
                        DTitle = textBox_添加_名称.Text,
                        DChar = textBox_添加_拼音.Text,
                        DPrice = decimal.Parse(textBox_添加_价格.Text),
                        DTypeId = Convert.ToInt32(comboBox_添加_分类.SelectedValue),
                        DIsDelete = false
                    };

                    if (dibll.Insert(di))
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

        private void button_添加_删除选中的行数据_Click(object sender, EventArgs e)
        {
            var rows = dataGridView_菜单管理.SelectedCells;
            //MessageBox.Show(rows[0].Value.ToString());
            DishInfo di = new DishInfo()
            {
                DId = Convert.ToInt32(rows[0].Value)
            };

            if (dibll.Delete(di))
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

        private void comboBox_添加_分类_DropDown(object sender, EventArgs e)
        {
            GetCombox();
        }


    }
}
