using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Microsoft.Reporting.WinForms;

namespace Derivation
{
    public partial class PrintForm : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        DataTable _dt;
        public PrintForm(DataTable dt)
        {
            InitializeComponent();
            _dt = dt;
        }

        private void PrintForm_Load(object sender, EventArgs e)
        {
            
            _dt.Rows[0]["pos_approved"] = GheloBytes.GetSetting("printing", "approved", "position");
            _dt.Rows[0]["pos_noted"] = GheloBytes.GetSetting("printing", "noted", "position");
            _dt.Rows[0]["name_approved"] = GheloBytes.GetSetting("printing", "approved", "name");
            _dt.Rows[0]["name_noted"] = GheloBytes.GetSetting("printing", "noted", "name");


            txtProjectNo.DataBindings.Add("Text", this._dt, "project_no");
            txtMunicipality.DataBindings.Add("Text", this._dt, "municipality");
            txtProvince.DataBindings.Add("Text", this._dt, "province");
            txtRegion.DataBindings.Add("Text", this._dt, "region");

            txtIsland.DataBindings.Add("Text", this._dt, "island");
            txtUrbanCode.DataBindings.Add("Text", this._dt, "urban_code");
            txtDateSurveyed.DataBindings.Add("Text", this._dt, "date_surveyed", true, DataSourceUpdateMode.OnPropertyChanged, null, "MM/dd/yyyy");
            txtDateApproved.DataBindings.Add("Text", this._dt, "date_approved", true, DataSourceUpdateMode.OnPropertyChanged, null, "MM/dd/yyyy");
            txtDateRecoveredObserved.DataBindings.Add("Text", this._dt, "date_rec_obs", true, DataSourceUpdateMode.OnPropertyChanged, null, "MM/dd/yyyy");
            txtApprovedBy.DataBindings.Add("Text", this._dt, "name_approved");
            txtApprovedPos.DataBindings.Add("Text", this._dt, "pos_approved");

            txtNotedBy.DataBindings.Add("Text", this._dt, "name_noted");
            txtNotedPos.DataBindings.Add("Text", this._dt, "pos_noted");

            txtRemarks.DataBindings.Add("Text", this._dt, "remarks");

            rptViewer.SetDisplayMode(DisplayMode.Normal);
            


            rptViewer.LocalReport.DataSources.Add(new ReportDataSource("ReportSource_Data",this._dt));
            rptViewer.RefreshReport();

            rptViewer.ZoomMode = ZoomMode.PageWidth;

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            rptViewer.RefreshReport();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            rptViewer.PrintDialog();
        }

        private void btnClose_LinkClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrintForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //SaveSetting(string section, string setting, string attribute, string value)
            //GheloBytes.SaveSetting("printing", "approved", "position", txtApprovedPos.Text);
            //GheloBytes.SaveSetting("printing", "noted", "position", txtNotedPos.Text);
        }

   

    }
}