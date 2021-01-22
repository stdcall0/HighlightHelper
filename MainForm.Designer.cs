
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelWorkingDir = new System.Windows.Forms.Label();
            this.labelActiveProfile = new System.Windows.Forms.Label();
            this.labelCountProfile = new System.Windows.Forms.Label();
            this.btnCheckUpd = new System.Windows.Forms.Button();
            this.btnShuffler = new System.Windows.Forms.Button();
            this.groupBoxBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // profileBox
            // 
            this.profileBox.BackColor = System.Drawing.Color.Linen;
            this.profileBox.FormattingEnabled = true;
            this.profileBox.Location = new System.Drawing.Point(117, 12);
            this.profileBox.Name = "profileBox";
            this.profileBox.Size = new System.Drawing.Size(276, 28);
            this.profileBox.TabIndex = 0;
            this.profileBox.SelectedIndexChanged += new System.EventHandler(this.profileBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "选择一个配置..";
            // 
            // btnNewProfile
            // 
            this.btnNewProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProfile.Location = new System.Drawing.Point(27, 71);
            this.btnNewProfile.Name = "btnNewProfile";
            this.btnNewProfile.Size = new System.Drawing.Size(66, 31);
            this.btnNewProfile.TabIndex = 2;
            this.btnNewProfile.Text = "新建...";
            this.btnNewProfile.UseVisualStyleBackColor = true;
            this.btnNewProfile.Click += new System.EventHandler(this.btnNewProfile_Click);
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProfile.Location = new System.Drawing.Point(83, 23);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(66, 31);
            this.btnEditProfile.TabIndex = 3;
            this.btnEditProfile.Text = "编辑...";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // btnSelectProfile
            // 
            this.btnSelectProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectProfile.Location = new System.Drawing.Point(227, 23);
            this.btnSelectProfile.Name = "btnSelectProfile";
            this.btnSelectProfile.Size = new System.Drawing.Size(66, 31);
            this.btnSelectProfile.TabIndex = 4;
            this.btnSelectProfile.Text = "激活";
            this.btnSelectProfile.UseVisualStyleBackColor = true;
            this.btnSelectProfile.Click += new System.EventHandler(this.btnSelectProfile_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Location = new System.Drawing.Point(299, 23);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(66, 31);
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
            this.groupBoxBtn.Location = new System.Drawing.Point(16, 48);
            this.groupBoxBtn.Name = "groupBoxBtn";
            this.groupBoxBtn.Size = new System.Drawing.Size(376, 68);
            this.groupBoxBtn.TabIndex = 6;
            this.groupBoxBtn.TabStop = false;
            this.groupBoxBtn.Text = "操作";
            // 
            // btnDeleteProfile
            // 
            this.btnDeleteProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProfile.Location = new System.Drawing.Point(155, 23);
            this.btnDeleteProfile.Name = "btnDeleteProfile";
            this.btnDeleteProfile.Size = new System.Drawing.Size(66, 31);
            this.btnDeleteProfile.TabIndex = 4;
            this.btnDeleteProfile.Text = "删除";
            this.btnDeleteProfile.UseVisualStyleBackColor = true;
            this.btnDeleteProfile.Click += new System.EventHandler(this.btnDeleteProfile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "活动的配置：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "总配置数：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.label4.Location = new System.Drawing.Point(12, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "程序版本：Release 210120";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "工作目录：";
            // 
            // labelWorkingDir
            // 
            this.labelWorkingDir.AutoSize = true;
            this.labelWorkingDir.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelWorkingDir.Location = new System.Drawing.Point(83, 191);
            this.labelWorkingDir.Name = "labelWorkingDir";
            this.labelWorkingDir.Size = new System.Drawing.Size(0, 16);
            this.labelWorkingDir.TabIndex = 11;
            // 
            // labelActiveProfile
            // 
            this.labelActiveProfile.AutoSize = true;
            this.labelActiveProfile.Location = new System.Drawing.Point(97, 128);
            this.labelActiveProfile.Name = "labelActiveProfile";
            this.labelActiveProfile.Size = new System.Drawing.Size(66, 20);
            this.labelActiveProfile.TabIndex = 12;
            this.labelActiveProfile.Text = "<None>";
            // 
            // labelCountProfile
            // 
            this.labelCountProfile.AutoSize = true;
            this.labelCountProfile.Location = new System.Drawing.Point(83, 148);
            this.labelCountProfile.Name = "labelCountProfile";
            this.labelCountProfile.Size = new System.Drawing.Size(0, 20);
            this.labelCountProfile.TabIndex = 13;
            // 
            // btnCheckUpd
            // 
            this.btnCheckUpd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCheckUpd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckUpd.Location = new System.Drawing.Point(225, 213);
            this.btnCheckUpd.Name = "btnCheckUpd";
            this.btnCheckUpd.Size = new System.Drawing.Size(168, 31);
            this.btnCheckUpd.TabIndex = 14;
            this.btnCheckUpd.Text = "Github 主页";
            this.btnCheckUpd.UseVisualStyleBackColor = true;
            this.btnCheckUpd.Click += new System.EventHandler(this.btnCheckUpd_Click);
            // 
            // btnShuffler
            // 
            this.btnShuffler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnShuffler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShuffler.Location = new System.Drawing.Point(12, 213);
            this.btnShuffler.Name = "btnShuffler";
            this.btnShuffler.Size = new System.Drawing.Size(168, 31);
            this.btnShuffler.TabIndex = 6;
            this.btnShuffler.Text = "工具: 连词成句";
            this.btnShuffler.UseVisualStyleBackColor = true;
            this.btnShuffler.Click += new System.EventHandler(this.btnShuffler_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.CancelButton = this.btnQuit;
            this.ClientSize = new System.Drawing.Size(405, 256);
            this.Controls.Add(this.btnCheckUpd);
            this.Controls.Add(this.btnShuffler);
            this.Controls.Add(this.labelCountProfile);
            this.Controls.Add(this.labelActiveProfile);
            this.Controls.Add(this.labelWorkingDir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNewProfile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.profileBox);
            this.Controls.Add(this.groupBoxBtn);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "高亮管理器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxBtn.ResumeLayout(false);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelWorkingDir;
        private System.Windows.Forms.Label labelActiveProfile;
        private System.Windows.Forms.Label labelCountProfile;
        private System.Windows.Forms.Button btnDeleteProfile;
        private System.Windows.Forms.Button btnCheckUpd;
        private System.Windows.Forms.Button btnShuffler;
    }
}

