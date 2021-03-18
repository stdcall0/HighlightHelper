using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HighlightHelper {
    public partial class ProfileEditor : Form {
        private int selectedType = 0;
        private readonly List<Label> lbs;
        private Profile target, targetBackup;

        public ProfileEditor() {
            InitializeComponent();
            lbs = new List<Label> { label1, label2, label3 };
        }

        public void setTarget(Profile profile) {
            target = profile;
            targetBackup = target.Clone();
            UpdateBoldDisplay();
            UpdateNumberDisplay();
        }

        private void setBold(Label label, bool v = true) {
            label.Font = new Font(label.Font, v ? FontStyle.Bold : FontStyle.Regular);
        }

        private void UpdateBoldDisplay() {
            foreach (Label i in lbs) {
                if (lbs.IndexOf(i) == selectedType) {
                    setBold(i);
                    labelActiveElement.Text = i.Text.Substring(0, i.Text.Length - 1);
                } else setBold(i, false);
            }
        }
        private void UpdateNumberDisplay() {
            labelCountPhrase.Text = target.phrase.Count.ToString();
            labelCountWord.Text = target.word.Count.ToString();
            labelCountWordNF.Text = target.wordnf.Count.ToString();
            profileNameBox.Text = target.name;
        }

        private void label1_Click(object sender, EventArgs e) {
            selectedType = 0; UpdateBoldDisplay();
        }
        private void label2_Click(object sender, EventArgs e) {
            selectedType = 1; UpdateBoldDisplay();
        }
        private void label3_Click(object sender, EventArgs e) {
            selectedType = 2; UpdateBoldDisplay();
        }

        private void ProfileEditor_Load(object sender, EventArgs e) {
        }

        private void btnDiscard_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ProfileEditor_FormClosing(object sender, FormClosingEventArgs e) {
            if (DialogResult != DialogResult.OK || !target.Validate()) {
                if (MessageBox.Show(this, "丢弃所有更改?", "Discard?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) {
                    e.Cancel = true;
                    return;
                }
                target = targetBackup;
                DialogResult = DialogResult.Cancel;
            }
        }

        private void profileNameBox_TextChanged(object sender, EventArgs e) {
            target.name = (sender as TextBox).Text;
        }

        private void btnClearAll_Click(object sender, EventArgs e) {
            if (MessageBox.Show(this, "真的要清空此配置内容吗?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                target = new Profile {
                    name = target.name
                };
                UpdateNumberDisplay();
            }
        }

        private void btnEditWord_Click(object sender, EventArgs e) {
            ListEditor editor = new ListEditor();
            List<string> list = selectedType == 0 ? target.word : selectedType == 1 ? target.wordnf : target.phrase;
            editor.setTarget(list, target.name + " 中 " + (selectedType == 0 ? "单词" : selectedType == 1 ? "特殊单词" : "短语"));
            if (editor.ShowDialog() == DialogResult.OK) {
                UpdateNumberDisplay();
            }
        }

        private void btnImport_Click(object sender, EventArgs e) {
            DataObject o = (DataObject)Clipboard.GetDataObject();
            if (o.GetDataPresent(DataFormats.Text)) {
                int a = 0, b = 0, c = 0;
                try {
                    string[] pastedRows = Regex.Split(o.GetData(DataFormats.Text).ToString().TrimEnd("\r\n".ToCharArray()), "\r\n");
                    foreach (string pastedRow in pastedRows) {
                        string cell = pastedRow.Split(new char[] { '\t' })[0];
                        if (Regex.IsMatch(cell, "^([A-Za-z])+$")) {
                            if (!target.word.Contains(cell)) { ++a; target.word.Add(cell); }
                        } else if (Regex.IsMatch(cell, "^([^ ])+$")) {
                            if (!target.wordnf.Contains(cell)) { ++b; target.wordnf.Add(cell); }
                        } else {
                            if (!target.phrase.Contains(cell)) { ++c; target.phrase.Add(cell); }
                        }
                    }
                    MessageBox.Show(this, "导入成功。共导入了 " + a + " 个单词，" + b + "个特殊单词，" + c + " 个短语。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch {
                    MessageBox.Show(this, "导入失败。请检查数据是否为一列，并右键-复制了。\n已经导入了 " + a + " 个单词，" + b + "个特殊单词，" + c + " 个短语。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                UpdateNumberDisplay();
            }
        }

        private void btnRecate_Click(object sender, EventArgs e) {
            int a = 0, b = 0, c = 0;
            try {
                string[] pastedRows = target.word.Concat(target.phrase).Concat(target.wordnf).ToArray();
                Profile targetNew = new Profile { name = target.name };
                foreach (string cell in pastedRows) {
                    if (Regex.IsMatch(cell, "^([A-Za-z])+$")) {
                        if (!targetNew.word.Contains(cell)) { ++a; targetNew.word.Add(cell); }
                    } else if (Regex.IsMatch(cell, "^([^ ])+$")) {
                        if (!targetNew.wordnf.Contains(cell)) { ++b; targetNew.wordnf.Add(cell); }
                    } else {
                        if (!targetNew.phrase.Contains(cell)) { ++c; targetNew.phrase.Add(cell); }
                    }
                }
                MessageBox.Show(this, "重组成功。现在有 " + a + " 个单词，" + b + "个特殊单词，" + c + " 个短语。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                target.word = targetNew.word.ConvertAll(az => az.Clone() as string);
                target.wordnf = targetNew.wordnf.ConvertAll(az => az.Clone() as string);
                target.phrase = targetNew.phrase.ConvertAll(az => az.Clone() as string);
            }
            catch {
                MessageBox.Show(this, "重组失败。这不应该发生，请联系马晨航。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateNumberDisplay();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (!target.Validate()) {
                MessageBox.Show(this, "profile.validate: 请输入配置名。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
