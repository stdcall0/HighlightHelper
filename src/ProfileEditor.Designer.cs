
namespace HighlightHelper
{
    partial class ProfileEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCountWord = new System.Windows.Forms.Label();
            this.labelCountWordNF = new System.Windows.Forms.Label();
            this.labelCountPhrase = new System.Windows.Forms.Label();
            this.btnEditWord = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelActiveElement = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.profileNameBox = new System.Windows.Forms.TextBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnRecate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "单词：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F);
            this.label2.Location = new System.Drawing.Point(11, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "特殊单词：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F);
            this.label3.Location = new System.Drawing.Point(11, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "短语：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelCountWord
            // 
            this.labelCountWord.AutoSize = true;
            this.labelCountWord.Font = new System.Drawing.Font("宋体", 9F);
            this.labelCountWord.Location = new System.Drawing.Point(89, 10);
            this.labelCountWord.Name = "labelCountWord";
            this.labelCountWord.Size = new System.Drawing.Size(65, 12);
            this.labelCountWord.TabIndex = 3;
            this.labelCountWord.Text = "loading...";
            // 
            // labelCountWordNF
            // 
            this.labelCountWordNF.AutoSize = true;
            this.labelCountWordNF.Font = new System.Drawing.Font("宋体", 9F);
            this.labelCountWordNF.Location = new System.Drawing.Point(89, 22);
            this.labelCountWordNF.Name = "labelCountWordNF";
            this.labelCountWordNF.Size = new System.Drawing.Size(65, 12);
            this.labelCountWordNF.TabIndex = 4;
            this.labelCountWordNF.Text = "loading...";
            // 
            // labelCountPhrase
            // 
            this.labelCountPhrase.AutoSize = true;
            this.labelCountPhrase.Font = new System.Drawing.Font("宋体", 9F);
            this.labelCountPhrase.Location = new System.Drawing.Point(89, 34);
            this.labelCountPhrase.Name = "labelCountPhrase";
            this.labelCountPhrase.Size = new System.Drawing.Size(65, 12);
            this.labelCountPhrase.TabIndex = 5;
            this.labelCountPhrase.Text = "loading...";
            // 
            // btnEditWord
            // 
            this.btnEditWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditWord.Font = new System.Drawing.Font("宋体", 9F);
            this.btnEditWord.Location = new System.Drawing.Point(160, 22);
            this.btnEditWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditWord.Name = "btnEditWord";
            this.btnEditWord.Size = new System.Drawing.Size(70, 24);
            this.btnEditWord.TabIndex = 6;
            this.btnEditWord.Text = "编辑...";
            this.btnEditWord.UseVisualStyleBackColor = true;
            this.btnEditWord.Click += new System.EventHandler(this.btnEditWord_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F);
            this.label4.Location = new System.Drawing.Point(10, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "已选择：";
            // 
            // labelActiveElement
            // 
            this.labelActiveElement.AutoSize = true;
            this.labelActiveElement.Font = new System.Drawing.Font("宋体", 9F);
            this.labelActiveElement.Location = new System.Drawing.Point(89, 46);
            this.labelActiveElement.Name = "labelActiveElement";
            this.labelActiveElement.Size = new System.Drawing.Size(65, 12);
            this.labelActiveElement.TabIndex = 8;
            this.labelActiveElement.Text = "loading...";
            // 
            // btnImport
            // 
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("宋体", 9F);
            this.btnImport.Location = new System.Drawing.Point(12, 86);
            this.btnImport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(39, 24);
            this.btnImport.TabIndex = 9;
            this.btnImport.Text = "导入";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("宋体", 9F);
            this.btnSave.Location = new System.Drawing.Point(147, 86);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(39, 24);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDiscard
            // 
            this.btnDiscard.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDiscard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscard.Font = new System.Drawing.Font("宋体", 9F);
            this.btnDiscard.Location = new System.Drawing.Point(192, 86);
            this.btnDiscard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(39, 24);
            this.btnDiscard.TabIndex = 12;
            this.btnDiscard.Text = "取消";
            this.btnDiscard.UseVisualStyleBackColor = true;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(11, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "配置名：";
            // 
            // profileNameBox
            // 
            this.profileNameBox.Font = new System.Drawing.Font("宋体", 9F);
            this.profileNameBox.Location = new System.Drawing.Point(89, 60);
            this.profileNameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profileNameBox.Name = "profileNameBox";
            this.profileNameBox.Size = new System.Drawing.Size(141, 21);
            this.profileNameBox.TabIndex = 14;
            this.profileNameBox.Text = "loading...";
            this.profileNameBox.TextChanged += new System.EventHandler(this.profileNameBox_TextChanged);
            // 
            // btnClearAll
            // 
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Font = new System.Drawing.Font("宋体", 9F);
            this.btnClearAll.Location = new System.Drawing.Point(57, 86);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(39, 24);
            this.btnClearAll.TabIndex = 15;
            this.btnClearAll.Text = "清空";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnRecate
            // 
            this.btnRecate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecate.Font = new System.Drawing.Font("宋体", 9F);
            this.btnRecate.Location = new System.Drawing.Point(102, 86);
            this.btnRecate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRecate.Name = "btnRecate";
            this.btnRecate.Size = new System.Drawing.Size(39, 24);
            this.btnRecate.TabIndex = 16;
            this.btnRecate.Text = "重组";
            this.btnRecate.UseVisualStyleBackColor = true;
            this.btnRecate.Click += new System.EventHandler(this.btnRecate_Click);
            // 
            // ProfileEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.CancelButton = this.btnDiscard;
            this.ClientSize = new System.Drawing.Size(242, 115);
            this.Controls.Add(this.btnRecate);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.profileNameBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDiscard);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.labelActiveElement);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEditWord);
            this.Controls.Add(this.labelCountPhrase);
            this.Controls.Add(this.labelCountWordNF);
            this.Controls.Add(this.labelCountWord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProfileEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "配置编辑器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProfileEditor_FormClosing);
            this.Load += new System.EventHandler(this.ProfileEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCountWord;
        private System.Windows.Forms.Label labelCountWordNF;
        private System.Windows.Forms.Label labelCountPhrase;
        private System.Windows.Forms.Button btnEditWord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelActiveElement;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox profileNameBox;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnRecate;
    }
}