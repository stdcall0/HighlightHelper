
namespace HighlightHelper
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.profileBox = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnNewProfile = new System.Windows.Forms.Button();
      this.btnEditProfile = new System.Windows.Forms.Button();
      this.btnSelectProfile = new System.Windows.Forms.Button();
      this.btnQuit = new System.Windows.Forms.Button();
      this.groupBoxBtn = new System.Windows.Forms.GroupBox();
      this.btnDeleteProfile = new System.Windows.Forms.Button();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.itemOpenShuffler = new System.Windows.Forms.ToolStripMenuItem();
      this.itemOpenGithub = new System.Windows.Forms.ToolStripMenuItem();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.statusAct = new System.Windows.Forms.ToolStripStatusLabel();
      this.statusSplit = new System.Windows.Forms.ToolStripStatusLabel();
      this.statusVer = new System.Windows.Forms.ToolStripStatusLabel();
      this.statusSaved = new System.Windows.Forms.ToolStripStatusLabel();
      this.groupBoxBtn.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // profileBox
      // 
      this.profileBox.BackColor = System.Drawing.Color.Linen;
      this.profileBox.Font = new System.Drawing.Font("微软雅黑", 11F);
      this.profileBox.FormattingEnabled = true;
      this.profileBox.Location = new System.Drawing.Point(161, 36);
      this.profileBox.Name = "profileBox";
      this.profileBox.Size = new System.Drawing.Size(513, 28);
      this.profileBox.TabIndex = 0;
      this.profileBox.SelectedIndexChanged += new System.EventHandler(this.profileBox_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("微软雅黑", 11F);
      this.label1.Location = new System.Drawing.Point(20, 39);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(107, 20);
      this.label1.TabIndex = 1;
      this.label1.Text = "选择一个配置..";
      // 
      // btnNewProfile
      // 
      this.btnNewProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnNewProfile.Font = new System.Drawing.Font("微软雅黑", 11F);
      this.btnNewProfile.Location = new System.Drawing.Point(24, 100);
      this.btnNewProfile.Name = "btnNewProfile";
      this.btnNewProfile.Size = new System.Drawing.Size(102, 31);
      this.btnNewProfile.TabIndex = 2;
      this.btnNewProfile.Text = "新建...";
      this.btnNewProfile.UseVisualStyleBackColor = true;
      this.btnNewProfile.Click += new System.EventHandler(this.btnNewProfile_Click);
      // 
      // btnEditProfile
      // 
      this.btnEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnEditProfile.Font = new System.Drawing.Font("微软雅黑", 11F);
      this.btnEditProfile.Location = new System.Drawing.Point(145, 23);
      this.btnEditProfile.Name = "btnEditProfile";
      this.btnEditProfile.Size = new System.Drawing.Size(102, 31);
      this.btnEditProfile.TabIndex = 3;
      this.btnEditProfile.Text = "编辑...";
      this.btnEditProfile.UseVisualStyleBackColor = true;
      this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
      // 
      // btnSelectProfile
      // 
      this.btnSelectProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSelectProfile.Font = new System.Drawing.Font("微软雅黑", 11F);
      this.btnSelectProfile.Location = new System.Drawing.Point(419, 23);
      this.btnSelectProfile.Name = "btnSelectProfile";
      this.btnSelectProfile.Size = new System.Drawing.Size(102, 31);
      this.btnSelectProfile.TabIndex = 4;
      this.btnSelectProfile.Text = "激活";
      this.btnSelectProfile.UseVisualStyleBackColor = true;
      this.btnSelectProfile.Click += new System.EventHandler(this.btnSelectProfile_Click);
      // 
      // btnQuit
      // 
      this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnQuit.Font = new System.Drawing.Font("微软雅黑", 11F);
      this.btnQuit.Location = new System.Drawing.Point(556, 23);
      this.btnQuit.Name = "btnQuit";
      this.btnQuit.Size = new System.Drawing.Size(102, 31);
      this.btnQuit.TabIndex = 5;
      this.btnQuit.Text = "退出";
      this.btnQuit.UseVisualStyleBackColor = true;
      this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
      // 
      // groupBoxBtn
      // 
      this.groupBoxBtn.Controls.Add(this.btnDeleteProfile);
      this.groupBoxBtn.Controls.Add(this.btnEditProfile);
      this.groupBoxBtn.Controls.Add(this.btnSelectProfile);
      this.groupBoxBtn.Controls.Add(this.btnQuit);
      this.groupBoxBtn.Font = new System.Drawing.Font("微软雅黑", 11F);
      this.groupBoxBtn.Location = new System.Drawing.Point(16, 77);
      this.groupBoxBtn.Name = "groupBoxBtn";
      this.groupBoxBtn.Size = new System.Drawing.Size(666, 68);
      this.groupBoxBtn.TabIndex = 6;
      this.groupBoxBtn.TabStop = false;
      this.groupBoxBtn.Text = "操作";
      // 
      // btnDeleteProfile
      // 
      this.btnDeleteProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnDeleteProfile.Font = new System.Drawing.Font("微软雅黑", 11F);
      this.btnDeleteProfile.Location = new System.Drawing.Point(282, 23);
      this.btnDeleteProfile.Name = "btnDeleteProfile";
      this.btnDeleteProfile.Size = new System.Drawing.Size(102, 31);
      this.btnDeleteProfile.TabIndex = 4;
      this.btnDeleteProfile.Text = "删除";
      this.btnDeleteProfile.UseVisualStyleBackColor = true;
      this.btnDeleteProfile.Click += new System.EventHandler(this.btnDeleteProfile_Click);
      // 
      // menuStrip1
      // 
      this.menuStrip1.BackColor = System.Drawing.Color.Linen;
      this.menuStrip1.Font = new System.Drawing.Font("微软雅黑", 11F);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemOpenShuffler,
            this.itemOpenGithub});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(694, 28);
      this.menuStrip1.TabIndex = 15;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // itemOpenShuffler
      // 
      this.itemOpenShuffler.Name = "itemOpenShuffler";
      this.itemOpenShuffler.Size = new System.Drawing.Size(81, 24);
      this.itemOpenShuffler.Text = "连词成句";
      this.itemOpenShuffler.Click += new System.EventHandler(this.itemOpenShuffler_Click);
      // 
      // itemOpenGithub
      // 
      this.itemOpenGithub.Name = "itemOpenGithub";
      this.itemOpenGithub.Size = new System.Drawing.Size(107, 24);
      this.itemOpenGithub.Text = "GitHub 主页";
      this.itemOpenGithub.Click += new System.EventHandler(this.itemOpenGithub_Click);
      // 
      // statusStrip1
      // 
      this.statusStrip1.BackColor = System.Drawing.Color.Linen;
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusAct,
            this.statusSplit,
            this.statusVer,
            this.statusSaved});
      this.statusStrip1.Location = new System.Drawing.Point(0, 154);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(694, 25);
      this.statusStrip1.TabIndex = 16;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // statusAct
      // 
      this.statusAct.Font = new System.Drawing.Font("微软雅黑", 11F);
      this.statusAct.Name = "statusAct";
      this.statusAct.Size = new System.Drawing.Size(31, 20);
      this.statusAct.Text = "act";
      // 
      // statusSplit
      // 
      this.statusSplit.Font = new System.Drawing.Font("微软雅黑", 11F);
      this.statusSplit.Name = "statusSplit";
      this.statusSplit.Size = new System.Drawing.Size(536, 20);
      this.statusSplit.Spring = true;
      // 
      // statusVer
      // 
      this.statusVer.Font = new System.Drawing.Font("微软雅黑", 11F);
      this.statusVer.Name = "statusVer";
      this.statusVer.Size = new System.Drawing.Size(32, 20);
      this.statusVer.Text = "ver";
      // 
      // statusSaved
      // 
      this.statusSaved.Font = new System.Drawing.Font("微软雅黑", 11F);
      this.statusSaved.Name = "statusSaved";
      this.statusSaved.Size = new System.Drawing.Size(80, 20);
      this.statusSaved.Text = "Loading...";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.BackColor = System.Drawing.Color.Linen;
      this.CancelButton = this.btnQuit;
      this.ClientSize = new System.Drawing.Size(694, 179);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.btnNewProfile);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.profileBox);
      this.Controls.Add(this.groupBoxBtn);
      this.Controls.Add(this.menuStrip1);
      this.Font = new System.Drawing.Font("微软雅黑", 11F);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "高亮管理器";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.groupBoxBtn.ResumeLayout(false);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox profileBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewProfile;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnSelectProfile;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.GroupBox groupBoxBtn;
        private System.Windows.Forms.Button btnDeleteProfile;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem itemOpenShuffler;
    private System.Windows.Forms.ToolStripMenuItem itemOpenGithub;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel statusAct;
    private System.Windows.Forms.ToolStripStatusLabel statusVer;
    private System.Windows.Forms.ToolStripStatusLabel statusSplit;
    private System.Windows.Forms.ToolStripStatusLabel statusSaved;
  }
}

