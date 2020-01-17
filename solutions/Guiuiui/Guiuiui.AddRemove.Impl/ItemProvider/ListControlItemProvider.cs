//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.AddRemove.Impl.ItemProvider
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using AddRemove.ItemProvider;
    using Base.RuntimeChecks;
    using Guiuiui.AddRemove;
    using ViewModel.List;

    /// <summary>
    /// Wrapps an <see cref="IListControl{TListItem}"/> object implements <see cref="IItemProvider{TItem}"/>.
    /// </summary>
    /// <typeparam name="TListItem">
    /// Type of the list item
    /// </typeparam>
    public class ListControlItemProvider<TListItem> : IItemProvider<TListItem>
        where TListItem : class
    {
        private readonly IListControl<TListItem> _selection;

        /// <summary>
        /// Initializes a new instance of the <see cref="ListControlItemProvider{TItem}"/> class.
        /// </summary>
        public ListControlItemProvider(IListControl<TListItem> selection)
        {
            ArgumentChecks.AssertNotNull(selection, nameof(selection));

            this._selection = selection;
            this._selection.SelectedItemsChanged += this.Selection_SelectedItemsChanged;
        }

        /// <summary>
        /// See <see cref="IItemProvider{TItem}.StateChanged"/>.
        /// </summary>
        public event EventHandler StateChanged;

        /// <summary>
        /// See <see cref="IItemProvider{TItem}.IsRetrievePossible"/>.
        /// </summary>
        public bool IsRetrievePossible
        {
            get
            {
                return this._selection.SelectedItems.Any();
            }
        }

        /// <summary>
        /// See <see cref="IItemProvider{TItem}.RetrieveItems"/>.
        /// </summary>
        public IEnumerable<TListItem> RetrieveItems()
        {
            return this._selection.SelectedItems;
        }

        private void Selection_SelectedItemsChanged(object sender, EventArgs e)
        {
            this.StateChanged?.Invoke(this, new EventArgs());
        }
    }
}
