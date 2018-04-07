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
    public partial class 菜单类型界面 : Form
    {
        public 菜单类型界面()
        {
            InitializeComponent();
        }

        DishTypeInfoBll dtibll = new DishTypeInfoBll();

        private void 菜单类型界面_Load(object sender, EventArgs e)
        {
            GetInfo();
        }

        private void button_取消_Click(object sender, EventArgs e)
        {
            textBox_菜系.Text = "";
            GetInfo();
        }

        private void button_添加_Click(object sender, EventArgs e)
        {
            if(textBox_菜系.Text != "")
            {
                DishTypeInfo dti = new DishTypeInfo()
                {
                    DTitle = textBox_菜系.Text,
                    DIsDelete = false
                };

                if(dtibll.Insert(dti))
                {
                    GetInfo();
                }
                else
                {
                    MessageBox.Show("添加错误");
                }
                
            }
            else
            {
                MessageBox.Show("菜系不能为空,请输入后,再添加");
            }
        }

        private void button_删除选中的菜系_Click(object sender, EventArgs e)
        {
            var rows = dataGridView_菜单类型管理.SelectedCells;
            DishTypeInfo mti = new DishTypeInfo()
            {
                DId = Convert.ToInt32(rows[0].Value)
            };
            if (dtibll.Delete(mti))
            {
                GetInfo();
            }
            else
            {
                MessageBox.Show("删除错误,请重试");
            }
        }

        private void GetInfo()
        {
            dataGridView_菜单类型管理.AutoGenerateColumns = false;

            List<DishTypeInfo> list = new List<DishTypeInfo>();

            list = dtibll.GetList();
            dataGridView_菜单类型管理.DataSource = list;
        }
    }
}
