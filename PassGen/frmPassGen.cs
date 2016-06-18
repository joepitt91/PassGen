using System;
using System.Windows.Forms;

namespace PassGen
{
    public partial class frmPassGen : Form
    {
        public frmPassGen()
        {
            InitializeComponent();

            bkgGetPasswords.DoWork += BkgGetPasswords_DoWork;
            this.FormClosing += FrmPassGen_FormClosing;
            this.HelpButtonClicked += FrmPassGen_HelpButtonClicked;
        }

        /// <summary>
        /// Restores the User's settings once the form has initialised.
        /// </summary>
        /// <param name="sender">System Generated.</param>
        /// <param name="e">System Generated.</param>
        private void frmPassGen_Load(object sender, EventArgs e)
        {
            // Restore Settings. Revert to defaults if there are any errors.
            try
            {
                chkLower.Checked = Properties.Settings.Default.Lower;
                chkUpper.Checked = Properties.Settings.Default.Upper;
                chkNumber.Checked = Properties.Settings.Default.Number;
                chkSpecial.Checked = Properties.Settings.Default.Special;
                chkSpace.Checked = Properties.Settings.Default.Space;
                chkIncludeAll.Checked = Properties.Settings.Default.IncludeAll;
                numLength.Value = Properties.Settings.Default.Length;
            }
            catch
            {
                Properties.Settings.Default.Reset();
            }
        }

        /// <summary>
        /// Shows the about box including instructions for use and licensing.
        /// </summary>
        /// <param name="sender">System Generated.</param>
        /// <param name="e">System Generated.</param>
        private void FrmPassGen_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            AboutBox dlgAbout = new AboutBox();
            dlgAbout.ShowDialog();
            e.Cancel = true;
        }

        /// <summary>
        /// Generates 10 passwords and updates the UI without causing the UI to not respond.
        /// </summary>
        /// <param name="sender">System Generated.</param>
        /// <param name="e">System Generated.</param>
        private void BkgGetPasswords_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            // Block the UI Controls.
            Action BlockUI = () => grpSettings.Enabled = false;
            grpSettings.Invoke(BlockUI);

            // Generate Passwords based on the settings defined.
            string[] Password = new string[10];
            int i = 0;
            while (i < 10)
            {
                Password[i] = Generator.NewPass((int)numLength.Value, chkLower.Checked, chkUpper.Checked, chkNumber.Checked, chkSpecial.Checked, chkSpace.Checked, chkIncludeAll.Checked);
                i++;
            }

            BeginInvoke((MethodInvoker)delegate
            {
                // Update UI with Generated Passwords.
                txtPass01.Text = Password[0];
                txtPass02.Text = Password[1];
                txtPass03.Text = Password[2];
                txtPass04.Text = Password[3];
                txtPass05.Text = Password[4];
                txtPass06.Text = Password[5];
                txtPass07.Text = Password[6];
                txtPass08.Text = Password[7];
                txtPass09.Text = Password[8];
                txtPass10.Text = Password[9];

                // Select all text to make copying easier.
                txtPass01.SelectAll();
                txtPass02.SelectAll();
                txtPass03.SelectAll();
                txtPass04.SelectAll();
                txtPass05.SelectAll();
                txtPass06.SelectAll();
                txtPass07.SelectAll();
                txtPass08.SelectAll();
                txtPass09.SelectAll();
                txtPass10.SelectAll();
            });

            // Unblock the UI Controls.
            Action UnblockUI = () => grpSettings.Enabled = true;
            grpSettings.Invoke(UnblockUI);
        }

        /// <summary>
        /// Saves settings as the form closes.
        /// </summary>
        /// <param name="sender">System Generated.</param>
        /// <param name="e">System Generated.</param>
        private void FrmPassGen_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save Settings.
            Properties.Settings.Default.Lower = chkLower.Checked;
            Properties.Settings.Default.Upper = chkUpper.Checked;
            Properties.Settings.Default.Number = chkNumber.Checked;
            Properties.Settings.Default.Special = chkSpecial.Checked;
            Properties.Settings.Default.Space = chkSpace.Checked;
            Properties.Settings.Default.IncludeAll = chkIncludeAll.Checked;
            Properties.Settings.Default.Length = (int)numLength.Value;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Carries out checks, then tirggers BkgGetPasswords_DoWork via a Background Worker.
        /// </summary>
        /// <param name="sender">System Generated.</param>
        /// <param name="e">System Generated.</param>
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Save Settings.
            Properties.Settings.Default.Lower = chkLower.Checked;
            Properties.Settings.Default.Upper = chkUpper.Checked;
            Properties.Settings.Default.Number = chkNumber.Checked;
            Properties.Settings.Default.Special = chkSpecial.Checked;
            Properties.Settings.Default.Space = chkSpace.Checked;
            Properties.Settings.Default.IncludeAll = chkIncludeAll.Checked;
            Properties.Settings.Default.Length = (int)numLength.Value;
            Properties.Settings.Default.Save();

            // Check a Character Set is enabled.
            if (!chkLower.Checked && !chkUpper.Checked && !chkNumber.Checked && !chkSpecial.Checked && !chkSpace.Checked)
            {
                MessageBox.Show("You must select at least one charater set first.", "No Character Sets Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Prevent exceptions when holding enter for new passwords.
            if (!bkgGetPasswords.IsBusy)
            {
                // Generate Passwords without blocking UI.
                bkgGetPasswords.RunWorkerAsync();
            }
        }
    }
}
