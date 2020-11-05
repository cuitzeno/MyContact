using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyContact
{
    public partial class frmEditGroup : Form
    {
        public string strFormName;
        BaseClass.DBHelper db = new BaseClass.DBHelper();

        public frmEditGroup()
        {
            InitializeComponent();
        }

        private void frmEditGroup_Load(object sender, EventArgs e)
        {
            txtGroupName.Text = strFormName;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string strSQLEdit = "update tb_Group set gName='" + txtGroupName.Text.Trim() + "' where gName='" + strFormName + "'";
            if (db.ExecuteNonQuery(strSQLEdit) > 0)
            {
                MessageBox.Show("分类名称修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
