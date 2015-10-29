﻿// Copyright (c) IxMilia.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.IO;
using System.Linq;
using IxMilia.Dxf.Objects;
using Xunit;

namespace IxMilia.Dxf.Test
{
    public class DxfObjectTests : AbstractDxfTests
    {
        private DxfObject GenObject(string typeString, string contents)
        {
            return Section("OBJECTS", $@"
  0
{typeString}
{contents.Trim()}
").Objects.Single();
        }

        [Fact]
        public void ReadSimpleObjectTest()
        {
            var proxyObject = GenObject("ACAD_PROXY_OBJECT", "");
            Assert.IsType<DxfAcadProxyObject>(proxyObject);
        }

        [Fact]
        public void WriteSimpleObjectTest()
        {
            var file = new DxfFile();
            file.Objects.Add(new DxfAcadProxyObject());
            VerifyFileContains(file, @"
  0
ACAD_PROXY_OBJECT
  5
A
100
AcDbProxyObject
 90
499
");
        }

        [Fact]
        public void ReadDataTableTest()
        {
            var table = (DxfDataTable)GenObject("DATATABLE", @"
 90
2
 91
2
  1
table-name
 92
10
  2
column-of-points
 10
1
 20
2
 30
3
 10
4
 20
5
 30
6
 92
3
  2
column-of-strings
  3
string 1
  3
string 2
");
            Assert.Equal(2, table.ColumnCount);
            Assert.Equal(2, table.RowCount);
            Assert.Equal("table-name", table.Name);

            Assert.Equal("column-of-points", table.ColumnNames[0]);
            Assert.Equal(new DxfPoint(1, 2, 3), (DxfPoint)table[0, 0]);
            Assert.Equal(new DxfPoint(4, 5, 6), (DxfPoint)table[1, 0]);

            Assert.Equal("column-of-strings", table.ColumnNames[1]);
            Assert.Equal("string 1", (string)table[0, 1]);
            Assert.Equal("string 2", (string)table[1, 1]);
        }

        [Fact]
        public void WriteDataTableTest()
        {
            var table = new DxfDataTable();
            table.Name = "table-name";
            table.SetSize(2, 2);
            table.ColumnNames.Add("column-of-points");
            table.ColumnNames.Add("column-of-strings");
            table[0, 0] = new DxfPoint(1, 2, 3);
            table[1, 0] = new DxfPoint(4, 5, 6);
            table[0, 1] = "string 1";
            table[1, 1] = "string 2";
            var file = new DxfFile();
            file.Objects.Add(table);
            VerifyFileContains(file, @"
  0
DATATABLE
  5
A
100
AcDbDataTable
 70
0
 90
2
 91
2
  1
table-name
 92
10
  2
column-of-points
 10
1.0
 20
2.0
 30
3.0
 10
4.0
 20
5.0
 30
6.0
 92
3
  2
column-of-strings
  3
string 1
  3
string 2
");
        }

        [Fact]
        public void ReadDictionaryTest()
        {
            var dict = (DxfDictionary)GenObject("DICTIONARY", @"
100
AcDbDictionary
280
1
281
1
  3
name-1
350
1
  3
name-2
350
2
  3
name-3
350
3
");
            Assert.True(dict.IsHardOwner);
            Assert.Equal(DxfDictionaryDuplicateRecordHandling.KeepExisting, dict.DuplicateRecordHandling);
            Assert.Equal(3, dict.Count);
            Assert.Equal(1u, dict["name-1"]);
            Assert.Equal(2u, dict["name-2"]);
            Assert.Equal(3u, dict["name-3"]);
        }

        [Fact]
        public void WriteDictionaryTest()
        {
            var dict = new DxfDictionary();
            dict["name-1"] = 1u;
            dict["name-2"] = 2u;
            dict["name-3"] = 3u;
            dict.IsHardOwner = true;
            dict.DuplicateRecordHandling = DxfDictionaryDuplicateRecordHandling.KeepExisting;
            var file = new DxfFile();
            file.Objects.Add(dict);
            VerifyFileContains(file, @"
  0
DICTIONARY
  5
A
100
AcDbDictionary
280
1
281
1
  3
name-1
350
1
  3
name-2
350
2
  3
name-3
350
3
");
        }

        [Fact]
        public void ReadLayoutTest()
        {
            var layout = (DxfLayout)GenObject("LAYOUT", @"
  1
page-setup-name
100
AcDbLayout
  1
layout-name
");
            Assert.Equal("page-setup-name", layout.PageSetupName);
            Assert.Equal("layout-name", layout.LayoutName);
        }

        [Fact]
        public void WriteLayoutTest()
        {
            var layout = new DxfLayout();
            layout.PageSetupName = "page-setup-name";
            layout.LayoutName = "layout-name";
            var file = new DxfFile();
            file.Objects.Add(layout);
            using (var ms = new MemoryStream())
            {
                file.Save(ms);
                ms.Seek(0, SeekOrigin.Begin);
                using (var reader = new StreamReader(ms))
                {
                    var contents = reader.ReadToEnd();

                    // verify the plot settings were written
                    var plotSettingsOffset = contents.IndexOf(@"
100
AcDbPlotSettings
  1
page-setup-name
".Trim());
                    Assert.True(plotSettingsOffset > 0);

                    // verify the layout settings were written
                    var layoutOffset = contents.IndexOf(@"
100
AcDbLayout
  1
layout-name
".Trim());
                    Assert.True(layoutOffset > 0);

                    // verify that the layout settings were written after the plot settings
                    Assert.True(layoutOffset > plotSettingsOffset);
                }
            }
        }

        [Fact]
        public void ReadLightListTest()
        {
            var lightList = (DxfLightList)GenObject("LIGHTLIST", @"
 90
42
 90
3
  5
111
  1
uno
  5
222
  1
dos
  5
333
  1
tres
");
            Assert.Equal(42, lightList.Version);
            Assert.Equal(3, lightList.Lights.Count);

            Assert.Equal(0x111u, lightList.Lights[0].Handle);
            Assert.Equal("uno", lightList.Lights[0].Name);
            Assert.Equal(0x222u, lightList.Lights[1].Handle);
            Assert.Equal("dos", lightList.Lights[1].Name);
            Assert.Equal(0x333u, lightList.Lights[2].Handle);
            Assert.Equal("tres", lightList.Lights[2].Name);
        }

        [Fact]
        public void WriteLightListTest()
        {
            var lightList = new DxfLightList();
            lightList.Version = 42;
            lightList.Lights.Add(new DxfLightList.DxfLightListItem() { Handle = 0x111, Name = "uno" });
            lightList.Lights.Add(new DxfLightList.DxfLightListItem() { Handle = 0x222, Name = "dos" });
            lightList.Lights.Add(new DxfLightList.DxfLightListItem() { Handle = 0x333, Name = "tres" });
            var file = new DxfFile();
            file.Objects.Add(lightList);
            VerifyFileContains(file, @"
 90
42
 90
3
  5
111
  1
uno
  5
222
  1
dos
  5
333
  1
tres
");
        }

        [Fact]
        public void ReadMaterialTest()
        {
            var material = (DxfMaterial)GenObject("MATERIAL", @"
 75
1
 43
1
 43
2
 43
3
 43
4
 43
5
 43
6
 43
7
 43
8
 43
9
 43
10
 43
11
 43
12
 43
13
 43
14
 43
15
 43
16
 75
2
 43
10
 43
20
 43
30
 43
40
 43
50
 43
60
 43
70
 43
80
 43
90
 43
100
 43
110
 43
120
 43
130
 43
140
 43
150
 43
160
");
            Assert.Equal(DxfMapAutoTransformMethod.NoAutoTransform, material.DiffuseMapAutoTransformMethod);
            Assert.Equal(1.0, material.DiffuseMapTransformMatrix.M11);
            Assert.Equal(2.0, material.DiffuseMapTransformMatrix.M12);
            Assert.Equal(3.0, material.DiffuseMapTransformMatrix.M13);
            Assert.Equal(4.0, material.DiffuseMapTransformMatrix.M14);
            Assert.Equal(5.0, material.DiffuseMapTransformMatrix.M21);
            Assert.Equal(6.0, material.DiffuseMapTransformMatrix.M22);
            Assert.Equal(7.0, material.DiffuseMapTransformMatrix.M23);
            Assert.Equal(8.0, material.DiffuseMapTransformMatrix.M24);
            Assert.Equal(9.0, material.DiffuseMapTransformMatrix.M31);
            Assert.Equal(10.0, material.DiffuseMapTransformMatrix.M32);
            Assert.Equal(11.0, material.DiffuseMapTransformMatrix.M33);
            Assert.Equal(12.0, material.DiffuseMapTransformMatrix.M34);
            Assert.Equal(13.0, material.DiffuseMapTransformMatrix.M41);
            Assert.Equal(14.0, material.DiffuseMapTransformMatrix.M42);
            Assert.Equal(15.0, material.DiffuseMapTransformMatrix.M43);
            Assert.Equal(16.0, material.DiffuseMapTransformMatrix.M44);

            Assert.Equal(DxfMapAutoTransformMethod.ScaleToCurrentEntity, material.NormalMapAutoTransformMethod);
            Assert.Equal(10.0, material.NormalMapTransformMatrix.M11);
            Assert.Equal(20.0, material.NormalMapTransformMatrix.M12);
            Assert.Equal(30.0, material.NormalMapTransformMatrix.M13);
            Assert.Equal(40.0, material.NormalMapTransformMatrix.M14);
            Assert.Equal(50.0, material.NormalMapTransformMatrix.M21);
            Assert.Equal(60.0, material.NormalMapTransformMatrix.M22);
            Assert.Equal(70.0, material.NormalMapTransformMatrix.M23);
            Assert.Equal(80.0, material.NormalMapTransformMatrix.M24);
            Assert.Equal(90.0, material.NormalMapTransformMatrix.M31);
            Assert.Equal(100.0, material.NormalMapTransformMatrix.M32);
            Assert.Equal(110.0, material.NormalMapTransformMatrix.M33);
            Assert.Equal(120.0, material.NormalMapTransformMatrix.M34);
            Assert.Equal(130.0, material.NormalMapTransformMatrix.M41);
            Assert.Equal(140.0, material.NormalMapTransformMatrix.M42);
            Assert.Equal(150.0, material.NormalMapTransformMatrix.M43);
            Assert.Equal(160.0, material.NormalMapTransformMatrix.M44);
        }

        [Fact]
        public void WriteAllDefaultObjectsTest()
        {
            var file = new DxfFile();
            var assembly = typeof(DxfFile).Assembly;
            foreach (var type in assembly.GetTypes())
            {
                if (IsDxfObjectOrDerived(type))
                {
                    var ctor = type.GetConstructor(Type.EmptyTypes);
                    if (ctor != null)
                    {
                        // all types deriving from DxfObject with a default constructor
                        var obj = (DxfObject)ctor.Invoke(new object[0]);

                        // add the object with its default initialized values
                        file.Objects.Add(obj);

                        // and create a new object to be nulled out
                        obj = (DxfObject)ctor.Invoke(new object[0]);

                        // set all non-indexer properties to `default(T)`
                        foreach (var property in type.GetProperties().Where(p => p.GetSetMethod() != null && p.GetIndexParameters().Length == 0))
                        {
                            var propertyType = property.PropertyType;
                            var defaultValue = propertyType.IsValueType
                                ? Activator.CreateInstance(propertyType)
                                : null;
                            property.SetValue(obj, defaultValue);
                        }

                        // add it to the file
                        file.Objects.Add(obj);
                    }
                }
            }

            // write each version of the objects with default versions
            foreach (var version in new[] { DxfAcadVersion.R10, DxfAcadVersion.R11, DxfAcadVersion.R12, DxfAcadVersion.R13, DxfAcadVersion.R14, DxfAcadVersion.R2000, DxfAcadVersion.R2004, DxfAcadVersion.R2007, DxfAcadVersion.R2010, DxfAcadVersion.R2013 })
            {
                file.Header.Version = version;
                using (var ms = new MemoryStream())
                {
                    file.Save(ms);
                }
            }
        }

        private static bool IsDxfObjectOrDerived(Type type)
        {
            if (type == typeof(DxfObject))
            {
                return true;
            }

            if (type.BaseType != null)
            {
                return IsDxfObjectOrDerived(type.BaseType);
            }

            return false;
        }
    }
}
