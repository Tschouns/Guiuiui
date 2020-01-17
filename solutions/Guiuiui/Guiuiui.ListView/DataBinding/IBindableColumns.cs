//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ListView.DataBinding
{
    using System;

    /// <summary>
    /// Provides an interface to bind properties of <typeparamref name="TListItem"/> to columns.
    /// </summary>
    /// <typeparam name="TListItem">
    /// Type of the list item
    /// </typeparam>
    public interface IBindableColumns<TListItem>
    {
        /// <summary>
        /// Adds a (read-only) data binding to a column for the specified property. The columns are assigned
        /// by the order in which this method is called.
        /// By default, if this method is not called at all, the list items will be displayed in the first
        /// column.
        /// </summary>
        /// <typeparam name="TPropertyValue">
        /// Type of the property value
        /// </typeparam>
        IBindableColumns<TListItem> AddColumnBindingForProperty<TPropertyValue>(Func<TListItem, TPropertyValue> getFunc);

        /// <summary>
        /// "Unbinds" all properties and columns.
        /// </summary>
        void UnbindAll();
    }
}
