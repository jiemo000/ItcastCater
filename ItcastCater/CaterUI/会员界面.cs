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
    }
}
