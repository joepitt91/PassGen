using JoePitt.PassGen.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace JoePitt.PassGen
{
    public partial class frmPassGen : Form
    {
        //General
        public frmPassGen()
        {
            //General
            InitializeComponent();
            FormClosing += FrmPassGen_FormClosing;
            HelpButtonClicked += FrmPassGen_HelpButtonClicked;
            tbgGenerators.SelectedIndexChanged += TbgGenerators_SelectedIndexChanged;
            //Crypto
            bkgCryptoGen.DoWork += bkgCryptoGen_DoWork;
            bkgCryptoGen.RunWorkerCompleted += BkgCryptoGen_RunWorkerCompleted;
            //Words
            bkgWordsGen.DoWork += BkgWordsGen_DoWork;
            bkgWordsGen.RunWorkerCompleted += BkgWordsGen_RunWorkerCompleted;
            //CVC
            bkgCVCGen.DoWork += BkgCVCGen_DoWork;
            bkgCVCGen.RunWorkerCompleted += BkgCVCGen_RunWorkerCompleted;
        }

        private void frmPassGen_Load(object sender, EventArgs e)
        {
            // Restore Settings. Revert to defaults if there are any errors.
            try
            {
                chkCryptoLower.Checked = Properties.Settings.Default.Lower;
                chkCryptoUpper.Checked = Properties.Settings.Default.Upper;
                chkCryptoNumber.Checked = Properties.Settings.Default.Number;
                chkCryptoSpecial.Checked = Properties.Settings.Default.Special;
                chkCryptoSpace.Checked = Properties.Settings.Default.Space;
                chkCryptoIncludeAll.Checked = Properties.Settings.Default.IncludeAll;
                numCryptoLength.Value = Properties.Settings.Default.Length;
            }
            catch
            {
                Properties.Settings.Default.Reset();
            }
        }

        private void FrmPassGen_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            AboutBox dlgAbout = new AboutBox();
            dlgAbout.ShowDialog();
            e.Cancel = true;
        }

        private void TbgGenerators_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbgGenerators.SelectedTab == tabCrypto)
            {
                AcceptButton = btnCryptoGenerate;
                CancelButton = btnCryptoGenerate;
            }
            else if (tbgGenerators.SelectedTab == tabWords)
            {
                AcceptButton = btnWordsGenerate;
                CancelButton = btnWordsGenerate;
            }
            else if (tbgGenerators.SelectedTab == tabCVC)
            {
                AcceptButton = btnCVCGenerate;
                CancelButton = btnCVCGenerate;
            }
        }
        
        private void FrmPassGen_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save Settings.
            Properties.Settings.Default.Lower = chkCryptoLower.Checked;
            Properties.Settings.Default.Upper = chkCryptoUpper.Checked;
            Properties.Settings.Default.Number = chkCryptoNumber.Checked;
            Properties.Settings.Default.Special = chkCryptoSpecial.Checked;
            Properties.Settings.Default.Space = chkCryptoSpace.Checked;
            Properties.Settings.Default.IncludeAll = chkCryptoIncludeAll.Checked;
            Properties.Settings.Default.Length = (int)numCryptoLength.Value;
            Properties.Settings.Default.Save();
        }

        // Crypto
        private void bkgCryptoGen_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            // Block the UI Controls.
            Action BlockUI = () => grpCryptoSettings.Enabled = false;
            grpCryptoSettings.Invoke(BlockUI);

            // Generate Passwords based on the settings defined.
            CryptoGenerator Generator = new CryptoGenerator();
            List<string> Passwords = new List<string>();
            int i = 0;
            while (i < 10)
            {
                Passwords.Add(Generator.Next((int)numCryptoLength.Value, chkCryptoLower.Checked, chkCryptoUpper.Checked, chkCryptoNumber.Checked, chkCryptoSpecial.Checked, chkCryptoSpace.Checked, chkCryptoIncludeAll.Checked));
                i++;
            }
            // Update UI
            BeginInvoke((MethodInvoker)delegate
            {
                int j = 0;
                foreach (TextBox pwBox in tabCrypto.Controls.OfType<TextBox>())
                {
                    pwBox.Text = Passwords[j];
                    pwBox.Select(0, 0);
                    j++;
                }
            });

            // Unblock the UI Controls.
            Action UnblockUI = () => grpCryptoSettings.Enabled = true;
            grpCryptoSettings.Invoke(UnblockUI);
        }

        private void BkgCryptoGen_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            tbgGenerators.SelectedTab = tabCrypto;
            txtCrypto01.Focus();
        }

        private void btnCryptoGenerate_Click(object sender, EventArgs e)
        {
            // Save Settings.
            Properties.Settings.Default.Lower = chkCryptoLower.Checked;
            Properties.Settings.Default.Upper = chkCryptoUpper.Checked;
            Properties.Settings.Default.Number = chkCryptoNumber.Checked;
            Properties.Settings.Default.Special = chkCryptoSpecial.Checked;
            Properties.Settings.Default.Space = chkCryptoSpace.Checked;
            Properties.Settings.Default.IncludeAll = chkCryptoIncludeAll.Checked;
            Properties.Settings.Default.Length = (int)numCryptoLength.Value;
            Properties.Settings.Default.Save();

            // Check a Character Set is enabled.
            if (!chkCryptoLower.Checked && !chkCryptoUpper.Checked && !chkCryptoNumber.Checked && !chkCryptoSpecial.Checked && !chkCryptoSpace.Checked)
            {
                MessageBox.Show("You must select at least one charater set first.", "No Character Sets Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Prevent exceptions when holding enter for new passwords.
            if (!bkgCryptoGen.IsBusy)
            {
                // Generate Passwords without blocking UI.
                bkgCryptoGen.RunWorkerAsync();
                tbgGenerators.Focus();
            }
        }

        // Words
        List<char> WordsFormat = new List<char>() { 'D', 'A', 'N' };

        private void BkgWordsGen_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            // Lock UI
            Action BlockUI = () => grpWordsSettings.Enabled = false;
            grpWordsSettings.Invoke(BlockUI);

            // Generate Passwords based on the settings defined.
            WordsGenerator Generator = new WordsGenerator();
            List<string> Passwords = new List<string>();
            int i = 0;
            while (i < 10)
            {
                Passwords.Add(Generator.Next(WordsFormat));
                i++;
            }
            // Update UI
            BeginInvoke((MethodInvoker)delegate
            {
                int j = 0;
                foreach (TextBox pwBox in tabWords.Controls.OfType<TextBox>())
                {
                    pwBox.Text = Passwords[j];
                    pwBox.Select(0, 0);
                    j++;
                }
            });

            // Unblock the UI Controls.
            Action UnblockUI = () => grpWordsSettings.Enabled = true;
            grpWordsSettings.Invoke(UnblockUI);
        }

        private void BkgWordsGen_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            tbgGenerators.SelectedTab = tabWords;
            txtWords01.Focus();
        }

        private void UpdateWordsFormat()
        {
            txtWordsFormat.Text = "";
            foreach (char Type in WordsFormat)
            {
                switch (Type)
                {
                    case 'A':
                        txtWordsFormat.Text = txtWordsFormat.Text + "Adjective";
                        break;
                    case 'D':
                        txtWordsFormat.Text = txtWordsFormat.Text + "Adverb";
                        break;
                    case 'N':
                        txtWordsFormat.Text = txtWordsFormat.Text + "Noun";
                        break;
                    case 'V':
                        txtWordsFormat.Text = txtWordsFormat.Text + "Verb";
                        break;
                }
            }
        }

        private void btnAdjective_Click(object sender, EventArgs e)
        {
            WordsFormat.Add('A');
            UpdateWordsFormat();
        }

        private void btnAdverb_Click(object sender, EventArgs e)
        {
            WordsFormat.Add('D');
            UpdateWordsFormat();
        }

        private void btnNoun_Click(object sender, EventArgs e)
        {
            WordsFormat.Add('N');
            UpdateWordsFormat();
        }

        private void btnVerb_Click(object sender, EventArgs e)
        {
            WordsFormat.Add('V');
            UpdateWordsFormat();
        }

        private void btnWordsClear_Click(object sender, EventArgs e)
        {
            WordsFormat.Clear();
            UpdateWordsFormat();
        }

        private void btnGenerateWords_Click(object sender, EventArgs e)
        {
            // Prevent exceptions when holding enter for new passwords.
            if (!bkgWordsGen.IsBusy)
            {
                // Generate Passwords without blocking UI.
                bkgWordsGen.RunWorkerAsync();
                tbgGenerators.Focus();
            }
        }

        // CVC
        private void BkgCVCGen_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            // Lock UI
            Action BlockUI = () => grpCVCSettings.Enabled = false;
            grpWordsSettings.Invoke(BlockUI);

            // Generate Passwords based on the settings defined.
            CVCGenerator Generator = new CVCGenerator();
            List<string> Passwords = new List<string>();
            int i = 0;
            while (i < 10)
            {
                string Password = Generator.Next((int)numCVCCount.Value);
                Passwords.Add(Password);
                i++;
            }
            // Update UI
            BeginInvoke((MethodInvoker)delegate
            {
                int j = 0;
                foreach (TextBox pwBox in tabCVC.Controls.OfType<TextBox>())
                {
                    pwBox.Text = Passwords[j];
                    pwBox.Select(0, 0);
                    j++;
                }
            });

            // Unblock the UI Controls.
            Action UnblockUI = () => grpCVCSettings.Enabled = true;
            grpCVCSettings.Invoke(UnblockUI);
        }

        private void BkgCVCGen_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            tbgGenerators.SelectedTab = tabCVC;
            txtCVC01.Focus();
        }

        

        private void btnCVCGenerate_Click(object sender, EventArgs e)
        {
            // Prevent exceptions when holding enter for new passwords.
            if (!bkgCVCGen.IsBusy)
            {
                // Generate Passwords without blocking UI.
                bkgCVCGen.RunWorkerAsync();
                tbgGenerators.Focus();
            }
        }
    }
}
