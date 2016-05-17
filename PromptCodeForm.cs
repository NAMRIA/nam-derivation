using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Derivation
{
    public partial class PromptCodeForm : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public string AuthorizationCode = "";

        public PromptCodeForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.AuthorizationCode = txtCode.Text;
            this.Close();
        }

        

    }
}