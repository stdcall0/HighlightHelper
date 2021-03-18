using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using AutoCSer.BinarySerialize;

namespace HighlightHelper {
  public interface ICloneable<T> {
    T Clone();
  };
  public class Profile : ICloneable<Profile> { // for Highlighting
    public string name;
    public List<string> word, wordnf, phrase;
    public Profile() {
      name = "";
      word = new List<string>();
      wordnf = new List<string>();
      phrase = new List<string>();
    }
    public bool Validate() {
      return !string.IsNullOrEmpty(name) && !string.IsNullOrWhiteSpace(name);
    }
    public Profile Clone() { // clone the object
      return new Profile {
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
      using (new System.IO.StreamWriter(ConfigManager.basedir + @"\word.txt", false)) { }
      using (new System.IO.StreamWriter(ConfigManager.basedir + @"\wordnf.txt", false)) { }
      using (new System.IO.StreamWriter(ConfigManager.basedir + @"\phrase.txt", false)) { }
    }
    public void Activate(out int count1, out int count2, out int count3) {
      count1 = count2 = count3 = 0;
      using (System.IO.StreamWriter file = new System.IO.StreamWriter(ConfigManager.basedir + @"\word.txt", true)) {
        foreach (string i in word) {
          if (Regex.IsMatch(i, "^([A-Za-z])+$")) {
            file.WriteLine(i); ++count1;
          }
        }
      }
      using (System.IO.StreamWriter file = new System.IO.StreamWriter(ConfigManager.basedir + @"\wordnf.txt", true)) {
        foreach (string i in wordnf) {
          if (Regex.IsMatch(i, "^([^ ])+$")) {
            file.WriteLine(i); ++count2;
          }
        }
      }
      using (System.IO.StreamWriter file = new System.IO.StreamWriter(ConfigManager.basedir + @"\phrase.txt", true)) {
        foreach (string i in phrase) {
          file.WriteLine(i); ++count3;
        }
      }
    }
  };
  public class ProfileOld : ICloneable<ProfileOld> {
    private string namei;
    public string name {
      get { return String.IsNullOrEmpty(namei) ? "" : namei; }
      set { namei = String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value) ? "" : value; }
    }
    public List<string> word, wordnf, phrase;
    public bool Validate() {
      return !String.IsNullOrEmpty(namei) && !String.IsNullOrWhiteSpace(namei);
    }
    public ProfileOld Clone() { // clone the object
      return new ProfileOld {
        name = name,
        word = word.ConvertAll(b => b.Clone() as string),
        wordnf = wordnf.ConvertAll(b => b.Clone() as string),
        phrase = phrase.ConvertAll(b => b.Clone() as string)
      };
    }
    public override string ToString() {
      return name;
    }
  };
  enum SortMethod { ASC, DESC, SHUFFLE };
  class ShufflerConfig {
    public bool addNumber, addMark, replaceChnSymbol, firstToLowercase, keepAtFirst, autoSplit;
    public decimal startNumber;
    public string splitText;
    public SortMethod sortMethod;
    public ShufflerConfig() {
      addNumber = addMark = replaceChnSymbol = keepAtFirst = autoSplit = true;
      keepAtFirst = false;
      startNumber = 1;
      splitText = " | ";
      sortMethod = SortMethod.ASC;
    }
  };
  class Config {
    public List<Profile> profiles;
    public int activeProfile;
    public ShufflerConfig shuffler;
    public Config() {
      activeProfile = -1;
      profiles = new List<Profile>();
      shuffler = new ShufflerConfig();
    }
  };
  static class ConfigManager {
    public static Config cfg;
    public static string filepath = "data.bin";
    public static string basedir = @"D:\WorkFinal";
    private readonly static int[] MAGICS = new int[] {
      0x5E4F1560
    };
    public static Profile getActiveProfile() {
      if (cfg.activeProfile >= cfg.profiles.Count) {
        cfg.activeProfile = -1;
      }
      if (cfg.activeProfile == -1) return null;
      return cfg.profiles[cfg.activeProfile];
    }
    private static int GetVersionMagic(byte[] ar) {
      if (ar.Length < 4) return 0;
      int magic = BitConverter.ToInt32(ar, 0);
      if (magic == MAGICS[0]) return 1;
      return 0;
    }
    public static bool Read() {
      FileStream fs;
      try {
        fs = new FileStream(filepath, FileMode.Open);
        long sizeLong = fs.Length;
        if (sizeLong > 2100000000) {
          throw new OverflowException("Config file is too large to read.");
        }
        int size = (int) fs.Length;
        byte[] ar = new byte[size], ar2 = new byte[size - 4];
        fs.Read(ar, 0, size); fs.Close();
        Array.Copy(ar, 4, ar2, 0, ar2.Length);
        switch (GetVersionMagic(ar)) {
          case 0:
            cfg = new Config();
            cfg.activeProfile = BitConverter.ToInt32(ar, 0);
            cfg.profiles = DeSerializer.DeSerialize<List<ProfileOld>>(ar2)
              .ConvertAll(x => {
                return new Profile { name = x.name, word = x.word, wordnf = x.wordnf, phrase = x.phrase };
              });
            cfg.shuffler = new ShufflerConfig();
            return true;
          case 1:
            cfg = DeSerializer.DeSerialize<Config>(ar2);
            return true;
          default:
            cfg = null;
            return false;
        }
      } catch { // unable to read
        cfg = null;
        return false;
      }
    }
    public static bool Write() {
      try {
        FileStream fs = new FileStream(filepath, FileMode.Create);
        byte[] ar = Serializer.Serialize(cfg);
        byte[] ar2 = new byte[ar.Length + 4];
        Array.Copy(BitConverter.GetBytes(MAGICS[0]), ar2, 4);
        Array.Copy(ar, 0, ar2, 4, ar.Length);
        fs.Write(ar2, 0, ar2.Length);
        fs.Close();
        return true;
      } catch {
        return false;
      }
    }
  };
}
