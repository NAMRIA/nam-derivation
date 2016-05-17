// D:\ghelo\Resources\Icons\Stockics\Stockicons\Carbon\Carbon\PNG

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Xml;
using SharpMap.Layers;
using SharpMap;
using SharpMap.Data.Providers;
using SharpMap.Data;
using SharpMap.Geometries;
using SharpMap.Converters.NTS;
using ProjNet.CoordinateSystems.Transformations;
using ProjNet.CoordinateSystems;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.IO;
using System.Web.Security;

namespace Derivation
{
    public partial class MainForm : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private string FORM_TITLE = "PRS92 - 4 Parameters Derivation";
        private const string PTM_ZONE1 = "PROJCS[\"Luzon 1911 / Philippines zone I\",GEOGCS[\"Luzon 1911\",DATUM[\"Luzon_1911\",SPHEROID[\"Clarke 1866\",6378206.4,294.9786982138982,AUTHORITY[\"EPSG\",\"7008\"]],AUTHORITY[\"EPSG\",\"6253\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4253\"]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",0],PARAMETER[\"central_meridian\",117],PARAMETER[\"scale_factor\",0.99995],PARAMETER[\"false_easting\",500000],PARAMETER[\"false_northing\",0],UNIT[\"metre\",1,AUTHORITY[\"EPSG\",\"9001\"]],AUTHORITY[\"EPSG\",\"25391\"]]";
        private const string PTM_ZONE1A = "PROJCS[\"Luzon 1911 / Philippines zone I\",GEOGCS[\"Luzon 1911\",DATUM[\"Luzon_1911\",SPHEROID[\"Clarke 1866\",6378206.4,294.9786982138982,AUTHORITY[\"EPSG\",\"7008\"]],AUTHORITY[\"EPSG\",\"6253\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4253\"]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",0],PARAMETER[\"central_meridian\",118.5],PARAMETER[\"scale_factor\",0.99995],PARAMETER[\"false_easting\",500000],PARAMETER[\"false_northing\",0],UNIT[\"metre\",1,AUTHORITY[\"EPSG\",\"9001\"]],AUTHORITY[\"EPSG\",\"25391\"]]";
        private const string PTM_ZONE2 = "PROJCS[\"Luzon 1911 / Philippines zone II\",GEOGCS[\"Luzon 1911\",DATUM[\"Luzon_1911\",SPHEROID[\"Clarke 1866\",6378206.4,294.9786982138982,AUTHORITY[\"EPSG\",\"7008\"]],AUTHORITY[\"EPSG\",\"6253\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4253\"]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",0],PARAMETER[\"central_meridian\",119],PARAMETER[\"scale_factor\",0.99995],PARAMETER[\"false_easting\",500000],PARAMETER[\"false_northing\",0],UNIT[\"metre\",1,AUTHORITY[\"EPSG\",\"9001\"]],AUTHORITY[\"EPSG\",\"25392\"]]";
        private const string PTM_ZONE3 = "PROJCS[\"Luzon 1911 / Philippines zone III\",GEOGCS[\"Luzon 1911\",DATUM[\"Luzon_1911\",SPHEROID[\"Clarke 1866\",6378206.4,294.9786982138982,AUTHORITY[\"EPSG\",\"7008\"]],AUTHORITY[\"EPSG\",\"6253\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4253\"]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",0],PARAMETER[\"central_meridian\",121],PARAMETER[\"scale_factor\",0.99995],PARAMETER[\"false_easting\",500000],PARAMETER[\"false_northing\",0],UNIT[\"metre\",1,AUTHORITY[\"EPSG\",\"9001\"]],AUTHORITY[\"EPSG\",\"25393\"]]";
        private const string PTM_ZONE4 = "PROJCS[\"Luzon 1911 / Philippines zone IV\",GEOGCS[\"Luzon 1911\",DATUM[\"Luzon_1911\",SPHEROID[\"Clarke 1866\",6378206.4,294.9786982138982,AUTHORITY[\"EPSG\",\"7008\"]],AUTHORITY[\"EPSG\",\"6253\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4253\"]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",0],PARAMETER[\"central_meridian\",123],PARAMETER[\"scale_factor\",0.99995],PARAMETER[\"false_easting\",500000],PARAMETER[\"false_northing\",0],UNIT[\"metre\",1,AUTHORITY[\"EPSG\",\"9001\"]],AUTHORITY[\"EPSG\",\"25394\"]]";
        private const string PTM_ZONE5 = "PROJCS[\"Luzon 1911 / Philippines zone V\",GEOGCS[\"Luzon 1911\",DATUM[\"Luzon_1911\",SPHEROID[\"Clarke 1866\",6378206.4,294.9786982138982,AUTHORITY[\"EPSG\",\"7008\"]],AUTHORITY[\"EPSG\",\"6253\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4253\"]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",0],PARAMETER[\"central_meridian\",125],PARAMETER[\"scale_factor\",0.99995],PARAMETER[\"false_easting\",500000],PARAMETER[\"false_northing\",0],UNIT[\"metre\",1,AUTHORITY[\"EPSG\",\"9001\"]],AUTHORITY[\"EPSG\",\"25395\"]]";
        private const string WGS84 = "GEOGCS[\"WGS 84\",DATUM[\"WGS_1984\",SPHEROID[\"WGS 84\",6378137,298.257223563,AUTHORITY[\"EPSG\",\"7030\"]],AUTHORITY[\"EPSG\",\"6326\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4326\"]]";

        private const string SQL = @"SELECT RTRIM([ref_type]) + ' ' + RTRIM([ref_type_no]) AS [REF_NAME]
                                            ,[True_Northing] AS [OLD_NORTHING]
                                            ,[True_Easting] AS [OLD_EASTING]
                                            ,[PTM_PRS92_Northing] AS [NEW_NORTHING]
                                            ,[PTM_PRS92_Easting] AS [NEW_EASTING]
                                            ,CAST(1 AS BIT) AS [IS_SELECTED]
                                            ,CAST(0 AS BIT) AS [IS_USER_ADDED]
                                     FROM  [ref_type_table] 
                                     WHERE [project_no] = '{0}' AND 
                                           NOT [true_easting] IS NULL AND 
                                           NOT [true_northing] IS NULL ";

        FeatureDataTable fdtCANDIDATE;
        FeatureDataTable fdtPRS;


        private string PROJECT_NO;
        private int ZONE;
        private string REGION;
        private string PROVINCE;
        private string MUNICIPALITY;
        private DerivedParameter param = new DerivedParameter();

        private string FileLocation = "";
        private bool HasChanged = false;
        private bool IsLocked = false;
        private bool CanConnect = false;
        

        // structures
        struct DerivedParameter
        {
            public double a;
            public double b;
            public double Ce;
            public double Cn;

            public int PointCount;
            public double VeVeSum;
            public double VnVnSum;
            public double Variance;

            public FeatureDataTable Table;
        }
        
        public MainForm()
        {
            InitializeComponent();
        }

        // events
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.FORM_TITLE = FORM_TITLE + String.Format(" (Build {0})", Program.Version);
            this.Text = FORM_TITLE;

            lblLocation.Text = "";
            lblStatus.Text = "";

            Hide();
            bool done = false;
            System.Threading.ThreadPool.QueueUserWorkItem((x) =>
            {
                using (SplashScreen splashForm = new SplashScreen())
                {
                    splashForm.Show();
                    splashForm.Activate();
                    while (!done)
                        Application.DoEvents();
                    splashForm.Close();
                }
            });

            // heavy
            this.CanConnect = GheloBytes.IsConnectionOk();
            Initialize();
            InitCandidateTable();
            InitPRSTable();
            InitializeMap();
            InitCadAutocomplete();
            InitializeValidation();
            // heavy

            done = true;
            Show();

        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchForm frm = new SearchForm();
            frm.ShowDialog();
        }
        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            mapBox.Map.Zoom *= 0.7f;
            mapBox.Refresh();
        }
        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            mapBox.Map.Zoom /= 0.7f;
            mapBox.Refresh();
        }
        private void btnCompute_Click(object sender, EventArgs e)
        {
            try
            {
                param = ComputeParameters(fdtCANDIDATE);
                fdtCANDIDATE = param.Table;

                txtP_a.Text = String.Format("{0:N6} ", param.a);
                txtP_b.Text = String.Format("{0:N6} ", param.b);
                txtP_Ce.Text = String.Format("{0:N6} ", param.Ce);
                txtP_Cn.Text = String.Format("{0:N6} ", param.Cn);


                txtPointCount.Text = String.Format("{0} ", param.PointCount);
                txtSumVeVe.Text = String.Format("{0:N6} ", param.VeVeSum);
                txtSumVnVn.Text = String.Format("{0:N6} ", param.VnVnSum);
                txtVariance.Text = String.Format("{0:N6} ", param.Variance);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }
        private void btnSearchProject_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("xxx");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            New();
            ApplyFileLocking();
            InitializeValidation();
        }
        private void btnSave_Click(object sender, EventArgs e)
        { 
            Save(false);
            UpdateChangeFlag(false);
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            Read();
            PlotRefPoints(this.PROJECT_NO);
            UpdateChangeFlag(false);
            ApplyFileLocking();
            InitializeValidation();
        }
        private void btnSaveAs_Click(object sender, System.EventArgs e)
        {
            string location = this.FileLocation;
            this.FileLocation = "";
            if (Save(false))
            {
                UpdateChangeFlag(false);
            }
            else
            {
                this.FileLocation = location;
            }           
        }

        private void btnGridAdd_Click(object sender, System.EventArgs e)
        {
            FeatureDataRow dr = fdtCANDIDATE.NewRow();
            dr.Geometry = Geometry.GeomFromText("POINT(0 0)");
            dr["REF_NAME"] = "*";
            dr["IS_USER_ADDED"] = true;
            fdtCANDIDATE.Rows.Add(dr);
            if (gvCoordinates.SelectedRows.Count > 0)
                gvCoordinates.SelectedRows[0].Selected = false;
            gvCoordinates.Rows[gvCoordinates.Rows.Count - 1].Selected = true;
            UpdateChangeFlag(true);
        }
        private void btnGridRemove_Click(object sender, System.EventArgs e)
        {
            if (gvCoordinates.SelectedRows.Count > 0)
            {
                gvCoordinates.Rows.Remove(gvCoordinates.SelectedRows[0]);
                UpdateChangeFlag(true);
                UpdatePRS();
                mapBox.Refresh();
            }
            
        }
        private void btnGridUncheck_Click(object sender, System.EventArgs e)
        {
            if (gvCoordinates.SelectedRows != null)
            {
                gvCoordinates.SelectedRows[0].Cells["colSelected"].Value = !Convert.ToBoolean(gvCoordinates.SelectedRows[0].Cells["colSelected"].Value);
                mapBox.Refresh();
                UpdateChangeFlag(true);
            }
            
        }
        private void btnAddPoint_Click(object sender, System.EventArgs e)
        {
            btnGridAdd_Click(this, EventArgs.Empty);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Size newSize = new Size(938, 713);
            Map printable = CloneMap(newSize, mapBox.Map);
            VectorLayer lyrMUN = printable.Layers["lyrMUN"] as VectorLayer;
            VectorLayer lyrPROV = printable.Layers["lyrPROV"] as VectorLayer;
            lyrMUN.Style.Fill = Brushes.White;
            lyrPROV.Style.Fill = Brushes.White;
            printable.BackColor = Color.White;

            Image img = printable.GetMap();
            

            using (Graphics gr = Graphics.FromImage(img))
            {
                //gr.DrawImage(global::Derivation.Properties.Resources.legend, new System.Drawing.Point(0, 0));
                //gr.DrawRectangle(Pens.Black, 100, 100, 100, 100);
            }

            byte[] map = ImageToByteArray(img);

            ReportSource.DataDataTable dt = new ReportSource.DataDataTable();
            ReportSource.DataRow dr = dt.NewDataRow();
            dr["project_no"] = this.PROJECT_NO;
            dr["municipality"] = this.MUNICIPALITY;
            dr["province"] = this.PROVINCE;
            dr["region"] = this.REGION;
            dr["map"] = map;

            dt.Rows.Add(dr);

            PrintForm p = new PrintForm(dt as DataTable);
            //p.TopMost = true;
            //p.Show();
            p.ShowDialog(this);


        }
        private void btnValidate_Click(object sender, EventArgs e)
        {
            // validate first
            using (PromptCodeForm frm = new PromptCodeForm())
            {
                frm.ShowDialog();
                string hash = FormsAuthentication.HashPasswordForStoringInConfigFile(GheloBytes.Salt + frm.AuthorizationCode, "SHA1");
                if (hash != GheloBytes.GetSetting("validation", "hash", "value"))
                {
                    MessageBox.Show("Invalid authorization code!");
                    return;
                }
            }
            


            if (this.FileLocation == String.Empty)
                return;

            this.FileLocation = this.FileLocation + ".lck";
            
            if (MessageBox.Show("Are you sure you want to sign this file as valid and lock it?", "Wait!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Save(true);
                this.IsLocked = true;
                UpdateChangeFlag(false);
                ApplyFileLocking();
            }

        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            bool isExisting = (Convert.ToInt32(GheloBytes.GetData(String.Format("SELECT COUNT(*) FROM [FourParameters] WHERE CadSurveyNo = '{0}'", this.PROJECT_NO))) > 0);
            if (isExisting)
            {
                if (MessageBox.Show(String.Format("The project {0} already exist in the four parameters library.\nDo you want to overwrite it?", this.PROJECT_NO), "Wait!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    GheloBytes.Execute(String.Format(@"UPDATE [FourParameters] SET [a] = {0}, [b] = {1}, [ce] = {2}, [cn] = {3} WHERE [CadSurveyNo] = '{4}';", param.a, param.b, param.Ce, param.Cn, this.PROJECT_NO));
                else
                    return;
            }
            else
            {
                GheloBytes.Execute(String.Format(@"INSERT INTO [FourParameters]([a],[b],[ce],[cn],[CadSurveyNo]) VALUES({0},{1},{2},{3},'{4}');", param.a, param.b, param.Ce, param.Cn, this.PROJECT_NO));
            }
            MessageBox.Show("The parameters of this project was succesfully uploaded to the database.");
        }

        private void mapBox_SizeChanged(object sender, EventArgs e)
        {
            //if (this.WindowState != FormWindowState.Minimized)
            //    mapBox.Refresh();
        }
        private void mapBox_MapQueried(FeatureDataTable data, BoundingBox bb)
        {

            if (this.IsLocked)
                return;

            if (data.Rows.Count == 1)
            {
                FeatureDataRow fdr = data.Rows[0] as FeatureDataRow;
                // check if row is in lyrSELECTION
                // if it is, remove
                // else add


                // check if the record has observed values
                if (fdr["NEW_NORTHING"] == DBNull.Value | fdr["NEW_EASTING"] == DBNull.Value)
                {
                    MessageBox.Show("Cannot add reference with no observed value.");
                    return;
                }
                    



                bool isAdded = false;

                if (fdtCANDIDATE.Rows.Count > 0)
                {
                    foreach (FeatureDataRow rw in fdtCANDIDATE.Rows)
                    {
                        //checking by geometry
                        //if (rw.Geometry.Equals(fdr.Geometry))

                        //checking by easting and northing value
                        if(rw["OLD_EASTING"].Equals(fdr["OLD_EASTING"]) & 
                           rw["OLD_NORTHING"].Equals(fdr["OLD_NORTHING"]))
                        {
                            fdtCANDIDATE.RemoveRow(rw);
                            //rw["IS_SELECTED"] = false;
                            isAdded = true;
                            break;
                        }
                    }
                }
                
                if (!isAdded)
                {
                    FeatureDataRow newFdr = fdtCANDIDATE.NewRow();
                    newFdr["REF_NAME"] = fdr["REF_NAME"];
                    newFdr["OLD_NORTHING"] = fdr["OLD_NORTHING"];
                    newFdr["OLD_EASTING"] = fdr["OLD_EASTING"];
                    newFdr["NEW_NORTHING"] = fdr["NEW_NORTHING"];
                    newFdr["NEW_EASTING"] = fdr["NEW_EASTING"];
                    newFdr.Geometry = fdr.Geometry;
                    fdtCANDIDATE.Rows.Add(newFdr);
                }
            }
            else if (data.Rows.Count > 1)
            {
                MessageBox.Show("More than 1 point is returned. TODO: Handle this.");
            }


            VectorLayer lyrSELECTION = mapBox.Map.Layers["lyrSELECTION"] as VectorLayer;
            lyrSELECTION.DataSource = new GeometryFeatureProvider(fdtCANDIDATE);

            //LabelLayer lblSELECTION = mapBox.Map.Layers["lblSELECTION"] as LabelLayer;
            //lblSELECTION.DataSource = lyrSELECTION.DataSource;
            
        }
        
        /*
        private void mapBox_MapQueried_KILLED(FeatureDataTable data, BoundingBox bb)
        {
            if (data.Rows.Count == 1)
            {
                FeatureDataRow fdr = data.Rows[0] as FeatureDataRow;
                // check if row is in lyrSELECTION
                // if it is, remove
                // else add

                bool isAdded = false;

                if (fdtCANDIDATE.Rows.Count > 0)
                {
                    foreach (FeatureDataRow rw in fdtCANDIDATE.Rows)
                    {
                        //checking by geometry
                        //if (rw.Geometry.Equals(fdr.Geometry))

                        //checking by easting and northing value
                        if (rw["OLD_EASTING"].Equals(fdr["OLD_EASTING"]) &
                           rw["OLD_NORTHING"].Equals(fdr["OLD_NORTHING"]))
                        {
                            //fdtCANDIDATE.RemoveRow(rw);
                            rw["IS_SELECTED"] = !Convert.ToBoolean(rw["IS_SELECTED"]);
                            isAdded = true;
                            break;
                        }
                    }
                }

                if (!isAdded)
                {
                    FeatureDataRow newFdr = fdtCANDIDATE.NewRow();
                    newFdr["REF_NAME"] = fdr["REF_NAME"];
                    newFdr["OLD_NORTHING"] = fdr["OLD_NORTHING"];
                    newFdr["OLD_EASTING"] = fdr["OLD_EASTING"];
                    newFdr["NEW_NORTHING"] = fdr["NEW_NORTHING"];
                    newFdr["NEW_EASTING"] = fdr["NEW_EASTING"];
                    newFdr.Geometry = fdr.Geometry;
                    fdtCANDIDATE.Rows.Add(newFdr);
                }
            }
            else if (data.Rows.Count > 1)
            {
                MessageBox.Show("More than 1 point is returned. TODO: Handle this.");
            }


            VectorLayer lyrSELECTION = mapBox.Map.Layers["lyrSELECTION"] as VectorLayer;
            lyrSELECTION.DataSource = new GeometryFeatureProvider(fdtCANDIDATE);

            //LabelLayer lblSELECTION = mapBox.Map.Layers["lblSELECTION"] as LabelLayer;
            //lblSELECTION.DataSource = lyrSELECTION.DataSource;

        }
 
        */
        
        private void mapBox_MouseMove(SharpMap.Geometries.Point worldPos, MouseEventArgs imagePos)
        {
            if (this.ZONE <= 0)
            {
                lblStatus.Text = "";
                return;
            }
            int zone = this.ZONE;
            double[] point = TransformPTM_WGS84(zone).MathTransform.Inverse().Transform(new double[] { worldPos.X, worldPos.Y });
            //string s = String.Format("WGS84: {0:N3}  {1:N3}   PTM Zone {2}: {3:N5}  {4:N5}", worldPos.X, worldPos.Y, zone, point[0], point[1]);
            //string s = String.Format(@"{0:N3}, {1:N3}", worldPos.X, worldPos.Y);
            string s = String.Format(@"N: {0:N3}   E: {1:N3}", point[1], point[0] );
            lblStatus.Text = s;
        }
        
        private void gvCoordinates_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if(!Convert.ToBoolean(gvCoordinates.Rows[e.RowIndex].Cells["colSelected"].Value))
            {
                gvCoordinates.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
            } else {
                if ((e.RowIndex % 2) > 0)
                   gvCoordinates.Rows[e.RowIndex].DefaultCellStyle.BackColor = gvCoordinates.AlternatingRowsDefaultCellStyle.BackColor;
                else
                    gvCoordinates.Rows[e.RowIndex].DefaultCellStyle.BackColor = gvCoordinates.RowsDefaultCellStyle.BackColor;
                
            }
        }
        private void gvCoordinates_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {

            if (gvCoordinates.CurrentCell.ColumnIndex == gvCoordinates.Columns["colSELECTED"].Index)
            {
                gvCoordinates.EndEdit();
                gvCoordinates.Update();
                fdtCANDIDATE.AcceptChanges();
                UpdatePRS();
                mapBox.Refresh();
            }

        }
        private void gvCoordinates_MouseClick(object sender, MouseEventArgs e)
        {
            KryptonDataGridView.HitTestInfo hitTestInfo;
            if (e.Button == MouseButtons.Right)
            {
                hitTestInfo = gvCoordinates.HitTest(e.X, e.Y);
                if (hitTestInfo.Type == DataGridViewHitTestType.Cell)
                {
                    cnxMenuGrid.Show(gvCoordinates);
                    if (gvCoordinates.SelectedRows != null)
                        gvCoordinates.SelectedRows[0].Selected = false;
                    gvCoordinates.Rows[hitTestInfo.RowIndex].Selected = true;

                }
            }
        }
        private void gvCoordinates_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gvCoordinates.CurrentCell.ColumnIndex == gvCoordinates.Columns["colREF_NAME"].Index)
            {
                if (this.CanConnect)
                {
                    PreparePointAutocomplete(e.Control);
                    UpdatePRS();
                    mapBox.Refresh();
                }
            }

            if (gvCoordinates.CurrentCell.ColumnIndex == gvCoordinates.Columns["colOLD_EASTING"].Index |
                gvCoordinates.CurrentCell.ColumnIndex == gvCoordinates.Columns["colOLD_NORTHING"].Index)
            {
                PrepareReplotPoint(e.Control, gvCoordinates.CurrentCell.RowIndex);
                
            }


        }
        
        private void txtProjectNo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string projectNo = txtProjectNo.Text;
                New();
                txtProjectNo.Text = projectNo;
                txtProjectNo.Select(projectNo.Length, 0);
                if(this.CanConnect)
                    GetProjectDetails(projectNo);
            }
        }
        private void txtProjectNo_TextChanged(object sender, EventArgs e)
        {
            this.PROJECT_NO = txtProjectNo.Text;
            UpdateChangeFlag(true);
        }
        private void txtREF_NAME_Leave(object sender, EventArgs e)
        {
            int rowIndex = gvCoordinates.CurrentCell.RowIndex;
            string refName = (sender as TextBox).Text;

            string sql = String.Format(@"SELECT [true_easting], [true_northing], [ptm_prs92_easting], [ptm_prs92_northing] FROM [ref_type_table] WHERE [project_no] = '{0}' AND RTRIM([ref_type]) + ' ' + RTRIM([ref_type_no]) = '{1}' ", this.PROJECT_NO, refName);
            DataTable dt = GheloBytes.GetDataTable(sql);

            if (dt.Rows.Count > 0)
            {
                double true_easting = Convert.ToDouble(dt.Rows[0]["true_easting"]);
                double true_northing = Convert.ToDouble(dt.Rows[0]["true_northing"]);
                gvCoordinates.Rows[rowIndex].Cells["colOLD_EASTING"].Value = true_easting;
                gvCoordinates.Rows[rowIndex].Cells["colOLD_NORTHING"].Value = true_northing;


                if (dt.Rows[0]["ptm_prs92_easting"] != DBNull.Value &
                    dt.Rows[0]["ptm_prs92_northing"] != DBNull.Value)
                {
                    double prs92_easting = Convert.ToDouble(dt.Rows[0]["ptm_prs92_easting"]);
                    double prs92_northing = Convert.ToDouble(dt.Rows[0]["ptm_prs92_northing"]);
                    gvCoordinates.Rows[rowIndex].Cells["colNEW_EASTING"].Value = prs92_easting;
                    gvCoordinates.Rows[rowIndex].Cells["colNEW_NORTHING"].Value = prs92_northing;
                }

                double[] point = new double[] { true_easting, true_northing };
                point = TransformPTM_WGS84(this.ZONE).MathTransform.Transform(point);
                string wkt = String.Format("POINT({0} {1})", point[0], point[1]);

                FeatureDataRow fdr = fdtCANDIDATE.Rows[rowIndex] as FeatureDataRow;
                fdr.Geometry = Geometry.GeomFromText(wkt);
                fdr["IS_USER_ADDED"] = false;

                UpdatePRS();
                mapBox.Refresh();


            }

        }
        private void txtCOORD_Leave(object sender, EventArgs e)
        {
            int rowIndex = Convert.ToInt32((sender as TextBox).Tag);

            if (fdtCANDIDATE.Rows[rowIndex]["OLD_EASTING"] != DBNull.Value &
                fdtCANDIDATE.Rows[rowIndex]["OLD_NORTHING"] != DBNull.Value)
            {
                double true_easting = Convert.ToDouble(fdtCANDIDATE.Rows[rowIndex]["OLD_EASTING"]);
                double true_northing = Convert.ToDouble(fdtCANDIDATE.Rows[rowIndex]["OLD_NORTHING"]);

                double[] point = new double[] { true_easting, true_northing };
                point = TransformPTM_WGS84(this.ZONE).MathTransform.Transform(point);
                string wkt = String.Format("POINT({0} {1})", point[0], point[1]);

                (fdtCANDIDATE.Rows[rowIndex] as FeatureDataRow).Geometry = Geometry.GeomFromText(wkt);

                UpdatePRS();
                mapBox.Refresh();
            }
            
        }

        private void cmbZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.PROJECT_NO))
                PlotRefPoints(this.PROJECT_NO);
        }
        private void lnkSettings_LinkClicked(object sender, EventArgs e)
        {
            SettingsForm frm = new SettingsForm();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {

                ////bool done = false;
                ////System.Threading.ThreadPool.QueueUserWorkItem((x) =>
                ////{
                ////    using (SplashScreen splashForm = new SplashScreen())
                ////    {
                ////        splashForm.Show();
                ////        splashForm.Activate();
                ////        while (!done)
                ////            Application.DoEvents();
                ////        splashForm.Close();
                ////    }
                ////});
                ////done = true;
                this.Cursor = Cursors.WaitCursor;
                this.CanConnect = GheloBytes.IsConnectionOk();
                InitializeValidation();
                InitCadAutocomplete();
                this.Cursor = Cursors.Default;
            }
            
        }


        // methods
        private void InitializeValidation()
        {
            string validation = GheloBytes.GetSetting("validation", "enable", "value");
            btnValidate.Visible = (validation == "true");
        }
        private void InitCadAutocomplete()
        {
            //if (this.CanConnect)
            //{
            //    DataTable dt = GheloBytes.GetDataTable("SELECT DISTINCT [project_no] FROM [ref_type_table] ORDER BY [project_no]");
            //    dt.Rows.InsertAt(dt.NewRow(), 0);
            //}

            if (this.CanConnect)
            {
                AutoCompleteStringCollection source = new AutoCompleteStringCollection();

                DataTable dtAUTOCOMPLETE = GheloBytes.GetDataTable("SELECT DISTINCT [project_no] FROM [projects] ORDER BY [project_no]");
                foreach (DataRow row in dtAUTOCOMPLETE.Rows)
                {
                    source.Add(row["project_no"].ToString());
                }

                txtProjectNo.AutoCompleteCustomSource = source;
            }
        }
        private void InitializeMap()
        {
            Map map = new Map();
       
            // create base layer
            string connStr = "Data source=" + Environment.CurrentDirectory + @"\data\data.sqlite";
            SpatiaLite spatialLiteMUN = new SpatiaLite(connStr, "MUNICIPALITY", "Geometry", "PK_UID");
            SpatiaLite spatialLitePROV = new SpatiaLite(connStr, "province", "Geometry", "PK_UID");

            VectorLayer lyrPROV = new VectorLayer("lyrPROV", spatialLitePROV);
            lyrPROV.Style.Fill = new SolidBrush(Color.FromArgb(255, 84, 133, 64));
            lyrPROV.Style.EnableOutline = true;
            lyrPROV.Style.Outline.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            lyrPROV.Style.Outline = new Pen(Color.FromArgb(255, 81, 79, 51));
            lyrPROV.MinVisible = 1.5d;

            LabelLayer lblPROV = new LabelLayer("lblPROV");
            lblPROV.DataSource = lyrPROV.DataSource;
            lblPROV.LabelColumn = "prov";
            lblPROV.MinVisible = 1.5d; // show
            lblPROV.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            lblPROV.MultipartGeometryBehaviour = LabelLayer.MultipartGeometryBehaviourEnum.Largest;
            lblPROV.Style.Font = new Font("Segoe UI", 14.00f);
            lblPROV.Style.ForeColor = Color.FromArgb(200, 95, 92, 88);
            lblPROV.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            VectorLayer lyrMUN = new VectorLayer("lyrMUN", spatialLiteMUN);
            lyrMUN.Style.Fill = new SolidBrush(Color.FromArgb(255, 84, 133, 64));
            lyrMUN.Style.EnableOutline = true;
            lyrMUN.Style.Outline.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            lyrMUN.Style.Outline = new Pen(Color.FromArgb(255, 81, 79, 51));
            lyrMUN.MaxVisible = 1.5d;

            LabelLayer lblMUN = new LabelLayer("lblMUN");
            lblMUN.DataSource = lyrMUN.DataSource;
            lblMUN.LabelColumn = "NAME_2";
            lblMUN.MaxVisible = 1.5d; // show
            lblMUN.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            lblMUN.MultipartGeometryBehaviour = LabelLayer.MultipartGeometryBehaviourEnum.Largest;
            lblMUN.Style.Font = new Font("Segoe UI", 14.00f);
            lblMUN.Style.ForeColor = Color.FromArgb(200, 95, 92, 88);
            lblMUN.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        
            // create points layer
            VectorLayer lyrPOINTS = new VectorLayer("lyrPOINTS");
            lyrPOINTS.DataSource = new GeometryFeatureProvider(new FeatureDataTable());
            lyrPOINTS.Theme = new SharpMap.Rendering.Thematics.CustomTheme(ReferenceStyle);
          
            LabelLayer lblPOINTS = new LabelLayer("lblPOINTS");
            lblPOINTS.DataSource = lyrPOINTS.DataSource;
            lblPOINTS.LabelColumn = "REF_NAME";
            lblPOINTS.Style.Font = new Font("Segoe UI", 10.00f, FontStyle.Regular);
            lblPOINTS.Style.Offset = new PointF(8, 0);

            lblPOINTS.Style.HorizontalAlignment = SharpMap.Styles.LabelStyle.HorizontalAlignmentEnum.Center;
            lblPOINTS.Style.VerticalAlignment = SharpMap.Styles.LabelStyle.VerticalAlignmentEnum.Top;
            lblPOINTS.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            lblPOINTS.LabelFilter = SharpMap.Rendering.LabelCollisionDetection.ThoroughCollisionDetection;
            lblPOINTS.Style.CollisionDetection = true;
            lblPOINTS.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            

            // create selection layer
            GeometryFeatureProvider gpSELECTION = new GeometryFeatureProvider(fdtCANDIDATE);
            VectorLayer lyrSELECTION = new VectorLayer("lyrSELECTION", gpSELECTION);
            lyrSELECTION.Style.Symbol = global::Derivation.Properties.Resources.red;
            lyrSELECTION.Theme = new SharpMap.Rendering.Thematics.CustomTheme(SelectionStyle);

            LabelLayer lblSELECTION = new LabelLayer("lblSELECTION");
            lblSELECTION.DataSource = lyrSELECTION.DataSource;
            lblSELECTION.LabelColumn = "REF_NAME";
            lblSELECTION.Style.Font = new Font("Segoe UI", 10.00f, FontStyle.Regular);
            lblSELECTION.Style.Offset = new PointF(8, 0);
            lblSELECTION.Style.HorizontalAlignment = SharpMap.Styles.LabelStyle.HorizontalAlignmentEnum.Center;
            lblSELECTION.Style.VerticalAlignment = SharpMap.Styles.LabelStyle.VerticalAlignmentEnum.Top;
            lblSELECTION.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            lblSELECTION.LabelFilter = SharpMap.Rendering.LabelCollisionDetection.ThoroughCollisionDetection;
            lblSELECTION.Style.CollisionDetection = true;
            lblSELECTION.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            lblSELECTION.Theme = new SharpMap.Rendering.Thematics.CustomTheme(SelectionLabelStyle);


            // create PRS layer
            GeometryFeatureProvider gpPRS = new GeometryFeatureProvider(fdtPRS);
            VectorLayer lyrPRS = new VectorLayer("lyrPRS", gpPRS);
            lyrPRS.Theme = new SharpMap.Rendering.Thematics.CustomTheme(PRSStyle);
            lyrPRS.Enabled = false;

            LabelLayer lblPRS = new LabelLayer("lblPRS");
            lblPRS.DataSource = lyrPRS.DataSource;
            lblPRS.LabelColumn = "REF_NAME";
            lblPRS.Style.Font = new Font("Segoe UI", 10.00f, FontStyle.Regular);
            lblPRS.Style.Offset = new PointF(8, 0);
            lblPRS.Style.HorizontalAlignment = SharpMap.Styles.LabelStyle.HorizontalAlignmentEnum.Center;
            lblPRS.Style.VerticalAlignment = SharpMap.Styles.LabelStyle.VerticalAlignmentEnum.Bottom;
            lblPRS.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            lblPRS.LabelFilter = SharpMap.Rendering.LabelCollisionDetection.ThoroughCollisionDetection;
            lblPRS.Style.CollisionDetection = true;
            lblPRS.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            lblPRS.Theme = new SharpMap.Rendering.Thematics.CustomTheme(SelectionLabelStyle);
            lblPRS.Enabled = false;

            // add the layers to the map
            map.Layers.Add(lyrPROV);
            map.Layers.Add(lyrMUN);
            map.Layers.Add(lblMUN);
            map.Layers.Add(lyrPOINTS);
            map.Layers.Add(lblPOINTS);

            map.Layers.Add(lyrPRS);
            map.Layers.Add(lblPRS);

            map.Layers.Add(lyrSELECTION);
            map.Layers.Add(lblSELECTION);

            mapBox.Map = map;
            mapBox.Map.ZoomToExtents();
            mapBox.Refresh();
            
        }
        private void PlotRefPoints(string projectNo)
        {
            if (!this.CanConnect)
                return;


            // fetch zone using location info
            int zone = this.ZONE;

            FeatureDataTable fdtPOINTS = GheloBytes.GetFeatureDataTable(String.Format(SQL, projectNo));

            foreach (FeatureDataRow fdr in fdtPOINTS.Rows)
            {
                double[] point = new double[]{ Convert.ToDouble(fdr["OLD_EASTING"]), 
                                               Convert.ToDouble(fdr["OLD_NORTHING"]) };
                point = TransformPTM_WGS84(zone).MathTransform.Transform(point);

                string wkt = String.Format("POINT({0} {1})", point[0], point[1]);

                Geometry geom = Geometry.GeomFromText(wkt);
                fdr.Geometry = geom;
            }

            
            //VectorLayer lyrPHIL = new VectorLayer();
            //VectorLayer lyrSEL = new VectorLayer();

            //ShapeFile myShapeFile = new ShapeFile("filename ng shapefile");

            //lyrPHIL.DataSource = myShapeFile;
            

            

            VectorLayer lyrPOINTS = mapBox.Map.Layers["lyrPOINTS"] as VectorLayer;
            lyrPOINTS.DataSource = new GeometryFeatureProvider(fdtPOINTS);

            LabelLayer lblPOINTS = mapBox.Map.Layers["lblPOINTS"] as LabelLayer;
            lblPOINTS.DataSource = lyrPOINTS.DataSource;


            if (fdtPOINTS.Rows.Count > 1)
                mapBox.Map.ZoomToBox(lyrPOINTS.Envelope.Grow(0.02f));
            else if (fdtPOINTS.Rows.Count == 1)
                mapBox.Map.ZoomToBox(lyrPOINTS.Envelope.Grow(1));

            UpdatePRS();
            mapBox.Refresh();
            
        }
        private void ClearSelection()
        {
            fdtCANDIDATE.Clear();
        }
        private void PostFilterExistingFeatureDataTable(FeatureDataTable featureDataTable, Geometry testGeometry)
        {
            //first we create a new GeometryFactory.
            GisSharpBlog.NetTopologySuite.Geometries.GeometryFactory geometryFactory = new GisSharpBlog.NetTopologySuite.Geometries.GeometryFactory();


            //then we convert the testGeometry into the equivalent NTS geometry
            GisSharpBlog.NetTopologySuite.Geometries.Geometry testGeometryAsNtsGeom =
                GeometryConverter.ToNTSGeometry(testGeometry, geometryFactory);


            //now we loop backwards through the FeatureDataTable 
            for (int i = featureDataTable.Rows.Count - 1; i > -1; i--)
            {
                //we get each row
                FeatureDataRow featureDataRow = featureDataTable.Rows[i] as FeatureDataRow;
                //and get the rows' geometry
                Geometry compareGeometry = featureDataRow.Geometry;
                //convert the rows' geometry into the equivalent NTS geometry
                GisSharpBlog.NetTopologySuite.Geometries.Geometry compareGeometryAsNts =
                    GeometryConverter.ToNTSGeometry(compareGeometry, geometryFactory);
                //now test for intesection (note other operations such as Contains, Within, Disjoint etc can all be done the same way)
                bool intersects = testGeometryAsNtsGeom.Intersects(compareGeometryAsNts);

                //if it doesn't intersect remove the row.
                if (!intersects)
                    featureDataTable.Rows.RemoveAt(i);
            }
        }

        private void InitPRSTable()
        {
            fdtPRS = new FeatureDataTable();
            fdtPRS.Columns.Add("NO", typeof(int));
            fdtPRS.Columns.Add("REF_NAME", typeof(string));

            fdtPRS.Columns.Add("IS_USER_ADDED", typeof(bool));
            fdtPRS.Columns.Add("IS_SELECTED", typeof(bool));

            fdtPRS.Columns["IS_SELECTED"].DefaultValue = true;
        }

        private void InitCandidateTable()
        {
            fdtCANDIDATE = new FeatureDataTable();
            fdtCANDIDATE.Columns.Add("NO", typeof(int));
            fdtCANDIDATE.Columns.Add("REF_NAME", typeof(string));
            fdtCANDIDATE.Columns.Add("OLD_NORTHING", typeof(double));
            fdtCANDIDATE.Columns.Add("OLD_EASTING", typeof(double));
            fdtCANDIDATE.Columns.Add("NEW_NORTHING", typeof(double));
            fdtCANDIDATE.Columns.Add("NEW_EASTING", typeof(double));
            fdtCANDIDATE.Columns.Add("E_BAR", typeof(double));
            fdtCANDIDATE.Columns.Add("N_BAR", typeof(double));
            fdtCANDIDATE.Columns.Add("X_BAR", typeof(double));
            fdtCANDIDATE.Columns.Add("Y_BAR", typeof(double));
            fdtCANDIDATE.Columns.Add("XE_BAR", typeof(double));
            fdtCANDIDATE.Columns.Add("YN_BAR", typeof(double));
            fdtCANDIDATE.Columns.Add("YE_BAR", typeof(double));
            fdtCANDIDATE.Columns.Add("XN_BAR", typeof(double));
            fdtCANDIDATE.Columns.Add("XX_BAR", typeof(double));
            fdtCANDIDATE.Columns.Add("YY_BAR", typeof(double));
            fdtCANDIDATE.Columns.Add("ADJUSTED_EASTING", typeof(double));
            fdtCANDIDATE.Columns.Add("ADJUSTED_NORTHING", typeof(double));
            fdtCANDIDATE.Columns.Add("RESIDUAL_VE", typeof(double));
            fdtCANDIDATE.Columns.Add("RESIDUAL_VN", typeof(double));
            fdtCANDIDATE.Columns.Add("VEVE", typeof(double));
            fdtCANDIDATE.Columns.Add("VNVN", typeof(double));
            fdtCANDIDATE.Columns.Add("IS_USER_ADDED", typeof(bool));
            fdtCANDIDATE.Columns.Add("IS_SELECTED", typeof(bool));

            fdtCANDIDATE.Columns["IS_SELECTED"].DefaultValue = true;
            fdtCANDIDATE.Columns["IS_USER_ADDED"].DefaultValue = false;


            fdtCANDIDATE.RowDeleted += delegate
            {
                fdtCANDIDATE.AcceptChanges();
                int i = 0;
                foreach (FeatureDataRow row in fdtCANDIDATE.Rows)
                {
                    i++;
                    row["NO"] = i;
                }
                
            };
            fdtCANDIDATE.TableNewRow += delegate(object sender, DataTableNewRowEventArgs e)
            {
                e.Row["NO"] = e.Row.Table.Rows.Count+1;
            };
            fdtCANDIDATE.ColumnChanged += delegate(object sender, DataColumnChangeEventArgs e)
            {
                if (!this.HasChanged)
                {
                    UpdateChangeFlag(true);
                    UpdatePRS();
                }
            };

            

            gvCoordinates.DataSource = fdtCANDIDATE;



        }


        private void GetProjectDetails(string projectNo)
        {
            // test if project no exist in database

            if (Convert.ToInt32(GheloBytes.GetData(String.Format("SELECT COUNT(*) FROM [projects] WHERE [Project_No] = '{0}'", projectNo))) == 0)
            {
                MessageBox.Show(String.Format("{0} does not exist in the database.",projectNo));
                return;
            }
            


            string sql;

            this.PROJECT_NO = projectNo;

            sql = String.Format("SELECT [Region] FROM [projects] WHERE [Project_No]  = '{0}'", projectNo);
            this.REGION = GheloBytes.GetData(sql).ToString().ToUpper();

            sql = String.Format("SELECT [Province] FROM [projects] WHERE [Project_No]  = '{0}'", projectNo);
            this.PROVINCE = GheloBytes.GetData(sql).ToString().ToUpper();

            sql = String.Format("SELECT [Municipality] FROM [projects] WHERE [Project_No]  = '{0}'", projectNo);
            this.MUNICIPALITY = GheloBytes.GetData(sql).ToString().ToUpper();

            sql = String.Format("SELECT [Zone] FROM [PTMZone] WHERE UPPER([Region]) = '{0}' AND UPPER([Province]) = '{1}' AND UPPER([Municipality]) = '{2}'", REGION, PROVINCE, MUNICIPALITY);
            this.ZONE = Convert.ToInt32(GheloBytes.GetData(sql));


            cmbZone.SelectedValue = this.ZONE;

            // define location
            lblLocation.Text = String.Format("{0}, {1}, {2}", this.REGION.ToUpperInvariant(),this.PROVINCE.ToUpperInvariant(), this.MUNICIPALITY.ToUpperInvariant());


            // get points
            PlotRefPoints(this.PROJECT_NO);

            



        }
        private void Initialize()
        {
            // prepare zones
            DataTable dtZONES = new DataTable();
            dtZONES.Columns.Add("DisplayMember", typeof(string));
            dtZONES.Columns.Add("ValueMember", typeof(int));
            dtZONES.Rows.Add(new object[] { "", 0});
            dtZONES.Rows.Add(new object[] { "1", 1 });
            dtZONES.Rows.Add(new object[] { "1A", 6 });
            dtZONES.Rows.Add(new object[] { "2", 2 });
            dtZONES.Rows.Add(new object[] { "3", 3 });
            dtZONES.Rows.Add(new object[] { "4", 4 });
            dtZONES.Rows.Add(new object[] { "5", 5 });

            cmbZone.DisplayMember = "DisplayMember";
            cmbZone.ValueMember = "ValueMember";
            cmbZone.DataSource = dtZONES;
            cmbZone.SelectedValueChanged += delegate
            {
                this.ZONE = Convert.ToInt32(cmbZone.SelectedValue);
                UpdateChangeFlag(true);
            };
        }
        private bool Save(bool lockFile)
        {
            string path;

            if (this.FileLocation == "")
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.DefaultExt = "*.prs";
                dialog.Filter = "PRS92|*.prs";
                dialog.ShowDialog();

                path = dialog.FileName;

                if (path == "")
                    return false;

            }
            else
            {
                path = this.FileLocation;
            }


            this.FileLocation = path;

            XmlTextWriter w = new XmlTextWriter(path, null);
            w.Formatting = Formatting.Indented;
            w.WriteStartDocument();
            w.WriteStartElement("prs92");
            w.WriteStartElement("derivation");

            {   // project details
                w.WriteStartElement("projectNo");
                w.WriteString(this.PROJECT_NO);
                w.WriteEndElement(); // projectNo

                w.WriteStartElement("zone");
                w.WriteString(this.ZONE.ToString());
                w.WriteEndElement(); // zone

                w.WriteStartElement("location");
                w.WriteString(lblLocation.Text);
                w.WriteEndElement(); // location

                w.WriteStartElement("municipality");
                w.WriteString(this.MUNICIPALITY);
                w.WriteEndElement(); // municipality

                w.WriteStartElement("province");
                w.WriteString(this.PROVINCE);
                w.WriteEndElement(); // province

                w.WriteStartElement("region");
                w.WriteString(this.REGION);
                w.WriteEndElement(); // region

            }

            {   // computed parameters
                w.WriteStartElement("a");
                w.WriteString(txtP_a.Text);
                w.WriteEndElement(); // a

                w.WriteStartElement("b");
                w.WriteString(txtP_b.Text);
                w.WriteEndElement(); // b

                w.WriteStartElement("Ce");
                w.WriteString(txtP_Ce.Text);
                w.WriteEndElement(); // Ce

                w.WriteStartElement("Cn");
                w.WriteString(txtP_Cn.Text);
                w.WriteEndElement(); // Cn

                w.WriteStartElement("PointCount");
                w.WriteString(txtPointCount.Text);
                w.WriteEndElement(); // PointCount

                w.WriteStartElement("SumVeVe");
                w.WriteString(txtSumVeVe.Text);
                w.WriteEndElement(); // SumVeVe

                w.WriteStartElement("SumVnVn");
                w.WriteString(txtSumVnVn.Text);
                w.WriteEndElement(); // SumVnVn

                w.WriteStartElement("Variance");
                w.WriteString(txtVariance.Text);
                w.WriteEndElement(); // Variance
            }

            {   // table

                w.WriteStartElement("Candidates");

                foreach (FeatureDataRow fdr in fdtCANDIDATE.Rows)
                {
                    w.WriteStartElement("Point");
                    foreach (DataColumn col in fdtCANDIDATE.Columns)
                    {
                        w.WriteStartElement(col.ColumnName);
                        w.WriteAttributeString("DataType", col.DataType.Name);
                        object data = fdr[col];
                        if (data == DBNull.Value || data == null)
                            w.WriteString("");
                        else
                            w.WriteString(fdr[col].ToString());
                        w.WriteEndElement(); // ColumnName
                    }
                    w.WriteEndElement(); // point
                }
                w.WriteEndElement(); // Candidates
            }

            { // file locking
                string hash = (lockFile ? System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile("NAMRIA" + this.PROJECT_NO, "SHA1") : String.Empty);
                w.WriteStartElement("signature");
                w.WriteString(hash);
                w.WriteEndElement(); // signature
            }

            { // save current map view
                w.WriteStartElement("mapView");
                    w.WriteStartElement("zoom");
                    w.WriteString(mapBox.Map.Zoom.ToString());
                    w.WriteEndElement();
                    w.WriteStartElement("center");
                    w.WriteString(mapBox.Map.Center.ToString());
                    w.WriteEndElement();
                w.WriteEndElement();
            }


            w.WriteEndElement(); // derivation
            w.WriteEndElement(); // prs92
            w.WriteEndDocument();
            w.Close();

            return true;
        }

        
        private void Read()
        {
            
            VectorLayer lyrSELECTION = mapBox.Map.Layers["lyrSELECTION"] as SharpMap.Layers.VectorLayer;

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.DefaultExt = "*.prs";
            dialog.Filter = "PRS92|*.prs;*.lck";

            dialog.ShowDialog();

            string path = dialog.FileName;

            if (path == "")
                return;

            //string path = @"C:\Users\user\Desktop\CAD_BACARRA.prs";

            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            // check if file is locked or not
            bool isLocked = (doc.SelectSingleNode("prs92/derivation/signature").InnerText != String.Empty);
            // if locked, validate signature
            if (isLocked)
            {
                string project_no = doc.SelectSingleNode("prs92/derivation/projectNo").InnerText;
                string hash = doc.SelectSingleNode("prs92/derivation/signature").InnerText;
                string computedHash = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile("NAMRIA" + project_no, "SHA1");
                if(hash != computedHash)
                {
                    MessageBox.Show("The file is marked as validated but \ndoes not contain a valid signature.","Error opening file!");
                    return;
                }

            }


            // load properties
            this.PROJECT_NO = doc.SelectSingleNode("prs92/derivation/projectNo").InnerText;
            txtProjectNo.Text = this.PROJECT_NO;
            this.ZONE = Convert.ToInt32(doc.SelectSingleNode("prs92/derivation/zone").InnerText);
            cmbZone.SelectedValue = this.ZONE;
            lblLocation.Text = doc.SelectSingleNode("prs92/derivation/location").InnerText;
            this.MUNICIPALITY = doc.SelectSingleNode("prs92/derivation/municipality").InnerText;
            this.PROVINCE = doc.SelectSingleNode("prs92/derivation/province").InnerText;
            this.REGION = doc.SelectSingleNode("prs92/derivation/region").InnerText;
            this.IsLocked = (doc.SelectSingleNode("prs92/derivation/signature").InnerText != String.Empty);

            
            if(doc.SelectSingleNode("prs92/derivation/a").InnerText != string.Empty)
                param.a = Convert.ToDouble(doc.SelectSingleNode("prs92/derivation/a").InnerText);
            if (doc.SelectSingleNode("prs92/derivation/b").InnerText != string.Empty)
                param.b = Convert.ToDouble(doc.SelectSingleNode("prs92/derivation/a").InnerText);
            if (doc.SelectSingleNode("prs92/derivation/Ce").InnerText != string.Empty)
                param.Ce = Convert.ToDouble(doc.SelectSingleNode("prs92/derivation/Ce").InnerText);
            if (doc.SelectSingleNode("prs92/derivation/Cn").InnerText != string.Empty)
                param.Cn = Convert.ToDouble(doc.SelectSingleNode("prs92/derivation/Cn").InnerText);

            txtP_a.Text = doc.SelectSingleNode("prs92/derivation/a").InnerText;
            txtP_b.Text = doc.SelectSingleNode("prs92/derivation/b").InnerText;
            txtP_Ce.Text = doc.SelectSingleNode("prs92/derivation/Ce").InnerText;
            txtP_Cn.Text = doc.SelectSingleNode("prs92/derivation/Cn").InnerText;

            

            txtPointCount.Text = doc.SelectSingleNode("prs92/derivation/PointCount").InnerText;
            txtSumVeVe.Text = doc.SelectSingleNode("prs92/derivation/SumVeVe").InnerText;
            txtSumVnVn.Text = doc.SelectSingleNode("prs92/derivation/SumVnVn").InnerText;
            txtVariance.Text = doc.SelectSingleNode("prs92/derivation/Variance").InnerText;

            this.FileLocation = path;
            //this.Text = path;

            // load tables
            fdtCANDIDATE.Clear();

           

            XmlNode candidates = doc.SelectSingleNode("prs92/derivation/Candidates");
            foreach (XmlNode point in candidates.ChildNodes)
            {
                FeatureDataRow row = fdtCANDIDATE.NewRow();

                foreach (XmlNode col in point.ChildNodes)
                {
                    string value = col.InnerText;
                    string type = col.Attributes["DataType"].Value;
                    object newValue = DBNull.Value;
                    if (value != "")
                    {
                        switch (type)
                        {
                            case "Int32":
                                newValue = Convert.ToInt32(value);
                                break;
                            case "String":
                                newValue = value.ToString();
                                break;
                            case "Double":
                                newValue = Convert.ToDouble(value);
                                break;
                            case "Boolean":
                                newValue = Convert.ToBoolean(value);
                                break;
                        }
                    }
                    row[col.Name] = newValue;   

                }

                // process geometry
                if (row["OLD_EASTING"] != DBNull.Value & row["OLD_NORTHING"] != DBNull.Value)
                {
                    int zone = this.ZONE;
                    double[] coord = new double[]{ Convert.ToDouble(row["OLD_EASTING"]), 
                                                   Convert.ToDouble(row["OLD_NORTHING"]) };
                    
                    coord = TransformPTM_WGS84(zone).MathTransform.Transform(coord);
                    
                    string wkt = String.Format("POINT({0} {1})", coord[0], coord[1]);
                    
                    Geometry geom = Geometry.GeomFromText(wkt);
                    row.Geometry = geom;
                }

                fdtCANDIDATE.AddRow(row);

            }

            // set map view
            ////double zoom = Convert.ToDouble(doc.SelectSingleNode("prs92/derivation/mapView/zoom").InnerText);
            ////SharpMap.Geometries.Point center = Geometry.GeomFromText(doc.SelectSingleNode("prs92/derivation/mapView/center").InnerText) as SharpMap.Geometries.Point;

            ////mapBox.Map.Zoom = zoom;
            ////mapBox.Map.Center = center;

            //VectorLayer lyrSELECTION = mapBox.Map.Layers["lyrSELECTION"] as SharpMap.Layers.VectorLayer;

            if (fdtCANDIDATE.Rows.Count > 1)
                mapBox.Map.ZoomToBox(lyrSELECTION.Envelope.Grow(0.02f));
            else if (fdtCANDIDATE.Rows.Count == 1)
                mapBox.Map.ZoomToBox(lyrSELECTION.Envelope.Grow(1));
            
       
            // PRS
            UpdatePRS();

            mapBox.Refresh();

            

        }


        private void New()
        {
            txtProjectNo.Clear();
            cmbZone.SelectedValue = 0;
            lblLocation.Text = "";

            this.PROJECT_NO = "";
            this.ZONE = 0;
            this.FileLocation = "";
            this.IsLocked = false;
            param = new DerivedParameter();

            txtP_a.Clear();
            txtP_b.Clear();
            txtP_Ce.Clear();
            txtP_Cn.Clear();

            txtPointCount.Clear();
            txtSumVeVe.Clear();
            txtSumVnVn.Clear();
            txtVariance.Clear();

            fdtCANDIDATE.Clear();

            UpdateChangeFlag(false);

            (mapBox.Map.Layers["lyrPOINTS"] as VectorLayer).DataSource = new GeometryFeatureProvider(new FeatureDataTable());
            (mapBox.Map.Layers["lblPOINTS"] as LabelLayer).DataSource = (mapBox.Map.Layers["lyrPOINTS"] as VectorLayer).DataSource;

            mapBox.Refresh();

        }
        private void UpdateChangeFlag(bool hasChanged)
        {
            this.HasChanged = hasChanged;
            if(hasChanged)
            {
                this.Text = String.Format("{0} :: {1}*",FORM_TITLE, this.FileLocation);
                
            }else{
                if (this.FileLocation != "")
                    this.Text = String.Format("{0} :: {1}", FORM_TITLE, this.FileLocation);
                else
                    this.Text = String.Format("{0}", FORM_TITLE);
                
            }
            
        }
        private void PreparePointAutocomplete(Control ctrl)
        {
            string refNameList = "";
            foreach (FeatureDataRow row in fdtCANDIDATE)
            {
                refNameList += String.Format("'{0}',", row["REF_NAME"]);
            }
            refNameList += "''";
            string sql = String.Format(@"SELECT RTRIM([ref_type]) + ' ' + RTRIM([ref_type_no]) AS [REF_NAME]
                                     FROM  [ref_type_table] 
                                     WHERE [project_no] = '{0}' AND 
                                           NOT [true_easting] IS NULL AND 
                                           NOT [true_northing] IS NULL AND 
                                           NOT [ptm_prs92_easting] IS NULL AND
                                           NOT [ptm_prs92_northing] IS NULL AND
                                           NOT RTRIM([ref_type]) + ' ' + RTRIM([ref_type_no]) IN ({1})", this.PROJECT_NO, refNameList);

            AutoCompleteStringCollection source = new AutoCompleteStringCollection();

            DataTable dtAUTOCOMPLETE = GheloBytes.GetDataTable(sql);
            foreach (DataRow row in dtAUTOCOMPLETE.Rows)
            {
                source.Add(row["REF_NAME"].ToString());
            }

            TextBox txt_REF_NAME = ctrl as TextBox;
            txt_REF_NAME.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_REF_NAME.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_REF_NAME.AutoCompleteCustomSource = source;
            
            
            txt_REF_NAME.Leave -= new EventHandler(txtREF_NAME_Leave);
            txt_REF_NAME.Leave += new EventHandler(txtREF_NAME_Leave);

        }
        private void PrepareReplotPoint(Control ctrl, int rowIndex)
        {
            TextBox txtCOORD = ctrl as TextBox;
            txtCOORD.Tag = rowIndex;
            txtCOORD.Leave -= new EventHandler(txtCOORD_Leave);
            txtCOORD.Leave += new EventHandler(txtCOORD_Leave);
        }
        private void ApplyFileLocking()
        {
            txtProjectNo.Enabled = (!this.IsLocked);
            cmbZone.Enabled = (!this.IsLocked);
            gvCoordinates.ReadOnly = this.IsLocked;

            btnSave.Enabled = (!this.IsLocked);
            btnCompute.Visible = (!this.IsLocked);
            btnValidate.Visible = (!this.IsLocked);
            btnAddPoint.Enabled = (this.IsLocked ? ButtonEnabled.False : ButtonEnabled.True);

            btnUpload.Visible = this.IsLocked;

            if(this.IsLocked)
                this.Text = this.Text + " (LOCKED)";
        }
  
        // functions
        private static ICoordinateTransformation TransformPTM_WGS84(int ptmZone)
        {
            ProjNet.CoordinateSystems.Transformations.CoordinateTransformationFactory ctFac = new ProjNet.CoordinateSystems.Transformations.CoordinateTransformationFactory();
            return ctFac.CreateFromCoordinateSystems(CreatePTM(ptmZone), CreateWGS84());
        }
        private static ICoordinateSystem CreatePTM(int zone)
        {
            ProjNet.CoordinateSystems.CoordinateSystemFactory cFac = new ProjNet.CoordinateSystems.CoordinateSystemFactory();

            switch (zone)
            {
                case 1:
                    return cFac.CreateFromWkt(PTM_ZONE1);
                case 2:
                    return cFac.CreateFromWkt(PTM_ZONE2);
                case 3:
                    return cFac.CreateFromWkt(PTM_ZONE3);
                case 4:
                    return cFac.CreateFromWkt(PTM_ZONE4);
                case 5:
                    return cFac.CreateFromWkt(PTM_ZONE5);
                case 6:
                    return cFac.CreateFromWkt(PTM_ZONE1A);
            }
            return null;
        }
        private static ICoordinateSystem CreateWGS84()
        {
            ProjNet.CoordinateSystems.CoordinateSystemFactory cFac = new ProjNet.CoordinateSystems.CoordinateSystemFactory();
            return cFac.CreateFromWkt(WGS84);
        }
        private SharpMap.Styles.VectorStyle SelectionStyle(SharpMap.Data.FeatureDataRow row)
        {
            SharpMap.Styles.VectorStyle style = new SharpMap.Styles.VectorStyle();
            bool selected = Convert.ToBoolean(row["IS_SELECTED"]);
            if (selected)
                style.Symbol = global::Derivation.Properties.Resources.old;
            else
                style.Symbol = global::Derivation.Properties.Resources.old_gray; ;

            style.SymbolScale = 0.95f;
            return style;

        }
        private SharpMap.Styles.VectorStyle PRSStyle(SharpMap.Data.FeatureDataRow row)
        {
            SharpMap.Styles.VectorStyle style = new SharpMap.Styles.VectorStyle();
            bool selected = Convert.ToBoolean(row["IS_SELECTED"]);
            if (selected)
                style.Symbol = global::Derivation.Properties.Resources.prs;
            else
                style.Symbol = global::Derivation.Properties.Resources.prs_gray;

            style.SymbolScale = 0.95f;
            return style;

        }
        private SharpMap.Styles.VectorStyle ReferenceStyle(SharpMap.Data.FeatureDataRow row)
        {
            SharpMap.Styles.VectorStyle style = new SharpMap.Styles.VectorStyle();
            bool isObserved = (row["NEW_NORTHING"] != DBNull.Value & row["NEW_EASTING"] != DBNull.Value);
            if (isObserved)
                style.Symbol = global::Derivation.Properties.Resources.blue;
            else
                style.Symbol = global::Derivation.Properties.Resources.gray;

            return style;
        }
        private SharpMap.Styles.LabelStyle SelectionLabelStyle(SharpMap.Data.FeatureDataRow row)
        {
            SharpMap.Styles.LabelStyle style = new SharpMap.Styles.LabelStyle();
            bool isUserAdded = Convert.ToBoolean(row["IS_USER_ADDED"]);

            style.Font = new Font("Segoe UI", 10.00f, FontStyle.Regular);
            style.Offset = new PointF(8, 0);

            style.HorizontalAlignment = SharpMap.Styles.LabelStyle.HorizontalAlignmentEnum.Center;
            style.VerticalAlignment = SharpMap.Styles.LabelStyle.VerticalAlignmentEnum.Top;
            style.CollisionDetection = true;

            
            if (isUserAdded | !this.CanConnect)
                style.ForeColor = Color.Black;
            else
                style.ForeColor = Color.Transparent;

            return style;
        }
        private DerivedParameter ComputeParameters(FeatureDataTable dt)
        {
            int POINT_COUNT = Convert.ToInt32(dt.Compute("COUNT(REF_NAME)", "IS_SELECTED=True"));
            //int POINT_COUNT = dt.Rows.Count;


            if (POINT_COUNT < 3)
                throw new Exception("Too few candidate points.");

            double SUM_NEW_EASTING = Convert.ToDouble(dt.Compute("SUM(NEW_EASTING)", "IS_SELECTED=True"));  //U13
            double SUM_OLD_EASTING = Convert.ToDouble(dt.Compute("SUM(OLD_EASTING)", "IS_SELECTED=True"));   //U15

            // compute E_BAR (I27)
            //dt.Columns.Add("E_BAR", typeof(double));

            //dt.DefaultView.Sort = "NO ASC";

            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToBoolean(row["IS_SELECTED"]))
                {
                    double E_BAR = Convert.ToDouble(row["NEW_EASTING"]) - (SUM_NEW_EASTING / POINT_COUNT);
                    row["E_BAR"] = E_BAR;
                }

            }


            double SUM_NEW_NORTHING = Convert.ToDouble(dt.Compute("SUM(NEW_NORTHING)", "IS_SELECTED=True")); //U14
            double SUM_OLD_NORTHING = Convert.ToDouble(dt.Compute("SUM(OLD_NORTHING)", "IS_SELECTED=True")); //U16


            // compute N_BAR (J27)
            //dt.Columns.Add("N_BAR", typeof(double));
            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToBoolean(row["IS_SELECTED"]))
                {
                    double N_BAR = Convert.ToDouble(row["NEW_NORTHING"]) - (SUM_NEW_NORTHING / POINT_COUNT);
                    row["N_BAR"] = N_BAR;
                }
            }
            // compute X_BAR (K27)
            //dt.Columns.Add("X_BAR", typeof(double));
            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToBoolean(row["IS_SELECTED"]))
                {
                    double X_BAR = Convert.ToDouble(row["OLD_EASTING"]) - (SUM_OLD_EASTING / POINT_COUNT);
                    row["X_BAR"] = X_BAR;
                }
            }
            // compute Y_BAR (L27)
            //dt.Columns.Add("Y_BAR", typeof(double));
            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToBoolean(row["IS_SELECTED"]))
                {
                    double Y_BAR = Convert.ToDouble(row["OLD_NORTHING"]) - (SUM_OLD_NORTHING / POINT_COUNT);
                    row["Y_BAR"] = Y_BAR;
                }
            }
            // compute X_BAR*E_BAR (M27)
            //dt.Columns.Add("XE_BAR", typeof(double));
            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToBoolean(row["IS_SELECTED"]))
                {
                    double XE_BAR = Convert.ToDouble(row["X_BAR"]) * Convert.ToDouble(row["E_BAR"]);
                    row["XE_BAR"] = XE_BAR;
                }
            }
            // compute Y_BAR*N_BAR (N27)
            //dt.Columns.Add("YN_BAR", typeof(double));
            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToBoolean(row["IS_SELECTED"]))
                {
                    double YN_BAR = Convert.ToDouble(row["Y_BAR"]) * Convert.ToDouble(row["N_BAR"]);
                    row["YN_BAR"] = YN_BAR;
                }
            }
            // compute Y_BAR*E_BAR (O27)
            //dt.Columns.Add("YE_BAR", typeof(double));
            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToBoolean(row["IS_SELECTED"]))
                {
                    double YE_BAR = Convert.ToDouble(row["Y_BAR"]) * Convert.ToDouble(row["E_BAR"]);
                    row["YE_BAR"] = YE_BAR;
                }
            }
            // compute X_BAR*N_BAR (P27)
            //dt.Columns.Add("XN_BAR", typeof(double));
            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToBoolean(row["IS_SELECTED"]))
                {
                    double XN_BAR = Convert.ToDouble(row["X_BAR"]) * Convert.ToDouble(row["N_BAR"]);
                    row["XN_BAR"] = XN_BAR;
                }
            }
            // compute X_BAR*X_BAR (Q27)
            //dt.Columns.Add("XX_BAR", typeof(double));
            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToBoolean(row["IS_SELECTED"]))
                {
                    double XX_BAR = Convert.ToDouble(row["X_BAR"]) * Convert.ToDouble(row["X_BAR"]);
                    row["XX_BAR"] = XX_BAR;
                }
            }
            // compute Y_BAR*Y_BAR (R27)
            //dt.Columns.Add("YY_BAR", typeof(double));
            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToBoolean(row["IS_SELECTED"]))
                {
                    double YY_BAR = Convert.ToDouble(row["Y_BAR"]) * Convert.ToDouble(row["Y_BAR"]);
                    row["YY_BAR"] = YY_BAR;
                }
            }

            double SUM_XE_BAR = Convert.ToDouble(dt.Compute("SUM(XE_BAR)", "IS_SELECTED=True"));   //U17
            double SUM_YN_BAR = Convert.ToDouble(dt.Compute("SUM(YN_BAR)", "IS_SELECTED=True"));   //U18

            double SUM_XX_BAR = Convert.ToDouble(dt.Compute("SUM(XX_BAR)", "IS_SELECTED=True"));   //U21
            double SUM_YY_BAR = Convert.ToDouble(dt.Compute("SUM(YY_BAR)", "IS_SELECTED=True"));   //U22

            double SUM_YE_BAR = Convert.ToDouble(dt.Compute("SUM(YE_BAR)", "IS_SELECTED=True"));   //U19
            double SUM_XN_BAR = Convert.ToDouble(dt.Compute("SUM(XN_BAR)", "IS_SELECTED=True"));   //U20


            // PARAMETERS
            double a = (SUM_XE_BAR + SUM_YN_BAR) / (SUM_XX_BAR + SUM_YY_BAR);   //C13
            double b = (SUM_YE_BAR - SUM_XN_BAR) / (SUM_XX_BAR + SUM_YY_BAR);   //C14
            double Ce = SUM_NEW_EASTING / POINT_COUNT - a * SUM_OLD_EASTING / POINT_COUNT - b * SUM_OLD_NORTHING / POINT_COUNT;     //C15
            double Cn = SUM_NEW_NORTHING / POINT_COUNT + b * SUM_OLD_EASTING / POINT_COUNT - a * SUM_OLD_NORTHING / POINT_COUNT;    //C16

            // compute ADJUSTED_NORTHING, ADJUSTED_EASTING, RESIDUAL_VE, RESIDUAL_VN (S27,T27,U27,V27)
            //dt.Columns.Add("ADJUSTED_EASTING", typeof(double));
            //dt.Columns.Add("ADJUSTED_NORTHING", typeof(double));
            //dt.Columns.Add("RESIDUAL_VE", typeof(double));
            //dt.Columns.Add("RESIDUAL_VN", typeof(double));
            //dt.Columns.Add("VEVE", typeof(double));
            //dt.Columns.Add("VNVN", typeof(double));
            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToBoolean(row["IS_SELECTED"]))
                {
                    double ADJUSTED_EASTING = a * Convert.ToDouble(row["OLD_EASTING"]) + b * Convert.ToDouble(row["OLD_NORTHING"]) + Ce;
                    double ADJUSTED_NORTHING = -b * Convert.ToDouble(row["OLD_EASTING"]) + a * Convert.ToDouble(row["OLD_NORTHING"]) + Cn;
                    double RESIDUAL_VE = ADJUSTED_EASTING - Convert.ToDouble(row["NEW_EASTING"]);
                    double RESIDUAL_VN = ADJUSTED_NORTHING - Convert.ToDouble(row["NEW_NORTHING"]); ;
                    row["ADJUSTED_EASTING"] = ADJUSTED_EASTING;
                    row["ADJUSTED_NORTHING"] = ADJUSTED_NORTHING;
                    row["RESIDUAL_VE"] = RESIDUAL_VE;
                    row["RESIDUAL_VN"] = RESIDUAL_VN;
                    row["VEVE"] = Math.Pow(RESIDUAL_VE, 2);
                    row["VNVN"] = Math.Pow(RESIDUAL_VN, 2);
                }
            }

            // ACCURACY STANDARDS
            double SUM_VeVe = Convert.ToDouble(dt.Compute("SUM(VEVE)", "IS_SELECTED=True"));    //C19
            double SUM_VnVn = Convert.ToDouble(dt.Compute("SUM(VNVN)", "IS_SELECTED=True"));    //C20
            double VARIANCE = Math.Sqrt((SUM_VeVe + SUM_VnVn) / (2 * (POINT_COUNT - 2))); //C22


            //txtP_a.Text = String.Format("{0:N6}", a);
            //txtP_b.Text = String.Format("{0:N6}", b);
            //txtP_Ce.Text = String.Format("{0:N6}", Ce);
            //txtP_Cn.Text = String.Format("{0:N6}", Cn);


            //txtSumVeVe.Text = String.Format("{0:N6}", SUM_VeVe);
            //txtSumVnVn.Text = String.Format("{0:N6}", SUM_VnVn);
            //txtVariance.Text = String.Format("{0:N6}", VARIANCE);

            DerivedParameter param = new DerivedParameter();
            param.a = a;
            param.b = b;
            param.Ce = Ce;
            param.Cn = Cn;
            param.VeVeSum = SUM_VeVe;
            param.VnVnSum = SUM_VnVn;
            param.Variance = VARIANCE;
            param.Table = dt;
            param.PointCount = POINT_COUNT;

            return param;

        }
        private Map CloneMap(Size size, Map map)
        {
            Map tempMap = new Map(size);
            foreach (ILayer layer in map.Layers)
            {
                if (layer is VectorLayer)
                    tempMap.Layers.Add((layer as VectorLayer).CloneLayer());
                else if (layer is LabelLayer)
                    tempMap.Layers.Add((layer as LabelLayer).CloneLayer());
            }
            tempMap.Center = map.Center;
            tempMap.Zoom = map.Zoom;
            return tempMap;
        }
        private byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private void kryptonHeader1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnToggleProjectPanel_Click(object sender, EventArgs e)
        {
            if (btnToggleProjectPanel.Type == PaletteButtonSpecStyle.RibbonMinimize)
            {
                btnToggleProjectPanel.Type = PaletteButtonSpecStyle.RibbonExpand;
                pnlFilterContainer.Hide();
            }
            else
            {
                btnToggleProjectPanel.Type = PaletteButtonSpecStyle.RibbonMinimize;
                pnlFilterContainer.Show();
            }
        }

        private void btnToggleParametersPanel_Click(object sender, EventArgs e)
        {
            if (btnToggleParametersPanel.Type == PaletteButtonSpecStyle.RibbonMinimize)
            {
                btnToggleParametersPanel.Type = PaletteButtonSpecStyle.RibbonExpand;
                pnlComputationResult.Hide();
            }
            else
            {
                btnToggleParametersPanel.Type = PaletteButtonSpecStyle.RibbonMinimize;
                pnlComputationResult.Show();
            }
        }



       
        private void UpdatePRS()
        {
            int zone = this.ZONE;

            fdtPRS.Clear();
            foreach (FeatureDataRow row in fdtCANDIDATE.Rows)
            {

                double[] coord = new double[]{  Convert.ToDouble(row["NEW_EASTING"]), 
                                                Convert.ToDouble(row["NEW_NORTHING"]) };

                coord = TransformPTM_WGS84(zone).MathTransform.Transform(coord);

                string wkt = String.Format("POINT({0} {1})", coord[0], coord[1]);

                Geometry geom = Geometry.GeomFromText(wkt);

                FeatureDataRow newRow = fdtPRS.NewRow();
                newRow["NO"] = row["NO"];
                newRow["REF_NAME"] = row["REF_NAME"];
                newRow["IS_USER_ADDED"] = row["IS_USER_ADDED"];
                newRow["IS_SELECTED"] = row["IS_SELECTED"];
                newRow.Geometry = geom;

                fdtPRS.Rows.Add(newRow);

            }
        }

        private void chkOLD_CheckedChanged(object sender, EventArgs e)
        {
            mapBox.Map.Layers["lyrSELECTION"].Enabled = chkOLD.Checked;
            mapBox.Map.Layers["lblSELECTION"].Enabled = chkOLD.Checked;
            mapBox.Refresh();
        }

        private void chkPRS_CheckedChanged(object sender, EventArgs e)
        {
            mapBox.Map.Layers["lyrPRS"].Enabled = chkPRS.Checked;
            mapBox.Map.Layers["lblPRS"].Enabled = chkPRS.Checked;
            mapBox.Refresh();
        }

        private void lnkCopy_LinkClicked(object sender, EventArgs e)
        {
            string text = String.Format(
                            "a: {0} \n" +
                            "b: {1} \n" +
                            "Ce: {2} \n" +
                            "Cn: {3} \n" +
                            "No. of points: {4} \n" +
                            "Sum Ve*Ve: {5} \n" +
                            "Sum Vn*Vn: {6} \n" +
                            "Standard Dev.: {7} ",
                            txtP_a.Text,
                            txtP_b.Text,
                            txtP_Ce.Text,
                            txtP_Cn.Text,
                            txtPointCount.Text,
                            txtSumVeVe.Text,
                            txtSumVnVn.Text,
                            txtVariance.Text);

            System.Windows.Forms.Clipboard.SetText(text);
        }

        private void gvCoordinates_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.V && e.Control)
            {
                string data = Clipboard.GetData(DataFormats.Text).ToString();
                string[] cells = data.Split('\t');
                for (int i = 0; i < cells.Length; i++)
                    System.Diagnostics.Debug.Write(cells[i] + "\n");
            }
        }









    }
}