namespace MyContact
{
    partial class frmContactInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tCtlContactInfo = new System.Windows.Forms.TabControl();
            this.tabPage = new System.Windows.Forms.TabPage();
            this.btnIsContactIn = new System.Windows.Forms.Button();
            this.cboxGroup = new System.Windows.Forms.ComboBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtQQ = new System.Windows.Forms.TextBox();
            this.lblQQ = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tCtlContactInfo.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tCtlContactInfo
            // 
            this.tCtlContactInfo.Controls.Add(this.tabPage);
            this.tCtlContactInfo.Location = new System.Drawing.Point(12, 12);
            this.tCtlContactInfo.Name = "tCtlContactInfo";
            this.tCtlContactInfo.SelectedIndex = 0;
            this.tCtlContactInfo.Size = new System.Drawing.Size(364, 198);
            this.tCtlContactInfo.TabIndex = 0;
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.btnIsContactIn);
            this.tabPage.Controls.Add(this.cboxGroup);
            this.tabPage.Controls.Add(this.lblGroup);
            this.tabPage.Controls.Add(this.txtEmail);
            this.tabPage.Controls.Add(this.lblEmail);
            this.tabPage.Controls.Add(this.txtQQ);
            this.tabPage.Controls.Add(this.lblQQ);
            this.tabPage.Controls.Add(this.txtPhone);
            this.tabPage.Controls.Add(this.lblPhone);
            this.tabPage.Controls.Add(this.rdoFemale);
            this.tabPage.Controls.Add(this.rdoMale);
            this.tabPage.Controls.Add(this.lblGender);
            this.tabPage.Controls.Add(this.txtName);
            this.tabPage.Controls.Add(this.lblName);
            this.tabPage.Location = new System.Drawing.Point(4, 22);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage.Size = new System.Drawing.Size(356, 172);
            this.tabPage.TabIndex = 0;
            this.tabPage.Text = "个人基本信息";
            this.tabPage.UseVisualStyleBackColor = true;
            // 
            // btnIsContactIn
            // 
            this.btnIsContactIn.Location = new System.Drawing.Point(208, 21);
            this.btnIsContactIn.Name = "btnIsContactIn";
            this.btnIsContactIn.Size = new System.Drawing.Size(126, 23);
            this.btnIsContactIn.TabIndex = 2;
            this.btnIsContactIn.Text = "检查联系人是否存在";
            this.btnIsContactIn.UseVisualStyleBackColor = true;
            this.btnIsContactIn.Click += new System.EventHandler(this.btnIsContactIn_Click);
            // 
            // cboxGroup
            // 
            this.cboxGroup.FormattingEnabled = true;
            this.cboxGroup.Location = new System.Drawing.Point(79, 57);
            this.cboxGroup.Name = "cboxGroup";
            this.cboxGroup.Size = new System.Drawing.Size(100, 20);
            this.cboxGroup.TabIndex = 3;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(12, 61);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(65, 12);
            this.lblGroup.TabIndex = 11;
            this.lblGroup.Text = "所属分类：";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(79, 129);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(258, 21);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.Text = "@";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(13, 132);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(65, 12);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "电子邮箱：";
            // 
            // txtQQ
            // 
            this.txtQQ.Location = new System.Drawing.Point(256, 92);
            this.txtQQ.MaxLength = 10;
            this.txtQQ.Name = "txtQQ";
            this.txtQQ.Size = new System.Drawing.Size(67, 21);
            this.txtQQ.TabIndex = 7;
            // 
            // lblQQ
            // 
            this.lblQQ.AutoSize = true;
            this.lblQQ.Location = new System.Drawing.Point(209, 96);
            this.lblQQ.Name = "lblQQ";
            this.lblQQ.Size = new System.Drawing.Size(47, 12);
            this.lblQQ.TabIndex = 7;
            this.lblQQ.Text = "Ｑ Ｑ：";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(79, 93);
            this.txtPhone.MaxLength = 11;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 21);
            this.txtPhone.TabIndex = 6;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(13, 96);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(65, 12);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "联系电话：";
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(302, 59);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(35, 16);
            this.rdoFemale.TabIndex = 5;
            this.rdoFemale.Text = "女";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Checked = true;
            this.rdoMale.Location = new System.Drawing.Point(257, 58);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(35, 16);
            this.rdoMale.TabIndex = 4;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "男";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(209, 60);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(47, 12);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "性 别：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(79, 21);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(24, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "姓  名：";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(179, 217);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "确 定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(282, 216);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "取 消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmContactInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 249);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tCtlContactInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmContactInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "通讯录信息编辑";
            this.Load += new System.EventHandler(this.frmContactInfo_Load);
            this.tCtlContactInfo.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.tabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tCtlContactInfo;
        private System.Windows.Forms.TabPage tabPage;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtQQ;
        private System.Windows.Forms.Label lblQQ;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ComboBox cboxGroup;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Button btnIsContactIn;
    }
}