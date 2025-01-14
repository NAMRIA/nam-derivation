// Copyright 2006 - Morten Nielsen (www.iter.dk)
//
// This file is part of ProjNet.
// ProjNet is free software; you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
// 
// ProjNet is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.

// You should have received a copy of the GNU Lesser General Public License
// along with ProjNet; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA 

using System;
using System.Collections.Generic;

namespace ProjNet.CoordinateSystems.Transformations
{
	/// <summary>
	/// Transformation for applying 
	/// </summary>
	internal class DatumTransform : MathTransform
	{
		protected IMathTransform _inverse;
		private Wgs84ConversionInfo _ToWgs94;
		double[] v;

		private bool _isInverse = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="DatumTransform"/> class.
        /// </summary>
        /// <param name="towgs84"></param>
        public DatumTransform(Wgs84ConversionInfo towgs84) : this(towgs84,false)
		{
		}

		private DatumTransform(Wgs84ConversionInfo towgs84, bool isInverse)
		{
			_ToWgs94 = towgs84;
			v = _ToWgs94.GetAffineTransform();
			_isInverse = isInverse;
		}
        /// <summary>
        /// Gets a Well-Known text representation of this object.
        /// </summary>
        /// <value></value>
		public override string WKT
		{
			get { throw new NotImplementedException(); }
		}

        /// <summary>
        /// Gets an XML representation of this object.
        /// </summary>
        /// <value></value>
		public override string XML
		{
			get { throw new NotImplementedException(); }
		}

        /// <summary>
        /// Creates the inverse transform of this object.
        /// </summary>
        /// <returns></returns>
        /// <remarks>This method may fail if the transform is not one to one. However, all cartographic projections should succeed.</remarks>
		public override IMathTransform Inverse()
		{
			if (_inverse == null)
				_inverse = new DatumTransform(_ToWgs94,!_isInverse);
			return _inverse;
		}

        private double[] Apply(double[] p)
		{
            return new double[] {
				v[0] * p[0] - v[3] * p[1] + v[2] * p[2] + v[4],
				v[3] * p[0] + v[0] * p[1] - v[1] * p[2] + v[5],
			   -v[2] * p[0] + v[1] * p[1] + v[0] * p[2] + v[6], };			
		}

        private double[] ApplyInverted(double[] p)
		{
            return new double[] {
				v[0] * p[0] + v[3] * p[1] - v[2] * p[2] - v[4],
			   -v[3] * p[0] + v[0] * p[1] + v[1] * p[2] - v[5],
			    v[2] * p[0] - v[1] * p[1] + v[0] * p[2] - v[6], };
		}

        /// <summary>
        /// Transforms a coordinate point. The passed parameter point should not be modified.
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public override double[] Transform(double[] point)
		{
            if (!_isInverse)
                 return Apply(point);
            else return ApplyInverted(point);
		}

        /// <summary>
        /// Transforms a list of coordinate point ordinal values.
        /// </summary>
        /// <param name="points"></param>
        /// <returns></returns>
        /// <remarks>
        /// This method is provided for efficiently transforming many points. The supplied array
        /// of ordinal values will contain packed ordinal values. For example, if the source
        /// dimension is 3, then the ordinals will be packed in this order (x0,y0,z0,x1,y1,z1 ...).
        /// The size of the passed array must be an integer multiple of DimSource. The returned
        /// ordinal values are packed in a similar way. In some DCPs. the ordinals may be
        /// transformed in-place, and the returned array may be the same as the passed array.
        /// So any client code should not attempt to reuse the passed ordinal values (although
        /// they can certainly reuse the passed array). If there is any problem then the server
        /// implementation will throw an exception. If this happens then the client should not
        /// make any assumptions about the state of the ordinal values.
        /// </remarks>
        public override List<double[]> TransformList(List<double[]> points)
		{
            List<double[]> pnts = new List<double[]>(points.Count);
            foreach (double[] p in points)
				pnts.Add(Transform(p));
			return pnts;
		}

        /// <summary>
        /// Reverses the transformation
        /// </summary>
		public override void Invert()
		{
			_isInverse = !_isInverse;
		}
	}
}
