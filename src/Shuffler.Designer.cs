
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
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.valFirstNum = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.valSentenceSplit = new System.Windows.Forms.ToolStripTextBox();
            this.valWordSplit = new System.Windows.Forms.ToolStripTextBox();
            this.toolSort = new System.Windows.Forms.ToolStripDropDownButton();
            this.itemAsc = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDesc = new System.Windows.Forms.ToolStripMenuItem();
            this.itemShuffle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnPaste = new System.Windows.Forms.ToolStripButton();
            this.btnCopyResult = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnToggleMode = new System.Windows.Forms.ToolStripButton();
            this.labelMode = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDebug = new System.Windows.Forms.ToolStripButton();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.valOutputSplit = new System.Windows.Forms.ToolStripTextBox();
            this.strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // valSent
            // 
            this.valSent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valSent.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.valSent.Location = new System.Drawing.Point(13, 33);
            this.valSent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.valSent.Multiline = true;
            this.valSent.Name = "valSent";
            this.valSent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.valSent.Size = new System.Drawing.Size(660, 291);
            this.valSent.TabIndex = 1;
            this.valSent.TextChanged += new System.EventHandler(this.valSent_TextChanged);
            // 
            // valOutput
            // 
            this.valOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valOutput.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.valOutput.Location = new System.Drawing.Point(13, 327);
            this.valOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.valOutput.Multiline = true;
            this.valOutput.Name = "valOutput";
            this.valOutput.ReadOnly = true;
            this.valOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.valOutput.Size = new System.Drawing.Size(660, 181);
            this.valOutput.TabIndex = 8;
            // 
            // strip
            // 
            this.strip.BackColor = System.Drawing.Color.Linen;
            this.strip.Font = new System.Drawing.Font("Sarasa UI SC Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolOpt,
            this.toolSort,
            this.toolStripSeparator1,
            this.btnRefresh,
            this.btnPaste,
            this.btnCopyResult,
            this.toolStripSeparator4,
            this.btnToggleMode,
            this.labelMode,
            this.toolStripSeparator5,
            this.btnDebug});
            this.strip.Location = new System.Drawing.Point(0, 0);
            this.strip.Name = "strip";
            this.strip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.strip.Size = new System.Drawing.Size(685, 27);
            this.strip.TabIndex = 17;
            this.strip.Text = "toolStrip";
            // 
            // toolOpt
            // 
            this.toolOpt.BackColor = System.Drawing.Color.Linen;
            this.toolOpt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemAddNumber,
            this.itemAddMark,
            this.itemFixChnSymbol,
            this.itemTolowercase,
            this.itemKeepfront,
            this.itemAutoSplit,
            this.toolStripSeparator2,
            this.ToolStripMenuItem1,
            this.valFirstNum,
            this.toolStripSeparator3,
            this.ToolStripMenuItem2,
            this.valSentenceSplit,
            this.toolStripMenuItem3,
            this.valWordSplit,
            this.toolStripMenuItem4,
            this.valOutputSplit});
            this.toolOpt.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.toolOpt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolOpt.Name = "toolOpt";
            this.toolOpt.Size = new System.Drawing.Size(52, 24);
            this.toolOpt.Text = "选项";
            // 
            // itemAddNumber
            // 
            this.itemAddNumber.Checked = true;
            this.itemAddNumber.CheckOnClick = true;
            this.itemAddNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.itemAddNumber.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.itemAddNumber.Name = "itemAddNumber";
            this.itemAddNumber.Size = new System.Drawing.Size(213, 24);
            this.itemAddNumber.Text = "添加序号";
            // 
            // itemAddMark
            // 
            this.itemAddMark.Checked = true;
            this.itemAddMark.CheckOnClick = true;
            this.itemAddMark.CheckState = System.Windows.Forms.CheckState.Checked;
            this.itemAddMark.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.itemAddMark.Name = "itemAddMark";
            this.itemAddMark.Size = new System.Drawing.Size(213, 24);
            this.itemAddMark.Text = "添加标点符号";
            // 
            // itemFixChnSymbol
            // 
            this.itemFixChnSymbol.Checked = true;
            this.itemFixChnSymbol.CheckOnClick = true;
            this.itemFixChnSymbol.CheckState = System.Windows.Forms.CheckState.Checked;
            this.itemFixChnSymbol.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.itemFixChnSymbol.Name = "itemFixChnSymbol";
            this.itemFixChnSymbol.Size = new System.Drawing.Size(213, 24);
            this.itemFixChnSymbol.Text = "替换全角标点为半角";
            // 
            // itemTolowercase
            // 
            this.itemTolowercase.CheckOnClick = true;
            this.itemTolowercase.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.itemTolowercase.Name = "itemTolowercase";
            this.itemTolowercase.Size = new System.Drawing.Size(213, 24);
            this.itemTolowercase.Text = "首字母转小写";
            // 
            // itemKeepfront
            // 
            this.itemKeepfront.Checked = true;
            this.itemKeepfront.CheckOnClick = true;
            this.itemKeepfront.CheckState = System.Windows.Forms.CheckState.Checked;
            this.itemKeepfront.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.itemKeepfront.Name = "itemKeepfront";
            this.itemKeepfront.Size = new System.Drawing.Size(213, 24);
            this.itemKeepfront.Text = "句首词保持最前";
            // 
            // itemAutoSplit
            // 
            this.itemAutoSplit.Checked = true;
            this.itemAutoSplit.CheckOnClick = true;
            this.itemAutoSplit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.itemAutoSplit.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.itemAutoSplit.Name = "itemAutoSplit";
            this.itemAutoSplit.Size = new System.Drawing.Size(213, 24);
            this.itemAutoSplit.Text = "自动分句";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(210, 6);
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Enabled = false;
            this.ToolStripMenuItem1.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(213, 24);
            this.ToolStripMenuItem1.Text = "起始数字";
            // 
            // valFirstNum
            // 
            this.valFirstNum.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.valFirstNum.Name = "valFirstNum";
            this.valFirstNum.Size = new System.Drawing.Size(100, 27);
            this.valFirstNum.Text = "1";
            this.valFirstNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valFirstNum_KeyPress);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(210, 6);
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.Enabled = false;
            this.ToolStripMenuItem2.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(213, 24);
            this.ToolStripMenuItem2.Text = "断句符号";
            // 
            // valSentenceSplit
            // 
            this.valSentenceSplit.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.valSentenceSplit.Name = "valSentenceSplit";
            this.valSentenceSplit.Size = new System.Drawing.Size(100, 27);
            // 
            // valWordSplit
            // 
            this.valWordSplit.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.valWordSplit.Name = "valWordSplit";
            this.valWordSplit.Size = new System.Drawing.Size(100, 27);
            // 
            // toolSort
            // 
            this.toolSort.BackColor = System.Drawing.Color.Linen;
            this.toolSort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemAsc,
            this.itemDesc,
            this.itemShuffle});
            this.toolSort.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.toolSort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSort.Name = "toolSort";
            this.toolSort.Size = new System.Drawing.Size(52, 24);
            this.toolSort.Text = "排序";
            // 
            // itemAsc
            // 
            this.itemAsc.Checked = true;
            this.itemAsc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.itemAsc.Name = "itemAsc";
            this.itemAsc.Size = new System.Drawing.Size(108, 24);
            this.itemAsc.Text = "顺序";
            // 
            // itemDesc
            // 
            this.itemDesc.Name = "itemDesc";
            this.itemDesc.Size = new System.Drawing.Size(108, 24);
            this.itemDesc.Text = "倒序";
            // 
            // itemShuffle
            // 
            this.itemShuffle.Name = "itemShuffle";
            this.itemShuffle.Size = new System.Drawing.Size(108, 24);
            this.itemShuffle.Text = "乱序";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.Linen;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Linen;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(43, 24);
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.BackColor = System.Drawing.Color.Linen;
            this.btnPaste.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.btnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(73, 24);
            this.btnPaste.Text = "粘贴输入";
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnCopyResult
            // 
            this.btnCopyResult.BackColor = System.Drawing.Color.Linen;
            this.btnCopyResult.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.btnCopyResult.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopyResult.Name = "btnCopyResult";
            this.btnCopyResult.Size = new System.Drawing.Size(73, 24);
            this.btnCopyResult.Text = "复制输出";
            this.btnCopyResult.Click += new System.EventHandler(this.btnCopyResult_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // btnToggleMode
            // 
            this.btnToggleMode.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.btnToggleMode.Name = "btnToggleMode";
            this.btnToggleMode.Size = new System.Drawing.Size(73, 24);
            this.btnToggleMode.Text = "切换模式";
            this.btnToggleMode.Click += new System.EventHandler(this.btnToggleMode_Click);
            // 
            // labelMode
            // 
            this.labelMode.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(62, 24);
            this.labelMode.Text = "[mode]";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // btnDebug
            // 
            this.btnDebug.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(23, 24);
            this.btnDebug.Text = " ";
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Enabled = false;
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(213, 24);
            this.toolStripMenuItem3.Text = "单词间符号";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Enabled = false;
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(213, 24);
            this.toolStripMenuItem4.Text = "输出分隔符";
            // 
            // valOutputSplit
            // 
            this.valOutputSplit.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.valOutputSplit.Name = "valOutputSplit";
            this.valOutputSplit.Size = new System.Drawing.Size(100, 27);
            // 
            // Shuffler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(685, 518);
            this.Controls.Add(this.strip);
            this.Controls.Add(this.valOutput);
            this.Controls.Add(this.valSent);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Shuffler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Shuffler";
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
    private System.Windows.Forms.ToolStripDropDownButton toolSort;
    private System.Windows.Forms.ToolStripMenuItem itemAsc;
    private System.Windows.Forms.ToolStripMenuItem itemDesc;
    private System.Windows.Forms.ToolStripMenuItem itemShuffle;
    private System.Windows.Forms.ToolStripMenuItem itemAutoSplit;
    private System.Windows.Forms.ToolStripButton btnRefresh;
    private System.Windows.Forms.ToolStripButton btnCopyResult;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
    private System.Windows.Forms.ToolStripTextBox valFirstNum;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem2;
    private System.Windows.Forms.ToolStripTextBox valSentenceSplit;
    private System.Windows.Forms.ToolStripButton btnPaste;
    private System.Windows.Forms.ToolStripButton btnToggleMode;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripLabel labelMode;
    private System.Windows.Forms.ToolStripTextBox valWordSplit;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripButton btnDebug;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripTextBox valOutputSplit;
    }
}