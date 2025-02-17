namespace Derivation
{
    partial class SettingsForm
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
            this.kryptonHeaderGroup3 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.txtNotedPos = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblNotedPos = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtNotedBy = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblNotedBy = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtApprovedPos = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblApprovedPos = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtApprovedBy = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblApprovedBy = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonHeaderGroup2 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.pnlValidationCurrent = new System.Windows.Forms.Panel();
            this.lnkCurrentCancel = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.lnkCurrentOk = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.txtCurrentCode = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblCurrentCode = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pnlValidationNew = new System.Windows.Forms.Panel();
            this.lnkNewCancel = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.lnkNewOk = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.txtNewCode = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblNewCode = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lnkChangeCode = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.chkEnableValidation = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.lblHash = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.lblServer = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtServer = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lnkTest = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.btnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3.Panel)).BeginInit();
            this.kryptonHeaderGroup3.Panel.SuspendLayout();
            this.kryptonHeaderGroup3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).BeginInit();
            this.kryptonHeaderGroup2.Panel.SuspendLayout();
            this.kryptonHeaderGroup2.SuspendLayout();
            this.pnlValidationCurrent.SuspendLayout();
            this.pnlValidationNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonHeaderGroup3);
            this.kryptonPanel.Controls.Add(this.kryptonHeaderGroup2);
            this.kryptonPanel.Controls.Add(this.kryptonHeaderGroup1);
            this.kryptonPanel.Controls.Add(this.btnClose);
            this.kryptonPanel.Controls.Add(this.btnSave);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(315, 371);
            this.kryptonPanel.TabIndex = 0;
            // 
            // kryptonHeaderGroup3
            // 
            this.kryptonHeaderGroup3.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeaderGroup3.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonStandalone;
            this.kryptonHeaderGroup3.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.kryptonHeaderGroup3.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroup3.Location = new System.Drawing.Point(0, 166);
            this.kryptonHeaderGroup3.Name = "kryptonHeaderGroup3";
            // 
            // kryptonHeaderGroup3.Panel
            // 
            this.kryptonHeaderGroup3.Panel.Controls.Add(this.txtNotedPos);
            this.kryptonHeaderGroup3.Panel.Controls.Add(this.lblNotedPos);
            this.kryptonHeaderGroup3.Panel.Controls.Add(this.txtNotedBy);
            this.kryptonHeaderGroup3.Panel.Controls.Add(this.lblNotedBy);
            this.kryptonHeaderGroup3.Panel.Controls.Add(this.txtApprovedPos);
            this.kryptonHeaderGroup3.Panel.Controls.Add(this.lblApprovedPos);
            this.kryptonHeaderGroup3.Panel.Controls.Add(this.txtApprovedBy);
            this.kryptonHeaderGroup3.Panel.Controls.Add(this.lblApprovedBy);
            this.kryptonHeaderGroup3.Size = new System.Drawing.Size(315, 158);
            this.kryptonHeaderGroup3.TabIndex = 25;
            this.kryptonHeaderGroup3.ValuesPrimary.Heading = "Printing";
            this.kryptonHeaderGroup3.ValuesPrimary.Image = null;
            // 
            // txtNotedPos
            // 
            this.txtNotedPos.Location = new System.Drawing.Point(97, 100);
            this.txtNotedPos.Name = "txtNotedPos";
            this.txtNotedPos.Size = new System.Drawing.Size(181, 24);
            this.txtNotedPos.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNotedPos.StateCommon.Border.Rounding = 5;
            this.txtNotedPos.TabIndex = 48;
            // 
            // lblNotedPos
            // 
            this.lblNotedPos.Location = new System.Drawing.Point(37, 100);
            this.lblNotedPos.Name = "lblNotedPos";
            this.lblNotedPos.Size = new System.Drawing.Size(54, 20);
            this.lblNotedPos.TabIndex = 52;
            this.lblNotedPos.Values.Text = "Position";
            // 
            // txtNotedBy
            // 
            this.txtNotedBy.Location = new System.Drawing.Point(97, 70);
            this.txtNotedBy.Name = "txtNotedBy";
            this.txtNotedBy.Size = new System.Drawing.Size(181, 24);
            this.txtNotedBy.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNotedBy.StateCommon.Border.Rounding = 5;
            this.txtNotedBy.TabIndex = 47;
            // 
            // lblNotedBy
            // 
            this.lblNotedBy.Location = new System.Drawing.Point(29, 74);
            this.lblNotedBy.Name = "lblNotedBy";
            this.lblNotedBy.Size = new System.Drawing.Size(62, 20);
            this.lblNotedBy.TabIndex = 51;
            this.lblNotedBy.Values.Text = "Noted by";
            // 
            // txtApprovedPos
            // 
            this.txtApprovedPos.Location = new System.Drawing.Point(97, 40);
            this.txtApprovedPos.Name = "txtApprovedPos";
            this.txtApprovedPos.Size = new System.Drawing.Size(181, 24);
            this.txtApprovedPos.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtApprovedPos.StateCommon.Border.Rounding = 5;
            this.txtApprovedPos.TabIndex = 46;
            // 
            // lblApprovedPos
            // 
            this.lblApprovedPos.Location = new System.Drawing.Point(37, 39);
            this.lblApprovedPos.Name = "lblApprovedPos";
            this.lblApprovedPos.Size = new System.Drawing.Size(54, 20);
            this.lblApprovedPos.TabIndex = 50;
            this.lblApprovedPos.Values.Text = "Position";
            // 
            // txtApprovedBy
            // 
            this.txtApprovedBy.Location = new System.Drawing.Point(97, 10);
            this.txtApprovedBy.Name = "txtApprovedBy";
            this.txtApprovedBy.Size = new System.Drawing.Size(181, 24);
            this.txtApprovedBy.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtApprovedBy.StateCommon.Border.Rounding = 5;
            this.txtApprovedBy.TabIndex = 45;
            // 
            // lblApprovedBy
            // 
            this.lblApprovedBy.Location = new System.Drawing.Point(10, 13);
            this.lblApprovedBy.Name = "lblApprovedBy";
            this.lblApprovedBy.Size = new System.Drawing.Size(81, 20);
            this.lblApprovedBy.TabIndex = 49;
            this.lblApprovedBy.Values.Text = "Approved by";
            // 
            // kryptonHeaderGroup2
            // 
            this.kryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeaderGroup2.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonStandalone;
            this.kryptonHeaderGroup2.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.kryptonHeaderGroup2.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroup2.Location = new System.Drawing.Point(0, 68);
            this.kryptonHeaderGroup2.Name = "kryptonHeaderGroup2";
            // 
            // kryptonHeaderGroup2.Panel
            // 
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.pnlValidationCurrent);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.pnlValidationNew);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.lnkChangeCode);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.chkEnableValidation);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.lblHash);
            this.kryptonHeaderGroup2.Size = new System.Drawing.Size(315, 98);
            this.kryptonHeaderGroup2.TabIndex = 24;
            this.kryptonHeaderGroup2.ValuesPrimary.Heading = "Validation";
            this.kryptonHeaderGroup2.ValuesPrimary.Image = null;
            // 
            // pnlValidationCurrent
            // 
            this.pnlValidationCurrent.BackColor = System.Drawing.Color.Transparent;
            this.pnlValidationCurrent.Controls.Add(this.lnkCurrentCancel);
            this.pnlValidationCurrent.Controls.Add(this.lnkCurrentOk);
            this.pnlValidationCurrent.Controls.Add(this.txtCurrentCode);
            this.pnlValidationCurrent.Controls.Add(this.lblCurrentCode);
            this.pnlValidationCurrent.Location = new System.Drawing.Point(7, 37);
            this.pnlValidationCurrent.Name = "pnlValidationCurrent";
            this.pnlValidationCurrent.Size = new System.Drawing.Size(307, 28);
            this.pnlValidationCurrent.TabIndex = 28;
            this.pnlValidationCurrent.Visible = false;
            // 
            // lnkCurrentCancel
            // 
            this.lnkCurrentCancel.LinkBehavior = ComponentFactory.Krypton.Toolkit.KryptonLinkBehavior.NeverUnderline;
            this.lnkCurrentCancel.Location = new System.Drawing.Point(255, 3);
            this.lnkCurrentCancel.Name = "lnkCurrentCancel";
            this.lnkCurrentCancel.Size = new System.Drawing.Size(47, 20);
            this.lnkCurrentCancel.TabIndex = 27;
            this.lnkCurrentCancel.Values.Text = "Cancel";
            this.lnkCurrentCancel.LinkClicked += new System.EventHandler(this.lnkCurrentCancel_LinkClicked);
            // 
            // lnkCurrentOk
            // 
            this.lnkCurrentOk.LinkBehavior = ComponentFactory.Krypton.Toolkit.KryptonLinkBehavior.NeverUnderline;
            this.lnkCurrentOk.Location = new System.Drawing.Point(226, 3);
            this.lnkCurrentOk.Name = "lnkCurrentOk";
            this.lnkCurrentOk.Size = new System.Drawing.Size(26, 20);
            this.lnkCurrentOk.TabIndex = 26;
            this.lnkCurrentOk.Values.Text = "Ok";
            this.lnkCurrentOk.LinkClicked += new System.EventHandler(this.lnkCurrentOk_LinkClicked);
            // 
            // txtCurrentCode
            // 
            this.txtCurrentCode.Location = new System.Drawing.Point(82, 1);
            this.txtCurrentCode.Name = "txtCurrentCode";
            this.txtCurrentCode.PasswordChar = '●';
            this.txtCurrentCode.Size = new System.Drawing.Size(138, 24);
            this.txtCurrentCode.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCurrentCode.StateCommon.Border.Rounding = 5;
            this.txtCurrentCode.TabIndex = 24;
            // 
            // lblCurrentCode
            // 
            this.lblCurrentCode.Location = new System.Drawing.Point(5, 3);
            this.lblCurrentCode.Name = "lblCurrentCode";
            this.lblCurrentCode.Size = new System.Drawing.Size(81, 20);
            this.lblCurrentCode.TabIndex = 23;
            this.lblCurrentCode.Values.Text = "Current code";
            // 
            // pnlValidationNew
            // 
            this.pnlValidationNew.BackColor = System.Drawing.Color.Transparent;
            this.pnlValidationNew.Controls.Add(this.lnkNewCancel);
            this.pnlValidationNew.Controls.Add(this.lnkNewOk);
            this.pnlValidationNew.Controls.Add(this.txtNewCode);
            this.pnlValidationNew.Controls.Add(this.lblNewCode);
            this.pnlValidationNew.Location = new System.Drawing.Point(7, 37);
            this.pnlValidationNew.Name = "pnlValidationNew";
            this.pnlValidationNew.Size = new System.Drawing.Size(307, 28);
            this.pnlValidationNew.TabIndex = 27;
            this.pnlValidationNew.Visible = false;
            // 
            // lnkNewCancel
            // 
            this.lnkNewCancel.LinkBehavior = ComponentFactory.Krypton.Toolkit.KryptonLinkBehavior.NeverUnderline;
            this.lnkNewCancel.Location = new System.Drawing.Point(255, 3);
            this.lnkNewCancel.Name = "lnkNewCancel";
            this.lnkNewCancel.Size = new System.Drawing.Size(47, 20);
            this.lnkNewCancel.TabIndex = 27;
            this.lnkNewCancel.Values.Text = "Cancel";
            this.lnkNewCancel.LinkClicked += new System.EventHandler(this.lnkNewCancel_LinkClicked);
            // 
            // lnkNewOk
            // 
            this.lnkNewOk.LinkBehavior = ComponentFactory.Krypton.Toolkit.KryptonLinkBehavior.NeverUnderline;
            this.lnkNewOk.Location = new System.Drawing.Point(226, 3);
            this.lnkNewOk.Name = "lnkNewOk";
            this.lnkNewOk.Size = new System.Drawing.Size(26, 20);
            this.lnkNewOk.TabIndex = 26;
            this.lnkNewOk.Values.Text = "Ok";
            this.lnkNewOk.LinkClicked += new System.EventHandler(this.lnkNewOk_LinkClicked);
            // 
            // txtNewCode
            // 
            this.txtNewCode.Location = new System.Drawing.Point(82, 1);
            this.txtNewCode.Name = "txtNewCode";
            this.txtNewCode.PasswordChar = '●';
            this.txtNewCode.Size = new System.Drawing.Size(138, 24);
            this.txtNewCode.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNewCode.StateCommon.Border.Rounding = 5;
            this.txtNewCode.TabIndex = 24;
            // 
            // lblNewCode
            // 
            this.lblNewCode.Location = new System.Drawing.Point(21, 3);
            this.lblNewCode.Name = "lblNewCode";
            this.lblNewCode.Size = new System.Drawing.Size(65, 20);
            this.lblNewCode.TabIndex = 23;
            this.lblNewCode.Values.Text = "New code";
            // 
            // lnkChangeCode
            // 
            this.lnkChangeCode.LinkBehavior = ComponentFactory.Krypton.Toolkit.KryptonLinkBehavior.NeverUnderline;
            this.lnkChangeCode.Location = new System.Drawing.Point(77, 11);
            this.lnkChangeCode.Name = "lnkChangeCode";
            this.lnkChangeCode.Size = new System.Drawing.Size(158, 20);
            this.lnkChangeCode.TabIndex = 22;
            this.lnkChangeCode.Values.Text = "Change authorization code";
            this.lnkChangeCode.LinkClicked += new System.EventHandler(this.lnkChangeCode_LinkClicked);
            // 
            // chkEnableValidation
            // 
            this.chkEnableValidation.Location = new System.Drawing.Point(11, 11);
            this.chkEnableValidation.Name = "chkEnableValidation";
            this.chkEnableValidation.Size = new System.Drawing.Size(60, 20);
            this.chkEnableValidation.TabIndex = 20;
            this.chkEnableValidation.Values.Text = "Enable";
            this.chkEnableValidation.CheckedChanged += new System.EventHandler(this.chkEnableValidation_CheckedChanged);
            // 
            // lblHash
            // 
            this.lblHash.Location = new System.Drawing.Point(15, 37);
            this.lblHash.Name = "lblHash";
            this.lblHash.Size = new System.Drawing.Size(76, 14);
            this.lblHash.StateCommon.ShortText.Font = new System.Drawing.Font("Courier New", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHash.TabIndex = 18;
            this.lblHash.Values.Text = "Hash: {hash}";
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeaderGroup1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonStandalone;
            this.kryptonHeaderGroup1.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.kryptonHeaderGroup1.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.lblServer);
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.txtServer);
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.lnkTest);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(315, 68);
            this.kryptonHeaderGroup1.TabIndex = 23;
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "Connection";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = null;
            // 
            // lblServer
            // 
            this.lblServer.Location = new System.Drawing.Point(46, 12);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(45, 20);
            this.lblServer.TabIndex = 18;
            this.lblServer.Values.Text = "Server";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(97, 10);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(166, 24);
            this.txtServer.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtServer.StateCommon.Border.Rounding = 5;
            this.txtServer.TabIndex = 19;
            // 
            // lnkTest
            // 
            this.lnkTest.LinkBehavior = ComponentFactory.Krypton.Toolkit.KryptonLinkBehavior.NeverUnderline;
            this.lnkTest.Location = new System.Drawing.Point(269, 14);
            this.lnkTest.Name = "lnkTest";
            this.lnkTest.Size = new System.Drawing.Size(33, 20);
            this.lnkTest.TabIndex = 21;
            this.lnkTest.Values.Text = "Test";
            this.lnkTest.Visible = false;
            this.lnkTest.LinkClicked += new System.EventHandler(this.lnkTest_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Location = new System.Drawing.Point(213, 334);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 25);
            this.btnClose.TabIndex = 22;
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(117, 334);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 25);
            this.btnSave.TabIndex = 20;
            this.btnSave.Values.Text = "Save and exit";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 371);
            this.Controls.Add(this.kryptonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3.Panel)).EndInit();
            this.kryptonHeaderGroup3.Panel.ResumeLayout(false);
            this.kryptonHeaderGroup3.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3)).EndInit();
            this.kryptonHeaderGroup3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).EndInit();
            this.kryptonHeaderGroup2.Panel.ResumeLayout(false);
            this.kryptonHeaderGroup2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).EndInit();
            this.kryptonHeaderGroup2.ResumeLayout(false);
            this.pnlValidationCurrent.ResumeLayout(false);
            this.pnlValidationCurrent.PerformLayout();
            this.pnlValidationNew.ResumeLayout(false);
            this.pnlValidationNew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            this.kryptonHeaderGroup1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtServer;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblServer;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lnkTest;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClose;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblHash;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup3;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chkEnableValidation;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNotedPos;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblNotedPos;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNotedBy;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblNotedBy;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtApprovedPos;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblApprovedPos;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtApprovedBy;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblApprovedBy;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lnkChangeCode;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCurrentCode;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCurrentCode;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lnkCurrentOk;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lnkCurrentCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lnkNewCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lnkNewOk;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblNewCode;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNewCode;
        private System.Windows.Forms.Panel pnlValidationNew;
        private System.Windows.Forms.Panel pnlValidationCurrent;
    }
}

