//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.AddRemove
{
    using System;
    using System.Collections.Generic;
    using Guiuiui.AddRemove.ItemProvider;
    using Guiuiui.ViewModel.List;
    using ViewModel;

    /// <summary>
    /// Creates <see cref="IAddRemove"/> controllers.
    /// </summary>
    public interface IAddRemoveFactory
    {
        /// <summary>
        /// Creates an <see cref="IAddRemove"/> controller which calls a custom <see cref="IItemProvider{TItem}"/> to
        /// add items and calls an <see cref="ISelection{TListItem}"/> instance to remove items from the specified
        /// item collection.
        /// </summary>
        /// <typeparam name="TItem">
        /// Type of the items in the collection
        /// </typeparam>
        IAddRemove CreateAddRemoveController<TItem>(
            Func<ICollection<TItem>> getItemCollectionFunc,
            IItemProvider<TItem> addItemProvider,
            ISelection<TItem> removeSelection)
            where TItem : class;

        /// <summary>
        /// Creates an <see cref="IAddRemove"/> controller which automatically creates a new default instance of
        /// <typeparamref name="TItem"/> to add and calls an <see cref="ISelection{TListItem}"/> instance to remove
        /// items from the specified item collection.
        /// </summary>
        /// <typeparam name="TItem">
        /// Type of the items in the collection
        /// </typeparam>
        IAddRemove CreateAddRemoveController<TItem>(
            Func<ICollection<TItem>> getItemCollectionFunc,
            ISelection<TItem> removeSelection)
            where TItem : class, new();

        /// <summary>
        /// Creates an <see cref="IAddRemove"/> controller which calls a custom <see cref="IItemProvider{TItem}"/> to
        /// add items and calls an <see cref="ISelection{TListItem}"/> instance to remove items from the specified
        /// item collection.
        /// The collection is retrieved from the specified property of the specified parent <see cref="IViewModel{TModel}"/>.
        /// </summary>
        /// <typeparam name="TItem">
        /// Type of the items in the collection
        /// </typeparam>
        IAddRemove CreateAddRemoveController<TParentItem, TItem>(
            IViewModel<TParentItem> parentViewModel,
            Func<TParentItem, ICollection<TItem>> getItemCollectionPropertyFunc,
            IItemProvider<TItem> addItemProvider,
            ISelection<TItem> removeSelection)
            where TParentItem : class
            where TItem : class;

        /// <summary>
        /// Creates an <see cref="IAddRemove"/> controller which automatically creates a new default instance of
        /// <typeparamref name="TItem"/> to add and calls an <see cref="ISelection{TListItem}"/> instance to remove
        /// items from the specified item collection.
        /// The collection is retrieved from the specified property of the specified parent <see cref="IViewModel{TModel}"/>.
        /// </summary>
        /// <typeparam name="TItem">
        /// Type of the items in the collection
        /// </typeparam>
        IAddRemove CreateAddRemoveController<TParentItem, TItem>(
            IViewModel<TParentItem> parentViewModel,
            Func<TParentItem, ICollection<TItem>> getItemCollectionPropertyFunc,
            ISelection<TItem> removeSelection)
            where TParentItem : class
            where TItem : class, new();
    }
}
