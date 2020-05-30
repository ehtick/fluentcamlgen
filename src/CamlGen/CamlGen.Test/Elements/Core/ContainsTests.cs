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
    public class ContainsTests : TestBase
    {
        [Test]
        public void BareEqReturnsAnEqTagWithNoAttributes()
        {
            var lhs = Fixture.Create<BaseCoreElement>();
            var rhs = Fixture.Create<BaseCoreElement>();
            var sut = CG.Contains(lhs, rhs);
            sut.ToString().Should().BeEquivalentTo(string.Format(@"<Contains>{0}{1}</Contains>", lhs, rhs));
        }

        [Test]
        public void AddFieldRefAddsAFieldRefToTheElement()
        {
            var field = Fixture.Create<string>();
            var value = Fixture.Create<string>();
            var sut = new CamlGen.Elements.Core.Contains();
            sut.AddFieldRef(field);
            sut.AddValue(CG.ValueType.Text, value);

            sut.ToString().Should().BeEquivalentTo(string.Format(@"<Contains><FieldRef Name=""{0}"" /><Value Type=""Text"">{1}</Value></Contains>", field, value));
        }
    }
}