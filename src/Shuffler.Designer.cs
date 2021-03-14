
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
            this.valAddNumber = new System.Windows.Forms.CheckBox();
            this.valAddMark = new System.Windows.Forms.CheckBox();
            this.valFixChnSymbol = new System.Windows.Forms.CheckBox();
            this.valFirstNumber = new System.Windows.Forms.NumericUpDown();
            this.valOutput = new System.Windows.Forms.TextBox();
            this.btnDoit = new System.Windows.Forms.Button();
            this.valUpcase = new System.Windows.Forms.CheckBox();
            this.valNoSplit = new System.Windows.Forms.CheckBox();
            this.valKeepFirst = new System.Windows.Forms.CheckBox();
            this.valSort = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.valSplitter = new System.Windows.Forms.TextBox();
            this.btnCopyOutput = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.valFirstNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // valSent
            // 
            this.valSent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valSent.Location = new System.Drawing.Point(12, 13);
            this.valSent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.valSent.Multiline = true;
            this.valSent.Name = "valSent";
            this.valSent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.valSent.Size = new System.Drawing.Size(403, 141);
            this.valSent.TabIndex = 1;
            this.valSent.TextChanged += new System.EventHandler(this.valSent_TextChanged);
            // 
            // valAddNumber
            // 
            this.valAddNumber.AutoSize = true;
            this.valAddNumber.Checked = true;
            this.valAddNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.valAddNumber.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.valAddNumber.Location = new System.Drawing.Point(12, 324);
            this.valAddNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.valAddNumber.Name = "valAddNumber";
            this.valAddNumber.Size = new System.Drawing.Size(320, 24);
            this.valAddNumber.TabIndex = 2;
            this.valAddNumber.Text = "添加序号，从                                             开始";
            this.valAddNumber.UseVisualStyleBackColor = true;
            this.valAddNumber.CheckedChanged += new System.EventHandler(this.valAddNumber_CheckedChanged);
            // 
            // valAddMark
            // 
            this.valAddMark.AutoSize = true;
            this.valAddMark.Checked = true;
            this.valAddMark.CheckState = System.Windows.Forms.CheckState.Checked;
            this.valAddMark.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.valAddMark.Location = new System.Drawing.Point(12, 356);
            this.valAddMark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.valAddMark.Name = "valAddMark";
            this.valAddMark.Size = new System.Drawing.Size(112, 24);
            this.valAddMark.TabIndex = 3;
            this.valAddMark.Text = "添加标点符号";
            this.valAddMark.UseVisualStyleBackColor = true;
            this.valAddMark.CheckedChanged += new System.EventHandler(this.valAddMark_CheckedChanged);
            // 
            // valFixChnSymbol
            // 
            this.valFixChnSymbol.AutoSize = true;
            this.valFixChnSymbol.Checked = true;
            this.valFixChnSymbol.CheckState = System.Windows.Forms.CheckState.Checked;
            this.valFixChnSymbol.Enabled = false;
            this.valFixChnSymbol.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.valFixChnSymbol.Location = new System.Drawing.Point(130, 356);
            this.valFixChnSymbol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.valFixChnSymbol.Name = "valFixChnSymbol";
            this.valFixChnSymbol.Size = new System.Drawing.Size(154, 24);
            this.valFixChnSymbol.TabIndex = 4;
            this.valFixChnSymbol.Text = "替换全角标点为半角";
            this.valFixChnSymbol.UseVisualStyleBackColor = true;
            this.valFixChnSymbol.CheckedChanged += new System.EventHandler(this.valFixChnSymbol_CheckedChanged);
            // 
            // valFirstNumber
            // 
            this.valFirstNumber.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.valFirstNumber.Location = new System.Drawing.Point(139, 326);
            this.valFirstNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.valFirstNumber.Name = "valFirstNumber";
            this.valFirstNumber.Size = new System.Drawing.Size(140, 23);
            this.valFirstNumber.TabIndex = 5;
            this.valFirstNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valFirstNumber.ValueChanged += new System.EventHandler(this.valFirstNumber_ValueChanged);
            // 
            // valOutput
            // 
            this.valOutput.Font = new System.Drawing.Font("Arial", 12F);
            this.valOutput.Location = new System.Drawing.Point(12, 162);
            this.valOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.valOutput.Multiline = true;
            this.valOutput.Name = "valOutput";
            this.valOutput.ReadOnly = true;
            this.valOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.valOutput.Size = new System.Drawing.Size(403, 141);
            this.valOutput.TabIndex = 8;
            // 
            // btnDoit
            // 
            this.btnDoit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoit.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDoit.Location = new System.Drawing.Point(290, 356);
            this.btnDoit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDoit.Name = "btnDoit";
            this.btnDoit.Size = new System.Drawing.Size(125, 47);
            this.btnDoit.TabIndex = 9;
            this.btnDoit.Text = "DO IT!";
            this.btnDoit.UseVisualStyleBackColor = true;
            this.btnDoit.Click += new System.EventHandler(this.btnDoit_Click);
            // 
            // valUpcase
            // 
            this.valUpcase.AutoSize = true;
            this.valUpcase.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.valUpcase.Location = new System.Drawing.Point(12, 388);
            this.valUpcase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.valUpcase.Name = "valUpcase";
            this.valUpcase.Size = new System.Drawing.Size(112, 24);
            this.valUpcase.TabIndex = 10;
            this.valUpcase.Text = "首字母转小写";
            this.valUpcase.UseVisualStyleBackColor = true;
            this.valUpcase.CheckedChanged += new System.EventHandler(this.valUpcase_CheckedChanged);
            // 
            // valNoSplit
            // 
            this.valNoSplit.AutoSize = true;
            this.valNoSplit.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.valNoSplit.Location = new System.Drawing.Point(12, 420);
            this.valNoSplit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.valNoSplit.Name = "valNoSplit";
            this.valNoSplit.Size = new System.Drawing.Size(98, 24);
            this.valNoSplit.TabIndex = 11;
            this.valNoSplit.Text = "每行为一句";
            this.valNoSplit.UseVisualStyleBackColor = true;
            this.valNoSplit.CheckedChanged += new System.EventHandler(this.valNoSplit_CheckedChanged);
            // 
            // valKeepFirst
            // 
            this.valKeepFirst.AutoSize = true;
            this.valKeepFirst.Checked = true;
            this.valKeepFirst.CheckState = System.Windows.Forms.CheckState.Checked;
            this.valKeepFirst.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.valKeepFirst.Location = new System.Drawing.Point(130, 388);
            this.valKeepFirst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.valKeepFirst.Name = "valKeepFirst";
            this.valKeepFirst.Size = new System.Drawing.Size(126, 24);
            this.valKeepFirst.TabIndex = 12;
            this.valKeepFirst.Text = "句首词保持最前";
            this.valKeepFirst.UseVisualStyleBackColor = true;
            this.valKeepFirst.CheckedChanged += new System.EventHandler(this.valKeepFirst_CheckedChanged);
            // 
            // valSort
            // 
            this.valSort.AutoSize = true;
            this.valSort.Checked = true;
            this.valSort.CheckState = System.Windows.Forms.CheckState.Checked;
            this.valSort.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.valSort.Location = new System.Drawing.Point(130, 420);
            this.valSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.valSort.Name = "valSort";
            this.valSort.Size = new System.Drawing.Size(140, 24);
            this.valSort.TabIndex = 13;
            this.valSort.Text = "排序，而不是乱序";
            this.valSort.UseVisualStyleBackColor = true;
            this.valSort.CheckedChanged += new System.EventHandler(this.valSort_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F);
            this.label1.Location = new System.Drawing.Point(17, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "单词间分隔符";
            // 
            // valSplitter
            // 
            this.valSplitter.Location = new System.Drawing.Point(130, 449);
            this.valSplitter.Name = "valSplitter";
            this.valSplitter.Size = new System.Drawing.Size(140, 21);
            this.valSplitter.TabIndex = 15;
            this.valSplitter.Text = ", ";
            this.valSplitter.TextChanged += new System.EventHandler(this.valSplitter_TextChanged);
            // 
            // btnCopyOutput
            // 
            this.btnCopyOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyOutput.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCopyOutput.Location = new System.Drawing.Point(290, 420);
            this.btnCopyOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCopyOutput.Name = "btnCopyOutput";
            this.btnCopyOutput.Size = new System.Drawing.Size(125, 47);
            this.btnCopyOutput.TabIndex = 16;
            this.btnCopyOutput.Text = "COPY RESULT";
            this.btnCopyOutput.UseVisualStyleBackColor = true;
            this.btnCopyOutput.Click += new System.EventHandler(this.btnCopyOutput_Click);
            // 
            // Shuffler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(429, 480);
            this.Controls.Add(this.btnCopyOutput);
            this.Controls.Add(this.valSplitter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valSort);
            this.Controls.Add(this.valKeepFirst);
            this.Controls.Add(this.valFirstNumber);
            this.Controls.Add(this.valNoSplit);
            this.Controls.Add(this.valUpcase);
            this.Controls.Add(this.btnDoit);
            this.Controls.Add(this.valOutput);
            this.Controls.Add(this.valFixChnSymbol);
            this.Controls.Add(this.valAddMark);
            this.Controls.Add(this.valAddNumber);
            this.Controls.Add(this.valSent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Shuffler";
            this.Text = "连词成句助手";
            ((System.ComponentModel.ISupportInitialize)(this.valFirstNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox valSent;
        private System.Windows.Forms.CheckBox valAddNumber;
        private System.Windows.Forms.CheckBox valAddMark;
        private System.Windows.Forms.CheckBox valFixChnSymbol;
        private System.Windows.Forms.NumericUpDown valFirstNumber;
        private System.Windows.Forms.TextBox valOutput;
        private System.Windows.Forms.Button btnDoit;
        private System.Windows.Forms.CheckBox valUpcase;
        private System.Windows.Forms.CheckBox valNoSplit;
        private System.Windows.Forms.CheckBox valKeepFirst;
        private System.Windows.Forms.CheckBox valSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valSplitter;
        private System.Windows.Forms.Button btnCopyOutput;
    }
}