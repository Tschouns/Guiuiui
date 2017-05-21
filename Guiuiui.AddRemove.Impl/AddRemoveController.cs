//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.AddRemove.Impl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Base.RuntimeChecks;
    using ViewModel.List;

    /// <summary>
    /// Implements <see cref="IAddRemove"/>. Orchestrates the "add" and "remove" processes.
    /// </summary>
    /// <typeparam name="TCollectionItem">
    /// Type of the items in the collection
    /// </typeparam>
    public class AddRemoveController<TCollectionItem> : IAddRemove
        where TCollectionItem : class
    {
        private readonly Func<ICollection<TCollectionItem>> _getItemCollectionFunc;
        private readonly IItemProvider<TCollectionItem> _itemProvider;
        private readonly ISelection<TCollectionItem> _selection;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddRemoveController{TItem}"/> class.
        /// </summary>
        public AddRemoveController(
            Func<ICollection<TCollectionItem>> getItemCollectionFunc,
            IItemProvider<TCollectionItem> itemProvider,
            ISelection<TCollectionItem> selection)
        {
            ArgumentChecks.AssertNotNull(getItemCollectionFunc, nameof(getItemCollectionFunc));
            ArgumentChecks.AssertNotNull(itemProvider, nameof(itemProvider));
            ArgumentChecks.AssertNotNull(selection, nameof(selection));

            this._getItemCollectionFunc = getItemCollectionFunc;
            this._itemProvider = itemProvider;
            this._selection = selection;

            this._itemProvider.StateChanged += this.ItemProvider_StateChanged;
            this._selection.SelectedItemsChanged += this.Selection_SelectedItemsChanged;
        }

        /// <summary>
        /// See <see cref="IAddRemove.StateChanged"/>.
        /// </summary>
        public event EventHandler StateChanged;

        /// <summary>
        /// See <see cref="IAddRemove.IsAddPossible"/>.
        /// </summary>
        public bool IsAddPossible
        {
            get
            {
                return this._itemProvider.IsRetrievePossible;
            }
        }

        /// <summary>
        /// See <see cref="IAddRemove.IsRemovePossible"/>.
        /// </summary>
        public bool IsRemovePossible
        {
            get
            {
                return this._selection.SelectedItems.Any();
            }
        }

        /// <summary>
        /// See <see cref="IAddRemove.TryAdd"/>.
        /// </summary>
        public bool TryAdd()
        {
            var collection = this._getItemCollectionFunc();
            var items = this._itemProvider.RetrieveItems();

            if (!items.Any())
            {
                return false;
            }

            // Add the all the items.
            foreach(var item in items)
            {
                collection.Add(item);
            }

            return true;
        }

        /// <summary>
        /// See <see cref="IAddRemove.TryRemove"/>.
        /// </summary>
        public bool TryRemove()
        {
            var collection = this._getItemCollectionFunc();
            var selectedItemsInCollection = this._selection.SelectedItems
                .Where(i => collection.Contains(i))
                .ToList();
            
            if (!selectedItemsInCollection.Any())
            {
                return false;
            }

            // Remove all the items.
            foreach(var item in selectedItemsInCollection)
            {
                collection.Remove(item);
            }

            return true;
        }

        private void ItemProvider_StateChanged(object sender, EventArgs e)
        {
            this.StateChanged?.Invoke(this, new EventArgs());
        }

        private void Selection_SelectedItemsChanged(object sender, EventArgs e)
        {
            this.StateChanged?.Invoke(this, new EventArgs());
        }
    }
}
