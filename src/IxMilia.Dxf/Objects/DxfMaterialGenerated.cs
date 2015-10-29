// Copyright (c) IxMilia.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

// The contents of this file are automatically generated by a tool, and should not be directly modified.

using System;
using System.Collections.Generic;
using System.Linq;

namespace IxMilia.Dxf.Objects
{

    /// <summary>
    /// DxfMaterial class
    /// </summary>
    public partial class DxfMaterial : DxfObject
    {
        public override DxfObjectType ObjectType { get { return DxfObjectType.Material; } }

        public string Name { get; set; }
        public string Description { get; set; }
        public bool OverrideAmbientColor { get; set; }
        public double AmbientColorFactor { get; set; }
        public int AmbientColorValue { get; set; }
        public bool OverrideDiffuseColor { get; set; }
        public double DiffuseColorFactor { get; set; }
        public int DiffuseColorValue { get; set; }
        public double DiffuseMapBlendFactor { get; set; }
        public bool UseImageFileForDiffuseMap { get; set; }
        public string DiffuseMapFileName { get; set; }
        public DxfMapProjectionMethod DiffuseMapProjectionMethod { get; set; }
        public DxfMapTilingMethod DiffuseMapTilingMethod { get; set; }
        public DxfMapAutoTransformMethod DiffuseMapAutoTransformMethod { get; set; }
        private List<double> _diffuseMapTransformMatrixValues { get; set; }
        public double SpecularGlossFactor { get; set; }
        public bool OverrideSpecularColor { get; set; }
        public double SpecularColorFactor { get; set; }
        public int SpecularColorValue { get; set; }
        public double SpecularMapBlendFactor { get; set; }
        public bool UseImageFileForSpecularMap { get; set; }
        public string SpecularMapFileName { get; set; }
        public DxfMapProjectionMethod SpecularMapProjectionMethod { get; set; }
        public DxfMapTilingMethod SpecularMapTilingMethod { get; set; }
        public DxfMapAutoTransformMethod SpecularMapAutoTransformMethod { get; set; }
        private List<double> _specularMapTransformMatrixValues { get; set; }
        public double ReflectionMapBlendFactor { get; set; }
        public bool UseImageFileForReflectionMap { get; set; }
        public string ReflectionMapFileName { get; set; }
        public DxfMapProjectionMethod ReflectionMapProjectionMethod { get; set; }
        public DxfMapTilingMethod ReflectionMapTilingMethod { get; set; }
        public DxfMapAutoTransformMethod ReflectionMapAutoTransformMethod { get; set; }
        private List<double> _reflectionMapTransformMatrixValues { get; set; }
        public double OpacityFactor { get; set; }
        public double OpacityMapBlendFactor { get; set; }
        public bool UseImageFileForOpacityMap { get; set; }
        public string OpacityMapFileName { get; set; }
        public DxfMapProjectionMethod OpacityMapProjectionMethod { get; set; }
        public DxfMapTilingMethod OpacityMapTilingMethod { get; set; }
        public DxfMapAutoTransformMethod OpacityMapAutoTransformMethod { get; set; }
        private List<double> _opacityMapTransformMatrixValues { get; set; }
        public double BumpMapBlendFactor { get; set; }
        public bool UseImageFileForBumpMap { get; set; }
        public string BumpMapFileName { get; set; }
        public DxfMapProjectionMethod BumpMapProjectionMethod { get; set; }
        public DxfMapTilingMethod BumpMapTilingMethod { get; set; }
        public DxfMapAutoTransformMethod BumpMapAutoTransformMethod { get; set; }
        private List<double> _bumpMapTransformMatrixValues { get; set; }
        public double RefractionIndex { get; set; }
        public double RefractionMapBlendFactor { get; set; }
        public bool UseImageFileForRefractionMap { get; set; }
        public string RefractionMapFileName { get; set; }
        public DxfMapProjectionMethod RefractionMapProjectionMethod { get; set; }
        public DxfMapTilingMethod RefractionMapTilingMethod { get; set; }
        public DxfMapAutoTransformMethod RefractionMapAutoTransformMethod { get; set; }
        private List<double> _refractionMapTransformMatrixValues { get; set; }
        public double ColorBleedScale { get; set; }
        public double IndirectDumpScale { get; set; }
        public double ReflectanceScale { get; set; }
        public double TransmittanceScale { get; set; }
        public bool IsTwoSided { get; set; }
        public double Luminance { get; set; }
        public short LuminanceMode { get; set; }
        public short NormalMapMethod { get; set; }
        public double NormalMapStrength { get; set; }
        public double NormalMapBlendFactor { get; set; }
        public bool UseImageFileForNormalMap { get; set; }
        public string NormalMapFileName { get; set; }
        public DxfMapProjectionMethod NormalMapProjectionMethod { get; set; }
        public DxfMapTilingMethod NormalMapTilingMethod { get; set; }
        public DxfMapAutoTransformMethod NormalMapAutoTransformMethod { get; set; }
        private List<double> _normalMapTransformMatrixValues { get; set; }
        public bool IsAnonymous { get; set; }
        public short GlobalIlluminationMode { get; set; }
        public short FinalGatherMode { get; set; }
        public string GenProcName { get; set; }
        public bool GenProcBooleanValue { get; set; }
        public short GenProcIntegerValue { get; set; }
        public double GenProcRealValue { get; set; }
        public string GenProcTextValue { get; set; }
        public bool GenProcTableEnd { get; set; }
        public DxfColor GenProcColorIndexValue { get; set; }
        public int GenProcColorRGBValue { get; set; }
        public string GenProcColorName { get; set; }
        public short MapUTile { get; set; }
        public double Translucence { get; set; }
        public int SelfIllumination { get; set; }
        public double Reflectivity { get; set; }
        public int IlluminationModel { get; set; }
        public int ChannelFlags { get; set; }

        public DxfMaterial()
            : base()
        {
        }

        protected override void Initialize()
        {
            base.Initialize();
            this.Name = null;
            this.Description = null;
            this.OverrideAmbientColor = false;
            this.AmbientColorFactor = 1.0;
            this.AmbientColorValue = 0;
            this.OverrideDiffuseColor = false;
            this.DiffuseColorFactor = 1.0;
            this.DiffuseColorValue = 0;
            this.DiffuseMapBlendFactor = 1.0;
            this.UseImageFileForDiffuseMap = false;
            this.DiffuseMapFileName = null;
            this.DiffuseMapProjectionMethod = DxfMapProjectionMethod.Planar;
            this.DiffuseMapTilingMethod = DxfMapTilingMethod.Tile;
            this.DiffuseMapAutoTransformMethod = DxfMapAutoTransformMethod.NoAutoTransform;
            this._diffuseMapTransformMatrixValues = new List<double>();
            this.SpecularGlossFactor = 0.5;
            this.OverrideSpecularColor = false;
            this.SpecularColorFactor = 1.0;
            this.SpecularColorValue = 0;
            this.SpecularMapBlendFactor = 1.0;
            this.UseImageFileForSpecularMap = false;
            this.SpecularMapFileName = null;
            this.SpecularMapProjectionMethod = DxfMapProjectionMethod.Planar;
            this.SpecularMapTilingMethod = DxfMapTilingMethod.Tile;
            this.SpecularMapAutoTransformMethod = DxfMapAutoTransformMethod.NoAutoTransform;
            this._specularMapTransformMatrixValues = new List<double>();
            this.ReflectionMapBlendFactor = 1.0;
            this.UseImageFileForReflectionMap = false;
            this.ReflectionMapFileName = null;
            this.ReflectionMapProjectionMethod = DxfMapProjectionMethod.Planar;
            this.ReflectionMapTilingMethod = DxfMapTilingMethod.Tile;
            this.ReflectionMapAutoTransformMethod = DxfMapAutoTransformMethod.NoAutoTransform;
            this._reflectionMapTransformMatrixValues = new List<double>();
            this.OpacityFactor = 1.0;
            this.OpacityMapBlendFactor = 1.0;
            this.UseImageFileForOpacityMap = false;
            this.OpacityMapFileName = null;
            this.OpacityMapProjectionMethod = DxfMapProjectionMethod.Planar;
            this.OpacityMapTilingMethod = DxfMapTilingMethod.Tile;
            this.OpacityMapAutoTransformMethod = DxfMapAutoTransformMethod.NoAutoTransform;
            this._opacityMapTransformMatrixValues = new List<double>();
            this.BumpMapBlendFactor = 1.0;
            this.UseImageFileForBumpMap = false;
            this.BumpMapFileName = null;
            this.BumpMapProjectionMethod = DxfMapProjectionMethod.Planar;
            this.BumpMapTilingMethod = DxfMapTilingMethod.Tile;
            this.BumpMapAutoTransformMethod = DxfMapAutoTransformMethod.NoAutoTransform;
            this._bumpMapTransformMatrixValues = new List<double>();
            this.RefractionIndex = 1.0;
            this.RefractionMapBlendFactor = 1.0;
            this.UseImageFileForRefractionMap = false;
            this.RefractionMapFileName = null;
            this.RefractionMapProjectionMethod = DxfMapProjectionMethod.Planar;
            this.RefractionMapTilingMethod = DxfMapTilingMethod.Tile;
            this.RefractionMapAutoTransformMethod = DxfMapAutoTransformMethod.NoAutoTransform;
            this._refractionMapTransformMatrixValues = new List<double>();
            this.ColorBleedScale = 0.0;
            this.IndirectDumpScale = 0.0;
            this.ReflectanceScale = 0.0;
            this.TransmittanceScale = 0.0;
            this.IsTwoSided = false;
            this.Luminance = 0.0;
            this.LuminanceMode = 0;
            this.NormalMapMethod = 0;
            this.NormalMapStrength = 1.0;
            this.NormalMapBlendFactor = 1.0;
            this.UseImageFileForNormalMap = false;
            this.NormalMapFileName = null;
            this.NormalMapProjectionMethod = DxfMapProjectionMethod.Planar;
            this.NormalMapTilingMethod = DxfMapTilingMethod.Tile;
            this.NormalMapAutoTransformMethod = DxfMapAutoTransformMethod.NoAutoTransform;
            this._normalMapTransformMatrixValues = new List<double>();
            this.IsAnonymous = false;
            this.GlobalIlluminationMode = 0;
            this.FinalGatherMode = 0;
            this.GenProcName = null;
            this.GenProcBooleanValue = false;
            this.GenProcIntegerValue = 0;
            this.GenProcRealValue = 0.0;
            this.GenProcTextValue = null;
            this.GenProcTableEnd = false;
            this.GenProcColorIndexValue = DxfColor.ByLayer;
            this.GenProcColorRGBValue = 0;
            this.GenProcColorName = null;
            this.MapUTile = 0;
            this.Translucence = 0.0;
            this.SelfIllumination = 0;
            this.Reflectivity = 0.0;
            this.IlluminationModel = 0;
            this.ChannelFlags = 0;
        }

        protected override void AddValuePairs(List<DxfCodePair> pairs, DxfAcadVersion version, bool outputHandles)
        {
            base.AddValuePairs(pairs, version, outputHandles);
            pairs.Add(new DxfCodePair(1, (this.Name)));
            pairs.Add(new DxfCodePair(2, (this.Description)));
            pairs.Add(new DxfCodePair(70, BoolShort(this.OverrideAmbientColor)));
            pairs.Add(new DxfCodePair(40, (this.AmbientColorFactor)));
            pairs.Add(new DxfCodePair(90, (this.AmbientColorValue)));
            pairs.Add(new DxfCodePair(71, BoolShort(this.OverrideDiffuseColor)));
            pairs.Add(new DxfCodePair(41, (this.DiffuseColorFactor)));
            pairs.Add(new DxfCodePair(91, (this.DiffuseColorValue)));
            pairs.Add(new DxfCodePair(42, (this.DiffuseMapBlendFactor)));
            pairs.Add(new DxfCodePair(72, BoolShort(this.UseImageFileForDiffuseMap)));
            pairs.Add(new DxfCodePair(3, (this.DiffuseMapFileName)));
            pairs.Add(new DxfCodePair(73, (short)(this.DiffuseMapProjectionMethod)));
            pairs.Add(new DxfCodePair(74, (short)(this.DiffuseMapTilingMethod)));
            pairs.Add(new DxfCodePair(75, (short)(this.DiffuseMapAutoTransformMethod)));
            foreach (var item in DiffuseMapTransformMatrix?.GetValues() ?? new double[0])
            {
                pairs.Add(new DxfCodePair(43, item));
            }

            pairs.Add(new DxfCodePair(44, (this.SpecularGlossFactor)));
            pairs.Add(new DxfCodePair(76, BoolShort(this.OverrideSpecularColor)));
            pairs.Add(new DxfCodePair(45, (this.SpecularColorFactor)));
            pairs.Add(new DxfCodePair(92, (this.SpecularColorValue)));
            pairs.Add(new DxfCodePair(46, (this.SpecularMapBlendFactor)));
            pairs.Add(new DxfCodePair(77, BoolShort(this.UseImageFileForSpecularMap)));
            pairs.Add(new DxfCodePair(4, (this.SpecularMapFileName)));
            pairs.Add(new DxfCodePair(78, (short)(this.SpecularMapProjectionMethod)));
            pairs.Add(new DxfCodePair(79, (short)(this.SpecularMapTilingMethod)));
            pairs.Add(new DxfCodePair(170, (short)(this.SpecularMapAutoTransformMethod)));
            foreach (var item in SpecularMapTransformMatrix?.GetValues() ?? new double[0])
            {
                pairs.Add(new DxfCodePair(47, item));
            }

            pairs.Add(new DxfCodePair(48, (this.ReflectionMapBlendFactor)));
            pairs.Add(new DxfCodePair(171, BoolShort(this.UseImageFileForReflectionMap)));
            pairs.Add(new DxfCodePair(6, (this.ReflectionMapFileName)));
            pairs.Add(new DxfCodePair(172, (short)(this.ReflectionMapProjectionMethod)));
            pairs.Add(new DxfCodePair(173, (short)(this.ReflectionMapTilingMethod)));
            pairs.Add(new DxfCodePair(174, (short)(this.ReflectionMapAutoTransformMethod)));
            foreach (var item in ReflectionMapTransformMatrix?.GetValues() ?? new double[0])
            {
                pairs.Add(new DxfCodePair(49, item));
            }

            pairs.Add(new DxfCodePair(140, (this.OpacityFactor)));
            pairs.Add(new DxfCodePair(141, (this.OpacityMapBlendFactor)));
            pairs.Add(new DxfCodePair(175, BoolShort(this.UseImageFileForOpacityMap)));
            pairs.Add(new DxfCodePair(7, (this.OpacityMapFileName)));
            pairs.Add(new DxfCodePair(176, (short)(this.OpacityMapProjectionMethod)));
            pairs.Add(new DxfCodePair(177, (short)(this.OpacityMapTilingMethod)));
            pairs.Add(new DxfCodePair(178, (short)(this.OpacityMapAutoTransformMethod)));
            foreach (var item in OpacityMapTransformMatrix?.GetValues() ?? new double[0])
            {
                pairs.Add(new DxfCodePair(142, item));
            }

            pairs.Add(new DxfCodePair(143, (this.BumpMapBlendFactor)));
            pairs.Add(new DxfCodePair(179, BoolShort(this.UseImageFileForBumpMap)));
            pairs.Add(new DxfCodePair(8, (this.BumpMapFileName)));
            pairs.Add(new DxfCodePair(270, (short)(this.BumpMapProjectionMethod)));
            pairs.Add(new DxfCodePair(271, (short)(this.BumpMapTilingMethod)));
            pairs.Add(new DxfCodePair(272, (short)(this.BumpMapAutoTransformMethod)));
            foreach (var item in BumpMapTransformMatrix?.GetValues() ?? new double[0])
            {
                pairs.Add(new DxfCodePair(144, item));
            }

            pairs.Add(new DxfCodePair(145, (this.RefractionIndex)));
            pairs.Add(new DxfCodePair(146, (this.RefractionMapBlendFactor)));
            pairs.Add(new DxfCodePair(273, BoolShort(this.UseImageFileForRefractionMap)));
            pairs.Add(new DxfCodePair(9, (this.RefractionMapFileName)));
            pairs.Add(new DxfCodePair(274, (short)(this.RefractionMapProjectionMethod)));
            pairs.Add(new DxfCodePair(275, (short)(this.RefractionMapTilingMethod)));
            pairs.Add(new DxfCodePair(276, (short)(this.RefractionMapAutoTransformMethod)));
            foreach (var item in RefractionMapTransformMatrix?.GetValues() ?? new double[0])
            {
                pairs.Add(new DxfCodePair(147, item));
            }

            pairs.Add(new DxfCodePair(460, (this.ColorBleedScale)));
            pairs.Add(new DxfCodePair(461, (this.IndirectDumpScale)));
            pairs.Add(new DxfCodePair(462, (this.ReflectanceScale)));
            pairs.Add(new DxfCodePair(463, (this.TransmittanceScale)));
            pairs.Add(new DxfCodePair(290, (this.IsTwoSided)));
            pairs.Add(new DxfCodePair(464, (this.Luminance)));
            pairs.Add(new DxfCodePair(270, (this.LuminanceMode)));
            pairs.Add(new DxfCodePair(271, (this.NormalMapMethod)));
            pairs.Add(new DxfCodePair(465, (this.NormalMapStrength)));
            pairs.Add(new DxfCodePair(42, (this.NormalMapBlendFactor)));
            pairs.Add(new DxfCodePair(72, BoolShort(this.UseImageFileForNormalMap)));
            pairs.Add(new DxfCodePair(3, (this.NormalMapFileName)));
            pairs.Add(new DxfCodePair(73, (short)(this.NormalMapProjectionMethod)));
            pairs.Add(new DxfCodePair(74, (short)(this.NormalMapTilingMethod)));
            pairs.Add(new DxfCodePair(75, (short)(this.NormalMapAutoTransformMethod)));
            foreach (var item in NormalMapTransformMatrix?.GetValues() ?? new double[0])
            {
                pairs.Add(new DxfCodePair(43, item));
            }

            pairs.Add(new DxfCodePair(293, (this.IsAnonymous)));
            pairs.Add(new DxfCodePair(272, (this.GlobalIlluminationMode)));
            pairs.Add(new DxfCodePair(273, (this.FinalGatherMode)));
            pairs.Add(new DxfCodePair(300, (this.GenProcName)));
            pairs.Add(new DxfCodePair(291, (this.GenProcBooleanValue)));
            pairs.Add(new DxfCodePair(271, (this.GenProcIntegerValue)));
            pairs.Add(new DxfCodePair(469, (this.GenProcRealValue)));
            pairs.Add(new DxfCodePair(301, (this.GenProcTextValue)));
            pairs.Add(new DxfCodePair(292, (this.GenProcTableEnd)));
            pairs.Add(new DxfCodePair(62, GetRawValue(this.GenProcColorIndexValue)));
            pairs.Add(new DxfCodePair(420, (this.GenProcColorRGBValue)));
            pairs.Add(new DxfCodePair(430, (this.GenProcColorName)));
            pairs.Add(new DxfCodePair(270, (this.MapUTile)));
            pairs.Add(new DxfCodePair(148, (this.Translucence)));
            pairs.Add(new DxfCodePair(90, (this.SelfIllumination)));
            pairs.Add(new DxfCodePair(468, (this.Reflectivity)));
            pairs.Add(new DxfCodePair(93, (this.IlluminationModel)));
            pairs.Add(new DxfCodePair(94, (this.ChannelFlags)));
        }
    }

}
