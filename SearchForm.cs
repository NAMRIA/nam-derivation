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
    public partial class SearchForm : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void lnkClose_LinkClicked(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            SearchGNIS();

        }





        private void SearchGNIS()
        {
            DataTable dt = GheloBytes.GetDataTable("SELECT * FROM [ref_type_table]");
            gvResult.DataSource = null;
            gvResult.DataSource = dt;
        }




    }
}