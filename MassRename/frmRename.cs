using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassRename
{
    public partial class frmRename : Form
    {
        public frmRename()
        {
            InitializeComponent();
        }

        private void btnLoadFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbdBrowser = new FolderBrowserDialog();
            fbdBrowser.ShowDialog(this);
            if (fbdBrowser.SelectedPath != null)
            {
                txtFolderPath.Text = fbdBrowser.SelectedPath.ToString();
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (txtFolderPath.Text == "")
            {
                txtError.Text = "Folder path is null";
                return;
            }
            if (txtFindString.Text == "")
            {
                txtError.Text = "Condition string is null";
                return;
            }
            if (txtReplaceString.Text == "")
            {
                txtError.Text = "Replace string is null";
                return;
            }
            
            txtLog.Clear();
            DirectoryInfo dInfo = new DirectoryInfo(txtFolderPath.Text);
            FileInfo[] arrInfo = dInfo.GetFiles();

            int countFile = 0;
            foreach (FileInfo fi in arrInfo)
            {
                string dirName = fi.DirectoryName;
                string oldName = fi.Name, newName = fi.Name.ToString().Replace(txtFindString.Text, txtReplaceString.Text);
                if (newName != oldName)
                {
                    File.Move(dirName + @"\\" + oldName, dirName + @"\\" + newName);
                    countFile++;
                    txtLog.AppendText(string.Format("Replaced {0} with {1}\n", oldName, newName));
                }
            }
            txtError.ForeColor = Color.Green;
            txtError.Text = "Rename successfully " + countFile + " file(s).";
            txtError.ForeColor = Color.Green;
        }
    }
}
