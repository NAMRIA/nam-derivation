using System;
using PdfSharp.Drawing;
using System.Drawing;
using System.Drawing.Drawing2D;
using PdfSharp.Pdf;

namespace SharpMap.Rendering
{
    public static class XGraphicsUtils
    {
        public static XFontStyle FontStyleToXFontStyle(FontStyle style)
        {
            XFontStyle fontStyle = XFontStyle.Regular;

            switch (style)
            {
                case FontStyle.Bold:
                    fontStyle = XFontStyle.Bold;
                    break;
                case FontStyle.Italic:
                    fontStyle = XFontStyle.Italic;
                    break;
                case FontStyle.Strikeout:
                    fontStyle = XFontStyle.Strikeout;
                    break;
                case FontStyle.Underline:
                    fontStyle = XFontStyle.Underline;
                    break;
                case FontStyle.Regular:
                default:
                    fontStyle = XFontStyle.Regular;
                    break;
            }

            return fontStyle;
        }

        public static XBrush BrushToXBrush(Brush brush)
        {
            XBrush xBrush = null;

            if (brush != null && brush != Brushes.Transparent)
            {
                if (brush is SolidBrush)
                    xBrush = new XSolidBrush((brush as SolidBrush).Color);
            }

            return xBrush;
        }

        public static XPen PenToXPen(Pen pen)
        {
            if (pen == null)
                return null;

            XPen xPen = new XPen(XColor.FromArgb(pen.Color), pen.Width);
            xPen.DashOffset = pen.DashOffset;

            if (pen.DashStyle != DashStyle.Solid && pen.DashPattern != null && pen.DashPattern.Length > 0)
            {
                double[] dashPattern = new double[pen.DashPattern.Length];

                for (int i = 0; i < pen.DashPattern.Length; i++)
                    dashPattern[i] = pen.DashPattern[i];

                xPen.DashPattern = dashPattern;
            }

            switch (pen.DashStyle)
            {
                case DashStyle.Custom:
                    xPen.DashStyle = XDashStyle.Custom;
                    break;
                case DashStyle.Dash:
                    xPen.DashStyle = XDashStyle.Dash;
                    break;
                case DashStyle.DashDot:
                    xPen.DashStyle = XDashStyle.DashDot;
                    break;
                case DashStyle.DashDotDot:
                    xPen.DashStyle = XDashStyle.DashDotDot;
                    break;
                case DashStyle.Dot:
                    xPen.DashStyle = XDashStyle.Dot;
                    break;
                case DashStyle.Solid:
                    xPen.DashStyle = XDashStyle.Solid;
                    break;
            }

            switch (pen.StartCap)
            {
                case LineCap.Flat:
                    xPen.LineCap = XLineCap.Flat;
                    break;
                case LineCap.Round:
                    xPen.LineCap = XLineCap.Round;
                    break;
                case LineCap.AnchorMask:
                case LineCap.ArrowAnchor:
                case LineCap.Custom:
                case LineCap.DiamondAnchor:
                case LineCap.NoAnchor:
                case LineCap.RoundAnchor:
                case LineCap.Square:
                case LineCap.SquareAnchor:
                case LineCap.Triangle:
                default:
                    xPen.LineCap = XLineCap.Square;
                    break;
            }

            switch (pen.LineJoin)
            {
                case LineJoin.Bevel:
                    xPen.LineJoin = XLineJoin.Bevel;
                    break;
                case LineJoin.Round:
                    xPen.LineJoin = XLineJoin.Round;
                    break;
                case LineJoin.MiterClipped:
                case LineJoin.Miter:
                default:
                    xPen.LineJoin = XLineJoin.Miter;
                    break;
            }

            xPen.MiterLimit = pen.MiterLimit;
            xPen.Width = pen.Width;

            return xPen;
        }

        private static XPdfFontOptions fontOptions = null;
        public static XFont FontToXFont(Font font)
        {
            if (fontOptions == null)
                fontOptions = new XPdfFontOptions(PdfFontEncoding.WinAnsi, PdfFontEmbedding.Default);

            XFontStyle xFontStyle = FontStyleToXFontStyle(font.Style);

            XFont retVal = new XFont(font.FontFamily, (double)font.Size, xFontStyle, fontOptions);

            return retVal;
        }
    }
}
