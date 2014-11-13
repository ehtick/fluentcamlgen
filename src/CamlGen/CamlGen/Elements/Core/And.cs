﻿/***
This File is part of FluentCamlGen

This source is subject to the Microsoft Public License.
See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
All other rights reserved.

THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
***/

using System;
using System.Collections.Generic;

namespace FluentCamlGen.CamlGen.Elements.Core
{
    /// <summary>
    /// &lt;And> ... &lt;/And>
    /// <see cref="http://msdn.microsoft.com/en-us/library/ms196939.aspx"/>
    /// </summary>
    public class And : BaseCoreElement
    {
        internal And()
            : this(null)
        {
        }

        internal And(IEnumerable<BaseElement> inner)
            : base("And", null, inner)
        {
        }

        /// <summary>
        /// Add an &lt;Eq>-Tag
        /// </summary>
        /// <returns><see cref="And"/></returns>
        public And Eq()
        {
            return Eq(x => { });
        }

        /// <summary>
        /// Add an &lt;Eq>-Tag
        /// </summary>
        /// <returns><see cref="And"/></returns>
        public And Eq(Action<Eq> action)
        {
            var eq = new Eq();
            action(eq);
            Childs.Add(eq);
            return this;
        }

        /// <summary>
        /// Add a &lt;Neq>-Tag
        /// </summary>
        /// <returns><see cref="And"/></returns>
        public And Neq()
        {
            return Neq(x => { });
        }

        /// <summary>
        /// Add a &lt;Neq>-Tag
        /// </summary>
        /// <returns><see cref="And"/></returns>
        public And Neq(Action<Neq> action)
        {
            var neq = new Neq();
            action(neq);
            Childs.Add(neq);
            return this;
        }

        /// <summary>
        /// Add a &lt;Gt>-Tag
        /// </summary>
        /// <returns><see cref="And"/></returns>
        public And Gt()
        {
            return Gt(x => { });
        }

        /// <summary>
        /// Add a &lt;Gt>-Tag
        /// </summary>
        /// <returns><see cref="And"/></returns>
        public And Gt(Action<Gt> action)
        {
            var gt = new Gt();
            action(gt);
            Childs.Add(gt);
            return this;
        }

        /// <summary>
        /// Add a &lt;Geq>-Tag
        /// </summary>
        /// <returns><see cref="And"/></returns>
        public And Geq()
        {
            return Geq(x => { });
        }

        /// <summary>
        /// Add a &lt;Geq>-Tag
        /// </summary>
        /// <returns><see cref="And"/></returns>
        public And Geq(Action<Geq> action)
        {
            var geq = new Geq();
            action(geq);
            Childs.Add(geq);
            return this;
        }

        /// <summary>
        /// Add a &lt;Lt>-Tag
        /// </summary>
        /// <returns><see cref="And"/></returns>
        public And Lt()
        {
            return Lt(x => { });
        }

        /// <summary>
        /// Add a &lt;Lt>-Tag
        /// </summary>
        /// <returns><see cref="And"/></returns>
        public And Lt(Action<Lt> action)
        {
            var lt = new Lt();
            action(lt);
            Childs.Add(lt);
            return this;
        }

        /// <summary>
        /// Add a &lt;Leq>-Tag
        /// </summary>
        /// <returns><see cref="And"/></returns>
        public And Leq()
        {
            return Leq(x => { });
        }

        /// <summary>
        /// Add a &lt;Leq>-Tag
        /// </summary>
        /// <returns><see cref="And"/></returns>
        public And Leq(Action<Leq> action)
        {
            var leq = new Leq();
            action(leq);
            Childs.Add(leq);
            return this;
        }

        /// <summary>
        /// Add a nested &lt;And>-Tag
        /// </summary>
        /// <returns><see cref="And"/></returns>
        public And NestedAnd(Action<And> action)
        {
            var and = new And();
            action(and);
            Childs.Add(and);
            return this;
        }

        /// <summary>
        /// Add an &lt;Or>-Tag
        /// </summary>
        /// <returns><see cref="And"/></returns>
        public And Or(Action<Or> action)
        {
            var or = new Or();
            action(or);
            Childs.Add(or);
            return this;
        }
    }
}