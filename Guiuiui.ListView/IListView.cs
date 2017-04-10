//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ListView
{
    using Guiuiui.ListView.DataBinding;
    using Guiuiui.ViewModel.List;

    /// <summary>
    /// Represents a list view. Displays a list of items.
    /// </summary>
    /// <typeparam name="TListItem">
    /// Type of the list item
    /// </typeparam>
    public interface IListView<TListItem> : IListControl<TListItem>, IBindableColumns<TListItem>
    {
    }
}
