using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HighlightHelper {
  public partial class ActivateForm : Form {
    readonly List<Profile> hl;

    public ActivateForm(List<Profile> hlr) {
      InitializeComponent();
      hl = hlr;
    }

    private void btnQuit_Click(object sender, EventArgs e) {
      DialogResult = DialogResult.Abort;
      Close();
    }

    private void ActivateForm_Load(object sender, EventArgs e) {
      hl.ForEach((a) => {
        activeList.Items.Add(a);
      });
    }

    private void btnActive_Click(object sender, EventArgs e) {
      if (activeList.CheckedItems.Count == 0) {
        MessageBox.Show(this, "你没有选择任何配置。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      int A = 0, B = 0, C = 0, a = 0, b = 0, c = 0;
      Profile.ActivateStart();
      activeList.CheckedItems.OfType<Profile>().ToList().ForEach((i) => {
        i.Activate(out a, out b, out c);
        A += a; B += b; C += c;
      });

      MessageBox.Show(this, String.Format("成功激活配置，包含 {0} 个单词，{1} 个特殊单词，{2} 个短语。", A, B, C), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
      Close();
    }
  }
}
