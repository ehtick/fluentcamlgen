﻿/***
This File is part of FluentCamlGen

This source is subject to the Microsoft Public License.
See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
All other rights reserved.

THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND,
EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED
WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
***/

using AutoFixture;

using FluentAssertions;

using FluentCamlGen.CamlGen.Elements.Core;

using NUnit.Framework;

namespace FluentCamlGen.CamlGen.Test.Elements.Core
{
    [TestFixture]
    public class ViewFieldsTests : TestBase
    {
        [Test]
        public void BareCgViewFieldsReturnsAViewFieldsTagWithNoAttributes()
        {
            var sut = CG.ViewFields();
            sut.ToString().Should().BeEquivalentTo(@"<ViewFields />");
        }

        [Test]
        public void AddFieldRefReturnsAViewFieldsTagWithAFieldRef()
        {
            var name = Fixture.Create<string>();
            var sut = new ViewFields();
            sut.AddFieldRef(name);
            sut.ToString().Should().BeEquivalentTo(string.Format(@"<ViewFields><FieldRef Name=""{0}"" /></ViewFields>", name));
        }

        [Test]
        public void AddFieldRefWithALambdaReturnsAViewFieldsTagWithAFieldRefAndCallsTheLamda()
        {
            var name = Fixture.Create<string>();
            var attrName = Fixture.Create<string>();
            var attrVal = Fixture.Create<string>();
            var sut = new ViewFields();
            sut.AddFieldRef(name, r => r.AddAttribute(attrName, attrVal));
            sut.ToString().Should().BeEquivalentTo(string.Format(@"<ViewFields><FieldRef Name=""{0}"" {1}=""{2}"" /></ViewFields>", name, attrName, attrVal));
        }
    }
}