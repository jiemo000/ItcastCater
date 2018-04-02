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
    public partial class 主界面 : Form
    {
        public 主界面()
        {
            InitializeComponent();
        }

        private void Menu_退出_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 主界面_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Menu_店员管理_Click(object sender, EventArgs e)
        {
            店员界面 fm = 店员界面.Cteate();
            fm.Show();
            fm.Focus();
        }

        private void Menu_会员管理_Click(object sender, EventArgs e)
        {
            会员界面 fm = 会员界面.Cteate();
            fm.Show();
            fm.Focus();
        }

        private void 主界面_Load(object sender, EventArgs e)
        {
            if(Convert.ToInt32(this.Tag) == 1)
            {
                Menu_店员管理.Visible = false;
            }
            
        }
    }
}
