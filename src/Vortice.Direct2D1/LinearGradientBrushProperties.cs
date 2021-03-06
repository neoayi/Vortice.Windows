﻿// Copyright (c) Amer Koleci and contributors.
// Distributed under the MIT license. See the LICENSE file in the project root for more information.

using System.Drawing;
using System.Numerics;

namespace Vortice.Direct2D1
{
    /// <summary>
    /// Contains the starting point and endpoint of the gradient axis for an <see cref="ID2D1LinearGradientBrush"/>.
    /// </summary>
    public partial struct LinearGradientBrushProperties
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinearGradientBrushProperties"/> struct.
        /// </summary>
        /// <param name="startPoint">In the brush's coordinate space, the starting point of the gradient axis.</param>
        /// <param name="endPoint">In the brush's coordinate space, the endpoint of the gradient axis.</param>
        public LinearGradientBrushProperties(in Vector2 startPoint, in Vector2 endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinearGradientBrushProperties"/> struct.
        /// </summary>
        /// <param name="startPoint">In the brush's coordinate space, the starting point of the gradient axis.</param>
        /// <param name="endPoint">In the brush's coordinate space, the endpoint of the gradient axis.</param>
        public LinearGradientBrushProperties(in PointF startPoint, in PointF endPoint)
        {
            StartPoint = new Vector2(startPoint.X, startPoint.Y);
            EndPoint = new Vector2(endPoint.X, endPoint.Y);
        }
    }
}
