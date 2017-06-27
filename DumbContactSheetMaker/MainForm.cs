using System;
using System.Windows.Forms;

namespace DumbContactSheetMaker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            Settings settings = GetSettings();
            // check
            if (txtFolder.Text == ""
                || settings.sheetWidth == 0
                || settings.thumbHeight == 0
                || (settings.cover && settings.coverPath == "")
                || (settings.title && settings.titleCustom && settings.titleText == "")
                )
            {
                MessageBox.Show("Settings incomplete", "Settings incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DCSM dcsm = new DCSM(settings);
                dcsm.StatusChanged += Dcsm_StatusChanged;
                if (chkRecursive.Checked)
                {
                    dcsm.createSheetsRecursive(txtFolder.Text);
                }
                else
                {
                    dcsm.createSheet(txtFolder.Text);
                }
            }
        }

        private void Dcsm_StatusChanged(object sender, DCSM.StatusEvent e)
        {
            UpdateStatus(e.step, e.stepMax, DCSM.StatusEvent.statusPrefix, e.status);
        }

        private void UpdateStatus(int step, int stepMax, string statusPrefix, string status)
        {
            if (prgProgress.InvokeRequired)
            {
                BeginInvoke((Action)(() =>
                {
                    UpdateStatus(step, stepMax, statusPrefix, status);
                }));
            }
            else
            {
                prgProgress.Value = step;
                prgProgress.Maximum = stepMax;
                txtProgress.Text = statusPrefix + status;
                this.Enabled = status == "done";
            }
        }

        private Settings GetSettings()
        {
            Settings settings = new Settings();

            // size
            settings.sheetWidth = (int)numSheetWidth.Value;
            settings.thumbHeight = (int)numThumbHeight.Value;
            settings.useMaxNumThunbs = chkMaxNumThumbs.Checked;
            settings.maxNumThumbs = (int)numMaxNumThumbs.Value;
            settings.largeFirst = chkLargeFirst.Checked;

            // cover image
            settings.cover = chkCover.Checked;
            settings.coverFirst = chkCoverFirst.Checked;
            settings.coverPath = txtCoverPath.Text;

            // title
            settings.title = chkTitle.Checked;
            settings.titleCustom = rdoTitleCustom.Checked;
            settings.titleText = txtTitle.Text;
            settings.titleBgColor = pnlTitleBgColor.BackColor;
            settings.titleFont = dlgTitleFont.Font;
            settings.titleFontColor = dlgTitleFont.Color;

            return settings;
        }




        private void btnCoverPathBrowse_Click(object sender, EventArgs e)
        {
            dlgCoverPathBrowse.ShowDialog();
            txtCoverPath.Text = dlgCoverPathBrowse.FileName;
        }

        private void chkCover_CheckedChanged(object sender, EventArgs e)
        {
            chkCoverFirst.Enabled = chkCover.Checked;
            txtCoverPath.Enabled = chkCover.Checked;
            btnCoverPathBrowse.Enabled = chkCover.Checked;
        }

        private void pnlTitleBgColor_Click(object sender, EventArgs e)
        {
            dlgTitleColor.ShowDialog();
            pnlTitleBgColor.BackColor = dlgTitleColor.Color;
        }

        private void pnlTitleFontColor_Click(object sender, EventArgs e)
        {
            dlgTitleColor.ShowDialog();
        }

        private void rdoTitleCustom_CheckedChanged(object sender, EventArgs e)
        {
            txtTitle.Enabled = rdoTitleCustom.Checked;
        }

        private void chkTitle_CheckedChanged(object sender, EventArgs e)
        {
            rdoTitleFolder.Enabled = chkTitle.Checked;
            rdoTitleCustom.Enabled = chkTitle.Checked;
            txtTitle.Enabled = chkTitle.Checked && rdoTitleCustom.Checked;
            pnlTitleBgColor.Enabled = chkTitle.Checked;
            btnTitleFont.Enabled = chkTitle.Checked;
        }

        private void btnTitleFont_Click(object sender, EventArgs e)
        {
            dlgTitleFont.ShowColor = true;
            dlgTitleFont.ShowDialog();
        }

        private void btnFolderBrowse_Click(object sender, EventArgs e)
        {
            dlgFolderBrowse.ShowDialog();
            txtFolder.Text = dlgFolderBrowse.SelectedPath;
        }

        private void chkMaxNumThumbs_CheckedChanged(object sender, EventArgs e)
        {
            numMaxNumThumbs.Enabled = chkMaxNumThumbs.Checked;
        }
    }
}
