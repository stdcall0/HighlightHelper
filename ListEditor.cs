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
    public partial class ListEditor : Form {
        private List<string> list;
        private readonly DataGridViewRowCollection listref;

        public ListEditor() {
            InitializeComponent();
            listref = listBox.Rows;
        }

        private void UpdateDisplay() {
            // Label texts
            labelCountList.Text = "共有 " + (listref.Count-1).ToString() + " 个元素";
        }
        private void PushElements() {
            listref.Clear(); listBox.Columns.Clear();
            listBox.Columns.Add("text", "Data");
            listBox.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            foreach (string i in list) {
                listref.Add(i);
            }
        }
        private void SelectRow(int index) {
            listBox.ClearSelection(); listBox.CurrentCell = listref[index].Cells[0];
            listref[index].Selected = true;
        }

        private void btnClearAll_Click(object sender, EventArgs e) {
            if (MessageBox.Show(this, "真的要清空此列表吗?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                try {
                    while (true) listref.RemoveAt(0);
                }
                catch {
                }
                UpdateDisplay();
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnDiscard_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAddElement_Click(object sender, EventArgs e) {
            SelectRow(listref.Add("在这里输入内容..."));
            listBox.BeginEdit(true);
        }

        private void btnDelElement_Click(object sender, EventArgs e) {
            if (listBox.SelectedCells.Count > 0) {
                int index = listBox.SelectedCells[0].RowIndex;
                if (index < listref.Count - 1) listref.RemoveAt(index);
                if (index < listref.Count - 1) SelectRow(index);
            }
        }

        private void listBox_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            UpdateDisplay();
        }

        private void listBox_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) {
            UpdateDisplay();
        }

        private void listBox_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) {
            UpdateDisplay();
        }

        private void ListEditor_FormClosing(object sender, FormClosingEventArgs e) {
            if (DialogResult != DialogResult.OK) {
                if (MessageBox.Show(this, "丢弃所有更改?", "Discard?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) {
                    e.Cancel = true;
                    return;
                }
                DialogResult = DialogResult.Cancel;
            } else {
                list.Clear();
                foreach (DataGridViewRow i in listBox.Rows) {
                    string content = i.Cells[0].Value as string;
                    if (String.IsNullOrEmpty(content) || String.IsNullOrWhiteSpace(content)) continue;
                    list.Add(content.Trim());
                }
            }
        }

        public void setTarget(List<string> vs, string targetname) {
            list = vs;
            labelProfileName.Text = targetname;

            PushElements();
            UpdateDisplay();
        }

        private void btnImport_Click(object sender, EventArgs e) {
            DataObject o = (DataObject)Clipboard.GetDataObject();
            if (o.GetDataPresent(DataFormats.Text)) {
                try {
                    string[] pastedRows = Regex.Split(o.GetData(DataFormats.Text).ToString().TrimEnd("\r\n".ToCharArray()), "\r\n");
                    foreach (string pastedRow in pastedRows) {
                        string cell = pastedRow.Split(new char[] { '\t' })[0];
                        listBox.Rows.Add(cell);
                    }
                    MessageBox.Show(this, "导入成功。共导入了 " + pastedRows.Length + " 条数据。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch {
                    MessageBox.Show(this, "导入失败。请检查数据是否为一列，并右键-复制了。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSort_Click(object sender, EventArgs e) {
            listBox.Enabled = false;
            List<string> list = new List<string>();
            foreach (DataGridViewRow i in listBox.Rows) {
                string content = i.Cells[0].Value as string;
                if (String.IsNullOrEmpty(content) || String.IsNullOrWhiteSpace(content)) continue;
                list.Add(content.Trim());
            }
            list.Sort(StringComparer.OrdinalIgnoreCase);
            listref.Clear();
            foreach (string i in list) {
                listref.Add(i);
            }
            listBox.Enabled = true;
        }
    }
}
