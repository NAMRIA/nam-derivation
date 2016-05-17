namespace Derivation
{
    partial class PrintForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pnlFill = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lblProjectNo = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtRegion = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtProjectNo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblRegion = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblCity = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtProvince = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtMunicipality = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblProvince = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.rptViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlRight = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.hdrParameters = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btnClose = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.btnPrint = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtRemarks = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblRemarks = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtNotedPos = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblNotedPos = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtNotedBy = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblNotedBy = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtApprovedPos = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblApprovedPos = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtApprovedBy = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblApprovedBy = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnRefresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtDateApproved = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblDateApproved = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtDateRecoveredObserved = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblDateRecoveredObserved = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtDateSurveyed = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblDateSurveyed = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtUrbanCode = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblUrbanCode = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtIsland = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblIsland = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFill)).BeginInit();
            this.pnlFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.pnlFill);
            this.kryptonPanel.Controls.Add(this.pnlRight);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Padding = new System.Windows.Forms.Padding(5);
            this.kryptonPanel.Size = new System.Drawing.Size(840, 720);
            this.kryptonPanel.TabIndex = 0;
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.rptViewer);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(5, 5);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Padding = new System.Windows.Forms.Padding(10);
            this.pnlFill.Size = new System.Drawing.Size(576, 710);
            this.pnlFill.TabIndex = 43;
            // 
            // lblProjectNo
            // 
            this.lblProjectNo.Location = new System.Drawing.Point(11, 41);
            this.lblProjectNo.Name = "lblProjectNo";
            this.lblProjectNo.Size = new System.Drawing.Size(69, 20);
            this.lblProjectNo.TabIndex = 18;
            this.lblProjectNo.Values.Text = "Project no.";
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(105, 128);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(142, 24);
            this.txtRegion.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtRegion.StateCommon.Border.Rounding = 5;
            this.txtRegion.TabIndex = 3;
            // 
            // txtProjectNo
            // 
            this.txtProjectNo.Location = new System.Drawing.Point(105, 38);
            this.txtProjectNo.Name = "txtProjectNo";
            this.txtProjectNo.Size = new System.Drawing.Size(142, 24);
            this.txtProjectNo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtProjectNo.StateCommon.Border.Rounding = 5;
            this.txtProjectNo.TabIndex = 0;
            // 
            // lblRegion
            // 
            this.lblRegion.Location = new System.Drawing.Point(11, 131);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(49, 20);
            this.lblRegion.TabIndex = 24;
            this.lblRegion.Values.Text = "Region";
            // 
            // lblCity
            // 
            this.lblCity.Location = new System.Drawing.Point(11, 71);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(77, 20);
            this.lblCity.TabIndex = 20;
            this.lblCity.Values.Text = "Municipality";
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(105, 98);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(142, 24);
            this.txtProvince.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtProvince.StateCommon.Border.Rounding = 5;
            this.txtProvince.TabIndex = 2;
            // 
            // txtMunicipality
            // 
            this.txtMunicipality.Location = new System.Drawing.Point(105, 68);
            this.txtMunicipality.Name = "txtMunicipality";
            this.txtMunicipality.Size = new System.Drawing.Size(142, 24);
            this.txtMunicipality.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMunicipality.StateCommon.Border.Rounding = 5;
            this.txtMunicipality.TabIndex = 1;
            // 
            // lblProvince
            // 
            this.lblProvince.Location = new System.Drawing.Point(11, 101);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(57, 20);
            this.lblProvince.TabIndex = 22;
            this.lblProvince.Values.Text = "Province";
            // 
            // rptViewer
            // 
            this.rptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptViewer.LocalReport.ReportEmbeddedResource = "Derivation.Resources.PrintMap.rdlc";
            this.rptViewer.Location = new System.Drawing.Point(10, 10);
            this.rptViewer.Name = "rptViewer";
            this.rptViewer.ShowBackButton = false;
            this.rptViewer.ShowContextMenu = false;
            this.rptViewer.ShowCredentialPrompts = false;
            this.rptViewer.ShowDocumentMapButton = false;
            this.rptViewer.ShowFindControls = false;
            this.rptViewer.ShowPageNavigationControls = false;
            this.rptViewer.ShowParameterPrompts = false;
            this.rptViewer.ShowPrintButton = false;
            this.rptViewer.ShowRefreshButton = false;
            this.rptViewer.ShowStopButton = false;
            this.rptViewer.Size = new System.Drawing.Size(556, 690);
            this.rptViewer.TabIndex = 0;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.lblProjectNo);
            this.pnlRight.Controls.Add(this.txtRegion);
            this.pnlRight.Controls.Add(this.hdrParameters);
            this.pnlRight.Controls.Add(this.txtProjectNo);
            this.pnlRight.Controls.Add(this.btnClose);
            this.pnlRight.Controls.Add(this.lblRegion);
            this.pnlRight.Controls.Add(this.btnPrint);
            this.pnlRight.Controls.Add(this.lblCity);
            this.pnlRight.Controls.Add(this.txtRemarks);
            this.pnlRight.Controls.Add(this.txtProvince);
            this.pnlRight.Controls.Add(this.lblRemarks);
            this.pnlRight.Controls.Add(this.txtMunicipality);
            this.pnlRight.Controls.Add(this.txtNotedPos);
            this.pnlRight.Controls.Add(this.lblProvince);
            this.pnlRight.Controls.Add(this.lblNotedPos);
            this.pnlRight.Controls.Add(this.txtNotedBy);
            this.pnlRight.Controls.Add(this.lblNotedBy);
            this.pnlRight.Controls.Add(this.txtApprovedPos);
            this.pnlRight.Controls.Add(this.lblApprovedPos);
            this.pnlRight.Controls.Add(this.txtApprovedBy);
            this.pnlRight.Controls.Add(this.lblApprovedBy);
            this.pnlRight.Controls.Add(this.btnRefresh);
            this.pnlRight.Controls.Add(this.txtDateApproved);
            this.pnlRight.Controls.Add(this.lblDateApproved);
            this.pnlRight.Controls.Add(this.txtDateRecoveredObserved);
            this.pnlRight.Controls.Add(this.lblDateRecoveredObserved);
            this.pnlRight.Controls.Add(this.txtDateSurveyed);
            this.pnlRight.Controls.Add(this.lblDateSurveyed);
            this.pnlRight.Controls.Add(this.txtUrbanCode);
            this.pnlRight.Controls.Add(this.lblUrbanCode);
            this.pnlRight.Controls.Add(this.txtIsland);
            this.pnlRight.Controls.Add(this.lblIsland);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(581, 5);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(254, 710);
            this.pnlRight.TabIndex = 1;
            // 
            // hdrParameters
            // 
            this.hdrParameters.Dock = System.Windows.Forms.DockStyle.Top;
            this.hdrParameters.Location = new System.Drawing.Point(0, 0);
            this.hdrParameters.Name = "hdrParameters";
            this.hdrParameters.Size = new System.Drawing.Size(254, 31);
            this.hdrParameters.TabIndex = 50;
            this.hdrParameters.Values.Description = "";
            this.hdrParameters.Values.Heading = "Report parameters";
            this.hdrParameters.Values.Image = null;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(122, 615);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 20);
            this.btnClose.TabIndex = 16;
            this.btnClose.Values.Text = "Close";
            this.btnClose.LinkClicked += new System.EventHandler(this.btnClose_LinkClicked);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(144, 563);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(103, 36);
            this.btnPrint.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPrint.StateCommon.Border.Rounding = 5;
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Values.Image = global::Derivation.Properties.Resources.print;
            this.btnPrint.Values.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(105, 462);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(142, 77);
            this.txtRemarks.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtRemarks.StateCommon.Border.Rounding = 5;
            this.txtRemarks.TabIndex = 13;
            // 
            // lblRemarks
            // 
            this.lblRemarks.Location = new System.Drawing.Point(11, 462);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(57, 20);
            this.lblRemarks.TabIndex = 46;
            this.lblRemarks.Values.Text = "Remarks";
            // 
            // txtNotedPos
            // 
            this.txtNotedPos.Location = new System.Drawing.Point(105, 421);
            this.txtNotedPos.Name = "txtNotedPos";
            this.txtNotedPos.Size = new System.Drawing.Size(142, 24);
            this.txtNotedPos.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNotedPos.StateCommon.Border.Rounding = 5;
            this.txtNotedPos.TabIndex = 12;
            // 
            // lblNotedPos
            // 
            this.lblNotedPos.Location = new System.Drawing.Point(11, 424);
            this.lblNotedPos.Name = "lblNotedPos";
            this.lblNotedPos.Size = new System.Drawing.Size(54, 20);
            this.lblNotedPos.TabIndex = 44;
            this.lblNotedPos.Values.Text = "Position";
            // 
            // txtNotedBy
            // 
            this.txtNotedBy.Location = new System.Drawing.Point(105, 391);
            this.txtNotedBy.Name = "txtNotedBy";
            this.txtNotedBy.Size = new System.Drawing.Size(142, 24);
            this.txtNotedBy.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNotedBy.StateCommon.Border.Rounding = 5;
            this.txtNotedBy.TabIndex = 11;
            // 
            // lblNotedBy
            // 
            this.lblNotedBy.Location = new System.Drawing.Point(11, 394);
            this.lblNotedBy.Name = "lblNotedBy";
            this.lblNotedBy.Size = new System.Drawing.Size(62, 20);
            this.lblNotedBy.TabIndex = 42;
            this.lblNotedBy.Values.Text = "Noted by";
            // 
            // txtApprovedPos
            // 
            this.txtApprovedPos.Location = new System.Drawing.Point(105, 350);
            this.txtApprovedPos.Name = "txtApprovedPos";
            this.txtApprovedPos.Size = new System.Drawing.Size(142, 24);
            this.txtApprovedPos.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtApprovedPos.StateCommon.Border.Rounding = 5;
            this.txtApprovedPos.TabIndex = 10;
            // 
            // lblApprovedPos
            // 
            this.lblApprovedPos.Location = new System.Drawing.Point(11, 353);
            this.lblApprovedPos.Name = "lblApprovedPos";
            this.lblApprovedPos.Size = new System.Drawing.Size(54, 20);
            this.lblApprovedPos.TabIndex = 40;
            this.lblApprovedPos.Values.Text = "Position";
            // 
            // txtApprovedBy
            // 
            this.txtApprovedBy.Location = new System.Drawing.Point(105, 320);
            this.txtApprovedBy.Name = "txtApprovedBy";
            this.txtApprovedBy.Size = new System.Drawing.Size(142, 24);
            this.txtApprovedBy.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtApprovedBy.StateCommon.Border.Rounding = 5;
            this.txtApprovedBy.TabIndex = 9;
            // 
            // lblApprovedBy
            // 
            this.lblApprovedBy.Location = new System.Drawing.Point(11, 323);
            this.lblApprovedBy.Name = "lblApprovedBy";
            this.lblApprovedBy.Size = new System.Drawing.Size(81, 20);
            this.lblApprovedBy.TabIndex = 38;
            this.lblApprovedBy.Values.Text = "Approved by";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(35, 563);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(103, 36);
            this.btnRefresh.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRefresh.StateCommon.Border.Rounding = 5;
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Values.Image = global::Derivation.Properties.Resources.reload;
            this.btnRefresh.Values.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtDateApproved
            // 
            this.txtDateApproved.Location = new System.Drawing.Point(105, 278);
            this.txtDateApproved.Name = "txtDateApproved";
            this.txtDateApproved.Size = new System.Drawing.Size(142, 24);
            this.txtDateApproved.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDateApproved.StateCommon.Border.Rounding = 5;
            this.txtDateApproved.TabIndex = 8;
            // 
            // lblDateApproved
            // 
            this.lblDateApproved.Location = new System.Drawing.Point(11, 281);
            this.lblDateApproved.Name = "lblDateApproved";
            this.lblDateApproved.Size = new System.Drawing.Size(92, 20);
            this.lblDateApproved.TabIndex = 35;
            this.lblDateApproved.Values.Text = "Date approved";
            // 
            // txtDateRecoveredObserved
            // 
            this.txtDateRecoveredObserved.Location = new System.Drawing.Point(105, 247);
            this.txtDateRecoveredObserved.Name = "txtDateRecoveredObserved";
            this.txtDateRecoveredObserved.Size = new System.Drawing.Size(142, 24);
            this.txtDateRecoveredObserved.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDateRecoveredObserved.StateCommon.Border.Rounding = 5;
            this.txtDateRecoveredObserved.TabIndex = 7;
            // 
            // lblDateRecoveredObserved
            // 
            this.lblDateRecoveredObserved.Location = new System.Drawing.Point(11, 251);
            this.lblDateRecoveredObserved.Name = "lblDateRecoveredObserved";
            this.lblDateRecoveredObserved.Size = new System.Drawing.Size(94, 20);
            this.lblDateRecoveredObserved.TabIndex = 33;
            this.lblDateRecoveredObserved.Values.Text = "Date recovered";
            // 
            // txtDateSurveyed
            // 
            this.txtDateSurveyed.Location = new System.Drawing.Point(105, 218);
            this.txtDateSurveyed.Name = "txtDateSurveyed";
            this.txtDateSurveyed.Size = new System.Drawing.Size(142, 24);
            this.txtDateSurveyed.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDateSurveyed.StateCommon.Border.Rounding = 5;
            this.txtDateSurveyed.TabIndex = 6;
            // 
            // lblDateSurveyed
            // 
            this.lblDateSurveyed.Location = new System.Drawing.Point(11, 221);
            this.lblDateSurveyed.Name = "lblDateSurveyed";
            this.lblDateSurveyed.Size = new System.Drawing.Size(88, 20);
            this.lblDateSurveyed.TabIndex = 31;
            this.lblDateSurveyed.Values.Text = "Date surveyed";
            // 
            // txtUrbanCode
            // 
            this.txtUrbanCode.Location = new System.Drawing.Point(105, 188);
            this.txtUrbanCode.Name = "txtUrbanCode";
            this.txtUrbanCode.Size = new System.Drawing.Size(142, 24);
            this.txtUrbanCode.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUrbanCode.StateCommon.Border.Rounding = 5;
            this.txtUrbanCode.TabIndex = 5;
            // 
            // lblUrbanCode
            // 
            this.lblUrbanCode.Location = new System.Drawing.Point(11, 191);
            this.lblUrbanCode.Name = "lblUrbanCode";
            this.lblUrbanCode.Size = new System.Drawing.Size(74, 20);
            this.lblUrbanCode.TabIndex = 28;
            this.lblUrbanCode.Values.Text = "Urban code";
            // 
            // txtIsland
            // 
            this.txtIsland.Location = new System.Drawing.Point(105, 158);
            this.txtIsland.Name = "txtIsland";
            this.txtIsland.Size = new System.Drawing.Size(142, 24);
            this.txtIsland.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtIsland.StateCommon.Border.Rounding = 5;
            this.txtIsland.TabIndex = 4;
            // 
            // lblIsland
            // 
            this.lblIsland.Location = new System.Drawing.Point(11, 161);
            this.lblIsland.Name = "lblIsland";
            this.lblIsland.Size = new System.Drawing.Size(43, 20);
            this.lblIsland.TabIndex = 26;
            this.lblIsland.Values.Text = "Island";
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 720);
            this.Controls.Add(this.kryptonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PrintForm";
            this.Text = "PrintForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PrintForm_FormClosed);
            this.Load += new System.EventHandler(this.PrintForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlFill)).EndInit();
            this.pnlFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private Microsoft.Reporting.WinForms.ReportViewer rptViewer;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlRight;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtProjectNo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblProjectNo;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUrbanCode;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblUrbanCode;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtIsland;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblIsland;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtRegion;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblRegion;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtProvince;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblProvince;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtMunicipality;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCity;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDateSurveyed;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblDateSurveyed;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDateApproved;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblDateApproved;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDateRecoveredObserved;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblDateRecoveredObserved;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRefresh;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtApprovedBy;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblApprovedBy;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtApprovedPos;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblApprovedPos;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNotedPos;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblNotedPos;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNotedBy;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblNotedBy;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtRemarks;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblRemarks;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPrint;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel btnClose;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlFill;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader hdrParameters;
    }
}

