using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Web.Security;

namespace Derivation
{
    public partial class SettingsForm : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public SettingsForm()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // connection
            GheloBytes.SaveSetting("datasource", "server", "name", txtServer.Text);

            // validation
            GheloBytes.SaveSetting("validation", "enable", "value", chkEnableValidation.Checked.ToString().ToLower());
            if(chkEnableValidation.Checked)
                GheloBytes.SaveSetting("validation", "hash", "value", lblHash.Tag.ToString());

            // printing
            GheloBytes.SaveSetting("printing", "approved", "name", txtApprovedBy.Text);
            GheloBytes.SaveSetting("printing", "approved", "position", txtApprovedPos.Text);
            GheloBytes.SaveSetting("printing", "noted", "name", txtNotedBy.Text);
            GheloBytes.SaveSetting("printing", "noted", "position", txtNotedPos.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnkTest_LinkClicked(object sender, EventArgs e)
        {
            MessageBox.Show("test");
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            // connection
            txtServer.Text = GheloBytes.GetSetting("datasource", "server", "name");

            // validation
            chkEnableValidation.Checked = (GheloBytes.GetSetting("validation", "enable", "value") == "true");
            lblHash.Tag = GheloBytes.GetSetting("validation", "hash", "value");
            lblHash.Text = String.Format(@"Hash: {0}", lblHash.Tag);
            lblHash.Visible = chkEnableValidation.Checked;
            lnkChangeCode.Visible = chkEnableValidation.Checked;


            // printing
            txtApprovedBy.Text = GheloBytes.GetSetting("printing", "approved", "name");
            txtApprovedPos.Text = GheloBytes.GetSetting("printing", "approved", "position");
            txtNotedBy.Text = GheloBytes.GetSetting("printing", "noted", "name");
            txtNotedPos.Text = GheloBytes.GetSetting("printing", "noted", "position");
        }

        private void chkEnableValidation_CheckedChanged(object sender, EventArgs e)
        {
            lblHash.Visible = chkEnableValidation.Checked;
            lnkChangeCode.Visible = chkEnableValidation.Checked;
        }

        // get current code
        private void lnkCurrentOk_LinkClicked(object sender, EventArgs e)
        {
            string currentHash = lblHash.Tag.ToString();
            if (FormsAuthentication.HashPasswordForStoringInConfigFile(GheloBytes.Salt + txtCurrentCode.Text, "SHA1") == currentHash)
            {
                pnlValidationCurrent.Hide();
                pnlValidationNew.Show();
            }
            else
            {
                MessageBox.Show("Invalid authorization code!");
            }
            
        }

        private void lnkCurrentCancel_LinkClicked(object sender, EventArgs e)
        {
            pnlValidationCurrent.Hide();
            lnkChangeCode.Show();
            lblHash.Show();
        }



        // set new code
        private void lnkNewOk_LinkClicked(object sender, EventArgs e)
        {
            string newHash = FormsAuthentication.HashPasswordForStoringInConfigFile(GheloBytes.Salt + txtNewCode.Text, "SHA1");
            lblHash.Tag = newHash;
            lblHash.Text = String.Format(@"Hash: {0}", lblHash.Tag);
            pnlValidationNew.Hide();
            lnkChangeCode.Show();
            lblHash.Show();
        }

        private void lnkNewCancel_LinkClicked(object sender, EventArgs e)
        {
            pnlValidationNew.Hide();
            lnkChangeCode.Show();
            lblHash.Show();
        }




        private void lnkChangeCode_LinkClicked(object sender, EventArgs e)
        {
            pnlValidationCurrent.Show();
            lnkChangeCode.Hide();
            lblHash.Hide();
        }

      


    }
}