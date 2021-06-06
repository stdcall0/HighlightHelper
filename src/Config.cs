using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using AutoCSer.BinarySerialize;

using Config = HighlightHelper.ConfigV3;

namespace HighlightHelper {
  public interface ICloneable<T> {
    T Clone();
  };
  public class ProfileV0 : ICloneable<ProfileV0> {
    private string namei;
    public string name {
      get { return string.IsNullOrEmpty(namei) ? "" : namei; }
      set { namei = string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) ? "" : value; }
    }
    public List<string> word, wordnf, phrase;
    public bool Validate() {
      return !string.IsNullOrEmpty(namei) && !string.IsNullOrWhiteSpace(namei);
    }
    public ProfileV0 Clone() { // clone the object
      return new ProfileV0 {
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
  enum SortMethod { ASC, DESC, SHUFFLE };
  class ShufflerConfigV0 {
    public bool addNumber, addMark, replaceChnSymbol, firstToLowercase, keepAtFirst, autoSplit;
    public decimal startNumber;
    public string splitText;
    public SortMethod sortMethod;
    public ShufflerConfigV0() {
      addNumber = addMark = replaceChnSymbol = autoSplit = true;
      firstToLowercase = keepAtFirst = false;
      startNumber = 1;
      splitText = " ";
      sortMethod = SortMethod.ASC;
    }
  };
  class ShufflerConfigV1 {
    public bool addNumber, addMark, replaceChnSymbol, firstToLowercase, keepAtFirst, autoSplit;
    public decimal startNumber;
    public string splitText, splitChars;
    public SortMethod sortMethod;
    public ShufflerConfigV1() {
      addNumber = addMark = replaceChnSymbol = autoSplit = true;
      firstToLowercase = keepAtFirst = false;
      startNumber = 1;
      splitText = " ";
      splitChars = ".!?";
      sortMethod = SortMethod.ASC;
    }
    public static ShufflerConfigV1 fromV0(ShufflerConfigV0 v0) {
      ShufflerConfigV1 ret = new ShufflerConfigV1();
      ret.addNumber = v0.addNumber;
      ret.addMark = v0.addMark;
      ret.replaceChnSymbol = v0.replaceChnSymbol;
      ret.keepAtFirst = v0.keepAtFirst;
      ret.autoSplit = v0.autoSplit;
      ret.startNumber = v0.startNumber;
      ret.splitText = v0.splitText.Clone() as string;
      ret.sortMethod = v0.sortMethod;
      return ret;
    }
  };
  class ShufflerConfigV2 {
    public bool addNumber, addMark, replaceChnSymbol, firstToLowercase, keepAtFirst, autoSplit;
    public decimal startNumber;
    public string sentenceSplit, outputSplit, wordSplit;
    public SortMethod sortMethod;
    public ShufflerConfigV2() {
      addNumber = addMark = replaceChnSymbol = autoSplit = true;
      firstToLowercase = keepAtFirst = false;
      startNumber = 1;
      outputSplit = " ";
      wordSplit = "•,";
      sentenceSplit = ".!?";
      sortMethod = SortMethod.ASC;
    }
    public static ShufflerConfigV2 fromV1(ShufflerConfigV1 v1) {
      ShufflerConfigV2 ret = new ShufflerConfigV2();
      ret.addNumber = v1.addNumber;
      ret.addMark = v1.addMark;
      ret.replaceChnSymbol = v1.replaceChnSymbol;
      ret.keepAtFirst = v1.keepAtFirst;
      ret.autoSplit = v1.autoSplit;
      ret.startNumber = v1.startNumber;
      ret.outputSplit = v1.splitText.Clone() as string;
      ret.sentenceSplit = v1.splitChars.Clone() as string;
      ret.sortMethod = v1.sortMethod;
      return ret;
    }
  };

  class ConfigV0 {
    public readonly static int MAGIC = 0;
    public static bool Check(int magic) {
      return MAGIC == magic;
    }

    public List<ProfileV0> profiles;
    public int activeProfile;
    public ConfigV0() {
      activeProfile = -1;
      profiles = new List<ProfileV0>();
    }
    public static ConfigV0 Read(byte[] ar, int magic) {
      ConfigV0 ret = new ConfigV0();
      ret.activeProfile = magic;
      ret.profiles = DeSerializer.DeSerialize<List<ProfileV0>>(ar);

      return ret;
    }
    public ConfigV1 Convert() {
      return new ConfigV1 {
        profiles = profiles.ConvertAll(
          new Converter<ProfileV0, Profile>((ProfileV0 v0) => {
            return new Profile {
              name = v0.name,
              word = v0.word.ConvertAll(b => b.Clone() as string),
              wordnf = v0.wordnf.ConvertAll(b => b.Clone() as string),
              phrase = v0.phrase.ConvertAll(b => b.Clone() as string)
            };
          })
          ),
        activeProfile = activeProfile,
        shuffler = new ShufflerConfigV0()
      };
    }
  };

  class ConfigV1 {
    public readonly static int MAGIC = 0x5E4F1560;
    public static bool Check(int magic) {
      return MAGIC == magic;
    }

    public List<Profile> profiles;
    public int activeProfile;
    public ShufflerConfigV0 shuffler;
    public ConfigV1() {
      activeProfile = -1;
      profiles = new List<Profile>();
      shuffler = new ShufflerConfigV0();
    }
    public static ConfigV1 Read(byte[] ar, int magic) {
      return DeSerializer.DeSerialize<ConfigV1>(ar);
    }

    public ConfigV2 Convert() {
      return new ConfigV2() {
        profiles = profiles,
        activeProfile = activeProfile,
        shuffler = ShufflerConfigV1.fromV0(shuffler)
      };
    }
  };
  class ConfigV2 {
    public readonly static int MAGIC = 0x123400FF;
    public static bool Check(int magic) {
      return MAGIC == magic;
    }

    public List<Profile> profiles;
    public int activeProfile;
    public ShufflerConfigV1 shuffler;
    public ConfigV2() {
      activeProfile = -1;
      profiles = new List<Profile>();
      shuffler = new ShufflerConfigV1();
    }
    public static ConfigV2 Read(byte[] ar, int magic) {
      return DeSerializer.DeSerialize<ConfigV2>(ar);
    }
    public ConfigV3 Convert() {
      return new ConfigV3() {
        profiles = profiles,
        activeProfile = activeProfile,
        shuffler = ShufflerConfigV2.fromV1(shuffler)
      };
    }
  };
  class ConfigV3 {
    public readonly static int MAGIC = 0x123401FF;
    public static bool Check(int magic) {
      return MAGIC == magic;
    }

    public List<Profile> profiles;
    public int activeProfile;
    public ShufflerConfigV2 shuffler;
    public ConfigV3() {
      activeProfile = -1;
      profiles = new List<Profile>();
      shuffler = new ShufflerConfigV2();
    }
    public static ConfigV3 Read(byte[] ar, int magic) {
      return DeSerializer.DeSerialize<ConfigV3>(ar);
    }
  };

  static class ConfigManager {
    public static string filepath = "data.bin";
    public static string basedir = @"D:\WorkFinal";

    public static Config cfg;

    public static Profile getActiveProfile() {
      if (cfg.activeProfile >= cfg.profiles.Count) {
        cfg.activeProfile = -1;
      }
      if (cfg.activeProfile == -1) return null;
      return cfg.profiles[cfg.activeProfile];
    }

    public static void Init() {
      if (cfg == null) cfg = new Config();
    }

    public static bool Read() {
      FileStream fs;
      try {
        fs = new FileStream(filepath, FileMode.Open);
        long sizeLong = fs.Length;
        if (sizeLong > 2100000000) {
          throw new OverflowException("Config file is too large to read.");
        }

        int size = (int)fs.Length;
        byte[] ar = new byte[size], ar2 = new byte[size - 4];
        fs.Read(ar, 0, size); fs.Close();
        Array.Copy(ar, 4, ar2, 0, ar2.Length);

        int magic = BitConverter.ToInt32(ar, 0);
        if (ConfigV3.Check(magic)) {
          cfg = ConfigV3.Read(ar2, magic);
        } else if (ConfigV2.Check(magic)) {
          cfg = ConfigV2.Read(ar2, magic).Convert();
        } else if (ConfigV1.Check(magic)) {
          cfg = ConfigV1.Read(ar2, magic).Convert().Convert();
        } else {
          cfg = ConfigV0.Read(ar2, magic).Convert().Convert().Convert();
        }

        return true;

      }
      catch { // unable to read
        cfg = null;
        return false;
      }
    }
    public static bool Write() {
      try {
        FileStream fs = new FileStream(filepath, FileMode.Create);

        byte[] ar = Serializer.Serialize(cfg);
        byte[] ar2 = new byte[ar.Length + 4];

        Array.Copy(BitConverter.GetBytes(Config.MAGIC), ar2, 4);
        Array.Copy(ar, 0, ar2, 4, ar.Length);

        fs.Write(ar2, 0, ar2.Length);
        fs.Close();

        return true;

      }
      catch {
        return false;
      }
    }
  };

}
