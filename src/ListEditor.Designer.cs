
namespace HighlightHelper {
    partial class ListEditor {
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
            this.btnDiscard = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.labelProfileName = new System.Windows.Forms.Label();
            this.labelCountList = new System.Windows.Forms.Label();
            this.btnAddElement = new System.Windows.Forms.Button();
            this.btnDelElement = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.DataGridView();
            this.btnSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDiscard
            // 
            this.btnDiscard.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDiscard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscard.Location = new System.Drawing.Point(382, 248);
            this.btnDiscard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(42, 24);
            this.btnDiscard.TabIndex = 16;
            this.btnDiscard.Text = "取消";
            this.btnDiscard.UseVisualStyleBackColor = true;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(335, 248);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(42, 24);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Location = new System.Drawing.Point(270, 248);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(42, 24);
            this.btnClearAll.TabIndex = 14;
            this.btnClearAll.Text = "清空";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnImport
            // 
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Location = new System.Drawing.Point(223, 248);
            this.btnImport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(42, 24);
            this.btnImport.TabIndex = 13;
            this.btnImport.Text = "导入";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // labelProfileName
            // 
            this.labelProfileName.AutoSize = true;
            this.labelProfileName.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelProfileName.Location = new System.Drawing.Point(10, 280);
            this.labelProfileName.Name = "labelProfileName";
            this.labelProfileName.Size = new System.Drawing.Size(54, 16);
            this.labelProfileName.TabIndex = 17;
            this.labelProfileName.Text = "loading..";
            // 
            // labelCountList
            // 
            this.labelCountList.Location = new System.Drawing.Point(117, 280);
            this.labelCountList.Name = "labelCountList";
            this.labelCountList.Size = new System.Drawing.Size(308, 12);
            this.labelCountList.TabIndex = 18;
            this.labelCountList.Text = "共有 loading.. 个元素";
            this.labelCountList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAddElement
            // 
            this.btnAddElement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddElement.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddElement.Location = new System.Drawing.Point(10, 248);
            this.btnAddElement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddElement.Name = "btnAddElement";
            this.btnAddElement.Size = new System.Drawing.Size(22, 30);
            this.btnAddElement.TabIndex = 19;
            this.btnAddElement.Text = "+";
            this.btnAddElement.UseVisualStyleBackColor = true;
            this.btnAddElement.Click += new System.EventHandler(this.btnAddElement_Click);
            // 
            // btnDelElement
            // 
            this.btnDelElement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelElement.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelElement.Location = new System.Drawing.Point(38, 248);
            this.btnDelElement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelElement.Name = "btnDelElement";
            this.btnDelElement.Size = new System.Drawing.Size(22, 30);
            this.btnDelElement.TabIndex = 20;
            this.btnDelElement.Text = "-";
            this.btnDelElement.UseVisualStyleBackColor = true;
            this.btnDelElement.Click += new System.EventHandler(this.btnDelElement_Click);
            // 
            // listBox
            // 
            this.listBox.AllowDrop = true;
            this.listBox.AllowUserToResizeColumns = false;
            this.listBox.AllowUserToResizeRows = false;
            this.listBox.BackgroundColor = System.Drawing.Color.Linen;
            this.listBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listBox.Location = new System.Drawing.Point(10, 9);
            this.listBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox.MultiSelect = false;
            this.listBox.Name = "listBox";
            this.listBox.RowTemplate.Height = 23;
            this.listBox.Size = new System.Drawing.Size(414, 234);
            this.listBox.TabIndex = 21;
            this.listBox.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.listBox_CellEndEdit);
            this.listBox.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.listBox_RowsAdded);
            this.listBox.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.listBox_RowsRemoved);
            // 
            // btnSort
            // 
            this.btnSort.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSort.Location = new System.Drawing.Point(65, 248);
            this.btnSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(42, 30);
            this.btnSort.TabIndex = 22;
            this.btnSort.Text = "排序";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // ListEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.CancelButton = this.btnDiscard;
            this.ClientSize = new System.Drawing.Size(435, 298);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnDelElement);
            this.Controls.Add(this.btnAddElement);
            this.Controls.Add(this.labelCountList);
            this.Controls.Add(this.labelProfileName);
            this.Controls.Add(this.btnDiscard);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnImport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "高亮列表编辑器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListEditor_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.listBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label labelProfileName;
        private System.Windows.Forms.Label labelCountList;
        private System.Windows.Forms.Button btnAddElement;
        private System.Windows.Forms.Button btnDelElement;
        private System.Windows.Forms.DataGridView listBox;
        private System.Windows.Forms.Button btnSort;
    }
}