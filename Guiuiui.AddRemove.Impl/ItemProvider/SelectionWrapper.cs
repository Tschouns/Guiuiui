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
    /// Wrapps an <see cref="ISelection{TListItem}"/> object implements <see cref="IItemProvider{TItem}"/>.
    /// </summary>
    /// <typeparam name="TItem">
    /// Type of the selectable item
    /// </typeparam>
    public class SelectionWrapper<TItem> : IItemProvider<TItem>
        where TItem : class
    {
        private readonly ISelection<TItem> _selection;

        /// <summary>
        /// Initializes a new instance of the <see cref="SelectionWrapper{TItem}"/> class.
        /// </summary>
        public SelectionWrapper(ISelection<TItem> selection)
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
        public IEnumerable<TItem> RetrieveItems()
        {
            return this._selection.SelectedItems;
        }

        private void Selection_SelectedItemsChanged(object sender, EventArgs e)
        {
            this.StateChanged?.Invoke(this, new EventArgs());
        }
    }
}
