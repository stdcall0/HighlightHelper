
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
            this.label1 = new System.Windows.Forms.Label();
            this.valSent = new System.Windows.Forms.TextBox();
            this.valAddNumber = new System.Windows.Forms.CheckBox();
            this.valAddMark = new System.Windows.Forms.CheckBox();
            this.valFixChnSymbol = new System.Windows.Forms.CheckBox();
            this.valFirstNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.valOutput = new System.Windows.Forms.TextBox();
            this.btnDoit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.valFirstNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sentences\r\nOne Per Line\r\n";
            // 
            // valSent
            // 
            this.valSent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valSent.Location = new System.Drawing.Point(113, 12);
            this.valSent.Multiline = true;
            this.valSent.Name = "valSent";
            this.valSent.Size = new System.Drawing.Size(675, 161);
            this.valSent.TabIndex = 1;
            // 
            // valAddNumber
            // 
            this.valAddNumber.AutoSize = true;
            this.valAddNumber.Checked = true;
            this.valAddNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.valAddNumber.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.valAddNumber.Location = new System.Drawing.Point(23, 357);
            this.valAddNumber.Name = "valAddNumber";
            this.valAddNumber.Size = new System.Drawing.Size(84, 24);
            this.valAddNumber.TabIndex = 2;
            this.valAddNumber.Text = "添加序号";
            this.valAddNumber.UseVisualStyleBackColor = true;
            // 
            // valAddMark
            // 
            this.valAddMark.AutoSize = true;
            this.valAddMark.Checked = true;
            this.valAddMark.CheckState = System.Windows.Forms.CheckState.Checked;
            this.valAddMark.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.valAddMark.Location = new System.Drawing.Point(140, 357);
            this.valAddMark.Name = "valAddMark";
            this.valAddMark.Size = new System.Drawing.Size(112, 24);
            this.valAddMark.TabIndex = 3;
            this.valAddMark.Text = "添加标点符号";
            this.valAddMark.UseVisualStyleBackColor = true;
            // 
            // valFixChnSymbol
            // 
            this.valFixChnSymbol.AutoSize = true;
            this.valFixChnSymbol.Checked = true;
            this.valFixChnSymbol.CheckState = System.Windows.Forms.CheckState.Checked;
            this.valFixChnSymbol.Enabled = false;
            this.valFixChnSymbol.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.valFixChnSymbol.Location = new System.Drawing.Point(277, 357);
            this.valFixChnSymbol.Name = "valFixChnSymbol";
            this.valFixChnSymbol.Size = new System.Drawing.Size(112, 24);
            this.valFixChnSymbol.TabIndex = 4;
            this.valFixChnSymbol.Text = "替换中文标点";
            this.valFixChnSymbol.UseVisualStyleBackColor = true;
            // 
            // valFirstNumber
            // 
            this.valFirstNumber.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.valFirstNumber.Location = new System.Drawing.Point(668, 357);
            this.valFirstNumber.Name = "valFirstNumber";
            this.valFirstNumber.Size = new System.Drawing.Size(120, 23);
            this.valFirstNumber.TabIndex = 5;
            this.valFirstNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(583, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "序号起始值";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 40);
            this.label3.TabIndex = 7;
            this.label3.Text = "Outputs\r\nOne Per Line\r\n";
            // 
            // valOutput
            // 
            this.valOutput.Font = new System.Drawing.Font("Arial", 12F);
            this.valOutput.Location = new System.Drawing.Point(113, 179);
            this.valOutput.Multiline = true;
            this.valOutput.Name = "valOutput";
            this.valOutput.ReadOnly = true;
            this.valOutput.Size = new System.Drawing.Size(675, 161);
            this.valOutput.TabIndex = 8;
            // 
            // btnDoit
            // 
            this.btnDoit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDoit.Location = new System.Drawing.Point(23, 162);
            this.btnDoit.Name = "btnDoit";
            this.btnDoit.Size = new System.Drawing.Size(66, 31);
            this.btnDoit.TabIndex = 9;
            this.btnDoit.Text = "分词";
            this.btnDoit.UseVisualStyleBackColor = true;
            this.btnDoit.Click += new System.EventHandler(this.btnDoit_Click);
            // 
            // Shuffler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 397);
            this.Controls.Add(this.btnDoit);
            this.Controls.Add(this.valOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valFirstNumber);
            this.Controls.Add(this.valFixChnSymbol);
            this.Controls.Add(this.valAddMark);
            this.Controls.Add(this.valAddNumber);
            this.Controls.Add(this.valSent);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Shuffler";
            this.Text = "连词成句助手";
            ((System.ComponentModel.ISupportInitialize)(this.valFirstNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valSent;
        private System.Windows.Forms.CheckBox valAddNumber;
        private System.Windows.Forms.CheckBox valAddMark;
        private System.Windows.Forms.CheckBox valFixChnSymbol;
        private System.Windows.Forms.NumericUpDown valFirstNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox valOutput;
        private System.Windows.Forms.Button btnDoit;
    }
}