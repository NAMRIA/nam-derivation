namespace Derivation
{
    partial class SearchForm
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
            this.grpResult = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.gvResult = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.lnkClose = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnGo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtKeyword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpResult.Panel)).BeginInit();
            this.grpResult.Panel.SuspendLayout();
            this.grpResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.grpResult);
            this.kryptonPanel.Controls.Add(this.lnkClose);
            this.kryptonPanel.Controls.Add(this.btnAdd);
            this.kryptonPanel.Controls.Add(this.btnGo);
            this.kryptonPanel.Controls.Add(this.txtKeyword);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(292, 333);
            this.kryptonPanel.TabIndex = 0;
            // 
            // grpResult
            // 
            this.grpResult.CaptionVisible = false;
            this.grpResult.Location = new System.Drawing.Point(12, 42);
            this.grpResult.Name = "grpResult";
            // 
            // grpResult.Panel
            // 
            this.grpResult.Panel.Controls.Add(this.gvResult);
            this.grpResult.Size = new System.Drawing.Size(268, 248);
            this.grpResult.TabIndex = 5;
            // 
            // gvResult
            // 
            this.gvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.gvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvResult.Location = new System.Drawing.Point(0, 0);
            this.gvResult.Name = "gvResult";
            this.gvResult.Size = new System.Drawing.Size(264, 244);
            this.gvResult.TabIndex = 4;
            // 
            // lnkClose
            // 
            this.lnkClose.Location = new System.Drawing.Point(175, 298);
            this.lnkClose.Name = "lnkClose";
            this.lnkClose.Size = new System.Drawing.Size(40, 20);
            this.lnkClose.TabIndex = 3;
            this.lnkClose.Values.Text = "Close";
            this.lnkClose.LinkClicked += new System.EventHandler(this.lnkClose_LinkClicked);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(221, 296);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(59, 25);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Values.Text = "Add";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(239, 12);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(41, 25);
            this.btnGo.TabIndex = 1;
            this.btnGo.Values.Text = "Go";
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(12, 12);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(221, 24);
            this.txtKeyword.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtKeyword.StateCommon.Border.Rounding = 5;
            this.txtKeyword.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtKeyword.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Sketch";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 333);
            this.Controls.Add(this.kryptonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search for reference points";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpResult.Panel)).EndInit();
            this.grpResult.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpResult)).EndInit();
            this.grpResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtKeyword;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnGo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAdd;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lnkClose;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gvResult;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox grpResult;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
    }
}

