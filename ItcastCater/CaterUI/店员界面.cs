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
        public 店员界面()
        {
            InitializeComponent();
        }

        ManagerInfoBll MIBll = new ManagerInfoBll();

        private void ManagerInfo_Load(object sender, EventArgs e)
        {
            GetInfo();
        }

        private void button_取消_Click(object sender, EventArgs e)
        {
            textBox_用户名.Text = "";
            textBox_密码.Text = "";
            radioButton_店员.Checked = true;
        }

        private void button_添加_Click(object sender, EventArgs e)
        {
            ManagerInfo mi = new ManagerInfo()
            {
                MNam = textBox_用户名.Text,
                MPwd = textBox_密码.Text,
                MType = radioButton_店员.Checked ? 1 : 0
            };

            if(MIBll.Insert(mi))
            {
                GetInfo();
                button_取消.PerformClick();
            }
            else
            {
                button_取消.PerformClick();
                MessageBox.Show("添加错误,请重新输入");
            }


            
        }

        private void GetInfo()
        {
            //从BLL层拿数据,填充 数据列表
            
            dataGridView_店员列表.AutoGenerateColumns = false;

            List<ManagerInfo> list = new List<ManagerInfo>();
            list = MIBll.GetList();
            dataGridView_店员列表.DataSource = list;

            //编号不能修改,界面初始化 和 添加 后,更新内容,公司员工总数+1
            textBox_编号.Text = (list.Count + 1).ToString();
        }

        private void button_删除选中的店员_Click(object sender, EventArgs e)
        {
            var rows = dataGridView_店员列表.SelectedCells;

        }

        private void dataGridView_店员列表_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 2)
            {
                e.Value = Convert.ToInt32(e.Value) == 1 ? "店员" : "经理";
            }
        }
    }
}
