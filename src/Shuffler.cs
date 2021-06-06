using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using man = HighlightHelper.ConfigManager;

namespace HighlightHelper {
  public partial class Shuffler : Form {
    private Timer _typingTimer;
    private bool mode = true;

    private string symbols = @"[,\.。!！\?？""“”'‘’;；]";

    public Shuffler() {
      InitializeComponent();
    }

    private void SwitchSortMethod(SortMethod sm) {
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

    private void SwitchMode() {
      mode = !mode;
      if (mode == false) {
        labelMode.Text = "[连词成句]";
      } else {
        labelMode.Text = "[连句成篇]";
      }
      refresh();
    }

    private void LoadCfg() {
      itemAddMark.Checked = man.cfg.shuffler.addMark;
      itemAddNumber.Checked = man.cfg.shuffler.addNumber;
      itemFixChnSymbol.Checked = man.cfg.shuffler.replaceChnSymbol;
      itemTolowercase.Checked = man.cfg.shuffler.firstToLowercase;
      itemAutoSplit.Checked = man.cfg.shuffler.autoSplit;
      valFirstNum.Text = man.cfg.shuffler.startNumber.ToString();
      valSentenceSplit.Text = man.cfg.shuffler.sentenceSplit.Replace(" ", "•");
      valWordSplit.Text = man.cfg.shuffler.wordSplit.Replace(" ", "•");
      valOutputSplit.Text = man.cfg.shuffler.outputSplit.Replace(" ", "•");
      SwitchSortMethod(man.cfg.shuffler.sortMethod);
      mode = true;  SwitchMode();
    }

    private void SaveCfg() {
      man.cfg.shuffler.addMark = itemAddMark.Checked;
      man.cfg.shuffler.addNumber = itemAddNumber.Checked;
      man.cfg.shuffler.replaceChnSymbol = itemFixChnSymbol.Checked;
      man.cfg.shuffler.firstToLowercase = itemTolowercase.Checked;
      man.cfg.shuffler.autoSplit = itemAutoSplit.Checked;
      man.cfg.shuffler.startNumber = 1;
      decimal.TryParse(valFirstNum.Text, out man.cfg.shuffler.startNumber);
      man.cfg.shuffler.sentenceSplit = getOriginal(valSentenceSplit);
      man.cfg.shuffler.wordSplit = getOriginal(valWordSplit);
      man.cfg.shuffler.outputSplit = getOriginal(valOutputSplit);
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
          ToolStripTextBox textBox = (ToolStripTextBox)s;
          int caretIndex = textBox.SelectionStart;
          int caretLength = textBox.SelectionLength;
          textBox.Text = textBox.Text.Replace(" ", "•");
          textBox.SelectionStart = caretIndex;
          textBox.SelectionLength = caretLength;
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

    private string getOriginal(ToolStripTextBox box) { return box.Text.Replace("•", " "); }

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
      raw = raw.Replace("\r", "");
      List<string> S = raw.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();
      if (itemAutoSplit.Checked) {
        string splitChars = getOriginal(valSentenceSplit);
        List<string> res = new List<string>();
        foreach (string s in S) {
          int lastPos = 0;
          for (int i = 0; i < s.Length; ++i) {
            if (splitChars.Contains(s[i])) {
              res.Add(s.Substring(lastPos, i - lastPos + 1));
              lastPos = i + 1;
            }
          }
          if (lastPos < s.Length) {
            res.Add(s.Substring(lastPos));
          }
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
      S.Remove("");

      valOutput.Text = "";

      decimal id = 1;
      decimal.TryParse(valFirstNum.Text, out id);

      if (mode) {
        if (itemAsc.Checked) {
          S.Sort();
        } else if (itemDesc.Checked) {
          S.Sort();
          S.Reverse();
        } else {
          Utils.ShuffleList(S);
        }
        foreach (string s in S) {
          string r = s.Trim();
          if (itemAddNumber.Checked) {
            r = id.ToString() + ". " + r;
            ++id;
          }
          valOutput.Text += r + "\r\n";
        }
      } else {
        foreach (string s in S) {
          char[] ws = (getOriginal(valWordSplit) + getOriginal(valSentenceSplit)).ToCharArray();
          string mark = "", r = "";
          if (itemAddMark.Checked) {
            int f = s.IndexOfAny(ws);
            while (f < s.Length && f != -1) {
              mark += s[f];
              f = s.IndexOfAny(ws, f + 1);
            }
          }

          List<string> w = s
              .Split(ws, StringSplitOptions.RemoveEmptyEntries)
              .ToList()
              .ConvertAll(x => x.Trim());
          if (w.Count == 0) continue;
          List<string> sub;
          if (itemKeepfront.Checked) {
            sub = w.GetRange(1, w.Count - 1);
            r = w[0];
            if (w.Count > 1) r += getOriginal(valOutputSplit);
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
          r += string.Join(getOriginal(valOutputSplit), sub);
          if (mark != "") {
            r += "    (" + mark.Replace(" ", "") + ")";
          }
          if (itemAddNumber.Checked) {
            r = id.ToString() + ". " + r;
            ++id;
          }
          valOutput.Text += r + "\r\n";
        }
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

    private void btnToggleMode_Click(object sender, EventArgs e) {
      SwitchMode();
      refresh();
    }

    private void btnDebug_Click(object sender, EventArgs e) {
      MessageBox.Show("DIMSTR " + valWordSplit.Text + "\r\nDIMCHARS " + valSentenceSplit.Text + "\r\nDIMOUTPUT " + valOutputSplit.Text, "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
  }
}
