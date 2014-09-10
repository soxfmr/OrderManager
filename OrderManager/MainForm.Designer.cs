namespace OrderManager
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusFinished = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusUnFinished = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusUnPaid = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusImported = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMainView = new System.Windows.Forms.TabPage();
            this.tabDetectView = new System.Windows.Forms.TabPage();
            this.DetectBrowser = new System.Windows.Forms.WebBrowser();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.选项OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuView = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.UserListView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edOrderCount = new System.Windows.Forms.TextBox();
            this.edDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edName = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnSync = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabMainView.SuspendLayout();
            this.tabDetectView.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusTotal,
            this.toolStripStatusLabel2,
            this.statusFinished,
            this.toolStripStatusLabel3,
            this.statusUnFinished,
            this.toolStripStatusLabel4,
            this.statusUnPaid,
            this.toolStripStatusLabel5,
            this.statusImported});
            this.statusStrip1.Location = new System.Drawing.Point(0, 752);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1160, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel1.Text = "订单总数：";
            // 
            // statusTotal
            // 
            this.statusTotal.Name = "statusTotal";
            this.statusTotal.Size = new System.Drawing.Size(15, 17);
            this.statusTotal.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel2.Text = "已完成：";
            // 
            // statusFinished
            // 
            this.statusFinished.Name = "statusFinished";
            this.statusFinished.Size = new System.Drawing.Size(15, 17);
            this.statusFinished.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel3.Text = "未完成：";
            // 
            // statusUnFinished
            // 
            this.statusUnFinished.Name = "statusUnFinished";
            this.statusUnFinished.Size = new System.Drawing.Size(15, 17);
            this.statusUnFinished.Text = "0";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(116, 17);
            this.toolStripStatusLabel4.Text = "拍下未付款傻逼数：";
            // 
            // statusUnPaid
            // 
            this.statusUnPaid.Name = "statusUnPaid";
            this.statusUnPaid.Size = new System.Drawing.Size(15, 17);
            this.statusUnPaid.Text = "0";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel5.Text = "已导入：";
            // 
            // statusImported
            // 
            this.statusImported.Name = "statusImported";
            this.statusImported.Size = new System.Drawing.Size(15, 17);
            this.statusImported.Text = "0";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMainView);
            this.tabControl1.Controls.Add(this.tabDetectView);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1160, 752);
            this.tabControl1.TabIndex = 2;
            // 
            // tabMainView
            // 
            this.tabMainView.Controls.Add(this.btnSync);
            this.tabMainView.Controls.Add(this.btnClean);
            this.tabMainView.Controls.Add(this.btnImport);
            this.tabMainView.Controls.Add(this.btnAdd);
            this.tabMainView.Controls.Add(this.btnStop);
            this.tabMainView.Controls.Add(this.btnStart);
            this.tabMainView.Controls.Add(this.edName);
            this.tabMainView.Controls.Add(this.label3);
            this.tabMainView.Controls.Add(this.edDate);
            this.tabMainView.Controls.Add(this.edOrderCount);
            this.tabMainView.Controls.Add(this.label2);
            this.tabMainView.Controls.Add(this.label1);
            this.tabMainView.Controls.Add(this.UserListView);
            this.tabMainView.Location = new System.Drawing.Point(4, 22);
            this.tabMainView.Name = "tabMainView";
            this.tabMainView.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainView.Size = new System.Drawing.Size(1152, 726);
            this.tabMainView.TabIndex = 0;
            this.tabMainView.Text = "tabPage1";
            this.tabMainView.UseVisualStyleBackColor = true;
            // 
            // tabDetectView
            // 
            this.tabDetectView.Controls.Add(this.DetectBrowser);
            this.tabDetectView.Location = new System.Drawing.Point(4, 22);
            this.tabDetectView.Name = "tabDetectView";
            this.tabDetectView.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetectView.Size = new System.Drawing.Size(1152, 718);
            this.tabDetectView.TabIndex = 1;
            this.tabDetectView.Text = "tabPage2";
            this.tabDetectView.UseVisualStyleBackColor = true;
            // 
            // DetectBrowser
            // 
            this.DetectBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetectBrowser.Location = new System.Drawing.Point(3, 3);
            this.DetectBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.DetectBrowser.Name = "DetectBrowser";
            this.DetectBrowser.Size = new System.Drawing.Size(1146, 712);
            this.DetectBrowser.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.选项OToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1160, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLoad,
            this.toolStripMenuItem1,
            this.menuExit});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // menuLoad
            // 
            this.menuLoad.Name = "menuLoad";
            this.menuLoad.Size = new System.Drawing.Size(118, 22);
            this.menuLoad.Text = "载入(&O)";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(115, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(118, 22);
            this.menuExit.Text = "退出(&E)";
            // 
            // 选项OToolStripMenuItem
            // 
            this.选项OToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSettings,
            this.toolStripMenuItem2,
            this.menuView});
            this.选项OToolStripMenuItem.Name = "选项OToolStripMenuItem";
            this.选项OToolStripMenuItem.Size = new System.Drawing.Size(62, 21);
            this.选项OToolStripMenuItem.Text = "选项(&O)";
            // 
            // menuSettings
            // 
            this.menuSettings.Name = "menuSettings";
            this.menuSettings.Size = new System.Drawing.Size(140, 22);
            this.menuSettings.Text = "设置(&S)";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(137, 6);
            // 
            // menuView
            // 
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(140, 22);
            this.menuView.Text = "视图切换(&V)";
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(116, 22);
            this.menuAbout.Text = "关于(&A)";
            // 
            // UserListView
            // 
            this.UserListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.UserListView.FullRowSelect = true;
            this.UserListView.GridLines = true;
            this.UserListView.Location = new System.Drawing.Point(4, 6);
            this.UserListView.Name = "UserListView";
            this.UserListView.Size = new System.Drawing.Size(1143, 553);
            this.UserListView.TabIndex = 0;
            this.UserListView.UseCompatibleStateImageBehavior = false;
            this.UserListView.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 580);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "订单总数：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 580);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "放单日期：";
            // 
            // edOrderCount
            // 
            this.edOrderCount.Location = new System.Drawing.Point(19, 613);
            this.edOrderCount.Name = "edOrderCount";
            this.edOrderCount.Size = new System.Drawing.Size(119, 21);
            this.edOrderCount.TabIndex = 3;
            // 
            // edDate
            // 
            this.edDate.Location = new System.Drawing.Point(160, 613);
            this.edDate.Name = "edDate";
            this.edDate.Size = new System.Drawing.Size(138, 21);
            this.edDate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 580);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "旺旺名：";
            // 
            // edName
            // 
            this.edName.Location = new System.Drawing.Point(331, 613);
            this.edName.Name = "edName";
            this.edName.Size = new System.Drawing.Size(200, 21);
            this.edName.TabIndex = 6;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(19, 649);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(279, 52);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "新建任务";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(19, 649);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(279, 52);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "终止任务";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(331, 649);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 52);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(568, 613);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(172, 72);
            this.btnImport.TabIndex = 10;
            this.btnImport.Text = "批量导入";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(761, 613);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(172, 72);
            this.btnClean.TabIndex = 11;
            this.btnClean.Text = "清理无效";
            this.btnClean.UseVisualStyleBackColor = true;
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(954, 613);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(172, 72);
            this.btnSync.TabIndex = 12;
            this.btnSync.Text = "同步列表";
            this.btnSync.UseVisualStyleBackColor = true;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "旺旺名";
            this.columnHeader1.Width = 260;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "订单状态";
            this.columnHeader2.Width = 260;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "备注状态";
            this.columnHeader3.Width = 618;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 774);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "放单管家";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabMainView.ResumeLayout(false);
            this.tabMainView.PerformLayout();
            this.tabDetectView.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusTotal;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel statusFinished;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel statusUnFinished;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel statusUnPaid;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel statusImported;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMainView;
        private System.Windows.Forms.TabPage tabDetectView;
        private System.Windows.Forms.WebBrowser DetectBrowser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuLoad;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem 选项OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuView;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox edName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edDate;
        private System.Windows.Forms.TextBox edOrderCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView UserListView;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

