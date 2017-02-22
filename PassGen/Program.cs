using System;
using System.IO;
using System.Windows.Forms;

namespace JoePitt.PassGen
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Words Generator Prep
            string wordsPath = Properties.Words.Default.DictionaryPath;
            if (string.IsNullOrEmpty(wordsPath))
            {
                wordsPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\JoePitt\\PassGen\\";
                Properties.Words.Default.DictionaryPath = wordsPath;
                Properties.Words.Default.Save();
            }
            if (!Directory.Exists(wordsPath))
            {
                Directory.CreateDirectory(wordsPath);
            }

            bool wordsAdjectiveFile = File.Exists(wordsPath + "Adjectives.txt");
            Properties.Words.Default.AdjectiveFile = wordsAdjectiveFile;
            bool wordsAdverbFile = File.Exists(wordsPath + "Adverbs.txt");
            Properties.Words.Default.AdverbFile = wordsAdverbFile;
            bool wordsNounFile = File.Exists(wordsPath + "Nouns.txt");
            Properties.Words.Default.NounFile = wordsNounFile;
            bool wordsVerbFile = File.Exists(wordsPath + "Verbs.txt");
            Properties.Words.Default.VerbFile = wordsVerbFile;
            Properties.Words.Default.Save();

            // If any files are missing and the warning is not suppress
            if ((!wordsAdjectiveFile || !wordsAdverbFile || !wordsNounFile || !wordsVerbFile) && !Properties.Words.Default.SuppressMissingDictionaryWarning)
            {
                string message = "Warning! the following word list(s) are missing for the Words Generator:" + Environment.NewLine;
                if (!wordsAdjectiveFile) message = message + Environment.NewLine + "Adjectives:" + Environment.NewLine + "    " + wordsPath + "Adjectives.txt";
                if (!wordsAdverbFile) message = message + Environment.NewLine + "Adverbs:" + Environment.NewLine + "    " + wordsPath + "Adverbs.txt";
                if (!wordsNounFile) message = message + Environment.NewLine + "Nouns:" + Environment.NewLine + "    " + wordsPath + "Nouns.txt";
                if (!wordsVerbFile) message = message + Environment.NewLine + "Verbs:" + Environment.NewLine + "    " + wordsPath + "Verbs.txt";
                message = message + Environment.NewLine + Environment.NewLine + 
                    "If you plan to use the Words Generator it is Strongly Recommended that you click Cancel, install Word Lists and relaunch PassGen (See https://passgen.help.joepitt.co.uk/installation/word-lists.html)" + Environment.NewLine + Environment.NewLine +
                    "Do you want to permanently ignore this Security Warning?";
                DialogResult response = MessageBox.Show(message, "Security Warning - PassGen", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (response == DialogResult.Cancel)
                {
                    System.Diagnostics.Process.Start("https://passgen.help.joepitt.co.uk/installation/word-lists.html");
                    Application.Exit();
                    return;
                }
                else if (response == DialogResult.Yes)
                {
                    Properties.Words.Default.SuppressMissingDictionaryWarning = true;
                    Properties.Words.Default.Save();
                }
            }

            Application.Run(new frmPassGen());
        }
    }
}
