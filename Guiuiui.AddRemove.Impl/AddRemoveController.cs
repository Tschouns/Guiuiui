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
    using AddRemove.ItemProvider;
    using Base.RuntimeChecks;

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
        private readonly IItemProvider<TCollectionItem> _addItemProvider;
        private readonly IItemProvider<TCollectionItem> _removeItemProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddRemoveController{TItem}"/> class.
        /// </summary>
        public AddRemoveController(
            Func<ICollection<TCollectionItem>> getItemCollectionFunc,
            IItemProvider<TCollectionItem> addItemProvider,
            IItemProvider<TCollectionItem> removeItemProvider)
        {
            ArgumentChecks.AssertNotNull(getItemCollectionFunc, nameof(getItemCollectionFunc));
            ArgumentChecks.AssertNotNull(addItemProvider, nameof(addItemProvider));
            ArgumentChecks.AssertNotNull(removeItemProvider, nameof(removeItemProvider));

            this._getItemCollectionFunc = getItemCollectionFunc;
            this._addItemProvider = addItemProvider;
            this._removeItemProvider = removeItemProvider;

            this._addItemProvider.StateChanged += this.ItemProvider_StateChanged;
            this._removeItemProvider.StateChanged += this.ItemProvider_StateChanged;
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
                return this._addItemProvider.IsRetrievePossible;
            }
        }

        /// <summary>
        /// See <see cref="IAddRemove.IsRemovePossible"/>.
        /// </summary>
        public bool IsRemovePossible
        {
            get
            {
                return this._removeItemProvider.IsRetrievePossible;
            }
        }

        /// <summary>
        /// See <see cref="IAddRemove.TryAdd"/>.
        /// </summary>
        public bool TryAdd()
        {
            var collection = this._getItemCollectionFunc();
            var itemsNotAlreadyInCollection = this._addItemProvider.RetrieveItems()
                .Where(i => !collection.Contains(i))
                .ToList();

            if (!itemsNotAlreadyInCollection.Any())
            {
                return false;
            }

            // Add the all the items.
            foreach(var item in itemsNotAlreadyInCollection)
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
            var selectedItemsInCollection = this._removeItemProvider.RetrieveItems()
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
    }
}
