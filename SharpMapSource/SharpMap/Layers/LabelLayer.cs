// Copyright 2005, 2006 - Morten Nielsen (www.iter.dk)
//
// This file is part of SharpMap.
// SharpMap is free software; you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
// 
// SharpMap is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.

// You should have received a copy of the GNU Lesser General Public License
// along with SharpMap; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA 

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Globalization;
using SharpMap.CoordinateSystems.Transformations;
using SharpMap.Data;
using SharpMap.Data.Providers;
using SharpMap.Geometries;
using SharpMap.Rendering;
using SharpMap.Rendering.Thematics;
using SharpMap.Styles;
using Point=SharpMap.Geometries.Point;
using PdfSharp.Drawing;

namespace SharpMap.Layers
{
    /// <summary>
    /// Label layer class
    /// </summary>
    /// <example>
    /// Creates a new label layer and sets the label text to the "Name" column in the FeatureDataTable of the datasource
    /// <code lang="C#">
    /// //Set up a label layer
    /// SharpMap.Layers.LabelLayer layLabel = new SharpMap.Layers.LabelLayer("Country labels");
    /// layLabel.DataSource = layCountries.DataSource;
    /// layLabel.Enabled = true;
    /// layLabel.LabelColumn = "Name";
    /// layLabel.Style = new SharpMap.Styles.LabelStyle();
    /// layLabel.Style.CollisionDetection = true;
    /// layLabel.Style.CollisionBuffer = new SizeF(20, 20);
    /// layLabel.Style.ForeColor = Color.White;
    /// layLabel.Style.Font = new Font(FontFamily.GenericSerif, 8);
    /// layLabel.MaxVisible = 90;
    /// layLabel.Style.HorizontalAlignment = SharpMap.Styles.LabelStyle.HorizontalAlignmentEnum.Center;
    /// </code>
    /// </example>
    public class LabelLayer : Layer, IDisposable
    {
        #region Delegates

        /// <summary>
        /// Delegate method for creating advanced label texts
        /// </summary>
        /// <param name="fdr"></param>
        /// <returns></returns>
        public delegate string GetLabelMethod(FeatureDataRow fdr);

        /// <summary>
        /// Delegate method for calculating the priority of label rendering
        /// </summary>
        /// <param name="fdr"></param>
        /// <returns></returns>
        public delegate int GetPriorityMethod(FeatureDataRow fdr);

        #endregion

        #region MultipartGeometryBehaviourEnum enum

        /// <summary>
        /// Labelling behaviour for Multipart geometry collections
        /// </summary>
        public enum MultipartGeometryBehaviourEnum
        {
            /// <summary>
            /// Place label on all parts (default)
            /// </summary>
            All,
            /// <summary>
            /// Place label on object which the greatest length or area.
            /// </summary>
            /// <remarks>
            /// Multipoint geometries will default to <see cref="First"/>
            /// </remarks>
            Largest,
            /// <summary>
            /// The center of the combined geometries
            /// </summary>
            CommonCenter,
            /// <summary>
            /// Center of the first geometry in the collection (fastest method)
            /// </summary>
            First
        }

        #endregion

        private IProvider _DataSource;
        private GetLabelMethod _getLabelMethod;
        private GetPriorityMethod _getPriorityMethod;
        private string _LabelColumn;
        private LabelCollisionDetection.LabelFilterMethod _LabelFilter;

        private MultipartGeometryBehaviourEnum _MultipartGeometryBehaviour;
        private int _Priority;

        /// <summary>
        /// A value indication the priority of the label in cases of label-collision detection
        /// </summary>
        private string _PriorityColumn = "";

        private string _RotationColumn;
        private SmoothingMode _SmoothingMode;
        private LabelStyle _Style;
        private TextRenderingHint _TextRenderingHint;
        private ITheme _theme;

        /// <summary>
        /// Creates a new instance of a LabelLayer
        /// </summary>
        public LabelLayer(string layername)
        {
            _Style = new LabelStyle();
            LayerName = layername;
            SmoothingMode = SmoothingMode.AntiAlias;
            TextRenderingHint = TextRenderingHint.AntiAlias;
            _MultipartGeometryBehaviour = MultipartGeometryBehaviourEnum.All;
            _LabelFilter = LabelCollisionDetection.SimpleCollisionDetection;
        }

        /// <summary>
        /// Gets or sets labelling behavior on multipart geometries
        /// </summary>
        /// <remarks>Default value is <see cref="MultipartGeometryBehaviourEnum.All"/></remarks>
        public MultipartGeometryBehaviourEnum MultipartGeometryBehaviour
        {
            get { return _MultipartGeometryBehaviour; }
            set { _MultipartGeometryBehaviour = value; }
        }

        /// <summary>
        /// Filtermethod delegate for performing filtering
        /// </summary>
        /// <remarks>
        /// Default method is <see cref="SharpMap.Rendering.LabelCollisionDetection.SimpleCollisionDetection"/>
        /// </remarks>
        public LabelCollisionDetection.LabelFilterMethod LabelFilter
        {
            get { return _LabelFilter; }
            set { _LabelFilter = value; }
        }


        /// <summary>
        /// Render whether smoothing (antialiasing) is applied to lines and curves and the edges of filled areas
        /// </summary>
        public SmoothingMode SmoothingMode
        {
            get { return _SmoothingMode; }
            set { _SmoothingMode = value; }
        }

        /// <summary>
        /// Specifies the quality of text rendering
        /// </summary>
        public TextRenderingHint TextRenderingHint
        {
            get { return _TextRenderingHint; }
            set { _TextRenderingHint = value; }
        }

        /// <summary>
        /// Gets or sets the datasource
        /// </summary>
        public IProvider DataSource
        {
            get { return _DataSource; }
            set { _DataSource = value; }
        }

        /// <summary>
        /// Gets or sets the rendering style of the label layer.
        /// </summary>
        public LabelStyle Style
        {
            get { return _Style; }
            set { _Style = value; }
        }

        /// <summary>
        /// Gets or sets thematic settings for the layer. Set to null to ignore thematics
        /// </summary>
        public ITheme Theme
        {
            get { return _theme; }
            set { _theme = value; }
        }

        /// <summary>
        /// Data column or expression where label text is extracted from.
        /// </summary>
        /// <remarks>
        /// This property is overriden by the <see cref="LabelStringDelegate"/>.
        /// </remarks>
        public string LabelColumn
        {
            get { return _LabelColumn; }
            set { _LabelColumn = value; }
        }

        /// <summary>
        /// Gets or sets the method for creating a custom label string based on a feature.
        /// </summary>
        /// <remarks>
        /// <para>If this method is not null, it will override the <see cref="LabelColumn"/> value.</para>
        /// <para>The label delegate must take a <see cref="SharpMap.Data.FeatureDataRow"/> and return a string.</para>
        /// <example>
        /// Creating a label-text by combining attributes "ROADNAME" and "STATE" into one string, using
        /// an anonymous delegate:
        /// <code lang="C#">
        /// myLabelLayer.LabelStringDelegate = delegate(SharpMap.Data.FeatureDataRow fdr)
        ///				{ return fdr["ROADNAME"].ToString() + ", " + fdr["STATE"].ToString(); };
        /// </code>
        /// </example>
        /// </remarks>
        public GetLabelMethod LabelStringDelegate
        {
            get { return _getLabelMethod; }
            set { _getLabelMethod = value; }
        }


        /// <summary>
        /// Gets or sets the method for calculating the render priority of a label based on a feature.
        /// </summary>
        /// <remarks>
        /// <para>If this method is not null, it will override the <see cref="PriorityColumn"/> value.</para>
        /// <para>The label delegate must take a <see cref="SharpMap.Data.FeatureDataRow"/> and return an Int32.</para>
        /// <example>
        /// Creating a priority by combining attributes "capital" and "population" into one value, using
        /// an anonymous delegate:
        /// <code lang="C#">
        /// myLabelLayer.PriorityDelegate = delegate(SharpMap.Data.FeatureDataRow fdr) 
        ///     { 
        ///         Int32 retVal = 100000000 * (Int32)( (String)fdr["capital"] == "Y" ? 1 : 0 );
        ///         return  retVal + Convert.ToInt32(fdr["population"]);
        ///     };
        /// </code>
        /// </example>
        /// </remarks>
        public GetPriorityMethod PriorityDelegate
        {
            get { return _getPriorityMethod; }
            set { _getPriorityMethod = value; }
        }

        /// <summary>
        /// Data column from where the label rotation is derived.
        /// If this is empty, rotation will be zero, or aligned to a linestring.
        /// Rotation are in degrees (positive = clockwise).
        /// </summary>
        public string RotationColumn
        {
            get { return _RotationColumn; }
            set { _RotationColumn = value; }
        }

        /// <summary>
        /// A value indication the priority of the label in cases of label-collision detection
        /// </summary>
        public int Priority
        {
            get { return _Priority; }
            set { _Priority = value; }
        }

        public string PriorityColumn
        {
            get { return _PriorityColumn; }
            set { _PriorityColumn = value; }
        }

        /// <summary>
        /// Gets the boundingbox of the entire layer
        /// </summary>
        public override BoundingBox Envelope
        {
            get
            {
                if (DataSource == null)
                    throw (new ApplicationException("DataSource property not set on layer '" + LayerName + "'"));

                bool wasOpen = DataSource.IsOpen;
                if (!wasOpen)
                    DataSource.Open();
                BoundingBox box = DataSource.GetExtents();
                if (!wasOpen) //Restore state
                    DataSource.Close();
                return box;
            }
        }

        /// <summary>
        /// Gets or sets the SRID of this VectorLayer's data source
        /// </summary>
        public override int SRID
        {
            get
            {
                if (DataSource == null)
                    throw (new ApplicationException("DataSource property not set on layer '" + LayerName + "'"));
                return DataSource.SRID;
            }
            set { DataSource.SRID = value; }
        }

        #region IDisposable Members

        /// <summary>
        /// Disposes the object
        /// </summary>
        public void Dispose()
        {
            if (DataSource is IDisposable)
                ((IDisposable) DataSource).Dispose();
        }

        #endregion

        /// <summary>
        /// Renders the layer
        /// </summary>
        /// <param name="g">Graphics object reference</param>
        /// <param name="map">Map which is rendered</param>
        public override void Render(Graphics g, Map map)
        {
            if (Style.Enabled && Style.MaxVisible >= map.Zoom && Style.MinVisible < map.Zoom)
            {
                if (DataSource == null)
                    throw (new ApplicationException("DataSource property not set on layer '" + LayerName + "'"));
                g.TextRenderingHint = TextRenderingHint;
                g.SmoothingMode = SmoothingMode;

                BoundingBox envelope = map.Envelope; //View to render
                if (CoordinateTransformation != null)
                //envelope = GeometryTransform.TransformBox(envelope, CoordinateTransformation.MathTransform.Inverse());
                {
                    CoordinateTransformation.MathTransform.Invert();
                    envelope = GeometryTransform.TransformBox(envelope, CoordinateTransformation.MathTransform);
                    CoordinateTransformation.MathTransform.Invert();
                }

                FeatureDataSet ds = new FeatureDataSet();
                DataSource.Open();
                DataSource.ExecuteIntersectionQuery(envelope, ds);
                DataSource.Close();
                if (ds.Tables.Count == 0)
                {
                    base.Render(g, map);
                    return;
                }
                FeatureDataTable features = (FeatureDataTable) ds.Tables[0];

                //Initialize label collection
                List<Label> labels = new List<Label>();

                //List<System.Drawing.Rectangle> LabelBoxes; //Used for collision detection
                //Render labels
                for (int i = 0; i < features.Count; i++)
                {
                    FeatureDataRow feature = features[i];
                    if (CoordinateTransformation != null)
                        features[i].Geometry = GeometryTransform.TransformGeometry(features[i].Geometry,
                                                                                   CoordinateTransformation.
                                                                                       MathTransform);

                    LabelStyle style = null;
                    if (Theme != null) //If thematics is enabled, lets override the style
                        style = Theme.GetStyle(feature) as LabelStyle;
                    else
                        style = Style;

                    float rotation = 0;
                    if (!String.IsNullOrEmpty(RotationColumn))
                        float.TryParse(feature[RotationColumn].ToString(), NumberStyles.Any, Map.NumberFormatEnUs,
                                       out rotation);

                    int priority = Priority;
                    if (_getPriorityMethod != null)
                        priority = _getPriorityMethod(feature);
                    else if (!String.IsNullOrEmpty(PriorityColumn))
                        int.TryParse(feature[PriorityColumn].ToString(), NumberStyles.Any, Map.NumberFormatEnUs,
                                     out priority);

                    string text;
                    if (_getLabelMethod != null)
                        text = _getLabelMethod(feature);
                    else
                        text = feature[LabelColumn].ToString();

                    if (text != null && text != String.Empty)
                    {
                        if (feature.Geometry is GeometryCollection)
                        {
                            if (MultipartGeometryBehaviour == MultipartGeometryBehaviourEnum.All)
                            {
                                foreach (Geometry geom in (feature.Geometry as GeometryCollection))
                                {
                                    Label lbl = CreateLabel(geom, text, rotation, priority, style, map, g);
                                    if (lbl != null)
                                        labels.Add(lbl);
                                }
                            }
                            else if (MultipartGeometryBehaviour == MultipartGeometryBehaviourEnum.CommonCenter)
                            {
                                Label lbl = CreateLabel(feature.Geometry, text, rotation, priority, style, map, g);
                                if (lbl != null)
                                    labels.Add(lbl);
                            }
                            else if (MultipartGeometryBehaviour == MultipartGeometryBehaviourEnum.First)
                            {
                                if ((feature.Geometry as GeometryCollection).Collection.Count > 0)
                                {
                                    Label lbl = CreateLabel((feature.Geometry as GeometryCollection).Collection[0], text,
                                                            rotation, style, map, g);
                                    if (lbl != null)
                                        labels.Add(lbl);
                                }
                            }
                            else if (MultipartGeometryBehaviour == MultipartGeometryBehaviourEnum.Largest)
                            {
                                GeometryCollection coll = (feature.Geometry as GeometryCollection);
                                if (coll.NumGeometries > 0)
                                {
                                    double largestVal = 0;
                                    int idxOfLargest = 0;
                                    for (int j = 0; j < coll.NumGeometries; j++)
                                    {
                                        Geometry geom = coll.Geometry(j);
                                        if (geom is LineString && ((LineString) geom).Length > largestVal)
                                        {
                                            largestVal = ((LineString) geom).Length;
                                            idxOfLargest = j;
                                        }
                                        if (geom is MultiLineString && ((MultiLineString) geom).Length > largestVal)
                                        {
                                            largestVal = ((LineString) geom).Length;
                                            idxOfLargest = j;
                                        }
                                        if (geom is Polygon && ((Polygon) geom).Area > largestVal)
                                        {
                                            largestVal = ((Polygon) geom).Area;
                                            idxOfLargest = j;
                                        }
                                        if (geom is MultiPolygon && ((MultiPolygon) geom).Area > largestVal)
                                        {
                                            largestVal = ((MultiPolygon) geom).Area;
                                            idxOfLargest = j;
                                        }
                                    }

                                    Label lbl = CreateLabel(coll.Geometry(idxOfLargest), text, rotation, priority, style,
                                                            map, g);
                                    if (lbl != null)
                                        labels.Add(lbl);
                                }
                            }
                        }
                        else
                        {
                            Label lbl = CreateLabel(feature.Geometry, text, rotation, priority, style, map, g);
                            if (lbl != null)
                                labels.Add(lbl);
                        }
                    }
                }
                if (labels.Count > 0) //We have labels to render...
                {
                    if (Style.CollisionDetection && _LabelFilter != null)
                        _LabelFilter(labels);
                    for (int i = 0; i < labels.Count; i++)
                        if (labels[i].Show)
                            VectorRenderer.DrawLabel(g, labels[i].LabelPoint, labels[i].Style.Offset,
                                                     labels[i].Style.Font, labels[i].Style.ForeColor,
                                                     labels[i].Style.BackColor, Style.Halo, labels[i].Rotation,
                                                     labels[i].Text, map);
                }
                labels = null;
            }
            base.Render(g, map);
        }

        private Label CreateLabel(Geometry feature, string text, float rotation, LabelStyle style, Map map, Graphics g)
        {
            return CreateLabel(feature, text, rotation, Priority, style, map, g);
            ;
        }

        private Label CreateLabel(Geometry feature, string text, float rotation, int priority, LabelStyle style, Map map,
                                  Graphics g)
        {
            SizeF size = g.MeasureString(text, style.Font);

            PointF position = map.WorldToImage(feature.GetBoundingBox().GetCentroid());
            position.X = position.X - size.Width*(short) style.HorizontalAlignment*0.5f;
            position.Y = position.Y - size.Height*(short) style.VerticalAlignment*0.5f;
            if (position.X - size.Width > map.Size.Width || position.X + size.Width < 0 ||
                position.Y - size.Height > map.Size.Height || position.Y + size.Height < 0)
                return null;
            else
            {
                Label lbl;

                if (!style.CollisionDetection)
                    lbl = new Label(text, position, rotation, priority, null, style);
                else
                {
                    //Collision detection is enabled so we need to measure the size of the string
                    lbl = new Label(text, position, rotation, priority,
                                    new LabelBox(position.X - size.Width*0.5f - style.CollisionBuffer.Width,
                                                 position.Y + size.Height*0.5f + style.CollisionBuffer.Height,
                                                 size.Width + 2f*style.CollisionBuffer.Width,
                                                 size.Height + style.CollisionBuffer.Height*2f), style);
                }
                if (feature.GetType() == typeof (LineString))
                {
                    LineString line = feature as LineString;
                    if (line.Length/map.PixelSize > size.Width) //Only label feature if it is long enough
                        CalculateLabelOnLinestring(line, ref lbl, map);
                    else
                        return null;
                }

                return lbl;
            }
        }

        private void CalculateLabelOnLinestring(LineString line, ref Label label, Map map)
        {
            double dx, dy;
            double tmpx, tmpy;
            double angle = 0.0;

            // first find the middle segment of the line
            int midPoint = (line.Vertices.Count - 1)/2;
            if (line.Vertices.Count > 2)
            {
                dx = line.Vertices[midPoint + 1].X - line.Vertices[midPoint].X;
                dy = line.Vertices[midPoint + 1].Y - line.Vertices[midPoint].Y;
            }
            else
            {
                midPoint = 0;
                dx = line.Vertices[1].X - line.Vertices[0].X;
                dy = line.Vertices[1].Y - line.Vertices[0].Y;
            }
            if (dy == 0)
                label.Rotation = 0;
            else if (dx == 0)
                label.Rotation = 90;
            else
            {
                // calculate angle of line					
                angle = -Math.Atan(dy/dx) + Math.PI*0.5;
                angle *= (180d/Math.PI); // convert radians to degrees
                label.Rotation = (float) angle - 90; // -90 text orientation
            }
            tmpx = line.Vertices[midPoint].X + (dx*0.5);
            tmpy = line.Vertices[midPoint].Y + (dy*0.5);
            label.LabelPoint = map.WorldToImage(new Point(tmpx, tmpy));
        }

        /// <summary>
        /// Clones the object
        /// </summary>
        /// <returns></returns>
        public override object Clone()
        {
            throw new NotImplementedException();
        }

        public LabelLayer CloneLayer()
        {
            LabelLayer ll = new LabelLayer(LayerName);

            ll.CoordinateTransformation = CoordinateTransformation;
            ll.DataSource = DataSource;
            ll.Enabled = Enabled;
            ll.LabelColumn = LabelColumn;
            ll.LabelFilter = LabelFilter;
            ll.LabelStringDelegate = LabelStringDelegate;
            ll.MaxVisible = MaxVisible;
            ll.MinVisible = MinVisible;
            ll.MultipartGeometryBehaviour = MultipartGeometryBehaviour;
            ll.Priority = Priority;
            ll.PriorityColumn = PriorityColumn;
            ll.PriorityDelegate = PriorityDelegate;
            ll.RotationColumn = RotationColumn;
            ll.SmoothingMode = SmoothingMode;
            ll.SRID = SRID;
            ll.Style = Style.Clone();
            ll.TextRenderingHint = TextRenderingHint;
            ll.Theme = Theme;

            return ll;
        }


        #region PDF Rendering

        /// <summary>
        /// Renders the layer
        /// </summary>
        /// <param name="g">XGraphics object reference</param>
        /// <param name="map">Map which is rendered</param>
        public override void Render(XGraphics g, Map map)
        {
            if (Style.Enabled && Style.MaxVisible >= map.Zoom && Style.MinVisible < map.Zoom)
            {
                if (DataSource == null)
                    throw (new ApplicationException("DataSource property not set on layer '" + LayerName + "'"));

                g.Graphics.TextRenderingHint = TextRenderingHint;

                switch (SmoothingMode)
                {
                    case SmoothingMode.AntiAlias:
                        g.SmoothingMode = XSmoothingMode.AntiAlias;
                        break;
                    case SmoothingMode.Default:
                        g.SmoothingMode = XSmoothingMode.Default;
                        break;
                    case SmoothingMode.HighQuality:
                        g.SmoothingMode = XSmoothingMode.HighQuality;
                        break;
                    case SmoothingMode.HighSpeed:
                        g.SmoothingMode = XSmoothingMode.HighSpeed;
                        break;
                    case SmoothingMode.Invalid:
                        g.SmoothingMode = XSmoothingMode.Invalid;
                        break;
                    case SmoothingMode.None:
                        g.SmoothingMode = XSmoothingMode.None;
                        break;
                    default:
                        break;
                }

                BoundingBox envelope = map.Envelope; //View to render
                if (CoordinateTransformation != null)
                    envelope = GeometryTransform.TransformBox(envelope, CoordinateTransformation.MathTransform.Inverse());

                FeatureDataSet ds = new FeatureDataSet();
                DataSource.Open();
                DataSource.ExecuteIntersectionQuery(envelope, ds);
                DataSource.Close();
                if (ds.Tables.Count == 0)
                {
                    base.Render(g, map);
                    return;
                }
                FeatureDataTable features = (FeatureDataTable)ds.Tables[0];

                //Initialize label collection
                List<Label> labels = new List<Label>();

                //List<System.Drawing.Rectangle> LabelBoxes; //Used for collision detection
                //Render labels
                for (int i = 0; i < features.Count; i++)
                {
                    FeatureDataRow feature = features[i];
                    if (CoordinateTransformation != null)
                        features[i].Geometry = GeometryTransform.TransformGeometry(features[i].Geometry,
                                                                                   CoordinateTransformation.
                                                                                       MathTransform);

                    LabelStyle style = null;
                    if (Theme != null) //If thematics is enabled, lets override the style
                        style = Theme.GetStyle(feature) as LabelStyle;
                    else
                        style = Style;

                    float rotation = 0;
                    if (!String.IsNullOrEmpty(RotationColumn))
                        float.TryParse(feature[RotationColumn].ToString(), NumberStyles.Any, Map.NumberFormatEnUs,
                                       out rotation);

                    int priority = Priority;
                    if (_getPriorityMethod != null)
                        priority = _getPriorityMethod(feature);
                    else if (!String.IsNullOrEmpty(PriorityColumn))
                        int.TryParse(feature[PriorityColumn].ToString(), NumberStyles.Any, Map.NumberFormatEnUs,
                                     out priority);

                    string text;
                    if (_getLabelMethod != null)
                        text = _getLabelMethod(feature);
                    else
                        text = feature[LabelColumn].ToString();

                    if (text != null && text != String.Empty)
                    {
                        if (feature.Geometry is GeometryCollection)
                        {
                            if (MultipartGeometryBehaviour == MultipartGeometryBehaviourEnum.All)
                            {
                                foreach (Geometry geom in (feature.Geometry as GeometryCollection))
                                {
                                    Label lbl = CreateLabel(geom, text, rotation, priority, style, map, g);
                                    if (lbl != null)
                                        labels.Add(lbl);
                                }
                            }
                            else if (MultipartGeometryBehaviour == MultipartGeometryBehaviourEnum.CommonCenter)
                            {
                                Label lbl = CreateLabel(feature.Geometry, text, rotation, priority, style, map, g);
                                if (lbl != null)
                                    labels.Add(lbl);
                            }
                            else if (MultipartGeometryBehaviour == MultipartGeometryBehaviourEnum.First)
                            {
                                if ((feature.Geometry as GeometryCollection).Collection.Count > 0)
                                {
                                    Label lbl = CreateLabel((feature.Geometry as GeometryCollection).Collection[0], text,
                                                            rotation, style, map, g);
                                    if (lbl != null)
                                        labels.Add(lbl);
                                }
                            }
                            else if (MultipartGeometryBehaviour == MultipartGeometryBehaviourEnum.Largest)
                            {
                                GeometryCollection coll = (feature.Geometry as GeometryCollection);
                                if (coll.NumGeometries > 0)
                                {
                                    double largestVal = 0;
                                    int idxOfLargest = 0;
                                    for (int j = 0; j < coll.NumGeometries; j++)
                                    {
                                        Geometry geom = coll.Geometry(j);
                                        if (geom is LineString && ((LineString)geom).Length > largestVal)
                                        {
                                            largestVal = ((LineString)geom).Length;
                                            idxOfLargest = j;
                                        }
                                        if (geom is MultiLineString && ((MultiLineString)geom).Length > largestVal)
                                        {
                                            largestVal = ((LineString)geom).Length;
                                            idxOfLargest = j;
                                        }
                                        if (geom is Polygon && ((Polygon)geom).Area > largestVal)
                                        {
                                            largestVal = ((Polygon)geom).Area;
                                            idxOfLargest = j;
                                        }
                                        if (geom is MultiPolygon && ((MultiPolygon)geom).Area > largestVal)
                                        {
                                            largestVal = ((MultiPolygon)geom).Area;
                                            idxOfLargest = j;
                                        }
                                    }

                                    Label lbl = CreateLabel(coll.Geometry(idxOfLargest), text, rotation, priority, style,
                                                            map, g);
                                    if (lbl != null)
                                        labels.Add(lbl);
                                }
                            }
                        }
                        else
                        {
                            Label lbl = CreateLabel(feature.Geometry, text, rotation, priority, style, map, g);
                            if (lbl != null)
                                labels.Add(lbl);
                        }
                    }
                }
                if (labels.Count > 0) //We have labels to render...
                {
                    if (Style.CollisionDetection && _LabelFilter != null)
                        _LabelFilter(labels);
                    for (int i = 0; i < labels.Count; i++)
                        if (labels[i].Show)
                            XGraphicsVectorRenderer.DrawLabel(g, labels[i].LabelPoint, labels[i].Style.Offset,
                                                     labels[i].Style.Font, labels[i].Style.ForeColor,
                                                     labels[i].Style.BackColor, Style.Halo, labels[i].Rotation,
                                                     labels[i].Text, map);
                }
                labels = null;
            }
            base.Render(g, map);
        }

        private Label CreateLabel(Geometry feature, string text, float rotation, LabelStyle style, Map map, XGraphics g)
        {
            return CreateLabel(feature, text, rotation, Priority, style, map, g);
        }

        private Label CreateLabel(Geometry feature, string text, float rotation, int priority, LabelStyle style, Map map,
                                  XGraphics g)
        {
            XFont xFont = XGraphicsUtils.FontToXFont(style.Font);

            XSize size = g.MeasureString(text, xFont);

            PointF position = map.WorldToImage(feature.GetBoundingBox().GetCentroid());
            position.X = position.X - (float)size.Width * (short)style.HorizontalAlignment * 0.5f;
            position.Y = position.Y - (float)size.Height * (short)style.VerticalAlignment * 0.5f;
            if (position.X - size.Width > map.Size.Width || position.X + size.Width < 0 ||
                position.Y - size.Height > map.Size.Height || position.Y + size.Height < 0)
                return null;
            else
            {
                Label lbl;

                if (!style.CollisionDetection)
                    lbl = new Label(text, position, rotation, priority, null, style);
                else
                {
                    //Collision detection is enabled so we need to measure the size of the string
                    lbl = new Label(text, position, rotation, priority,
                                    new LabelBox(position.X - (float)size.Width * 0.5f - style.CollisionBuffer.Width,
                                                 position.Y + (float)size.Height * 0.5f + style.CollisionBuffer.Height,
                                                 (float)size.Width + 2f * style.CollisionBuffer.Width,
                                                 (float)size.Height + style.CollisionBuffer.Height * 2f), style);
                }
                if (feature.GetType() == typeof(LineString))
                {
                    LineString line = feature as LineString;
                    if (line.Length / map.PixelSize > size.Width) //Only label feature if it is long enough
                        CalculateLabelOnLinestring(line, ref lbl, map);
                    else
                        return null;
                }

                return lbl;
            }
        }

        #endregion




    }
}