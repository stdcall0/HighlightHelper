using System;
using System.Collections.Generic;
using AutoCSer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HighlightHelper
{
    public interface ICloneable<T> {
        T Clone();
    }

    public class HighlightProfile : ICloneable<HighlightProfile> {
        private string namei;
        public string name {
            get { return String.IsNullOrEmpty(namei) ? "" : namei; }
            set { namei = String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value) ? "" : value; }
        }
        public List<string> word, wordnf, phrase;
        public HighlightProfile() {
            namei = "";
            word = new List<string>();
            wordnf = new List<string>();
            phrase = new List<string>();
        }
        public bool Validate() {
            return !String.IsNullOrEmpty(namei) && !String.IsNullOrWhiteSpace(namei);
        }
        public HighlightProfile Clone() { // clone the object
            return new HighlightProfile {
                name = name,
                word = word.ConvertAll(b => b.Clone() as string),
                wordnf = wordnf.ConvertAll(b => b.Clone() as string),
                phrase = phrase.ConvertAll(b => b.Clone() as string)
            };
        }
        public override string ToString() {
            return name;
        }
        public static void ActivateStart() {
            using (new System.IO.StreamWriter(@"D:\WorkFinal\word.txt", false)) { }
            using (new System.IO.StreamWriter(@"D:\WorkFinal\wordnf.txt", false)) { }
            using (new System.IO.StreamWriter(@"D:\WorkFinal\phrase.txt", false)) { }
        }
        public void Activate(ref int count1, ref int count2, ref int count3) {
            count1 = count2 = count3 = 0;
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\WorkFinal\word.txt", true)) {
                foreach (string i in word) {
                    if (Regex.IsMatch(i, "^([A-Za-z])+$")) {
                        file.WriteLine(i); ++count1;
                    }
                }
            }
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\WorkFinal\wordnf.txt", true)) {
                foreach (string i in wordnf) {
                    if (Regex.IsMatch(i, "^([^ ])+$")) {
                        file.WriteLine(i); ++count2;
                    }
                }
            }
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\WorkFinal\phrase.txt", true)) {
                foreach (string i in phrase) {
                    file.WriteLine(i); ++count3;
                }
            }
        }
    }
}
