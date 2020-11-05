using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyContact
{
    public partial class frmAddGroup : Form
    {
        BaseClass.DBHelper db = new BaseClass.DBHelper();

        public frmAddGroup()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtGroupName.Text.Trim() == "")
            {
                MessageBox.Show("请输入分类名称", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string cmdText = "select * from [tb_Group] where gName = '" + txtGroupName.Text.Trim() + "'";
                OleDbDataReader dr = db.ExecuteReader(cmdText);
                if (dr.Read())
                {
                    MessageBox.Show("该分类已经存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    string strSQL = "insert into [tb_Group] (gName) values ('" + txtGroupName.Text + "')";
                    if (db.ExecuteNonQuery(strSQL) > 0)
                    {
                        MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
