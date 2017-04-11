//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ListView.Impl
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Guiuiui.Base.RuntimeChecks;
    using Guiuiui.ListView.DataBinding;
    using Guiuiui.ViewModel.List;

    /// <summary>
    /// See <see cref="IListView{TListItem}"/>.
    /// </summary>
    /// <typeparam name="TListItem">
    /// See <see cref="IListView{TListItem}"/>.
    /// </typeparam>
    public class ListView<TListItem> : IListView<TListItem>
    {
        private readonly ListView _listView;

        /// <summary>
        /// Initializes a new instance of the <see cref="ListView{TListItem}"/> class.
        /// </summary>
        public ListView(ListView listView)
        {
            ArgumentChecks.AssertNotNull(listView, nameof(listView));

            this._listView = listView;
        }

        /// <summary>
        /// See <see cref="IListControl{TListItem}.SetItemsToDisplay"/>.
        /// </summary>
        public void SetItemsToDisplay(IEnumerable<TListItem> items)
        {
            ArgumentChecks.AssertNotNull(items, nameof(items));

            throw new NotImplementedException();
        }

        /// <summary>
        /// See <see cref="IBindableColumns{TListItem}.AddColumnBindingForProperty{TPropertyValue}"/>.
        /// </summary>
        public IBindableColumns<TListItem> AddColumnBindingForProperty<TPropertyValue>(Func<TListItem, TPropertyValue> getFunc)
        {
            throw new NotImplementedException();
        }
    }
}
