// Copyright (c) IxMilia.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

// The contents of this file are automatically generated by a tool, and should not be directly modified.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using IxMilia.Dxf.Collections;
using IxMilia.Dxf.Entities;

namespace IxMilia.Dxf.Objects
{
    /// <summary>
    /// DxfPlotSettings class
    /// </summary>
    public partial class DxfPlotSettings : DxfObject, IDxfItemInternal
    {
        public override DxfObjectType ObjectType { get { return DxfObjectType.PlotSettings; } }
        protected override DxfAcadVersion MaxVersion { get { return DxfAcadVersion.R2000; } }

        IEnumerable<DxfPointer> IDxfItemInternal.GetPointers()
        {
            yield return ShadePlotObjectPointer;
        }

        IEnumerable<IDxfItemInternal> IDxfItemInternal.GetChildItems()
        {
            return ((IDxfItemInternal)this).GetPointers().Select(p => (IDxfItemInternal)p.Item);
        }

        internal DxfPointer ShadePlotObjectPointer { get; } = new DxfPointer();
        public string PageSetupName { get; set; }
        public string PrinterName { get; set; }
        public string PaperSize { get; set; }
        public string PlotViewName { get; set; }
        public double UnprintableLeftMarginSize { get; set; }
        public double UnprintableBottomMarginSize { get; set; }
        public double UnprintableRightMarginSize { get; set; }
        public double UnprintableTopMarginSize { get; set; }
        public double PaperWidth { get; set; }
        public double PaperHeight { get; set; }
        public double PlotOriginXValue { get; set; }
        public double PlotOriginYValue { get; set; }
        public double PlotWindowLowerLeftXValue { get; set; }
        public double PlotWindowLowerLeftYValue { get; set; }
        public double PlotWindowUpperRightXValue { get; set; }
        public double PlotWindowUpperRightYValue { get; set; }
        public double CustomPrintScaleNumerator { get; set; }
        public double CustomPrintScaleDenominator { get; set; }
        public int PlotLayoutFlags { get; set; }
        public DxfPlotPaperUnits PlotPaperUnits { get; set; }
        public DxfPlotRotation PlotRotation { get; set; }
        public DxfPlotType PlotType { get; set; }
        public string CurrentStyleSheet { get; set; }
        public DxfStandardScale StandardScale { get; set; }
        public DxfShadePlotMode ShadePlotMode { get; set; }
        public DxfShadePlotResolutionLevel ShadePlotResolutionLevel { get; set; }
        public int ShadePlotCustomDPI { get; set; }
        public double StandardScaleValue { get; set; }
        public double PaperImageOriginX { get; set; }
        public double PaperImageOriginY { get; set; }
        public IDxfItem ShadePlotObject { get { return ShadePlotObjectPointer.Item as IDxfItem; } set { ShadePlotObjectPointer.Item = value; } }

        // PlotLayoutFlags flags

        public bool PlotViewportBorders
        {
            get { return DxfHelpers.GetFlag(PlotLayoutFlags, 1); }
            set
            {
                var flags = PlotLayoutFlags;
                DxfHelpers.SetFlag(value, ref flags, 1);
                PlotLayoutFlags = flags;
            }
        }

        public bool ShowPlotStyles
        {
            get { return DxfHelpers.GetFlag(PlotLayoutFlags, 2); }
            set
            {
                var flags = PlotLayoutFlags;
                DxfHelpers.SetFlag(value, ref flags, 2);
                PlotLayoutFlags = flags;
            }
        }

        public bool PlotCentered
        {
            get { return DxfHelpers.GetFlag(PlotLayoutFlags, 4); }
            set
            {
                var flags = PlotLayoutFlags;
                DxfHelpers.SetFlag(value, ref flags, 4);
                PlotLayoutFlags = flags;
            }
        }

        public bool PlotHidden
        {
            get { return DxfHelpers.GetFlag(PlotLayoutFlags, 8); }
            set
            {
                var flags = PlotLayoutFlags;
                DxfHelpers.SetFlag(value, ref flags, 8);
                PlotLayoutFlags = flags;
            }
        }

        public bool UseStandardScale
        {
            get { return DxfHelpers.GetFlag(PlotLayoutFlags, 16); }
            set
            {
                var flags = PlotLayoutFlags;
                DxfHelpers.SetFlag(value, ref flags, 16);
                PlotLayoutFlags = flags;
            }
        }

        public bool PlotPlotStyles
        {
            get { return DxfHelpers.GetFlag(PlotLayoutFlags, 32); }
            set
            {
                var flags = PlotLayoutFlags;
                DxfHelpers.SetFlag(value, ref flags, 32);
                PlotLayoutFlags = flags;
            }
        }

        public bool ScaleLineweights
        {
            get { return DxfHelpers.GetFlag(PlotLayoutFlags, 64); }
            set
            {
                var flags = PlotLayoutFlags;
                DxfHelpers.SetFlag(value, ref flags, 64);
                PlotLayoutFlags = flags;
            }
        }

        public bool PrintLineweights
        {
            get { return DxfHelpers.GetFlag(PlotLayoutFlags, 128); }
            set
            {
                var flags = PlotLayoutFlags;
                DxfHelpers.SetFlag(value, ref flags, 128);
                PlotLayoutFlags = flags;
            }
        }

        public bool DrawViewportsFirst
        {
            get { return DxfHelpers.GetFlag(PlotLayoutFlags, 512); }
            set
            {
                var flags = PlotLayoutFlags;
                DxfHelpers.SetFlag(value, ref flags, 512);
                PlotLayoutFlags = flags;
            }
        }

        public bool ModelType
        {
            get { return DxfHelpers.GetFlag(PlotLayoutFlags, 1024); }
            set
            {
                var flags = PlotLayoutFlags;
                DxfHelpers.SetFlag(value, ref flags, 1024);
                PlotLayoutFlags = flags;
            }
        }

        public bool UpdatePaper
        {
            get { return DxfHelpers.GetFlag(PlotLayoutFlags, 2048); }
            set
            {
                var flags = PlotLayoutFlags;
                DxfHelpers.SetFlag(value, ref flags, 2048);
                PlotLayoutFlags = flags;
            }
        }

        public bool ZoomToPaperOnUpdate
        {
            get { return DxfHelpers.GetFlag(PlotLayoutFlags, 4096); }
            set
            {
                var flags = PlotLayoutFlags;
                DxfHelpers.SetFlag(value, ref flags, 4096);
                PlotLayoutFlags = flags;
            }
        }

        public bool Initializing
        {
            get { return DxfHelpers.GetFlag(PlotLayoutFlags, 8192); }
            set
            {
                var flags = PlotLayoutFlags;
                DxfHelpers.SetFlag(value, ref flags, 8192);
                PlotLayoutFlags = flags;
            }
        }

        public bool PrevPlotInit
        {
            get { return DxfHelpers.GetFlag(PlotLayoutFlags, 16384); }
            set
            {
                var flags = PlotLayoutFlags;
                DxfHelpers.SetFlag(value, ref flags, 16384);
                PlotLayoutFlags = flags;
            }
        }

        public DxfPlotSettings()
            : base()
        {
        }

        protected override void Initialize()
        {
            base.Initialize();
            this.PageSetupName = null;
            this.PrinterName = null;
            this.PaperSize = null;
            this.PlotViewName = null;
            this.UnprintableLeftMarginSize = 0.0;
            this.UnprintableBottomMarginSize = 0.0;
            this.UnprintableRightMarginSize = 0.0;
            this.UnprintableTopMarginSize = 0.0;
            this.PaperWidth = 0.0;
            this.PaperHeight = 0.0;
            this.PlotOriginXValue = 0.0;
            this.PlotOriginYValue = 0.0;
            this.PlotWindowLowerLeftXValue = 0.0;
            this.PlotWindowLowerLeftYValue = 0.0;
            this.PlotWindowUpperRightXValue = 0.0;
            this.PlotWindowUpperRightYValue = 0.0;
            this.CustomPrintScaleNumerator = 0.0;
            this.CustomPrintScaleDenominator = 0.0;
            this.PlotLayoutFlags = 0;
            this.PlotPaperUnits = DxfPlotPaperUnits.Inches;
            this.PlotRotation = DxfPlotRotation.NoRotation;
            this.PlotType = DxfPlotType.DrawingExtents;
            this.CurrentStyleSheet = null;
            this.StandardScale = DxfStandardScale.ScaledToFit;
            this.ShadePlotMode = DxfShadePlotMode.AsDisplayed;
            this.ShadePlotResolutionLevel = DxfShadePlotResolutionLevel.Normal;
            this.ShadePlotCustomDPI = 100;
            this.StandardScaleValue = 1.0;
            this.PaperImageOriginX = 0.0;
            this.PaperImageOriginY = 0.0;
        }

        protected override void AddValuePairs(List<DxfCodePair> pairs, DxfAcadVersion version, bool outputHandles)
        {
            base.AddValuePairs(pairs, version, outputHandles);
            pairs.Add(new DxfCodePair(100, "AcDbPlotSettings"));
            pairs.Add(new DxfCodePair(1, (this.PageSetupName)));
            pairs.Add(new DxfCodePair(2, (this.PrinterName)));
            pairs.Add(new DxfCodePair(4, (this.PaperSize)));
            pairs.Add(new DxfCodePair(6, (this.PlotViewName)));
            pairs.Add(new DxfCodePair(40, (this.UnprintableLeftMarginSize)));
            pairs.Add(new DxfCodePair(41, (this.UnprintableBottomMarginSize)));
            pairs.Add(new DxfCodePair(42, (this.UnprintableRightMarginSize)));
            pairs.Add(new DxfCodePair(43, (this.UnprintableTopMarginSize)));
            pairs.Add(new DxfCodePair(44, (this.PaperWidth)));
            pairs.Add(new DxfCodePair(45, (this.PaperHeight)));
            pairs.Add(new DxfCodePair(46, (this.PlotOriginXValue)));
            pairs.Add(new DxfCodePair(47, (this.PlotOriginYValue)));
            pairs.Add(new DxfCodePair(48, (this.PlotWindowLowerLeftXValue)));
            pairs.Add(new DxfCodePair(49, (this.PlotWindowLowerLeftYValue)));
            pairs.Add(new DxfCodePair(140, (this.PlotWindowUpperRightXValue)));
            pairs.Add(new DxfCodePair(141, (this.PlotWindowUpperRightYValue)));
            pairs.Add(new DxfCodePair(142, (this.CustomPrintScaleNumerator)));
            pairs.Add(new DxfCodePair(143, (this.CustomPrintScaleDenominator)));
            pairs.Add(new DxfCodePair(70, (short)(this.PlotLayoutFlags)));
            pairs.Add(new DxfCodePair(72, (short)(this.PlotPaperUnits)));
            pairs.Add(new DxfCodePair(73, (short)(this.PlotRotation)));
            pairs.Add(new DxfCodePair(74, (short)(this.PlotType)));
            pairs.Add(new DxfCodePair(7, (this.CurrentStyleSheet)));
            pairs.Add(new DxfCodePair(75, (short)(this.StandardScale)));
            if (version >= DxfAcadVersion.R2004)
            {
                pairs.Add(new DxfCodePair(76, (short)(this.ShadePlotMode)));
            }

            if (version >= DxfAcadVersion.R2004)
            {
                pairs.Add(new DxfCodePair(77, (short)(this.ShadePlotResolutionLevel)));
            }

            if (version >= DxfAcadVersion.R2004)
            {
                pairs.Add(new DxfCodePair(78, (short)(this.ShadePlotCustomDPI)));
            }

            pairs.Add(new DxfCodePair(147, (this.StandardScaleValue)));
            pairs.Add(new DxfCodePair(148, (this.PaperImageOriginX)));
            pairs.Add(new DxfCodePair(149, (this.PaperImageOriginY)));
            if (this.ShadePlotObjectPointer.Handle != 0u)
            {
                pairs.Add(new DxfCodePair(333, DxfCommonConverters.UIntHandle(this.ShadePlotObjectPointer.Handle)));
            }

        }

        internal override bool TrySetPair(DxfCodePair pair)
        {
            switch (pair.Code)
            {
                case 1:
                    this.PageSetupName = (pair.StringValue);
                    break;
                case 2:
                    this.PrinterName = (pair.StringValue);
                    break;
                case 4:
                    this.PaperSize = (pair.StringValue);
                    break;
                case 6:
                    this.PlotViewName = (pair.StringValue);
                    break;
                case 7:
                    this.CurrentStyleSheet = (pair.StringValue);
                    break;
                case 40:
                    this.UnprintableLeftMarginSize = (pair.DoubleValue);
                    break;
                case 41:
                    this.UnprintableBottomMarginSize = (pair.DoubleValue);
                    break;
                case 42:
                    this.UnprintableRightMarginSize = (pair.DoubleValue);
                    break;
                case 43:
                    this.UnprintableTopMarginSize = (pair.DoubleValue);
                    break;
                case 44:
                    this.PaperWidth = (pair.DoubleValue);
                    break;
                case 45:
                    this.PaperHeight = (pair.DoubleValue);
                    break;
                case 46:
                    this.PlotOriginXValue = (pair.DoubleValue);
                    break;
                case 47:
                    this.PlotOriginYValue = (pair.DoubleValue);
                    break;
                case 48:
                    this.PlotWindowLowerLeftXValue = (pair.DoubleValue);
                    break;
                case 49:
                    this.PlotWindowLowerLeftYValue = (pair.DoubleValue);
                    break;
                case 70:
                    this.PlotLayoutFlags = (pair.ShortValue);
                    break;
                case 72:
                    this.PlotPaperUnits = (DxfPlotPaperUnits)(pair.ShortValue);
                    break;
                case 73:
                    this.PlotRotation = (DxfPlotRotation)(pair.ShortValue);
                    break;
                case 74:
                    this.PlotType = (DxfPlotType)(pair.ShortValue);
                    break;
                case 75:
                    this.StandardScale = (DxfStandardScale)(pair.ShortValue);
                    break;
                case 76:
                    this.ShadePlotMode = (DxfShadePlotMode)(pair.ShortValue);
                    break;
                case 77:
                    this.ShadePlotResolutionLevel = (DxfShadePlotResolutionLevel)(pair.ShortValue);
                    break;
                case 78:
                    this.ShadePlotCustomDPI = (pair.ShortValue);
                    break;
                case 140:
                    this.PlotWindowUpperRightXValue = (pair.DoubleValue);
                    break;
                case 141:
                    this.PlotWindowUpperRightYValue = (pair.DoubleValue);
                    break;
                case 142:
                    this.CustomPrintScaleNumerator = (pair.DoubleValue);
                    break;
                case 143:
                    this.CustomPrintScaleDenominator = (pair.DoubleValue);
                    break;
                case 147:
                    this.StandardScaleValue = (pair.DoubleValue);
                    break;
                case 148:
                    this.PaperImageOriginX = (pair.DoubleValue);
                    break;
                case 149:
                    this.PaperImageOriginY = (pair.DoubleValue);
                    break;
                case 333:
                    this.ShadePlotObjectPointer.Handle = DxfCommonConverters.UIntHandle(pair.StringValue);
                    break;
                default:
                    return base.TrySetPair(pair);
            }

            return true;
        }
    }
}
