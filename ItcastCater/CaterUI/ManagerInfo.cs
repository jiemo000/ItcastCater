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
    public partial class ManagerInfo : Form
    {
        public ManagerInfo()
        {
            InitializeComponent();
        }

        private void ManagerInfo_Load(object sender, EventArgs e)
        {
            ManagerInfoBll MIBll = new ManagerInfoBll();
            dataGridView_店员列表.AutoGenerateColumns = false;
            dataGridView_店员列表.DataSource = MIBll.GetList();
        }
    }
}
