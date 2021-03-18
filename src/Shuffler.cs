using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using man = HighlightHelper.ConfigManager;

namespace HighlightHelper {
  public partial class Shuffler : Form {
    private Timer _typingTimer;

    public Shuffler() {
      InitializeComponent();
    }
    private void SwitchMode(SortMethod sm) {
      itemDesc.Checked = false;
      itemShuffle.Checked = false;
      itemAsc.Checked = false;
      switch (sm) {
        case SortMethod.ASC: itemAsc.Checked = true; break;
        case SortMethod.DESC: itemDesc.Checked = true; break;
        case SortMethod.SHUFFLE: itemShuffle.Checked = true; break;
      }
      man.cfg.shuffler.sortMethod = sm;
    }
    private void LoadCfg() {
      itemAddMark.Checked = man.cfg.shuffler.addMark;
      itemAddNumber.Checked = man.cfg.shuffler.addNumber;
      itemFixChnSymbol.Checked = man.cfg.shuffler.replaceChnSymbol;
      itemTolowercase.Checked = man.cfg.shuffler.firstToLowercase;
      itemAutoSplit.Checked = man.cfg.shuffler.autoSplit;
      valFirstNum.Text = man.cfg.shuffler.startNumber.ToString();
      valSplitText.Text = man.cfg.shuffler.splitText;
      SwitchMode(man.cfg.shuffler.sortMethod);
    }
    private void SaveCfg() {
      man.cfg.shuffler.addMark = itemAddMark.Checked;
      man.cfg.shuffler.addNumber = itemAddNumber.Checked;
      man.cfg.shuffler.replaceChnSymbol = itemFixChnSymbol.Checked;
      man.cfg.shuffler.firstToLowercase = itemTolowercase.Checked;
      man.cfg.shuffler.autoSplit = itemAutoSplit.Checked;
      man.cfg.shuffler.startNumber = 1;
      decimal.TryParse(valFirstNum.Text, out man.cfg.shuffler.startNumber);
      man.cfg.shuffler.splitText = valSplitText.Text;
      man.cfg.shuffler.sortMethod = itemAsc.Checked ? SortMethod.ASC : (itemDesc.Checked ? SortMethod.DESC : SortMethod.SHUFFLE);
    }
    private void Shuffler_Load(object sender, EventArgs e) {
      LoadCfg();
      foreach (var i in toolOpt.DropDownItems.OfType<ToolStripMenuItem>()) {
        i.CheckStateChanged += (object s, EventArgs ev) => {
          refresh();
          SaveCfg();
        };
      }
      foreach (var i in toolOpt.DropDownItems.OfType<ToolStripTextBox>()) {
        i.TextChanged += (object s, EventArgs ev) => {
          refresh();
          SaveCfg();
        };
      }
      foreach (ToolStripMenuItem i in toolSort.DropDownItems) {
        i.Click += (object s, EventArgs ev) => {
          var j = s as ToolStripMenuItem;
          if (!j.Checked) {
            itemDesc.Checked = false;
            itemShuffle.Checked = false;
            itemAsc.Checked = false;
            i.Checked = true;
            refresh();
            SaveCfg();
          }
        };
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
          return char.ToLower(x[0]) + x.Substring(1);
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
          Utils.ShuffleList(sub);
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
      if (_typingTimer == null) {
        _typingTimer = new Timer();
        _typingTimer.Interval = 300;

        _typingTimer.Tick += (object a, EventArgs b) => {
          _typingTimer.Stop();
          refresh();
        };
      }
      _typingTimer.Stop();
      _typingTimer.Start();
    }

    private void btnRefresh_Click(object sender, EventArgs e) {
      refresh();
    }

    private void btnCopyResult_Click(object sender, EventArgs e) {
      Clipboard.SetText(valOutput.Text);
    }
    private void btnPaste_Click(object sender, EventArgs e) {
      valSent.Text = Clipboard.GetText();
    }

    private void valFirstNum_KeyPress(object sender, KeyPressEventArgs e) {
      e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
    }
  }
}
