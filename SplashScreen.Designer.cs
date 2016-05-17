namespace Derivation
{
    partial class SplashScreen
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
            this.grpContainer = new ComponentFactory.Krypton.Toolkit.KryptonGroup();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.lblLoading = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpContainer.Panel)).BeginInit();
            this.grpContainer.Panel.SuspendLayout();
            this.grpContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.grpContainer);
            this.kryptonPanel.Controls.Add(this.lblLoading);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(2, 2);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(190, 57);
            this.kryptonPanel.TabIndex = 0;
            // 
            // grpContainer
            // 
            this.grpContainer.Location = new System.Drawing.Point(12, 8);
            this.grpContainer.Name = "grpContainer";
            // 
            // grpContainer.Panel
            // 
            this.grpContainer.Panel.Controls.Add(this.pbLoading);
            this.grpContainer.Size = new System.Drawing.Size(43, 42);
            this.grpContainer.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.grpContainer.StateCommon.Border.Rounding = 5;
            this.grpContainer.TabIndex = 2;
            // 
            // pbLoading
            // 
            this.pbLoading.BackColor = System.Drawing.Color.Transparent;
            this.pbLoading.Image = global::Derivation.Properties.Resources.loading;
            this.pbLoading.Location = new System.Drawing.Point(1, 1);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(35, 34);
            this.pbLoading.TabIndex = 0;
            this.pbLoading.TabStop = false;
            // 
            // lblLoading
            // 
            this.lblLoading.Location = new System.Drawing.Point(56, 19);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(114, 19);
            this.lblLoading.TabIndex = 1;
            this.lblLoading.Values.Text = "Loading. Please wait.";
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(194, 61);
            this.Controls.Add(this.kryptonPanel);
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpContainer.Panel)).EndInit();
            this.grpContainer.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpContainer)).EndInit();
            this.grpContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private System.Windows.Forms.PictureBox pbLoading;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblLoading;
        private ComponentFactory.Krypton.Toolkit.KryptonGroup grpContainer;
    }
}

