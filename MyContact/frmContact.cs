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
    public partial class frmContact : Form
    {
        BaseClass.DBHelper db = new BaseClass.DBHelper();

        public frmContact()
        {
            InitializeComponent();
        }

        public void ContactListAll()
        {
            string strSQLAll = "Select ID,UserName as 姓名,Gender as 性别,Phone as 联系电话,QQ,Email as 电子邮箱,PostDate as 添加日期 from tb_Contact";
            DataSet dsAll = db.getDataSet(strSQLAll, "tb_Contact");
            dgvContactInfo.DataSource = dsAll.Tables[0];
            dgvContactInfo.Columns[0].Visible = false;
            dgvContactInfo.Columns[1].Width = 60;
            dgvContactInfo.Columns[2].Width = 55;
            dgvContactInfo.Columns[3].Width = 80;
            dgvContactInfo.Columns[4].Width = 65;
            dgvContactInfo.Columns[5].Width = 190;
            dgvContactInfo.Columns[6].Width = 105;
            if (dgvContactInfo.RowCount > 1)
            {
                tStripEdit.Enabled = true;
                tStripDel.Enabled = true;
            }
            else
            {
                tStripEdit.Enabled = false;
                tStripDel.Enabled = false;
            }
        }

        private void frmContact_Load(object sender, EventArgs e)
        {
            string strLoginTime = DateTime.Now.ToString();
            sStriplblLoginTime.Text = strLoginTime;
            cBoxKeyWords.Items.Clear();
            sStriplblCurrentTime.Text = DateTime.Now.ToString();
            TreeNode tn = tvGroup.Nodes.Add("我的通讯录");
            OleDbDataReader dr = db.ExecuteReader("Select * from tb_Group");
            while (dr.Read())
            {
                tn.Nodes.Add(dr["gName"].ToString());
                cBoxKeyWords.Items.Add(dr["gName"].ToString());
            }
            tvGroup.ExpandAll();
            tvGroup.SelectedNode = tvGroup.Nodes[0];
            ContactListAll();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            sStriplblCurrentTime.Text = DateTime.Now.ToString();
        }

        private void tStripExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定退出本系统吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void tvGroup_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string strNodeText = e.Node.Text;
            if (strNodeText == "我的通讯录")
            {
                ContactListAll();
            }
            else
            {
                string strSQLOne = "Select ID,UserName as 姓名,Gender as 性别,Phone as 电话,QQ,Email as 电子邮箱,PostDate as 添加日期 from tb_Contact where GroupID = (Select gID from tb_Group where gName = '" + strNodeText + "')";
                DataSet dsOne = db.getDataSet(strSQLOne, "db_Contact");
                dgvContactInfo.DataSource = dsOne.Tables[0];
                dgvContactInfo.Columns[0].Visible = false;
                dgvContactInfo.Columns[1].Width = 60;
                dgvContactInfo.Columns[2].Width = 55;
                dgvContactInfo.Columns[3].Width = 80;
                dgvContactInfo.Columns[4].Width = 65;
                dgvContactInfo.Columns[5].Width = 190;
                dgvContactInfo.Columns[6].Width = 105;
                if (dgvContactInfo.RowCount > 1)
                {
                    tStripEdit.Enabled = true;
                    tStripDel.Enabled = true;
                }
                else
                {
                    tStripEdit.Enabled = false;
                    tStripDel.Enabled = false;
                }
            }
        }

        private void tStripAddGroup_Click(object sender, EventArgs e)
        {
            frmAddGroup addGroup = new frmAddGroup();
            addGroup.ShowDialog();
        }

        private void frmContact_Activated(object sender, EventArgs e)
        {
            tvGroup.Nodes.Clear();
            frmContact_Load(sender, e);
        }

        private void tStripDelGroup_Click(object sender, EventArgs e)
        {

            if (tvGroup.SelectedNode.Text == "我的通讯录")
            {
                MessageBox.Show("不能删除根目录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string strNodeText = tvGroup.SelectedNode.Text;
                if (MessageBox.Show("确定要删除分类<" + strNodeText + ">吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    string strSQLDel = "delete from tb_Group where gName='" + strNodeText + "'";
                    if (db.ExecuteNonQuery(strSQLDel) > 0)
                    {
                        MessageBox.Show("分类删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void tStripEditGroup_Click(object sender, EventArgs e)
        {
            if (tvGroup.SelectedNode.Text == "我的通讯录")
            {
                MessageBox.Show("不能修改根目录", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string strNodeText = tvGroup.SelectedNode.Text;
                frmEditGroup editGroup = new frmEditGroup();
                editGroup.strFormName = strNodeText;
                editGroup.ShowDialog();
            }
        }

        private void dgvContactInfo_DoubleClick(object sender, EventArgs e)
        {
            if (dgvContactInfo.SelectedCells.Count == 0)
            {
                MessageBox.Show("请选择要修改的数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                frmContactInfo contactinfoedit = new frmContactInfo();
                contactinfoedit.IsAdd = false;
                contactinfoedit.ContactName = dgvContactInfo.SelectedCells[0].Value.ToString();
                contactinfoedit.ShowDialog();
            }
        }

        private void 添加组ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tStripAddGroup_Click(sender, e);
        }

        private void 修改组ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tStripEditGroup_Click(sender, e);
        }

        private void 删除组ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tStripDelGroup_Click(sender, e);
        }

        private void tStripAdd_Click(object sender, EventArgs e)
        {
            frmContactInfo contactinfoadd = new frmContactInfo();
            contactinfoadd.IsAdd = true;
            contactinfoadd.ShowDialog();
        }

        private void tStripEdit_Click(object sender, EventArgs e)
        {
            dgvContactInfo_DoubleClick(sender, e);
        }

        private void tStripDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvContactInfo.SelectedCells.Count == 0)
                {
                    MessageBox.Show("请选择要删除的数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    string strContact = dgvContactInfo.SelectedCells[0].Value.ToString();
                    if (MessageBox.Show("确定要删除联系人<" + strContact + ">吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    {
                        string strSQLDel = "delete from tb_Contact where UserName='" + strContact + "'";
                        if (db.ExecuteNonQuery(strSQLDel) > 0)
                        {
                            MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("删除操作失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tStripEdit_Click(sender, e);
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tStripDel_Click(sender, e);
        }
    }
}
