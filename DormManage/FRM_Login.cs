using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DormManage
{
    public partial class FRM_Login : DevExpress.XtraEditors.XtraForm
    {
        public FRM_Login()
        {
            InitializeComponent();
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FRM_Login_Load(object sender, EventArgs e)
        {

        }

        private void FRM_Login_Shown(object sender, EventArgs e)
        {
            this.TB_userName.Focus();
        }
    }
}