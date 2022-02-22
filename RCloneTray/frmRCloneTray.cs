using System.Configuration;
using System.Diagnostics;

namespace RCloneTray
{
    public partial class frmRCloneTray : Form
    {
        private bool allowShowDisplay = false;
        private string driveLetter1 = String.Empty;
        private string driveLetter2 = String.Empty;
        private string driveLetter3 = String.Empty;
        private string remote1 = String.Empty;
        private string remote2 = String.Empty;
        private string remote3 = String.Empty;
        private int pid1 = -1;
        private int pid2 = -1;
        private int pid3 = -1;

        public frmRCloneTray()
        {
            InitializeComponent();

            string rcloneRemote1 = GetConfig("rcloneRemote1");
            string rcloneRemote2 = GetConfig("rcloneRemote2");
            string rcloneRemote3 = GetConfig("rcloneRemote3");

            if (!String.IsNullOrEmpty(rcloneRemote1))
            {
                driveLetter1 = rcloneRemote1.Split(';')[0];
                remote1 = rcloneRemote1.Split(';')[1];
                tsmiMountRemote1.Text = remote1;
                tsmiMountRemote1.Enabled = true;
                tsmiUnmountRemote1.Text = remote1;
            }
            if (!String.IsNullOrEmpty(rcloneRemote2))
            {
                driveLetter2 = rcloneRemote2.Split(';')[0];
                remote2 = rcloneRemote2.Split(';')[1];
                tsmiMountRemote2.Text = remote2;
                tsmiMountRemote2.Enabled = true;
                tsmiUnmountRemote2.Text = remote2;
            }
            if (!String.IsNullOrEmpty(rcloneRemote3))
            {
                driveLetter3 = rcloneRemote3.Split(';')[0];
                remote3 = rcloneRemote3.Split(';')[1];
                tsmiMountRemote3.Text = remote3;
                tsmiMountRemote3.Enabled = true;
                tsmiUnmountRemote3.Text = remote3;
            }

        }

        protected override void SetVisibleCore(bool value)
        {
            base.SetVisibleCore(allowShowDisplay ? value : allowShowDisplay);
        }

        public static void SetConfig(string key, string value)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
            if (settings[key] == null)
            {
                settings.Add(key, value);
            }
            else
            {
                settings[key].Value = value;
            }
            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        }

        public static string GetConfig(string key)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return ConfigurationManager.AppSettings[key];
#pragma warning restore CS8603 // Possible null reference return.
        }

        public int RCloneMount(string rcloneMountDriveLetter, string rcloneRemote)
        {
            Process rcloneProcess = new Process();
            rcloneProcess.StartInfo = new ProcessStartInfo(GetConfig("rcloneBin"));
            rcloneProcess.StartInfo.Arguments = "mount " + rcloneRemote + " " + rcloneMountDriveLetter;
            rcloneProcess.StartInfo.CreateNoWindow = true;
            rcloneProcess.StartInfo.UseShellExecute = false;
            rcloneProcess.Start();

            return rcloneProcess.Id;
        }

        public void RCloneUnmount(int pid)
        {
            if (pid > -1)
            {
                Process process = Process.GetProcessById(pid);
                process.Kill();
            }
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            tsmiUnmountRemote1.PerformClick();
            tsmiUnmountRemote2.PerformClick();
            tsmiUnmountRemote3.PerformClick();
            Application.Exit();
        }

        #region Mounts
        private void tsmiMountRemote1_Click(object sender, EventArgs e)
        {
            pid1 = RCloneMount(driveLetter1, remote1);
            tsmiMountRemote1.Text = "[MOUNTED] " + remote1;
            tsmiMountRemote1.Enabled = false;
            tsmiUnmountRemote1.Enabled = true;
        }

        private void tsmiMountRemote2_Click(object sender, EventArgs e)
        {
            pid2 = RCloneMount(driveLetter2, remote2);
            tsmiMountRemote2.Text = "[MOUNTED] " + remote2;
            tsmiMountRemote2.Enabled = false;
            tsmiUnmountRemote2.Enabled = true;
        }

        private void tsmiMountRemote3_Click(object sender, EventArgs e)
        {
            pid3 = RCloneMount(driveLetter3, remote3);
            tsmiMountRemote3.Text = "[MOUNTED] " + remote3;
            tsmiMountRemote3.Enabled = false;
            tsmiUnmountRemote3.Enabled = true;
        }
        #endregion

        #region Unmounts
        private void tsmiUnmountRemote1_Click(object sender, EventArgs e)
        {
            if (pid1 > -1)
            {
                RCloneUnmount(pid1);
                tsmiUnmountRemote1.Enabled = false;
                tsmiMountRemote1.Text = remote1;
                tsmiMountRemote1.Enabled = true;
                pid1 = -1;
            }
        }

        private void tsmiUnmountRemote2_Click(object sender, EventArgs e)
        {
            if (pid2 > -1)
            {
                RCloneUnmount(pid2);
                tsmiUnmountRemote2.Enabled = false;
                tsmiMountRemote2.Text = remote2;
                tsmiMountRemote2.Enabled = true;
                pid2 = -1;
            }
        }

        private void tsmiUnmountRemote3_Click(object sender, EventArgs e)
        {
            if (pid3 > -1)
            {
                RCloneUnmount(pid3);
                tsmiUnmountRemote3.Enabled = false;
                tsmiMountRemote3.Text = remote3;
                tsmiMountRemote3.Enabled = true;
                pid3 = -1;
            }
        }
        #endregion

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("https://github.com/DRN88 \n Licence: WTFPL", "About", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void tsmiOpenRCloneConfigDir_Click(object sender, EventArgs e)
        {
            Process rcloneProcess = new Process();
            rcloneProcess.StartInfo = new ProcessStartInfo("explorer.exe");
            rcloneProcess.StartInfo.Arguments = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\rclone";
            rcloneProcess.StartInfo.CreateNoWindow = true;
            rcloneProcess.StartInfo.UseShellExecute = false;
            rcloneProcess.Start();
        }

        private void tsmiOpenRCloneTrayDir_Click(object sender, EventArgs e)
        {
            Process rcloneProcess = new Process();
            rcloneProcess.StartInfo = new ProcessStartInfo("explorer.exe");
            rcloneProcess.StartInfo.Arguments = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\RCloneTray\RCloneTray";
            rcloneProcess.StartInfo.CreateNoWindow = true;
            rcloneProcess.StartInfo.UseShellExecute = false;
            rcloneProcess.Start();
        }
    }
}