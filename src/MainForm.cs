using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using AutoUpdaterDotNET;

namespace HighlightHelper {
  public partial class MainForm : Form {
    private readonly Version versionA = new Version(1, 2, 2, 0);
    private readonly string versionB = "R 210317";

    private readonly string DataFile = "data.bin"; // need refactor
    private bool ischanging = false;
    private List<HighlightProfile> profiles = new List<HighlightProfile>();
    private int activeIndex = -1;

    public MainForm() {
      InitializeComponent();
    }

    private void ReadProfiles() {
      FileStream fs;
      try {
        fs = new FileStream(DataFile, FileMode.Open);
      }
      catch // no file
      {
        return;
      }
      long size = fs.Length;
      byte[] ar = new byte[size], ar2 = new byte[size - 4];
      fs.Read(ar, 0, ar.Length);
      fs.Close();
      activeIndex = BitConverter.ToInt32(ar, 0);
      Array.Copy(ar, 4, ar2, 0, ar2.Length);
      profiles = AutoCSer.BinarySerialize.DeSerializer.DeSerialize<List<HighlightProfile>>(ar2);
    }

    private void WriteProfiles() {
      byte[] ar = AutoCSer.BinarySerialize.Serializer.Serialize(profiles);
      byte[] ar2 = new byte[ar.Length + 4];
      Array.Copy(BitConverter.GetBytes(activeIndex), ar2, 4);
      Array.Copy(ar, 0, ar2, 4, ar.Length);
      FileStream fs = new FileStream(DataFile, FileMode.Create);
      fs.Write(ar2, 0, ar2.Length);
      fs.Close();
    }

    private void UpdateDisplay() {
      ischanging = true;
      if (activeIndex >= profiles.Count) activeIndex = -1;

      // Labels
      // statusSplit.Text = "Total: " + profiles.Count.ToString();
      if (activeIndex == -1) statusAct.Text = "当前配置: 无";
      else statusAct.Text = string.Format("当前配置: <{0}> - {1},{2},{3}", profiles[activeIndex].name, profiles[activeIndex].word.Count, profiles[activeIndex].wordnf.Count, profiles[activeIndex].phrase.Count);

      // Profiles
      profileBox.Items.Clear();
      foreach (HighlightProfile i in profiles) {
        profileBox.Items.Add(i.name);
      }
      profileBox.SelectedIndex = activeIndex;
      if (activeIndex == -1) profileBox.Text = "";
      else profileBox.Text = profileBox.SelectedItem as string;
      ischanging = false;
    }

    private bool EditProfile(int index = -1) {
      if (index == -1) index = activeIndex;
      if (index < 0 || index >= profiles.Count) return false;
      ProfileEditor editor = new ProfileEditor();
      editor.setTarget(profiles[index]);
      return editor.ShowDialog() == DialogResult.OK;
    }

    private void MainForm_Load(object sender, EventArgs e) {
      ReadProfiles();
      UpdateDisplay();

      statusVer.Text = "版本: " + versionA.ToString() + " | " + versionB.ToString();

      AutoUpdater.InstalledVersion = versionA;
      AutoUpdater.Start("https://proj.imchinanb.xyz/update.xml");
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
      // Save everything.
      WriteProfiles();
    }

    private void btnQuit_Click(object sender, EventArgs e) {
      Close();
    }

    private void btnEditProfile_Click(object sender, EventArgs e) {
      if (EditProfile()) {
        UpdateDisplay();
        WriteProfiles();
      }
    }

    private void btnNewProfile_Click(object sender, EventArgs e) {
      profiles.Add(new HighlightProfile());
      if (EditProfile(profiles.Count - 1)) {
        activeIndex = profiles.Count - 1;
        UpdateDisplay();
        WriteProfiles();
      } else {
        profiles.Remove(profiles.Last());
      }
    }

    private void btnDeleteProfile_Click(object sender, EventArgs e) {
      if (activeIndex < 0 || activeIndex >= profiles.Count) return;

      if (MessageBox.Show(this, "你真的要删除这个配置吗?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
        profiles.RemoveAt(activeIndex);
        if (activeIndex < 0 || activeIndex >= profiles.Count) activeIndex = -1;
        UpdateDisplay();
      }
    }

    private void btnSelectProfile_Click(object sender, EventArgs e) {
      ActivateForm af = new ActivateForm(profiles);
      af.ShowDialog();
    }

    private void profileBox_SelectedIndexChanged(object sender, EventArgs e) {
      if (!ischanging) {
        activeIndex = profileBox.SelectedIndex;
        UpdateDisplay();
        WriteProfiles();
      }
    }

    private void itemOpenShuffler_Click(object sender, EventArgs e) {
      (new Shuffler()).ShowDialog();
    }

    private void itemOpenGithub_Click(object sender, EventArgs e) {
      System.Diagnostics.Process.Start("https://github.com/ImChinaNB/HighlightHelper");
    }
  }
}
