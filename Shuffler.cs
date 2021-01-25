﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

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

        private void btnDoit_Click(object sender, EventArgs e) {
            List<string> sent = valSent.Text.Split('\n').ToList();
            string o = "";
            int id = (int)valFirstNumber.Value;
            bool numb = valAddNumber.Checked;
            bool mark = valAddMark.Checked;
            foreach (string s in sent) {
                if (string.IsNullOrWhiteSpace(s)) continue;
                List<string> w = s.Split(' ').ToList();
                w[0] = w[0].ToLower();
                w = w.ConvertAll(Ao => Ao.Trim().Replace('　', ' ').Replace('？', '?').Replace('。', '.').Replace('，', ','));
                List<string> w2 = w.ConvertAll(Ao => Ao.Replace("?", "").Replace("!", "").Replace(",", "").Replace(".", ""));
                ShuffleList(w2);
                string ap = string.Join(" ", w2);
                if (mark) {
                    string dest = string.Join("", w);
                    string om = "  (";
                    int i = 0;
                    while (i < dest.Length) {
                        i = dest.IndexOfAny(new[] { ',', '.', '!', '?'}, i);
                        if (i != -1) {
                            om += dest[i];
                            i = i + 1;
                        } else break;
                    }
                    if (om != "  (") ap += om + ")";
                }
                if (numb) ap = id.ToString() + ". " + ap;
                o += ap + "\r\n"; ++id;
            }
            valOutput.Text = o;
        }
    }
}
