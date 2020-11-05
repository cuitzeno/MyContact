using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MyContact
{
    public partial class frmContactInfo : Form
    {
        public Boolean IsAdd;
        public string ContactName;
        BaseClass.DBHelper db = new BaseClass.DBHelper();

        public frmContactInfo()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmContactInfo_Load(object sender, EventArgs e)
        {
            string strSQLGroup = "select * from tb_Group";
            OleDbDataReader drGroup = db.ExecuteReader(strSQLGroup);
            while (drGroup.Read())
            {
                cboxGroup.Items.Add(drGroup[1].ToString());
            }
            if (!IsAdd)
            {
                string strSqlContact = "select tb_Contact.*, tb_Group.gName from tb_Contact, tb_Group where tb_Contact.GroupID = tb_Group.gID and UserName = '" + ContactName + "'";
                DataSet dsContact = db.getDataSet(strSqlContact, "db_Contact");
                txtName.Text = dsContact.Tables[0].Rows[0][1].ToString();
                if (dsContact.Tables[0].Rows[0][2].ToString() == "男")
                    rdoMale.Checked = true;
                else
                    rdoFemale.Checked = true;
                txtPhone.Text = dsContact.Tables[0].Rows[0][3].ToString();
                txtQQ.Text = dsContact.Tables[0].Rows[0][4].ToString();
                txtEmail.Text = dsContact.Tables[0].Rows[0][5].ToString();
                btnIsContactIn.Enabled = false;
                cboxGroup.SelectedText = dsContact.Tables[0].Rows[0][8].ToString();
            }
        }

        private void btnIsContactIn_Click(object sender, EventArgs e)
        {
            string strSQLExist = "select * from tb_Contact where UserName = '" + txtName.Text + "'";
            OleDbDataReader dr = db.ExecuteReader(strSQLExist);
            dr.Read();
            if (dr.HasRows)
            {
                txtName.Text = "";
                MessageBox.Show("该用户已经存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
            }
            else
            {
                MessageBox.Show("该用户不存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboxGroup.Focus();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "" || cboxGroup.Text.Trim() == "" || txtPhone.Text.Trim() == "" || txtQQ.Text.Trim() == "" || txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("请将信息填写完整", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (txtPhone.Text.Length != 11)
                {
                    MessageBox.Show("手机号码为11位");
                    txtPhone.Focus();
                    return;
                }
                else if (!(Regex.IsMatch(txtEmail.Text.Trim(), @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")))
                {
                    MessageBox.Show("邮件格式不正确");
                    txtEmail.Focus();
                    return;
                }
                else
                {
                    string strGender = "男";
                    if (rdoFemale.Checked)
                        strGender = "女";
                    string strSQLGroupID = "select gID from tb_Group where gName = '" + cboxGroup.Text.Trim() + "'";
                    OleDbDataReader dr = db.ExecuteReader(strSQLGroupID);
                    dr.Read();
                    int strGroupID = Convert.ToInt32(dr[0].ToString());
                    string strSQLAddEdit;
                    if (IsAdd)
                        strSQLAddEdit = "insert into [tb_Contact] (UserName, Gender, Phone, QQ, Email, PostDate, GroupID) values ('" + txtName.Text.Trim() + "', '" + strGender + "', '" + txtPhone.Text.Trim() + "', '" + txtQQ.Text.Trim() + "', '" + txtEmail.Text.Trim() + "', '" + DateTime.Now.ToString() + "', " + strGroupID + ")";
                    else
                        strSQLAddEdit = "update tb_Contact set Gender = '" + strGender + "', Phone = '" + txtPhone.Text.Trim() + "', QQ = '" + txtQQ.Text.Trim() + "', Email = '" + txtEmail.Text.Trim() + "' where UserName='" + txtName.Text.Trim() + "'";
                    if (db.ExecuteNonQuery(strSQLAddEdit) > 0)
                    {
                        MessageBox.Show("编辑成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
