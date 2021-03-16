
namespace HighlightHelper {
    partial class Shuffler {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shuffler));
      this.valSent = new System.Windows.Forms.TextBox();
      this.valOutput = new System.Windows.Forms.TextBox();
      this.strip = new System.Windows.Forms.ToolStrip();
      this.toolOpt = new System.Windows.Forms.ToolStripDropDownButton();
      this.itemAddNumber = new System.Windows.Forms.ToolStripMenuItem();
      this.itemAddMark = new System.Windows.Forms.ToolStripMenuItem();
      this.itemFixChnSymbol = new System.Windows.Forms.ToolStripMenuItem();
      this.itemTolowercase = new System.Windows.Forms.ToolStripMenuItem();
      this.itemKeepfront = new System.Windows.Forms.ToolStripMenuItem();
      this.itemAutoSplit = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
      this.itemAsc = new System.Windows.Forms.ToolStripMenuItem();
      this.itemDesc = new System.Windows.Forms.ToolStripMenuItem();
      this.itemShuffle = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
      this.btnRefresh = new System.Windows.Forms.ToolStripButton();
      this.btnCopyResult = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.起始数字ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.valFirstNum = new System.Windows.Forms.ToolStripTextBox();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.单词间分隔符ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.valSplitText = new System.Windows.Forms.ToolStripTextBox();
      this.strip.SuspendLayout();
      this.SuspendLayout();
      // 
      // valSent
      // 
      this.valSent.Font = new System.Drawing.Font("更纱黑体 UI SC Semibold", 11F, System.Drawing.FontStyle.Bold);
      this.valSent.Location = new System.Drawing.Point(13, 31);
      this.valSent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.valSent.Multiline = true;
      this.valSent.Name = "valSent";
      this.valSent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.valSent.Size = new System.Drawing.Size(556, 175);
      this.valSent.TabIndex = 1;
      this.valSent.TextChanged += new System.EventHandler(this.valSent_TextChanged);
      // 
      // valOutput
      // 
      this.valOutput.Font = new System.Drawing.Font("更纱黑体 UI SC Semibold", 11F, System.Drawing.FontStyle.Bold);
      this.valOutput.Location = new System.Drawing.Point(13, 209);
      this.valOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.valOutput.Multiline = true;
      this.valOutput.Name = "valOutput";
      this.valOutput.ReadOnly = true;
      this.valOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.valOutput.Size = new System.Drawing.Size(556, 172);
      this.valOutput.TabIndex = 8;
      // 
      // strip
      // 
      this.strip.Font = new System.Drawing.Font("更纱黑体 UI SC Semibold", 11F, System.Drawing.FontStyle.Bold);
      this.strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolOpt,
            this.toolStripDropDownButton2,
            this.toolStripSeparator1,
            this.btnRefresh,
            this.btnCopyResult});
      this.strip.Location = new System.Drawing.Point(0, 0);
      this.strip.Name = "strip";
      this.strip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
      this.strip.Size = new System.Drawing.Size(581, 26);
      this.strip.TabIndex = 17;
      this.strip.Text = "toolStrip";
      // 
      // toolOpt
      // 
      this.toolOpt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemAddNumber,
            this.itemAddMark,
            this.itemFixChnSymbol,
            this.itemTolowercase,
            this.itemKeepfront,
            this.itemAutoSplit,
            this.toolStripSeparator2,
            this.起始数字ToolStripMenuItem,
            this.valFirstNum,
            this.toolStripSeparator3,
            this.单词间分隔符ToolStripMenuItem,
            this.valSplitText});
      this.toolOpt.Font = new System.Drawing.Font("更纱黑体 UI SC Semibold", 11F, System.Drawing.FontStyle.Bold);
      this.toolOpt.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolOpt.Name = "toolOpt";
      this.toolOpt.Size = new System.Drawing.Size(52, 23);
      this.toolOpt.Text = "选项";
      // 
      // itemAddNumber
      // 
      this.itemAddNumber.Checked = true;
      this.itemAddNumber.CheckOnClick = true;
      this.itemAddNumber.CheckState = System.Windows.Forms.CheckState.Checked;
      this.itemAddNumber.Name = "itemAddNumber";
      this.itemAddNumber.Size = new System.Drawing.Size(213, 24);
      this.itemAddNumber.Text = "添加序号";
      // 
      // itemAddMark
      // 
      this.itemAddMark.Checked = true;
      this.itemAddMark.CheckOnClick = true;
      this.itemAddMark.CheckState = System.Windows.Forms.CheckState.Checked;
      this.itemAddMark.Font = new System.Drawing.Font("更纱黑体 UI SC Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
      this.itemAddMark.Name = "itemAddMark";
      this.itemAddMark.Size = new System.Drawing.Size(213, 24);
      this.itemAddMark.Text = "添加标点符号";
      // 
      // itemFixChnSymbol
      // 
      this.itemFixChnSymbol.Checked = true;
      this.itemFixChnSymbol.CheckOnClick = true;
      this.itemFixChnSymbol.CheckState = System.Windows.Forms.CheckState.Checked;
      this.itemFixChnSymbol.Name = "itemFixChnSymbol";
      this.itemFixChnSymbol.Size = new System.Drawing.Size(213, 24);
      this.itemFixChnSymbol.Text = "替换全角标点为半角";
      // 
      // itemTolowercase
      // 
      this.itemTolowercase.CheckOnClick = true;
      this.itemTolowercase.Name = "itemTolowercase";
      this.itemTolowercase.Size = new System.Drawing.Size(213, 24);
      this.itemTolowercase.Text = "首字母转小写";
      // 
      // itemKeepfront
      // 
      this.itemKeepfront.Checked = true;
      this.itemKeepfront.CheckOnClick = true;
      this.itemKeepfront.CheckState = System.Windows.Forms.CheckState.Checked;
      this.itemKeepfront.Name = "itemKeepfront";
      this.itemKeepfront.Size = new System.Drawing.Size(213, 24);
      this.itemKeepfront.Text = "句首词保持最前";
      // 
      // itemAutoSplit
      // 
      this.itemAutoSplit.Checked = true;
      this.itemAutoSplit.CheckOnClick = true;
      this.itemAutoSplit.CheckState = System.Windows.Forms.CheckState.Checked;
      this.itemAutoSplit.Name = "itemAutoSplit";
      this.itemAutoSplit.Size = new System.Drawing.Size(213, 24);
      this.itemAutoSplit.Text = "自动分句";
      // 
      // toolStripDropDownButton2
      // 
      this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemAsc,
            this.itemDesc,
            this.itemShuffle});
      this.toolStripDropDownButton2.Font = new System.Drawing.Font("更纱黑体 UI SC Semibold", 11F, System.Drawing.FontStyle.Bold);
      this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
      this.toolStripDropDownButton2.Size = new System.Drawing.Size(52, 23);
      this.toolStripDropDownButton2.Text = "排序";
      // 
      // itemAsc
      // 
      this.itemAsc.Checked = true;
      this.itemAsc.CheckState = System.Windows.Forms.CheckState.Checked;
      this.itemAsc.Name = "itemAsc";
      this.itemAsc.Size = new System.Drawing.Size(180, 24);
      this.itemAsc.Text = "顺序";
      this.itemAsc.Click += new System.EventHandler(this.itemAsc_Click);
      // 
      // itemDesc
      // 
      this.itemDesc.Name = "itemDesc";
      this.itemDesc.Size = new System.Drawing.Size(180, 24);
      this.itemDesc.Text = "倒序";
      this.itemDesc.Click += new System.EventHandler(this.itemDesc_Click);
      // 
      // itemShuffle
      // 
      this.itemShuffle.Name = "itemShuffle";
      this.itemShuffle.Size = new System.Drawing.Size(180, 24);
      this.itemShuffle.Text = "乱序";
      this.itemShuffle.Click += new System.EventHandler(this.itemShuffle_Click);
      // 
      // toolStripButton1
      // 
      this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
      this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButton1.Name = "toolStripButton1";
      this.toolStripButton1.Size = new System.Drawing.Size(23, 23);
      this.toolStripButton1.Text = "toolStripButton1";
      // 
      // btnRefresh
      // 
      this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnRefresh.Name = "btnRefresh";
      this.btnRefresh.Size = new System.Drawing.Size(43, 23);
      this.btnRefresh.Text = "刷新";
      this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
      // 
      // btnCopyResult
      // 
      this.btnCopyResult.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnCopyResult.Name = "btnCopyResult";
      this.btnCopyResult.Size = new System.Drawing.Size(73, 23);
      this.btnCopyResult.Text = "复制输出";
      this.btnCopyResult.Click += new System.EventHandler(this.btnCopyResult_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(210, 6);
      // 
      // 起始数字ToolStripMenuItem
      // 
      this.起始数字ToolStripMenuItem.Enabled = false;
      this.起始数字ToolStripMenuItem.Name = "起始数字ToolStripMenuItem";
      this.起始数字ToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
      this.起始数字ToolStripMenuItem.Text = "起始数字";
      // 
      // valFirstNum
      // 
      this.valFirstNum.Font = new System.Drawing.Font("更纱黑体 UI SC", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
      this.valFirstNum.Name = "valFirstNum";
      this.valFirstNum.Size = new System.Drawing.Size(100, 22);
      this.valFirstNum.Text = "1";
      this.valFirstNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valFirstNum_KeyPress);
      this.valFirstNum.TextChanged += new System.EventHandler(this.valFirstNum_TextChanged);
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(210, 6);
      // 
      // 单词间分隔符ToolStripMenuItem
      // 
      this.单词间分隔符ToolStripMenuItem.Enabled = false;
      this.单词间分隔符ToolStripMenuItem.Name = "单词间分隔符ToolStripMenuItem";
      this.单词间分隔符ToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
      this.单词间分隔符ToolStripMenuItem.Text = "单词间分隔符";
      // 
      // valSplitText
      // 
      this.valSplitText.Font = new System.Drawing.Font("更纱黑体 UI SC", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
      this.valSplitText.Name = "valSplitText";
      this.valSplitText.Size = new System.Drawing.Size(100, 22);
      this.valSplitText.Text = " | ";
      this.valSplitText.TextChanged += new System.EventHandler(this.valSplitText_TextChanged);
      // 
      // Shuffler
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ControlDark;
      this.ClientSize = new System.Drawing.Size(581, 390);
      this.Controls.Add(this.strip);
      this.Controls.Add(this.valOutput);
      this.Controls.Add(this.valSent);
      this.Font = new System.Drawing.Font("更纱黑体 UI SC Semibold", 11F, System.Drawing.FontStyle.Bold);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "Shuffler";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "连词成句助手";
      this.Load += new System.EventHandler(this.Shuffler_Load);
      this.strip.ResumeLayout(false);
      this.strip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox valSent;
        private System.Windows.Forms.TextBox valOutput;
        private System.Windows.Forms.ToolStrip strip;
    private System.Windows.Forms.ToolStripDropDownButton toolOpt;
    private System.Windows.Forms.ToolStripMenuItem itemAddNumber;
    private System.Windows.Forms.ToolStripMenuItem itemAddMark;
    private System.Windows.Forms.ToolStripMenuItem itemFixChnSymbol;
    private System.Windows.Forms.ToolStripMenuItem itemTolowercase;
    private System.Windows.Forms.ToolStripMenuItem itemKeepfront;
    private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
    private System.Windows.Forms.ToolStripMenuItem itemAsc;
    private System.Windows.Forms.ToolStripMenuItem itemDesc;
    private System.Windows.Forms.ToolStripMenuItem itemShuffle;
    private System.Windows.Forms.ToolStripMenuItem itemAutoSplit;
    private System.Windows.Forms.ToolStripButton btnRefresh;
    private System.Windows.Forms.ToolStripButton toolStripButton1;
    private System.Windows.Forms.ToolStripButton btnCopyResult;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem 起始数字ToolStripMenuItem;
    private System.Windows.Forms.ToolStripTextBox valFirstNum;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripMenuItem 单词间分隔符ToolStripMenuItem;
    private System.Windows.Forms.ToolStripTextBox valSplitText;
  }
}