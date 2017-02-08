using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Independentsoft.Office.Spreadsheet;

namespace BigBrother
{
    public partial class frmMainFrame : Form
    {
        public frmMainFrame()
        {
            InitializeComponent();
        }

        private void frmMainFrame_Load(object sender, EventArgs e)
        {
            cboListPrograms.Items.AddRange(GlobalMacro.MacroData.m_listPrograms);

            picVI.BackgroundImage = Image.FromFile(GlobalMacro.MacroData.m_languageFlags[0]);
            picEN.BackgroundImage = Image.FromFile(GlobalMacro.MacroData.m_languageFlags[1]);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboListPrograms.SelectedItem.ToString().ToLower().Equals("mass rename"))
                {
                    MassRename.frmRename frmRename = new MassRename.frmRename();
                    bool opening = false;
                    for (int i = 0; i < Application.OpenForms.Count && !opening; i++)
                    {
                        if (frmRename == Application.OpenForms[i])
                        {
                            opening = true;
                        }
                    }
                    if (!opening)
                        frmRename.Show();
                    else
                        frmRename.BringToFront();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: {0}",ex.Message.ToString());
                txtError.ForeColor = Color.Red;
                txtError.Text = "You haven't choosen any selections";
            }
        }

        private void picVI_Click(object sender, EventArgs e)
        {
            Worksheet wrsh = new ContentLocalizer.Localizer().GetLocalizedFile();
            for (int j = 0; j < this.Controls[pnlLeftWindow.Name].Controls.Count; j++)
            {
                for (int i = 2; i <= wrsh.Rows.Count; i++)
                {
                    string localName = wrsh["A", i].Value.Replace("_", "").ToLower();
                    if (this.Controls[pnlLeftWindow.Name].Controls[j].Name.ToLower() == localName)
                        this.Controls[pnlLeftWindow.Name].Controls[j].Text = wrsh["B", i].Value;
                }
            }
        }

        private void picEN_Click(object sender, EventArgs e)
        {
            Worksheet wrsh = new ContentLocalizer.Localizer().GetLocalizedFile();
            for (int j = 0; j < this.Controls[pnlLeftWindow.Name].Controls.Count; j++)
            {
                for (int i = 2; i <= wrsh.Rows.Count; i++)
                {
                    string localName = wrsh["A", i].Value.Replace("_", "").ToLower();
                    if (this.Controls[pnlLeftWindow.Name].Controls[j].Name.ToLower() == localName)
                        this.Controls[pnlLeftWindow.Name].Controls[j].Text = wrsh["C", i].Value;
                }
            }
        }
    }
}
