//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.DataBinding
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Provides an interface to bind properties of <typeparamref name="TModel"/> to controls.
    /// </summary>
    /// <typeparam name="TModel">
    /// Type of the underlying data model
    /// </typeparam>
    public interface IBindable<TModel>
        where TModel : class
    {
        /// <summary>
        /// Binds the specified property read-only.
        /// </summary>
        /// <typeparam name="TPropertyValue">
        /// Type of the property value
        /// </typeparam>
        IReadOnlyPropertyPredicate BindPropertyGet<TPropertyValue>(Func<TModel, TPropertyValue> getFunc);

        /// <summary>
        /// Binds the specified property two-way.
        /// </summary>
        /// <typeparam name="TPropertyValue">
        /// Type of the property value
        /// </typeparam>
        ITwoWayPropertyPredicate BindPropertyGetAndSet<TPropertyValue>(Func<TModel, TPropertyValue> getFunc, Action<TModel, TPropertyValue> setAction);

        /// <summary>
        /// Binds the specified list property.
        /// </summary>
        /// <typeparam name="TListItem">
        /// Type of the list item
        /// </typeparam>
        IListPropertyPredicate<TListItem> BindListProperty<TListItem>(Func<TModel, IEnumerable<TListItem>> getFunc);

        /// <summary>
        /// "Unbinds" all properties and controls.
        /// </summary>
        void UnbindAll();
    }
}
