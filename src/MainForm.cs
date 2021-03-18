using System;
using System.Linq;
using System.Windows.Forms;
using AutoUpdaterDotNET;
using man = HighlightHelper.ConfigManager;

namespace HighlightHelper {
  public partial class MainForm : Form {
    private readonly Version versionA = new Version(1, 3, 0, 0);
    private readonly string versionB = "R 210318";

    private bool ischanging = false, loaded = false;

    public MainForm() {
      InitializeComponent();
    }

    private void UpdateDisplay() {
      ischanging = true;
      Profile pro = man.getActiveProfile();

      if (pro == null) statusAct.Text = string.Format("<None> of {0} profiles", man.cfg.profiles.Count);
      else statusAct.Text = string.Format(
        "<{0}> of {4} profiles: {1} words, {2} S-words, {3} phrases",
        pro.name,
        pro.word.Count,
        pro.wordnf.Count,
        pro.phrase.Count,
        man.cfg.profiles.Count
      );

      profileBox.Items.Clear();
      foreach (Profile i in man.cfg.profiles) {
        profileBox.Items.Add(i.name);
      }
      profileBox.SelectedIndex = man.cfg.activeProfile;
      if (man.cfg.activeProfile == -1) profileBox.Text = "";
      else profileBox.Text = profileBox.SelectedItem as string;
      ischanging = false;
    }

    private bool EditProfile(int index = -1) {
      if (index == -1) index = man.cfg.activeProfile;
      if (index < 0 || index >= man.cfg.profiles.Count) return false;
      ProfileEditor editor = new ProfileEditor();
      editor.setTarget(man.cfg.profiles[index]);
      return editor.ShowDialog() == DialogResult.OK;
    }

    private void Save() {
      if (loaded) {
        statusSaved.Text = "Saving...";
        if (man.Write()) {
          statusSaved.Text = "Saved";
        } else {
          statusSaved.Text = "Failed to save";
          MessageBox.Show("无法保存数据文件。", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void MainForm_Load(object sender, EventArgs e) {
      if (System.IO.File.Exists(ConfigManager.filepath)) {
        if (!man.Read()) {
          statusSaved.Text = "Failed to load";
          MessageBox.Show("无法加载数据文件。", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
          Close();
        } else loaded = true;
      } else {
        man.cfg = new Config();
        loaded = true;
      }
      statusSaved.Text = "Loaded";

      UpdateDisplay();
      statusVer.Text = "版本: " + versionA.ToString() + " | " + versionB.ToString();

      AutoUpdater.InstalledVersion = versionA;
      AutoUpdater.Start("https://proj.imchinanb.xyz/update.xml");
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
    }

    private void btnQuit_Click(object sender, EventArgs e) {
      Close();
    }

    private void btnEditProfile_Click(object sender, EventArgs e) {
      if (EditProfile()) {
        UpdateDisplay();
        Save();
      }
    }

    private void btnNewProfile_Click(object sender, EventArgs e) {
      man.cfg.profiles.Add(new Profile());
      if (EditProfile(man.cfg.profiles.Count - 1)) {
        man.cfg.activeProfile = man.cfg.profiles.Count - 1;
        UpdateDisplay();
        Save();
      } else {
        man.cfg.profiles.Remove(man.cfg.profiles.Last());
      }
    }

    private void btnDeleteProfile_Click(object sender, EventArgs e) {
      Profile pro = man.getActiveProfile();
      if (pro == null) return;

      if (MessageBox.Show(this, "你真的要删除这个配置吗?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
        man.cfg.profiles.RemoveAt(man.cfg.activeProfile);
        UpdateDisplay();
      }
    }

    private void btnSelectProfile_Click(object sender, EventArgs e) {
      ActivateForm af = new ActivateForm(man.cfg.profiles);
      af.ShowDialog();
    }

    private void profileBox_SelectedIndexChanged(object sender, EventArgs e) {
      if (!ischanging) {
        man.cfg.activeProfile = profileBox.SelectedIndex;
        UpdateDisplay();
        Save();
      }
    }

    private void itemOpenShuffler_Click(object sender, EventArgs e) {
      (new Shuffler()).ShowDialog();
      Save();
    }

    private void itemOpenGithub_Click(object sender, EventArgs e) {
      System.Diagnostics.Process.Start("https://github.com/ImChinaNB/HighlightHelper");
    }
  }
}
