//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Guiuiui.ViewModel.List;

namespace Guiuiui.AddRemove
{
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
    }
}
