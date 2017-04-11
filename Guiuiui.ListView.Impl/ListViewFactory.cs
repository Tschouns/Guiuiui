//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ListView.Impl
{
    using Base.RuntimeChecks;
    using System.Windows.Forms;

    /// <summary>
    /// See <see cref="IListViewFactory"/>.
    /// </summary>
    public class ListViewFactory : IListViewFactory
    {
        /// <summary>
        /// See <see cref="IListViewFactory.CreateListView{TListItem}(System.Windows.Forms.ListView)"/>.
        /// </summary>
        /// <typeparam name="TListItem">
        /// See <see cref="IListViewFactory.CreateListView{TListItem}(System.Windows.Forms.ListView)"/>.
        /// </typeparam>
        public IListView<TListItem> CreateListView<TListItem>(ListView listView)
        {
            ArgumentChecks.AssertNotNull(listView, nameof(listView));

            var newListView = new ListView<TListItem>(listView);

            return newListView;
        }
    }
}
