//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.List
{
    using System.Collections.Generic;

    /// <summary>
    /// Represents a control which displayes a list of models.
    /// </summary>
    /// <typeparam name="TListItem">
    /// Type of the list item
    /// </typeparam>
    public interface IListControl<TListItem>
    {
        /// <summary>
        /// Sets the items which are to be displayed in the list.
        /// </summary>
        void SetItemsToDisplay(IEnumerable<TListItem> items);
    }
}
