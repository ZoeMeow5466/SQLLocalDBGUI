using SQLLocalDBGUI.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace Zoe13010.SQLLocalDB.GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            btnDetectExecFile_Click(btnDetectExecFile, new EventArgs());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnDetectExecFile_Click(btnDetectExecFile, new EventArgs());
        }

        private void btnDetectExecFile_Click(object sender, EventArgs e)
        {
            if (SqlLocalDBCommand.DetectSQLLocalDB())
            {
                lbDetectStatus.Text = "Detected";
                btnLoadInstance_Click(btnLoadInstance, new EventArgs());
            }
            else lbDetectStatus.Text = "Not detected or error";
        }

        private void btnLoadInstance_Click(object sender, EventArgs e)
        {
            List<string> d = SqlLocalDBCommand.GetAllInstance();
            cbInstance.Items.Clear();
            cbInstance.Items.AddRange(d.ToArray());
            try { cbInstance.SelectedIndex = 0; }
            catch { }
        }

        private void cbInstance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
                this.Invoke((MethodInvoker)delegate { cbInstance_SelectedIndexChanged(sender, e); });
            else
            {
                var d = SqlLocalDBCommand.GetInfoInstance(cbInstance.SelectedItem.ToString());
                var d1 = (InstanceInfo)d.Object;
                lbInstanceName.Text = d1.Name;
                lbInstanceOwner.Text = d1.Owner;
                lbInstanceAutoCreate.Text = d1.AutoCreate == true ? "Yes" : "No";
                lbInstanceLastStartTime.Text = d1.LastStartTime;
                tbInstancePipeName.Text = d1.PipeName;
                lbInstanceSharedName.Text = d1.SharedName;
                lbInstanceState.Text = d1.State.ToString();
                lbInstanceVer.Text = d1.Version;

                if (d1.State == InstanceState.Running)
                {
                    btnStart.Enabled = false;
                    btnStop.Enabled = true;
                    btnOpenSqlCmd.Enabled = true;
                    btnDelete.Enabled = false;
                }
                else if (d1.State == InstanceState.Stopped)
                {
                    btnStop.Enabled = false;
                    btnStart.Enabled = true;
                    btnDelete.Enabled = true;
                    btnOpenSqlCmd.Enabled = false;
                }
                else
                {
                    btnStop.Enabled = true;
                    btnStart.Enabled = true;
                    btnDelete.Enabled = true;
                    btnOpenSqlCmd.Enabled = true;
                }
            }
        }

        private void btnRefreshInstanceInfo_Click(object sender, EventArgs e)
        {
            cbInstance_SelectedIndexChanged(cbInstance, new EventArgs());
        }

        private void btnCreateInstance_Click(object sender, EventArgs e)
        {
            CreateInstance frm = new CreateInstance();
            frm.Top = this.Top + (this.Height / 2 - frm.Height / 2);
            frm.Left = this.Left + (this.Width / 2 - frm.Width / 2);
            bool cancelled = false;
            do
            {
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    if (cbInstance.Items.Contains(frm.TextBoxData))
                        MessageBox.Show("Another instance which same instance name has exist!\nPlease choose another name.",
                            this.Text,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    else
                    {
                        var d = SqlLocalDBCommand.Actions(frm.TextBoxData, "create");
                        if (d.ExecuteSuccessful)
                        {
                            MessageBox.Show(String.Format("Successfully created instance \"{0}\".", frm.TextBoxData),
                                this.Text,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(String.Format("Failed when create instance \"{0}\".", frm.TextBoxData),
                                this.Text,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                        btnLoadInstance_Click(btnLoadInstance, new EventArgs());
                        cancelled = true;
                    }
                }
                else cancelled = true;
            }
            while (!cancelled);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            SqlLocalDBCommand.Actions(cbInstance.SelectedItem.ToString(), "start");
            btnRefreshInstanceInfo_Click(btnRefreshInstanceInfo, new EventArgs());
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            SqlLocalDBCommand.Actions(cbInstance.SelectedItem.ToString(), "stop");
            btnRefreshInstanceInfo_Click(btnRefreshInstanceInfo, new EventArgs());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlLocalDBCommand.Actions(cbInstance.SelectedItem.ToString(), "delete");
            btnLoadInstance_Click(btnLoadInstance, new EventArgs());
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpenSqlCmd_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            try
            {
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.Arguments = String.Format(@"/c title SqlCommand - {0} & echo. & echo.Type 'quit' to quit. & echo. & sqlcmd.exe -S (LocalDB)\{0}", cbInstance.SelectedItem.ToString());

                this.Hide();
                p.Start();
                p.WaitForExit();
            }
            catch
            {

            }
            finally
            {
                p.Close();
                p.Dispose();
                this.Show();
            }
        }
    }
}
