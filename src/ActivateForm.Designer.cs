
namespace HighlightHelper {
    partial class ActivateForm {
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
            this.activeList = new System.Windows.Forms.CheckedListBox();
            this.btnActive = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // activeList
            // 
            this.activeList.BackColor = System.Drawing.Color.MistyRose;
            this.activeList.CheckOnClick = true;
            this.activeList.FormattingEnabled = true;
            this.activeList.Location = new System.Drawing.Point(0, 0);
            this.activeList.Name = "activeList";
            this.activeList.ScrollAlwaysVisible = true;
            this.activeList.Size = new System.Drawing.Size(345, 256);
            this.activeList.TabIndex = 0;
            // 
            // btnActive
            // 
            this.btnActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActive.Location = new System.Drawing.Point(12, 266);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(154, 31);
            this.btnActive.TabIndex = 6;
            this.btnActive.Text = "激活";
            this.btnActive.UseVisualStyleBackColor = true;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Location = new System.Drawing.Point(182, 266);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(151, 31);
            this.btnQuit.TabIndex = 7;
            this.btnQuit.Text = "退出";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // ActivateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(345, 307);
            this.Controls.Add(this.btnActive);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.activeList);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ActivateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "选择要激活的配置...";
            this.Load += new System.EventHandler(this.ActivateForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox activeList;
        private System.Windows.Forms.Button btnActive;
        private System.Windows.Forms.Button btnQuit;
    }
}