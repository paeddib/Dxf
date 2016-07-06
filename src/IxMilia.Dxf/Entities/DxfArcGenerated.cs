// Copyright (c) IxMilia.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

// The contents of this file are automatically generated by a tool, and should not be directly modified.

using System;
using System.Collections.Generic;
using System.Linq;
using IxMilia.Dxf.Collections;

namespace IxMilia.Dxf.Entities
{

    /// <summary>
    /// DxfArc class
    /// </summary>
    public partial class DxfArc : DxfCircle
    {
        public override DxfEntityType EntityType { get { return DxfEntityType.Arc; } }


        /// <Summary>
        /// Arc start angle in degrees
        /// </Summary>
        public double StartAngle { get; set; }

        /// <Summary>
        /// Arc end angle in degrees
        /// </Summary>
        public double EndAngle { get; set; }

        public DxfArc()
            : base()
        {
        }

        //
        // Parameterized constructors
        //
        public DxfArc(DxfPoint center, double radius, double startAngle, double endAngle)
            : this()
        {
            this.Center = center;
            this.Radius = radius;
            this.StartAngle = startAngle;
            this.EndAngle = endAngle;
        }

        protected override void Initialize()
        {
            base.Initialize();
            this.StartAngle = 0.0;
            this.EndAngle = 360.0;
        }

        protected override void AddValuePairs(List<DxfCodePair> pairs, DxfAcadVersion version, bool outputHandles)
        {
            base.AddValuePairs(pairs, version, outputHandles);
            pairs.Add(new DxfCodePair(100, "AcDbArc"));
            pairs.Add(new DxfCodePair(50, (this.StartAngle)));
            pairs.Add(new DxfCodePair(51, (this.EndAngle)));
        }

        internal override bool TrySetPair(DxfCodePair pair)
        {
            switch (pair.Code)
            {
                case 50:
                    this.StartAngle = (pair.DoubleValue);
                    break;
                case 51:
                    this.EndAngle = (pair.DoubleValue);
                    break;
                default:
                    return base.TrySetPair(pair);
            }

            return true;
        }
    }

}
