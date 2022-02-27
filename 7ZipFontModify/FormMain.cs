using SevenZipFontModify.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SevenZipFontModify
{
    public partial class FormMain : Form
    {
        #region Private Fields

        private readonly Settings settings;

        #endregion

        #region Public Methods

        public FormMain()
        {
            InitializeComponent();
            settings = Settings.Default;

            string backupDirectory = settings.BackupTo;

            if (!string.IsNullOrEmpty(backupDirectory))
            {
                if (Path.IsPathRooted(backupDirectory))
                {
                    textBoxBackupTo.Text = backupDirectory;
                }
                else
                {
                    textBoxBackupTo.Text = Path.Combine(Application.StartupPath, backupDirectory);
                }
            }
        }

        #endregion

        #region Private Methods

        private void DoBackup()
        {
            string destination = textBoxBackupTo.Text;

            if (string.IsNullOrEmpty(destination))
            {
                return;
            }

            destination = Environment.ExpandEnvironmentVariables(destination);

            if (!Directory.Exists(destination))
            {
                Directory.CreateDirectory(destination);
            }

            foreach (string file in GetExpandedFileNames())
            {
                var fileInfo = new FileInfo(file);
                File.Copy(file, Path.Combine(destination, fileInfo.Name));
            }
        }

        private int DoModify()
        {
            int result = 0;
            byte[] before = MainEngine.ToByte(((int)numericUpDownFontSizeFrom.Value).ToString("X2") + settings.Target);
            byte[] after = MainEngine.ToByte(((int)numericUpDownFontSizeTo.Value).ToString("X2") + settings.Target);

            foreach (string fileName in GetExpandedFileNames())
            {
                result += MainEngine.Replace(fileName, before, after);
            }

            return result;
        }

        private IEnumerable<string> GetExpandedFileNames()
        {
            return textBoxFiles.Lines.Select(n => Environment.ExpandEnvironmentVariables(n));
        }

        private void ShowErrorMessage(Exception exception)
        {
            ShowMessage(exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private DialogResult ShowMessage(string text, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return MessageBox.Show(this, text, Text, buttons, icon);
        }

        #endregion

        // Designer's Methods

        private void buttonExec_Click(object sender, EventArgs e)
        {
            bool result;

            try
            {
                DoBackup();
                result = (DoModify() > 0);
            }
            catch (Exception exception)
            {
                ShowErrorMessage(exception);
                return;
            }

            if (result)
            {
                ShowMessage("The files have been modified successfully.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ShowMessage("The files were not modified.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void shown(object sender, EventArgs e)
        {
            buttonExec.Focus();
        }
    }
}
