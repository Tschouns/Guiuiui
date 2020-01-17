//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ListView
{
    using System.Windows.Forms;

    /// <summary>
    /// Creates new instances of <see cref="IListView{TListItem}"/>.
    /// </summary>
    public interface IListViewFactory
    {
        /// <summary>
        /// Creates a <see cref="IListView{TListItem}"/>.
        /// </summary>
        /// <typeparam name="TListItem">
        /// Type of the list item
        /// </typeparam>
        IListView<TListItem> Create<TListItem>(ListView listView)
            where TListItem : class;
    }
}
