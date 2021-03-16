using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace HighlightHelper {
  public partial class Shuffler : Form {
    public Shuffler() {
      InitializeComponent();
    }
    private void Shuffler_Load(object sender, EventArgs e) {
      Utils.SetFont(this);
      foreach (var i in toolOpt.DropDownItems.OfType<ToolStripMenuItem>()) {
        i.CheckStateChanged += (object s, EventArgs ev) => refresh();
      }
    }
    public static void ShuffleList(List<string> list) {
      RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
      int n = list.Count;
      while (n > 1) {
        byte[] box = new byte[1];
        do provider.GetBytes(box);
        while (!(box[0] < n * (Byte.MaxValue / n)));
        int k = (box[0] % n);
        n--;
        string value = list[k];
        list[k] = list[n];
        list[n] = value;
      }
    }
    private void refresh() {
      string raw = valSent.Text;
      if (itemFixChnSymbol.Checked) {
        raw = raw
            .Replace('　', ' ')
            .Replace('？', '?')
            .Replace('。', '.')
            .Replace('，', ',')
            .Replace("“", "\"")
            .Replace("”", "\"")
            .Replace("‘", "'")
            .Replace("’", "'");
      }
      List<string> S = raw.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();
      if (itemAutoSplit.Checked) {
        List<string> res = new List<string>();
        foreach (string s in S) {
          res.AddRange(Regex.Split(s, @"(?<=[\.。!！\?？])\s+"));
        }
        S = res;
      }
      S = S.ConvertAll(x => x.Trim()).ToList();
      if (itemTolowercase.Checked) {
        S = S.ConvertAll(x => {
          if (x.Length == 0) return x;
          return Char.ToLower(x[0]) + x.Substring(1);
        }).ToList();
      }

      valOutput.Text = "";

      decimal id = 1;
      decimal.TryParse(valFirstNum.Text, out id);

      foreach (string s in S) {
        List<string> w = Regex
            .Replace(s, @"[,\.。!！\?？""“”'‘’;；]", "")
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToList()
            .ConvertAll(x => x.Trim()); // words
        if (w.Count == 0) continue;
        string mark = "", r = "";
        if (itemAddMark.Checked) {
          foreach (Match m in Regex.Matches(s, @"[,\.。!！\?？""“”'‘’;；]")) {
            mark += s[m.Index];
          }
        }
        List<string> sub;
        if (itemKeepfront.Checked) {
          sub = w.GetRange(1, w.Count - 1);
          r = w[0];
          if (w.Count > 1) r += valSplitText.Text;
        } else {
          sub = w;
        }
        if (itemAsc.Checked) {
          sub.Sort();
        } else if (itemDesc.Checked) {
          sub.Sort();
          sub.Reverse();
        } else {
          ShuffleList(sub);
        }
        r += String.Join(valSplitText.Text, sub);
        if (mark != "") {
          r += "    (" + mark + ")";
        }
        if (itemAddNumber.Checked) {
          r = id.ToString() + ". " + r;
          ++id;
        }
        valOutput.Text += r + "\r\n";
      }
    }

    private void valSent_TextChanged(object sender, EventArgs e) {
      refresh();
    }

    private void valSplitter_TextChanged(object sender, EventArgs e) {
      refresh();
    }

    private void valFirstNumber_ValueChanged(object sender, EventArgs e) {
      refresh();
    }

    private void btnRefresh_Click(object sender, EventArgs e) {
      refresh();
    }

    private void btnCopyResult_Click(object sender, EventArgs e) {
      Clipboard.SetText(valOutput.Text);
    }

    private void valFirstNum_Click(object sender, EventArgs e) {
      refresh();
    }

    private void valFirstNum_KeyPress(object sender, KeyPressEventArgs e) {
      e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
    }

    private void valFirstNum_TextChanged(object sender, EventArgs e) {
      refresh();
    }

    private void valSplitText_TextChanged(object sender, EventArgs e) {
      refresh();
    }

    private void itemAsc_Click(object sender, EventArgs e) {
      if (!itemAsc.Checked) {
        itemDesc.Checked = false;
        itemShuffle.Checked = false;
        itemAsc.Checked = true;
      }
      refresh();
    }

    private void itemDesc_Click(object sender, EventArgs e) {
      if (!itemDesc.Checked) {
        itemDesc.Checked = true;
        itemShuffle.Checked = false;
        itemAsc.Checked = false;
      }
      refresh();
    }

    private void itemShuffle_Click(object sender, EventArgs e) {
      if (!itemShuffle.Checked) {
        itemDesc.Checked = false;
        itemShuffle.Checked = true;
        itemAsc.Checked = false;
      }
      refresh();
    }
  }
}
