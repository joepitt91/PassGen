using JoePitt.PassGen.Generators;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace JoePitt.PassGen
{
    public partial class frmPassGen : Form
    {
        private List<char> wordsFormat;

        //General
        public frmPassGen()
        {
            //General
            InitializeComponent();
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
            txtAboutGeneral.Select(0, 0);
            // Restore Settings. Revert to defaults if there are any errors.
            //Crypto
            try
            {
                chkCryptoLower.Checked = Properties.Crypto.Default.Lower;
                chkCryptoUpper.Checked = Properties.Crypto.Default.Upper;
                chkCryptoNumber.Checked = Properties.Crypto.Default.Number;
                chkCryptoSpecial.Checked = Properties.Crypto.Default.Special;
                chkCryptoSpace.Checked = Properties.Crypto.Default.Space;
                chkCryptoIncludeAll.Checked = Properties.Crypto.Default.IncludeAll;
                numCryptoLength.Value = Properties.Crypto.Default.Length;
            }
            catch
            {
                Properties.Crypto.Default.Reset();
                Properties.Crypto.Default.Save();
            }

            //Words
            if (!Properties.Words.Default.AdjectiveFile || !Properties.Words.Default.AdverbFile || !Properties.Words.Default.NounFile || !Properties.Words.Default.VerbFile)
            {
                foreach (TextBox pwBox in tabWords.Controls.OfType<TextBox>())
                {
                    pwBox.BackColor = System.Drawing.Color.PaleVioletRed;
                    pwBox.ForeColor = System.Drawing.Color.White;
                }
            }

            try
            {
                string formatString = Properties.Words.Default.Pattern;
                wordsFormat = new List<char>();

                foreach (string Type in formatString.Split(':').ToList())
                {
                    switch (Type)
                    {
                        case "Adjective":
                            wordsFormat.Add('A');
                            txtWordsFormat.Text = txtWordsFormat.Text + Type;
                            break;
                        case "Adverb":
                            wordsFormat.Add('D');
                            txtWordsFormat.Text = txtWordsFormat.Text + Type;
                            break;
                        case "Noun":
                            wordsFormat.Add('N');
                            txtWordsFormat.Text = txtWordsFormat.Text + Type;
                            break;
                        case "Verb":
                            wordsFormat.Add('V');
                            txtWordsFormat.Text = txtWordsFormat.Text + Type;
                            break;
                        default:
                            throw new FormatException("Unknown Word Type: " + Type);
                    }
                }
            }
            catch
            {
                Properties.Words.Default.Reset();
                Properties.Words.Default.Save();
                string formatString = Properties.Words.Default.Pattern;
                wordsFormat = new List<char>();

                foreach (string Type in formatString.Split(':').ToList())
                {
                    switch (Type)
                    {
                        case "Adjective":
                            wordsFormat.Add('A');
                            txtWordsFormat.Text = txtWordsFormat.Text + "Adjective";
                            break;
                        case "Adverb":
                            wordsFormat.Add('D');
                            txtWordsFormat.Text = txtWordsFormat.Text + "Adverb";
                            break;
                        case "Noun":
                            wordsFormat.Add('N');
                            txtWordsFormat.Text = txtWordsFormat.Text + "Noun";
                            break;
                        case "Verb":
                            wordsFormat.Add('V');
                            txtWordsFormat.Text = txtWordsFormat.Text + "Verb";
                            break;
                        default:
                            throw new FormatException("Unknown Word Type: " + Type);
                    }
                }
            }

            //CVC
            try
            {
                numCVCCount.Value = Properties.CVC.Default.Count;
            }
            catch
            {
                Properties.CVC.Default.Reset();
                Properties.CVC.Default.Save();
            }
        }

        private void TbgGenerators_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tbgGenerators.SelectedIndex)
            {
                case 0:
                    AcceptButton = btnCryptoGenerate;
                    CancelButton = btnCryptoGenerate;
                    break;
                case 1:
                    AcceptButton = btnWordsGenerate;
                    CancelButton = btnWordsGenerate;
                    break;
                case 2:
                    AcceptButton = btnCVCGenerate;
                    CancelButton = btnCVCGenerate;
                    break;
                default:
                    AcceptButton = null;
                    CancelButton = null;
                    break;
            }
        }

        // Crypto
        private void bkgCryptoGen_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            // Block the UI Controls.
            Action BlockUI = () => grpCryptoSettings.Enabled = false;
            grpCryptoSettings.Invoke(BlockUI);

            // Save Settings
            Properties.Crypto.Default.Lower = chkCryptoLower.Checked;
            Properties.Crypto.Default.Upper = chkCryptoUpper.Checked;
            Properties.Crypto.Default.Number = chkCryptoNumber.Checked;
            Properties.Crypto.Default.Special = chkCryptoSpecial.Checked;
            Properties.Crypto.Default.Space = chkCryptoSpace.Checked;
            Properties.Crypto.Default.IncludeAll = chkCryptoIncludeAll.Checked;
            Properties.Crypto.Default.Length = (int)numCryptoLength.Value;
            Properties.Crypto.Default.Save();

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
        private void BkgWordsGen_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            // Lock UI
            Action BlockUI = () => grpWordsSettings.Enabled = false;
            grpWordsSettings.Invoke(BlockUI);

            // Save Settings
            string savePattern = "";
            foreach (char component in wordsFormat)
            {
                switch (component)
                {
                    case 'A':
                        savePattern = savePattern + ":Adjective";
                        break;
                    case 'D':
                        savePattern = savePattern + ":Adverb";
                        break;
                    case 'N':
                        savePattern = savePattern + ":Noun";
                        break;
                    case 'V':
                        savePattern = savePattern + ":Verb";
                        break;
                }
            }
            Properties.Words.Default.Pattern = savePattern.Substring(1);
            Properties.Words.Default.Save();

            // Generate Passwords based on the settings defined.
            WordsGenerator Generator = new WordsGenerator();
            List<string> Passwords = new List<string>();
            int i = 0;
            while (i < 10)
            {
                Passwords.Add(Generator.Next(wordsFormat));
                i++;
            }
            Generator.Dispose();
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
            if (!Properties.Words.Default.AdjectiveFile || !Properties.Words.Default.AdverbFile ||
                !Properties.Words.Default.NounFile || !Properties.Words.Default.VerbFile)
            {
                ToolTip Warning = new ToolTip();
                Warning.ToolTipIcon = ToolTipIcon.Warning;
                Warning.ToolTipTitle = "Internet Generated";
                Warning.Show("Warning, these passwords have been generated from the internet.", txtWords01, 0, 0, 15000);
            }
        }

        private void UpdateWordsFormat()
        {
            txtWordsFormat.Text = "";
            foreach (char Type in wordsFormat)
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
            wordsFormat.Add('A');
            UpdateWordsFormat();
        }

        private void btnAdverb_Click(object sender, EventArgs e)
        {
            wordsFormat.Add('D');
            UpdateWordsFormat();
        }

        private void btnNoun_Click(object sender, EventArgs e)
        {
            wordsFormat.Add('N');
            UpdateWordsFormat();
        }

        private void btnVerb_Click(object sender, EventArgs e)
        {
            wordsFormat.Add('V');
            UpdateWordsFormat();
        }

        private void btnWordsClear_Click(object sender, EventArgs e)
        {
            wordsFormat.Clear();
            UpdateWordsFormat();
        }

        private void btnGenerateWords_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtWordsFormat.Text))
            {
                MessageBox.Show("No format string set, add some word types first, e.g. AdverbAdjectiveNoun", "Word Generator - PassGen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

            // Save Settings
            Properties.CVC.Default.Count = (int)numCVCCount.Value;
            Properties.CVC.Default.Save();

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

        // About Tab
        private void lnkProjectPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.joepitt.co.uk/Project/PassGen/");
        }

        private void lnkUserGuideOnline_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://passgen.help.joepitt.co.uk/");
        }

        private void lnkUserGuideOffline_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("Resources\\PassGen-UserGuide.pdf");
        }

        private void lnkSourceCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/joepitt91/PassGen");
        }

        private void lnkDonate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=donations@joepitt.co.uk&lc=GB&item_name=PassGen%20Donation%20%28Joe%20Pitt%29&currency_code=GBP&bn=PP-DonationsBF");
        }

        private void btnResetAll_Click(object sender, EventArgs e)
        {
            // Crypto
            Properties.Crypto.Default.Reset();
            Properties.Crypto.Default.Save();

            // Words
            Properties.Words.Default.Reset();
            Properties.Words.Default.Save();

            // CVC
            Properties.CVC.Default.Reset();
            Properties.CVC.Default.Save();

            Application.Restart();
        }

        private void btnResetCrypto_Click(object sender, EventArgs e)
        {
            Properties.Crypto.Default.Reset();
            Properties.Crypto.Default.Save();
            Application.Restart();
        }

        private void btnResetWords_Click(object sender, EventArgs e)
        {
            Properties.Words.Default.Reset();
            Properties.Words.Default.Save();
            Application.Restart();
        }

        private void btnResetCVC_Click(object sender, EventArgs e)
        {
            Properties.CVC.Default.Reset();
            Properties.CVC.Default.Save();
            Application.Restart();
        }
    }
}
