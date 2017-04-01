//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.Tools.Impl.Reflection
{
    using System;
    using System.Collections.Generic;
    using Guiuiui.Tools.Reflection;
    using Base.RuntimeChecks;
    using System.Linq;

    /// <summary>
    /// See <see cref="ITypeHelper"/>.
    /// </summary>
    public class TypeHelper : ITypeHelper
    {
        /// <summary>
        /// See <see cref="ITypeHelper.GetInheritedTypes{TType}"/>.
        /// </summary>
        public IReadOnlyList<Type> GetInheritedTypes<TType>()
        {
            return this.GetInheritedTypes(typeof(TType));
        }

        /// <summary>
        /// See <see cref="ITypeHelper.GetInheritedTypes(Type)"/>.
        /// </summary>
        public IReadOnlyList<Type> GetInheritedTypes(Type type)
        {
            ArgumentChecks.AssertNotNull(type, nameof(type));

            IList<Type> allInheritedTypes = new List<Type>();

            // Get all base types...
            var current = type;
            while (current != null)
            {
                allInheritedTypes.Add(current);
                current = current.BaseType;
            }

            // ...and all interfaces (if "type" itself represents an interface, then its BaseType is null).
            var interfaces = type.GetInterfaces();

            foreach(var i in interfaces)
            {
                allInheritedTypes.Add(i);
            }

            // Order.
            var allInheritedTypesOrdered = allInheritedTypes
                .OrderByDescending(t => t, new TypeComparer())
                .ToList();

            return allInheritedTypesOrdered;
        }
    }
}
