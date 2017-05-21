//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.List
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Represents a selection of items.
    /// </summary>
    /// <typeparam name="TListItem">
    /// Type of the selectable list item
    /// </typeparam>
    public interface ISelection<TListItem>
    {
        /// <summary>
        /// Raised when the selected items have changed.
        /// </summary>
        event EventHandler SelectedItemsChanged;

        /// <summary>
        /// Gets the selected items.
        /// </summary>
        IEnumerable<TListItem> SelectedItems { get; }
    }
}
