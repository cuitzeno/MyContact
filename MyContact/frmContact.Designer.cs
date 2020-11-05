namespace MyContact
{
    partial class frmContact
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContact));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tStripAddGroup = new System.Windows.Forms.ToolStripButton();
            this.tStripEditGroup = new System.Windows.Forms.ToolStripButton();
            this.tStripDelGroup = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tStripAdd = new System.Windows.Forms.ToolStripButton();
            this.tStripEdit = new System.Windows.Forms.ToolStripButton();
            this.tStripDel = new System.Windows.Forms.ToolStripButton();
            this.tStripPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tStripAbout = new System.Windows.Forms.ToolStripButton();
            this.tStripExit = new System.Windows.Forms.ToolStripButton();
            this.tvGroup = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加组ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改组ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除组ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.sStriplblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.sStriplblUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.sStriplblLogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.sStriplblLoginTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.sStriplblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.sStriplblCurrentTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.dgvContactInfo = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblKeyWords = new System.Windows.Forms.Label();
            this.cBoxKeyWords = new System.Windows.Forms.ComboBox();
            this.txtKeyWords = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactInfo)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStripAddGroup,
            this.tStripEditGroup,
            this.tStripDelGroup,
            this.toolStripSeparator1,
            this.tStripAdd,
            this.tStripEdit,
            this.tStripDel,
            this.tStripPrint,
            this.toolStripSeparator2,
            this.tStripAbout,
            this.tStripExit});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(737, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tStripAddGroup
            // 
            this.tStripAddGroup.Image = ((System.Drawing.Image)(resources.GetObject("tStripAddGroup.Image")));
            this.tStripAddGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStripAddGroup.Name = "tStripAddGroup";
            this.tStripAddGroup.Size = new System.Drawing.Size(64, 22);
            this.tStripAddGroup.Text = "添加组";
            this.tStripAddGroup.Click += new System.EventHandler(this.tStripAddGroup_Click);
            // 
            // tStripEditGroup
            // 
            this.tStripEditGroup.Image = ((System.Drawing.Image)(resources.GetObject("tStripEditGroup.Image")));
            this.tStripEditGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStripEditGroup.Name = "tStripEditGroup";
            this.tStripEditGroup.Size = new System.Drawing.Size(64, 22);
            this.tStripEditGroup.Text = "修改组";
            this.tStripEditGroup.Click += new System.EventHandler(this.tStripEditGroup_Click);
            // 
            // tStripDelGroup
            // 
            this.tStripDelGroup.Image = ((System.Drawing.Image)(resources.GetObject("tStripDelGroup.Image")));
            this.tStripDelGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStripDelGroup.Name = "tStripDelGroup";
            this.tStripDelGroup.Size = new System.Drawing.Size(64, 22);
            this.tStripDelGroup.Text = "删除组";
            this.tStripDelGroup.Click += new System.EventHandler(this.tStripDelGroup_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tStripAdd
            // 
            this.tStripAdd.Image = ((System.Drawing.Image)(resources.GetObject("tStripAdd.Image")));
            this.tStripAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStripAdd.Name = "tStripAdd";
            this.tStripAdd.Size = new System.Drawing.Size(52, 22);
            this.tStripAdd.Text = "添加";
            this.tStripAdd.Click += new System.EventHandler(this.tStripAdd_Click);
            // 
            // tStripEdit
            // 
            this.tStripEdit.Image = ((System.Drawing.Image)(resources.GetObject("tStripEdit.Image")));
            this.tStripEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStripEdit.Name = "tStripEdit";
            this.tStripEdit.Size = new System.Drawing.Size(52, 22);
            this.tStripEdit.Text = "修改";
            this.tStripEdit.Click += new System.EventHandler(this.tStripEdit_Click);
            // 
            // tStripDel
            // 
            this.tStripDel.Image = ((System.Drawing.Image)(resources.GetObject("tStripDel.Image")));
            this.tStripDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStripDel.Name = "tStripDel";
            this.tStripDel.Size = new System.Drawing.Size(52, 22);
            this.tStripDel.Text = "删除";
            this.tStripDel.Click += new System.EventHandler(this.tStripDel_Click);
            // 
            // tStripPrint
            // 
            this.tStripPrint.Image = ((System.Drawing.Image)(resources.GetObject("tStripPrint.Image")));
            this.tStripPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStripPrint.Name = "tStripPrint";
            this.tStripPrint.Size = new System.Drawing.Size(52, 22);
            this.tStripPrint.Text = "打印";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tStripAbout
            // 
            this.tStripAbout.Image = ((System.Drawing.Image)(resources.GetObject("tStripAbout.Image")));
            this.tStripAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStripAbout.Name = "tStripAbout";
            this.tStripAbout.Size = new System.Drawing.Size(52, 22);
            this.tStripAbout.Text = "关于";
            // 
            // tStripExit
            // 
            this.tStripExit.Image = ((System.Drawing.Image)(resources.GetObject("tStripExit.Image")));
            this.tStripExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStripExit.Name = "tStripExit";
            this.tStripExit.Size = new System.Drawing.Size(52, 22);
            this.tStripExit.Text = "退出";
            this.tStripExit.Click += new System.EventHandler(this.tStripExit_Click);
            // 
            // tvGroup
            // 
            this.tvGroup.ContextMenuStrip = this.contextMenuStrip1;
            this.tvGroup.Location = new System.Drawing.Point(0, 28);
            this.tvGroup.Name = "tvGroup";
            this.tvGroup.Size = new System.Drawing.Size(154, 379);
            this.tvGroup.TabIndex = 1;
            this.tvGroup.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvGroup_AfterSelect);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加组ToolStripMenuItem,
            this.修改组ToolStripMenuItem,
            this.删除组ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 70);
            // 
            // 添加组ToolStripMenuItem
            // 
            this.添加组ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("添加组ToolStripMenuItem.Image")));
            this.添加组ToolStripMenuItem.Name = "添加组ToolStripMenuItem";
            this.添加组ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.添加组ToolStripMenuItem.Text = "添加组";
            this.添加组ToolStripMenuItem.Click += new System.EventHandler(this.添加组ToolStripMenuItem_Click);
            // 
            // 修改组ToolStripMenuItem
            // 
            this.修改组ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("修改组ToolStripMenuItem.Image")));
            this.修改组ToolStripMenuItem.Name = "修改组ToolStripMenuItem";
            this.修改组ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.修改组ToolStripMenuItem.Text = "修改组";
            this.修改组ToolStripMenuItem.Click += new System.EventHandler(this.修改组ToolStripMenuItem_Click);
            // 
            // 删除组ToolStripMenuItem
            // 
            this.删除组ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("删除组ToolStripMenuItem.Image")));
            this.删除组ToolStripMenuItem.Name = "删除组ToolStripMenuItem";
            this.删除组ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.删除组ToolStripMenuItem.Text = "删除组";
            this.删除组ToolStripMenuItem.Click += new System.EventHandler(this.删除组ToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sStriplblUser,
            this.sStriplblUserName,
            this.sStriplblLogin,
            this.sStriplblLoginTime,
            this.sStriplblTime,
            this.sStriplblCurrentTime});
            this.statusStrip.Location = new System.Drawing.Point(0, 410);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(737, 22);
            this.statusStrip.TabIndex = 2;
            // 
            // sStriplblUser
            // 
            this.sStriplblUser.Name = "sStriplblUser";
            this.sStriplblUser.Size = new System.Drawing.Size(92, 17);
            this.sStriplblUser.Text = "当前登录用户：";
            // 
            // sStriplblUserName
            // 
            this.sStriplblUserName.AutoSize = false;
            this.sStriplblUserName.Name = "sStriplblUserName";
            this.sStriplblUserName.Size = new System.Drawing.Size(120, 17);
            this.sStriplblUserName.Text = "Admin";
            this.sStriplblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sStriplblLogin
            // 
            this.sStriplblLogin.Name = "sStriplblLogin";
            this.sStriplblLogin.Size = new System.Drawing.Size(68, 17);
            this.sStriplblLogin.Text = "登录时间：";
            // 
            // sStriplblLoginTime
            // 
            this.sStriplblLoginTime.AutoSize = false;
            this.sStriplblLoginTime.Name = "sStriplblLoginTime";
            this.sStriplblLoginTime.Size = new System.Drawing.Size(250, 17);
            this.sStriplblLoginTime.Text = "sStriplblLoginTime";
            this.sStriplblLoginTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sStriplblTime
            // 
            this.sStriplblTime.Name = "sStriplblTime";
            this.sStriplblTime.Size = new System.Drawing.Size(68, 17);
            this.sStriplblTime.Text = "当前时间：";
            // 
            // sStriplblCurrentTime
            // 
            this.sStriplblCurrentTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sStriplblCurrentTime.Name = "sStriplblCurrentTime";
            this.sStriplblCurrentTime.Size = new System.Drawing.Size(107, 17);
            this.sStriplblCurrentTime.Text = "sStripStatusLabel";
            this.sStriplblCurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // dgvContactInfo
            // 
            this.dgvContactInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactInfo.ContextMenuStrip = this.contextMenuStrip2;
            this.dgvContactInfo.Location = new System.Drawing.Point(160, 54);
            this.dgvContactInfo.Name = "dgvContactInfo";
            this.dgvContactInfo.RowHeadersVisible = false;
            this.dgvContactInfo.RowTemplate.Height = 23;
            this.dgvContactInfo.Size = new System.Drawing.Size(577, 353);
            this.dgvContactInfo.TabIndex = 5;
            this.dgvContactInfo.DoubleClick += new System.EventHandler(this.dgvContactInfo_DoubleClick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加ToolStripMenuItem,
            this.删除ToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(153, 70);
            // 
            // 添加ToolStripMenuItem
            // 
            this.添加ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("添加ToolStripMenuItem.Image")));
            this.添加ToolStripMenuItem.Name = "添加ToolStripMenuItem";
            this.添加ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.添加ToolStripMenuItem.Text = "修改";
            this.添加ToolStripMenuItem.Click += new System.EventHandler(this.添加ToolStripMenuItem_Click);
            // 
            // lblKeyWords
            // 
            this.lblKeyWords.AutoSize = true;
            this.lblKeyWords.Location = new System.Drawing.Point(160, 31);
            this.lblKeyWords.Name = "lblKeyWords";
            this.lblKeyWords.Size = new System.Drawing.Size(101, 12);
            this.lblKeyWords.TabIndex = 6;
            this.lblKeyWords.Text = "请选择查找条件：";
            // 
            // cBoxKeyWords
            // 
            this.cBoxKeyWords.FormattingEnabled = true;
            this.cBoxKeyWords.Location = new System.Drawing.Point(261, 28);
            this.cBoxKeyWords.Name = "cBoxKeyWords";
            this.cBoxKeyWords.Size = new System.Drawing.Size(121, 20);
            this.cBoxKeyWords.TabIndex = 7;
            // 
            // txtKeyWords
            // 
            this.txtKeyWords.Location = new System.Drawing.Point(388, 27);
            this.txtKeyWords.Name = "txtKeyWords";
            this.txtKeyWords.Size = new System.Drawing.Size(249, 21);
            this.txtKeyWords.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(648, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "查 询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("删除ToolStripMenuItem.Image")));
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // frmContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 432);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtKeyWords);
            this.Controls.Add(this.cBoxKeyWords);
            this.Controls.Add(this.lblKeyWords);
            this.Controls.Add(this.dgvContactInfo);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tvGroup);
            this.Controls.Add(this.toolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "我的通讯录";
            this.Load += new System.EventHandler(this.frmContact_Load);
            this.Activated += new System.EventHandler(this.frmContact_Activated);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactInfo)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tStripAddGroup;
        private System.Windows.Forms.ToolStripButton tStripEditGroup;
        private System.Windows.Forms.ToolStripButton tStripDelGroup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tStripAdd;
        private System.Windows.Forms.ToolStripButton tStripEdit;
        private System.Windows.Forms.ToolStripButton tStripDel;
        private System.Windows.Forms.ToolStripButton tStripPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tStripExit;
        private System.Windows.Forms.TreeView tvGroup;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel sStriplblUser;
        private System.Windows.Forms.ToolStripStatusLabel sStriplblUserName;
        private System.Windows.Forms.ToolStripStatusLabel sStriplblLogin;
        private System.Windows.Forms.ToolStripStatusLabel sStriplblLoginTime;
        private System.Windows.Forms.ToolStripStatusLabel sStriplblCurrentTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripStatusLabel sStriplblTime;
        private System.Windows.Forms.ToolStripButton tStripAbout;
        private System.Windows.Forms.DataGridView dgvContactInfo;
        private System.Windows.Forms.Label lblKeyWords;
        private System.Windows.Forms.ComboBox cBoxKeyWords;
        private System.Windows.Forms.TextBox txtKeyWords;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加组ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改组ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除组ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
    }
}