using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace HighlightHelper {
    public partial class Shuffler : Form {
        public Shuffler() {
            InitializeComponent();
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
            if (valFixChnSymbol.Checked) {
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
            if (!valNoSplit.Checked) {
                List<string> res = new List<string>();
                foreach (string s in S) {
                    res.AddRange(Regex.Split(s, @"(?<=[\.!\?])\s+"));
                }
                S = res;
            }
            S = S.ConvertAll(x => x.Trim()).ToList();
            if (valUpcase.Checked) {
                S = S.ConvertAll(x => {
                    if (x.Length == 0) return x;
                    return Char.ToLower(x[0]) + x.Substring(1);
                }).ToList();
            }

            valOutput.Text = "";

            decimal id = valFirstNumber.Value;

            foreach (string s in S) {
                List<string> w = Regex
                    .Replace(s, @"[,.!?""';]", "")
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList()
                    .ConvertAll(x => x.Trim()); // words
                if (w.Count == 0) continue;
                string mark = "", r = "";
                if (valAddMark.Checked) {
                    foreach (Match m in Regex.Matches(s, @"[,.!?""';]")) {
                        mark += s[m.Index];
                    }
                }
                List<string> sub;
                if (valKeepFirst.Checked) {
                    sub = w.GetRange(1, w.Count - 1);
                    r = w[0];
                    if (w.Count > 1) r += valSplitter.Text;
                } else {
                    sub = w;
                }
                if (valSort.Checked) {
                    sub.Sort();
                } else {
                    ShuffleList(sub);
                }
                r += String.Join(valSplitter.Text, sub);
                if (mark != "") {
                    r += "    (" + mark + ")";
                }
                if (valAddNumber.Checked) {
                    r = id.ToString() + ". " + r;
                    ++id;
                }
                valOutput.Text += r + "\r\n";
            }
        }

        private void btnDoit_Click(object sender, EventArgs e) {
            refresh();
        }

        private void valSent_TextChanged(object sender, EventArgs e) {
            refresh();
        }

        private void valAddNumber_CheckedChanged(object sender, EventArgs e) {
            refresh();
        }

        private void valFirstNumber_ValueChanged(object sender, EventArgs e) {
            refresh();
        }

        private void valAddMark_CheckedChanged(object sender, EventArgs e) {
            refresh();
        }

        private void valFixChnSymbol_CheckedChanged(object sender, EventArgs e) {
            refresh();
        }

        private void valUpcase_CheckedChanged(object sender, EventArgs e) {
            refresh();
        }

        private void valKeepFirst_CheckedChanged(object sender, EventArgs e) {
            refresh();
        }

        private void valNoSplit_CheckedChanged(object sender, EventArgs e) {
            refresh();
        }

        private void valSort_CheckedChanged(object sender, EventArgs e) {
            refresh();
        }

        private void valSplitter_TextChanged(object sender, EventArgs e) {
            refresh();
        }

        private void btnCopyOutput_Click(object sender, EventArgs e) {
            Clipboard.SetText(valOutput.Text);
        }
    }
}
